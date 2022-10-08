namespace BankingSys
{
    partial class AddEdit
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
            this.LTransactionID = new System.Windows.Forms.Label();
            this.LAmount = new System.Windows.Forms.Label();
            this.LTransactionTypeID = new System.Windows.Forms.Label();
            this.LClientID = new System.Windows.Forms.Label();
            this.LComment = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.tbTransactionTypeID = new System.Windows.Forms.TextBox();
            this.tbTransactionID = new System.Windows.Forms.TextBox();
            this.TitleAdd = new System.Windows.Forms.Label();
            this.Labelid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LTransactionID
            // 
            this.LTransactionID.AutoSize = true;
            this.LTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTransactionID.Location = new System.Drawing.Point(183, 115);
            this.LTransactionID.Name = "LTransactionID";
            this.LTransactionID.Size = new System.Drawing.Size(113, 18);
            this.LTransactionID.TabIndex = 0;
            this.LTransactionID.Text = "TransactionID";
            // 
            // LAmount
            // 
            this.LAmount.AutoSize = true;
            this.LAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAmount.Location = new System.Drawing.Point(183, 173);
            this.LAmount.Name = "LAmount";
            this.LAmount.Size = new System.Drawing.Size(65, 18);
            this.LAmount.TabIndex = 1;
            this.LAmount.Text = "Amount";
            // 
            // LTransactionTypeID
            // 
            this.LTransactionTypeID.AutoSize = true;
            this.LTransactionTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTransactionTypeID.Location = new System.Drawing.Point(183, 244);
            this.LTransactionTypeID.Name = "LTransactionTypeID";
            this.LTransactionTypeID.Size = new System.Drawing.Size(149, 18);
            this.LTransactionTypeID.TabIndex = 2;
            this.LTransactionTypeID.Text = "TransactionTypeID";
            // 
            // LClientID
            // 
            this.LClientID.AutoSize = true;
            this.LClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClientID.Location = new System.Drawing.Point(183, 307);
            this.LClientID.Name = "LClientID";
            this.LClientID.Size = new System.Drawing.Size(67, 18);
            this.LClientID.TabIndex = 3;
            this.LClientID.Text = "ClientID";
            // 
            // LComment
            // 
            this.LComment.AutoSize = true;
            this.LComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LComment.Location = new System.Drawing.Point(183, 367);
            this.LComment.Name = "LComment";
            this.LComment.Size = new System.Drawing.Size(81, 18);
            this.LComment.TabIndex = 4;
            this.LComment.Text = "Comment";
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BSave.Location = new System.Drawing.Point(186, 426);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(166, 41);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "Save Changes";
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.MediumBlue;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bCancel.Location = new System.Drawing.Point(511, 426);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(185, 41);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(511, 167);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(185, 22);
            this.tbAmount.TabIndex = 7;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(511, 367);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(185, 22);
            this.tbComment.TabIndex = 8;
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(511, 304);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(185, 22);
            this.tbClientID.TabIndex = 9;
            // 
            // tbTransactionTypeID
            // 
            this.tbTransactionTypeID.Location = new System.Drawing.Point(511, 238);
            this.tbTransactionTypeID.Name = "tbTransactionTypeID";
            this.tbTransactionTypeID.Size = new System.Drawing.Size(185, 22);
            this.tbTransactionTypeID.TabIndex = 10;
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Location = new System.Drawing.Point(511, 109);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.Size = new System.Drawing.Size(185, 22);
            this.tbTransactionID.TabIndex = 11;
            // 
            // TitleAdd
            // 
            this.TitleAdd.AutoSize = true;
            this.TitleAdd.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAdd.Location = new System.Drawing.Point(261, 31);
            this.TitleAdd.Name = "TitleAdd";
            this.TitleAdd.Size = new System.Drawing.Size(381, 52);
            this.TitleAdd.TabIndex = 12;
            this.TitleAdd.Text = "Add a Transaction";
            // 
            // Labelid
            // 
            this.Labelid.AutoSize = true;
            this.Labelid.Location = new System.Drawing.Point(728, 46);
            this.Labelid.Name = "Labelid";
            this.Labelid.Size = new System.Drawing.Size(44, 16);
            this.Labelid.TabIndex = 13;
            this.Labelid.Text = "label1";
            this.Labelid.Visible = false;
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(911, 523);
            this.Controls.Add(this.Labelid);
            this.Controls.Add(this.TitleAdd);
            this.Controls.Add(this.tbTransactionID);
            this.Controls.Add(this.tbTransactionTypeID);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.LComment);
            this.Controls.Add(this.LClientID);
            this.Controls.Add(this.LTransactionTypeID);
            this.Controls.Add(this.LAmount);
            this.Controls.Add(this.LTransactionID);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTransactionID;
        private System.Windows.Forms.Label LAmount;
        private System.Windows.Forms.Label LTransactionTypeID;
        private System.Windows.Forms.Label LClientID;
        private System.Windows.Forms.Label LComment;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.TextBox tbTransactionTypeID;
        private System.Windows.Forms.TextBox tbTransactionID;
        private System.Windows.Forms.Label TitleAdd;
        private System.Windows.Forms.Label Labelid;
    }
}