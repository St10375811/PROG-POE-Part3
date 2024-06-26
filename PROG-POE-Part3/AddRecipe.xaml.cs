﻿using System;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PROG_POE_Part3
{
    public partial class AddRecipe : Window
    {
        private ManageRecepie manageRecipes;

        public AddRecipe(ManageRecepie manageRecipes)
        {
            InitializeComponent();
            this.manageRecipes = manageRecipes;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            if (string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Recipe name cannot be empty.");
                return;
            }

            if (!int.TryParse(NumIngredientstxt.Text, out int numIngredients) || numIngredients <= 0)
            {
                MessageBox.Show("Please enter a valid number of ingredients.");
                return;
            }

            if (!int.TryParse(NumStepstxt.Text, out int numSteps) || numSteps <= 0)
            {
                MessageBox.Show("Please enter a valid number of steps.");
                return;
            }

            Recipe recipe = new Recipe(recipeName, numIngredients, numSteps);
            var addIngredientsWindow = new AddIngredients(recipe, numIngredients, manageRecipes);
            addIngredientsWindow.Show();
            this.Close();

            manageRecipes.AddRecipe(recipe);

            RecipeNameTextBox.Clear();
            NumIngredientstxt.Clear();
            NumStepstxt.Clear();
        }
    }
}
