namespace Classes
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = point >= 65;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Point: {Point}");


        }
        public void CheckGraduated()
        {
            Console.WriteLine($"IsGratueted: {IsGraduated}");
        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("No diplom :( ");

            }
            else if (Point <= 80)
            {
                Console.WriteLine("The common diplom,nothing special");
            }
            else if (Point <= 90)
            {
                Console.WriteLine("Good diplom");
            }
            else
            {
                Console.WriteLine("Legendary diplom");
            }




        }
    }
}
