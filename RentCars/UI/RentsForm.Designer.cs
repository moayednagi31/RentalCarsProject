namespace RentCars.UI
{
    partial class RentsForm
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
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textvenhicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.dtendtime = new System.Windows.Forms.DateTimePicker();
            this.nmtotalamount = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChooseUser = new System.Windows.Forms.Button();
            this.btnChooseCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmtotalamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtstarttime
            // 
            this.dtstarttime.Location = new System.Drawing.Point(96, 89);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.Size = new System.Drawing.Size(193, 20);
            this.dtstarttime.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(214, 180);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(96, 180);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 7;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 140);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "TotalAmount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "EndDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "StarDate";
            // 
            // textvenhicle
            // 
            this.textvenhicle.Location = new System.Drawing.Point(96, 63);
            this.textvenhicle.Name = "textvenhicle";
            this.textvenhicle.ReadOnly = true;
            this.textvenhicle.Size = new System.Drawing.Size(193, 20);
            this.textvenhicle.TabIndex = 2;
            this.textvenhicle.TabStop = false;
            this.textvenhicle.TextChanged += new System.EventHandler(this.textModel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Venhicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(96, 11);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(193, 20);
            this.textID.TabIndex = 0;
            this.textID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "RentalID";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(96, 37);
            this.textuser.Name = "textuser";
            this.textuser.ReadOnly = true;
            this.textuser.Size = new System.Drawing.Size(193, 20);
            this.textuser.TabIndex = 1;
            this.textuser.TabStop = false;
            this.textuser.TextChanged += new System.EventHandler(this.textModel_TextChanged);
            // 
            // dtendtime
            // 
            this.dtendtime.Location = new System.Drawing.Point(96, 112);
            this.dtendtime.Name = "dtendtime";
            this.dtendtime.Size = new System.Drawing.Size(193, 20);
            this.dtendtime.TabIndex = 4;
            // 
            // nmtotalamount
            // 
            this.nmtotalamount.DecimalPlaces = 2;
            this.nmtotalamount.Location = new System.Drawing.Point(96, 138);
            this.nmtotalamount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmtotalamount.Name = "nmtotalamount";
            this.nmtotalamount.Size = new System.Drawing.Size(193, 20);
            this.nmtotalamount.TabIndex = 31;
            this.nmtotalamount.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnChooseUser
            // 
            this.btnChooseUser.Location = new System.Drawing.Point(310, 34);
            this.btnChooseUser.Name = "btnChooseUser";
            this.btnChooseUser.Size = new System.Drawing.Size(107, 23);
            this.btnChooseUser.TabIndex = 32;
            this.btnChooseUser.Text = "choose user";
            this.btnChooseUser.UseVisualStyleBackColor = true;
            this.btnChooseUser.Click += new System.EventHandler(this.btnChooseUser_Click);
            // 
            // btnChooseCar
            // 
            this.btnChooseCar.Location = new System.Drawing.Point(310, 66);
            this.btnChooseCar.Name = "btnChooseCar";
            this.btnChooseCar.Size = new System.Drawing.Size(107, 23);
            this.btnChooseCar.TabIndex = 32;
            this.btnChooseCar.Text = "choose car";
            this.btnChooseCar.UseVisualStyleBackColor = true;
            this.btnChooseCar.Click += new System.EventHandler(this.btnChooseCar_Click);
            // 
            // RentsForm
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(475, 218);
            this.Controls.Add(this.btnChooseCar);
            this.Controls.Add(this.btnChooseUser);
            this.Controls.Add(this.nmtotalamount);
            this.Controls.Add(this.dtendtime);
            this.Controls.Add(this.dtstarttime);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textvenhicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RentsForm";
            this.Load += new System.EventHandler(this.RentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmtotalamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textvenhicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.DateTimePicker dtendtime;
        private System.Windows.Forms.NumericUpDown nmtotalamount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChooseCar;
        private System.Windows.Forms.Button btnChooseUser;
    }
}