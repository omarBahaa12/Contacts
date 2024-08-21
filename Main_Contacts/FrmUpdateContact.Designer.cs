namespace Main_Contacts
{
    partial class FrmUpdateContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateContact));
            this.Pan_TitlePar = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Minmize = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lb_EnterName = new System.Windows.Forms.Label();
            this.Txtbox_Name = new System.Windows.Forms.TextBox();
            this.Btn_SearchFullName = new System.Windows.Forms.Button();
            this.Lb_EnterID = new System.Windows.Forms.Label();
            this.Txtbox_ID = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.Combox_Countries = new System.Windows.Forms.ComboBox();
            this.Btn_SetImage = new System.Windows.Forms.Button();
            this.Txtb_Phone = new System.Windows.Forms.TextBox();
            this.Txtb_LastName = new System.Windows.Forms.TextBox();
            this.Txtb_Address = new System.Windows.Forms.TextBox();
            this.Txtb_Email = new System.Windows.Forms.TextBox();
            this.Txtb_FirstName = new System.Windows.Forms.TextBox();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.Lb_PersonID = new System.Windows.Forms.Label();
            this.PicBox_Person = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.Lb_Address = new System.Windows.Forms.Label();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Lb_LastName = new System.Windows.Forms.Label();
            this.Lb_FirstName = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pan_TitlePar.SuspendLayout();
            this.Pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan_TitlePar
            // 
            this.Pan_TitlePar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Pan_TitlePar.Controls.Add(this.Lb_Title);
            this.Pan_TitlePar.Controls.Add(this.Btn_Minmize);
            this.Pan_TitlePar.Controls.Add(this.Btn_Maxmize);
            this.Pan_TitlePar.Controls.Add(this.Btn_Exit);
            this.Pan_TitlePar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_TitlePar.Location = new System.Drawing.Point(0, 0);
            this.Pan_TitlePar.Name = "Pan_TitlePar";
            this.Pan_TitlePar.Size = new System.Drawing.Size(1129, 47);
            this.Pan_TitlePar.TabIndex = 2;
            this.Pan_TitlePar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(205, 28);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "Update Contact";
            // 
            // Btn_Minmize
            // 
            this.Btn_Minmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(203)))));
            this.Btn_Minmize.FlatAppearance.BorderSize = 0;
            this.Btn_Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minmize.ImageIndex = 6;
            this.Btn_Minmize.ImageList = this.imageList1;
            this.Btn_Minmize.Location = new System.Drawing.Point(949, 3);
            this.Btn_Minmize.Name = "Btn_Minmize";
            this.Btn_Minmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Minmize.TabIndex = 2;
            this.Btn_Minmize.UseVisualStyleBackColor = false;
            this.Btn_Minmize.Click += new System.EventHandler(this.Btn_Minmize_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            this.imageList1.Images.SetKeyName(1, "mail.png");
            this.imageList1.Images.SetKeyName(2, "phone-call.png");
            this.imageList1.Images.SetKeyName(3, "location.png");
            this.imageList1.Images.SetKeyName(4, "countries.png");
            this.imageList1.Images.SetKeyName(5, "reject.png");
            this.imageList1.Images.SetKeyName(6, "minus.png");
            this.imageList1.Images.SetKeyName(7, "maximize(1).png");
            this.imageList1.Images.SetKeyName(8, "search.png");
            this.imageList1.Images.SetKeyName(9, "trash-bin.png");
            this.imageList1.Images.SetKeyName(10, "unknown.png");
            this.imageList1.Images.SetKeyName(11, "transaction.png");
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 7;
            this.Btn_Maxmize.ImageList = this.imageList1;
            this.Btn_Maxmize.Location = new System.Drawing.Point(1004, 3);
            this.Btn_Maxmize.Name = "Btn_Maxmize";
            this.Btn_Maxmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Maxmize.TabIndex = 1;
            this.Btn_Maxmize.UseVisualStyleBackColor = true;
            this.Btn_Maxmize.Click += new System.EventHandler(this.Btn_Maxmize_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ImageIndex = 5;
            this.Btn_Exit.ImageList = this.imageList1;
            this.Btn_Exit.Location = new System.Drawing.Point(1059, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(45, 34);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lb_EnterName
            // 
            this.Lb_EnterName.AutoSize = true;
            this.Lb_EnterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_EnterName.Location = new System.Drawing.Point(723, 61);
            this.Lb_EnterName.Name = "Lb_EnterName";
            this.Lb_EnterName.Size = new System.Drawing.Size(146, 24);
            this.Lb_EnterName.TabIndex = 13;
            this.Lb_EnterName.Text = "Enter Full Name";
            // 
            // Txtbox_Name
            // 
            this.Txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_Name.Location = new System.Drawing.Point(727, 103);
            this.Txtbox_Name.Name = "Txtbox_Name";
            this.Txtbox_Name.Size = new System.Drawing.Size(206, 27);
            this.Txtbox_Name.TabIndex = 12;
            // 
            // Btn_SearchFullName
            // 
            this.Btn_SearchFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.Btn_SearchFullName.FlatAppearance.BorderSize = 0;
            this.Btn_SearchFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchFullName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SearchFullName.ImageIndex = 8;
            this.Btn_SearchFullName.ImageList = this.imageList1;
            this.Btn_SearchFullName.Location = new System.Drawing.Point(589, 95);
            this.Btn_SearchFullName.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SearchFullName.Name = "Btn_SearchFullName";
            this.Btn_SearchFullName.Size = new System.Drawing.Size(117, 44);
            this.Btn_SearchFullName.TabIndex = 11;
            this.Btn_SearchFullName.Text = "Search";
            this.Btn_SearchFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SearchFullName.UseVisualStyleBackColor = false;
            this.Btn_SearchFullName.Click += new System.EventHandler(this.Btn_SearchFullName_Click);
            // 
            // Lb_EnterID
            // 
            this.Lb_EnterID.AutoSize = true;
            this.Lb_EnterID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_EnterID.Location = new System.Drawing.Point(218, 61);
            this.Lb_EnterID.Name = "Lb_EnterID";
            this.Lb_EnterID.Size = new System.Drawing.Size(79, 24);
            this.Lb_EnterID.TabIndex = 10;
            this.Lb_EnterID.Text = "Enter ID";
            // 
            // Txtbox_ID
            // 
            this.Txtbox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_ID.Location = new System.Drawing.Point(213, 103);
            this.Txtbox_ID.Name = "Txtbox_ID";
            this.Txtbox_ID.Size = new System.Drawing.Size(206, 27);
            this.Txtbox_ID.TabIndex = 9;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Search.ImageIndex = 8;
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(70, 95);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(117, 44);
            this.Btn_Search.TabIndex = 8;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Pan_Main
            // 
            this.Pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pan_Main.Controls.Add(this.Combox_Countries);
            this.Pan_Main.Controls.Add(this.Btn_SetImage);
            this.Pan_Main.Controls.Add(this.Txtb_Phone);
            this.Pan_Main.Controls.Add(this.Txtb_LastName);
            this.Pan_Main.Controls.Add(this.Txtb_Address);
            this.Pan_Main.Controls.Add(this.Txtb_Email);
            this.Pan_Main.Controls.Add(this.Txtb_FirstName);
            this.Pan_Main.Controls.Add(this.Lb_ID);
            this.Pan_Main.Controls.Add(this.Lb_PersonID);
            this.Pan_Main.Controls.Add(this.PicBox_Person);
            this.Pan_Main.Controls.Add(this.label1);
            this.Pan_Main.Controls.Add(this.Lb_Phone);
            this.Pan_Main.Controls.Add(this.Lb_Address);
            this.Pan_Main.Controls.Add(this.Lb_Email);
            this.Pan_Main.Controls.Add(this.Lb_LastName);
            this.Pan_Main.Controls.Add(this.Lb_FirstName);
            this.Pan_Main.Controls.Add(this.Btn_Cancel);
            this.Pan_Main.Controls.Add(this.Btn_Update);
            this.Pan_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_Main.Location = new System.Drawing.Point(0, 207);
            this.Pan_Main.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(1129, 412);
            this.Pan_Main.TabIndex = 14;
            // 
            // Combox_Countries
            // 
            this.Combox_Countries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combox_Countries.FormattingEnabled = true;
            this.Combox_Countries.Location = new System.Drawing.Point(553, 230);
            this.Combox_Countries.Name = "Combox_Countries";
            this.Combox_Countries.Size = new System.Drawing.Size(186, 28);
            this.Combox_Countries.TabIndex = 49;
            // 
            // Btn_SetImage
            // 
            this.Btn_SetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SetImage.FlatAppearance.BorderSize = 0;
            this.Btn_SetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_SetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SetImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_SetImage.Location = new System.Drawing.Point(868, 212);
            this.Btn_SetImage.Name = "Btn_SetImage";
            this.Btn_SetImage.Size = new System.Drawing.Size(188, 43);
            this.Btn_SetImage.TabIndex = 48;
            this.Btn_SetImage.Text = "Set Image";
            this.Btn_SetImage.UseVisualStyleBackColor = true;
            this.Btn_SetImage.Click += new System.EventHandler(this.Btn_SetImage_Click);
            // 
            // Txtb_Phone
            // 
            this.Txtb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Phone.Location = new System.Drawing.Point(553, 173);
            this.Txtb_Phone.Name = "Txtb_Phone";
            this.Txtb_Phone.Size = new System.Drawing.Size(186, 27);
            this.Txtb_Phone.TabIndex = 46;
            this.Txtb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_Phone_Validating);
            // 
            // Txtb_LastName
            // 
            this.Txtb_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_LastName.Location = new System.Drawing.Point(582, 110);
            this.Txtb_LastName.Name = "Txtb_LastName";
            this.Txtb_LastName.Size = new System.Drawing.Size(157, 27);
            this.Txtb_LastName.TabIndex = 45;
            this.Txtb_LastName.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_LastName_Validating);
            // 
            // Txtb_Address
            // 
            this.Txtb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Address.Location = new System.Drawing.Point(134, 229);
            this.Txtb_Address.Name = "Txtb_Address";
            this.Txtb_Address.Size = new System.Drawing.Size(187, 27);
            this.Txtb_Address.TabIndex = 44;
            this.Txtb_Address.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_Address_Validating);
            // 
            // Txtb_Email
            // 
            this.Txtb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Email.Location = new System.Drawing.Point(108, 173);
            this.Txtb_Email.Name = "Txtb_Email";
            this.Txtb_Email.Size = new System.Drawing.Size(232, 27);
            this.Txtb_Email.TabIndex = 43;
            // 
            // Txtb_FirstName
            // 
            this.Txtb_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_FirstName.Location = new System.Drawing.Point(169, 104);
            this.Txtb_FirstName.Name = "Txtb_FirstName";
            this.Txtb_FirstName.Size = new System.Drawing.Size(141, 27);
            this.Txtb_FirstName.TabIndex = 42;
            this.Txtb_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_FirstName_Validating);
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_ID.ImageList = this.imageList1;
            this.Lb_ID.Location = new System.Drawing.Point(462, 21);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(26, 29);
            this.Lb_ID.TabIndex = 35;
            this.Lb_ID.Text = "0";
            this.Lb_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_PersonID
            // 
            this.Lb_PersonID.AutoSize = true;
            this.Lb_PersonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_PersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_PersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_PersonID.ImageList = this.imageList1;
            this.Lb_PersonID.Location = new System.Drawing.Point(342, 21);
            this.Lb_PersonID.Name = "Lb_PersonID";
            this.Lb_PersonID.Size = new System.Drawing.Size(125, 29);
            this.Lb_PersonID.TabIndex = 34;
            this.Lb_PersonID.Text = "Person ID:";
            this.Lb_PersonID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PicBox_Person
            // 
            this.PicBox_Person.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PicBox_Person.Image = global::Main_Contacts.Properties.Resources.unknown;
            this.PicBox_Person.Location = new System.Drawing.Point(868, 21);
            this.PicBox_Person.Name = "PicBox_Person";
            this.PicBox_Person.Size = new System.Drawing.Size(188, 174);
            this.PicBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Person.TabIndex = 32;
            this.PicBox_Person.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(444, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Country :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.AutoSize = true;
            this.Lb_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Phone.ImageList = this.imageList1;
            this.Lb_Phone.Location = new System.Drawing.Point(448, 168);
            this.Lb_Phone.Name = "Lb_Phone";
            this.Lb_Phone.Size = new System.Drawing.Size(94, 27);
            this.Lb_Phone.TabIndex = 28;
            this.Lb_Phone.Text = "Phone : ";
            this.Lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Address
            // 
            this.Lb_Address.AutoSize = true;
            this.Lb_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Address.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Address.ImageList = this.imageList1;
            this.Lb_Address.Location = new System.Drawing.Point(23, 229);
            this.Lb_Address.Name = "Lb_Address";
            this.Lb_Address.Size = new System.Drawing.Size(105, 27);
            this.Lb_Address.TabIndex = 22;
            this.Lb_Address.Text = "Address :";
            this.Lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Email
            // 
            this.Lb_Email.AutoSize = true;
            this.Lb_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Email.ImageList = this.imageList1;
            this.Lb_Email.Location = new System.Drawing.Point(23, 167);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(79, 27);
            this.Lb_Email.TabIndex = 21;
            this.Lb_Email.Text = "Email :";
            this.Lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_LastName
            // 
            this.Lb_LastName.AutoSize = true;
            this.Lb_LastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_LastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_LastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_LastName.ImageList = this.imageList1;
            this.Lb_LastName.Location = new System.Drawing.Point(444, 105);
            this.Lb_LastName.Name = "Lb_LastName";
            this.Lb_LastName.Size = new System.Drawing.Size(132, 27);
            this.Lb_LastName.TabIndex = 20;
            this.Lb_LastName.Text = "Last Name :";
            this.Lb_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_FirstName
            // 
            this.Lb_FirstName.AutoSize = true;
            this.Lb_FirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_FirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_FirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_FirstName.ImageList = this.imageList1;
            this.Lb_FirstName.Location = new System.Drawing.Point(23, 99);
            this.Lb_FirstName.Name = "Lb_FirstName";
            this.Lb_FirstName.Size = new System.Drawing.Size(140, 27);
            this.Lb_FirstName.TabIndex = 19;
            this.Lb_FirstName.Text = "First  Name :";
            this.Lb_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(887, 341);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(169, 45);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Update.ImageIndex = 11;
            this.Btn_Update.ImageList = this.imageList1;
            this.Btn_Update.Location = new System.Drawing.Point(553, 341);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(169, 45);
            this.Btn_Update.TabIndex = 0;
            this.Btn_Update.Text = "  Update";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1129, 619);
            this.Controls.Add(this.Pan_Main);
            this.Controls.Add(this.Lb_EnterName);
            this.Controls.Add(this.Txtbox_Name);
            this.Controls.Add(this.Btn_SearchFullName);
            this.Controls.Add(this.Lb_EnterID);
            this.Controls.Add(this.Txtbox_ID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Pan_TitlePar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Name = "FrmUpdateContact";
            this.Text = "FrmUpdateContact";
            this.Load += new System.EventHandler(this.FrmUpdateContact_Load);
            this.Resize += new System.EventHandler(this.FrmUpdateContact_Resize);
            this.Pan_TitlePar.ResumeLayout(false);
            this.Pan_TitlePar.PerformLayout();
            this.Pan_Main.ResumeLayout(false);
            this.Pan_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pan_TitlePar;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_Minmize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lb_EnterName;
        private System.Windows.Forms.TextBox Txtbox_Name;
        private System.Windows.Forms.Button Btn_SearchFullName;
        private System.Windows.Forms.Label Lb_EnterID;
        private System.Windows.Forms.TextBox Txtbox_ID;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Label Lb_PersonID;
        private System.Windows.Forms.PictureBox PicBox_Person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Phone;
        private System.Windows.Forms.Label Lb_Address;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label Lb_LastName;
        private System.Windows.Forms.Label Lb_FirstName;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox Txtb_FirstName;
        private System.Windows.Forms.TextBox Txtb_Email;
        private System.Windows.Forms.TextBox Txtb_Phone;
        private System.Windows.Forms.TextBox Txtb_LastName;
        private System.Windows.Forms.TextBox Txtb_Address;
        private System.Windows.Forms.Button Btn_SetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox Combox_Countries;
    }
}