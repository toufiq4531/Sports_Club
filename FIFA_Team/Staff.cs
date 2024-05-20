using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    public class Staff : Member
    {
        string position;
        
        public Staff(string id, string name, Address address, string position)
            : base(id, name, address)
        {
            this.position = position;
        }

        public string Position
        {
            set => position = value;
            get => position;
        }

        public bool PlayerStatus(Player player)
        {
            if(player.CurrentRank >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
