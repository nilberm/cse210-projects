public class SaveRecipeTxt : SaveRecipe
{
  private ListRecipesFormatted listRecipesFormatted = new ListRecipesFormatted();

  public override void SaveFile(List<List<string>> _listRecipes, List<List<List<string>>> _listIngredients, string fileName)
  {
    string _newFileName = $"recipes/{fileName}.txt";

    using (StreamWriter sw = new StreamWriter(_newFileName))
    {
      for (int i = 0; i < _listRecipes.Count; i++)
      {
        sw.Write(listRecipesFormatted.GetRecipeFormatted(_listRecipes[i], _listIngredients[i]));
        sw.Write("\n-------------------------------------\n");
      }
    }
  }
}
