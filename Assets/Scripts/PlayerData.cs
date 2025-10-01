using System;
using System.Collections.Generic;
using System.Numerics;

namespace PlayerData
{
    [Serializable]
    public class PlanetData
    {
        public int planetId;
        public bool isOpened;
        public int level;
    }

    [Serializable]
    public class CraftSlot
    {
        public int assignedRecipeId;    // invalid id means closed.
    }

    [Serializable]
    public class CraftData
    {
        public List<CraftSlot> craftSlots;
    }    

    [Serializable]
    public class PlayerData
    {
        public List<GameData.ResourceAmount> ownedResources;
        public List<PlanetData> miningPlanets;
        public CraftData compCrafter;
        public CraftData itemCrafter;
        public int idxCurSkill;
    }
}
