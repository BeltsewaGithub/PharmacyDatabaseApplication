using PharmasyApplication.DataSet1TableAdapters;
using PublishingHouseClient2;
using Spire.Xls;
using Spire.Xls.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmasyApplication
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
try
{ 
               
            
addArrive.Parameters["@item"].Value =
comboBoxItemName.Text;
addArrive.Parameters["@orderDate"].Value =
dateTimePickerOrder.Text;
addArrive.Parameters["@quantity"].Value =
textBoxQuantity.Text;
addArrive.Parameters["@salePrice"].Value =
textBoxSalePriceArrive.Text;                
addArrive.Parameters["@provider"].Value =
comboBoxProvider.Text;
                
var confirmResult = MessageBox.Show("Подтвердить создание заказа?", "Подтвердить создание заказа?", MessageBoxButtons.YesNo);
if (confirmResult == DialogResult.Yes)
{
ArrayList batches = new ArrayList();
sqlConnection1.Open();

SqlDataReader reader = addArrive.ExecuteReader();
                    
if (reader.HasRows)
{
while (reader.Read())
{
string[] row = new string[3];
row[0] = reader.GetValue(0).ToString();
row[1] = reader.GetValue(1).ToString();
row[2] = reader.GetValue(2).ToString();
batches.Add(row);
this.providersItemsTableAdapter.Fill(this.dataSet1.ProvidersItems);
this.getExpiredItemsTableAdapter.Fill(this.dataSet1.getExpiredItems);
this.simpleItemsInStockTableAdapter.Fill(this.dataSet1.SimpleItemsInStock);
this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);

}
reader.Close();
string cost = addArrive.Parameters["@cost"].Value.ToString();
Workbook wb = new Workbook();
wb.LoadFromFile(@"C:\Users\Polina\source\repos\PharmasyApplication\sources\billArriveTemplate.xlsx");
Worksheet sheet = wb.Worksheets[0];
DateTime dtp = dateTimePickerOrder.Value;
sheet.Range["D1"].Text = sheet.Range["D1"].Text.Replace("<day>", dtp.Day.ToString());
sheet.Range["E1"].Text = sheet.Range["E1"].Text.Replace("<month>", getMonth(dtp.Month)); //Convert.ToInt32
sheet.Range["F1"].Text = sheet.Range["F1"].Text.Replace("<year>", dtp.Year.ToString());
int rowNumber = 0;
foreach (string[] l in batches)
{
int currentRow = rowNumber + 4;
string cellName = "B" + currentRow.ToString();
string cellBatch = "C" + currentRow.ToString();
string cellQuantity = "D" + currentRow.ToString();
string cellPrice = "E" + currentRow.ToString();
sheet.Range[cellName].Text = comboBoxItemName.Text;
sheet.Range[cellBatch].Text = l[0].ToString();
sheet.Range[cellPrice].Text = l[1].ToString();
sheet.Range[cellQuantity].Text = l[2].ToString();
rowNumber++;
}
sheet.Range["E11"].Text = cost;
//Получение последнего номера накладной
string pathToTextFile = @"C:\Users\Polina\source\repos\PharmasyApplication\sources\Bills.txt";
string[] billsNumberFromFile = File.ReadAllLines(pathToTextFile);
int currentNumber = Convert.ToInt32(billsNumberFromFile[billsNumberFromFile.Length - 1]) + 1;
string numberOfBillFinalToWrite = generateBillNameEightNumbers(currentNumber);
File.AppendAllText(pathToTextFile, "\n" + currentNumber.ToString());
sheet.Range["A2"].Text = sheet.Range["A2"].Text.Replace("<number>", numberOfBillFinalToWrite);
string filepath = @"C:\Users\Polina\source\repos\PharmasyApplication\bills\" + @"Накладная_" + numberOfBillFinalToWrite + ".xlsx";

wb.SaveToFile(filepath, ExcelVersion.Version2016);

System.Diagnostics.Process.Start(filepath);
}
                    
MessageBox.Show(addArrive.Parameters["@message"].Value.ToString());
sqlConnection1.Close();                                    
}
}
catch (Exception ex)
{
MessageBox.Show(ex.Message);
}
        }
        private static string generateBillNameEightNumbers(int num)
        {
            int quantityOfSymbolsInBillNumber = 8;
            int quantityOfNumbers = num.ToString().Length;
            int numberOfZero = quantityOfSymbolsInBillNumber - quantityOfNumbers;
            //for (int i = 0; i <= 10000000; i++)
            //{
            //    if (num > Math.Pow(10, i) && num < Math.Pow(10, i + 1))
            //        numberOfZero = 7;
            //}
            return string.Join("", Enumerable.Repeat("0", numberOfZero)) + num.ToString();
        }
        private static string getMonth(int month)
        {
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "Января";
                    break;
                case 2:
                    monthName = "Февраля";
                    break;
                case 3:
                    monthName = "Марта";
                    break;
                case 4:
                    monthName = "Апреля";
                    break;
                case 5:
                    monthName = "Мая";
                    break;
                case 6:
                    monthName = "Июня";
                    break;
                case 7:
                    monthName = "Июля";
                    break;
                case 8:
                    monthName = "Августа";
                    break;
                case 9:
                    monthName = "Сентября";
                    break;
                case 10:
                    monthName = "Октября";
                    break;
                case 11:
                    monthName = "Ноября";
                    break;
                case 12:
                    monthName = "Декабря";
                    break;
                default:
                    monthName = "-";
                    break;
            }
            return monthName;
        }
        private void Pharmacist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StockItems' table. You can move, or remove it, as needed.
            this.stockItemsTableAdapter.Fill(this.dataSet1.StockItems);
            // TODO: This line of code loads data into the 'dataSet1.ProvidersItems' table. You can move, or remove it, as needed.
            this.providersItemsTableAdapter.Fill(this.dataSet1.ProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProviderItemsInStock". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProvidersItems". При необходимости она может быть перемещена или удалена.
            this.providersItemsTableAdapter.Fill(this.dataSet1.ProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.getProvidersItems". При необходимости она может быть перемещена или удалена.
            this.getProvidersItemsTableAdapter.Fill(this.dataSet1.getProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.getExpiredItems". При необходимости она может быть перемещена или удалена.
            this.getExpiredItemsTableAdapter.Fill(this.dataSet1.getExpiredItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet12.Batches". При необходимости она может быть перемещена или удалена.
            this.batchesTableAdapter.Fill(this.dataSet1.Batches);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet12.getExpiredItems". При необходимости она может быть перемещена или удалена.
            this.getExpiredItemsTableAdapter.Fill(this.dataSet1.getExpiredItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SimpleItemsInStock". При необходимости она может быть перемещена или удалена.
            this.simpleItemsInStockTableAdapter.Fill(this.dataSet1.SimpleItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.getItemsInStock". При необходимости она может быть перемещена или удалена.
            this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.getItemsInStock". При необходимости она может быть перемещена или удалена.
            this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.getProvidersItems". При необходимости она может быть перемещена или удалена.
            this.getProvidersItemsTableAdapter.Fill(this.dataSet1.getProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.getItemsInStock". При необходимости она может быть перемещена или удалена.
            this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Arrives". При необходимости она может быть перемещена или удалена.
            this.arrivesTableAdapter.Fill(this.dataSet1.Arrives);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProvidersItems". При необходимости она может быть перемещена или удалена.
            this.providersItemsTableAdapter.Fill(this.dataSet1.ProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProviderItemsInStock". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.getItemsInStock". При необходимости она может быть перемещена или удалена.
            this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.dataSet1.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dataSet1.Items);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProviderFilter_Click(object sender, EventArgs e)
        {
            try
            {
                providersItemsBindingSource.Filter =
                "Provider = '" + textBox1.Text + "'";
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNameFilter_Click(object sender, EventArgs e)
        {
            try
            {
                providersItemsBindingSource.Filter = 
                    "Name = '" + textBox2.Text + "'";
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            providersItemsBindingSource.Filter = "";
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxSalePriceArrive.Text);
        }

        private void buttonExpItemFilter_Click(object sender, EventArgs e)
        {
            try
            {
                getItemsInStockBindingSource.Filter =
                "Name = '" + comboBoxExItemFilterCollection.Text + "'";
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCreateExpense_Click(object sender, EventArgs e)
        {
            try
            {
                addExpense.Parameters["@date"].Value = 
                    dateTimePickerExpense.Text;
                addExpense.Parameters["@item"].Value =
                    comboBoxExItemName.Text;
                addExpense.Parameters["@discount"].Value = 
                    textBoxExPrice.Text;
                addExpense.Parameters["@quantity"].Value = 
                    textBoxExQuantity.Text;
                sqlConnection1.Open();
                var confirmResult = MessageBox.Show("Подтвердить создание расхода?", "Подтвердить создание расхода?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    addExpense.ExecuteNonQuery();
                    MessageBox.Show(Convert.ToString(addExpense.Parameters["@message"].Value));
                    this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
                    this.providersItemsTableAdapter.Fill(this.dataSet1.ProvidersItems);
                    sqlConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxExQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }

        private void textBoxExPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }

        private void buttonExCategoryFilter_Click(object sender, EventArgs e)
        {
            try
            {
                getItemsInStockBindingSource.Filter =
                    "CategoryName = '" + comboBoxCategoryFilterCollection.Text + "'";
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExClearFilter_Click(object sender, EventArgs e)
        {
            getItemsInStockBindingSource.Filter = "";
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonWriteOffBatch_Click(object sender, EventArgs e)
        {
            try
            {
                WriteOffBatch.Parameters["@date"].Value =
                    dateTimePickerWriteOff.Text;
                WriteOffBatch.Parameters["@batchNumber"].Value = 
                    comboBoxWriteOffBatch.Text;
                sqlConnection1.Open();
                WriteOffBatch.ExecuteNonQuery();
                this.getExpiredItemsTableAdapter.Fill(this.dataSet1.getExpiredItems);
                this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
                sqlConnection1.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonWriteOffAllExpiredItems_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                WriteOffAllExpiredItems.ExecuteNonQuery();
                this.getExpiredItemsTableAdapter.Fill(this.dataSet1.getExpiredItems);
                this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
                sqlConnection1.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSalePriceArrive_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxSalePriceArrive.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.getItemsInStockTableAdapter.Fill(this.dataSet1.getItemsInStock);
        }

        private void textBoxExPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonDiscountSalePrice_Click(object sender, EventArgs e)
        {
            try
            {
                double price = 0;
                String commandText = "SELECT TOP(1) salePrice FROM StockItems WHERE Name = '" + comboBoxExItemName.Text + "'";
                sqlConnection1.Open();
                SqlCommand command =
                    new SqlCommand(commandText, sqlConnection1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    price = Convert.ToDouble(reader[0]);
                    
                }
                labelPriceExpense.Text = (Convert.ToDouble(textBoxExQuantity.Text) * (price -
                    price * (Convert.ToDouble(textBoxExPrice.Text) / 100))
                    ).ToString();
                sqlConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка в поле 'скидка(%)'");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.stockItemsTableAdapter.Fill(this.dataSet1.StockItems);
        }

        private void label11_Click(object sender, EventArgs e)
        {
                    }

        private void report1_StartReport(object sender, EventArgs e)
        {

        }

        private void comboBoxItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSalePriceArrive.Enabled = true;
            string textCommand = "SELECT COUNT(*) FROM StockItems WHERE Name = '" + comboBoxItemName.Text + "'";
            SqlCommand comm = new SqlCommand(textCommand, sqlConnection1);
            int count = 0;
            sqlConnection1.Open();
            var reader1 = comm.ExecuteReader();
            while (reader1.Read())
            {
                count = Convert.ToInt32(reader1[0]);
            }
            reader1.Close();
            if (count > 0)
            {
                string textCom = "SELECT salePrice FROM StockItems WHERE Name = '" + comboBoxItemName.Text + "'";
                SqlCommand com = new SqlCommand(textCom, sqlConnection1);
                var reader2 = com.ExecuteReader();
                while (reader2.Read())
                {
                    textBoxSalePriceArrive.Text = reader2[0].ToString();
                    textBoxSalePriceArrive.Enabled = false;
                }
                reader2.Close();
            }
            sqlConnection1.Close();
        }
    }
}
