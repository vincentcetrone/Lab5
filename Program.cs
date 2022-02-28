using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int row = rnd.Next(3,10);
            int column = rnd.Next(3,10);
            MenuChoice(row,column);
        }
        static void Menu()
        {
            Console.WriteLine("Make a selection by entering 1, 2, or 3");
            Console.WriteLine("Enter 1 to display starting poker chips");
            Console.WriteLine("Enter 2 to display chips not played");
            Console.WriteLine("Enter 3 to exit");
            
            
        }
        static void GetChips(ref int row, ref int column)
        {
            for(int rnd =0; rnd < column; rnd++)
            {
                Console.Write("0");
            }
            Console.WriteLine("");
        }
        static void StackedChips(ref int row, ref int column)
        {
                
        }
        static void MenuChoice( int row, int column)
        {
            Menu();
            string choice = Console.ReadLine();
            int choice1 = Int32.Parse(choice);
            while(choice1 != 3)
            {
                if(choice1 == 1)
                {
                    GetChips(ref row,ref column);
                }
                else if(choice1 == 2)
                {
                    StackedChips(ref row, ref column);
                }
                else
                {
                    Console.WriteLine("You entered an invalid number");
                }
                Menu();
                choice = Console.ReadLine();
                choice1 = Int32.Parse(choice);
            }
        }
    }
}
