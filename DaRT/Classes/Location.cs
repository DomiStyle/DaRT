using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DaRT
{
    public class Location
    {
        public String location = "";
        public Image flag = null;

        public Location(String location, Image flag)
        {
            this.location = location;
            this.flag = flag;
        }
    }
}
