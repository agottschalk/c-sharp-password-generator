namespace PassGenerator
{
    partial class ExtraSettingsForm
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
            this.useSpecsCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secPassNumChars = new System.Windows.Forms.NumericUpDown();
            this.secureSettGB = new System.Windows.Forms.GroupBox();
            this.simpleSettGB = new System.Windows.Forms.GroupBox();
            this.capitalsCB = new System.Windows.Forms.CheckBox();
            this.settSaveB = new System.Windows.Forms.Button();
            this.settCancelB = new System.Windows.Forms.Button();
            this.settDefaultB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secPassNumChars)).BeginInit();
            this.secureSettGB.SuspendLayout();
            this.simpleSettGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // useSpecsCB
            // 
            this.useSpecsCB.AutoSize = true;
            this.useSpecsCB.Location = new System.Drawing.Point(6, 48);
            this.useSpecsCB.Name = "useSpecsCB";
            this.useSpecsCB.Size = new System.Drawing.Size(254, 43);
            this.useSpecsCB.TabIndex = 0;
            this.useSpecsCB.Text = "Use special characters when generating secure \r\npasswords (harder to remember but" +
    " also harder \r\nto crack)";
            this.useSpecsCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Characters in secure password";
            // 
            // secPassNumChars
            // 
            this.secPassNumChars.Location = new System.Drawing.Point(164, 25);
            this.secPassNumChars.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.secPassNumChars.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.secPassNumChars.Name = "secPassNumChars";
            this.secPassNumChars.Size = new System.Drawing.Size(45, 20);
            this.secPassNumChars.TabIndex = 2;
            this.secPassNumChars.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // secureSettGB
            // 
            this.secureSettGB.Controls.Add(this.useSpecsCB);
            this.secureSettGB.Controls.Add(this.secPassNumChars);
            this.secureSettGB.Controls.Add(this.label1);
            this.secureSettGB.Location = new System.Drawing.Point(12, 100);
            this.secureSettGB.Name = "secureSettGB";
            this.secureSettGB.Size = new System.Drawing.Size(274, 109);
            this.secureSettGB.TabIndex = 3;
            this.secureSettGB.TabStop = false;
            this.secureSettGB.Text = "Secure";
            // 
            // simpleSettGB
            // 
            this.simpleSettGB.Controls.Add(this.capitalsCB);
            this.simpleSettGB.Location = new System.Drawing.Point(12, 12);
            this.simpleSettGB.Name = "simpleSettGB";
            this.simpleSettGB.Size = new System.Drawing.Size(274, 82);
            this.simpleSettGB.TabIndex = 4;
            this.simpleSettGB.TabStop = false;
            this.simpleSettGB.Text = "Simple";
            // 
            // capitalsCB
            // 
            this.capitalsCB.AutoSize = true;
            this.capitalsCB.Location = new System.Drawing.Point(9, 20);
            this.capitalsCB.Name = "capitalsCB";
            this.capitalsCB.Size = new System.Drawing.Size(224, 30);
            this.capitalsCB.TabIndex = 0;
            this.capitalsCB.Text = "Include capitals when adding extra letters \r\nto password";
            this.capitalsCB.UseVisualStyleBackColor = true;
            // 
            // settSaveB
            // 
            this.settSaveB.Location = new System.Drawing.Point(129, 227);
            this.settSaveB.Name = "settSaveB";
            this.settSaveB.Size = new System.Drawing.Size(75, 23);
            this.settSaveB.TabIndex = 5;
            this.settSaveB.Text = "Save";
            this.settSaveB.UseVisualStyleBackColor = true;
            this.settSaveB.Click += new System.EventHandler(this.settSaveB_Click);
            // 
            // settCancelB
            // 
            this.settCancelB.Location = new System.Drawing.Point(211, 226);
            this.settCancelB.Name = "settCancelB";
            this.settCancelB.Size = new System.Drawing.Size(75, 23);
            this.settCancelB.TabIndex = 6;
            this.settCancelB.Text = "Cancel";
            this.settCancelB.UseVisualStyleBackColor = true;
            this.settCancelB.Click += new System.EventHandler(this.settCancelB_Click);
            // 
            // settDefaultB
            // 
            this.settDefaultB.Location = new System.Drawing.Point(12, 227);
            this.settDefaultB.Name = "settDefaultB";
            this.settDefaultB.Size = new System.Drawing.Size(75, 23);
            this.settDefaultB.TabIndex = 7;
            this.settDefaultB.Text = "Default";
            this.settDefaultB.UseVisualStyleBackColor = true;
            this.settDefaultB.Click += new System.EventHandler(this.settDefaultB_Click);
            // 
            // ExtraSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.settDefaultB);
            this.Controls.Add(this.settCancelB);
            this.Controls.Add(this.settSaveB);
            this.Controls.Add(this.simpleSettGB);
            this.Controls.Add(this.secureSettGB);
            this.Name = "ExtraSettingsForm";
            this.Text = "Extra Settings";
            ((System.ComponentModel.ISupportInitialize)(this.secPassNumChars)).EndInit();
            this.secureSettGB.ResumeLayout(false);
            this.secureSettGB.PerformLayout();
            this.simpleSettGB.ResumeLayout(false);
            this.simpleSettGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox useSpecsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown secPassNumChars;
        private System.Windows.Forms.GroupBox secureSettGB;
        private System.Windows.Forms.GroupBox simpleSettGB;
        private System.Windows.Forms.CheckBox capitalsCB;
        private System.Windows.Forms.Button settSaveB;
        private System.Windows.Forms.Button settCancelB;
        private System.Windows.Forms.Button settDefaultB;
    }
}