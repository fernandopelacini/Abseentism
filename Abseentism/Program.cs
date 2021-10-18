using Abseentism.Clases;
using Abseentism.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AutoMapper;
using Abseentism.Forms;
using System.Web.Services.Description;


namespace Abseentism
{
    static class Program
    {

        private static AbseentismEntities _context;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
  //          AutoMapperConfiguration.Configure();
            Application.Run(new MDIMain ());
        }
    }
}
