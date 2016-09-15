namespace WHATechChallenge
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riskLegendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettled)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettled)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledSum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settled CSV Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unsettled CSV Location:";
            // 
            // txtSettled
            // 
            this.txtSettled.Enabled = false;
            this.txtSettled.Location = new System.Drawing.Point(141, 26);
            this.txtSettled.Name = "txtSettled";
            this.txtSettled.Size = new System.Drawing.Size(456, 20);
            this.txtSettled.TabIndex = 1;
            // 
            // txtUnsettled
            // 
            this.txtUnsettled.Enabled = false;
            this.txtUnsettled.Location = new System.Drawing.Point(141, 53);
            this.txtUnsettled.Name = "txtUnsettled";
            this.txtUnsettled.Size = new System.Drawing.Size(456, 20);
            this.txtUnsettled.TabIndex = 1;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(603, 26);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(24, 20);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(603, 53);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(24, 20);
            this.btnBrowse2.TabIndex = 2;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(633, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 201);
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
            this.dgvSettled.Size = new System.Drawing.Size(505, 182);
            this.dgvSettled.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUnsettled);
            this.groupBox2.Location = new System.Drawing.Point(15, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 164);
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
            this.dgvUnsettled.Size = new System.Drawing.Size(703, 145);
            this.dgvUnsettled.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSettledSum);
            this.groupBox3.Location = new System.Drawing.Point(532, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 201);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bet History Summary";
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
            this.dgvSettledSum.Size = new System.Drawing.Size(186, 182);
            this.dgvSettledSum.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riskLegendToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riskLegendToolStripMenuItem
            // 
            this.riskLegendToolStripMenuItem.Name = "riskLegendToolStripMenuItem";
            this.riskLegendToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.riskLegendToolStripMenuItem.Text = "Risk Legend";
            this.riskLegendToolStripMenuItem.Click += new System.EventHandler(this.riskLegendToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtUnsettled);
            this.Controls.Add(this.txtSettled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WhatTechChallenge";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettled)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettled)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledSum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riskLegendToolStripMenuItem;
    }
}

