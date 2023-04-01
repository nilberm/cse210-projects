public class Ingredients
{
  private List<List<string>> _ingredients;
  private List<string> _tempIngredientsByCategory;
  private string _tempNameCategory;
  private string _numberOfCategories;

  public List<List<string>> CreateListOfIngredients()
  {
    _ingredients = new List<List<string>>();

    Console.Write("How many ingredient categories are there? ");
    _numberOfCategories = Console.ReadLine();

    int numberOfCategories;
    while (!int.TryParse(_numberOfCategories, out numberOfCategories) || numberOfCategories < 1)
    {
      Console.Write("Please enter a valid number greater than zero: ");
      _numberOfCategories = Console.ReadLine();
    }

    for (int i = 0; i < numberOfCategories; i++)
    {
      Console.Write($"Enter the name of ingredient category {i + 1}: ");
      _tempNameCategory = Console.ReadLine();

      _tempIngredientsByCategory = new List<string>();
      _tempIngredientsByCategory.Add(_tempNameCategory);

      Console.Write($"Enter the ingredients for {_tempNameCategory} separated by commas: ");
      string ingredientsInput = Console.ReadLine();

      string[] ingredients = ingredientsInput.Split(',');

      foreach (string ingredient in ingredients)
      {
        string trimmedIngredient = ingredient.Trim();
        if (!string.IsNullOrEmpty(trimmedIngredient))
        {
          _tempIngredientsByCategory.Add(trimmedIngredient);
        }
      }

      _ingredients.Add(_tempIngredientsByCategory);
    }

    return _ingredients;
  }
}