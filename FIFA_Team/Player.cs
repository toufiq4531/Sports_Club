using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    public class Player : Member
    {
        int salary;
        string position;
        int currRank;

        public Player(string id, string name, Address address, 
            int salary, string position, int currRank) : base(id, name, address)
        {
            this.salary = salary;
            this.position = position;
            this.currRank = currRank;
        }

        public int Salary
        {
            set => salary = value;
            get => salary;
        }
        public string Position
        {
            set => position = value;
            get => position;
        }
        public int CurrentRank
        {
            set => currRank = value;
            get => currRank;
        }
       

    }
}
