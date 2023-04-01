public abstract class SaveRecipe
{
  public abstract void SaveFile(List<List<string>> _listRecipes, List<List<List<string>>> _listIngredients, string fileName);

  public virtual void SaveFileFormatted(List<List<string>> _listRecipes, List<List<List<string>>> _listIngredients, string fileName, ListRecipesFormatted listRecipesFormatted)
  {
    throw new NotImplementedException();
  }
}