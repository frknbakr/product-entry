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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private TechnicalServicesManager Manager = new TechnicalServicesManager();

        private void button1_Click(object sender, EventArgs e)
        {
            var user = (ComboboxItem)comboBox2.SelectedItem;
            var product = (ComboboxItem)comboBox1.SelectedItem;
            var technicalService = new TechnicalService();
            technicalService.DeliveryDate = dateTimePicker1.Value;
            technicalService.AdmissionDate = DateTime.Now;
            technicalService.CustomerId = (int) user.Value;
            technicalService.ProductId = (int) product.Value;
            technicalService.TechnicalId = UserLogin.LoginUser.Id;
            technicalService.TotalPrice = Convert.ToDouble(textBox1.Text);
            technicalService.Description = richTextBox1.Text;
            Manager.Create(technicalService);

        }
    }
}
