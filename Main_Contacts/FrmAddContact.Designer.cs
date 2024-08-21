namespace Main_Contacts
{
    partial class FrmAddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddContact));
            this.Lb_FirstName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_LastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.Lb_PersonID = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_SetImage = new System.Windows.Forms.Button();
            this.PicBox_Person = new System.Windows.Forms.PictureBox();
            this.Cm_Country = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_Phone = new System.Windows.Forms.TextBox();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Tbox_Address = new System.Windows.Forms.TextBox();
            this.Tbox_Email = new System.Windows.Forms.TextBox();
            this.Tbox_LastName = new System.Windows.Forms.TextBox();
            this.Tbox_FirstName = new System.Windows.Forms.TextBox();
            this.Lb_Address = new System.Windows.Forms.Label();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Pan_Title = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Minmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).BeginInit();
            this.Pan_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_FirstName
            // 
            this.Lb_FirstName.AutoSize = true;
            this.Lb_FirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_FirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_FirstName.ImageList = this.imageList1;
            this.Lb_FirstName.Location = new System.Drawing.Point(211, 83);
            this.Lb_FirstName.Name = "Lb_FirstName";
            this.Lb_FirstName.Size = new System.Drawing.Size(49, 25);
            this.Lb_FirstName.TabIndex = 0;
            this.Lb_FirstName.Text = "First";
            this.Lb_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // Lb_LastName
            // 
            this.Lb_LastName.AutoSize = true;
            this.Lb_LastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_LastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_LastName.ImageList = this.imageList1;
            this.Lb_LastName.Location = new System.Drawing.Point(604, 69);
            this.Lb_LastName.Name = "Lb_LastName";
            this.Lb_LastName.Size = new System.Drawing.Size(49, 25);
            this.Lb_LastName.TabIndex = 1;
            this.Lb_LastName.Text = "Last";
            this.Lb_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Lb_ID);
            this.panel1.Controls.Add(this.Lb_PersonID);
            this.panel1.Controls.Add(this.Btn_Cancel);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.Btn_SetImage);
            this.panel1.Controls.Add(this.PicBox_Person);
            this.panel1.Controls.Add(this.Cm_Country);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tbox_Phone);
            this.panel1.Controls.Add(this.Lb_Phone);
            this.panel1.Controls.Add(this.Lb_Name);
            this.panel1.Controls.Add(this.Tbox_Address);
            this.panel1.Controls.Add(this.Tbox_Email);
            this.panel1.Controls.Add(this.Tbox_LastName);
            this.panel1.Controls.Add(this.Tbox_FirstName);
            this.panel1.Controls.Add(this.Lb_Address);
            this.panel1.Controls.Add(this.Lb_Email);
            this.panel1.Controls.Add(this.Lb_LastName);
            this.panel1.Controls.Add(this.Lb_FirstName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 622);
            this.panel1.TabIndex = 4;
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_ID.ImageList = this.imageList1;
            this.Lb_ID.Location = new System.Drawing.Point(502, 23);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(26, 29);
            this.Lb_ID.TabIndex = 18;
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
            this.Lb_PersonID.Location = new System.Drawing.Point(371, 23);
            this.Lb_PersonID.Name = "Lb_PersonID";
            this.Lb_PersonID.Size = new System.Drawing.Size(125, 29);
            this.Lb_PersonID.TabIndex = 17;
            this.Lb_PersonID.Text = "Person ID:";
            this.Lb_PersonID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(931, 497);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(188, 43);
            this.Btn_Cancel.TabIndex = 16;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(573, 497);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(188, 43);
            this.Btn_Save.TabIndex = 15;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_SetImage
            // 
            this.Btn_SetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SetImage.FlatAppearance.BorderSize = 0;
            this.Btn_SetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_SetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SetImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_SetImage.Location = new System.Drawing.Point(940, 263);
            this.Btn_SetImage.Name = "Btn_SetImage";
            this.Btn_SetImage.Size = new System.Drawing.Size(188, 43);
            this.Btn_SetImage.TabIndex = 14;
            this.Btn_SetImage.Text = "Set Image";
            this.Btn_SetImage.UseVisualStyleBackColor = true;
            this.Btn_SetImage.Click += new System.EventHandler(this.Btn_SetImage_Click);
            // 
            // PicBox_Person
            // 
            this.PicBox_Person.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PicBox_Person.Image = global::Main_Contacts.Properties.Resources.unknown;
            this.PicBox_Person.Location = new System.Drawing.Point(940, 56);
            this.PicBox_Person.Name = "PicBox_Person";
            this.PicBox_Person.Size = new System.Drawing.Size(188, 174);
            this.PicBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Person.TabIndex = 13;
            this.PicBox_Person.TabStop = false;
            // 
            // Cm_Country
            // 
            this.Cm_Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Cm_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cm_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cm_Country.FormattingEnabled = true;
            this.Cm_Country.Location = new System.Drawing.Point(595, 337);
            this.Cm_Country.Name = "Cm_Country";
            this.Cm_Country.Size = new System.Drawing.Size(166, 28);
            this.Cm_Country.TabIndex = 12;
            this.Cm_Country.Validating += new System.ComponentModel.CancelEventHandler(this.Cm_Country_Validating);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 4;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(426, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Country";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tbox_Phone
            // 
            this.Tbox_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Tbox_Phone.Location = new System.Drawing.Point(595, 208);
            this.Tbox_Phone.Name = "Tbox_Phone";
            this.Tbox_Phone.Size = new System.Drawing.Size(133, 22);
            this.Tbox_Phone.TabIndex = 10;
            this.Tbox_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.Tbox_Phone_Validating);
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Phone.ImageIndex = 2;
            this.Lb_Phone.ImageList = this.imageList1;
            this.Lb_Phone.Location = new System.Drawing.Point(451, 186);
            this.Lb_Phone.Name = "Lb_Phone";
            this.Lb_Phone.Size = new System.Drawing.Size(124, 50);
            this.Lb_Phone.TabIndex = 9;
            this.Lb_Phone.Text = "Phone";
            this.Lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Name
            // 
            this.Lb_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Name.ImageIndex = 0;
            this.Lb_Name.ImageList = this.imageList1;
            this.Lb_Name.Location = new System.Drawing.Point(25, 103);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(122, 39);
            this.Lb_Name.TabIndex = 8;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tbox_Address
            // 
            this.Tbox_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Tbox_Address.Location = new System.Drawing.Point(187, 340);
            this.Tbox_Address.Name = "Tbox_Address";
            this.Tbox_Address.Size = new System.Drawing.Size(198, 22);
            this.Tbox_Address.TabIndex = 7;
            this.Tbox_Address.Validating += new System.ComponentModel.CancelEventHandler(this.Tbox_Address_Validating);
            // 
            // Tbox_Email
            // 
            this.Tbox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Tbox_Email.Location = new System.Drawing.Point(187, 208);
            this.Tbox_Email.Name = "Tbox_Email";
            this.Tbox_Email.Size = new System.Drawing.Size(198, 22);
            this.Tbox_Email.TabIndex = 6;
            // 
            // Tbox_LastName
            // 
            this.Tbox_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Tbox_LastName.Location = new System.Drawing.Point(595, 120);
            this.Tbox_LastName.Name = "Tbox_LastName";
            this.Tbox_LastName.Size = new System.Drawing.Size(133, 22);
            this.Tbox_LastName.TabIndex = 5;
            // 
            // Tbox_FirstName
            // 
            this.Tbox_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Tbox_FirstName.Location = new System.Drawing.Point(203, 120);
            this.Tbox_FirstName.Name = "Tbox_FirstName";
            this.Tbox_FirstName.Size = new System.Drawing.Size(133, 22);
            this.Tbox_FirstName.TabIndex = 4;
            this.Tbox_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Tbox_FirstName_Validating);
            // 
            // Lb_Address
            // 
            this.Lb_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Address.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Address.ImageIndex = 3;
            this.Lb_Address.ImageList = this.imageList1;
            this.Lb_Address.Location = new System.Drawing.Point(7, 322);
            this.Lb_Address.Name = "Lb_Address";
            this.Lb_Address.Size = new System.Drawing.Size(140, 47);
            this.Lb_Address.TabIndex = 3;
            this.Lb_Address.Text = "Address";
            this.Lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Email
            // 
            this.Lb_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Email.ImageIndex = 1;
            this.Lb_Email.ImageList = this.imageList1;
            this.Lb_Email.Location = new System.Drawing.Point(25, 186);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(128, 50);
            this.Lb_Email.TabIndex = 2;
            this.Lb_Email.Text = "Email";
            this.Lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pan_Title
            // 
            this.Pan_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Pan_Title.Controls.Add(this.Lb_Title);
            this.Pan_Title.Controls.Add(this.Btn_Minmize);
            this.Pan_Title.Controls.Add(this.Btn_Exit);
            this.Pan_Title.Controls.Add(this.Btn_Maxmize);
            this.Pan_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Title.Location = new System.Drawing.Point(0, 0);
            this.Pan_Title.Name = "Pan_Title";
            this.Pan_Title.Size = new System.Drawing.Size(1182, 48);
            this.Pan_Title.TabIndex = 8;
            this.Pan_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_Title_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(36, 11);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(178, 26);
            this.Lb_Title.TabIndex = 8;
            this.Lb_Title.Text = "Add New Contact";
            // 
            // Btn_Minmize
            // 
            this.Btn_Minmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(203)))));
            this.Btn_Minmize.FlatAppearance.BorderSize = 0;
            this.Btn_Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minmize.ImageIndex = 6;
            this.Btn_Minmize.ImageList = this.imageList1;
            this.Btn_Minmize.Location = new System.Drawing.Point(1006, 3);
            this.Btn_Minmize.Name = "Btn_Minmize";
            this.Btn_Minmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Minmize.TabIndex = 7;
            this.Btn_Minmize.UseVisualStyleBackColor = false;
            this.Btn_Minmize.Click += new System.EventHandler(this.Btn_Minmize_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ImageIndex = 5;
            this.Btn_Exit.ImageList = this.imageList1;
            this.Btn_Exit.Location = new System.Drawing.Point(1124, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(45, 34);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 7;
            this.Btn_Maxmize.ImageList = this.imageList1;
            this.Btn_Maxmize.Location = new System.Drawing.Point(1065, 3);
            this.Btn_Maxmize.Name = "Btn_Maxmize";
            this.Btn_Maxmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Maxmize.TabIndex = 6;
            this.Btn_Maxmize.UseVisualStyleBackColor = true;
            this.Btn_Maxmize.Click += new System.EventHandler(this.Btn_Maxmize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1182, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pan_Title);
            this.Name = "FrmAddContact";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.FrmAddContact_Load);
            this.Resize += new System.EventHandler(this.FrmAddContact_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).EndInit();
            this.Pan_Title.ResumeLayout(false);
            this.Pan_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_FirstName;
        private System.Windows.Forms.Label Lb_LastName;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label Lb_Address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Tbox_Address;
        private System.Windows.Forms.TextBox Tbox_Email;
        private System.Windows.Forms.TextBox Tbox_LastName;
        private System.Windows.Forms.TextBox Tbox_FirstName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Tbox_Phone;
        private System.Windows.Forms.Label Lb_Phone;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Minmize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Panel Pan_Title;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.PictureBox PicBox_Person;
        private System.Windows.Forms.Button Btn_SetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lb_PersonID;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox Cm_Country;
    }
}