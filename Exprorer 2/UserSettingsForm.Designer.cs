namespace Exprorer_2
{
    partial class UserSettingsForm
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
            this.label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CancelSaveChangesButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(48, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Explorer label:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(239, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 32);
            this.textBox1.TabIndex = 1;
            // 
            // CancelSaveChangesButton
            // 
            this.CancelSaveChangesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSaveChangesButton.Location = new System.Drawing.Point(421, 100);
            this.CancelSaveChangesButton.Name = "CancelSaveChangesButton";
            this.CancelSaveChangesButton.Size = new System.Drawing.Size(130, 50);
            this.CancelSaveChangesButton.TabIndex = 8;
            this.CancelSaveChangesButton.Text = "Cancel";
            this.CancelSaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.Location = new System.Drawing.Point(62, 100);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(202, 50);
            this.SaveChangesButton.TabIndex = 9;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // UserSettingsForm
            // 
            this.AcceptButton = this.SaveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelSaveChangesButton;
            this.ClientSize = new System.Drawing.Size(595, 172);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.CancelSaveChangesButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CancelSaveChangesButton;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}