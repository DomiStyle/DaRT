using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DaRT.Properties;
using System.Diagnostics;

namespace DaRT
{
    public partial class GUIsettings : Form
    {
        private GUImain gui = null;
        private Font font;

        public GUIsettings(GUImain gui)
        {
            InitializeComponent();

            this.gui = gui;

            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 30000;

            tooltip.SetToolTip(savePlayers, "Should DaRT store all players in a database?");
            tooltip.SetToolTip(saveHosts, "Should DaRT save the hosts you connected to?");
            tooltip.SetToolTip(showTimestamps, "Would you like to have timestamps in your log window?");
            tooltip.SetToolTip(colorChat, "Should the chat be colored in all tab?");
            tooltip.SetToolTip(colorFilters, "Should the filter logs be colored in all tab?");
            tooltip.SetToolTip(refreshOnJoin, "Do you want DaRT to automatically refresh everytime a player joins or leaves?");
            tooltip.SetToolTip(showGlobalChat, "Should the global chat be shown in your log?\r\nIMPORTANT: The global chat will always be transmitted to the server.");
            tooltip.SetToolTip(showSideChat, "Should the side chat be shown in your log?\r\nIMPORTANT: The side chat will only be transmitted to the server if atleast two players are online and in the same team.");
            tooltip.SetToolTip(showDirectChat, "Should the direct chat be shown in your log?\r\nIMPORTANT: Direct chat will only be transmitted to the server if atleast two players are in a range of 40 meters.");
            tooltip.SetToolTip(showVehicleChat, "Should the vehicle chat be shown in your log?\r\nIMPORTANT: Vehicle chat will only be transmitted to the server if atleast two players are in the same vehicle.");
            tooltip.SetToolTip(showCommandChat, "Should the command chat be shown in your log?");
            tooltip.SetToolTip(showUnknownChat, "Should any unknown chat be shown?\r\n(Unknown chats are usually added by mission. For example: Altis Life)");
            tooltip.SetToolTip(showGroupChat, "Should the group chat be shown in your log?\r\nIMPOTANT: Two players are required in order for this channel to be transmitted to the server.");
            tooltip.SetToolTip(showConnectMessages, "If checked, DaRT will show confirmation messages when you are connecting, disconnecting or reconnecting.");
            tooltip.SetToolTip(showDebug, "Should debug messages be enabled? Enable this if you want to send me a error report, so I can see what is going on.");
            tooltip.SetToolTip(showPlayerConnectMessages, "If checked connecting and disconnecting players will be shown.");
            tooltip.SetToolTip(showRefreshMessages, "Should DaRT give you a confirmation on each refresh?");
            tooltip.SetToolTip(showVerificationMessages, "Show verification messages for players? (Verfied GUID of...)");
            tooltip.SetToolTip(showAdminMessages, "Show admin logins?");
            tooltip.SetToolTip(showAdminChat, "Show global admin chat in log?");
            tooltip.SetToolTip(saveLog, "Should DaRT save a log file to console.txt?");
            tooltip.SetToolTip(requestOnConnect, "If checked, DaRT will automatically request your player and ban list on connecting to a server.");
            tooltip.SetToolTip(showAdminCalls, "Should DaRT highlight calls for admins in chat?");
            tooltip.SetToolTip(useNameForAdminCalls, "Should DaRT use your own name (set above) for admin calls? (for example: I need help, <yourname>!)");
            tooltip.SetToolTip(flash, "Should DaRT flash its window when a admin call was detected?");
            tooltip.SetToolTip(dartbrs, "Is a Ban Relay Server configured on the server?\r\nCheck DaRT thread for more details.");
            tooltip.SetToolTip(quickBan, "The duration a player is banned for when using the Quick Ban feature.");
            tooltip.SetToolTip(interval, "The time betweeen automatic refreshes.");
            tooltip.SetToolTip(playerTicks, "This is the tick amount that DaRT waits for a response from the server to arrive when requesting the player list.\r\n(lower = faster but unreliable)\r\n(higher = slower but more reliable)");
            tooltip.SetToolTip(banTicks, "This is the tick amount that DaRT waits for a response from the server to arrive when requesting the ban list.\r\n(lower = faster but unreliable)\r\n(higher = slower but more reliable)\r\n(should usually be higher then player ticks)");
            tooltip.SetToolTip(name, "Your name to be used when you chat ingame.\r\nfor example: [Name]: Your message here\r\nLeave empty to disable.");
            tooltip.SetToolTip(connectOnStartup, "If checked, DaRT will automatically connect to your last server on startup.");

            tooltip.SetToolTip(fontChooser, "You can choose a custom font for your log here.");

            savePlayers.Checked = Settings.Default.savePlayers;
            saveHosts.Checked = Settings.Default.saveHosts;
            showTimestamps.Checked = Settings.Default.showTimestamps;
            colorChat.Checked = Settings.Default.colorChat;
            colorFilters.Checked = Settings.Default.colorFilters;
            refreshOnJoin.Checked = Settings.Default.refreshOnJoin;
            showGlobalChat.Checked = Settings.Default.showGlobalChat;
            showSideChat.Checked = Settings.Default.showSideChat;
            showDirectChat.Checked = Settings.Default.showDirectChat;
            showVehicleChat.Checked = Settings.Default.showVehicleChat;
            showCommandChat.Checked = Settings.Default.showCommandChat;
            showGroupChat.Checked = Settings.Default.showGroupChat;
            showUnknownChat.Checked = Settings.Default.showUnknownChat;
            showConnectMessages.Checked = Settings.Default.showConnectMessages;
            showDebug.Checked = Settings.Default.showDebug;
            showPlayerConnectMessages.Checked = Settings.Default.showPlayerConnectMessages;
            showRefreshMessages.Checked = Settings.Default.showRefreshMessages;
            showVerificationMessages.Checked = Settings.Default.showVerificationMessages;
            showAdminMessages.Checked = Settings.Default.showAdminMessages;
            showAdminChat.Checked = Settings.Default.showAdminChat;
            saveLog.Checked = Settings.Default.saveLog;
            requestOnConnect.Checked = Settings.Default.requestOnConnect;
            showAdminCalls.Checked = Settings.Default.showAdminCalls;
            useNameForAdminCalls.Checked = Settings.Default.useNameForAdminCalls;
            flash.Checked = Settings.Default.flash;
            dartbrs.Checked = Settings.Default.dartbrs;
            quickBan.Text = Settings.Default.quickBan.ToString();
            interval.Text = Settings.Default.interval.ToString();
            playerTicks.Text = Settings.Default.playerTicks.ToString();
            banTicks.Text = Settings.Default.banTicks.ToString();
            buffer.Text = Settings.Default.buffer.ToString();
            name.Text = Settings.Default.name;
            connectOnStartup.Checked = Settings.Default.connectOnStartup;

            showLogErrors.Checked = Settings.Default.showLogErrors;
            showScriptsLog.Checked = Settings.Default.showScriptsLog;
            showCreateVehicleLog.Checked = Settings.Default.showCreateVehicleLog;
            showDeleteVehicleLog.Checked = Settings.Default.showDeleteVehicleLog;
            showPublicVariableLog.Checked = Settings.Default.showPublicVariableLog;
            showPublicVariableValLog.Checked = Settings.Default.showPublicVariableValLog;
            showRemoteExecLog.Checked = Settings.Default.showRemoteExecLog;
            showRemoteControlLog.Checked = Settings.Default.showRemoteControlLog;
            showSetDamageLog.Checked = Settings.Default.showSetDamageLog;
            showSetPosLog.Checked = Settings.Default.showSetPosLog;
            showSetVariableLog.Checked = Settings.Default.showSetVariableLog;
            showSetVariableValLog.Checked = Settings.Default.showSetVariableValLog;
            showAddBackpackCargoLog.Checked = Settings.Default.showAddBackpackCargoLog;
            showAddMagazineCargoLog.Checked = Settings.Default.showAddMagazineCargoLog;
            showAddWeaponCargoLog.Checked = Settings.Default.showAddWeaponCargoLog;
            showAttachToLog.Checked = Settings.Default.showAttachToLog;
            showMPEventHandlerLog.Checked = Settings.Default.showMPEventHandlerLog;
            showSelectPlayerLog.Checked = Settings.Default.showSelectPlayerLog;
            showTeamSwitchLog.Checked = Settings.Default.showTeamSwitchLog;
            showWaypointConditionLog.Checked = Settings.Default.showWaypointConditionLog;
            showWaypointStatementLog.Checked = Settings.Default.showWaypointStatementLog;
            filters.Text = Settings.Default.filters;

            font = Settings.Default.font;
        }

        private void done_Click(object sender, EventArgs e)
        {
            Settings.Default.savePlayers = savePlayers.Checked;
            Settings.Default.saveHosts = saveHosts.Checked;
            Settings.Default.showTimestamps = showTimestamps.Checked;
            Settings.Default.colorChat = colorChat.Checked;
            Settings.Default.colorFilters = colorFilters.Checked;
            Settings.Default.refreshOnJoin = refreshOnJoin.Checked;
            Settings.Default.showGlobalChat = showGlobalChat.Checked;
            Settings.Default.showSideChat = showSideChat.Checked;
            Settings.Default.showDirectChat = showDirectChat.Checked;
            Settings.Default.showVehicleChat = showVehicleChat.Checked;
            Settings.Default.showCommandChat = showCommandChat.Checked;
            Settings.Default.showGroupChat = showGroupChat.Checked;
            Settings.Default.showUnknownChat = showUnknownChat.Checked;
            Settings.Default.showConnectMessages = showConnectMessages.Checked;
            Settings.Default.showDebug = showDebug.Checked;
            Settings.Default.showPlayerConnectMessages = showPlayerConnectMessages.Checked;
            Settings.Default.showRefreshMessages = showRefreshMessages.Checked;
            Settings.Default.showVerificationMessages = showVerificationMessages.Checked;
            Settings.Default.showAdminMessages = showAdminMessages.Checked;
            Settings.Default.showAdminChat = showAdminChat.Checked;
            Settings.Default.saveLog = saveLog.Checked;
            Settings.Default.requestOnConnect = requestOnConnect.Checked;
            Settings.Default.showAdminCalls = showAdminCalls.Checked;
            Settings.Default.useNameForAdminCalls = useNameForAdminCalls.Checked;
            Settings.Default.flash = flash.Checked;
            Settings.Default.dartbrs = dartbrs.Checked;
            Settings.Default.connectOnStartup = connectOnStartup.Checked;

            Settings.Default.showLogErrors = showLogErrors.Checked;
            Settings.Default.showScriptsLog = showScriptsLog.Checked;
            Settings.Default.showCreateVehicleLog = showCreateVehicleLog.Checked;
            Settings.Default.showDeleteVehicleLog = showDeleteVehicleLog.Checked;
            Settings.Default.showPublicVariableLog = showPublicVariableLog.Checked;
            Settings.Default.showPublicVariableValLog = showPublicVariableValLog.Checked;
            Settings.Default.showRemoteExecLog = showRemoteExecLog.Checked;
            Settings.Default.showRemoteControlLog = showRemoteControlLog.Checked;
            Settings.Default.showSetDamageLog = showSetDamageLog.Checked;
            Settings.Default.showSetPosLog = showSetPosLog.Checked;
            Settings.Default.showSetVariableLog = showSetVariableLog.Checked;
            Settings.Default.showSetVariableValLog = showSetVariableValLog.Checked;
            Settings.Default.showAddBackpackCargoLog = showAddBackpackCargoLog.Checked;
            Settings.Default.showAddMagazineCargoLog = showAddMagazineCargoLog.Checked;
            Settings.Default.showAddWeaponCargoLog = showAddWeaponCargoLog.Checked;
            Settings.Default.showAttachToLog = showAttachToLog.Checked;
            Settings.Default.showMPEventHandlerLog = showMPEventHandlerLog.Checked;
            Settings.Default.showSelectPlayerLog = showSelectPlayerLog.Checked;
            Settings.Default.showTeamSwitchLog = showTeamSwitchLog.Checked;
            Settings.Default.showWaypointConditionLog = showWaypointConditionLog.Checked;
            Settings.Default.showWaypointStatementLog = showWaypointStatementLog.Checked;
            Settings.Default.filters = filters.Text;

            Settings.Default.name = name.Text;
            Settings.Default.font = font;

            try
            {
                Settings.Default.quickBan = int.Parse(quickBan.Text);
                Settings.Default.interval = UInt32.Parse(interval.Text);
                Settings.Default.playerTicks = UInt32.Parse(playerTicks.Text);
                Settings.Default.banTicks = UInt32.Parse(banTicks.Text);
                Settings.Default.buffer = UInt32.Parse(buffer.Text);
            }
            catch
            {
                gui.Log("An error occurred while applying the settings.", LogType.Debug, false);
            }
            Settings.Default.Save();

            this.Close();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fontChooser_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = font;

            DialogResult result = fontDialog.ShowDialog();
            
            if (result == DialogResult.OK)
                font = fontDialog.Font;
        }

        private void dartthread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://forums.dayzgame.com/index.php?/topic/68933-dart-a-lightweight-dayz-rcon-tool-v101-26062013/?p=658483");
        }

        private void dart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/DomiStyle/DaRT");
        }
        private void battlenet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/marceldev89/BattleNET");
        }

        private void epm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://forums.dayzgame.com/index.php?/topic/170620-epm-rcon-tool-0996-changelog-and-information/?p=1736050");
        }
    }
}
