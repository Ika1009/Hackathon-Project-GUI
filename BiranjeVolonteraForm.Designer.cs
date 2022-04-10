
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiranjeVolonteraForm));
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikazOsobaDataGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // tabelaPrikazOsobaDataGriedView
            // 
            this.tabelaPrikazOsobaDataGriedView.AllowUserToAddRows = false;
            this.tabelaPrikazOsobaDataGriedView.AllowUserToDeleteRows = false;
            this.tabelaPrikazOsobaDataGriedView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
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
            this.tabelaPrikazOsobaDataGriedView.Location = new System.Drawing.Point(25, 123);
            this.tabelaPrikazOsobaDataGriedView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelaPrikazOsobaDataGriedView.Name = "tabelaPrikazOsobaDataGriedView";
            this.tabelaPrikazOsobaDataGriedView.RowHeadersWidth = 51;
            this.tabelaPrikazOsobaDataGriedView.RowTemplate.Height = 25;
            this.tabelaPrikazOsobaDataGriedView.Size = new System.Drawing.Size(1008, 499);
            this.tabelaPrikazOsobaDataGriedView.TabIndex = 5;
            this.tabelaPrikazOsobaDataGriedView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPrikazOsobaDataGriedView_CellContentClick);
            // 
            // idKolona
            // 
            this.idKolona.HeaderText = "id";
            this.idKolona.MinimumWidth = 6;
            this.idKolona.Name = "idKolona";
            this.idKolona.Width = 80;
            // 
            // imeKolona
            // 
            this.imeKolona.HeaderText = "ime";
            this.imeKolona.MinimumWidth = 6;
            this.imeKolona.Name = "imeKolona";
            this.imeKolona.Width = 125;
            // 
            // prezimeKolona
            // 
            this.prezimeKolona.HeaderText = "prezime";
            this.prezimeKolona.MinimumWidth = 6;
            this.prezimeKolona.Name = "prezimeKolona";
            this.prezimeKolona.Width = 125;
            // 
            // BrojGodinaKolona
            // 
            this.BrojGodinaKolona.HeaderText = "Broj Godina";
            this.BrojGodinaKolona.MinimumWidth = 6;
            this.BrojGodinaKolona.Name = "BrojGodinaKolona";
            this.BrojGodinaKolona.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pol";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // brojTelefonaKolona
            // 
            this.brojTelefonaKolona.HeaderText = "Broj Telefona";
            this.brojTelefonaKolona.MinimumWidth = 6;
            this.brojTelefonaKolona.Name = "brojTelefonaKolona";
            this.brojTelefonaKolona.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Opstina";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // nazadButton
            // 
            this.nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
            this.nazadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nazadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Location = new System.Drawing.Point(11, 13);
            this.nazadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(45, 45);
            this.nazadButton.TabIndex = 6;
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            this.nazadButton.MouseEnter += new System.EventHandler(this.over);
            this.nazadButton.MouseLeave += new System.EventHandler(this.leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(342, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista dostupnih volontera: ";
            // 
            // BiranjeVolonteraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1055, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.tabelaPrikazOsobaDataGriedView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BiranjeVolonteraForm";
            this.Text = "Lista volontera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BiranjeVolonteraForm_FormClosed);
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
        private System.Windows.Forms.Label label2;
    }
}