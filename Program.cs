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
        public bool InsertItemsInMainPocket (double itemWeight)
        {
            if(itemWeight > 0 && mainPocketWeight + itemWeight <= 10)
            {
                mainPocketWeight += itemWeight;
                return true;
            } 
            else
            {
                return false;
            }
        }

        //method to add items to the right pocket
        public bool InsertItemsInRightPocket (double itemWeight)
        {
            if (itemWeight > 0 && rightPocketWeight + itemWeight <= 5)
            {
                rightPocketWeight += itemWeight;
                return true;
            }
            else
            {
                return false;
            }
        }

        //method to add items to the left pocket
        public bool InsertItemsInLeftPocket (double itemWeight)
        {
            if (itemWeight > 0 && leftPocketWeight + itemWeight <= 5)
            {
                leftPocketWeight += itemWeight;
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns the total sum of each pocket weight
        public double GetTotalWeight()
        {
            return mainPocketWeight + leftPocketWeight + rightPocketWeight;
        }

        //method to remove items from the main pocket
        public bool RemoveitemsFromMainPocket (double itemWeight)
        {
             if (itemWeight > 0 && mainPocketWeight - itemWeight > 0)
            {
                mainPocketWeight -= itemWeight;
                return true;
            }
            else
            {
                return false;
            }       
        }

        //method to remove items from the right pocket
        public bool RemoveitemsFromRightPocket(double itemWeight)
        {
            if (itemWeight > 0 && rightPocketWeight - itemWeight > 0)
            {
                rightPocketWeight -= itemWeight;
                return true;
            }
            else
            {
                return false;
            }        
        
        }

        //method to remove items from the left pocket
        public bool RemoveitemsFromLeftPocket(double itemWeight)
        {
            if (itemWeight > 0 && leftPocketWeight - itemWeight > 0)
            {
                leftPocketWeight -= itemWeight;
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Backpack myBackPack = new Backpack(); //creates a backpack object
            Console.WriteLine(myBackPack.InsertItemsInMainPocket(8));
            Console.WriteLine("Hello World!");
        }
    }
}
