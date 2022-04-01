
namespace Hackathon_Project_GUI
{
    partial class settingsForm
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
            this.ugasiMuzikuButton = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.muzika1Button = new System.Windows.Forms.Button();
            this.muzika2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ugasiMuzikuButton
            // 
            this.ugasiMuzikuButton.BackColor = System.Drawing.Color.Transparent;
            this.ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_on_dugme;
            this.ugasiMuzikuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ugasiMuzikuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ugasiMuzikuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ugasiMuzikuButton.ForeColor = System.Drawing.Color.Teal;
            this.ugasiMuzikuButton.Location = new System.Drawing.Point(160, 91);
            this.ugasiMuzikuButton.Name = "ugasiMuzikuButton";
            this.ugasiMuzikuButton.Size = new System.Drawing.Size(60, 60);
            this.ugasiMuzikuButton.TabIndex = 0;
            this.ugasiMuzikuButton.UseVisualStyleBackColor = false;
            this.ugasiMuzikuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.BackColor = System.Drawing.Color.Transparent;
            this.nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
            this.nazadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nazadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.ForeColor = System.Drawing.Color.Teal;
            this.nazadButton.Location = new System.Drawing.Point(10, 10);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(40, 40);
            this.nazadButton.TabIndex = 1;
            this.nazadButton.UseVisualStyleBackColor = false;
            this.nazadButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // muzika1Button
            // 
            this.muzika1Button.BackColor = System.Drawing.Color.Transparent;
            this.muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_on_dugme;
            this.muzika1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muzika1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muzika1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muzika1Button.ForeColor = System.Drawing.Color.Teal;
            this.muzika1Button.Location = new System.Drawing.Point(160, 162);
            this.muzika1Button.Name = "muzika1Button";
            this.muzika1Button.Size = new System.Drawing.Size(60, 60);
            this.muzika1Button.TabIndex = 2;
            this.muzika1Button.UseVisualStyleBackColor = false;
            this.muzika1Button.Click += new System.EventHandler(this.muzika1Button_Click);
            // 
            // muzika2button
            // 
            this.muzika2button.BackColor = System.Drawing.Color.Transparent;
            this.muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_on_dugme;
            this.muzika2button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muzika2button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muzika2button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muzika2button.ForeColor = System.Drawing.Color.Teal;
            this.muzika2button.Location = new System.Drawing.Point(160, 231);
            this.muzika2button.Name = "muzika2button";
            this.muzika2button.Size = new System.Drawing.Size(60, 60);
            this.muzika2button.TabIndex = 3;
            this.muzika2button.UseVisualStyleBackColor = false;
            this.muzika2button.Click += new System.EventHandler(this.muzika2button_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(364, 333);
            this.Controls.Add(this.muzika2button);
            this.Controls.Add(this.muzika1Button);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.ugasiMuzikuButton);
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ugasiMuzikuButton;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button muzika1Button;
        private System.Windows.Forms.Button muzika2button;
    }
}