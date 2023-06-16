using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class chiste
{
  public string Id { get; set; }
  public string Value { get; set; }

  public string ToFileString()
  {
    return $"{Id}|{Value}";
  }

  public static chiste FromFileString(string fileString)
  {
    string[] parts = fileString.Split('|');
    if (parts.Length >= 2)
    {
      return new chiste { Id = parts[0], Value = parts[1] };
    }
    return null;
  }
}