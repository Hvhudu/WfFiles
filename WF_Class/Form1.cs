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
    public partial class Form1 : Form
    {
        Product prod = null;
        public Form1()
        {
            InitializeComponent();
        }

        //private void Add_but_Click(object sender, EventArgs e)
        //{
        //    prod = new Product();
        //    Form2 form = new Form2(prod, true);
        //    if (form.ShowDialog() == DialogResult.OK)
        //        list.Items.Add(prod);
        //}

        private void Red_but_Click(object sender, EventArgs e)
        {
            Product prod1 = new Product();
            Form2 form = new Form2(prod, true);
            int index = new int();       
            if (form.ShowDialog() == DialogResult.OK)
            {
                index = list.SelectedIndex;
                prod1 = (Product)list.Items[index];
                list.Items.RemoveAt(index);
                list.Items.Insert(index,prod1);
            }
            
        }

        private void Del_but_Click(object sender, EventArgs e)
        {
            if (list.SelectedIndex == -1)
            {
                MessageBox.Show("Error");
            }
            else
                list.Items.RemoveAt(list.SelectedIndex);
        }

        private void Clear_but_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            prod = new Product();
                Form2 form = new Form2(prod, true);         
                if (form.ShowDialog() == DialogResult.OK)
                    list.Items.Add(prod);
        }
    }
}
