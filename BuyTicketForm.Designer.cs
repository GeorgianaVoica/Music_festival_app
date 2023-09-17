
namespace Proiect
{
    partial class BuyTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicketForm));
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(-2, 97);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowHeadersWidth = 51;
            this.TicketDataGridView.RowTemplate.Height = 24;
            this.TicketDataGridView.Size = new System.Drawing.Size(385, 154);
            this.TicketDataGridView.TabIndex = 0;
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(233, 59);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(123, 23);
            this.addTicketButton.TabIndex = 1;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 64);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(76, 17);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total Price";
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 253);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.TicketDataGridView);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketDataGridView;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Label TotalLabel;
    }
}