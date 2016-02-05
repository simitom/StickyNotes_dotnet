using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StickyNotes
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //startup(true);
            Application.Run(new Form1());
           
        }

            //private static void startup(bool add)
            //{
            //  // isinstartup = add;
            //   RegistryKey key = Registry.CurrentUser.OpenSubKey(
            //              @"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //   if (add)
            //   {
            //    //Surround path with " " to make sure that there are no problems
            //    //if path contains spaces.
            //    key.SetValue("Tray minimizer", "\"" + Application.ExecutablePath + "\"");
            //   }
            //   else
            //    key.DeleteValue("Tray minimizer");

            //   key.Close();
            //}

        }
}
