using Newtonsoft.Json;

public class SaveRecipe
{

  public void SaveFile(List<List<string>> ListRecipes, List<List<List<string>>> ListIngredients, string fileName)
  {
    string _newFileName = $"recipes/{fileName}";

    var data = new
    {
      ListRecipes,
      ListIngredients
    };

    string json = JsonConvert.SerializeObject(data);

    using (StreamWriter sw = new StreamWriter(_newFileName))
    {
      sw.Write(json);
    }
  }
}