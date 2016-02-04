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

            //var path = @"C:\StickyNotes";

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            //if (Directory.GetFiles(path).Length > 0)
            //{
            //    var files = Directory.GetFiles(path);
            //    foreach (string fileName in files)
            //    {
            //        OpenNewForm();
            //    }
            //}
            //else
            //{
            //    this.Tag = Guid.NewGuid().ToString();
            //    this.textBox1.Tag = this.Tag;
            //}


            Application.Run(new Form1());
        }
    }
}
