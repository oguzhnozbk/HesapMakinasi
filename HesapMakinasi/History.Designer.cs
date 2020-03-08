namespace HesapMakinasi
{
    partial class History
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
            this.HistoryTextBox = new System.Windows.Forms.RichTextBox();
            this.btnHistoryDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HistoryTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.ReadOnly = true;
            this.HistoryTextBox.Size = new System.Drawing.Size(337, 575);
            this.HistoryTextBox.TabIndex = 0;
            this.HistoryTextBox.Text = "";
            // 
            // btnHistoryDelete
            // 
            this.btnHistoryDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHistoryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryDelete.Location = new System.Drawing.Point(13, 594);
            this.btnHistoryDelete.Name = "btnHistoryDelete";
            this.btnHistoryDelete.Size = new System.Drawing.Size(336, 25);
            this.btnHistoryDelete.TabIndex = 1;
            this.btnHistoryDelete.Text = "Geçmişi Sil";
            this.btnHistoryDelete.UseVisualStyleBackColor = false;
            this.btnHistoryDelete.Click += new System.EventHandler(this.btnHistoryDelete_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 631);
            this.Controls.Add(this.btnHistoryDelete);
            this.Controls.Add(this.HistoryTextBox);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HistoryTextBox;
        private System.Windows.Forms.Button btnHistoryDelete;
    }
}