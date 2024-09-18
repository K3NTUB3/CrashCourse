using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L12Function
    {
        public static void Lesson12()
        {
            bool toLoop = true;
            do
            {
                Console.WriteLine("\n\nSIMPLE INVENTORY SYSTEM\n");
                Console.Write("Product Serial Number : ");
                string prodnum = Console.ReadLine();

                Console.Write("Product Name          : ");
                string prodname = Console.ReadLine();

                Console.Write("Product Type          : ");
                string prodtype = Console.ReadLine();

                Console.Write("Item In? (True/False) : ");
                string input = Console.ReadLine();

                bool isIn;
                if (bool.TryParse(input, out isIn))
                {
                    Inventory inv = new Inventory(prodnum, prodname, prodtype, isIn);
                    inv.DisplayInventory();
                    inv.IsItemIn();
                    toLoop = false;
                }
                else
                {
                    Console.WriteLine("Only write true or false in the 'Item In' portion.");
                }
            } while (toLoop);

            Console.WriteLine("That is it for Lesson 12!\n\n");

        }
    }
    class Inventory
    {
        private string productNumber, productName, productType;
        bool isIn;

        public Inventory(string productNumber, string productName, string productType, bool isIn)
        {
            this.productNumber = productNumber;
            this.productName = productName;
            this.productType = productType;
            this.isIn = isIn;
        }
        public string ProductNumber
        {
            get { return productNumber; }
            private set { productNumber = value; }
        }
        public string ProductName
        {
            get { return productName; }
            private set { productName = value; }
        }
        public string ProductType
        {
            get { return productType; }
            private set { productType = value; }
        }
        public bool IsIn
        {
            get { return isIn; }
            private set { isIn = value; }
        }
        public void IsItemIn()
        {
            if (isIn)
            {
                Console.WriteLine("\nYou have added item stocks in the Inventory.");
            }
            else
            {
                Console.WriteLine("\nYou have added a new item in the Inventory.");
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n\nProduct Number : " + ProductNumber);
            Console.WriteLine("Product Name   : " + ProductName);
            Console.WriteLine("Product Type   : " + ProductType);
            Console.WriteLine("Item In?       : " + isIn);
        }
    }
}
