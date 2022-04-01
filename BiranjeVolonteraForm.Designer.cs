
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
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.nadjiVolonteraButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabelaPrikazOsobaDataGriedView = new System.Windows.Forms.DataGridView();
            this.idKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdresaKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazOsobaDataGriedView)).BeginInit();
            this.SuspendLayout();
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
            // tabelaPrikazOsobaDataGriedView
            // 
            this.tabelaPrikazOsobaDataGriedView.AllowUserToAddRows = false;
            this.tabelaPrikazOsobaDataGriedView.AllowUserToDeleteRows = false;
            this.tabelaPrikazOsobaDataGriedView.BackgroundColor = System.Drawing.Color.White;
            this.tabelaPrikazOsobaDataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPrikazOsobaDataGriedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKolona,
            this.imeKolona,
            this.prezimeKolona,
            this.brojTelefonaKolona,
            this.emailAdresaKolona});
            this.tabelaPrikazOsobaDataGriedView.GridColor = System.Drawing.Color.BlueViolet;

            this.tabelaPrikazOsobaDataGriedView.Location = new System.Drawing.Point(12, 149);

            this.tabelaPrikazOsobaDataGriedView.Name = "tabelaPrikazOsobaDataGriedView";
            this.tabelaPrikazOsobaDataGriedView.RowTemplate.Height = 25;
            this.tabelaPrikazOsobaDataGriedView.Size = new System.Drawing.Size(625, 192);
            this.tabelaPrikazOsobaDataGriedView.TabIndex = 5;
            // 
            // idKolona
            // 
            this.idKolona.HeaderText = "id";
            this.idKolona.Name = "idKolona";
            // 
            // imeKolona
            // 
            this.imeKolona.HeaderText = "ime";
            this.imeKolona.Name = "imeKolona";
            // 
            // prezimeKolona
            // 
            this.prezimeKolona.HeaderText = "prezime";
            this.prezimeKolona.Name = "prezimeKolona";
            // 
            // brojTelefonaKolona
            // 
            this.brojTelefonaKolona.HeaderText = "Broj Telefona";
            this.brojTelefonaKolona.Name = "brojTelefonaKolona";
            // 
            // emailAdresaKolona
            // 
            this.emailAdresaKolona.HeaderText = "Email Adresa";
            this.emailAdresaKolona.Name = "emailAdresaKolona";
            // 
            // BiranjeVolonteraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(671, 428);
            this.Controls.Add(this.tabelaPrikazOsobaDataGriedView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nadjiVolonteraButton);
            this.Controls.Add(this.prezimeTextBox);
            this.Name = "BiranjeVolonteraForm";
            this.Text = "BiranjeVolonteraForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazOsobaDataGriedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Button nadjiVolonteraButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabelaPrikazOsobaDataGriedView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdresaKolona;
    }
}