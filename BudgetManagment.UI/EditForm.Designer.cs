namespace BudgetManagment.UI
{
    partial class EditForm
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
            cmbIncomeCategory = new ComboBox();
            label1 = new Label();
            cmbExpenseCategory = new ComboBox();
            label2 = new Label();
            btnAddIncome = new Button();
            btnUpdateIncome = new Button();
            txtIncomeName = new TextBox();
            label3 = new Label();
            txtIncomeAmount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtExpenseAmount = new TextBox();
            label6 = new Label();
            txtExpenseName = new TextBox();
            btnDeleteIncom = new Button();
            btnDeleteExpense = new Button();
            btnUpdateExpense = new Button();
            btnAddExpense = new Button();
            dgvIncomes = new DataGridView();
            dgvExpenses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIncomes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // cmbIncomeCategory
            // 
            cmbIncomeCategory.FormattingEnabled = true;
            cmbIncomeCategory.Location = new Point(23, 60);
            cmbIncomeCategory.Name = "cmbIncomeCategory";
            cmbIncomeCategory.Size = new Size(121, 23);
            cmbIncomeCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Gelir kategori seçiniz:";
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Location = new Point(358, 50);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(121, 23);
            cmbExpenseCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 25);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 3;
            label2.Text = "Gider kategorisi seçiniz:";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(23, 206);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(118, 23);
            btnAddIncome.TabIndex = 4;
            btnAddIncome.Text = "Gelir Ekle";
            btnAddIncome.UseVisualStyleBackColor = true;
            // 
            // btnUpdateIncome
            // 
            btnUpdateIncome.Location = new Point(27, 413);
            btnUpdateIncome.Name = "btnUpdateIncome";
            btnUpdateIncome.Size = new Size(117, 23);
            btnUpdateIncome.TabIndex = 5;
            btnUpdateIncome.Text = "Gelir Güncelle";
            btnUpdateIncome.UseVisualStyleBackColor = true;
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(24, 115);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(100, 23);
            txtIncomeName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 90);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Gelir adı:";
            // 
            // txtIncomeAmount
            // 
            txtIncomeAmount.Location = new Point(23, 177);
            txtIncomeAmount.Name = "txtIncomeAmount";
            txtIncomeAmount.Size = new Size(100, 23);
            txtIncomeAmount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 151);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 9;
            label4.Text = "Gelir miktarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 141);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 13;
            label5.Text = "Gider miktarı:";
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Location = new Point(358, 167);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.Size = new Size(100, 23);
            txtExpenseAmount.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 80);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "Gider adı:";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(359, 105);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(100, 23);
            txtExpenseName.TabIndex = 10;
            // 
            // btnDeleteIncom
            // 
            btnDeleteIncom.Location = new Point(164, 413);
            btnDeleteIncom.Name = "btnDeleteIncom";
            btnDeleteIncom.Size = new Size(118, 23);
            btnDeleteIncom.TabIndex = 14;
            btnDeleteIncom.Text = "Geliri Sil";
            btnDeleteIncom.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.Location = new Point(499, 413);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(121, 23);
            btnDeleteExpense.TabIndex = 17;
            btnDeleteExpense.Text = "Gideri Sil";
            btnDeleteExpense.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExpense
            // 
            btnUpdateExpense.Location = new Point(358, 413);
            btnUpdateExpense.Name = "btnUpdateExpense";
            btnUpdateExpense.Size = new Size(121, 23);
            btnUpdateExpense.TabIndex = 16;
            btnUpdateExpense.Text = "Gider Güncelle";
            btnUpdateExpense.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(358, 196);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(121, 23);
            btnAddExpense.TabIndex = 15;
            btnAddExpense.Text = "Gider Ekle";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // dgvIncomes
            // 
            dgvIncomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncomes.Location = new Point(23, 257);
            dgvIncomes.Name = "dgvIncomes";
            dgvIncomes.Size = new Size(240, 150);
            dgvIncomes.TabIndex = 18;
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(358, 257);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.Size = new Size(240, 150);
            dgvExpenses.TabIndex = 19;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 514);
            Controls.Add(dgvExpenses);
            Controls.Add(dgvIncomes);
            Controls.Add(btnDeleteExpense);
            Controls.Add(btnUpdateExpense);
            Controls.Add(btnAddExpense);
            Controls.Add(btnDeleteIncom);
            Controls.Add(label5);
            Controls.Add(txtExpenseAmount);
            Controls.Add(label6);
            Controls.Add(txtExpenseName);
            Controls.Add(label4);
            Controls.Add(txtIncomeAmount);
            Controls.Add(label3);
            Controls.Add(txtIncomeName);
            Controls.Add(btnUpdateIncome);
            Controls.Add(btnAddIncome);
            Controls.Add(label2);
            Controls.Add(cmbExpenseCategory);
            Controls.Add(label1);
            Controls.Add(cmbIncomeCategory);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncomes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIncomeCategory;
        private Label label1;
        private ComboBox cmbExpenseCategory;
        private Label label2;
        private Button btnAddIncome;
        private Button btnUpdateIncome;
        private TextBox txtIncomeName;
        private Label label3;
        private TextBox txtIncomeAmount;
        private Label label4;
        private Label label5;
        private TextBox txtExpenseAmount;
        private Label label6;
        private TextBox txtExpenseName;
        private Button btnDeleteIncom;
        private Button btnDeleteExpense;
        private Button btnUpdateExpense;
        private Button btnAddExpense;
        private DataGridView dgvIncomes;
        private DataGridView dgvExpenses;
    }
}