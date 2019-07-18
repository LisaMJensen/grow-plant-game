using System;
using System.Collections.Generic;

namespace Plantgame.Models
{
    class Plant
    {

        private string _PlantName;
        private int _WaterLevel;
        private int _FoodLevel;
        private int _SunshineLevel;
        private int _PlantHealth;

        public Plant(string plantName, int waterLevel, int foodLevel, int sunshineLevel, int plantHealth)
        {

            _PlantName = plantName;
            _WaterLevel  = waterLevel;
            _FoodLevel = foodLevel;
            _SunshineLevel = sunshineLevel;
            _PlantHealth = plantHealth;
        }

        public string GetPlantName()
        {
            return _PlantName;
        }

        public int GetWaterLevel()
        {
            return _WaterLevel;
        }

        public int GetFoodLevel()
        {
            return _FoodLevel;
        }

        public int GetSunshineLevel()
        {
            return _SunshineLevel;
        }

        public int GetPlantHealth()
        {
            return _PlantHealth;
        }

        public void SetPlantName(string newPlantName)
        {
          _PlantName = newPlantName;
        }

        public void DetermineNextSteps()
        {
            Feed();
            Water();
            GiveSun();
            // UpdatePlantHealth();
            // IsPlantDead();
        }

        private void Feed()
        {
            _FoodLevel++;
        }

        private void Water()
        {
            _WaterLevel++;
        }

        private void GiveSun()
        {
            _SunshineLevel++;
        }

        // private void  UpdatePlantHealth()
        // {
        //
        // }
        //
        // private string IsPlantDead()
        // {
        //
        // }









    }
}
