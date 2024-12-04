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
            SuspendLayout();
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(33, 49);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(100, 23);
            txtIncomeName.TabIndex = 0;
            // 
            // txtIncomeAmount
            // 
            txtIncomeAmount.Location = new Point(33, 110);
            txtIncomeAmount.Name = "txtIncomeAmount";
            txtIncomeAmount.Size = new Size(100, 23);
            txtIncomeAmount.TabIndex = 1;
            // 
            // cmbIncomeCategory
            // 
            cmbIncomeCategory.FormattingEnabled = true;
            cmbIncomeCategory.Location = new Point(33, 169);
            cmbIncomeCategory.Name = "cmbIncomeCategory";
            cmbIncomeCategory.Size = new Size(121, 23);
            cmbIncomeCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Gelir Adı giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 92);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Gelir miktarını giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 149);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 5;
            label3.Text = "Gelir kategorisini seçiniz:";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(33, 207);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(75, 23);
            btnAddIncome.TabIndex = 6;
            btnAddIncome.Text = "Geliri Ekle";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // btnExitIncome
            // 
            btnExitIncome.Location = new Point(124, 207);
            btnExitIncome.Name = "btnExitIncome";
            btnExitIncome.Size = new Size(100, 25);
            btnExitIncome.TabIndex = 7;
            btnExitIncome.Text = "Formu kapat";
            btnExitIncome.UseVisualStyleBackColor = true;
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitIncome);
            Controls.Add(btnAddIncome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbIncomeCategory);
            Controls.Add(txtIncomeAmount);
            Controls.Add(txtIncomeName);
            Name = "IncomeForm";
            Text = "IncomeForm";
            Load += IncomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}