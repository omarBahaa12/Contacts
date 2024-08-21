using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Main_Contacts
{
    public partial class FrmListContact : Form
    {
        private Size formsize;
        private int BorderSize;
        clsContact contact = new clsContact();
        public FrmListContact()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern int ReleaseCaputre();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(System.IntPtr ptr, int hty, int htr, int ewq);
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Maximized))
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
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
        private void FrmListContact_Load(object sender, EventArgs e)
        {
            formsize= this.ClientSize;
            PrintContactsInDataview();
        }

        private void PrintContactsInDataview()
        {
            var Contacts = clsContact.GetContacts();
            int Counter = 0;
            foreach (var Contact in Contacts) 
            {
                ListViewItem item= new ListViewItem(Contact.ContactID.ToString());
                item.SubItems.Add(Contact.FirstName+" "+Contact.LastName);
                item.SubItems.Add(Contact.Phone);
                item.SubItems.Add(Contact.Email);
                item.SubItems.Add(Contact.Adress);
                item.SubItems.Add(clsContact.GetCountryNameWithID(Contact.CountryID));
                imageList2.Images.Add(GetImage(Contact));
                item.ImageIndex = Counter;
                List_ContactsList.Items.Add(item);
                Counter++;
            }
        }

        private Image GetImage(clsContact contact)
        {
            if (contact.Image == null)
            {
                return imageList1.Images[10];
                
            } 
            MemoryStream stream= new MemoryStream(contact.Image);
            return Image.FromStream(stream);
        }

        private void FrmListContact_Resize(object sender, EventArgs e)
        {
            AdiustForm();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            FrmAddContact frm= new FrmAddContact();
            frm.ShowDialog();
        }    

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteContact frm= new FrmDeleteContact(contact.ContactID);
            frm.ShowDialog();
        }       

        private void DetailsStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDetails frm=new FrmDetails(contact);
            frm.ShowDialog();
        }

        private void List_ContactsList_ItemActivate(object sender, EventArgs e)
        {
            List_ContactsList.ContextMenuStrip = contextMenuStrip1;
            string ContactID = List_ContactsList.SelectedItems[0].SubItems[0].Text;
            contact.ContactID = Convert.ToInt32(ContactID.Trim());
            var FullName = List_ContactsList.SelectedItems[0].SubItems[1].Text.Split(' ');
            contact.FirstName = FullName[0];
            contact.LastName = FullName[1];
            contact.Phone = List_ContactsList.SelectedItems[0].SubItems[2].Text;
            contact.Email = List_ContactsList.SelectedItems[0].SubItems[3].Text;
            contact.Adress = List_ContactsList.SelectedItems[0].SubItems[4].Text;
            contact.CountryID = clsContact.GetCountryIDWithName(List_ContactsList.SelectedItems[0].SubItems[5].Text);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateContact frm=new FrmUpdateContact(contact.ContactID);
            frm.ShowDialog();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            imageList2.Images.Clear();
            List_ContactsList.Items.Clear();
            PrintContactsInDataview();
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
                    List_ContactsList.Items.Clear();
                    imageList2.Images.Clear();
                    ListViewItem item = new ListViewItem(contact.ContactID.ToString());
                    item.SubItems.Add(contact.FirstName + " " + contact.LastName);
                    item.SubItems.Add(contact.Phone);
                    item.SubItems.Add(contact.Email);
                    item.SubItems.Add(contact.Adress);
                    item.SubItems.Add(clsContact.GetCountryNameWithID(contact.CountryID));
                    imageList2.Images.Add(GetImage(contact));
                    item.ImageIndex = 0;
                    List_ContactsList.Items.Add(item);                    
                }

                else
                {
                    MessageBox.Show(" Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Btn_SearchFullName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtbox_ID.Text))
            {
                MessageBox.Show("Enter ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsContact.IsFound(Convert.ToInt32(Txtbox_ID.Text)))
                {
                    contact.GetContact(Convert.ToInt32(clsContact.GetContactID(Txtbox_Name.Text)));
                    List_ContactsList.Items.Clear();
                    imageList2.Images.Clear();
                    ListViewItem item = new ListViewItem(contact.ContactID.ToString());
                    item.SubItems.Add(contact.FirstName + " " + contact.LastName);
                    item.SubItems.Add(contact.Phone);
                    item.SubItems.Add(contact.Email);
                    item.SubItems.Add(contact.Adress);
                    item.SubItems.Add(clsContact.GetCountryNameWithID(contact.CountryID));
                    imageList2.Images.Add(GetImage(contact));
                    item.ImageIndex = 0;
                    List_ContactsList.Items.Add(item);
                }

                else
                {
                    MessageBox.Show(" Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
