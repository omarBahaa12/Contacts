namespace Main_Contacts
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Pan_Menu = new System.Windows.Forms.Panel();
            this.Lb_UserContacts = new System.Windows.Forms.Label();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_ManageContacts = new System.Windows.Forms.Button();
            this.Pan_TitlePar = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Minmize = new System.Windows.Forms.Button();
            this.Btn_Maxmize = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Pan_Destop = new System.Windows.Forms.Panel();
            this.Btn_ListContact = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_UdateContact = new System.Windows.Forms.Button();
            this.Btn_DeleteContact = new System.Windows.Forms.Button();
            this.Btn_AddContact = new System.Windows.Forms.Button();
            this.Pan_Menu.SuspendLayout();
            this.Pan_TitlePar.SuspendLayout();
            this.Pan_Destop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Menu
            // 
            this.Pan_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pan_Menu.Controls.Add(this.Lb_UserContacts);
            this.Pan_Menu.Controls.Add(this.Btn_Menu);
            this.Pan_Menu.Controls.Add(this.Btn_ManageContacts);
            this.Pan_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Menu.Location = new System.Drawing.Point(0, 47);
            this.Pan_Menu.Name = "Pan_Menu";
            this.Pan_Menu.Size = new System.Drawing.Size(338, 688);
            this.Pan_Menu.TabIndex = 0;
            // 
            // Lb_UserContacts
            // 
            this.Lb_UserContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Lb_UserContacts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_UserContacts.Location = new System.Drawing.Point(12, 10);
            this.Lb_UserContacts.Name = "Lb_UserContacts";
            this.Lb_UserContacts.Size = new System.Drawing.Size(150, 74);
            this.Lb_UserContacts.TabIndex = 1;
            this.Lb_UserContacts.Text = "User\'s Contacts";
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu.ImageIndex = 1;
            this.Btn_Menu.ImageList = this.imageList1;
            this.Btn_Menu.Location = new System.Drawing.Point(194, 13);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(86, 61);
            this.Btn_Menu.TabIndex = 2;
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Brown;
            this.imageList1.Images.SetKeyName(0, "contact.png");
            this.imageList1.Images.SetKeyName(1, "menu-burger.png");
            this.imageList1.Images.SetKeyName(2, "reject.png");
            this.imageList1.Images.SetKeyName(3, "minus.png");
            this.imageList1.Images.SetKeyName(4, "maximize(1).png");
            this.imageList1.Images.SetKeyName(5, "contacts.png");
            // 
            // Btn_ManageContacts
            // 
            this.Btn_ManageContacts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_ManageContacts.FlatAppearance.BorderSize = 0;
            this.Btn_ManageContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ManageContacts.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ManageContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_ManageContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ManageContacts.ImageIndex = 5;
            this.Btn_ManageContacts.ImageList = this.imageList1;
            this.Btn_ManageContacts.Location = new System.Drawing.Point(3, 105);
            this.Btn_ManageContacts.Name = "Btn_ManageContacts";
            this.Btn_ManageContacts.Size = new System.Drawing.Size(332, 63);
            this.Btn_ManageContacts.TabIndex = 2;
            this.Btn_ManageContacts.Tag = "Manage Contacts ";
            this.Btn_ManageContacts.Text = "   Manage Contacts ";
            this.Btn_ManageContacts.UseVisualStyleBackColor = true;
            this.Btn_ManageContacts.Click += new System.EventHandler(this.Btn_ManageContacts_Click);
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
            this.Pan_TitlePar.Size = new System.Drawing.Size(1274, 47);
            this.Pan_TitlePar.TabIndex = 1;
            this.Pan_TitlePar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_TitlePar_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Lb_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Lb_Title.Location = new System.Drawing.Point(39, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(226, 28);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "Manage Contacts";
            // 
            // Btn_Minmize
            // 
            this.Btn_Minmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(203)))));
            this.Btn_Minmize.FlatAppearance.BorderSize = 0;
            this.Btn_Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minmize.ImageIndex = 3;
            this.Btn_Minmize.ImageList = this.imageList1;
            this.Btn_Minmize.Location = new System.Drawing.Point(1094, 3);
            this.Btn_Minmize.Name = "Btn_Minmize";
            this.Btn_Minmize.Size = new System.Drawing.Size(45, 34);
            this.Btn_Minmize.TabIndex = 2;
            this.Btn_Minmize.UseVisualStyleBackColor = false;
            this.Btn_Minmize.Click += new System.EventHandler(this.Btn_Minmize_Click);
            // 
            // Btn_Maxmize
            // 
            this.Btn_Maxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maxmize.FlatAppearance.BorderSize = 0;
            this.Btn_Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maxmize.ImageIndex = 4;
            this.Btn_Maxmize.ImageList = this.imageList1;
            this.Btn_Maxmize.Location = new System.Drawing.Point(1149, 3);
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
            this.Btn_Exit.ImageIndex = 2;
            this.Btn_Exit.ImageList = this.imageList1;
            this.Btn_Exit.Location = new System.Drawing.Point(1204, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(45, 34);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Pan_Destop
            // 
            this.Pan_Destop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Pan_Destop.Controls.Add(this.Btn_ListContact);
            this.Pan_Destop.Controls.Add(this.Btn_UdateContact);
            this.Pan_Destop.Controls.Add(this.Btn_DeleteContact);
            this.Pan_Destop.Controls.Add(this.Btn_AddContact);
            this.Pan_Destop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Destop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Pan_Destop.Location = new System.Drawing.Point(0, 0);
            this.Pan_Destop.Name = "Pan_Destop";
            this.Pan_Destop.Size = new System.Drawing.Size(1274, 735);
            this.Pan_Destop.TabIndex = 2;
            // 
            // Btn_ListContact
            // 
            this.Btn_ListContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_ListContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ListContact.FlatAppearance.BorderSize = 0;
            this.Btn_ListContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ListContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_ListContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ListContact.ImageIndex = 3;
            this.Btn_ListContact.ImageList = this.imageList2;
            this.Btn_ListContact.Location = new System.Drawing.Point(830, 435);
            this.Btn_ListContact.Name = "Btn_ListContact";
            this.Btn_ListContact.Size = new System.Drawing.Size(358, 178);
            this.Btn_ListContact.TabIndex = 3;
            this.Btn_ListContact.Text = "List Contact";
            this.Btn_ListContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ListContact.UseVisualStyleBackColor = false;
            this.Btn_ListContact.Visible = false;
            this.Btn_ListContact.Click += new System.EventHandler(this.Btn_ListContact_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "add-user.png");
            this.imageList2.Images.SetKeyName(1, "remove-user.png");
            this.imageList2.Images.SetKeyName(2, "transaction.png");
            this.imageList2.Images.SetKeyName(3, "customer.png");
            // 
            // Btn_UdateContact
            // 
            this.Btn_UdateContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_UdateContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UdateContact.FlatAppearance.BorderSize = 0;
            this.Btn_UdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UdateContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UdateContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_UdateContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UdateContact.ImageIndex = 2;
            this.Btn_UdateContact.ImageList = this.imageList2;
            this.Btn_UdateContact.Location = new System.Drawing.Point(360, 435);
            this.Btn_UdateContact.Name = "Btn_UdateContact";
            this.Btn_UdateContact.Size = new System.Drawing.Size(358, 178);
            this.Btn_UdateContact.TabIndex = 2;
            this.Btn_UdateContact.Text = "Update Contact";
            this.Btn_UdateContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_UdateContact.UseVisualStyleBackColor = false;
            this.Btn_UdateContact.Visible = false;
            this.Btn_UdateContact.Click += new System.EventHandler(this.Btn_UdateContact_Click);
            // 
            // Btn_DeleteContact
            // 
            this.Btn_DeleteContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_DeleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteContact.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_DeleteContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DeleteContact.ImageIndex = 1;
            this.Btn_DeleteContact.ImageList = this.imageList2;
            this.Btn_DeleteContact.Location = new System.Drawing.Point(851, 91);
            this.Btn_DeleteContact.Name = "Btn_DeleteContact";
            this.Btn_DeleteContact.Size = new System.Drawing.Size(337, 178);
            this.Btn_DeleteContact.TabIndex = 1;
            this.Btn_DeleteContact.Text = "Delete Contact";
            this.Btn_DeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_DeleteContact.UseVisualStyleBackColor = false;
            this.Btn_DeleteContact.Visible = false;
            this.Btn_DeleteContact.Click += new System.EventHandler(this.Btn_DeleteContact_Click);
            // 
            // Btn_AddContact
            // 
            this.Btn_AddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Btn_AddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddContact.FlatAppearance.BorderSize = 0;
            this.Btn_AddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(193)))), ((int)(((byte)(246)))));
            this.Btn_AddContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddContact.ImageIndex = 3;
            this.Btn_AddContact.ImageList = this.imageList2;
            this.Btn_AddContact.Location = new System.Drawing.Point(360, 103);
            this.Btn_AddContact.Name = "Btn_AddContact";
            this.Btn_AddContact.Size = new System.Drawing.Size(358, 178);
            this.Btn_AddContact.TabIndex = 0;
            this.Btn_AddContact.Text = "Add Contact";
            this.Btn_AddContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AddContact.UseVisualStyleBackColor = false;
            this.Btn_AddContact.Visible = false;
            this.Btn_AddContact.Click += new System.EventHandler(this.Btn_AddContact_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1274, 735);
            this.Controls.Add(this.Pan_Menu);
            this.Controls.Add(this.Pan_TitlePar);
            this.Controls.Add(this.Pan_Destop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.Text = "   Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Frm_Main_Resize);
            this.Pan_Menu.ResumeLayout(false);
            this.Pan_TitlePar.ResumeLayout(false);
            this.Pan_TitlePar.PerformLayout();
            this.Pan_Destop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Menu;
        private System.Windows.Forms.Label Lb_UserContacts;
        private System.Windows.Forms.Button Btn_ManageContacts;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Panel Pan_TitlePar;
        private System.Windows.Forms.Panel Pan_Destop;
        private System.Windows.Forms.Button Btn_Minmize;
        private System.Windows.Forms.Button Btn_Maxmize;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_AddContact;
        public System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button Btn_ListContact;
        private System.Windows.Forms.Button Btn_UdateContact;
        private System.Windows.Forms.Button Btn_DeleteContact;
    }
}

