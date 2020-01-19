using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp signUpForm = new signUp();
            signUpForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signIn signIn = new signIn();
            signIn.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminLogIn adminLogIn = new adminLogIn();
            adminLogIn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            this.Hide();
        }
    }
}
