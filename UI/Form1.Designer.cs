namespace UI
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
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnShowOnMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgents
            // 
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Location = new System.Drawing.Point(12, 25);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.Size = new System.Drawing.Size(249, 214);
            this.dgvAgents.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(9, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(126, 13);
            this.header.TabIndex = 1;
            this.header.Text = "Top 5 closest agents";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(356, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(951, 681);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnShowOnMap
            // 
            this.btnShowOnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOnMap.Location = new System.Drawing.Point(267, 56);
            this.btnShowOnMap.Name = "btnShowOnMap";
            this.btnShowOnMap.Size = new System.Drawing.Size(83, 34);
            this.btnShowOnMap.TabIndex = 3;
            this.btnShowOnMap.Text = "Show On Map";
            this.btnShowOnMap.UseVisualStyleBackColor = true;
            this.btnShowOnMap.Click += new System.EventHandler(this.btnShowOnMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 714);
            this.Controls.Add(this.btnShowOnMap);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.dgvAgents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnShowOnMap;
    }
}

