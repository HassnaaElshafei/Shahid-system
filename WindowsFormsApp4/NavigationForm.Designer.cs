
namespace WindowsFormsApp4
{
    partial class NavigationForm
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
            this.FavButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.CrystalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FavButton
            // 
            this.FavButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavButton.Location = new System.Drawing.Point(71, 134);
            this.FavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(138, 86);
            this.FavButton.TabIndex = 0;
            this.FavButton.Text = "Favorites Page";
            this.FavButton.UseVisualStyleBackColor = false;
            this.FavButton.Click += new System.EventHandler(this.FavButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(413, 134);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(152, 86);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Filter Movies Page";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // CrystalButton
            // 
            this.CrystalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CrystalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalButton.Location = new System.Drawing.Point(241, 134);
            this.CrystalButton.Name = "CrystalButton";
            this.CrystalButton.Size = new System.Drawing.Size(142, 86);
            this.CrystalButton.TabIndex = 2;
            this.CrystalButton.Text = "Show Crystal Report";
            this.CrystalButton.UseVisualStyleBackColor = false;
            this.CrystalButton.Click += new System.EventHandler(this.CrystalButton_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.CrystalButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FavButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button CrystalButton;
    }
}