using PublishingHouseClient2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmasyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void previewControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StockItems' table. You can move, or remove it, as needed.
            this.stockItemsTableAdapter.Fill(this.dataSet1.StockItems);
            sqlConnection1.Open();
            string textCom = "SELECT salePrice FROM StockItems WHERE Name = '" + comboBox1.Text + "'";
            SqlCommand command1 = new SqlCommand(textCom, sqlConnection1);
            var reader = command1.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = reader[0].ToString() + " руб.";
            }
            sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string commandText = "DELETE FROM TempTableExpensesReport";
            SqlCommand command = new SqlCommand(commandText, sqlConnection1);
            command.ExecuteNonQuery();
            sqlConnection1.Close();

            sqlCommand1.Parameters["@dateStart"].Value =
                dateTimePicker1.Text;
            sqlCommand1.Parameters["@dateEnd"].Value =
                dateTimePicker2.Text;
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            stiReport1["dateStart"] = dateTimePicker1.Value;
            stiReport1["dateEnd"] = dateTimePicker2.Value;
            stiReport1.Load(@"C:\Users\Polina\source\repos\PharmasyApplication\sources\ReportExpenses4.mrt");
            
            stiReport1.Compile();
            stiReport1.Show();

        }

private void button2_Click(object sender, EventArgs e)
{
sqlConnection1.Open();
string commandText = "SELECT dbo.getSumCost()";
SqlCommand command = new SqlCommand(commandText, sqlConnection1);
SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    label1.Text = reader[0].ToString() + " руб.";                
}      
sqlConnection1.Close();
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

private void button3_Click(object sender, EventArgs e)
{
sqlConnection1.Open();
sqlCommand2.Parameters["@item"].Value = comboBox1.Text;
sqlCommand2.Parameters["@price"].Value = textBox1.Text;
MessageBox.Show("Цена обновлена");
sqlCommand2.ExecuteNonQuery();
sqlConnection1.Close();
}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBox1.Text);
;        }
    }
}
