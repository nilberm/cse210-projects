public class HandleStart
{
  string _userEntry;
  int _countLoops;

  Scripture scripture;
  List<int> shuffledIndex;
  Word verses;
  List<string> listVerses;
  int totalLength;

  Reference reference = new Reference();
  public HandleStart()
  {
    verses = new Word();
    listVerses = verses.GetVerseList();
    scripture = new Scripture();
    shuffledIndex = scripture.GetIndexListShuffled();
    totalLength = scripture.GetTotalLengthVerseList() - 1;
    _userEntry = "";
    _countLoops = 0;
  }

  public void RunApplication()
  {
    while (_userEntry != "quit" && _countLoops - 2 != totalLength)
    {
      Console.Clear();

      for (int i = 0; i < _countLoops; i++)
      {

        int indexTemp = shuffledIndex[i];

        string underlineTemp = string.Join("", Enumerable.Repeat("_", listVerses[indexTemp].Length));
        listVerses[indexTemp] = underlineTemp;

      }

      Console.WriteLine($"{reference.GetReference()} {String.Join(" ", listVerses)}\n");

      Console.WriteLine("Press enter to continue or type 'quit' to finish:");

      _userEntry = Console.ReadLine();
      _countLoops++;
    }
  }


}