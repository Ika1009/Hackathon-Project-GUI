
namespace Hackathon_Project_GUI
{
    partial class ParkingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pretrazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brojpmmesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pretrazi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 521);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.logoovoono;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(146, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 56);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite opštinu";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // pretrazi
            // 
            this.pretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pretrazi.Location = new System.Drawing.Point(18, 352);
            this.pretrazi.Name = "pretrazi";
            this.pretrazi.Size = new System.Drawing.Size(143, 49);
            this.pretrazi.TabIndex = 2;
            this.pretrazi.Text = "Pretraži";
            this.pretrazi.UseVisualStyleBackColor = true;
            this.pretrazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ulica,
            this.Brojpmmesta,
            this.Zona,
            this.Napomena});
            this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView1.Location = new System.Drawing.Point(232, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(736, 521);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ulica
            // 
            this.Ulica.HeaderText = "Ulica";
            this.Ulica.MinimumWidth = 6;
            this.Ulica.Name = "Ulica";
            this.Ulica.ReadOnly = true;
            this.Ulica.Width = 225;
            // 
            // Brojpmmesta
            // 
            this.Brojpmmesta.HeaderText = "Broj parking mesta";
            this.Brojpmmesta.MinimumWidth = 6;
            this.Brojpmmesta.Name = "Brojpmmesta";
            this.Brojpmmesta.ReadOnly = true;
            this.Brojpmmesta.Width = 75;
            // 
            // Zona
            // 
            this.Zona.HeaderText = "Zona";
            this.Zona.MinimumWidth = 6;
            this.Zona.Name = "Zona";
            this.Zona.ReadOnly = true;
            this.Zona.Width = 75;
            // 
            // Napomena
            // 
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 375;
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(980, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ParkingForm";
            this.Text = "ParkingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pretrazi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brojpmmesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}