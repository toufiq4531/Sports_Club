using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    public class Address
    {
        int houseNo;
        int roadNo;
        string area;
        string district;

        public Address(int houseNo, int roadNo, string area, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
            this.district = district;
        }

        public int HouseNo { get=> houseNo; set => houseNo = value; }
        public int RoadNo { get => roadNo; set => roadNo = value; }
        public string Area { get => area; set => area = value; }
        public string District { get => district; set => district = value; }

        public override string ToString()
        {
            return $"{HouseNo}, {RoadNo}, {Area}, {District}";
        }
    }
}
