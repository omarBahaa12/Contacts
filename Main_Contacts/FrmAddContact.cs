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
    public partial class FrmAddContact : Form
    {
        private Size formSize;

        private int BorderSize = 2; 

        public FrmAddContact()
        {
            InitializeComponent();
            this.Padding = new Padding(BorderSize);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Minmize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmAddContact_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            var CountriesName = clsContact.GetNameofCountries();
            foreach (var line in CountriesName)
            {
                Cm_Country.Items.Add(line);
            }
        }

        private void FrmAddContact_Resize(object sender, EventArgs e)
        {
            AdiustForm();
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

        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        //    const int SC_RESTORE = 0xF120; //Restore form (Before)
        //    const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        //    const int resizeAreaSize = 10;

        //    #region Form Resize
        //    // Resize/WM_NCHITTEST values
        //    const int HTCLIENT = 1; //Represents the client area of the window
        //    const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        //    const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        //    const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        //    const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        //    const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        //    const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        //    const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        //    const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

        //    ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

        //    if (m.Msg == WM_NCHITTEST)
        //    { //If the windows m is WM_NCHITTEST
        //        base.WndProc(ref m);
        //        if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
        //        {
        //            if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
        //            {
        //                Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
        //                Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

        //                if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
        //                        m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
        //                        m.Result = (IntPtr)HTTOP; //Resize vertically up
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTTOPRIGHT;
        //                }
        //                else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
        //                        m.Result = (IntPtr)HTLEFT;
        //                    else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
        //                        m.Result = (IntPtr)HTRIGHT;
        //                }
        //                else
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
        //                        m.Result = (IntPtr)HTBOTTOMLEFT;
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
        //                        m.Result = (IntPtr)HTBOTTOM;
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTBOTTOMRIGHT;
        //                }
        //            }
        //        }
        //        return;
        //    }
        //    #endregion

        //    //Remove border and keep snap window
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    {
        //        return;
        //    }

        //    //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        //    if (m.Msg == WM_SYSCOMMAND)
        //    {
        //        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
        //        /// Quote:
        //        /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
        //        /// are used internally by the system.To obtain the correct result when testing 
        //        /// the value of wParam, an application must combine the value 0xFFF0 with the 
        //        /// wParam value by using the bitwise AND operator.
        //        int wParam = (m.WParam.ToInt32() & 0xFFF0);

        //        if (wParam == SC_MINIMIZE)  //Before
        //            formSize = this.ClientSize;
        //        if (wParam == SC_RESTORE)// Restored form(Before)
        //            this.Size = formSize;
        //    }
        //    base.WndProc(ref m);
        //}

        protected override void WndProc(ref Message m)
        {
            const int WM = 0x0083;
            if (m.Msg == WM && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Pan_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaputre();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Btn_SetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory=@"D:\";

            openFileDialog1.DefaultExt = "png,jpeg";

            openFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg) |*.jpeg| JPG files (*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                PicBox_Person.Image = new Bitmap(openFileDialog1.FileName);
            }

        }

        private void FillfullContact(ref clsContact contact)
        {

            contact.FirstName=Tbox_FirstName.Text;
            contact.LastName=Tbox_LastName.Text;
            contact.Email=Tbox_Email.Text;
            contact.Phone=Tbox_Phone.Text;
            contact.Adress=Tbox_Address.Text;
            PicBox_Person.Image.Save(contact.streamImage, PicBox_Person.Image.RawFormat);
            contact.CountryID = clsContact.GetCountryIDWithName(Cm_Country.SelectedItem.ToString());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            clsContact contact = new clsContact();
            FillfullContact(ref contact);
            int ID=contact.AddNewContact();
            if (ID != -1)
            {
                Lb_ID.Text = ID.ToString();
                MessageBox.Show("Added Successfully", "Information");
            }
            else
                MessageBox.Show("Failed to Add", "Information");

        }

        private void Tbox_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Tbox_FirstName.Text))
            {
                e.Cancel = true;
                Tbox_FirstName.Focus();
                errorProvider1.SetError(Tbox_FirstName, "Should Have Value");
            }
            else
            {
                e.Cancel= false;

            }
        }

        private void Tbox_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbox_Phone.Text))
            {
                e.Cancel = true;
                Tbox_FirstName.Focus();
                errorProvider1.SetError(Tbox_Phone, "Should Have Value");
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void Tbox_Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbox_Address.Text))
            {
                e.Cancel = true;
                Tbox_FirstName.Focus();
                errorProvider1.SetError(Tbox_Address, "Should Have Value");
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void Cm_Country_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Cm_Country.Text))
            {
                e.Cancel = true;
                Tbox_FirstName.Focus();
                errorProvider1.SetError(Cm_Country, "Should Have Value");
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
