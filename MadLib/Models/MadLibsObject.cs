namespace MadLib.Models
{
  public class MadLibsObject
  {
    private string _noun;
    private string _name;
    private string _event;

    public string GetNoun()
    {
      return _noun;
    }
    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetAnEvent()
    {
      return _event;
    }
    public void SetEvent(string newEvent)
    {
      _event = newEvent;
    }
  }
}
