﻿namespace WHATechChallenge
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSettled = new System.Windows.Forms.TextBox();
            this.txtUnsettled = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSettled = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUnsettled = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSettledSum = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUnsettledSum = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettled)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettled)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledSum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledSum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settled CSV Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unsettled CSV Location:";
            // 
            // txtSettled
            // 
            this.txtSettled.Enabled = false;
            this.txtSettled.Location = new System.Drawing.Point(141, 19);
            this.txtSettled.Name = "txtSettled";
            this.txtSettled.Size = new System.Drawing.Size(373, 20);
            this.txtSettled.TabIndex = 1;
            // 
            // txtUnsettled
            // 
            this.txtUnsettled.Enabled = false;
            this.txtUnsettled.Location = new System.Drawing.Point(141, 46);
            this.txtUnsettled.Name = "txtUnsettled";
            this.txtUnsettled.Size = new System.Drawing.Size(373, 20);
            this.txtUnsettled.TabIndex = 1;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(520, 19);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(24, 20);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(520, 46);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(24, 20);
            this.btnBrowse2.TabIndex = 2;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(550, 19);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(91, 47);
            this.btnEvaluate.TabIndex = 3;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSettled);
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settled Table";
            // 
            // dgvSettled
            // 
            this.dgvSettled.AllowUserToAddRows = false;
            this.dgvSettled.AllowUserToDeleteRows = false;
            this.dgvSettled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSettled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSettled.Location = new System.Drawing.Point(3, 16);
            this.dgvSettled.Name = "dgvSettled";
            this.dgvSettled.ReadOnly = true;
            this.dgvSettled.RowHeadersVisible = false;
            this.dgvSettled.Size = new System.Drawing.Size(455, 145);
            this.dgvSettled.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUnsettled);
            this.groupBox2.Location = new System.Drawing.Point(15, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 164);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unsettled Table";
            // 
            // dgvUnsettled
            // 
            this.dgvUnsettled.AllowUserToAddRows = false;
            this.dgvUnsettled.AllowUserToDeleteRows = false;
            this.dgvUnsettled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnsettled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnsettled.Location = new System.Drawing.Point(3, 16);
            this.dgvUnsettled.Name = "dgvUnsettled";
            this.dgvUnsettled.ReadOnly = true;
            this.dgvUnsettled.RowHeadersVisible = false;
            this.dgvUnsettled.Size = new System.Drawing.Size(455, 145);
            this.dgvUnsettled.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSettledSum);
            this.groupBox3.Location = new System.Drawing.Point(482, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 164);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // dgvSettledSum
            // 
            this.dgvSettledSum.AllowUserToAddRows = false;
            this.dgvSettledSum.AllowUserToDeleteRows = false;
            this.dgvSettledSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSettledSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettledSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSettledSum.Location = new System.Drawing.Point(3, 16);
            this.dgvSettledSum.Name = "dgvSettledSum";
            this.dgvSettledSum.ReadOnly = true;
            this.dgvSettledSum.RowHeadersVisible = false;
            this.dgvSettledSum.Size = new System.Drawing.Size(153, 145);
            this.dgvSettledSum.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvUnsettledSum);
            this.groupBox4.Location = new System.Drawing.Point(482, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 164);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summary";
            // 
            // dgvUnsettledSum
            // 
            this.dgvUnsettledSum.AllowUserToAddRows = false;
            this.dgvUnsettledSum.AllowUserToDeleteRows = false;
            this.dgvUnsettledSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnsettledSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnsettledSum.Location = new System.Drawing.Point(3, 16);
            this.dgvUnsettledSum.Name = "dgvUnsettledSum";
            this.dgvUnsettledSum.ReadOnly = true;
            this.dgvUnsettledSum.RowHeadersVisible = false;
            this.dgvUnsettledSum.Size = new System.Drawing.Size(153, 145);
            this.dgvUnsettledSum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtUnsettled);
            this.Controls.Add(this.txtSettled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WhatTechChallenge";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettled)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettled)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledSum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSettled;
        private System.Windows.Forms.TextBox txtUnsettled;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSettled;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUnsettled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSettledSum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvUnsettledSum;
    }
}

