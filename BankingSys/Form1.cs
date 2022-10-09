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
using System.Runtime.CompilerServices;
using BankingSys;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbclient.DataSource = bankingRecEntities.Clients.ToList();
            PopulateGrid();

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

        private void cbclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bankingRecEntities.Transactions.Where(x => x.ClientID == (cbclient.SelectedIndex+1)).ToList();

        }

        private void tbClient_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bankingRecEntities.Transactions.Where(x => x.Client.Name.Contains(tbClient.Text) || x.Client.Surname.Contains(tbClient.Text)).ToList();
        }

        private void ShowT_Click(object sender, EventArgs e)
        {
            var Records = bankingRecEntities.Transactions.ToList();
            dataGridView1.DataSource = Records;
        }

        private void bEditComment_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionIDDataGridViewTextBoxColumn"].Value);
                var trans = bankingRecEntities.Transactions.FirstOrDefault(q => q.TransactionID == id);
                var addEdit = new AddEdit(trans, this);
                addEdit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select A Row To Edit");
            }

        }

        private void bAddTransaction_Click(object sender, EventArgs e)
        {
            var addEdit = new AddEdit(this);
            addEdit.ShowDialog();
        }
    }
}
