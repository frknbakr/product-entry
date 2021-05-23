using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines;
using Bussines.Conctrete;
using Entities;

namespace FormUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private ProductManager productManager = new ProductManager();
        private UserManager userManager = new UserManager();
        private AddressManager addressManager = new AddressManager();
        private OrderProductManager OrderProduct = new OrderProductManager();
        private OrderManager OrderManager = new OrderManager();
        private void button1_Click(object sender, EventArgs e)
        {
            var ss = (ComboboxItem)comboBox1.SelectedItem;
            var ssa = (ComboboxItem)comboBox2.SelectedItem;
            var addressId = addressManager.CreateSendId(new Address
            {
                FullAddress = textBox1.Text,
                UserId = Convert.ToInt32(ss.Value)
            });
        
            var order = new Order
            {
                AddressId = addressId,
                OrderDate = DateTime.Now,
                OrderStatus = 0,
                UserId = Convert.ToInt32(ss.Value),
            };
            var orderId = OrderManager.CreateSendId(order);
            var orderProducts = new OrderProduct
            {
                OrderId = orderId,
                ProductId = Convert.ToInt32(ssa.Value),

            };
            OrderProduct.Create(orderProducts);


        }


        private void Form4_Load(object sender, EventArgs e)
        {
            var products = productManager.GetAll();
            var users = userManager = new UserManager();
            foreach (var user in users.GetCustomers())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = user.Name + " " + user.LastName;
                item.Value = user.Id;
                comboBox1.Items.Add(item);
            }
            foreach (var product in products)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = product.Name;
                item.Value = product.Id;
                comboBox2.Items.Add(item);
            }
        }
    }
}
