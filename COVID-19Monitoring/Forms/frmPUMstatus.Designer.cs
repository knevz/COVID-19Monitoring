﻿namespace COVID_19Monitoring.Forms
{
    partial class frmPUMstatus
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.cbPUMstatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Status";
            // 
            // dtpDateUpdated
            // 
            this.dtpDateUpdated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateUpdated.Location = new System.Drawing.Point(91, 104);
            this.dtpDateUpdated.Name = "dtpDateUpdated";
            this.dtpDateUpdated.Size = new System.Drawing.Size(200, 20);
            this.dtpDateUpdated.TabIndex = 11;
            // 
            // cbPUMstatus
            // 
            this.cbPUMstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPUMstatus.FormattingEnabled = true;
            this.cbPUMstatus.Items.AddRange(new object[] {
            "Case Closed",
            "Transferred Out",
            "Death"});
            this.cbPUMstatus.Location = new System.Drawing.Point(91, 61);
            this.cbPUMstatus.Name = "cbPUMstatus";
            this.cbPUMstatus.Size = new System.Drawing.Size(200, 21);
            this.cbPUMstatus.TabIndex = 10;
            // 
            // frmPUMstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 199);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateUpdated);
            this.Controls.Add(this.cbPUMstatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPUMstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update PUM Status";
            this.Load += new System.EventHandler(this.frmPUMstatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateUpdated;
        private System.Windows.Forms.ComboBox cbPUMstatus;
    }
}