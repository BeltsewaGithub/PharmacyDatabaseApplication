using PharmasyApplication.DataSet1TableAdapters;
using PublishingHouseClient2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmasyApplication
{
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BatchesView' table. You can move, or remove it, as needed.
            this.batchesViewTableAdapter.Fill(this.dataSet1.BatchesView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.getProvidersItems". При необходимости она может быть перемещена или удалена.
            this.getProvidersItemsTableAdapter.Fill(this.dataSet1.getProvidersItems);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.dataSet1.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProviderItemsInStock". При необходимости она может быть перемещена или удалена.
            this.providerItemsInStockTableAdapter.Fill(this.dataSet1.ProviderItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Batches". При необходимости она может быть перемещена или удалена.
            this.batchesTableAdapter.Fill(this.dataSet1.Batches);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dataSet1.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ProviderItemsInStock". При необходимости она может быть перемещена или удалена.
            this.providerItemsInStockTableAdapter.Fill(this.dataSet1.ProviderItemsInStock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dataSet1.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.dataSet1.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ItemsCollection". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dataSet1.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDBTablesDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Сохранить изменения?", "Подтвердить изменений", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.itemsBindingSource.EndEdit();
                    this.itemsTableAdapter.Update
                    (this.dataSet1.Items); this.Validate();
                    this.itemsBindingSource.EndEdit();
                    this.itemsTableAdapter.Update
                    (this.dataSet1.Items);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.itemsTableAdapter.Fill(this.dataSet1.Items);
            }
        }

        //private void buttonCreateItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        addBatch.Parameters["@salePrice"].Value =
        //            textBoxSalePrice.Text;
        //        addBatch.Parameters["@itemName"].Value =
        //            comboBoxNameItem.Text;
        //        addBatch.Parameters["@productionDate"].Value =
        //            Convert.ToDateTime(dateTimePicker1.Value);
        //        addBatch.Parameters["@expirationDate"].Value =
        //            Convert.ToDateTime(dateTimePicker2.Value);
        //        sqlConnection1.Open();
        //        addBatch.ExecuteNonQuery();
        //        MessageBox.Show("Товар добавлен");
        //        this.itemsTableAdapter.Fill(this.dataSet1.Items);
        //        sqlConnection1.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void buttonCreateItemProviderStock_Click(object sender, EventArgs e)
        {
            try
            {
                AddBatchToProvider.Parameters["@provider"].Value =
                    comboBoxProvider.Text;
                AddBatchToProvider.Parameters["@batchNumber"].Value =
                    comboBoxBatch.Text;
                AddBatchToProvider.Parameters["@purchasePrice"].Value =
                    textBoxPrice.Text;
                AddBatchToProvider.Parameters["@quantity"].Value =
                    quantityAddBatch.Text;
                sqlConnection1.Open();
                AddBatchToProvider.ExecuteNonQuery();
                MessageBox.Show("Товар добавлен в наличие поставщика");
                this.providerItemsInStockTableAdapter.Fill(this.dataSet1.ProviderItemsInStock);
                sqlConnection1.Close();
            }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxSalePrice.Text);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxSalePrice.Text);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxPrice.Text);
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.dataSet1.Items);
        }

        private void toolStripButtonUpdateBatch_Click(object sender, EventArgs e)
        {
            this.batchesTableAdapter.Fill(this.dataSet1.Batches);
        }

        private void buttonUpdateBatches_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Сохранить изменения?", "Подтвердить изменений", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    createBatch.Parameters["@itemName"].Value = comboBoxNameItem.Text;
                    createBatch.Parameters["@productionDate"].Value = dateTimePicker1.Text;
                    createBatch.Parameters["@expirationDate"].Value = dateTimePicker2.Text;
                    sqlConnection1.Open();
                    createBatch.ExecuteNonQuery();
                    MessageBox.Show("Партия создана");
                    this.batchesTableAdapter.Fill(this.dataSet1.Batches);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.batchesTableAdapter.Fill(this.dataSet1.Batches);

                /*(var confirmResult = MessageBox.Show("Сохранить изменения?", "Подтвердить изменений", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        this.Validate();
                        this.batchesBindingSource.EndEdit();
                        this.batchesTableAdapter.Update (this.dataSet1.Batches); this.Validate();
                        this.batchesBindingSource.EndEdit();
                        this.batchesTableAdapter.Update (this.dataSet1.Batches);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    this.batchesTableAdapter.Fill(this.dataSet1.Batches);
                }*/
            }
            sqlConnection1.Close();
        }

        private void toolStripButtonUpdateProvidersItemsInStock_Click(object sender, EventArgs e)
        {
            this.providerItemsInStockTableAdapter.Fill(this.dataSet1.ProviderItemsInStock);
        }

        private void toolStripButtonSaveProvider_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.providersBindingSource.EndEdit();
                this.providersTableAdapter.Update
                (this.dataSet1.Providers); this.Validate();
                this.providersBindingSource.EndEdit();
                this.providersTableAdapter.Update
                (this.dataSet1.Providers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonUpdateProviders_Click(object sender, EventArgs e)
        {
            this.providersTableAdapter.Fill(this.dataSet1.Providers);
        }
        private void comboBoxNameItem_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            String commandText = "SELECT Id FROM Items WHERE Name = '" +
                    comboBoxNameItem.Text + "'";
            SqlCommand command =
                new SqlCommand(commandText, sqlConnection1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //labelRecommendedPrice.Text = Convert.ToString(reader[0]);
                //label8.Text = Convert.ToString(reader[0]);
            }
            sqlConnection1.Close();
        }

        //private void comboBoxBatch_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    sqlConnection1.Open();
        //    String commandText = "SELECT ItemName FROM BatchesView WHERE batchNumber = '" +
        //            comboBoxBatch.Text + "'";
        //    SqlCommand command =
        //        new SqlCommand(commandText, sqlConnection1);
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        //labelRecommendedPrice.Text = Convert.ToString(reader[0]);
        //        label18.Text = Convert.ToString(reader[0]);
        //    }
        //    sqlConnection1.Close();
        //}

        private void textBoxSalePrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ProgramClass.MoneyCheck(e, textBoxSalePrice.Text);
        }

        private void quantityAddBatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }
    }
}
