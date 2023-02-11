public class Reference
{
  string _book;
  int _chapter;
  int _verse;
  int _endVerse;

  public Reference()
  {
    _book = "Ether";
    _chapter = 12;
    _verse = 6;
    _endVerse = 0;
  }

  public string GetReference()
  {
    return $"{_book} {_chapter}:{_verse}{(_endVerse == 0 ? "" : $"-{_endVerse}")}";
  }

}