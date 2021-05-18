using System;
using System.Collections.Generic;

class MainClass {

  static List<RecipeItem> brownieRecipe = new List<RecipeItem>();
  static List<RecipeItem> cookieRecipe = new List<RecipeItem>();
  static List<RecipeItem> cakeRecipe = new List<RecipeItem>();

  public static String formatRecipeItem(RecipeItem item, bool displayAmount){
    if(displayAmount){
      return " ~ " + item.name + "... " + item.amount + " grames";
    }
    return " ~ " + item.name;
  }

  public static void displayRecipe(List<RecipeItem> recipe, bool displayAmount){
    foreach(RecipeItem item in recipe)
      {
        Console.WriteLine(formatRecipeItem(item, displayAmount));
      }
  }

  public static void SelectRecipe(bool displayAmount)
  {
    while(true) {
      Console.WriteLine("Welcome to the vertual cook book. Do you want to cook a [brownie], [cookie], or [cake]?");
      string reply = Console.ReadLine();
      if(reply.Equals("brownie"))
      {
        displayRecipe(brownieRecipe, displayAmount);
        return;
      } else if(reply.Equals("cookie"))
      {
        displayRecipe(cookieRecipe, displayAmount);
        return;
      } else if(reply.Equals("cake"))
      {
        displayRecipe(cakeRecipe, displayAmount);
        return;
      }else
      {
        Console.WriteLine("Please chose a recipe from the list.");
      }
    }
  }


  public static void Main (string[] args) {
    
    RecipeItem sugar = new RecipeItem("Sugar", 10);
    RecipeItem flour = new RecipeItem("Flour", 50);
    RecipeItem eggs = new RecipeItem("Eggs", 20);
    RecipeItem cocoaPowder = new RecipeItem("Cocoa Powder", 8.75);
    RecipeItem water = new RecipeItem("Water", 25);
    RecipeItem bakingSoda = new RecipeItem("Baking Soda", 8);
    RecipeItem chocolateChips = new RecipeItem("Chocolate Chips", 12.5);
    RecipeItem vanilla = new RecipeItem("Vanilla", 1.5);
    RecipeItem bakingPowder = new RecipeItem("Baking Powder", 8.25);
    RecipeItem milk = new RecipeItem("Milk", 16);

    brownieRecipe.Add(sugar);
    brownieRecipe.Add(flour);
    brownieRecipe.Add(eggs);
    brownieRecipe.Add(cocoaPowder);
    brownieRecipe.Add(water);

    cookieRecipe.Add(chocolateChips);
    cookieRecipe.Add(bakingSoda);
    cookieRecipe.Add(sugar);
    cookieRecipe.Add(flour);
    cookieRecipe.Add(water);

    cakeRecipe.Add(milk);
    cakeRecipe.Add(vanilla);
    cakeRecipe.Add(bakingPowder);
    cakeRecipe.Add(sugar);
    cakeRecipe.Add(flour);
    cakeRecipe.Add(eggs);

    SelectRecipe(true);
  }
}

class RecipeItem 
{
  public string name;
  public double amount;

  public RecipeItem(string name, double amount)
  {
    this.name = name;
    this.amount = amount;
    
  }

}