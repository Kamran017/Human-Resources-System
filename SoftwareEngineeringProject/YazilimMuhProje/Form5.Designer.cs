namespace YazilimMuhProje
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.secondSite = new System.Windows.Forms.Label();
            this.firstSite = new System.Windows.Forms.Label();
            this.compensationHeader = new System.Windows.Forms.Label();
            this.compensationContent = new System.Windows.Forms.Panel();
            this.compensationContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondSite
            // 
            this.secondSite.AutoSize = true;
            this.secondSite.BackColor = System.Drawing.Color.Transparent;
            this.secondSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondSite.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secondSite.ForeColor = System.Drawing.Color.White;
            this.secondSite.Location = new System.Drawing.Point(278, 442);
            this.secondSite.Name = "secondSite";
            this.secondSite.Size = new System.Drawing.Size(246, 37);
            this.secondSite.TabIndex = 9;
            this.secondSite.Text = "Quittance.co.uk";
            // 
            // firstSite
            // 
            this.firstSite.AutoSize = true;
            this.firstSite.BackColor = System.Drawing.Color.Transparent;
            this.firstSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstSite.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstSite.ForeColor = System.Drawing.Color.White;
            this.firstSite.Location = new System.Drawing.Point(163, 317);
            this.firstSite.Name = "firstSite";
            this.firstSite.Size = new System.Drawing.Size(499, 37);
            this.firstSite.TabIndex = 8;
            this.firstSite.Text = "National-Accident-Helpline.Co.Uk";
            this.firstSite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compensationHeader
            // 
            this.compensationHeader.AutoSize = true;
            this.compensationHeader.BackColor = System.Drawing.Color.Transparent;
            this.compensationHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.compensationHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.compensationHeader.Location = new System.Drawing.Point(162, 52);
            this.compensationHeader.Name = "compensationHeader";
            this.compensationHeader.Size = new System.Drawing.Size(514, 129);
            this.compensationHeader.TabIndex = 10;
            this.compensationHeader.Text = "Please select one of the\r\nchoices for the compensation\r\ncalculation!";
            this.compensationHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compensationContent
            // 
            this.compensationContent.BackColor = System.Drawing.Color.DarkGreen;
            this.compensationContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("compensationContent.BackgroundImage")));
            this.compensationContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compensationContent.Controls.Add(this.compensationHeader);
            this.compensationContent.Controls.Add(this.firstSite);
            this.compensationContent.Controls.Add(this.secondSite);
            this.compensationContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.compensationContent.Location = new System.Drawing.Point(299, 0);
            this.compensationContent.Name = "compensationContent";
            this.compensationContent.Size = new System.Drawing.Size(849, 753);
            this.compensationContent.TabIndex = 8;
            this.compensationContent.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 753);
            this.Controls.Add(this.compensationContent);
            this.Name = "Form5";
            this.Text = "Form5";
            this.compensationContent.ResumeLayout(false);
            this.compensationContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label secondSite;
        private System.Windows.Forms.Label firstSite;
        private System.Windows.Forms.Label compensationHeader;
        private System.Windows.Forms.Panel compensationContent;
    }
}