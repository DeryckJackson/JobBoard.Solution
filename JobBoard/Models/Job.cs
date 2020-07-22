using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    private string _title;
    private string _desc;
    private string _contactInfo;
    public int Id { get; }
    private static List<Job> _instances = new List<Job>();

    public Job(string title, string desc, string contactInfo)
    {
      _title = title;
      _desc = desc;
      _contactInfo = contactInfo;
      _instances.Add(this);
      Id = _instances.Count - 1;
    }

    public string GetTitle()
    {
      return _title;
    }

    public string GetDesc()
    {
      return _desc;
    }

    public string GetContactInfo()
    {
      return _contactInfo;
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Job Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}