using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDataModels;
using System.Diagnostics;

namespace MyDataManagerWinForms
{
    public partial class MainForm : Form
    {
        private static IConfigurationRoot _configuration;
        private static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;
        Random rand = new Random();
        private static List<Restaurant> restaurants;
        private IList<Cuisine> Cuisines = new List<Cuisine>();
        //private IList<Price> pricePoint = new List<Price>();
        private IList<Convenience> convenience = new List<Convenience>();

        public MainForm()
        {
            InitializeComponent();
        }

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }
          
        private void MainForm_Load(object sender, EventArgs e)
        {
            BuildOptions();

            //load categories
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

            //dgv fixes
            dgItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboBox = sender as ComboBox;
            var selItem = cboBox.SelectedItem as Cuisine;

            LoadGrid(selItem);
        }

        private void LoadGrid(Cuisine selectedItem)
        {
            Debug.WriteLine($"Selected Item {selectedItem.Id}| {selectedItem.Type}");
            //var curData = Items.Where(x => x.CategoryId == selectedItem.Id).OrderBy(x => x.Name).ToList();
            //dgItems.DataSource = curData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //testing output
            //label1.Text = ((int)pricePointComboBox.SelectedValue).ToString() +
            //    " " + ConvenienceComboBox.SelectedValue.ToString() +
            //    " " + CuisineComboBox.SelectedValue.ToString();

            var priceValue = (int)pricePointComboBox.SelectedValue;
            var convValue = ConvenienceComboBox.SelectedValue;
            var cuisValue = CuisineComboBox.SelectedValue;

            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                    restaurants = db.Restaurants.Where(x => x.Price == priceValue)
                    .Where(x => x.Convenience == convValue)
                    .Where(x => x.Cuisine == cuisValue).OrderBy(x => x.Name).ToList();
                                    
                dgItems.DataSource = restaurants;
            }

            //msgbox telling the user there's nothing returned in the search
        }

        private void btnSurpriseMe_Click(object sender, EventArgs e)
        {
            //if list is full, return one at random. otherwise, return random restaurant from entire db
            if (restaurants?.Count > 0)
            {
                MessageBox.Show(restaurants[rand.Next(restaurants.Count)].ToString());
            }
            else
            {
                using (var db = new DataDbContext(_optionsBuilder.Options))
                {
                    restaurants = db.Restaurants.ToList();
                    var choice = rand.Next(restaurants.Count);

                    MessageBox.Show(restaurants[choice].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm addupdate = new AddUpdateForm();
            addupdate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                AddUpdateForm addupdate = new AddUpdateForm();
                addupdate.ShowDialog();
            }
            else
            {
                NothingSelected();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsSelected())
            {
                //ask user to confirm deletion
                var userSelection = MessageBox.Show($"Delete selected restaurant from the database?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //delete the selected restaurant from the database

            }
            else
            {
                NothingSelected();
            }
        }

        private bool IsSelected()
        {
            if (dgItems.SelectedRows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void NothingSelected()
        {
            MessageBox.Show("Nothing is selected.");
        }
    }
}