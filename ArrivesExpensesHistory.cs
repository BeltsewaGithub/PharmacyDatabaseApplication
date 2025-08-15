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
    public partial class ArrivesExpensesHistory : Form
    {
        public ArrivesExpensesHistory()
        {
            InitializeComponent();
        }

        private void ArrivesExpensesHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Arrives' table. You can move, or remove it, as needed.
            this.arrivesTableAdapter.Fill(this.dataSet1.Arrives);
            // TODO: This line of code loads data into the 'dataSet1.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.dataSet1.Expenses);

        }
    }
}
