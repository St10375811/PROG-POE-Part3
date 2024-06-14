POE  Recipe Application.

Full Name: Leeto Isaiah Sebake
Student Number: ST10375811
Written in: C#
Application type: GUI Application

-----------------------------------------------------------
https://github.com/St10375811/PROG-POE-Part3.git

Prerequisites
Visual Studio 2022 or later
.NET Framework [version used, e.g., 4.7.2 or .NET Core 3.1]


Setup Instructions:


Navigate to the project directory.
Double-click on the solution file (PROG-POE-Part3.sln) to open it in Visual Studio.
Restore NuGet packages:

Right-click on the solution in Solution Explorer.
Select Restore NuGet Packages.

Build the solution:

Press Ctrl+Shift+B or navigate to Build > Build Solution.
Set the startup project:

Right-click on the desired project (Mainwindows.xaml).
Select Set as StartUp Project.
Run the application:

Press F5 or click on the Start button in the toolbar to run the application.
Usage

Features
[List key features or functionalities of your application.]
- Ingredient: Represents an ingredient in a recipe, with properties for its name, quantity, original quantity,unit of measurement, calories and foodGroup
- Step: Represents a step in a recipe, containing a description of the step.
- Recipe: Represents a recipe, containing a name, list of ingredients, and list of steps. It provides methods for adding ingredients and steps, displaying the recipe, scaling the recipe quantities, and resetting    the recipe to its original quantities also shows  calories excessed 300 the if it does it will display a warning and foodGroup
- Program: Contains the main method and handles user interaction through a menu-driven interface. It allows users to create, display, scale, reset , calories, and clear recipes.

- Instructions on how to run the program:

Step 1:		Double click on the file "Mainwindows.XAMP." or run the program
		      from Visual Studio.

Step 2:		You will see the name Welcome to your Application and they is a Meun.
	

Step 3:		The menu will be displayed with each menu item being labelled
		      with Numbers. Enter the number only to execut the menu item.

Step 4: 	You can add, scale, view and clear a recipe.

Step 5:		Adding a recipe

Step 6:		Enter the number of ingredients and steps. For each
		      ingredient, provide the name, quantity and unit of measurement.
		      For each step, provide the description (help text).

Step 6.1:	Your recipe will be created successfully.

Step 7:		The Meun will reappear

Step 8:		Select the scale Recipe factor to scale the recipe's ingredients.
	

Step 7:		You can select your Reset recipe to reset the  Quantity of  the Original Quantity .

Step 8:		You can select your Clear recipe data then all the data well be deleted.

Step 9:		At the End they is a Exit bar at the meun if you press 6 this message will Display "
		

Structure
/Assets: Contains graphical assets used in the application.
/ViewModels: Contains view models if using MVVM architecture.
/Views: Contains XAML files for UI design.
/Models: Contains C# classes defining data structures.
/Services: Contains any additional services or utilities used in the application.
App.xaml, MainWindow.xaml: Entry points and main window of the application.
