namespace ConsoleApp3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Person zs= new Person();
            zs.Age = 13;
            ChangeAge(zs.Age);
            Console.WriteLine(zs.Age);
        }
        static void ChangeAge(int age)
        {
            age++;
            Console.WriteLine(age);

        }
    }
    public class Person
    {
        public  int Age { get; set; }
    }
}