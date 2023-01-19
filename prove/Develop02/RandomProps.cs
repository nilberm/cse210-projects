class RandomProps
{

  string[] props = {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
  };

  Random randomPropIndex = new Random();

  private int GetRandomProp()
  {
    int propsIndex = randomPropIndex.Next(0, props.Length);
    return propsIndex;
  }

  public string DisplayProps()
  {
    int randomProp = GetRandomProp();
    string randomQuestion = props[randomProp];
    return randomQuestion;
  }

}