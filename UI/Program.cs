using Tools;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PasswordHasher.Check("1000.9c0goO1Rt87Zt1CxK0ZpSQ==.UHaX+mCpHAD1StkvM3d4dfu89HHjWE5AannPbYbzD/Q=", "1111"));
            //ConsoleUI ui = new();
            //ui.LogPage();
        }
    }
}