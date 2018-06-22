namespace EmailAdressBook
{
    partial class AddNew
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
                _personRepository.Dispose();
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
            this.personInfoPanel = new System.Windows.Forms.Panel();
            this.idLable = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.closeFormChckBox = new System.Windows.Forms.CheckBox();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.personInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfoPanel
            // 
            this.personInfoPanel.Controls.Add(this.phoneNumberTextBox);
            this.personInfoPanel.Controls.Add(this.AddBtn);
            this.personInfoPanel.Controls.Add(this.idLable);
            this.personInfoPanel.Controls.Add(this.emailTextBox);
            this.personInfoPanel.Controls.Add(this.nameTextBox);
            this.personInfoPanel.Controls.Add(this.phoneNumberLabel);
            this.personInfoPanel.Controls.Add(this.emailLabel);
            this.personInfoPanel.Controls.Add(this.nameLabel);
            this.personInfoPanel.Location = new System.Drawing.Point(114, 102);
            this.personInfoPanel.Name = "personInfoPanel";
            this.personInfoPanel.Size = new System.Drawing.Size(1262, 737);
            this.personInfoPanel.TabIndex = 3;
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(64, 611);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(0, 32);
            this.idLable.TabIndex = 6;
            this.idLable.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(27, 254);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(1218, 89);
            this.emailTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(27, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(1218, 89);
            this.nameTextBox.TabIndex = 3;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(33, 431);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(288, 46);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "PhoneNumber";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(33, 205);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(125, 46);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(33, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 46);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.Location = new System.Drawing.Point(473, 611);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(228, 103);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // closeFormChckBox
            // 
            this.closeFormChckBox.AutoSize = true;
            this.closeFormChckBox.Checked = global::EmailAdressBook.Properties.Settings.Default.CloseFormWhenAddNew;
            this.closeFormChckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EmailAdressBook.Properties.Settings.Default, "CloseFormWhenAddNew", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.closeFormChckBox.Location = new System.Drawing.Point(127, 30);
            this.closeFormChckBox.Name = "closeFormChckBox";
            this.closeFormChckBox.Size = new System.Drawing.Size(466, 36);
            this.closeFormChckBox.TabIndex = 4;
            this.closeFormChckBox.Text = "Close form when record is added";
            this.closeFormChckBox.UseVisualStyleBackColor = true;
            this.closeFormChckBox.CheckedChanged += new System.EventHandler(this.closeFormChckBox_CheckedChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(27, 480);
            this.phoneNumberTextBox.Mask = "(999) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(1218, 96);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1491, 868);
            this.Controls.Add(this.closeFormChckBox);
            this.Controls.Add(this.personInfoPanel);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNew_FormClosing);
            this.personInfoPanel.ResumeLayout(false);
            this.personInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel personInfoPanel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox closeFormChckBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
    }
}