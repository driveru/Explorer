namespace Exprorer_2
{
    partial class FindBookForm
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
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.BooksCountTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.CancelFindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(93, 26);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(88, 29);
            this.Label.TabIndex = 1;
            this.Label.Text = "Query:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books count:";
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryTextBox.Location = new System.Drawing.Point(187, 26);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(310, 32);
            this.QueryTextBox.TabIndex = 3;
            // 
            // BooksCountTextBox
            // 
            this.BooksCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BooksCountTextBox.Location = new System.Drawing.Point(187, 72);
            this.BooksCountTextBox.Name = "BooksCountTextBox";
            this.BooksCountTextBox.Size = new System.Drawing.Size(310, 32);
            this.BooksCountTextBox.TabIndex = 4;
            // 
            // FindButton
            // 
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(50, 146);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(121, 54);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // CancelFindButton
            // 
            this.CancelFindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelFindButton.Location = new System.Drawing.Point(362, 146);
            this.CancelFindButton.Name = "CancelFindButton";
            this.CancelFindButton.Size = new System.Drawing.Size(121, 54);
            this.CancelFindButton.TabIndex = 6;
            this.CancelFindButton.Text = "Cancel";
            this.CancelFindButton.UseVisualStyleBackColor = true;
            // 
            // FindBookForm
            // 
            this.AcceptButton = this.FindButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelFindButton;
            this.ClientSize = new System.Drawing.Size(509, 212);
            this.Controls.Add(this.CancelFindButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.BooksCountTextBox);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Name = "FindBookForm";
            this.Text = "FindBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.TextBox BooksCountTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button CancelFindButton;
    }
}