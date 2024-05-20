using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    public class Member
    {
        string id;
        string name;
        Address address;

        public Member() { }
        public Member(string id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public string ID
        {
            set => id = value;
            get => id;

        }
        public string Name
        {
            set => name = value;
            get => name;
        }
        public Address Address
        {
            set => address = value;
            get => address;
        }


        public static void GetAllDetails(Member member)
        {
            Console.WriteLine("ID: "+ member.ID);
            Console.WriteLine("Name: "+ member.Name);
            Console.WriteLine("Address: "+ member.Address);

            if(member is Player p)
            {
                Console.WriteLine("Salary: "+ p.Salary);
                Console.WriteLine("Playing Position: "+ p.Position);
                Console.WriteLine("Current Rank: "+ p.CurrentRank);
            }
            else if(member is Staff s)
            {
                Console.WriteLine("Staff Position: "+ s.Position);
            }
        }
    }
}
