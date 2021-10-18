using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases
{
public static  class Helpers
    {
        public static Bitmap GetFlag(string country)
        {
            Bitmap flag;
            switch (country)
            {
                case "Brazil":
                case "Brasil":
                case "brasil":
                case "brazil":
                    flag = new Bitmap(Properties.Resources.brazil);
                    break;
                case "Argentina":
                case "argentina":
                case "Argentine":
                case "argentine":
                    flag = new Bitmap(Properties.Resources.Argentina);
                    break;
                case "Chile":
                case "chile":
                    flag = new Bitmap(Properties.Resources.Chile);
                    break;
                case "Canada":
                case "canada":
                    flag = new Bitmap(Properties.Resources.Canada);
                    break;
                default:
                    flag = new Bitmap(Properties.Resources.globe);
                    break;
            }
            return flag;
        }
    }
}
