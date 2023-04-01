public class Menu
{
  private string _userEntry = "0";

  CreateRecipe createRecipe;
  Ingredients ingredients = new Ingredients();
  SaveRecipe saveRecipe = new SaveRecipe();

  ListRecipesFormatted listRecipesFormatted = new ListRecipesFormatted();

  LoadRecipe loadRecipe = new LoadRecipe();
  List<string> recipeCreated = new List<string>();

  List<List<string>> ListRecipes = new List<List<string>>();
  List<List<List<string>>> ListIngredients = new List<List<List<string>>>();



  private string _menuOptions = "\n1 - Create a New Recipe\n2 - List Recipes\n3 - Save Recipe to File\n4 - Load Recipe from File\n5 - Quit\n\nEnter the Option: ";

  public void RunProgram()
  {
    Console.WriteLine("Welcome to the Recipe Manager\n");

    while (_userEntry != "5")
    {
      Console.WriteLine(_menuOptions);

      _userEntry = Console.ReadLine();

      if (_userEntry == "1")
      {
        // Create Recipes

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Category: ");
        string category = Console.ReadLine();

        List<List<string>> ingredientsList = ingredients.CreateListOfIngredients();
        ListIngredients.Add(ingredientsList);

        Console.Write("Preparation Time: ");
        string prepTime = Console.ReadLine();

        Console.Write("Directions: ");
        string directions = Console.ReadLine();

        createRecipe = new CreateRecipe(name, description, category, prepTime, directions);

        recipeCreated = createRecipe.CreateRecipeList(ingredientsList);

        ListRecipes.Add(recipeCreated);

        Console.Write("\nItem Added Successfully\n");
      }
      else if (_userEntry == "2")
      {
        // List Recipes

        Console.Clear();

        if (ListRecipes.Count == 0)
        {
          Console.WriteLine("\nNo recipes found.\n");
        }
        else
        {
          for (int i = 0; i < ListRecipes.Count; i++)
          {
            Console.WriteLine(listRecipesFormatted.GetRecipeFormatted(ListRecipes[i], ListIngredients[i]));

            Console.WriteLine("-------------------------------------");

          }
        }
      }
      // else if (_userEntry == "3")
      // {
      //   // Edit Recipe

      // }
      else if (_userEntry == "3")
      {
        // Save Recipe


        Console.Write("Enter the name for the file: ");

        string fileName = Console.ReadLine();
        saveRecipe.SaveFile(ListRecipes, ListIngredients, fileName);
      }
      else if (_userEntry == "4")
      {
        // Load Recipe

        Console.Write("Enter the name for the file: ");

        string fileName = Console.ReadLine();

        if (File.Exists($"recipes/{fileName}"))
        {
          loadRecipe.LoadFile($"recipes/{fileName}");

          ListRecipes = loadRecipe.GetRecipes();
          ListIngredients = loadRecipe.GetIngredients();
        }
        else
        {
          Console.WriteLine("File not found.");
        }
      }


    }

  }
}