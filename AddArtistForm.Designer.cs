
namespace Proiect
{
    partial class AddArtistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtistForm));
            this.Namelabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.HourTextbox = new System.Windows.Forms.TextBox();
            this.SaveArtistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(46, 43);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(49, 98);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(39, 17);
            this.HourLabel.TabIndex = 1;
            this.HourLabel.Text = "Hour";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(202, 43);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(187, 22);
            this.NameTextbox.TabIndex = 2;
            // 
            // HourTextbox
            // 
            this.HourTextbox.Location = new System.Drawing.Point(202, 107);
            this.HourTextbox.Name = "HourTextbox";
            this.HourTextbox.Size = new System.Drawing.Size(187, 22);
            this.HourTextbox.TabIndex = 3;
            // 
            // SaveArtistButton
            // 
            this.SaveArtistButton.Location = new System.Drawing.Point(314, 178);
            this.SaveArtistButton.Name = "SaveArtistButton";
            this.SaveArtistButton.Size = new System.Drawing.Size(75, 23);
            this.SaveArtistButton.TabIndex = 4;
            this.SaveArtistButton.Text = "Save ";
            this.SaveArtistButton.UseVisualStyleBackColor = true;
            this.SaveArtistButton.Click += new System.EventHandler(this.SaveArtistButton_Click);
            // 
            // AddArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.SaveArtistButton);
            this.Controls.Add(this.HourTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "AddArtistForm";
            this.Text = "AddArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox HourTextbox;
        private System.Windows.Forms.Button SaveArtistButton;
    }
}