namespace BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtOwner = new TextBox();
            nupIntrentRate = new NumericUpDown();
            nupAmount = new NumericUpDown();
            btnDeposit = new Button();
            btnWithDraw = new Button();
            btnCreateAccount = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bankAccountsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nupIntrentRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(121, 29);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(150, 27);
            txtOwner.TabIndex = 0;
            // 
            // nupIntrentRate
            // 
            nupIntrentRate.Location = new Point(121, 79);
            nupIntrentRate.Name = "nupIntrentRate";
            nupIntrentRate.Size = new Size(150, 27);
            nupIntrentRate.TabIndex = 1;
            // 
            // nupAmount
            // 
            nupAmount.Location = new Point(121, 183);
            nupAmount.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            nupAmount.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
            nupAmount.Name = "nupAmount";
            nupAmount.Size = new Size(150, 27);
            nupAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDeposit.Location = new Point(27, 245);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 36);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithDraw
            // 
            btnWithDraw.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnWithDraw.Location = new Point(177, 245);
            btnWithDraw.Name = "btnWithDraw";
            btnWithDraw.Size = new Size(94, 36);
            btnWithDraw.TabIndex = 3;
            btnWithDraw.Text = "Withdraw";
            btnWithDraw.UseVisualStyleBackColor = true;
            btnWithDraw.Click += btnWithDraw_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCreateAccount.Location = new Point(122, 122);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(149, 36);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "Interent Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(27, 185);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Amount";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // bankAccountsGrid
            // 
            bankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bankAccountsGrid.BackgroundColor = SystemColors.ButtonFace;
            bankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankAccountsGrid.Location = new Point(289, 29);
            bankAccountsGrid.Name = "bankAccountsGrid";
            bankAccountsGrid.RowHeadersWidth = 51;
            bankAccountsGrid.Size = new Size(499, 252);
            bankAccountsGrid.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 292);
            Controls.Add(bankAccountsGrid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnWithDraw);
            Controls.Add(btnDeposit);
            Controls.Add(nupAmount);
            Controls.Add(nupIntrentRate);
            Controls.Add(txtOwner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Account";
            ((System.ComponentModel.ISupportInitialize)nupIntrentRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOwner;
        private NumericUpDown nupIntrentRate;
        private NumericUpDown nupAmount;
        private Button btnDeposit;
        private Button btnWithDraw;
        private Button btnCreateAccount;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView bankAccountsGrid;
    }
}
