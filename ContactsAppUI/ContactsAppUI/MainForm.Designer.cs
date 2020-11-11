namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.BithdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.SystemButtonsSeparatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FindTextBoxSeparatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FindContactTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditDeleteButtonsSeparatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.MainTableLayout.SuspendLayout();
            this.ContactInfoTableLayout.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SystemButtonsSeparatorTableLayout.SuspendLayout();
            this.FindTextBoxSeparatorTableLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.AddEditDeleteButtonsSeparatorTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.MainTableLayout.Controls.Add(this.ContactInfoTableLayout, 1, 0);
            this.MainTableLayout.Controls.Add(this.Panel, 0, 0);
            this.MainTableLayout.Controls.Add(this.AddEditDeleteButtonsSeparatorTableLayout, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayout.Size = new System.Drawing.Size(704, 366);
            this.MainTableLayout.TabIndex = 3;
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
            this.ContactInfoTableLayout.Controls.Add(this.PhoneTextBox, 1, 4);
            this.ContactInfoTableLayout.Controls.Add(this.BithdayDateTimePicker, 1, 3);
            this.ContactInfoTableLayout.Controls.Add(this.LastNameTextBox, 1, 2);
            this.ContactInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactInfoTableLayout.Location = new System.Drawing.Point(246, 0);
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
            this.ContactInfoTableLayout.Size = new System.Drawing.Size(458, 311);
            this.ContactInfoTableLayout.TabIndex = 1;
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
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTextBox.Location = new System.Drawing.Point(125, 18);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(328, 26);
            this.NameTextBox.TabIndex = 6;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MiddleNameTextBox.Enabled = false;
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MiddleNameTextBox.Location = new System.Drawing.Point(125, 62);
            this.MiddleNameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(328, 26);
            this.MiddleNameTextBox.TabIndex = 7;
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
            this.VKIDTextBox.Enabled = false;
            this.VKIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VKIDTextBox.Location = new System.Drawing.Point(125, 285);
            this.VKIDTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.VKIDTextBox.Name = "VKIDTextBox";
            this.VKIDTextBox.Size = new System.Drawing.Size(328, 26);
            this.VKIDTextBox.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTextBox.Location = new System.Drawing.Point(125, 238);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(328, 26);
            this.EmailTextBox.TabIndex = 10;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PhoneTextBox.Enabled = false;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhoneTextBox.Location = new System.Drawing.Point(125, 194);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(328, 26);
            this.PhoneTextBox.TabIndex = 9;
            // 
            // BithdayDateTimePicker
            // 
            this.BithdayDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BithdayDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BithdayDateTimePicker.Enabled = false;
            this.BithdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BithdayDateTimePicker.Location = new System.Drawing.Point(125, 147);
            this.BithdayDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BithdayDateTimePicker.Name = "BithdayDateTimePicker";
            this.BithdayDateTimePicker.Size = new System.Drawing.Size(328, 29);
            this.BithdayDateTimePicker.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(125, 106);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(328, 26);
            this.LastNameTextBox.TabIndex = 13;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ContactsListBox);
            this.Panel.Controls.Add(this.SystemButtonsSeparatorTableLayout);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(246, 311);
            this.Panel.TabIndex = 2;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(0, 59);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(246, 252);
            this.ContactsListBox.TabIndex = 8;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // SystemButtonsSeparatorTableLayout
            // 
            this.SystemButtonsSeparatorTableLayout.ColumnCount = 1;
            this.SystemButtonsSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.SystemButtonsSeparatorTableLayout.Controls.Add(this.FindTextBoxSeparatorTableLayout, 0, 1);
            this.SystemButtonsSeparatorTableLayout.Controls.Add(this.menuStrip1, 0, 0);
            this.SystemButtonsSeparatorTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.SystemButtonsSeparatorTableLayout.Location = new System.Drawing.Point(0, 0);
            this.SystemButtonsSeparatorTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SystemButtonsSeparatorTableLayout.Name = "SystemButtonsSeparatorTableLayout";
            this.SystemButtonsSeparatorTableLayout.RowCount = 2;
            this.SystemButtonsSeparatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemButtonsSeparatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemButtonsSeparatorTableLayout.Size = new System.Drawing.Size(246, 59);
            this.SystemButtonsSeparatorTableLayout.TabIndex = 7;
            // 
            // FindTextBoxSeparatorTableLayout
            // 
            this.FindTextBoxSeparatorTableLayout.ColumnCount = 2;
            this.FindTextBoxSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.FindTextBoxSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FindTextBoxSeparatorTableLayout.Controls.Add(this.FindContactTextBox, 1, 0);
            this.FindTextBoxSeparatorTableLayout.Controls.Add(this.FindLabel, 0, 0);
            this.FindTextBoxSeparatorTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTextBoxSeparatorTableLayout.Location = new System.Drawing.Point(0, 29);
            this.FindTextBoxSeparatorTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FindTextBoxSeparatorTableLayout.Name = "FindTextBoxSeparatorTableLayout";
            this.FindTextBoxSeparatorTableLayout.RowCount = 1;
            this.FindTextBoxSeparatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FindTextBoxSeparatorTableLayout.Size = new System.Drawing.Size(246, 30);
            this.FindTextBoxSeparatorTableLayout.TabIndex = 0;
            // 
            // FindContactTextBox
            // 
            this.FindContactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindContactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FindContactTextBox.Location = new System.Drawing.Point(75, 0);
            this.FindContactTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FindContactTextBox.Name = "FindContactTextBox";
            this.FindContactTextBox.Size = new System.Drawing.Size(171, 29);
            this.FindContactTextBox.TabIndex = 7;
            // 
            // FindLabel
            // 
            this.FindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FindLabel.Location = new System.Drawing.Point(0, 0);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(75, 30);
            this.FindLabel.TabIndex = 8;
            this.FindLabel.Text = "Find:";
            this.FindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load from File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AddEditDeleteButtonsSeparatorTableLayout
            // 
            this.AddEditDeleteButtonsSeparatorTableLayout.ColumnCount = 3;
            this.AddEditDeleteButtonsSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddEditDeleteButtonsSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddEditDeleteButtonsSeparatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddEditDeleteButtonsSeparatorTableLayout.Controls.Add(this.AddContactButton, 0, 0);
            this.AddEditDeleteButtonsSeparatorTableLayout.Controls.Add(this.EditContactButton, 1, 0);
            this.AddEditDeleteButtonsSeparatorTableLayout.Controls.Add(this.DeleteContactButton, 2, 0);
            this.AddEditDeleteButtonsSeparatorTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEditDeleteButtonsSeparatorTableLayout.Location = new System.Drawing.Point(0, 311);
            this.AddEditDeleteButtonsSeparatorTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.AddEditDeleteButtonsSeparatorTableLayout.Name = "AddEditDeleteButtonsSeparatorTableLayout";
            this.AddEditDeleteButtonsSeparatorTableLayout.RowCount = 1;
            this.AddEditDeleteButtonsSeparatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddEditDeleteButtonsSeparatorTableLayout.Size = new System.Drawing.Size(246, 55);
            this.AddEditDeleteButtonsSeparatorTableLayout.TabIndex = 4;
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Image = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Image")));
            this.AddContactButton.Location = new System.Drawing.Point(3, 3);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(76, 49);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = ((System.Drawing.Image)(resources.GetObject("EditContactButton.Image")));
            this.EditContactButton.Location = new System.Drawing.Point(85, 3);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(76, 49);
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteContactButton.FlatAppearance.BorderSize = 0;
            this.DeleteContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteContactButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteContactButton.Image")));
            this.DeleteContactButton.Location = new System.Drawing.Point(167, 3);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(76, 49);
            this.DeleteContactButton.TabIndex = 2;
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 366);
            this.Controls.Add(this.MainTableLayout);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "MainForm";
            this.Text = "Contacts App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.ContactInfoTableLayout.ResumeLayout(false);
            this.ContactInfoTableLayout.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.SystemButtonsSeparatorTableLayout.ResumeLayout(false);
            this.SystemButtonsSeparatorTableLayout.PerformLayout();
            this.FindTextBoxSeparatorTableLayout.ResumeLayout(false);
            this.FindTextBoxSeparatorTableLayout.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddEditDeleteButtonsSeparatorTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TableLayoutPanel ContactInfoTableLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VKIDTextBox;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TableLayoutPanel SystemButtonsSeparatorTableLayout;
        private System.Windows.Forms.DateTimePicker BithdayDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel AddEditDeleteButtonsSeparatorTableLayout;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button DeleteContactButton;
        private System.Windows.Forms.TableLayoutPanel FindTextBoxSeparatorTableLayout;
        private System.Windows.Forms.TextBox FindContactTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label VKIDLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
    }
}

