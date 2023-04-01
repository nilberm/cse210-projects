public class CreateRecipe : RecipeBase
{



  public CreateRecipe(string name, string description, string category, string prepTime, string directions)
  : base(name, description, category, prepTime, directions)
  {
  }

  public List<string> CreateRecipeList(List<List<string>> _ingredientList)
  {
    List<string> recipeList = new List<string> { _name, _description, _category, _prepTime, _directions };
    return recipeList;
  }




}