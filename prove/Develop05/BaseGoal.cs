public abstract class BaseGoal
{
  protected string _typeGoal;
  protected string _nameGoal;
  protected string _description;
  protected string _amountPoints;
  protected string _timesToExtra;

  protected string _currentTimesToExtra;
  protected string _extraPoints;
  protected Boolean _isCompleted;
  protected List<string> _goal;

  public abstract List<string> CreateGoal(string typeGoal);


}