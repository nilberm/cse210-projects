public class ListRecipesFormatted
{
  public string GetRecipeFormatted(List<string> recipe, List<List<string>> ingredients)
  {
    string recipeHeader = $"{recipe[0]}\n\n{recipe[1]}\n\n{recipe[2]}\n\n";

    string ingredientList = "";

    foreach (List<string> ingredientCategory in ingredients)
    {
      ingredientList += $"{ingredientCategory[0]}:\n";

      foreach (string ingredient in ingredientCategory.Skip(1))
      {
        ingredientList += $"{ingredient}\n";
      }

      ingredientList += "\n";
    }

    string recipeFooter = $"{recipe[3]}\n\n{ingredientList}{recipe[4]}";

    string formattedRecipe = $"{recipeHeader}{recipeFooter}";

    return formattedRecipe;
  }
}