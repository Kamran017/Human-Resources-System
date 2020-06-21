namespace YazilimMuhProje
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.employeeHeader = new System.Windows.Forms.Label();
            this.employeeInformationGrid = new System.Windows.Forms.DataGridView();
            this.employeeContent = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationGrid)).BeginInit();
            this.employeeContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeHeader
            // 
            this.employeeHeader.AutoSize = true;
            this.employeeHeader.BackColor = System.Drawing.Color.Transparent;
            this.employeeHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeHeader.ForeColor = System.Drawing.Color.Black;
            this.employeeHeader.Location = new System.Drawing.Point(316, 30);
            this.employeeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeHeader.Name = "employeeHeader";
            this.employeeHeader.Size = new System.Drawing.Size(250, 61);
            this.employeeHeader.TabIndex = 17;
            this.employeeHeader.Text = "Employees";
            // 
            // employeeInformationGrid
            // 
            this.employeeInformationGrid.AllowUserToAddRows = false;
            this.employeeInformationGrid.AllowUserToDeleteRows = false;
            this.employeeInformationGrid.AllowUserToResizeColumns = false;
            this.employeeInformationGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.employeeInformationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeInformationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeInformationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.employeeInformationGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.employeeInformationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeInformationGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.employeeInformationGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeInformationGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeInformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeInformationGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeInformationGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeInformationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.employeeInformationGrid.Location = new System.Drawing.Point(0, 120);
            this.employeeInformationGrid.Name = "employeeInformationGrid";
            this.employeeInformationGrid.ReadOnly = true;
            this.employeeInformationGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeInformationGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.employeeInformationGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.employeeInformationGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeeInformationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeInformationGrid.Size = new System.Drawing.Size(852, 633);
            this.employeeInformationGrid.TabIndex = 29;
            this.employeeInformationGrid.Visible = false;
            // 
            // employeeContent
            // 
            this.employeeContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeContent.BackgroundImage")));
            this.employeeContent.Controls.Add(this.employeeInformationGrid);
            this.employeeContent.Controls.Add(this.employeeHeader);
            this.employeeContent.Location = new System.Drawing.Point(148, 0);
            this.employeeContent.Name = "employeeContent";
            this.employeeContent.Size = new System.Drawing.Size(852, 753);
            this.employeeContent.TabIndex = 31;
            this.employeeContent.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 753);
            this.Controls.Add(this.employeeContent);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationGrid)).EndInit();
            this.employeeContent.ResumeLayout(false);
            this.employeeContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeHeader;
        private System.Windows.Forms.DataGridView employeeInformationGrid;
        private System.Windows.Forms.Panel employeeContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}