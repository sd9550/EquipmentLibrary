using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Equipment
    {
        private string[] equipment = new string[10];
        private string[] equipmentDescription = new string[10];
        private int index = 0;

        public Equipment()
        {

        }

        protected void SetEquipment(string[] e, string[] d) 
        {
            for(int x = 0; x < e.Length; ++x)
            {
                equipment[x] = e[x];
                equipmentDescription[x] = d[x];
                //Console.WriteLine(x + " " + equipment[x]);
                index += 1;
            }
            //equipment[index] = e;
            //Console.WriteLine("index = " + index);
             
        }

        public void AddEquipment()
        {
            string e = "", d = "";
            bool valid = false;
            // loop until valid entries are entered or stop if inventory full
            do
            {
                if (index < equipment.Length)
                {
                    do
                    {
                        Console.Write("Enter equipment name >>");
                        e = Console.ReadLine();
                        Console.Write("Enter equipment description >>");
                        d = Console.ReadLine();
                        // check if entries have been entered
                        if (e.Equals("") || d.Equals(""))
                        {
                            Console.WriteLine("Entries cannot be blank - try again");
                        }
                        else
                        {
                            equipment[index] = e;
                            equipmentDescription[index] = d;
                            index += 1;
                            valid = true;
                            Console.WriteLine(e + " was successfuly added to libray");
                        }
                    } while (!valid);
                }
                else
                {
                    Console.WriteLine("Inventory is full!");
                    valid = true;
                }
            } while (!valid);
        }

        protected void SetDescription(string d)
        {
            equipmentDescription[index] = d;
        }
        public string GetEquipment(int e)
        {
            return equipment[e];
        }

        public string GetDescription(int d)
        {
            return equipmentDescription[d];
        }

        public int GetEquipmentLength()
        {
            return index;
        }
    }
}
