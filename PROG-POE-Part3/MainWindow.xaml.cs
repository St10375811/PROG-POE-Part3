using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG_POE_Part3
{
    public partial class MainWindow : Window
    {
        private ManageRecepie manageRecipes;

        public MainWindow()
        {
            InitializeComponent();
            this.manageRecipes = new ManageRecepie();
        }

        public MainWindow(ManageRecepie manageRecipes)
        {
            InitializeComponent();
            this.manageRecipes = manageRecipes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipeWindow = new AddRecipe(manageRecipes);
            addRecipeWindow.Show();
            this.Close();
        }
    }
}
