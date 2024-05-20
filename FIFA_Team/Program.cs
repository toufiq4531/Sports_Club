﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address(houseNO,roadNo,area,district)
            Address a1 = new Address(2, 5, "Uttara", "Dhaka");
            Address a2 = new Address(3, 15, "Banani", "Dhaka");

            Staff s = new Staff("ST-000", "BRUCE", a1, "Coach");

            Player[] list = new Player[2];
            list[0] = new Player("PL-000", "TONY", a2, 10000, "Striker", 87);
            list[1] = new Player("PL-000", "CLERK" , a1 , 14000 , "Defender" , 71);
            
            for (int i = 0; i < list.Length; i++)
                {
                    if (s.PlayerStatus(list[i]) == true)
                        Member.GetAllDetails(list[i]);
                }
            
            Member.GetAllDetails(s);

            ClubCommittee cc = new ClubCommittee();
            cc.AddMember(s);
            cc.AddMember(list[0]);
            cc.AddMember(list[1]);

            Console.ReadKey();
        }
    }
}
