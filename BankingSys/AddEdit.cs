using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingSys
{
    public partial class AddEdit : Form
    {
        private bool IsEditMode;
        private readonly BankingRecEntities bankingRecEntities;
        private Form1 _form1;
        public AddEdit(Form1 form1 = null)
        {
            InitializeComponent();
            TitleAdd.Text = "Add A Transaction";
            IsEditMode = false;
            _form1 = form1;
            bankingRecEntities = new BankingRecEntities();
        }

        public AddEdit(Transaction CEdit, Form1 form1 = null)
        {
            InitializeComponent();
            TitleAdd.Text = "Edit A Transaction";
            _form1 = form1;

            if (CEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                IsEditMode = true;
                bankingRecEntities = new BankingRecEntities();
                PopulateFields(CEdit);
            }  
            
        }

        private void PopulateFields(Transaction trans)
        {
            Labelid.Text = trans.TransactionID.ToString();
            tbTransactionID.Text = trans.TransactionID.ToString();
            tbAmount.Text = trans.Amount.ToString();
            tbClientID.Text = trans.ClientID.ToString();
            tbComment.Text = trans.Comment;
            tbTransactionTypeID.Text = trans.TransactionTypeID.ToString();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                var id = int.Parse(Labelid.Text);
                var trans = bankingRecEntities.Transactions.FirstOrDefault(q => q.TransactionID == id);

                trans.TransactionID = Convert.ToInt64(tbTransactionID.Text);
                trans.Amount = Convert.ToDecimal(tbAmount.Text);
                trans.ClientID = int.Parse(tbClientID.Text);
                trans.Comment = tbComment.Text;
                trans.TransactionTypeID = Convert.ToInt16(tbTransactionTypeID.Text);
                bankingRecEntities.SaveChanges();
                _form1.PopulateGrid();
                Close();

            }
            else
            {
                var newTrans = new Transaction
                {
                    TransactionID = Convert.ToInt64(tbTransactionID.Text),
                    Amount = Convert.ToDecimal(tbAmount.Text),
                    ClientID = int.Parse(tbClientID.Text),
                    Comment = tbComment.Text,
                    TransactionTypeID = Convert.ToInt16(tbTransactionTypeID.Text),
                };
                bankingRecEntities.Transactions.Add(newTrans);
                bankingRecEntities.SaveChanges();
                _form1.PopulateGrid();
                Close();

            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
