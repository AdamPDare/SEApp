using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitisoftVendorAssignment
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /** Tasks left to do for registration Form
         *  Verify the users input to ensure its not NULL and Numbers are actually numbers.
         *  Encrypt the password at minimum to be then written to the DB CitisoftDB User_Information table
         *  Once their details have been logged, pop window pops up saying all complete. Returns user to login page
         **/




        // Struct that stores all the user information they have filled out
        struct userInformation 
        {
            public string password, userName, firstName, lastName, email;
            public int companyRole, userAge;
        }

        
        private void registerAccountButton_Click(object sender, EventArgs e, userInformation UI)
        {
            
            UI.userName=usernametxt.Text;
            UI.password=passwordtxt.Text; 
            UI.firstName=firstNametxt.Text;
            UI.lastName=lastNametxt.Text;
            UI.email=emailtxt.Text;
            UI.companyRole=companyRolecmb.SelectedIndex;
            UI.userAge = Int32.Parse(agetxt.Text);
        }

        private bool stringVerify (string userDetail)
        {
            return true;
        }

        private bool intVerify (int userDetails)
        {
            return true;
        }
    }
}
