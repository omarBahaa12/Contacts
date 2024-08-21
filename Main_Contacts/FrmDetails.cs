using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Contacts
{
    public partial class FrmDetails : Form
    {
        public FrmDetails(clsContact contact)
        {
            InitializeComponent();
            
            Lb_FirstName.Text = contact.FirstName;
            Lb_LastName.Text = contact.LastName;
            Lb_Email.Text = contact.Email;
            Lb_Phone.Text = contact.Phone;
            Lb_Address.Text = contact.Adress;
            Lb_Country.Text=clsContact.GetCountryNameWithID(contact.CountryID);
        }

       
    }
}
