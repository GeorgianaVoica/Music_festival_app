
namespace Proiect
{
    partial class Form1
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
            this.StageDataGridView = new System.Windows.Forms.DataGridView();
            this.AddStageButton = new System.Windows.Forms.Button();
            this.TicketButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StageDataGridView
            // 
            this.StageDataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.StageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StageDataGridView.Location = new System.Drawing.Point(0, 199);
            this.StageDataGridView.Name = "StageDataGridView";
            this.StageDataGridView.RowHeadersWidth = 51;
            this.StageDataGridView.Size = new System.Drawing.Size(714, 198);
            this.StageDataGridView.TabIndex = 0;
            this.StageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StageDataGridView_CellClick);
            // 
            // AddStageButton
            // 
            this.AddStageButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.AddStageButton.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStageButton.Location = new System.Drawing.Point(47, 115);
            this.AddStageButton.Name = "AddStageButton";
            this.AddStageButton.Size = new System.Drawing.Size(122, 42);
            this.AddStageButton.TabIndex = 1;
            this.AddStageButton.Text = "Add New Stage";
            this.AddStageButton.UseVisualStyleBackColor = false;
            this.AddStageButton.Click += new System.EventHandler(this.AddStageButton_Click);
            // 
            // TicketButton
            // 
            this.TicketButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.TicketButton.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketButton.Location = new System.Drawing.Point(508, 115);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(125, 42);
            this.TicketButton.TabIndex = 2;
            this.TicketButton.Text = "Buy Ticket";
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleTextBox.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(193, 12);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(337, 46);
            this.TitleTextBox.TabIndex = 3;
            this.TitleTextBox.Text = "  SOUND FESTIVAL";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(628, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(628, 57);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 5;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(715, 396);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TicketButton);
            this.Controls.Add(this.AddStageButton);
            this.Controls.Add(this.StageDataGridView);
            this.Name = "Form1";
            this.Text = "Festival";
            ((System.ComponentModel.ISupportInitialize)(this.StageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StageDataGridView;
        private System.Windows.Forms.Button AddStageButton;
        private System.Windows.Forms.Button TicketButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
    }
}

