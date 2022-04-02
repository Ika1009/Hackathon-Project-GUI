
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
            this.igrica1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.povezivanje;
            this.igrica1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.igrica1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igrica1Button.Location = new System.Drawing.Point(60, 253);
            this.igrica1Button.Name = "igrica1Button";
            this.igrica1Button.Size = new System.Drawing.Size(131, 112);
            this.igrica1Button.TabIndex = 0;
            this.igrica1Button.UseVisualStyleBackColor = true;
            this.igrica1Button.Click += new System.EventHandler(this.igrica1Button_Click);
            this.igrica1Button.MouseEnter += new System.EventHandler(this.over);
            this.igrica1Button.MouseLeave += new System.EventHandler(this.leave);
            // 
            // igrica2Button
            // 
            this.igrica2Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.lavirint;
            this.igrica2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.igrica2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igrica2Button.Location = new System.Drawing.Point(61, 253);
            this.igrica2Button.Name = "igrica2Button";
            this.igrica2Button.Size = new System.Drawing.Size(131, 112);
            this.igrica2Button.TabIndex = 1;
            this.igrica2Button.UseVisualStyleBackColor = true;
            this.igrica2Button.Click += new System.EventHandler(this.igrica2Button_Click);
            this.igrica2Button.MouseEnter += new System.EventHandler(this.over2);
            this.igrica2Button.MouseLeave += new System.EventHandler(this.leave2);
            // 
            // igrica3Button
            // 
            this.igrica3Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.debela_macka;
            this.igrica3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.igrica3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igrica3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igrica3Button.Location = new System.Drawing.Point(60, 253);
            this.igrica3Button.Name = "igrica3Button";
            this.igrica3Button.Size = new System.Drawing.Size(131, 112);
            this.igrica3Button.TabIndex = 2;
            this.igrica3Button.UseVisualStyleBackColor = true;
            this.igrica3Button.Click += new System.EventHandler(this.igrica3Button_Click);
            this.igrica3Button.MouseEnter += new System.EventHandler(this.over3);
            this.igrica3Button.MouseLeave += new System.EventHandler(this.leave3);
            // 
            // nazadButton
            // 
            this.nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
            this.nazadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nazadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Location = new System.Drawing.Point(10, 10);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(39, 34);
            this.nazadButton.TabIndex = 3;
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            this.nazadButton.MouseEnter += new System.EventHandler(this.overnaz);
            this.nazadButton.MouseLeave += new System.EventHandler(this.leavenaz);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.igrica1Button);
            this.panel1.Controls.Add(this.nazadButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 542);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.igrica2Button);
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 542);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.igrica3Button);
            this.panel3.Location = new System.Drawing.Point(535, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 542);
            this.panel3.TabIndex = 5;
            // 
            // igriceMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(786, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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