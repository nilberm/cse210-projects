using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class LoadRecipe
{


  private List<List<string>> ListRecipes;
  private List<List<List<string>>> ListIngredients;

  public void LoadFile(string fileName)
  {
    try
    {
      string json = File.ReadAllText(fileName);
      JObject jsonObject = JObject.Parse(json);

      if (jsonObject.ContainsKey("ListRecipes") && jsonObject.ContainsKey("ListIngredients"))
      {
        JToken recipesToken = jsonObject["ListRecipes"];
        JToken ingredientsToken = jsonObject["ListIngredients"];

        if (recipesToken is JArray && ingredientsToken is JArray)
        {
          ListRecipes = JsonConvert.DeserializeObject<List<List<string>>>(recipesToken.ToString());
          ListIngredients = JsonConvert.DeserializeObject<List<List<List<string>>>>(ingredientsToken.ToString());
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("Error loading file: " + ex.Message);
    }
  }



  public List<List<string>> GetRecipes()
  {
    return ListRecipes;
  }

  public List<List<List<string>>> GetIngredients()
  {
    return ListIngredients;
  }
}