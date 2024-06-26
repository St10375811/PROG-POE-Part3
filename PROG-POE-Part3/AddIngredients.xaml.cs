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

namespace PROG_POE_Part3
{
    public partial class AddIngredients : Window
    {
        private Recipe recipe;
        ManageRecepie manageRecipe;

        List<UnitOfMeasurement> units = new List<UnitOfMeasurement>();
        List<FoodGroup> groups = new List<FoodGroup>();

        private int numIngredients;
        private int currentIngredientIndex = 0;

        public AddIngredients(Recipe recipe, int numIngredients, ManageRecepie manageRecipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            this.numIngredients = numIngredients;
            UpdateIngredientLabel();
            PopulateComboBoxes();
            this.manageRecipe = manageRecipe;
        }

        private void PopulateComboBoxes()
        {
            units.Add(UnitOfMeasurement.SMALL);
            units.Add(UnitOfMeasurement.MEDIUM);
            units.Add(UnitOfMeasurement.LARGE);
            units.Add(UnitOfMeasurement.EXTRALARGE);
            units.Add(UnitOfMeasurement.TEASPOON);
            units.Add(UnitOfMeasurement.TEASPOONS);
            units.Add(UnitOfMeasurement.TABLESPOON);
            units.Add(UnitOfMeasurement.TABLESPOONS);
            units.Add(UnitOfMeasurement.CUP);
            units.Add(UnitOfMeasurement.CUPS);

            for (int i = 0; i < units.Count(); i++)
            {
                unitComboBox.Items.Add(units[i]);
            }

            groups.Add(FoodGroup.CARBOHYDRATE);
            groups.Add(FoodGroup.PROTEIN);
            groups.Add(FoodGroup.FAT);
            groups.Add(FoodGroup.FRUIT);
            groups.Add(FoodGroup.VEGETABLE);
            groups.Add(FoodGroup.DAIRY);

            for (int i = 0; i < groups.Count(); i++)
            {
                foodGroupComboBox.Items.Add(groups[i]);
            }
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Ingredient name cannot be empty.");
                return;
            }

            if (!double.TryParse(Quantitytxt.Text, out double quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (!double.TryParse(NumCaloriestxt.Text, out double calories) || calories < 0)
            {
                MessageBox.Show("Please enter a valid number of calories.");
                return;
            }

            if (!Enum.TryParse<UnitOfMeasurement>(unitComboBox.SelectedItem?.ToString(), out UnitOfMeasurement unit))
            {
                MessageBox.Show("Please select a unit of measurement.");
                return;
            }

            if (!Enum.TryParse<FoodGroup>(foodGroupComboBox.SelectedItem?.ToString(), out FoodGroup group))
            {
                MessageBox.Show("Please select a food group.");
                return;
            }

            recipe.Ingredients.Add(new Ingredient(name, quantity, unit, group, calories));

            currentIngredientIndex++;

            if (currentIngredientIndex < numIngredients)
            {
                var successWindow = new SuccessWindow("Ingredient added successfully!");
                successWindow.Show();
                ResetFields();
                UpdateIngredientLabel();
            }
            else
            {
                var successWindow = new SuccessWindow("All ingredients added successfully!");
                successWindow.Show();
                this.Close();
                var addStepsWindow = new AddSteps(recipe, recipe.NumSteps, manageRecipe);
                addStepsWindow.Show();
            }

            recipe.CalculateTotalCalories();
        }

        private void ResetFields()
        {
            IngredientNameTextBox.Clear();
            Quantitytxt.Clear();
            NumCaloriestxt.Clear();
            unitComboBox.SelectedIndex = -1;
            foodGroupComboBox.SelectedIndex = -1;
        }

        private void UpdateIngredientLabel()
        {
            AddIngredientLabel.Content = $"Add Ingredient {currentIngredientIndex + 1} of {numIngredients}";
        }
    }
}
