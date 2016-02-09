using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class Form1 : Form
    {
        
        string path = @"C:\StickyNotes";
       
       //for dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;  
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
           
        }

        Reminder dlg = new Reminder(); // instantiating reminder class
        private DateTime myRemindTime; // variable to hold time until which form appears

        private void LblReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                myRemindTime = dlg.MyMonthCalendar.SelectionStart.AddHours(dlg.MyTimePicker.Value.Hour).AddMinutes(dlg.MyTimePicker.Value.Minute).AddSeconds(dlg.MyTimePicker.Value.Second);
                this.Visible = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myRemindTime.CompareTo(DateTime.Now) < 0)
            {
                this.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (null == this.Tag)
            {
                if (Directory.GetFiles(path).Length > 0)
                {
                    var files = Directory.GetFiles(path);
                    foreach (string fileName in files)
                    {
                        Form1 fm = new Form1();
                        var noteId = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                        noteId = noteId.Substring(0, noteId.LastIndexOf("."));
                        fm.Tag = noteId;
                        // fm.Width = 300;
                        fm.Show();
                    }
                }
                else
                {
                    this.Tag = Guid.NewGuid().ToString();
                    this.textBox1.Tag = this.Tag;
                }
            }
            else
            {
                this.textBox1.Tag = this.Tag;
                //Read the file 
                //File Path
                var filePath = path + @"\" + this.textBox1.Tag.ToString() + ".txt";
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                this.textBox1.Text = sr.ReadToEnd();
                sr.Close();

            }
        }

        private void OpenNewForm()
        {
            Form1 fm = new Form1();
            // fm.Width = 300;
            fm.Show();
        }
       
      
        StreamWriter sw;
       // StreamReader sr;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
            MessageBox.Show(textBox1.Text);
            //sr.Close();
            if (null == this.Tag)
            {
                this.Tag = Guid.NewGuid().ToString();
                this.textBox1.Tag = this.Tag;
            }
            sw = new StreamWriter(@"C:\StickyNotes\" + this.Tag + ".txt");
            sw.Write(textBox1.Text);
            sw.Close();

        }
                      
      
        private void AddNewForm_Click_1(object sender, EventArgs e)
        {
            {
                Form1 fm = new Form1();
                // fm.Width = 300;
                fm.Tag = Guid.NewGuid().ToString();

                fm.Show();
            }

        }

        private void DeleteForm_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Do you realy want to delete note?", "Exit",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var fileDelete = @"C:\StickyNotes\" + this.Tag + ".txt";
                   
                    {
                        if (File.Exists(fileDelete))
                        {
                            File.Delete(fileDelete);
                           
                        }
                    }

                    this.Close();
                    MessageBox.Show("File Deleted");
                }
                else
                {
                    MessageBox.Show("Cancel");
                    return;
                }
            }

        }

                      
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) //for dragging the form
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

               
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

       
     
        private void exitToolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

       
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                                            
    }
}
