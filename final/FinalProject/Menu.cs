public class Menu
{
  private string _userEntry = "0";


  private string _menuOptions = "\n1 - Create a New Recipe\n2 - List Recipes\n3 - Edit Recipe\n4 - Save Recipe to File\n5 - Load Recipe from File\n6 - Quit\n\nEnter the Option: ";

  public void RunProgram()
  {
    Console.WriteLine("Welcome to the Recipe Manager\n");

    while (_userEntry != "6")
    {
      Console.WriteLine(_menuOptions);

      _userEntry = Console.ReadLine();

      if (_userEntry == "1")
      {
        // Create New Recipe
      }
      else if (_userEntry == "2")
      {
        // List Recipes
      }
      else if (_userEntry == "3")
      {
        // Edit Recipe
      }
      else if (_userEntry == "4")
      {
        // Save Recipe
      }
      else if (_userEntry == "5")
      {
        // Load Recipe
      }


    }

  }
}