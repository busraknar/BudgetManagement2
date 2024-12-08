namespace BudgetManagment.UI
{
    partial class IncomeForm
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
            txtIncomeName = new TextBox();
            txtIncomeAmount = new TextBox();
            cmbIncomeCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAddIncome = new Button();
            btnExitIncome = new Button();
            btnAddExpense = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbExpenseCategory = new ComboBox();
            txtExpenseAmount = new TextBox();
            txtExpenseName = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(13, 35);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(100, 23);
            txtIncomeName.TabIndex = 0;
            // 
            // txtIncomeAmount
            // 
            txtIncomeAmount.Location = new Point(13, 96);
            txtIncomeAmount.Name = "txtIncomeAmount";
            txtIncomeAmount.Size = new Size(100, 23);
            txtIncomeAmount.TabIndex = 1;
            // 
            // cmbIncomeCategory
            // 
            cmbIncomeCategory.FormattingEnabled = true;
            cmbIncomeCategory.Location = new Point(13, 155);
            cmbIncomeCategory.Name = "cmbIncomeCategory";
            cmbIncomeCategory.Size = new Size(121, 23);
            cmbIncomeCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Gelir Adı giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Gelir miktarını giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 135);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 5;
            label3.Text = "Gelir kategorisini seçiniz:";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(13, 193);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(75, 23);
            btnAddIncome.TabIndex = 6;
            btnAddIncome.Text = "Geliri Ekle";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // btnExitIncome
            // 
            btnExitIncome.Location = new Point(104, 193);
            btnExitIncome.Name = "btnExitIncome";
            btnExitIncome.Size = new Size(100, 25);
            btnExitIncome.TabIndex = 7;
            btnExitIncome.Text = "Formu kapat";
            btnExitIncome.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(26, 193);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(75, 23);
            btnAddExpense.TabIndex = 14;
            btnAddExpense.Text = "Gideri Ekle";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 135);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 13;
            label4.Text = "Gider kategorisini seçiniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 78);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 12;
            label5.Text = "Gider miktarını giriniz:";
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 16;
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Location = new Point(26, 155);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(121, 23);
            cmbExpenseCategory.TabIndex = 10;
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Location = new Point(26, 96);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.Size = new Size(100, 23);
            txtExpenseAmount.TabIndex = 9;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(26, 35);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(100, 23);
            txtExpenseName.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 17);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 17;
            label7.Text = "Gider Adı giriniz:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnExitIncome);
            groupBox1.Controls.Add(txtIncomeName);
            groupBox1.Controls.Add(txtIncomeAmount);
            groupBox1.Controls.Add(cmbIncomeCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAddIncome);
            groupBox1.Location = new Point(43, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 224);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.IndianRed;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtExpenseName);
            groupBox2.Controls.Add(txtExpenseAmount);
            groupBox2.Controls.Add(btnAddExpense);
            groupBox2.Controls.Add(cmbExpenseCategory);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(329, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 224);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Name = "IncomeForm";
            Text = "IncomeForm";
            Load += IncomeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtIncomeName;
        private TextBox txtIncomeAmount;
        private ComboBox cmbIncomeCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddIncome;
        private Button btnExitIncome;
        private Button btnAddExpense;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbExpenseCategory;
        private TextBox txtExpenseAmount;
        private TextBox txtExpenseName;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}