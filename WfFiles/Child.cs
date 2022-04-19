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
    public partial class Child : Form
    {
        // 1.1 version______________________________________________________
        //public Child(string str)
        //{
        //    InitializeComponent();
        //    tbChild.Text = str;
        //}

        //private void butClose_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
        // 1.2 version______________________________________________________
        //public string TText
        //{
        //    set
        //    {
        //        tbChild.Text = value;
        //    }
        //}
        //public Child()
        //{
        //    InitializeComponent();

        //}
        //private void butClose_Click(object sender, EventArgs e)
        //{
        //   Close();
        //}
        // 1.3 version______________________________________________________
        //public DialogResult ShowDialog(string str)
        //{
        //    tbChild.Text = str;
        //    return ShowDialog();
        //}
        //public Child()
        //{
        //    InitializeComponent();
        //}

        //private void butClose_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
        // 2.1 version______________________________________________________
        public DialogResult ShowDialog(string str)
        {
            tbChild.Text = str;
            return ShowDialog();
        }
        public Child()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_but_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        public string Ttext
        {
            get
            {
                return tbChild.Text;
            }
        }
    }
}
