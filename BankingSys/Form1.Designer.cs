namespace BankingSys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddTransaction = new System.Windows.Forms.Button();
            this.bEditComment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbclient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowT = new System.Windows.Forms.Button();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(897, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients";
            // 
            // bAddTransaction
            // 
            this.bAddTransaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddTransaction.Location = new System.Drawing.Point(133, 425);
            this.bAddTransaction.Name = "bAddTransaction";
            this.bAddTransaction.Size = new System.Drawing.Size(195, 48);
            this.bAddTransaction.TabIndex = 3;
            this.bAddTransaction.Text = "Add a transaction";
            this.bAddTransaction.UseVisualStyleBackColor = false;
            this.bAddTransaction.Click += new System.EventHandler(this.bAddTransaction_Click);
            // 
            // bEditComment
            // 
            this.bEditComment.BackColor = System.Drawing.Color.MediumBlue;
            this.bEditComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditComment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bEditComment.Location = new System.Drawing.Point(412, 425);
            this.bEditComment.Name = "bEditComment";
            this.bEditComment.Size = new System.Drawing.Size(205, 48);
            this.bEditComment.TabIndex = 4;
            this.bEditComment.Text = "Edit a transaction";
            this.bEditComment.UseVisualStyleBackColor = false;
            this.bEditComment.Click += new System.EventHandler(this.bEditComment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 290);
            this.dataGridView1.TabIndex = 5;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BankingSys.Transaction);
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(BankingSys.Transaction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Transactions";
            // 
            // cbclient
            // 
            this.cbclient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ClientID", true));
            this.cbclient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.clientBindingSource, "ClientID", true));
            this.cbclient.DataSource = this.clientBindingSource;
            this.cbclient.DisplayMember = "Name";
            this.cbclient.FormattingEnabled = true;
            this.cbclient.Location = new System.Drawing.Point(822, 141);
            this.cbclient.Name = "cbclient";
            this.cbclient.Size = new System.Drawing.Size(216, 24);
            this.cbclient.TabIndex = 10;
            this.cbclient.ValueMember = "ClientID";
            this.cbclient.SelectedIndexChanged += new System.EventHandler(this.cbclient_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankingSys.Client);
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(822, 295);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(216, 22);
            this.tbClient.TabIndex = 11;
            this.tbClient.TextChanged += new System.EventHandler(this.tbClient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filter By Name Or Surname";
            // 
            // ShowT
            // 
            this.ShowT.BackColor = System.Drawing.Color.SlateGray;
            this.ShowT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowT.Location = new System.Drawing.Point(822, 425);
            this.ShowT.Name = "ShowT";
            this.ShowT.Size = new System.Drawing.Size(204, 48);
            this.ShowT.TabIndex = 14;
            this.ShowT.Text = "Show All Transactions";
            this.ShowT.UseVisualStyleBackColor = false;
            this.ShowT.Click += new System.EventHandler(this.ShowT_Click);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1134, 538);
            this.Controls.Add(this.ShowT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.cbclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bEditComment);
            this.Controls.Add(this.bAddTransaction);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddTransaction;
        private System.Windows.Forms.Button bEditComment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbclient;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.Button ShowT;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

