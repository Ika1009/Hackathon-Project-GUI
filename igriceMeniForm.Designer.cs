
namespace Hackathon_Project_GUI
{
    partial class igriceMeniForm
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
            this.igrica1Button = new System.Windows.Forms.Button();
            this.igrica2Button = new System.Windows.Forms.Button();
            this.igrica3Button = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // igrica1Button
            // 
            this.igrica1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica1Button.Location = new System.Drawing.Point(77, 384);
            this.igrica1Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.igrica1Button.Name = "igrica1Button";
            this.igrica1Button.Size = new System.Drawing.Size(126, 57);
            this.igrica1Button.TabIndex = 0;
            this.igrica1Button.Text = "Povezivanje";
            this.igrica1Button.UseVisualStyleBackColor = true;
            this.igrica1Button.Click += new System.EventHandler(this.igrica1Button_Click);
            // 
            // igrica2Button
            // 
            this.igrica2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica2Button.Location = new System.Drawing.Point(85, 384);
            this.igrica2Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.igrica2Button.Name = "igrica2Button";
            this.igrica2Button.Size = new System.Drawing.Size(125, 57);
            this.igrica2Button.TabIndex = 1;
            this.igrica2Button.Text = "Lavirint";
            this.igrica2Button.UseVisualStyleBackColor = true;
            this.igrica2Button.Click += new System.EventHandler(this.igrica2Button_Click);
            // 
            // igrica3Button
            // 
            this.igrica3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica3Button.Location = new System.Drawing.Point(90, 381);
            this.igrica3Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.igrica3Button.Name = "igrica3Button";
            this.igrica3Button.Size = new System.Drawing.Size(118, 56);
            this.igrica3Button.TabIndex = 2;
            this.igrica3Button.Text = "Memorije";
            this.igrica3Button.UseVisualStyleBackColor = true;
            this.igrica3Button.Click += new System.EventHandler(this.igrica3Button_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
            this.nazadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nazadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadButton.Location = new System.Drawing.Point(11, 13);
            this.nazadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(47, 53);
            this.nazadButton.TabIndex = 3;
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.igrica1Button);
            this.panel1.Controls.Add(this.nazadButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 722);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.igrica2Button);
            this.panel2.Location = new System.Drawing.Point(306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 722);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.igrica3Button);
            this.panel3.Location = new System.Drawing.Point(611, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 722);
            this.panel3.TabIndex = 5;
            // 
            // igriceMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(898, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "igriceMeniForm";
            this.Text = "igriceMeniForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button igrica1Button;
        private System.Windows.Forms.Button igrica2Button;
        private System.Windows.Forms.Button igrica3Button;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}