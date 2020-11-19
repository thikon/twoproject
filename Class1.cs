using System;

namespace submodulestest
{
    public class Class1
    {
        private string Name { get; set; }
        private string LastName { get; set; }

        public Class1(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        
        public string GetFullname()
        {
            return $"{Name} {LastName}";
        }

        public string GetOccupation(string occupation)
        {
            return occupation;
        }

        public int Calculate(int x, int y)
        {
            return x + y;
        }
    }
}
