namespace MainGui
{
    partial class MainGui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.chkLittleLetters = new System.Windows.Forms.CheckBox();
            this.chkBigLetters = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecialcharacters = new System.Windows.Forms.CheckBox();
            this.txtGeneratedKey = new System.Windows.Forms.TextBox();
            this.txtCountCharacters = new System.Windows.Forms.TextBox();
            this.lblCountCharacters = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateKey.Location = new System.Drawing.Point(317, 55);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateKey.TabIndex = 0;
            this.btnGenerateKey.Text = "Generieren";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // chkLittleLetters
            // 
            this.chkLittleLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLittleLetters.AutoSize = true;
            this.chkLittleLetters.Location = new System.Drawing.Point(12, 61);
            this.chkLittleLetters.Name = "chkLittleLetters";
            this.chkLittleLetters.Size = new System.Drawing.Size(97, 17);
            this.chkLittleLetters.TabIndex = 1;
            this.chkLittleLetters.Text = "kl. Buchstaben";
            this.chkLittleLetters.UseVisualStyleBackColor = true;
            // 
            // chkBigLetters
            // 
            this.chkBigLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBigLetters.AutoSize = true;
            this.chkBigLetters.Location = new System.Drawing.Point(12, 84);
            this.chkBigLetters.Name = "chkBigLetters";
            this.chkBigLetters.Size = new System.Drawing.Size(100, 17);
            this.chkBigLetters.TabIndex = 2;
            this.chkBigLetters.Text = "Gr. Buchstaben";
            this.chkBigLetters.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Location = new System.Drawing.Point(118, 61);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(53, 17);
            this.chkNumbers.TabIndex = 3;
            this.chkNumbers.Text = "Ziffen";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecialcharacters
            // 
            this.chkSpecialcharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSpecialcharacters.AutoSize = true;
            this.chkSpecialcharacters.Location = new System.Drawing.Point(118, 84);
            this.chkSpecialcharacters.Name = "chkSpecialcharacters";
            this.chkSpecialcharacters.Size = new System.Drawing.Size(97, 17);
            this.chkSpecialcharacters.TabIndex = 4;
            this.chkSpecialcharacters.Text = "Sonderzeichen";
            this.chkSpecialcharacters.UseVisualStyleBackColor = true;
            // 
            // txtGeneratedKey
            // 
            this.txtGeneratedKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneratedKey.Enabled = false;
            this.txtGeneratedKey.Location = new System.Drawing.Point(12, 12);
            this.txtGeneratedKey.MaxLength = 64;
            this.txtGeneratedKey.Name = "txtGeneratedKey";
            this.txtGeneratedKey.Size = new System.Drawing.Size(380, 20);
            this.txtGeneratedKey.TabIndex = 5;
            this.txtGeneratedKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountCharacters
            // 
            this.txtCountCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCountCharacters.Location = new System.Drawing.Point(221, 81);
            this.txtCountCharacters.MaxLength = 2;
            this.txtCountCharacters.Name = "txtCountCharacters";
            this.txtCountCharacters.Size = new System.Drawing.Size(66, 20);
            this.txtCountCharacters.TabIndex = 6;
            // 
            // lblCountCharacters
            // 
            this.lblCountCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountCharacters.AutoSize = true;
            this.lblCountCharacters.Location = new System.Drawing.Point(218, 61);
            this.lblCountCharacters.Name = "lblCountCharacters";
            this.lblCountCharacters.Size = new System.Drawing.Size(75, 13);
            this.lblCountCharacters.TabIndex = 7;
            this.lblCountCharacters.Text = "Anzal Zeichen";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(317, 84);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Kopieren";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 113);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblCountCharacters);
            this.Controls.Add(this.txtCountCharacters);
            this.Controls.Add(this.txtGeneratedKey);
            this.Controls.Add(this.chkSpecialcharacters);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkBigLetters);
            this.Controls.Add(this.chkLittleLetters);
            this.Controls.Add(this.btnGenerateKey);
            this.Name = "MainGui";
            this.Text = "WlanKey Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGui_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.CheckBox chkLittleLetters;
        private System.Windows.Forms.CheckBox chkBigLetters;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSpecialcharacters;
        private System.Windows.Forms.TextBox txtGeneratedKey;
        private System.Windows.Forms.TextBox txtCountCharacters;
        private System.Windows.Forms.Label lblCountCharacters;
        private System.Windows.Forms.Button btnCopy;
    }
}

