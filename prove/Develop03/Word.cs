public class Word
{
  string _verse;
  List<string> _verseList;

  public Word()
  {
    _verse = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that afaith is things which are bhoped for and cnot seen; wherefore, dispute not because ye see not, for ye receive no dwitness until after the etrial of your faith.";

    _verseList = _verse.Split(' ').ToList();
  }

  public List<string> GetVerseList()
  {
    return _verseList;
  }



}