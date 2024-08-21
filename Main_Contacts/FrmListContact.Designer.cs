namespace Main_Contacts
{
    partial class FrmListContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListContact));
            this.Pan_TitlePar = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Minmize = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.List_ContactsList = new System.Windows.Forms.ListView();
            this.ContactID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_EnterName = new System.Windows.Forms.Label();
            this.Txtbox_Name = new System.Windows.Forms.TextBox();
            this.Lb_EnterID = new System.Windows.Forms.Label();
            this.Txtbox_ID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DetailsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_SearchFullName = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Pan_TitlePar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.Pan_TitlePar.Size = new System.Drawing.Size(1468, 47);
            this.Pan_TitlePar.TabIndex = 3;
            this.Pan_TitlePar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Title.Location = new System.Drawing.Point(12, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(174, 28);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "List Contacts";
            // 
            // Btn_Minmize
            // 
            this.Btn_Minmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(203)))));
            this.Btn_Minmize.FlatAppearance.BorderSize = 0;
            this.Btn_Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minmize.ImageIndex = 6;
            this.Btn_Minmize.ImageList = this.imageList1;
            this.Btn_Minmize.Location = new System.Drawing.Point(1288, 3);
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
            this.imageList1.Images.SetKeyName(12, "add-user.png");
            this.imageList1.Images.SetKeyName(13, "refresh-button.png");
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 7;
            this.Btn_Maxmize.ImageList = this.imageList1;
            this.Btn_Maxmize.Location = new System.Drawing.Point(1343, 3);
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
            this.Btn_Exit.Location = new System.Drawing.Point(1398, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(45, 34);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // List_ContactsList
            // 
            this.List_ContactsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.List_ContactsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.List_ContactsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactID,
            this.FullName,
            this.Phone,
            this.Email,
            this.Address,
            this.Country});
            this.List_ContactsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.List_ContactsList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_ContactsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.List_ContactsList.FullRowSelect = true;
            this.List_ContactsList.HideSelection = false;
            this.List_ContactsList.LargeImageList = this.imageList2;
            this.List_ContactsList.Location = new System.Drawing.Point(0, 179);
            this.List_ContactsList.Name = "List_ContactsList";
            this.List_ContactsList.Size = new System.Drawing.Size(1468, 545);
            this.List_ContactsList.SmallImageList = this.imageList2;
            this.List_ContactsList.TabIndex = 4;
            this.List_ContactsList.UseCompatibleStateImageBehavior = false;
            this.List_ContactsList.View = System.Windows.Forms.View.Details;
            this.List_ContactsList.ItemActivate += new System.EventHandler(this.List_ContactsList_ItemActivate);
            // 
            // ContactID
            // 
            this.ContactID.Text = "ContactID";
            this.ContactID.Width = 179;
            // 
            // FullName
            // 
            this.FullName.Text = "FullName";
            this.FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FullName.Width = 251;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 189;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 232;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 227;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Country.Width = 161;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(50, 45);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Lb_EnterName
            // 
            this.Lb_EnterName.AutoSize = true;
            this.Lb_EnterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_EnterName.Location = new System.Drawing.Point(1233, 60);
            this.Lb_EnterName.Name = "Lb_EnterName";
            this.Lb_EnterName.Size = new System.Drawing.Size(129, 19);
            this.Lb_EnterName.TabIndex = 19;
            this.Lb_EnterName.Text = "Enter Full Name";
            // 
            // Txtbox_Name
            // 
            this.Txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_Name.Location = new System.Drawing.Point(1237, 102);
            this.Txtbox_Name.Name = "Txtbox_Name";
            this.Txtbox_Name.Size = new System.Drawing.Size(206, 27);
            this.Txtbox_Name.TabIndex = 18;
            // 
            // Lb_EnterID
            // 
            this.Lb_EnterID.AutoSize = true;
            this.Lb_EnterID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EnterID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_EnterID.Location = new System.Drawing.Point(728, 60);
            this.Lb_EnterID.Name = "Lb_EnterID";
            this.Lb_EnterID.Size = new System.Drawing.Size(70, 19);
            this.Lb_EnterID.TabIndex = 16;
            this.Lb_EnterID.Text = "Enter ID";
            // 
            // Txtbox_ID
            // 
            this.Txtbox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_ID.Location = new System.Drawing.Point(723, 102);
            this.Txtbox_ID.Name = "Txtbox_ID";
            this.Txtbox_ID.Size = new System.Drawing.Size(206, 27);
            this.Txtbox_ID.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailsStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 88);
            // 
            // DetailsStripMenuItem1
            // 
            this.DetailsStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsStripMenuItem1.Image = global::Main_Contacts.Properties.Resources.audit;
            this.DetailsStripMenuItem1.Name = "DetailsStripMenuItem1";
            this.DetailsStripMenuItem1.Size = new System.Drawing.Size(139, 28);
            this.DetailsStripMenuItem1.Text = "Details";
            this.DetailsStripMenuItem1.Click += new System.EventHandler(this.DetailsStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::Main_Contacts.Properties.Resources.remove_user;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.Image = global::Main_Contacts.Properties.Resources.transaction;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Add.ImageIndex = 12;
            this.Btn_Add.ImageList = this.imageList1;
            this.Btn_Add.Location = new System.Drawing.Point(17, 90);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(122, 49);
            this.Btn_Add.TabIndex = 20;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            this.Btn_SearchFullName.Location = new System.Drawing.Point(1099, 94);
            this.Btn_SearchFullName.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SearchFullName.Name = "Btn_SearchFullName";
            this.Btn_SearchFullName.Size = new System.Drawing.Size(117, 44);
            this.Btn_SearchFullName.TabIndex = 17;
            this.Btn_SearchFullName.Text = "Search";
            this.Btn_SearchFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SearchFullName.UseVisualStyleBackColor = false;
            this.Btn_SearchFullName.Click += new System.EventHandler(this.Btn_SearchFullName_Click);
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
            this.Btn_Search.Location = new System.Drawing.Point(580, 94);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(117, 44);
            this.Btn_Search.TabIndex = 14;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Refresh.ImageIndex = 13;
            this.Btn_Refresh.ImageList = this.imageList1;
            this.Btn_Refresh.Location = new System.Drawing.Point(252, 90);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(165, 48);
            this.Btn_Refresh.TabIndex = 21;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // FrmListContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1468, 724);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lb_EnterName);
            this.Controls.Add(this.Txtbox_Name);
            this.Controls.Add(this.Btn_SearchFullName);
            this.Controls.Add(this.Lb_EnterID);
            this.Controls.Add(this.Txtbox_ID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.List_ContactsList);
            this.Controls.Add(this.Pan_TitlePar);
            this.Name = "FrmListContact";
            this.Text = "FrmListContact";
            this.Load += new System.EventHandler(this.FrmListContact_Load);
            this.Resize += new System.EventHandler(this.FrmListContact_Resize);
            this.Pan_TitlePar.ResumeLayout(false);
            this.Pan_TitlePar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pan_TitlePar;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_Minmize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView List_ContactsList;
        private System.Windows.Forms.ColumnHeader ContactID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.Label Lb_EnterName;
        private System.Windows.Forms.TextBox Txtbox_Name;
        private System.Windows.Forms.Button Btn_SearchFullName;
        private System.Windows.Forms.Label Lb_EnterID;
        private System.Windows.Forms.TextBox Txtbox_ID;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailsStripMenuItem1;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}