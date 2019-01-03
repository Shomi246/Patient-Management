namespace PatientsManagement
{
    partial class PatientsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsDetails));
            this.newp = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newp
            // 
            this.newp.BackColor = System.Drawing.Color.LightSalmon;
            this.newp.Location = new System.Drawing.Point(472, 22);
            this.newp.Name = "newp";
            this.newp.Size = new System.Drawing.Size(104, 25);
            this.newp.TabIndex = 0;
            this.newp.Text = "Add New Patients";
            this.newp.UseVisualStyleBackColor = false;
            this.newp.Click += new System.EventHandler(this.newp_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.LightSalmon;
            this.search.Location = new System.Drawing.Point(220, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(22, 164);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(587, 193);
            this.datagrid.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(83, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Serial No:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(142, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(153, 20);
            this.txtid.TabIndex = 2;
            // 
            // PatientsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 424);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newp);
            this.Name = "PatientsDetails";
            this.Text = "Patients Details";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newp;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
    }
}

