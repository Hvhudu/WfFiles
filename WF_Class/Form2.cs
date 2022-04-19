using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Class
{
    public partial class Form2 : Form
    {
        Product prod;
        bool addnew;
        public Form2(Product product, bool Addnew)
        {
            InitializeComponent();
            addnew = Addnew;
            prod = product;
            if (addnew == false)
            {
                textBox1.Text = product.Name;
                textBox2.Text = product.Fabricator;
                textBox3.Text = product.Price.ToString();
                Text = "Редактирование товара";
            }
            else
                Text = "Добавление товара";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""|| textBox2.Text == ""|| textBox3.Text == "")
            {
                MessageBox.Show("Error");
            }
            if (prod == null) 
                prod = new Product();
            prod.Name = textBox1.Text;
            prod.Fabricator = textBox2.Text;
            try
            {
                prod.Price = Convert.ToDouble(textBox3.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
