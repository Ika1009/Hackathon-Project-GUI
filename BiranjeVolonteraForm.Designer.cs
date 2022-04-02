
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabelaPrikazOsobaDataGriedView = new System.Windows.Forms.DataGridView();
            this.idKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojGodinaKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaKolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazOsobaDataGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
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
            this.BrojGodinaKolona,
            this.Column1,
            this.brojTelefonaKolona,
            this.Column2,
            this.Column3});
            this.tabelaPrikazOsobaDataGriedView.GridColor = System.Drawing.Color.BlueViolet;
            this.tabelaPrikazOsobaDataGriedView.Location = new System.Drawing.Point(22, 61);

            this.tabelaPrikazOsobaDataGriedView.Name = "tabelaPrikazOsobaDataGriedView";
            this.tabelaPrikazOsobaDataGriedView.RowTemplate.Height = 25;
            this.tabelaPrikazOsobaDataGriedView.Size = new System.Drawing.Size(868, 374);
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
            // BrojGodinaKolona
            // 
            this.BrojGodinaKolona.HeaderText = "Broj Godina";
            this.BrojGodinaKolona.Name = "BrojGodinaKolona";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pol";
            this.Column1.Name = "Column1";
            // 
            // brojTelefonaKolona
            // 
            this.brojTelefonaKolona.HeaderText = "Broj Telefona";
            this.brojTelefonaKolona.Name = "brojTelefonaKolona";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Opstina";
            this.Column3.Name = "Column3";
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(12, 455);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(75, 23);
            this.nazadButton.TabIndex = 6;
            this.nazadButton.Text = "nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // BiranjeVolonteraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(953, 502);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.tabelaPrikazOsobaDataGriedView);
            this.Controls.Add(this.label1);
            this.Name = "BiranjeVolonteraForm";
            this.Text = "BiranjeVolonteraForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazOsobaDataGriedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabelaPrikazOsobaDataGriedView;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojGodinaKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaKolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}