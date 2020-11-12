namespace ContactsAppUI
{
    partial class EditContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContactForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ContactInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VKIDLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.VKIDTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BithdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.ContactInfoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.AcceptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 47);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(504, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(423, 12);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 7;
            this.AcceptButton.Text = "OK";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ContactInfoTableLayout
            // 
            this.ContactInfoTableLayout.ColumnCount = 2;
            this.ContactInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.ContactInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactInfoTableLayout.Controls.Add(this.VKIDLabel, 0, 6);
            this.ContactInfoTableLayout.Controls.Add(this.MiddleNameLabel, 0, 1);
            this.ContactInfoTableLayout.Controls.Add(this.LastNameLabel, 0, 2);
            this.ContactInfoTableLayout.Controls.Add(this.BirthdayLabel, 0, 3);
            this.ContactInfoTableLayout.Controls.Add(this.PhoneNumberLabel, 0, 4);
            this.ContactInfoTableLayout.Controls.Add(this.EmailLabel, 0, 5);
            this.ContactInfoTableLayout.Controls.Add(this.NameTextBox, 1, 0);
            this.ContactInfoTableLayout.Controls.Add(this.MiddleNameTextBox, 1, 1);
            this.ContactInfoTableLayout.Controls.Add(this.NameLabel, 0, 0);
            this.ContactInfoTableLayout.Controls.Add(this.VKIDTextBox, 1, 6);
            this.ContactInfoTableLayout.Controls.Add(this.EmailTextBox, 1, 5);
            this.ContactInfoTableLayout.Controls.Add(this.BithdayDateTimePicker, 1, 3);
            this.ContactInfoTableLayout.Controls.Add(this.LastNameTextBox, 1, 2);
            this.ContactInfoTableLayout.Controls.Add(this.PhoneMaskedTextBox, 1, 4);
            this.ContactInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactInfoTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ContactInfoTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ContactInfoTableLayout.Name = "ContactInfoTableLayout";
            this.ContactInfoTableLayout.RowCount = 7;
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.ContactInfoTableLayout.Size = new System.Drawing.Size(584, 311);
            this.ContactInfoTableLayout.TabIndex = 2;
            // 
            // VKIDLabel
            // 
            this.VKIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VKIDLabel.Location = new System.Drawing.Point(0, 264);
            this.VKIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.VKIDLabel.Name = "VKIDLabel";
            this.VKIDLabel.Size = new System.Drawing.Size(125, 47);
            this.VKIDLabel.TabIndex = 14;
            this.VKIDLabel.Text = "vk.com\\";
            this.VKIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MiddleNameLabel.Location = new System.Drawing.Point(0, 44);
            this.MiddleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(125, 44);
            this.MiddleNameLabel.TabIndex = 1;
            this.MiddleNameLabel.Text = "Middle Name";
            this.MiddleNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LastNameLabel.Location = new System.Drawing.Point(0, 88);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(125, 44);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BirthdayLabel.Location = new System.Drawing.Point(0, 132);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(125, 44);
            this.BirthdayLabel.TabIndex = 3;
            this.BirthdayLabel.Text = "Birthday";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(0, 176);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(125, 44);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EmailLabel.Location = new System.Drawing.Point(0, 220);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(125, 44);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "E-mail";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTextBox.Location = new System.Drawing.Point(125, 18);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(454, 26);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MiddleNameTextBox.Location = new System.Drawing.Point(125, 62);
            this.MiddleNameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(454, 26);
            this.MiddleNameTextBox.TabIndex = 1;
            this.MiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(125, 44);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // VKIDTextBox
            // 
            this.VKIDTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VKIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VKIDTextBox.Location = new System.Drawing.Point(125, 285);
            this.VKIDTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.VKIDTextBox.Name = "VKIDTextBox";
            this.VKIDTextBox.Size = new System.Drawing.Size(454, 26);
            this.VKIDTextBox.TabIndex = 6;
            this.VKIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTextBox.Location = new System.Drawing.Point(125, 238);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(454, 26);
            this.EmailTextBox.TabIndex = 5;
            // 
            // BithdayDateTimePicker
            // 
            this.BithdayDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BithdayDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BithdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BithdayDateTimePicker.Location = new System.Drawing.Point(125, 147);
            this.BithdayDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BithdayDateTimePicker.Name = "BithdayDateTimePicker";
            this.BithdayDateTimePicker.Size = new System.Drawing.Size(454, 29);
            this.BithdayDateTimePicker.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(125, 106);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(454, 26);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(125, 194);
            this.PhoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(454, 26);
            this.PhoneMaskedTextBox.TabIndex = 15;
            this.PhoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ContactInfoTableLayout);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "EditContactForm";
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            this.panel1.ResumeLayout(false);
            this.ContactInfoTableLayout.ResumeLayout(false);
            this.ContactInfoTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        new private System.Windows.Forms.Button CancelButton;
        new private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TableLayoutPanel ContactInfoTableLayout;
        private System.Windows.Forms.Label VKIDLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox VKIDTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker BithdayDateTimePicker;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}