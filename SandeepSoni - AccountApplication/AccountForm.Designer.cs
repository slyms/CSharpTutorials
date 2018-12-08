namespace SandeepSoni___AccountApplication
{
    partial class AccountForm
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
            this.Id = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnGetGeneration = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnSetMB = new System.Windows.Forms.Button();
            this.btnGetMB = new System.Windows.Forms.Button();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(12, 23);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(115, 23);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(221, 23);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 13);
            this.Balance.TabIndex = 5;
            this.Balance.Text = "Balance";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(224, 49);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 75);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 43);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(118, 75);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(100, 43);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(224, 75);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 43);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(118, 124);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(100, 43);
            this.btnDestroy.TabIndex = 11;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(224, 124);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(100, 43);
            this.btnGC.TabIndex = 12;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(12, 222);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 43);
            this.btnDeposit.TabIndex = 15;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnGetGeneration
            // 
            this.btnGetGeneration.Location = new System.Drawing.Point(118, 173);
            this.btnGetGeneration.Name = "btnGetGeneration";
            this.btnGetGeneration.Size = new System.Drawing.Size(206, 43);
            this.btnGetGeneration.TabIndex = 14;
            this.btnGetGeneration.Text = "Get Generation";
            this.btnGetGeneration.UseVisualStyleBackColor = true;
            this.btnGetGeneration.Click += new System.EventHandler(this.btnGetGeneration_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(224, 222);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 43);
            this.btnWithdraw.TabIndex = 17;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(118, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(12, 171);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(100, 43);
            this.btnTemp.TabIndex = 13;
            this.btnTemp.Text = "Temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnSetMB
            // 
            this.btnSetMB.Location = new System.Drawing.Point(12, 274);
            this.btnSetMB.Name = "btnSetMB";
            this.btnSetMB.Size = new System.Drawing.Size(100, 43);
            this.btnSetMB.TabIndex = 18;
            this.btnSetMB.Text = "Set MB";
            this.btnSetMB.UseVisualStyleBackColor = true;
            this.btnSetMB.Click += new System.EventHandler(this.btnSetMB_Click);
            // 
            // btnGetMB
            // 
            this.btnGetMB.Location = new System.Drawing.Point(224, 274);
            this.btnGetMB.Name = "btnGetMB";
            this.btnGetMB.Size = new System.Drawing.Size(100, 43);
            this.btnGetMB.TabIndex = 19;
            this.btnGetMB.Text = "Get MB";
            this.btnGetMB.UseVisualStyleBackColor = true;
            this.btnGetMB.Click += new System.EventHandler(this.btnGetMB_Click);
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(118, 274);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(100, 20);
            this.txtMB.TabIndex = 20;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 329);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.btnGetMB);
            this.Controls.Add(this.btnSetMB);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnGetGeneration);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Name.Name = "AccountForm";
            this.Text = "Account Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnGetGeneration;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnSetMB;
        private System.Windows.Forms.Button btnGetMB;
        private System.Windows.Forms.TextBox txtMB;
    }
}

