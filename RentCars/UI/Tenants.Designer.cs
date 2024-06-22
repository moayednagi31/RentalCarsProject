namespace RentCars.UI
{
    partial class Tenants
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUsersAdder = new System.Windows.Forms.ToolStripButton();
            this.btnUsersUpdater = new System.Windows.Forms.ToolStripButton();
            this.btnUsersDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnUsersFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnfind = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btncancel);
            this.tabPage1.Controls.Add(this.btnsend);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(499, 371);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsend.Location = new System.Drawing.Point(418, 371);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 7;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(655, 330);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsersAdder,
            this.btnUsersUpdater,
            this.btnUsersDelete,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.btnUsersFind,
            this.btnfind});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Add";
            // 
            // btnUsersAdder
            // 
            this.btnUsersAdder.Image = global::RentCars.Properties.Resources.database_user_add;
            this.btnUsersAdder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsersAdder.Name = "btnUsersAdder";
            this.btnUsersAdder.Size = new System.Drawing.Size(57, 28);
            this.btnUsersAdder.Text = "Add";
            this.btnUsersAdder.Click += new System.EventHandler(this.btnUsersAdder_Click);
            // 
            // btnUsersUpdater
            // 
            this.btnUsersUpdater.Image = global::RentCars.Properties.Resources.database_user_edit;
            this.btnUsersUpdater.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsersUpdater.Name = "btnUsersUpdater";
            this.btnUsersUpdater.Size = new System.Drawing.Size(73, 28);
            this.btnUsersUpdater.Text = "Update";
            this.btnUsersUpdater.Click += new System.EventHandler(this.btnUsersUpdater_Click);
            // 
            // btnUsersDelete
            // 
            this.btnUsersDelete.Image = global::RentCars.Properties.Resources.database_user_remove;
            this.btnUsersDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsersDelete.Name = "btnUsersDelete";
            this.btnUsersDelete.Size = new System.Drawing.Size(68, 28);
            this.btnUsersDelete.Text = "Delete";
            this.btnUsersDelete.Click += new System.EventHandler(this.btnUsersDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 28);
            this.toolStripLabel1.Text = "Search";
            // 
            // btnUsersFind
            // 
            this.btnUsersFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsersFind.Name = "btnUsersFind";
            this.btnUsersFind.Size = new System.Drawing.Size(100, 31);
            // 
            // btnfind
            // 
            this.btnfind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnfind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnfind.Image = global::RentCars.Properties.Resources.database_user_search;
            this.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(28, 28);
            this.btnfind.Text = "toolStripButton1";
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(202, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // Tenants
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(672, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tenants";
            this.Text = "Tenants";
            this.Load += new System.EventHandler(this.Tenants_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUsersAdder;
        private System.Windows.Forms.ToolStripButton btnUsersUpdater;
        private System.Windows.Forms.ToolStripButton btnUsersDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox btnUsersFind;
        private System.Windows.Forms.ToolStripButton btnfind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsend;
    }
}