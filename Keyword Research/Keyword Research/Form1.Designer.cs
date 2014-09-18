namespace Keyword_Research
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
            this.siteurl = new System.Windows.Forms.TextBox();
            this.googlecountry = new System.Windows.Forms.ComboBox();
            this.KeywordsList = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siteurl
            // 
            this.siteurl.Location = new System.Drawing.Point(12, 12);
            this.siteurl.Multiline = true;
            this.siteurl.Name = "siteurl";
            this.siteurl.Size = new System.Drawing.Size(625, 31);
            this.siteurl.TabIndex = 0;
            // 
            // googlecountry
            // 
            this.googlecountry.AllowDrop = true;
            this.googlecountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.googlecountry.FormattingEnabled = true;
            this.googlecountry.Items.AddRange(new object[] {
            "US",
            "UK",
            "CA",
            "PK"});
            this.googlecountry.Location = new System.Drawing.Point(12, 61);
            this.googlecountry.Name = "googlecountry";
            this.googlecountry.Size = new System.Drawing.Size(625, 21);
            this.googlecountry.TabIndex = 1;
            // 
            // KeywordsList
            // 
            this.KeywordsList.Location = new System.Drawing.Point(12, 98);
            this.KeywordsList.Multiline = true;
            this.KeywordsList.Name = "KeywordsList";
            this.KeywordsList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KeywordsList.Size = new System.Drawing.Size(625, 164);
            this.KeywordsList.TabIndex = 2;
            this.KeywordsList.Text = "Enter One Keyword Per LIne";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Keyword,
            this.Rank});
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // Keyword
            // 
            this.Keyword.HeaderText = "Keyword";
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            this.Keyword.Width = 312;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Width = 312;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KeywordsList);
            this.Controls.Add(this.googlecountry);
            this.Controls.Add(this.siteurl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox siteurl;
        private System.Windows.Forms.ComboBox googlecountry;
        private System.Windows.Forms.TextBox KeywordsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.Button button1;
    }
}

