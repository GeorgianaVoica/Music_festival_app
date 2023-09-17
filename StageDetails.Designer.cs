
namespace Proiect
{
    partial class StageDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageDetails));
            this.stageNameTextbox = new System.Windows.Forms.TextBox();
            this.AddArtistButton = new System.Windows.Forms.Button();
            this.artistsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stageNameTextbox
            // 
            this.stageNameTextbox.Location = new System.Drawing.Point(49, 42);
            this.stageNameTextbox.Name = "stageNameTextbox";
            this.stageNameTextbox.Size = new System.Drawing.Size(172, 22);
            this.stageNameTextbox.TabIndex = 0;
            // 
            // AddArtistButton
            // 
            this.AddArtistButton.Location = new System.Drawing.Point(49, 89);
            this.AddArtistButton.Name = "AddArtistButton";
            this.AddArtistButton.Size = new System.Drawing.Size(75, 23);
            this.AddArtistButton.TabIndex = 1;
            this.AddArtistButton.Text = "Add New Artist";
            this.AddArtistButton.UseVisualStyleBackColor = true;
            this.AddArtistButton.Click += new System.EventHandler(this.AddArtistButton_Click);
            // 
            // artistsDataGridView
            // 
            this.artistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistsDataGridView.Location = new System.Drawing.Point(2, 141);
            this.artistsDataGridView.Name = "artistsDataGridView";
            this.artistsDataGridView.RowHeadersWidth = 51;
            this.artistsDataGridView.RowTemplate.Height = 24;
            this.artistsDataGridView.Size = new System.Drawing.Size(609, 212);
            this.artistsDataGridView.TabIndex = 2;
            this.artistsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artistsDataGridView_CellClick);
            // 
            // StageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 353);
            this.Controls.Add(this.artistsDataGridView);
            this.Controls.Add(this.AddArtistButton);
            this.Controls.Add(this.stageNameTextbox);
            this.Name = "StageDetails";
            this.Text = "Line-up";
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stageNameTextbox;
        private System.Windows.Forms.Button AddArtistButton;
        private System.Windows.Forms.DataGridView artistsDataGridView;
    }
}