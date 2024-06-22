namespace RentCars.UI
{
    partial class PaymentForm
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
            this.dtspaymenttime = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmamount = new System.Windows.Forms.NumericUpDown();
            this.cbpaymentmethod = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChooseRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtspaymenttime
            // 
            this.dtspaymenttime.Location = new System.Drawing.Point(107, 82);
            this.dtspaymenttime.Name = "dtspaymenttime";
            this.dtspaymenttime.Size = new System.Drawing.Size(193, 20);
            this.dtspaymenttime.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(225, 189);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(144, 189);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 5;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "PaymentMethod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "PaymentDate";
            // 
            // textrent
            // 
            this.textrent.Location = new System.Drawing.Point(107, 52);
            this.textrent.Name = "textrent";
            this.textrent.ReadOnly = true;
            this.textrent.Size = new System.Drawing.Size(193, 20);
            this.textrent.TabIndex = 1;
            this.textrent.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "User";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(107, 26);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(193, 20);
            this.textID.TabIndex = 0;
            this.textID.TabStop = false;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "PaymentID";
            // 
            // nmamount
            // 
            this.nmamount.DecimalPlaces = 2;
            this.nmamount.Location = new System.Drawing.Point(107, 118);
            this.nmamount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmamount.Name = "nmamount";
            this.nmamount.Size = new System.Drawing.Size(193, 20);
            this.nmamount.TabIndex = 3;
            this.nmamount.ThousandsSeparator = true;
            // 
            // cbpaymentmethod
            // 
            this.cbpaymentmethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaymentmethod.FormattingEnabled = true;
            this.cbpaymentmethod.Items.AddRange(new object[] {
            "Cash payment",
            "Credit cards",
            "Electronic payment",
            "Checks"});
            this.cbpaymentmethod.Location = new System.Drawing.Point(107, 151);
            this.cbpaymentmethod.Name = "cbpaymentmethod";
            this.cbpaymentmethod.Size = new System.Drawing.Size(193, 21);
            this.cbpaymentmethod.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnChooseRent
            // 
            this.btnChooseRent.Location = new System.Drawing.Point(306, 50);
            this.btnChooseRent.Name = "btnChooseRent";
            this.btnChooseRent.Size = new System.Drawing.Size(108, 23);
            this.btnChooseRent.TabIndex = 47;
            this.btnChooseRent.Text = "choose user";
            this.btnChooseRent.UseVisualStyleBackColor = true;
            this.btnChooseRent.Click += new System.EventHandler(this.btnChooseRent_Click);
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(426, 233);
            this.Controls.Add(this.btnChooseRent);
            this.Controls.Add(this.cbpaymentmethod);
            this.Controls.Add(this.nmamount);
            this.Controls.Add(this.dtspaymenttime);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtspaymenttime;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmamount;
        private System.Windows.Forms.ComboBox cbpaymentmethod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChooseRent;
    }
}