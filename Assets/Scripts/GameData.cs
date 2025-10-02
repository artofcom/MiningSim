using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace GameData
{
    public enum Currency
    {
        GOLD, RUBY
    };

    [Serializable]
    public class CurrencyAmount
    {
        public Currency currencyType;
        public BigInteger amount;
    }

    [Serializable]
    public class Resource
    {
        public string id;
        public int sellPrice;
    }

    [Serializable]
    public class ResourceAmount
    {
        public string resourceId;
        public BigInteger amount;
    }

    [Serializable]
    public class Planet
    {
        [Serializable]
        public class Obtainables
        {
            public string resourceId;
            public float rate;
        }
        [Serializable]
        public class LevelFloat
        {
            public float GetValue(int level)
            {
                return baseValue + increaseValue * ((float)level);
            }
            public float baseValue;
            public float increaseValue;
        }

        [Serializable]
        public class LevelBigInt
        {
            public BigInteger GetValue(int level)
            {
                return new BigInteger(baseValue) + new BigInteger(increaseValue) * level;
            }
            public int baseValue;
            public int increaseValue;
        }

        public int id;
        public List<Obtainables> obtainables;
        public LevelFloat performances; 
        public LevelBigInt upgradeCost;
        public Currency currencyType;
    }

    [Serializable]
    public class CraftRecipe
    {
        public int id;
        public List<ResourceAmount> sources;
        public Resource output;
        public int duration;
    }

    [Serializable]
    public class SkillNode
    {
        public List<ResourceAmount> sources;

        public string feature;
        public float effectRate;
        public List<int> unlockPlanets;
    }

    [Serializable]
    public class GameData
    {
        public List<CurrencyAmount> currencies;
        public List<Resource> resources;
        public List<Planet> planets;
        public List<CraftRecipe> compRecipes;
        public List<CraftRecipe> itemRecipes;
        public List<SkillNode> skillTree;
    }
}