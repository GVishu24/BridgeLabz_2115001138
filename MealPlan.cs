using System;
using System.Collections.Generic;

// Meal Plan Interface
public interface IMealPlan
{
    string GetMealType();
}

// Specific Meal Plans
public class VegetarianMeal : IMealPlan
{
    public string GetMealType() => "Vegetarian Meal Plan";
}

public class VeganMeal : IMealPlan
{
    public string GetMealType() => "Vegan Meal Plan";
}

public class KetoMeal : IMealPlan
{
    public string GetMealType() => "Keto Meal Plan";
}

public class HighProteinMeal : IMealPlan
{
    public string GetMealType() => "High-Protein Meal Plan";
}

// Generic Meal Class
public class Meal<T> where T : IMealPlan
{
    public string MealName { get; set; }
    public T MealCategory { get; set; }

    public Meal(string mealName, T mealCategory)
    {
        MealName = mealName;
        MealCategory = mealCategory;
    }

    public void DisplayMealInfo()
    {
        Console.WriteLine($"Meal: {MealName}, Type: {MealCategory.GetMealType()}");
    }
}

// Meal Plan Generator
public class MealPlanGenerator
{
    private List<object> _meals = new List<object>();

    public void AddMeal<T>(Meal<T> meal) where T : IMealPlan
    {
        _meals.Add(meal);
    }

    public void DisplayAllMeals()
    {
        foreach (var meal in _meals)
        {
            Console.WriteLine(meal);
        }
    }
}

// Testing the Implementation
public class Program
{
    public static void Main()
    {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>("Grilled Veggie Bowl", new VegetarianMeal());
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>("Vegan Smoothie", new VeganMeal());

        vegMeal.DisplayMealInfo();
        veganMeal.DisplayMealInfo();

        MealPlanGenerator mpg = new MealPlanGenerator();
        mpg.AddMeal(vegMeal);
        mpg.AddMeal(veganMeal);
    }
}
