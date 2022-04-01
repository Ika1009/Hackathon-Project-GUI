namespace Hackathon_Project_GUI
{
    partial class DodavanjeVolonteraForm
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
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.godineTextBox = new System.Windows.Forms.TextBox();
            this.dodajVolonteraButton = new System.Windows.Forms.Button();
            this.brojTelefonaTextBox = new System.Windows.Forms.TextBox();
            this.emailAdresaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(185, 34);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(150, 23);
            this.imeTextBox.TabIndex = 0;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(185, 77);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(150, 23);
            this.prezimeTextBox.TabIndex = 1;
            // 
            // godineTextBox
            // 
            this.godineTextBox.Location = new System.Drawing.Point(185, 119);
            this.godineTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.godineTextBox.Name = "godineTextBox";
            this.godineTextBox.Size = new System.Drawing.Size(150, 23);
            this.godineTextBox.TabIndex = 2;
            // 
            // dodajVolonteraButton
            // 
            this.dodajVolonteraButton.Location = new System.Drawing.Point(214, 278);
            this.dodajVolonteraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajVolonteraButton.Name = "dodajVolonteraButton";
            this.dodajVolonteraButton.Size = new System.Drawing.Size(82, 22);
            this.dodajVolonteraButton.TabIndex = 3;
            this.dodajVolonteraButton.Text = "button1";
            this.dodajVolonteraButton.UseVisualStyleBackColor = true;
            this.dodajVolonteraButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // brojTelefonaTextBox
            // 
            this.brojTelefonaTextBox.Location = new System.Drawing.Point(185, 159);
            this.brojTelefonaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brojTelefonaTextBox.Name = "brojTelefonaTextBox";
            this.brojTelefonaTextBox.Size = new System.Drawing.Size(150, 23);
            this.brojTelefonaTextBox.TabIndex = 4;
            // 
            // emailAdresaTextBox
            // 
            this.emailAdresaTextBox.Location = new System.Drawing.Point(185, 203);
            this.emailAdresaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailAdresaTextBox.Name = "emailAdresaTextBox";
            this.emailAdresaTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailAdresaTextBox.TabIndex = 5;
            // 
            // DodavanjeVolonteraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 365);
            this.Controls.Add(this.emailAdresaTextBox);
            this.Controls.Add(this.brojTelefonaTextBox);
            this.Controls.Add(this.dodajVolonteraButton);
            this.Controls.Add(this.godineTextBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DodavanjeVolonteraForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox godineTextBox;
        private System.Windows.Forms.Button dodajVolonteraButton;
        private System.Windows.Forms.TextBox brojTelefonaTextBox;
        private System.Windows.Forms.TextBox emailAdresaTextBox;
    }
}