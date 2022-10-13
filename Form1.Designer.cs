namespace Lab1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_button = new Lab1._1.RoundButton();
            this.exit_button = new Lab1._1.RoundButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.checkContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 32);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Yellow;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.Yellow;
            this.minimize_button.Location = new System.Drawing.Point(328, 8);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(16, 16);
            this.minimize_button.TabIndex = 17;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.IndianRed;
            this.exit_button.Location = new System.Drawing.Point(354, 8);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(16, 16);
            this.exit_button.TabIndex = 16;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 29);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageMenuStrip,
            this.checkContextMenuStrip,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // messageMenuStrip
            // 
            this.messageMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.messageMenuStrip.ForeColor = System.Drawing.Color.IndianRed;
            this.messageMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("messageMenuStrip.Image")));
            this.messageMenuStrip.Name = "messageMenuStrip";
            this.messageMenuStrip.ShortcutKeyDisplayString = "";
            this.messageMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.messageMenuStrip.Size = new System.Drawing.Size(209, 26);
            this.messageMenuStrip.Text = "Message";
            this.messageMenuStrip.Click += new System.EventHandler(this.messageMenuStrip_Click);
            // 
            // checkContextMenuStrip
            // 
            this.checkContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.checkContextMenuStrip.CheckOnClick = true;
            this.checkContextMenuStrip.ForeColor = System.Drawing.Color.IndianRed;
            this.checkContextMenuStrip.Name = "checkContextMenuStrip";
            this.checkContextMenuStrip.ShortcutKeyDisplayString = "";
            this.checkContextMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkContextMenuStrip.Size = new System.Drawing.Size(209, 26);
            this.checkContextMenuStrip.Text = "Check";
            this.checkContextMenuStrip.Click += new System.EventHandler(this.checkMenuStrip_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Checked = true;
            this.sizeToolStripMenuItem.CheckOnClick = true;
            this.sizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.sizeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem2.Text = "50%";
            this.toolStripMenuItem2.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem3.Text = "75%";
            this.toolStripMenuItem3.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // line_label
            // 
            this.line_label.BackColor = System.Drawing.Color.IndianRed;
            this.line_label.Location = new System.Drawing.Point(0, 32);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(380, 1);
            this.line_label.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem1,
            this.checkMenuStrip,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 82);
            // 
            // messageToolStripMenuItem1
            // 
            this.messageToolStripMenuItem1.ForeColor = System.Drawing.Color.IndianRed;
            this.messageToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("messageToolStripMenuItem1.Image")));
            this.messageToolStripMenuItem1.Name = "messageToolStripMenuItem1";
            this.messageToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.messageToolStripMenuItem1.Size = new System.Drawing.Size(209, 26);
            this.messageToolStripMenuItem1.Text = "Message";
            this.messageToolStripMenuItem1.Click += new System.EventHandler(this.messageContextMenuStrip_Click);
            // 
            // checkMenuStrip
            // 
            this.checkMenuStrip.CheckOnClick = true;
            this.checkMenuStrip.ForeColor = System.Drawing.Color.IndianRed;
            this.checkMenuStrip.Name = "checkMenuStrip";
            this.checkMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkMenuStrip.Size = new System.Drawing.Size(209, 26);
            this.checkMenuStrip.Text = "Check";
            this.checkMenuStrip.Click += new System.EventHandler(this.checkContextMenuStrip_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.IndianRed;
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(209, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sd";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton exit_button;
        private RoundButton minimize_button;
        private Label line_label;

        private Panel panel1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem messageMenuStrip;
        private ToolStripMenuItem checkContextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem messageToolStripMenuItem1;
        private ToolStripMenuItem checkMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}