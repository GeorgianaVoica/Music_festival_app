
namespace Proiect
{
    partial class LineUpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineUpDetails));
            this.ArtistTextbox = new System.Windows.Forms.TextBox();
            this.PlaylistDataGridView = new System.Windows.Forms.DataGridView();
            this.addSongButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtistTextbox
            // 
            this.ArtistTextbox.Location = new System.Drawing.Point(12, 54);
            this.ArtistTextbox.Name = "ArtistTextbox";
            this.ArtistTextbox.Size = new System.Drawing.Size(219, 22);
            this.ArtistTextbox.TabIndex = 0;
            // 
            // PlaylistDataGridView
            // 
            this.PlaylistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaylistDataGridView.Location = new System.Drawing.Point(-1, 121);
            this.PlaylistDataGridView.Name = "PlaylistDataGridView";
            this.PlaylistDataGridView.RowHeadersWidth = 51;
            this.PlaylistDataGridView.RowTemplate.Height = 24;
            this.PlaylistDataGridView.Size = new System.Drawing.Size(471, 150);
            this.PlaylistDataGridView.TabIndex = 1;
            this.PlaylistDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaylistDataGridView_CellClick);
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(376, 13);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 23);
            this.addSongButton.TabIndex = 2;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // LineUpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 270);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.PlaylistDataGridView);
            this.Controls.Add(this.ArtistTextbox);
            this.Name = "LineUpDetails";
            this.Text = "LineUpDetails";
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArtistTextbox;
        private System.Windows.Forms.DataGridView PlaylistDataGridView;
        private System.Windows.Forms.Button addSongButton;
    }
}