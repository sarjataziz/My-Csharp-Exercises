using Student_Info_1;

namespace Using_Association
{
    class Address
    {
        string road, house, area;

        public Address(string road, string house, string area)
        {
            this.road = road;
            this.house = house;
            this.area = area;
        }

        public string GetAddress()
        {
            return "Address: \n Road: " + this.road + ", House: " + this.house + ", Area: " + this.area;
        }
    }
}