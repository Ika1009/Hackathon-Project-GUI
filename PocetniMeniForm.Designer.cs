
namespace Hackathon_Project_GUI
{
    partial class PocetniMeniForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // webBrowser1

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetniMeniForm));
            this.settingsButton = new System.Windows.Forms.Button();
            this.igriceButton = new System.Windows.Forms.Button();
            this.mestaButton = new System.Windows.Forms.Button();
            this.pomocButton = new System.Windows.Forms.Button();
            this.lokacijeButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.podesavanja_dugme;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(650, 10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(60, 60);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // igriceButton
            // 
            this.igriceButton.AutoSize = true;
            this.igriceButton.BackColor = System.Drawing.Color.Transparent;
            this.igriceButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.igrice_dugme;
            this.igriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.igriceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igriceButton.ForeColor = System.Drawing.Color.Transparent;
            this.igriceButton.Location = new System.Drawing.Point(135, 575);
            this.igriceButton.Name = "igriceButton";
            this.igriceButton.Size = new System.Drawing.Size(180, 180);
            this.igriceButton.TabIndex = 2;
            this.igriceButton.UseVisualStyleBackColor = false;
            this.igriceButton.Click += new System.EventHandler(this.igriceButton_Click);
            // 
            // mestaButton
            // 
            this.mestaButton.AutoSize = true;
            this.mestaButton.BackColor = System.Drawing.Color.Transparent;
            this.mestaButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.mesta_dugme21;
            this.mestaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mestaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mestaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mestaButton.ForeColor = System.Drawing.Color.Transparent;
            this.mestaButton.Location = new System.Drawing.Point(135, 305);
            this.mestaButton.Name = "mestaButton";
            this.mestaButton.Size = new System.Drawing.Size(180, 180);
            this.mestaButton.TabIndex = 3;
            this.mestaButton.UseVisualStyleBackColor = false;
            this.mestaButton.Click += new System.EventHandler(this.mestaButton_Click);
            // 
            // pomocButton
            // 
            this.pomocButton.AutoSize = true;
            this.pomocButton.BackColor = System.Drawing.Color.Transparent;
            this.pomocButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.pomoc_dugme;
            this.pomocButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pomocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pomocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomocButton.ForeColor = System.Drawing.Color.Transparent;
            this.pomocButton.Location = new System.Drawing.Point(405, 305);
            this.pomocButton.Name = "pomocButton";
            this.pomocButton.Size = new System.Drawing.Size(180, 180);
            this.pomocButton.TabIndex = 4;
            this.pomocButton.UseVisualStyleBackColor = false;
            this.pomocButton.Click += new System.EventHandler(this.pomocButton_Click);
            this.pomocButton.MouseEnter += new System.EventHandler(this.pomocover);
            this.pomocButton.MouseHover += new System.EventHandler(this.pomocleave);
            // 
            // lokacijeButton
            // 
            this.lokacijeButton.AutoSize = true;
            this.lokacijeButton.BackColor = System.Drawing.Color.Transparent;
            this.lokacijeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lokacijeButton.BackgroundImage")));
            this.lokacijeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lokacijeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lokacijeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokacijeButton.Location = new System.Drawing.Point(405, 575);
            this.lokacijeButton.Name = "lokacijeButton";
            this.lokacijeButton.Size = new System.Drawing.Size(180, 180);
            this.lokacijeButton.TabIndex = 5;
            this.lokacijeButton.UseVisualStyleBackColor = false;
            this.lokacijeButton.Click += new System.EventHandler(this.lokacijeButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.info_dugme;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Location = new System.Drawing.Point(10, 10);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(40, 40);
            this.infoButton.TabIndex = 6;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(148, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Potraži volontera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(418, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Postani volonter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(195, 758);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Igrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(424, 757);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mapa parkinga";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.mrtvi_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(190, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 250);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PocetniMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.pozadina21;
            this.ClientSize = new System.Drawing.Size(724, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.lokacijeButton);
            this.Controls.Add(this.pomocButton);
            this.Controls.Add(this.mestaButton);
            this.Controls.Add(this.igriceButton);
            this.Controls.Add(this.settingsButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(1682, 978);
            this.MinimumSize = new System.Drawing.Size(740, 900);
            this.Name = "PocetniMeniForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.PocetniMeniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button igriceButton;
        private System.Windows.Forms.Button mestaButton;
        private System.Windows.Forms.Button pomocButton;
        private System.Windows.Forms.Button lokacijeButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

