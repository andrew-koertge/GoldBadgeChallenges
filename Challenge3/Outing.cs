using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class Outing
    {
        public enum TypeOfOuting
        {
            Golf = 1,
            Bowling,
            AmusementPark,
            Concert
        }
        public int PeopleAttended { get; set; }
        public DateTime DateOfOuting { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostPerEvent { get; set; }
        public TypeOfOuting OutingType { get; set; }

        public Outing() { }

        public Outing(int peopleAttended, DateTime dateOfOuting, decimal costPerPerson, decimal costPerEvent, TypeOfOuting outingType)
        {
            PeopleAttended = peopleAttended;
            DateOfOuting = dateOfOuting;
            CostPerPerson = costPerPerson;
            CostPerEvent = costPerEvent;
            OutingType = outingType;
        }
    }
}
