using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Player : IComparable
    {
        public enum Position { All, Goalkeeper, Defender, Midfielder, Forward }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position _Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        public Player(string _firstname, string _lastname, Position _position, string _prefferedposition, DateTime _dateofbirth)
        {
            FirstName = _firstname;
            LastName = _lastname;
            _Position = _position;
            DateOfBirth = _dateofbirth;
        }

        public Player(string _firstname, string _lastname, Position _position, DateTime _dateofbirth) : this(_firstname, _lastname, 0, DateTime.Now)
        {
            FirstName = _firstname;
            LastName = _lastname;
            _Position = _position;
            DateOfBirth = _dateofbirth;
        }

        public Player() : this("", "", Position.All, "", DateTime.Now) { }

        public void DisplayPosition()
        {

        }

        public override string ToString()
        {
            return $"{FirstName} - {DateOfBirth.ToShortDateString()}";
        }

        public int CompareTo(object obj)
        {
            Player that = (Player)obj;
            return DateOfBirth.CompareTo(that.DateOfBirth);
        }


    }

}
