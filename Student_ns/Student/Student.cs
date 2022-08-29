using Using_Association;

namespace Student_Info_1
{
    class Student
    {
        internal readonly int Length;
        private string _id, _name, _department, _university;
        private Address address; //one-to-one
        private float _cgpa;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public float Cgpa
        {
            get { return _cgpa; }
            set { _cgpa = value; }
        }
        public string University
        {
            get { return _university; }
            set { _university = value; }
        }

        public void ShowInfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Student Info: ");
            System.Console.WriteLine();
            System.Console.WriteLine("University Name: " + _university);
            System.Console.WriteLine("Name: " + _name);
            System.Console.WriteLine("ID: " + _id);
            System.Console.WriteLine("Department: " + _department);
            System.Console.WriteLine("CGPA: " + _cgpa);
            System.Console.WriteLine(this.address.GetAddress());                                        //Calling Address
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
        }

    }
}