using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp4
{
    public partial class FavoritesForm : Form
    {
        string ordb = "Data Source =ORCL; User Id=hr;Password=hr;";
        int currentUserId;
        Dictionary<int, string> allMovies;
        List<int> userFavMoviesIds;
        public FavoritesForm(int userId)
        {
            this.currentUserId = userId;
            InitializeComponent();
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select movieid from userfavshow where USERFAVSHOW.USERID= :currentUserId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("currentUserId",this.currentUserId);

            OracleDataReader dr = cmd.ExecuteReader();
            userFavMoviesIds =new List<int>();
            while (dr.Read())
            {
                userFavMoviesIds.Add(int.Parse(dr[0].ToString()));
            }
            dr.Close();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GetAllShows";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("allMovies", OracleDbType.RefCursor, ParameterDirection.Output);
            //cmd.Parameters.Add("returnedId", OracleDbType.Int32).Direction = ParameterDirection.Output;
            OracleDataReader dr2=cmd2.ExecuteReader();
            allMovies = new Dictionary<int, string>();
            while (dr2.Read())
            {
                allMovies.Add(int.Parse(dr2["MOVIEID"].ToString()), dr2["MOVIETITLE"].ToString());
            }
            // Setup listview appearance
            //FavListView.Columns.Clear();
            //FavListView.Columns.Add("");
            FavListView.View = View.Tile;
            FavListView.HeaderStyle = ColumnHeaderStyle.None;

            // Adapt widht of column
            FavListView.Columns[0].Width = -1;

            foreach (int Id in userFavMoviesIds)
            {
                FavListView.Items.Add(allMovies[Id]);
                InFavCombobox.Items.Add(allMovies[Id]);
            }

            foreach(KeyValuePair<int,string> movie in allMovies)
            {
                if (!userFavMoviesIds.Contains(movie.Key))
                {
                    addToFavCombobox.Items.Add(movie.Value);
                }
            }


        }

        private void AddToFavButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into UserfavShow (userId,MovieId) values (:UserID,:MovieId)";
            cmd.Parameters.Add("UserID", currentUserId);
            string movieName=addToFavCombobox.SelectedItem.ToString();
            int movieId = -1;
            foreach(KeyValuePair<int,string> movie in allMovies)
            {
                if(movie.Value == movieName)
                {
                    movieId = movie.Key;
                    break;
                }
            }
            cmd.Parameters.Add("MovieId",movieId);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                userFavMoviesIds.Add(movieId);
                FavListView.Items.Add(allMovies[movieId]);
                addToFavCombobox.Items.Remove(allMovies[movieId]);
                InFavCombobox.Items.Add(allMovies[movieId]);
                MessageBox.Show("Movie Added To Your Favorites List");
            }
            else
            {
                MessageBox.Show("Failed To Add The Movie!!!");
            }
        }

        private void RemoveFromFavButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from UserfavShow where UserId =:CurrentUserId and MovieId= :movieId";
            cmd.Parameters.Add("CurrentUserId", currentUserId);
            string movieName = InFavCombobox.SelectedItem.ToString();
            int movieId = -1;
            foreach (KeyValuePair<int, string> movie in allMovies)
            {
                if (movie.Value == movieName)
                {
                    movieId = movie.Key;
                    break;
                }
            }
            cmd.Parameters.Add("movieId", movieId);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {

                FavListView.Clear();
                userFavMoviesIds.Remove(movieId);
                foreach (int Id in userFavMoviesIds)
                {
                    FavListView.Items.Add(allMovies[Id]);
                }
                addToFavCombobox.Items.Add(allMovies[movieId]);
                InFavCombobox.Items.Remove(movieName);
                MessageBox.Show("Movie Removed Your Favorites List");
            }
            else
            {
                MessageBox.Show("Failed To Remove The Movie!!!");
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavigationForm f = new NavigationForm(currentUserId);
            f.Show();
        }
    }
}


// 1- in the registration form
// 2- registration form adding new user
// 3- login form user login
// 4- favorites form getting all movies.