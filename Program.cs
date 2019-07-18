using System;
using System.Collections.Generic;
using Plantgame.Models;

class Program
{
    public static List<Plant> Plants = new List<Plant>() {};

    public static void ShowPlantStats()
    {
        Console.WriteLine("Your Plant's Current Stats:");
        foreach(Plant newPlant in Plants)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(newPlant.GetPlantName());

            Console.WriteLine("Water Level: " + newPlant.GetWaterLevel());
            Console.WriteLine("Food Level: " + newPlant.GetFoodLevel());
            Console.WriteLine("Sunshine Level: " + newPlant.GetSunshineLevel());
            Console.WriteLine("Plant Health: " + newPlant.GetPlantHealth());

        }
    }

    static void Main()
    {
     Console.WriteLine("WELCOME TO PLANT GROW");
     Console.WriteLine("----------------");
     Console.WriteLine("Give your plant a name:");
     string answer = Console.ReadLine();
     Plant newPlant = new Plant (answer, 20, 20, 20, 50);

     Plants.Add(newPlant);
     ShowPlantStats();
    }









}
