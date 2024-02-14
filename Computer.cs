using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    internal class Computer
    {
        //properties
        public string ProcessorType { get; set; }
        public string GraphicsCard { get; set; }
        public double RAMSize { get; set; }
        public double StorageSize { get; set; }

        //default constructor method
        public Computer()
        {
            //initialize the properties to a default value
            ProcessorType = "not selected";
            GraphicsCard = "not selected";
            RAMSize = 0;
            StorageSize = 0;
        }

        //non-default constructor method
        public Computer(string processorType, string graphicsCard, double ramSize, double storageSize)
        {
            ProcessorType = processorType;
            GraphicsCard = graphicsCard;
            RAMSize = ramSize;
            StorageSize = storageSize;
        }

        //ToString method
        public override string ToString()
        {
            return $"Processor: {ProcessorType}, Graphics Card: {GraphicsCard}, RAM: {RAMSize}GB, StorageCapacity: {StorageSize}GB";
        }

        //method to calculate the price of the user's PC build
        public double CalculateCost()
        {
            //applying average market prices to each component
            double processorPrice = 300;
            double graphicsCardPrice = 650;
            double ramPricePerGB = 0.80;
            double storagePricePerGB = 0.12;

            //expression to calculate the total cost of the user's computer
            double totalBuildCost = processorPrice + graphicsCardPrice + (RAMSize * ramPricePerGB) + (StorageSize * storagePricePerGB);
            return totalBuildCost;
        }

    }
}
