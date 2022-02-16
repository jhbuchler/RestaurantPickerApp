using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataManagerWinForms
{
    public partial class AddUpdateForm : Form
    {
        private static IConfigurationRoot _configuration;
        private static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;
        private IList<Cuisine> Cuisines = new List<Cuisine>();
        private IList<Convenience> convenience = new List<Convenience>();

        public AddUpdateForm()
        {
            InitializeComponent();
        }

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {


            BuildOptions();

            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                Cuisines = db.Cuisines.OrderBy(x => x.Type).ToList();
                CuisineComboBox.DataSource = Cuisines;
            }

            pricePointComboBox.DataSource = Enum.GetValues(typeof(Price));

            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                convenience = db.Conveniences.OrderBy(x => x.Type).ToList();
                ConvenienceComboBox.DataSource = convenience;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                MessageBox.Show("Please enter the name of the restaurant.");
            }
            else
            {
                //actually add something
                var _restaurant = new Restaurant();
                _restaurant.Price = (int)this.pricePointComboBox.SelectedItem;
                //var x = this.ConvenienceComboBox.SelectedItem;
                //_restaurant.ConvenienceId = this.ConvenienceComboBox.SelectedIndex;
                //this.ConvenienceComboBox.Text = _restaurant.Convenience.ToString();
                switch (this.ConvenienceComboBox.Text)
                {
                    case "Sit Down":
                        _restaurant.ConvenienceId = 1;
                        break;
                    case "Take Out":
                        _restaurant.ConvenienceId = 2;
                        break;
                    case "Fast Food":
                        _restaurant.ConvenienceId = 3;
                        break;
                }
                //this.CuisineComboBox.Text = _restaurant.CuisineId;
                switch (this.CuisineComboBox.Text)
                {
                    case "Italian":
                        _restaurant.CuisineId = 1;
                        break;
                    case "American":
                        _restaurant.CuisineId = 2;
                        break;
                    case "Mexican":
                        _restaurant.CuisineId = 3;
                        break;
                    case "Korean":
                        _restaurant.CuisineId = 4;
                        break;
                    case "Chinese":
                        _restaurant.CuisineId = 5;
                        break;
                }
                _restaurant.Name = txtBoxName.Text;

                using (var db = new DataDbContext(_optionsBuilder.Options))
                {
                    db.Add(_restaurant);
                    db.SaveChanges();
                }
            }
        }
    }
}
