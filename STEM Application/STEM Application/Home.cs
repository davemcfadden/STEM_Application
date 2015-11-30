using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace STEM_Application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


       

        private void logout_event(object sender, EventArgs e)
        {
            this.Hide();
            LoginAndSignUp login = new LoginAndSignUp();
            login.Show();
        }


    }
}
