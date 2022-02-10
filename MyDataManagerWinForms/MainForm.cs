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
                CusineComboBox1.DataSource = Cuisines;
                //Items = db.Items.ToList();
                //cboCategories.DataSource = Categories;
            }
            //preload test data
            //List<string> prices = new List<string>() { "$", "$$", "$$$" };
            pricePointComboBox.DataSource = Enum.GetValues(typeof(Price));

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

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void highPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CusineComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pricePointComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConvenienceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}