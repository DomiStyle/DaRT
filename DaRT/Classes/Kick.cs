using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaRT
{
    public class Kick
    {
        public int id;
        public String name;
        public String reason;

        public Kick(int id, String name, String reason)
        {
            this.id = id;
            this.name = name;
            this.reason = reason;
        }
    }
}