using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BankingSys
{
    public partial class Form1 : Form
    {
        private readonly BankingRecEntities bankingRecEntities;
        public Form1()
        {
            InitializeComponent();
            bankingRecEntities = new BankingRecEntities();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var banking = bankingRecEntities.Clients.ToList();
            cbClient.DisplayMember = "Name";
            cbClient.ValueMember = "ClientID";
            cbClient.DataSource = banking;

            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopulateGrid()
        {
            var records = bankingRecEntities.Transactions.Select(q => new
            {
                TransactionID = q.TransactionID,
                Amount = q.Amount,
                TransactionTypeID = q.TransactionTypeID,
                ClientID = q.ClientID,
                Comment = q.Comment,
                ClientName = q.Client.Name,
            }).ToList();

            dataGridView1.DataSource = records;
           /* dataGridView1.Columns["ClientName"].Visible = false;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedItem = cbClient.SelectedItem.ToString();
            dataGridView1.DataSource = bankingRecEntities.Transactions.Where(x => x.Client.Name == SelectedItem).ToList();


        }

        private void bEditComment_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dataGridView1.SelectedRows[0].Cells["ClientName"].Value;
                var trans = bankingRecEntities.Transactions.FirstOrDefault(q => q.Client.Name == id);
                var addEdit = new AddEdit(trans, this);
                addEdit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row to edit");
            }

        }

        private void bAddTransaction_Click(object sender, EventArgs e)
        {
            var addEdit = new AddEdit(this);
            addEdit.Show();
        }
    }
}
