public class RecipeBase
{
  private string _name;
  private string _description;
  private string _category;
  private string _prepTime;
  private string _directions;

  public RecipeBase(string name, string description, string category, string prepTime, string directions)
  {
    _name = name;
    _description = description;
    _category = category;
    _prepTime = prepTime;
    _directions = directions;
  }

}