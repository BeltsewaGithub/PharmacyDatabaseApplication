using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmasyApplication
{
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Provider form = new Provider();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pharmacist form = new Pharmacist();
            form.Show();
        }
    }
}
