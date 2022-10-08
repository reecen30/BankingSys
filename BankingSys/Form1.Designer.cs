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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.bAddTransaction = new System.Windows.Forms.Button();
            this.bEditComment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbClient
            // 
            this.cbClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(430, 39);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(261, 24);
            this.cbClient.TabIndex = 1;
            // 
            // bAddTransaction
            // 
            this.bAddTransaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddTransaction.Location = new System.Drawing.Point(305, 468);
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
            this.bEditComment.Location = new System.Drawing.Point(605, 468);
            this.bEditComment.Name = "bEditComment";
            this.bEditComment.Size = new System.Drawing.Size(205, 48);
            this.bEditComment.TabIndex = 4;
            this.bEditComment.Text = "Edit a transaction";
            this.bEditComment.UseVisualStyleBackColor = false;
            this.bEditComment.Click += new System.EventHandler(this.bEditComment_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(208, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 383);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1134, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bEditComment);
            this.Controls.Add(this.bAddTransaction);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Button bAddTransaction;
        private System.Windows.Forms.Button bEditComment;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

