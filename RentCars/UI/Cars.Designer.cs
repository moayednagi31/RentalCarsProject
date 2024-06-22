namespace RentCars.UI
{
    partial class Cars
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnvehiclesadder = new System.Windows.Forms.ToolStrip();
            this.AddVehicles = new System.Windows.Forms.ToolStripButton();
            this.UpdateVehicles = new System.Windows.Forms.ToolStripButton();
            this.vehiclesdelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.SearchVehicles = new System.Windows.Forms.ToolStripButton();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.btnvehiclesadder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 358);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnvehiclesadder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(683, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(677, 295);
            this.dataGridView2.TabIndex = 4;
            // 
            // btnvehiclesadder
            // 
            this.btnvehiclesadder.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.btnvehiclesadder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVehicles,
            this.UpdateVehicles,
            this.vehiclesdelete,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.SearchVehicles});
            this.btnvehiclesadder.Location = new System.Drawing.Point(3, 3);
            this.btnvehiclesadder.Name = "btnvehiclesadder";
            this.btnvehiclesadder.Size = new System.Drawing.Size(677, 31);
            this.btnvehiclesadder.TabIndex = 3;
            this.btnvehiclesadder.Text = "Add";
            // 
            // AddVehicles
            // 
            this.AddVehicles.Image = global::RentCars.Properties.Resources.vehicle_car_side_add;
            this.AddVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddVehicles.Name = "AddVehicles";
            this.AddVehicles.Size = new System.Drawing.Size(57, 28);
            this.AddVehicles.Text = "Add";
            this.AddVehicles.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UpdateVehicles
            // 
            this.UpdateVehicles.Image = global::RentCars.Properties.Resources.vehicle_car_side_edit;
            this.UpdateVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateVehicles.Name = "UpdateVehicles";
            this.UpdateVehicles.Size = new System.Drawing.Size(73, 28);
            this.UpdateVehicles.Text = "Update";
            this.UpdateVehicles.Click += new System.EventHandler(this.UpdateVehicles_Click);
            // 
            // vehiclesdelete
            // 
            this.vehiclesdelete.Image = global::RentCars.Properties.Resources.vehicle_car_side_remove;
            this.vehiclesdelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vehiclesdelete.Name = "vehiclesdelete";
            this.vehiclesdelete.Size = new System.Drawing.Size(68, 28);
            this.vehiclesdelete.Text = "Delete";
            this.vehiclesdelete.Click += new System.EventHandler(this.vehiclesdelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 28);
            this.toolStripLabel2.Text = "Search";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 31);
            // 
            // SearchVehicles
            // 
            this.SearchVehicles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchVehicles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchVehicles.Image = global::RentCars.Properties.Resources.vehicle_car_side_search;
            this.SearchVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchVehicles.Name = "SearchVehicles";
            this.SearchVehicles.Size = new System.Drawing.Size(28, 28);
            this.SearchVehicles.Text = "toolStripButton1";
            this.SearchVehicles.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(241, 364);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(128, 364);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Cars
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.btnvehiclesadder.ResumeLayout(false);
            this.btnvehiclesadder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip btnvehiclesadder;
        private System.Windows.Forms.ToolStripButton AddVehicles;
        private System.Windows.Forms.ToolStripButton UpdateVehicles;
        private System.Windows.Forms.ToolStripButton vehiclesdelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton SearchVehicles;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsend;
    }
}