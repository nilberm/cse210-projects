public class RecipeBase
{
  protected string _name;
  protected string _description;
  protected string _category;
  protected string _prepTime;
  protected string _directions;

  public RecipeBase(string name, string description, string category, string prepTime, string directions)
  {
    _name = name;
    _description = description;
    _category = category;
    _prepTime = prepTime;
    _directions = directions;
  }

}