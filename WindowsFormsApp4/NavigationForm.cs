using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class NavigationForm : Form
    {
        public int currentUserId;

        public NavigationForm(int userId)
        {
            this.currentUserId = userId;
            InitializeComponent();
        }

        private void FavButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavoritesForm f = new FavoritesForm(currentUserId);
            f.Show();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterShows f = new FilterShows(currentUserId);
            f.Show();
        }

        private void CrystalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(this.currentUserId);
            f.Show();
        }
    }
}
