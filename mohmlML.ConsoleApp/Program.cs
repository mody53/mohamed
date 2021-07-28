// This file was auto-generated by ML.NET Model Builder. 

using System;
using MohmlML.Model;

namespace MohmlML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                ItemID = @"Item001",
                Loccode = 1F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual TotalStockQty with predicted TotalStockQty from sample data...\n\n");
            Console.WriteLine($"ItemID: {sampleData.ItemID}");
            Console.WriteLine($"Loccode: {sampleData.Loccode}");
            Console.WriteLine($"\n\nPredicted TotalStockQty value {predictionResult.Prediction} \nPredicted TotalStockQty scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
