using System;

namespace Backpack
{
    class Backpack
    {
        private double mainPocketWeight;
        private double leftPocketWeight;
        private double rightPocketWeight;

        //contructor to initialize fields
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
        public bool RemoveItemsFromMainPocket (double itemWeight)
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
        public bool RemoveItemsFromRightPocket(double itemWeight)
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
        public bool RemoveItemsFromLeftPocket(double itemWeight)
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

            //Backpack total weight before adding any item weight
            Console.WriteLine("Backpack total weight before adding any item weight");
            Console.WriteLine(myBackPack.GetTotalWeight() + "\n\n");

                        
            //Tests that middle pocket is true
            Console.WriteLine("Tests that the main pocket is true by adding 8 item weight");
            Console.WriteLine(myBackPack.InsertItemsInMainPocket(8) + "\n");

            //Tests that right pocket is true
            Console.WriteLine("Tests that the right pocket is true by adding 3 item weight");
            Console.WriteLine(myBackPack.InsertItemsInRightPocket(3) + "\n");

            //Tests that left pocket is true
            Console.WriteLine("Tests that the left pocket is true by adding 3 item weight");
            Console.WriteLine(myBackPack.InsertItemsInLeftPocket(3) + "\n\n");


            //Backpack total weight after adding the item weight
            Console.WriteLine("Backpack total weight after adding the item weight");
            Console.WriteLine(myBackPack.GetTotalWeight() + "\n\n");

            
            //Tests that middle pocket is false by going over capacity by 10
            Console.WriteLine("Tests that the main pocket is false by going over capacity by 10");
            Console.WriteLine(myBackPack.InsertItemsInMainPocket(12) + "\n");

            //Tests that right pocket is false by going over capacity
            Console.WriteLine("Tests that the right pocket is false by going over capacity by 5");
            Console.WriteLine(myBackPack.InsertItemsInRightPocket(7) + "\n");

            //Tests that left pocket is false by going over capacity
            Console.WriteLine("Tests that the left pocket is false by going over capacity by 5");
            Console.WriteLine(myBackPack.InsertItemsInLeftPocket(7) + "\n\n");


            //Backpack total weight after going over the capacity weight of the backpack
            Console.WriteLine("Backpack total weight after going over the capacity weight of the backpack");
            Console.WriteLine(myBackPack.GetTotalWeight() + "\n\n");

            
            //Tests removing the item weight from the backpack is true
            Console.WriteLine("Tests removing the weight from the backpack true\n");
            Console.WriteLine("Removes 6 item weight from the main pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromMainPocket(6));
            Console.WriteLine("Removes 2 item weight from the right pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromRightPocket(2));
            Console.WriteLine("Removes 2 item weight from the left pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromLeftPocket(2) + "\n\n");


            //Backpack total weight after removing item weight from the backpack
            Console.WriteLine("Backpack total weight after removing item weight from the backpack");
            Console.WriteLine(myBackPack.GetTotalWeight() + "\n\n");

            
            //Tests removing too much item weight from the backpack is false
            Console.WriteLine("Tests removing too much item weight from the backpack is false\n");
            Console.WriteLine("Removes 10 item weight from the main pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromMainPocket(10));
            Console.WriteLine("Removes 5 item weight from the right pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromRightPocket(5));
            Console.WriteLine("Removes 5 item weigh from the left pocket");
            Console.WriteLine(myBackPack.RemoveItemsFromLeftPocket(5) + "\n\n");


            //Backpack weight after all operations
            Console.WriteLine("Backpack total weight after all operations");
            Console.WriteLine(myBackPack.GetTotalWeight() + "\n\n");

        }
    }
}
