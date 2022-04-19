using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfFiles
{
    public partial class Parent : Form
    {
        // 1.1 version______________________________________________________
        //public Parent()
        //{
        //    InitializeComponent();
        //}

        //private void butShow_Click(object sender, EventArgs e)
        //{
        //    Child child = new Child(tbParent.Text);
        //    child.ShowDialog();
        //}


        // 1.2 version______________________________________________________
        //public Parent()
        //{
        //    InitializeComponent();
        //}

        //private void butShow_Click(object sender, EventArgs e)
        //{
        //    Child child = new Child();
        //    child.ShowDialog();
        //}


        // 1.3 version______________________________________________________
        //private void butShow_Click(object sender, EventArgs e)
        //{
        //    Child child = new Child();
        //    child.ShowDialog(tbParent.Text);
        //}
        // 2.1 version______________________________________________________
        public Parent()
          {
              InitializeComponent();
          }

          private void butShow_Click(object sender, EventArgs e)
          {
              Child child = new Child();
              
          }

        private void Clear_but_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Del_but_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Error");
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            if (child.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(child.Ttext);
        }
    }
}
