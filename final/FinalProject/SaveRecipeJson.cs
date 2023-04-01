using Newtonsoft.Json;
public class SaveRecipeJson : SaveRecipe
{
  public override void SaveFile(List<List<string>> _listRecipes, List<List<List<string>>> _listIngredients, string fileName)
  {
    string _newFileName = $"json/{fileName}.json";

    var data = new
    {
      _listRecipes,
      _listIngredients
    };

    string json = JsonConvert.SerializeObject(data);

    using (StreamWriter sw = new StreamWriter(_newFileName))
    {
      sw.Write(json);
    }
  }
}
