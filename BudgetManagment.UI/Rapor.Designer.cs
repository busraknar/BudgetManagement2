namespace BudgetManagment.UI
{
    partial class Rapor
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
            dgvIncome = new DataGridView();
            dgvExpense = new DataGridView();
            lblTotalIncome = new Label();
            lblTotalExpense = new Label();
            panelMonth = new FlowLayoutPanel();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            SuspendLayout();
            // 
            // dgvIncome
            // 
            dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncome.Location = new Point(21, 304);
            dgvIncome.Name = "dgvIncome";
            dgvIncome.Size = new Size(418, 150);
            dgvIncome.TabIndex = 1;
            // 
            // dgvExpense
            // 
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Location = new Point(445, 304);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.Size = new Size(397, 150);
            dgvExpense.TabIndex = 2;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.BackColor = SystemColors.MenuHighlight;
            lblTotalIncome.BorderStyle = BorderStyle.FixedSingle;
            lblTotalIncome.Location = new Point(75, 484);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(75, 17);
            lblTotalIncome.TabIndex = 3;
            lblTotalIncome.Text = "Toplam Gelir";
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.BackColor = SystemColors.ActiveCaption;
            lblTotalExpense.BorderStyle = BorderStyle.FixedSingle;
            lblTotalExpense.Location = new Point(498, 484);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(79, 17);
            lblTotalExpense.TabIndex = 4;
            lblTotalExpense.Text = "Toplam Gider";
            // 
            // panelMonth
            // 
            panelMonth.Location = new Point(21, 12);
            panelMonth.Name = "panelMonth";
            panelMonth.Size = new Size(821, 286);
            panelMonth.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 536);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(403, 23);
            progressBar1.TabIndex = 6;
            // 
            // Rapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 627);
            Controls.Add(progressBar1);
            Controls.Add(panelMonth);
            Controls.Add(lblTotalExpense);
            Controls.Add(lblTotalIncome);
            Controls.Add(dgvExpense);
            Controls.Add(dgvIncome);
            Name = "Rapor";
            Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvIncome;
        private DataGridView dgvExpense;
        private Label lblTotalIncome;
        private Label lblTotalExpense;
        private FlowLayoutPanel panelMonth;
        private ProgressBar progressBar1;
    }
}