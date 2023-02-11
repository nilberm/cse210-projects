public class Scripture
{
  //Attributes
  List<int> _indexList;
  List<int> _indexListShuffled;
  int _totalLengthVerse;

  //Importation
  Word word = new Word();
  List<string> words;

  Random rng = new Random();

  public void InitializeWords()
  {
    words = word.GetVerseList();
  }

  //Constructor
  public Scripture()
  {
    InitializeWords();

    _totalLengthVerse = words.Count;
    _indexList = Enumerable.Range(0, (_totalLengthVerse)).ToList();
    _indexListShuffled = this.ShuffleIndexList(_indexList);
  }

  //Methods
  public List<int> GetIndexList()
  {
    return _indexList;
  }

  public int GetTotalLengthVerseList()
  {
    return _totalLengthVerse;
  }

  public List<int> GetIndexListShuffled()
  {
    return _indexListShuffled;
  }


  private List<int> ShuffleIndexList(List<int> indexList)
  {
    List<int> shuffledInt = new List<int>(indexList);

    Random rng = new Random();
    int n = shuffledInt.Count;

    while (n > 1)
    {
      n--;
      int k = rng.Next(n + 1);
      int value = shuffledInt[k];
      shuffledInt[k] = shuffledInt[n];
      shuffledInt[n] = value;
    }

    return shuffledInt;
  }

}