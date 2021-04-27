// [I]. HEAD
//  A] usings
using System.IO;
using System.Text;

namespace PizzaBox.Domain.Models
{
  public class StreetAddress
  {
    //  B] fields & props
    public int StreetNumber { get; set; }
    public string StreetLetter { get; set; }
    public string StreetName { get; set; }
    public string StreetDirection { get; set; }


    // [II]. BODY
    public StreetAddress(int _number, string _name) : this(_number, "", _name) { }

    ///
    public StreetAddress(int _number, string _letter, string _name, string _direction = null)
    {
      StreetNumber = _number;
      StreetLetter = _letter;
      StreetName = _name;
      StreetDirection = _direction;
    }// /full cxtr

    public StreetAddress(string _index, string _name, string _direction = null)
    {
      int _numb = 0;
      int.TryParse(_index, out _numb);
      StreetNumber = _numb;

      _index = _index.Replace(_numb.ToString(), "");
      StreetLetter = _index;

      StreetName = _name;
      StreetDirection = _direction;
    }// /smart cxtr

    // [III]. FOOT
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(StreetNumber);
      sb.Append(" " + StreetLetter);
      sb.Append(" " + StreetName);
      sb.Append(" " + StreetDirection);

      return sb.ToString();
    }// /'ToString'

  }// /cla 'StreetAddress'
}// ns '..Models/."
 // EoF