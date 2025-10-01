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
        public class Performance
        {
            public float rate;
            public CurrencyAmount cost;
        }

        public int id;
        public List<Obtainables> obtainables;
        public List<Performance> levelPerformances; // performance per level. ( idx+1 == level )
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