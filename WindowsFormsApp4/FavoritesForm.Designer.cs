
namespace WindowsFormsApp4
{
    partial class FavoritesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FavListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToFavCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToFavButton = new System.Windows.Forms.Button();
            this.RemoveFromFavButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InFavCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(226, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorites";
            // 
            // FavListView
            // 
            this.FavListView.BackColor = System.Drawing.SystemColors.Menu;
            this.FavListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.FavListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FavListView.HideSelection = false;
            this.FavListView.Location = new System.Drawing.Point(11, 108);
            this.FavListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FavListView.Name = "FavListView";
            this.FavListView.Size = new System.Drawing.Size(264, 243);
            this.FavListView.TabIndex = 1;
            this.FavListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = -1;
            // 
            // addToFavCombobox
            // 
            this.addToFavCombobox.FormattingEnabled = true;
            this.addToFavCombobox.Location = new System.Drawing.Point(398, 108);
            this.addToFavCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToFavCombobox.Name = "addToFavCombobox";
            this.addToFavCombobox.Size = new System.Drawing.Size(260, 24);
            this.addToFavCombobox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(395, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add To Favorites:";
            // 
            // AddToFavButton
            // 
            this.AddToFavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToFavButton.Location = new System.Drawing.Point(485, 155);
            this.AddToFavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToFavButton.Name = "AddToFavButton";
            this.AddToFavButton.Size = new System.Drawing.Size(75, 38);
            this.AddToFavButton.TabIndex = 4;
            this.AddToFavButton.Text = "Add";
            this.AddToFavButton.UseVisualStyleBackColor = true;
            this.AddToFavButton.Click += new System.EventHandler(this.AddToFavButton_Click);
            // 
            // RemoveFromFavButton
            // 
            this.RemoveFromFavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromFavButton.Location = new System.Drawing.Point(473, 298);
            this.RemoveFromFavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveFromFavButton.Name = "RemoveFromFavButton";
            this.RemoveFromFavButton.Size = new System.Drawing.Size(102, 38);
            this.RemoveFromFavButton.TabIndex = 7;
            this.RemoveFromFavButton.Text = "Remove";
            this.RemoveFromFavButton.UseVisualStyleBackColor = true;
            this.RemoveFromFavButton.Click += new System.EventHandler(this.RemoveFromFavButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(395, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remove From Favorites:";
            // 
            // InFavCombobox
            // 
            this.InFavCombobox.FormattingEnabled = true;
            this.InFavCombobox.Location = new System.Drawing.Point(398, 261);
            this.InFavCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InFavCombobox.Name = "InFavCombobox";
            this.InFavCombobox.Size = new System.Drawing.Size(260, 24);
            this.InFavCombobox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Favorites List:";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(2, 7);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(92, 38);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(7, 13);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveFromFavButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InFavCombobox);
            this.Controls.Add(this.AddToFavButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addToFavCombobox);
            this.Controls.Add(this.FavListView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavoritesForm";
            this.Text = "FavoritesForm";
            this.Load += new System.EventHandler(this.FavoritesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView FavListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox addToFavCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToFavButton;
        private System.Windows.Forms.Button RemoveFromFavButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InFavCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button2;
    }
}