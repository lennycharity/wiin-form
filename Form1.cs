using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView6_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void arerwe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculator(object sender, EventArgs e)
        {
            ar.Controls.Clear();
            Form3 chari = new Form3();
            chari.TopLevel = false;
            ar.Controls.Add(chari);
            chari.Show();
        }
    }
}
