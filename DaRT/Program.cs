using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;

namespace DaRT
{
    static class Program
    {
        static String version = "v2.1";
        static GUImain gui;
        static StreamWriter writer;

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();

        static void CatchThreadException(object sender, ThreadExceptionEventArgs e)
        {
            new GUIcrash(e.Exception, version, gui).ShowDialog();
        }

        static void CatchUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            new GUIcrash(e.ExceptionObject as Exception, version, gui).ShowDialog();
        }

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                if (Debugger.IsAttached)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    gui = new GUImain(version);
                    Application.Run(gui);
                    return;
                }
                Application.ThreadException += CatchThreadException;
                AppDomain.CurrentDomain.UnhandledException += CatchUnhandledException;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                gui = new GUImain(version);
                Application.Run(gui);
            }
            else
            {
                AllocConsole();

                #region Read Config
                String ip = "127.0.0.1";
                int port = 2302;
                String password = "password";
                String command = "";
                String output = "";
                String script = "";
                int loop = 0;
                bool close = false;

                foreach (String arg in args)
                {
                    if (arg.StartsWith("-ip="))
                    {
                        ip = arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1]; ;
                    }
                    else if (arg.StartsWith("-port="))
                    {
                        try
                        {
                            port = Int32.Parse(arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1]);
                        }
                        catch
                        {
                            port = 2302;
                        }
                    }
                    else if (arg.StartsWith("-password=") || arg.StartsWith("-pass=") || arg.StartsWith("-pw="))
                    {
                        password = arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    else if (arg.StartsWith("-command="))
                    {
                        command = arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    else if (arg.StartsWith("-output="))
                    {
                        output = arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    else if(arg.StartsWith("-close"))
                    {
                        close = true;
                    }
                    else if (arg.StartsWith("-script="))
                    {
                        script = arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    else if (arg.StartsWith("-loop="))
                    {
                        loop = Int32.Parse(arg.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1]);
                    }
                }
                #endregion

                #region Establish Connection
                RCon rcon = new RCon(null);
                rcon.Connect(IPAddress.Parse(ip), port, password);
                #endregion

                #region Writing header
                if (output != "")
                    writer = File.CreateText(output);

                Write("DaRT " + version + " - DayZ RCon Tool");
                if (command != "")
                    Write("Running in command mode.");
                else if (script != "")
                    Write("Running in script mode.");
                Write("---------------------");
                Write("Supplied arguments:");
                foreach (String arg in args)
                {
                    Write(arg);
                }
                Write("---------------------");
                Write("Output:");
                #endregion

                if (command != "")
                {
                    #region Command mode
                    if (command == "players")
                    {
                        List<String> players = rcon.getRawPlayers();
                        foreach (String player in players)
                            Write(player);
                    }
                    else if (command == "bans")
                    {
                        List<String> bans = rcon.getRawBans();
                        foreach (String ban in bans)
                            Write(ban);
                    }
                    else if (command == "admins")
                    {
                        List<String> admins = rcon.getRawAdmins();
                        foreach (String admin in admins)
                            Write(admin);
                    }
                    else
                    {
                        rcon.execute(command);
                        Write("Command executed successfully!");
                    }
                    #endregion
                }
                else if (script != "")
                {
                    #region Script mode
                    Write("Running " + script);

                    String[] lines = File.ReadAllLines(script);
                    List<String> commands = new List<String>();

                    foreach (String line in lines)
                    {
                        if (line != "")
                        {
                            if (!line.StartsWith("//"))
                            {
                                commands.Add(line);
                            }
                        }
                    }

                    bool looping = true;
                    int run = 0;
                    do
                    {
                        foreach (String c in commands)
                        {
                            if (c.StartsWith("wait="))
                            {
                                int amount = Int32.Parse(c.Split('=')[1]);
                                Write("Waiting " + (amount / 1000) + "s");
                                Thread.Sleep(amount);
                                continue;
                            }
                            else if (c.StartsWith("exit") || c.StartsWith("quit") || c.StartsWith("close"))
                            {
                                Write("Stopped script.");
                                break;
                            }

                            String exec = c;

                            int players;
                            int admins;
                            int bans;
                            String randomPlayer;
                            if (c.Contains("%p"))
                            {
                                players = rcon.getPlayers().Count;
                                exec = c.Replace("%p", players.ToString());
                            }
                            if (c.Contains("%a"))
                            {
                                admins = rcon.getAdmins();
                                exec = c.Replace("%a", admins.ToString());
                            }
                            if (c.Contains("%b"))
                            {
                                bans = rcon.getBans().Count;
                                exec = c.Replace("%b", bans.ToString());
                            }
                            if (c.Contains("%r"))
                            {
                                List<Player> p = rcon.getPlayers();
                                if (p.Count > 0)
                                {
                                    Random random = new Random();
                                    randomPlayer = p[random.Next(0, p.Count)].name;
                                    exec = c.Replace("%r", randomPlayer);
                                }
                            }
                            if (c.Contains("%l"))
                            {
                                exec = c.Replace("%l", run.ToString());
                            }

                            if (c.StartsWith("if"))
                            {
                                String[] items = exec.Split(new char[] { ':' }, 3, StringSplitOptions.RemoveEmptyEntries);

                                String[] flags = items[0].Split(new char[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
                                String param1 = flags[1];
                                String op = flags[2];
                                String param2 = flags[3];

                                bool fulfilled = false;

                                if (op == ">")
                                {
                                    if (Int32.Parse(param1) > Int32.Parse(param2))
                                        fulfilled = true;
                                }
                                else if (op == "<")
                                {
                                    if (Int32.Parse(param1) < Int32.Parse(param2))
                                        fulfilled = true;
                                }
                                else if (op == "=" || op == "==")
                                {
                                    if (param1 == param2)
                                        fulfilled = true;
                                }
                                else
                                {
                                }

                                if (fulfilled)
                                    exec = items[1];
                                else if (items.Length == 3)
                                    exec = items[2];
                                else
                                    continue;
                            }

                            if (exec.StartsWith("kickAll"))
                            {
                                Write("Kicking all players...");
                                String reason;
                                if (exec.Contains("="))
                                    reason = exec.Split('=')[1];
                                else
                                    reason = "Admin Kick";

                                List<Player> p = rcon.getPlayers();

                                foreach (Player player in p)
                                {
                                    rcon.kick(new Kick(player.number, player.name, reason));
                                }
                            }
                            else if (exec.StartsWith("banAll"))
                            {
                                Write("Banning all players...");
                                String reason;
                                if (exec.Contains("="))
                                    reason = exec.Split('=')[1];
                                else
                                    reason = "Admin Ban";

                                List<Player> p = rcon.getPlayers();

                                foreach (Player player in p)
                                {
                                    rcon.Ban(new Ban(player.number.ToString(), player.name, "0", reason));
                                }
                            }
                            else if (exec.StartsWith("exec"))
                            {
                                String execute = exec.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
                                Write(execute);
                                rcon.execute(execute);
                            }
                        }

                        if (run == loop)
                            looping = false;

                        if (loop != -1)
                            run++;
                    } while (looping);
                    #endregion
                }
                else
                {
                    Write("You need to run atleast one command or one script.");
                }
                
                rcon.Disconnect();
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                }
                if (!close)
                {
                    Console.WriteLine("All done. Press any key to close.");
                    Console.ReadKey();
                    Console.WriteLine("Closing...");
                }
            }
        }
        private static void Write(String line)
        {
            Console.WriteLine(line);
            if (writer != null)
            {
                writer.WriteLine(line.ToString());
            }
        }
    }
}
