namespace PassGenerator
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
            this.wordsCB = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numCB = new System.Windows.Forms.CheckBox();
            this.specCB = new System.Windows.Forms.CheckBox();
            this.lettersCB = new System.Windows.Forms.CheckBox();
            this.SecureCB = new System.Windows.Forms.CheckBox();
            this.wordAmtUD = new System.Windows.Forms.NumericUpDown();
            this.letAmtUD = new System.Windows.Forms.NumericUpDown();
            this.numAmtUD = new System.Windows.Forms.NumericUpDown();
            this.specAmtUD = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notLoadedWarning = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordAmtUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letAmtUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmtUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specAmtUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordsCB
            // 
            this.wordsCB.AutoSize = true;
            this.wordsCB.Location = new System.Drawing.Point(13, 44);
            this.wordsCB.Name = "wordsCB";
            this.wordsCB.Size = new System.Drawing.Size(57, 17);
            this.wordsCB.TabIndex = 0;
            this.wordsCB.Text = "&Words";
            this.wordsCB.UseVisualStyleBackColor = true;
            this.wordsCB.CheckedChanged += new System.EventHandler(this.wordsCB_CheckedChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 163);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your password is:";
            // 
            // numCB
            // 
            this.numCB.AutoSize = true;
            this.numCB.Location = new System.Drawing.Point(13, 92);
            this.numCB.Name = "numCB";
            this.numCB.Size = new System.Drawing.Size(68, 17);
            this.numCB.TabIndex = 4;
            this.numCB.Text = "&Numbers";
            this.numCB.UseVisualStyleBackColor = true;
            this.numCB.CheckedChanged += new System.EventHandler(this.numCB_CheckedChanged);
            // 
            // specCB
            // 
            this.specCB.AutoSize = true;
            this.specCB.Location = new System.Drawing.Point(13, 117);
            this.specCB.Name = "specCB";
            this.specCB.Size = new System.Drawing.Size(115, 17);
            this.specCB.TabIndex = 6;
            this.specCB.Text = "Special &Characters";
            this.specCB.UseVisualStyleBackColor = true;
            this.specCB.CheckedChanged += new System.EventHandler(this.specCB_CheckedChanged);
            // 
            // lettersCB
            // 
            this.lettersCB.AutoSize = true;
            this.lettersCB.Location = new System.Drawing.Point(13, 67);
            this.lettersCB.Name = "lettersCB";
            this.lettersCB.Size = new System.Drawing.Size(85, 17);
            this.lettersCB.TabIndex = 2;
            this.lettersCB.Text = "Extra &Letters";
            this.lettersCB.UseVisualStyleBackColor = true;
            this.lettersCB.CheckedChanged += new System.EventHandler(this.lettersCB_CheckedChanged);
            // 
            // SecureCB
            // 
            this.SecureCB.AutoSize = true;
            this.SecureCB.Location = new System.Drawing.Point(13, 140);
            this.SecureCB.Name = "SecureCB";
            this.SecureCB.Size = new System.Drawing.Size(60, 17);
            this.SecureCB.TabIndex = 8;
            this.SecureCB.Text = "&Secure";
            this.SecureCB.UseVisualStyleBackColor = true;
            this.SecureCB.CheckedChanged += new System.EventHandler(this.SecureCB_CheckedChanged);
            // 
            // wordAmtUD
            // 
            this.wordAmtUD.Enabled = false;
            this.wordAmtUD.Location = new System.Drawing.Point(76, 44);
            this.wordAmtUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.wordAmtUD.Name = "wordAmtUD";
            this.wordAmtUD.Size = new System.Drawing.Size(40, 20);
            this.wordAmtUD.TabIndex = 1;
            // 
            // letAmtUD
            // 
            this.letAmtUD.Enabled = false;
            this.letAmtUD.Location = new System.Drawing.Point(105, 67);
            this.letAmtUD.Name = "letAmtUD";
            this.letAmtUD.Size = new System.Drawing.Size(40, 20);
            this.letAmtUD.TabIndex = 3;
            // 
            // numAmtUD
            // 
            this.numAmtUD.Enabled = false;
            this.numAmtUD.Location = new System.Drawing.Point(87, 92);
            this.numAmtUD.Name = "numAmtUD";
            this.numAmtUD.Size = new System.Drawing.Size(40, 20);
            this.numAmtUD.TabIndex = 5;
            // 
            // specAmtUD
            // 
            this.specAmtUD.Enabled = false;
            this.specAmtUD.Location = new System.Drawing.Point(133, 115);
            this.specAmtUD.Name = "specAmtUD";
            this.specAmtUD.Size = new System.Drawing.Size(40, 20);
            this.specAmtUD.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // notLoadedWarning
            // 
            this.notLoadedWarning.AutoSize = true;
            this.notLoadedWarning.ForeColor = System.Drawing.Color.Red;
            this.notLoadedWarning.Location = new System.Drawing.Point(10, 189);
            this.notLoadedWarning.Name = "notLoadedWarning";
            this.notLoadedWarning.Size = new System.Drawing.Size(197, 13);
            this.notLoadedWarning.TabIndex = 12;
            this.notLoadedWarning.Text = "Warning:  Files have not loaded properly";
            this.notLoadedWarning.Visible = false;
            // 
            // passBox
            // 
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Location = new System.Drawing.Point(13, 229);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.Size = new System.Drawing.Size(278, 60);
            this.passBox.TabIndex = 10;
            this.passBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 301);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.notLoadedWarning);
            this.Controls.Add(this.wordAmtUD);
            this.Controls.Add(this.specAmtUD);
            this.Controls.Add(this.numAmtUD);
            this.Controls.Add(this.letAmtUD);
            this.Controls.Add(this.SecureCB);
            this.Controls.Add(this.lettersCB);
            this.Controls.Add(this.specCB);
            this.Controls.Add(this.numCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.wordsCB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 340);
            this.Name = "Form1";
            this.Text = "Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wordAmtUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letAmtUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmtUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specAmtUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox wordsCB;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox numCB;
        private System.Windows.Forms.CheckBox specCB;
        private System.Windows.Forms.CheckBox lettersCB;
        private System.Windows.Forms.CheckBox SecureCB;
        private System.Windows.Forms.NumericUpDown wordAmtUD;
        private System.Windows.Forms.NumericUpDown letAmtUD;
        private System.Windows.Forms.NumericUpDown numAmtUD;
        private System.Windows.Forms.NumericUpDown specAmtUD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label notLoadedWarning;
        private System.Windows.Forms.TextBox passBox;
    }
}

