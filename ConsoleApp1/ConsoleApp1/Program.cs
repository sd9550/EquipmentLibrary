// C# project to test arrays and classes
// 7/25/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapons weapons = new Weapons();
            Armor armor = new Armor();
            bool quit = false;
            bool sel;
            string entry;
            int index; // equipment array value
            // main program loop, continues until q is selected
            do {
                Console.Write("Enter 1 to view weapons, 2 to view armor, q to quit >>");
                entry = Console.ReadLine();
                sel = false; // resets each loop
                index = 0;

                if (entry.Equals("1"))
                {
                    for (int x = 0; x < weapons.GetEquipmentLength(); ++x)
                    {
                        Console.WriteLine((x + 1) + ". " + weapons.GetEquipment(x));
                    }

                do { 
                    Console.Write("Enter a number to view description, a to add a new entry, or q to quit >>");
                    entry = Console.ReadLine();
                    Int32.TryParse(entry, out index);

                    if (entry.Equals("q"))
                    {
                            sel = true;
                    } else if(entry.Equals("a")) {
                            weapons.AddEquipment();
                    }
                    else if (index > 0 && index <= weapons.GetEquipmentLength()) {
                            index -= 1; // decrement for array index purposes
                            Console.WriteLine(weapons.GetDescription(index));
                            sel = true;
                    } else
                        {
                            Console.WriteLine("Please enter a valid selection");
                        }
                } while (!sel);

                } else if(entry.Equals("2"))
                {
                    for (int x = 0; x < armor.GetEquipmentLength(); ++x)
                    {
                        Console.WriteLine((x + 1) + ". " + armor.GetEquipment(x));
                    }

                    do
                    {
                        Console.Write("Enter a number to view description, a to add a new entry, or q to quit >>");
                        entry = Console.ReadLine();
                        Int32.TryParse(entry, out index);

                        if (entry.Equals("q"))
                        {
                            sel = true;
                        }
                        else if (entry.Equals("a"))
                        {
                            armor.AddEquipment();
                        }
                        else if (index > 0 && index <= armor.GetEquipmentLength())
                        {
                            index -= 1; // decrement for array index purposes
                            Console.WriteLine(armor.GetDescription(index));
                            sel = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid selection");
                        }
                    } while (!sel);
                } else if(entry.Equals("q"))
                {
                    quit = true;
                } else
                {
                    Console.WriteLine("Please enter a valid entry");
                }
                
            } while(!quit);

            Console.WriteLine("Program Terminated");
            Console.ReadLine();
            
        }
    }
}
