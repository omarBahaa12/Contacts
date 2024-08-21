using NuGet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Contacts
{
    public partial class FrmDeleteContact : Form
    {
        private Size formSize;

        private byte BorderSize = 2;

        private clsContact contact = new clsContact();

        public FrmDeleteContact(int ID=0)
        {
            InitializeComponent();
            this.Padding = new Padding(BorderSize);
            Lb_GetAddress.Text = string.Empty;
            Lb_GetCountry.Text = string.Empty;
            Lb_GetEmail.Text = string.Empty;
            Lb_GetFirstName.Text = string.Empty;
            Lb_GetLastName.Text = string.Empty;
            Lb_GetPhone.Text = string.Empty;
            if(ID != 0) 
            {
                Txtbox_ID.Text=ID.ToString();
                Btn_Search_Click(this,new EventArgs());
            }
        }

        private void FrmDeleteContact_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void UnknownPerson()
        {
            Lb_GetAddress.Text = string.Empty;
            Lb_GetCountry.Text= string.Empty;
            Lb_GetEmail.Text = string.Empty;
            Lb_GetFirstName.Text = string.Empty;
            Lb_GetLastName.Text = string.Empty;
            Lb_GetPhone.Text = string.Empty;
            Lb_ID.Text = string.Empty;
            Txtbox_ID.Text = string.Empty;
            Txtbox_Name.Text = string.Empty;
        }

        private void AdiustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != BorderSize)
                        this.Padding = new Padding(BorderSize);
                    break;

            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern int ReleaseCaputre();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(System.IntPtr ptr, int hty, int htr, int ewq);

        private void Pan_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaputre();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void FrmDeleteContact_Resize(object sender, EventArgs e)
        {
            AdiustForm();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM = 0x0083;
            if (m.Msg == WM && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtbox_ID.Text))
            {
                MessageBox.Show("Enter ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsContact.IsFound(Convert.ToInt32(Txtbox_ID.Text)))
                {
                    contact.GetContact(Convert.ToInt32(Txtbox_ID.Text));
                    Lb_GetFirstName.Text = contact.FirstName;
                    Lb_GetLastName.Text = contact.LastName;
                    Lb_GetPhone.Text = contact.Phone;
                    Lb_ID.Text = contact.ContactID.ToString();
                    Lb_GetAddress.Text = contact.Adress;
                    Lb_GetCountry.Text = clsContact.GetCountryNameWithID(contact.CountryID);
                    Lb_GetEmail.Text = contact.Email;
                    PicBox_Person.Image = GetImage();
                    contact.Image = null;
                }

                else
                {
                    MessageBox.Show(" Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private Image GetImage()
        {
            if (contact.Image == null)
            {
                return imageList1.Images[10];

            }
            MemoryStream stream = new MemoryStream(contact.Image);
            return Image.FromStream(stream);
        }

        private void Btn_SearchFullName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtbox_Name.Text))
            {
                MessageBox.Show("Enter FullName ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsContact.IsFound(Txtbox_Name.Text))
                {

                    contact.GetContact(clsContact.GetContactID(Txtbox_Name.Text));
                    Lb_GetFirstName.Text = contact.FirstName;
                    Lb_GetLastName.Text = contact.LastName;
                    Lb_GetPhone.Text = contact.Phone;
                    Lb_ID.Text = contact.ContactID.ToString();
                    Lb_GetAddress.Text = contact.Adress;
                    Lb_GetCountry.Text = clsContact.GetCountryNameWithID(contact.CountryID);
                    Lb_GetEmail.Text = contact.Email;
                    PicBox_Person.Image = GetImage();
                    contact.Image = null;

                }
                else
                {
                    MessageBox.Show(" Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (!contact.IsEmpty())
            {
                if (MessageBox.Show("Are you sure to delete this contact", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    contact.Delete();
                    MessageBox.Show("Deleted Successfully", "Done");
                    UnknownPerson();
                }
            }
            else
            {
                MessageBox.Show("Please Enter ContactID or FullName","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maxmize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                return;
            }
            WindowState = FormWindowState.Maximized;

        }

        private void Btn_Minmize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
