using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines.Conctrete;

namespace FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UserManager userManager = new UserManager();
        private void button1_Click(object sender, EventArgs e)
        {
            var isLoginSuccess = userManager.Login(textBox1.Text, textBox2.Text);
            if (isLoginSuccess==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                UserLogin.LoginUser = isLoginSuccess;
                Form2 frm = new Form2();
                frm.ShowDialog();
                this.Hide();
            }
        }
    }
}
