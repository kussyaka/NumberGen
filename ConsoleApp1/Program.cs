namespace RandomGen
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine(RandomNumbGen());
        }
        public static int RandomNumbGen()
        {
            var number = new Random();
            return number.Next();
        }
    }
}