namespace StickyNotes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LblReminder = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AddNew = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.DeleteForm = new System.Windows.Forms.Label();
            this.AddNewForm = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 189);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHide,
            this.fontToolStripMenuItem,
            this.ToolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ToolStripMenuItemHide
            // 
            this.ToolStripMenuItemHide.Name = "ToolStripMenuItemHide";
            this.ToolStripMenuItemHide.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemHide.Text = "Hide";
            this.ToolStripMenuItemHide.Click += new System.EventHandler(this.exitToolStripMenuItemHide_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // LblReminder
            // 
            this.LblReminder.AutoSize = true;
            this.LblReminder.LinkColor = System.Drawing.Color.Black;
            this.LblReminder.Location = new System.Drawing.Point(230, 228);
            this.LblReminder.Name = "LblReminder";
            this.LblReminder.Size = new System.Drawing.Size(83, 13);
            this.LblReminder.TabIndex = 1;
            this.LblReminder.TabStop = true;
            this.LblReminder.Text = "Remind me later";
            this.LblReminder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LblReminder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblReminder_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(0, 0);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(75, 23);
            this.AddNew.TabIndex = 6;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(0, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.DeleteForm);
            this.panel1.Controls.Add(this.AddNewForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 30);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(270, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(14, 13);
            this.Minimize.TabIndex = 7;
            this.Minimize.Text = "_";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(299, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(13, 13);
            this.Close.TabIndex = 8;
            this.Close.Text = "x";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DeleteForm
            // 
            this.DeleteForm.AutoSize = true;
            this.DeleteForm.ForeColor = System.Drawing.Color.Red;
            this.DeleteForm.Image = global::StickyNotes.Properties.Resources.delete_13;
            this.DeleteForm.Location = new System.Drawing.Point(63, 8);
            this.DeleteForm.Name = "DeleteForm";
            this.DeleteForm.Size = new System.Drawing.Size(12, 13);
            this.DeleteForm.TabIndex = 1;
            this.DeleteForm.Text = "x";
            this.DeleteForm.Click += new System.EventHandler(this.DeleteForm_Click);
            // 
            // AddNewForm
            // 
            this.AddNewForm.AutoSize = true;
            this.AddNewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewForm.ForeColor = System.Drawing.Color.Green;
            this.AddNewForm.Image = global::StickyNotes.Properties.Resources.add_9;
            this.AddNewForm.Location = new System.Drawing.Point(23, 8);
            this.AddNewForm.Name = "AddNewForm";
            this.AddNewForm.Size = new System.Drawing.Size(14, 13);
            this.AddNewForm.TabIndex = 0;
            this.AddNewForm.Text = "+";
            this.AddNewForm.Click += new System.EventHandler(this.AddNewForm_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(325, 250);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.LblReminder);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel LblReminder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AddNew;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHide;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewForm;
        private System.Windows.Forms.Label DeleteForm;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Close;
    }
}

