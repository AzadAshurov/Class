namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Azad", "Ashurov", "BP-217", 95);
            student.GetInfo();
            student.CheckGraduated();
            student.GetDiplomDegree();




        }
    }
}
