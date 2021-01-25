using System;

namespace Backpack
{
    class Backpack
    {
        private double mainPocketWeight;
        private double leftPocketWeight;
        private double rightPocketWeight;

        //contructure to initialize fields
        public Backpack()
        {
            mainPocketWeight = 0;
            leftPocketWeight = 0;
            rightPocketWeight = 0;
        }

        //method to add items to the main pocket
        public bool InsertItemsInMainPocket (double items)
        {

        }

        //method to add items to the right pocket
        public bool InsertItemsInRightPocket (double items)
        {

        }

        //method to add items to the left pocket
        public bool InsertItemsInLeftPocket (double items)
        {

        }

        //returns the total sum of each pocket weight
        public double GetTotalWeight()
        {

        }

        //method to remove items from the main pocket
        public bool RemoveitemsFromMainPocket (double items)
        {

        }

        //method to remove items from the right pocket
        public bool RemoveitemsFromRightPocket(double items)
        {

        }

        //method to remove items from the left pocket
        public bool RemoveitemsFromLeftPocket(double items)
        {

        }
        static void Main(string[] args)
        {
            Backpack myBackPack = new Backpack(); //creates a backpack object
            Console.WriteLine(myBackPack.InsertItemsInMainPocket(8));
            Console.WriteLine("Hello World!");
        }
    }
}
