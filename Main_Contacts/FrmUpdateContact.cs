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
    public partial class FrmUpdateContact : Form
    {
        private Size formsize;
        
        private clsContact contact=new clsContact();

        private int BorderSize = 2;
        public FrmUpdateContact(int ID=0)
        {
            InitializeComponent();
            this.Padding = new Padding(BorderSize);
            if(ID != 0 ) 
            {
                Txtbox_ID.Text=ID.ToString();
                Btn_Search_Click(this,new EventArgs());
            }
            
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern int ReleaseCaputre();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(System.IntPtr ptr, int hty, int htr, int ewq);
        private void FrmUpdateContact_Load(object sender, EventArgs e)
        {
            formsize = this.ClientSize;
            var CountryName= clsContact.GetNameofCountries();
            foreach(var line in CountryName)
            {
                Combox_Countries.Items.Add(line);
            }
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
            WindowState=FormWindowState.Maximized;
        }

        private void Btn_Minmize_Click(object sender, EventArgs e)
        {
            formsize = this.ClientSize;
            WindowState = FormWindowState.Minimized;
        }

        private void Pan_TitlePar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaputre();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formsize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formsize;
            }
            base.WndProc(ref m);
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

        private void FrmUpdateContact_Resize(object sender, EventArgs e)
        {
            AdiustForm();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    Txtb_FirstName.Text = contact.FirstName;
                    Txtb_LastName.Text = contact.LastName;
                    Txtb_Phone.Text = contact.Phone;
                    Lb_ID.Text = contact.ContactID.ToString();
                    Txtb_Address.Text = contact.Adress;
                    Combox_Countries.Text = clsContact.GetCountryNameWithID(contact.CountryID);                
                    Txtb_Email.Text = contact.Email;
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
                    Txtb_FirstName.Text = contact.FirstName;
                    Txtb_LastName.Text = contact.LastName;
                    Txtb_Phone.Text = contact.Phone;
                    Lb_ID.Text = contact.ContactID.ToString();
                    Txtb_Address.Text = contact.Adress;
                    Combox_Countries.SelectedText = clsContact.GetCountryNameWithID(contact.CountryID);
                    Txtb_Email.Text = contact.Email;
                    PicBox_Person.Image = GetImage();
                    contact.Image = null;

                }
                else
                {
                    MessageBox.Show(" Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (!contact.IsEmpty())
            {
                if (MessageBox.Show("Are you sure to Update this contact", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    UpdateContactClass();
                    if (contact.Update())
                    {
                        MessageBox.Show("Updated Successfully", "Done");
                        UnknownPerson();
                    }
                    else
                        MessageBox.Show("SomeThing went Wrong", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter ContactID or FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateContactClass()
        {
            contact.FirstName=Txtb_FirstName.Text;
            contact.LastName=Txtb_LastName.Text;
            contact.Phone=Txtb_Phone.Text;
            contact.Email=Txtb_Email.Text;
            contact.Adress=Txtb_Address.Text;
            contact.CountryID=clsContact.GetCountryIDWithName(Combox_Countries.Text.ToString());
            PicBox_Person.Image.Save(contact.streamImage, PicBox_Person.Image.RawFormat);
        }

        private void UnknownPerson()
        {
            Txtb_Email.Text = string.Empty;
            Txtb_Address.Text = string.Empty;
            Combox_Countries.Text = string.Empty;
            Txtb_FirstName.Text = string.Empty;
            Txtb_LastName.Text = string.Empty;
            Txtb_Phone.Text = string.Empty;
            Lb_ID.Text = string.Empty;
            Txtbox_ID.Text = string.Empty;
            Txtbox_Name.Text = string.Empty;
            PicBox_Person.Image = imageList1.Images[10];
        }

        private void Btn_SetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";

            openFileDialog1.DefaultExt = "png,jpeg";

            openFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg) |*.jpeg| JPG files (*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicBox_Person.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void Txtb_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Txtb_FirstName.Text))
            {
                e.Cancel = true;
                Txtb_FirstName.Focus();
                errorProvider1.SetError(Txtb_FirstName, "Should Have Value");
                return;
            }
            return;
        }

        private void Txtb_LastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Txtb_LastName.Text))
            {
                e.Cancel = true;
                Txtb_FirstName.Focus();
                errorProvider1.SetError(Txtb_LastName, "Should Have Value");
                return;
            }
            return;
        }       

        private void Txtb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Txtb_Phone.Text))
            {
                e.Cancel = true;
                Txtb_FirstName.Focus();
                errorProvider1.SetError(Txtb_Phone, "Should Have Value");
                return;
            }
            return;
        }

        private void Txtb_Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Txtb_Address.Text))
            {
                e.Cancel = true;
                Txtb_FirstName.Focus();
                errorProvider1.SetError(Txtb_Address, "Should Have Value");
                return;
            }
            return;
        }

        
    }
}
