using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    class ClubCommittee : Member
    {
        private Member[] members;
        private int count;

        public ClubCommittee()
        {
            members = new Member[10];
            count = 0;
        }

        public void AddMember(Member member)
        {
            if (count < members.Length)
            {
                members[count] = member;
                count++;
            }
            else
            {
                Console.WriteLine("Array is full");
            }
        }
    }
}

