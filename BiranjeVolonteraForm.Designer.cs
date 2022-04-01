
namespace Hackathon_Project_GUI
{
    partial class BiranjeVolonteraForm
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
            this.volonteriIzBazePodatakaListBox = new System.Windows.Forms.ListBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.nadjiVolonteraButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volonteriIzBazePodatakaListBox
            // 
            this.volonteriIzBazePodatakaListBox.FormattingEnabled = true;
            this.volonteriIzBazePodatakaListBox.ItemHeight = 15;
            this.volonteriIzBazePodatakaListBox.Location = new System.Drawing.Point(12, 116);
            this.volonteriIzBazePodatakaListBox.Name = "volonteriIzBazePodatakaListBox";
            this.volonteriIzBazePodatakaListBox.Size = new System.Drawing.Size(299, 334);
            this.volonteriIzBazePodatakaListBox.TabIndex = 0;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(12, 28);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 23);
            this.prezimeTextBox.TabIndex = 1;
            // 
            // nadjiVolonteraButton
            // 
            this.nadjiVolonteraButton.Location = new System.Drawing.Point(12, 70);
            this.nadjiVolonteraButton.Name = "nadjiVolonteraButton";
            this.nadjiVolonteraButton.Size = new System.Drawing.Size(75, 23);
            this.nadjiVolonteraButton.TabIndex = 2;
            this.nadjiVolonteraButton.Text = "Potrazi";
            this.nadjiVolonteraButton.UseVisualStyleBackColor = true;
            this.nadjiVolonteraButton.Click += new System.EventHandler(this.nadjiVolonteraButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // BiranjeVolonteraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nadjiVolonteraButton);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.volonteriIzBazePodatakaListBox);
            this.Name = "BiranjeVolonteraForm";
            this.Text = "BiranjeVolonteraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox volonteriIzBazePodatakaListBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Button nadjiVolonteraButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}