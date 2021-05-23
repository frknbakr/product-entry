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
using Entities;

namespace FormUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private UserManager userManager = new UserManager();
        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Name = textBox1.Text;
            user.OperationGroupId = User.Groups.Customer;
            user.PhoneNumber = textBox2.Text;
            user.BirthDate = dateTimePicker1.Value;
            user.Password = textBox3.Text;
            user.LastName = textBox4.Text;
            
            userManager.Create(user);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
