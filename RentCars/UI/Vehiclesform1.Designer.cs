namespace RentCars.UI
{
    partial class Vehiclesform1
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textState = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.dtdailyrate = new System.Windows.Forms.DateTimePicker();
            this.nmDailyRate = new System.Windows.Forms.NumericUpDown();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmDailyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(176, 206);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(95, 206);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 7;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DailyRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FuelType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year";
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(67, 63);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(193, 20);
            this.textModel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brand";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(67, 11);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(193, 20);
            this.textID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "VehicleID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 179);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status";
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(67, 175);
            this.textState.Multiline = true;
            this.textState.Name = "textState";
            this.textState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textState.Size = new System.Drawing.Size(193, 25);
            this.textState.TabIndex = 6;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "Toyota",
            "Ford",
            "Honda",
            "Nissan",
            "BMW",
            "Mercedes"});
            this.cbBrand.Location = new System.Drawing.Point(67, 40);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(193, 21);
            this.cbBrand.TabIndex = 1;
            // 
            // dtdailyrate
            // 
            this.dtdailyrate.Location = new System.Drawing.Point(67, 89);
            this.dtdailyrate.Name = "dtdailyrate";
            this.dtdailyrate.Size = new System.Drawing.Size(193, 20);
            this.dtdailyrate.TabIndex = 3;
            // 
            // nmDailyRate
            // 
            this.nmDailyRate.DecimalPlaces = 2;
            this.nmDailyRate.Location = new System.Drawing.Point(67, 142);
            this.nmDailyRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmDailyRate.Name = "nmDailyRate";
            this.nmDailyRate.Size = new System.Drawing.Size(193, 20);
            this.nmDailyRate.TabIndex = 5;
            this.nmDailyRate.ThousandsSeparator = true;
            // 
            // cbFuelType
            // 
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Electricity",
            "Hybrid"});
            this.cbFuelType.Location = new System.Drawing.Point(67, 115);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(193, 21);
            this.cbFuelType.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Vehiclesform1
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(305, 246);
            this.Controls.Add(this.nmDailyRate);
            this.Controls.Add(this.dtdailyrate);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vehiclesform1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehiclesform1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmDailyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.DateTimePicker dtdailyrate;
        private System.Windows.Forms.NumericUpDown nmDailyRate;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}