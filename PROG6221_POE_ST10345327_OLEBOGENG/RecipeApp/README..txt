# RecipeApp README File #
## Introduction
This is a console-based recipe application written in C# as part of the PROG6221 assessment. The application allows users to add, display, and manage recipes, including ingredients and steps. It also calculates the total calories of each recipe and notifies the user if the total calories exceed 300.

## Installation and Setup
#Prerequisites
* Visual Studio
# Steps
1. Clone the Repository
git clone https://github.com/st10345327/recipe-app 
cd recipe-app

2. Open in Visual Studio

Open the RecipeApp.sln solution file in Visual Studio.
3. Build the Solution

Go to the Build menu and select "Build Solution" or press Ctrl+Shift+B.
4. Run the Application

Press F5 or click the "Start" button to run the program.
## How to Use ##
Adding a Recipe
a. Run the application.
b. Select option 1 to add a new recipe.
c. Follow the prompts to enter the recipe name, ingredients, and steps.
## Displaying Recipes
d. Run the application.
e. Select option 2 to display all recipes.
f. Recipes are displayed in alphabetical order along with their ingredients, steps, and total calories.
Exiting the Application
g. Run the application.
h. Select option 3 to exit.
## Features
* Add a Recipe: Enter details for a new recipe, including name, ingredients, and steps.
* Display Recipes: View a list of all recipes, sorted alphabetically by name.
* Calculate Total Calories: The application calculates the total calories of each recipe.
* Notify Exceeding Calories: Alerts the user if the total calories of a recipe exceed 300.

## File Structure
* Program.cs: Main entry point and handles user interaction.
* Recipe.cs: Defines the Recipe class.
* Ingredient.cs: Defines the Ingredient class.
* RecipeAppTests.cs: Contains unit tests.

## Unit Tests
Unit tests for the application's functionality can be found in the RecipeAppTests project. These tests cover the calculation of total calories and other critical functions of the application.

## Lecturer Feedback ##
Based on feedback from the lecturer, the following updates were made:

* Added support for multiple recipes.
* Enabled entering additional details for each ingredient, such as calories and food group.
* Calculated and displayed total calories for recipes.
* Notified users when calories exceed 300.
* Used generic collections for data management.
* Implemented unit tests for calorie calculation.

GitHub Repository
Link to the GitHub repository: RecipeApp GitHub Repositor: git clone https://github.com/st10345327/recipe-app
cd recipe-app

 ## Developer Information ##
Name: Olebogeng Phawe
Student Number: ST10345327
Email: [ST10345327@RCCONNECT.EDU.ZA]
