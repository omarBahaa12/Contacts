namespace Main_Contacts
{
    partial class FrmDeleteContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteContact));
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.Lb_GetFirstName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_GetEmail = new System.Windows.Forms.Label();
            this.Lb_GetAddress = new System.Windows.Forms.Label();
            this.Lb_GetLastName = new System.Windows.Forms.Label();
            this.Lb_GetPhone = new System.Windows.Forms.Label();
            this.Lb_GetCountry = new System.Windows.Forms.Label();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.Lb_PersonID = new System.Windows.Forms.Label();
            this.PicBox_Person = new System.Windows.Forms.PictureBox();
            this.Lb_Country = new System.Windows.Forms.Label();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.Lb_Address = new System.Windows.Forms.Label();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Lb_LastName = new System.Windows.Forms.Label();
            this.Lb_FirstName = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txtbox_ID = new System.Windows.Forms.TextBox();
            this.Lb_EnterID = new System.Windows.Forms.Label();
            this.Lb_EnterName = new System.Windows.Forms.Label();
            this.Txtbox_Name = new System.Windows.Forms.TextBox();
            this.Btn_SearchFullName = new System.Windows.Forms.Button();
            this.Pan_Title = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Minmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).BeginInit();
            this.Pan_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Main
            // 
            this.Pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pan_Main.Controls.Add(this.Lb_GetFirstName);
            this.Pan_Main.Controls.Add(this.Lb_GetEmail);
            this.Pan_Main.Controls.Add(this.Lb_GetAddress);
            this.Pan_Main.Controls.Add(this.Lb_GetLastName);
            this.Pan_Main.Controls.Add(this.Lb_GetPhone);
            this.Pan_Main.Controls.Add(this.Lb_GetCountry);
            this.Pan_Main.Controls.Add(this.Lb_ID);
            this.Pan_Main.Controls.Add(this.Lb_PersonID);
            this.Pan_Main.Controls.Add(this.PicBox_Person);
            this.Pan_Main.Controls.Add(this.Lb_Country);
            this.Pan_Main.Controls.Add(this.Lb_Phone);
            this.Pan_Main.Controls.Add(this.Lb_Address);
            this.Pan_Main.Controls.Add(this.Lb_Email);
            this.Pan_Main.Controls.Add(this.Lb_LastName);
            this.Pan_Main.Controls.Add(this.Lb_FirstName);
            this.Pan_Main.Controls.Add(this.Btn_Cancel);
            this.Pan_Main.Controls.Add(this.Btn_Delete);
            this.Pan_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Pan_Main.Location = new System.Drawing.Point(0, 150);
            this.Pan_Main.Margin = new System.Windows.Forms.Padding(4);
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.Size = new System.Drawing.Size(1213, 465);
            this.Pan_Main.TabIndex = 1;
            // 
            // Lb_GetFirstName
            // 
            this.Lb_GetFirstName.AutoSize = true;
            this.Lb_GetFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetFirstName.ImageList = this.imageList1;
            this.Lb_GetFirstName.Location = new System.Drawing.Point(182, 106);
            this.Lb_GetFirstName.Name = "Lb_GetFirstName";
            this.Lb_GetFirstName.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetFirstName.TabIndex = 41;
            this.Lb_GetFirstName.Text = "0";
            this.Lb_GetFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // Lb_GetEmail
            // 
            this.Lb_GetEmail.AutoSize = true;
            this.Lb_GetEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetEmail.ImageList = this.imageList1;
            this.Lb_GetEmail.Location = new System.Drawing.Point(121, 163);
            this.Lb_GetEmail.Name = "Lb_GetEmail";
            this.Lb_GetEmail.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetEmail.TabIndex = 40;
            this.Lb_GetEmail.Text = "0";
            this.Lb_GetEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_GetAddress
            // 
            this.Lb_GetAddress.AutoSize = true;
            this.Lb_GetAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetAddress.ImageList = this.imageList1;
            this.Lb_GetAddress.Location = new System.Drawing.Point(147, 223);
            this.Lb_GetAddress.Name = "Lb_GetAddress";
            this.Lb_GetAddress.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetAddress.TabIndex = 39;
            this.Lb_GetAddress.Text = "0";
            this.Lb_GetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_GetLastName
            // 
            this.Lb_GetLastName.AutoSize = true;
            this.Lb_GetLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetLastName.ImageList = this.imageList1;
            this.Lb_GetLastName.Location = new System.Drawing.Point(701, 106);
            this.Lb_GetLastName.Name = "Lb_GetLastName";
            this.Lb_GetLastName.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetLastName.TabIndex = 38;
            this.Lb_GetLastName.Text = "0";
            this.Lb_GetLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_GetPhone
            // 
            this.Lb_GetPhone.AutoSize = true;
            this.Lb_GetPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetPhone.ImageList = this.imageList1;
            this.Lb_GetPhone.Location = new System.Drawing.Point(660, 167);
            this.Lb_GetPhone.Name = "Lb_GetPhone";
            this.Lb_GetPhone.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetPhone.TabIndex = 37;
            this.Lb_GetPhone.Text = "0";
            this.Lb_GetPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_GetCountry
            // 
            this.Lb_GetCountry.AutoSize = true;
            this.Lb_GetCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_GetCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GetCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_GetCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_GetCountry.ImageList = this.imageList1;
            this.Lb_GetCountry.Location = new System.Drawing.Point(674, 227);
            this.Lb_GetCountry.Name = "Lb_GetCountry";
            this.Lb_GetCountry.Size = new System.Drawing.Size(26, 29);
            this.Lb_GetCountry.TabIndex = 36;
            this.Lb_GetCountry.Text = "0";
            this.Lb_GetCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Lb_PersonID.Size = new System.Drawing.Size(129, 29);
            this.Lb_PersonID.TabIndex = 34;
            this.Lb_PersonID.Text = "Contact ID:";
            this.Lb_PersonID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PicBox_Person
            // 
            this.PicBox_Person.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.PicBox_Person.Image = global::Main_Contacts.Properties.Resources.unknown;
            this.PicBox_Person.Location = new System.Drawing.Point(953, 36);
            this.PicBox_Person.Name = "PicBox_Person";
            this.PicBox_Person.Size = new System.Drawing.Size(188, 216);
            this.PicBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Person.TabIndex = 32;
            this.PicBox_Person.TabStop = false;
            // 
            // Lb_Country
            // 
            this.Lb_Country.AutoSize = true;
            this.Lb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Country.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Country.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Country.ImageList = this.imageList1;
            this.Lb_Country.Location = new System.Drawing.Point(565, 229);
            this.Lb_Country.Name = "Lb_Country";
            this.Lb_Country.Size = new System.Drawing.Size(103, 27);
            this.Lb_Country.TabIndex = 30;
            this.Lb_Country.Text = "Country :";
            this.Lb_Country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.AutoSize = true;
            this.Lb_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Phone.ImageList = this.imageList1;
            this.Lb_Phone.Location = new System.Drawing.Point(569, 169);
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
            this.Lb_Address.Location = new System.Drawing.Point(36, 227);
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
            this.Lb_Email.Location = new System.Drawing.Point(36, 165);
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
            this.Lb_LastName.Location = new System.Drawing.Point(565, 106);
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
            this.Lb_FirstName.Location = new System.Drawing.Point(36, 106);
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
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(1001, 383);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(169, 45);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.ImageIndex = 9;
            this.Btn_Delete.ImageList = this.imageList1;
            this.Btn_Delete.Location = new System.Drawing.Point(604, 383);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(169, 45);
            this.Btn_Delete.TabIndex = 0;
            this.Btn_Delete.Text = "  Delete";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Search.ImageIndex = 8;
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(180, 93);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(117, 30);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txtbox_ID
            // 
            this.Txtbox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Txtbox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Txtbox_ID.Location = new System.Drawing.Point(316, 93);
            this.Txtbox_ID.Name = "Txtbox_ID";
            this.Txtbox_ID.Size = new System.Drawing.Size(206, 30);
            this.Txtbox_ID.TabIndex = 3;
            // 
            // Lb_EnterID
            // 
            this.Lb_EnterID.AutoSize = true;
            this.Lb_EnterID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterID.ForeColor = System.Drawing.Color.Silver;
            this.Lb_EnterID.Location = new System.Drawing.Point(321, 51);
            this.Lb_EnterID.Name = "Lb_EnterID";
            this.Lb_EnterID.Size = new System.Drawing.Size(79, 24);
            this.Lb_EnterID.TabIndex = 4;
            this.Lb_EnterID.Text = "Enter ID";
            // 
            // Lb_EnterName
            // 
            this.Lb_EnterName.AutoSize = true;
            this.Lb_EnterName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterName.ForeColor = System.Drawing.Color.Silver;
            this.Lb_EnterName.Location = new System.Drawing.Point(847, 51);
            this.Lb_EnterName.Name = "Lb_EnterName";
            this.Lb_EnterName.Size = new System.Drawing.Size(146, 24);
            this.Lb_EnterName.TabIndex = 7;
            this.Lb_EnterName.Text = "Enter Full Name";
            // 
            // Txtbox_Name
            // 
            this.Txtbox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Txtbox_Name.Location = new System.Drawing.Point(830, 93);
            this.Txtbox_Name.Name = "Txtbox_Name";
            this.Txtbox_Name.Size = new System.Drawing.Size(206, 30);
            this.Txtbox_Name.TabIndex = 6;
            // 
            // Btn_SearchFullName
            // 
            this.Btn_SearchFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.Btn_SearchFullName.FlatAppearance.BorderSize = 0;
            this.Btn_SearchFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchFullName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_SearchFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SearchFullName.ImageIndex = 8;
            this.Btn_SearchFullName.ImageList = this.imageList1;
            this.Btn_SearchFullName.Location = new System.Drawing.Point(706, 92);
            this.Btn_SearchFullName.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SearchFullName.Name = "Btn_SearchFullName";
            this.Btn_SearchFullName.Size = new System.Drawing.Size(117, 30);
            this.Btn_SearchFullName.TabIndex = 5;
            this.Btn_SearchFullName.Text = "Search";
            this.Btn_SearchFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SearchFullName.UseVisualStyleBackColor = false;
            this.Btn_SearchFullName.Click += new System.EventHandler(this.Btn_SearchFullName_Click);
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
            this.Pan_Title.Size = new System.Drawing.Size(1213, 48);
            this.Pan_Title.TabIndex = 9;
            this.Pan_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_Title_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Title.Location = new System.Drawing.Point(36, 11);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(153, 26);
            this.Lb_Title.TabIndex = 8;
            this.Lb_Title.Text = "Delete Contact";
            // 
            // Btn_Minmize
            // 
            this.Btn_Minmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(203)))));
            this.Btn_Minmize.FlatAppearance.BorderSize = 0;
            this.Btn_Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minmize.ImageIndex = 6;
            this.Btn_Minmize.ImageList = this.imageList1;
            this.Btn_Minmize.Location = new System.Drawing.Point(1037, 3);
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
            this.Btn_Exit.Location = new System.Drawing.Point(1155, 3);
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
            this.Btn_Maxmize.Location = new System.Drawing.Point(1096, 3);
            this.Btn_Maxmize.Name = "Btn_Maxmize";
            this.Btn_Maxmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Maxmize.TabIndex = 6;
            this.Btn_Maxmize.UseVisualStyleBackColor = true;
            this.Btn_Maxmize.Click += new System.EventHandler(this.Btn_Maxmize_Click);
            // 
            // FrmDeleteContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1213, 615);
            this.Controls.Add(this.Pan_Title);
            this.Controls.Add(this.Lb_EnterName);
            this.Controls.Add(this.Txtbox_Name);
            this.Controls.Add(this.Btn_SearchFullName);
            this.Controls.Add(this.Lb_EnterID);
            this.Controls.Add(this.Txtbox_ID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Pan_Main);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDeleteContact";
            this.Text = "FrmDeleteContact";
            this.Load += new System.EventHandler(this.FrmDeleteContact_Load);
            this.Resize += new System.EventHandler(this.FrmDeleteContact_Resize);
            this.Pan_Main.ResumeLayout(false);
            this.Pan_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Person)).EndInit();
            this.Pan_Title.ResumeLayout(false);
            this.Pan_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txtbox_ID;
        private System.Windows.Forms.Label Lb_EnterID;
        private System.Windows.Forms.Label Lb_EnterName;
        private System.Windows.Forms.TextBox Txtbox_Name;
        private System.Windows.Forms.Button Btn_SearchFullName;
        private System.Windows.Forms.Panel Pan_Title;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_Minmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Label Lb_PersonID;
        private System.Windows.Forms.PictureBox PicBox_Person;
        private System.Windows.Forms.Label Lb_Country;
        private System.Windows.Forms.Label Lb_Phone;
        private System.Windows.Forms.Label Lb_Address;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label Lb_LastName;
        private System.Windows.Forms.Label Lb_FirstName;
        private System.Windows.Forms.Label Lb_GetFirstName;
        private System.Windows.Forms.Label Lb_GetEmail;
        private System.Windows.Forms.Label Lb_GetAddress;
        private System.Windows.Forms.Label Lb_GetLastName;
        private System.Windows.Forms.Label Lb_GetPhone;
        private System.Windows.Forms.Label Lb_GetCountry;
    }
}