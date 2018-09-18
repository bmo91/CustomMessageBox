using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowMessage("Hello, World!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(MyMessageBox.ShowMessage("Are you sure you want to delete this record?", "Messager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyMessageBox.ShowMessage("Yes!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
                MyMessageBox.ShowMessage("No!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
