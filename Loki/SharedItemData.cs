using System.Collections.Generic;
using Loki;

namespace Loki
{
    public enum ItemType
    {
        None = 0,
        Material = 1,
        Consumable = 2,
        OneHandedWeapon = 3,
        Bow = 4,
        Shield = 5,
        Helmet = 6,
        Chest = 7,
        Ammo = 9,
        Customization = 10,
        Legs = 11,
        Hands = 12,
        Trophy = 13,
        TwoHandedWeapon = 14,
        Torch = 15,
        Misc = 16,
        Shoulder = 17,
        Utility = 18,
        Tool = 19,
        AttachAtgeir = 20,
    }

    public class SharedItemData
    {
        public string ItemName { get; set; }
        public bool IsTeleportable { get; set; }
        public bool UsesDurability { get; set; }
        public double MaxDurability { get; set; }
        public double DurabilityPerLevel { get; set; }
        public int MaxStack { get; set; }
        public string DisplayName { get; set; }
        public int MaxQuality { get; set; }
        public ItemType ItemType {get;set;}
    }

    public static class ItemDb
    {
        private static readonly Dictionary<string, SharedItemData> ItemData = new Dictionary<string, SharedItemData>
        {
            ["Amber"] = new SharedItemData
            {
                ItemName = "Amber", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Amber,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["AmberPearl"] = new SharedItemData
            {
                ItemName = "AmberPearl", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Amber_pearl,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["AncientSeed"] = new SharedItemData
            {
                ItemName = "AncientSeed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Ancient_seed,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["ArmorBronzeChest"] = new SharedItemData
            {
                ItemName = "ArmorBronzeChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_plate_cuirass,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorBronzeLegs"] = new SharedItemData
            {
                ItemName = "ArmorBronzeLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_plate_leggings,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorIronChest"] = new SharedItemData
            {
                ItemName = "ArmorIronChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_scale_mail,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorIronLegs"] = new SharedItemData
            {
                ItemName = "ArmorIronLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_greaves,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Leather_tunic,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Leather_pants,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorPaddedCuirass"] = new SharedItemData
            {
                ItemName = "ArmorPaddedCuirass", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Padded_cuirass,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorPaddedGreaves"] = new SharedItemData
            {
                ItemName = "ArmorPaddedGreaves", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Padded_greaves,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorRagsChest"] = new SharedItemData
            {
                ItemName = "ArmorRagsChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Rag_tunic,
                MaxQuality = 2, ItemType = (ItemType)7,
            },
            ["ArmorRagsLegs"] = new SharedItemData
            {
                ItemName = "ArmorRagsLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Rag_pants,
                MaxQuality = 2, ItemType = (ItemType)11,
            },
            ["ArmorTrollLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Troll_leather_tunic,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorTrollLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Troll_leather_pants,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorWolfChest"] = new SharedItemData
            {
                ItemName = "ArmorWolfChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wolf_armor_chest,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorWolfLegs"] = new SharedItemData
            {
                ItemName = "ArmorWolfLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wolf_armor_legs,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArrowBronze"] = new SharedItemData
            {
                ItemName = "ArrowBronze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Bronzehead_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFire"] = new SharedItemData
            {
                ItemName = "ArrowFire", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Fire_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFlint"] = new SharedItemData
            {
                ItemName = "ArrowFlint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Flinthead_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFrost"] = new SharedItemData
            {
                ItemName = "ArrowFrost", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Frost_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowIron"] = new SharedItemData
            {
                ItemName = "ArrowIron", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Ironhead_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowNeedle"] = new SharedItemData
            {
                ItemName = "ArrowNeedle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Needle_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowObsidian"] = new SharedItemData
            {
                ItemName = "ArrowObsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Obsidian_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowPoison"] = new SharedItemData
            {
                ItemName = "ArrowPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Poison_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowSilver"] = new SharedItemData
            {
                ItemName = "ArrowSilver", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Silver_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowWood"] = new SharedItemData
            {
                ItemName = "ArrowWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Wood_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["AtgeirBlackmetal"] = new SharedItemData
            {
                ItemName = "AtgeirBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Blackmetal_atgeir,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AtgeirBronze"] = new SharedItemData
            {
                ItemName = "AtgeirBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_atgeir,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AtgeirIron"] = new SharedItemData
            {
                ItemName = "AtgeirIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_atgeir,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AxeBlackMetal"] = new SharedItemData
            {
                ItemName = "AxeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Blackmetal_axe,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeBronze"] = new SharedItemData
            {
                ItemName = "AxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_axe,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeFlint"] = new SharedItemData
            {
                ItemName = "AxeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = Loki.Properties.Resources.Flint_axe,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeIron"] = new SharedItemData
            {
                ItemName = "AxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_axe,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeStone"] = new SharedItemData
            {
                ItemName = "AxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stone_axe,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Barley"] = new SharedItemData
            {
                ItemName = "Barley", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Barley,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BarleyFlour"] = new SharedItemData
            {
                ItemName = "BarleyFlour", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Barley_flour,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BarleyWine"] = new SharedItemData
            {
                ItemName = "BarleyWine", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Fire_resistance_barley_wine,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["BarleyWineBase"] = new SharedItemData
            {
                ItemName = "BarleyWineBase", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Barley_wine_base__Fire_resistance,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Battleaxe"] = new SharedItemData
            {
                ItemName = "Battleaxe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Battleaxe,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["Beard1"] = new SharedItemData
            {
                ItemName = "Beard1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Long_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard10"] = new SharedItemData
            {
                ItemName = "Beard10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Braided_4,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard2"] = new SharedItemData
            {
                ItemName = "Beard2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Long_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard3"] = new SharedItemData
            {
                ItemName = "Beard3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Short_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard4"] = new SharedItemData
            {
                ItemName = "Beard4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Short_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard5"] = new SharedItemData
            {
                ItemName = "Beard5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Braided_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard6"] = new SharedItemData
            {
                ItemName = "Beard6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Braided_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard7"] = new SharedItemData
            {
                ItemName = "Beard7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Short_3,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard8"] = new SharedItemData
            {
                ItemName = "Beard8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Thick_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard9"] = new SharedItemData
            {
                ItemName = "Beard9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_Braided_3,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["BeardNone"] = new SharedItemData
            {
                ItemName = "BeardNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.B_No_beard,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["BeechSeeds"] = new SharedItemData
            {
                ItemName = "BeechSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Beech_seeds,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BeltStrength"] = new SharedItemData
            {
                ItemName = "BeltStrength", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Megingjord,
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["BlackMetal"] = new SharedItemData
            {
                ItemName = "BlackMetal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Black_metal,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BlackMetalScrap"] = new SharedItemData
            {
                ItemName = "BlackMetalScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Black_metal_scrap,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["blobelite_attack_aoe"] = new SharedItemData
            {
                ItemName = "blobelite_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.fart,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["blob_attack_aoe"] = new SharedItemData
            {
                ItemName = "blob_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.fart,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Bloodbag"] = new SharedItemData
            {
                ItemName = "Bloodbag", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Bloodbag,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BloodPudding"] = new SharedItemData
            {
                ItemName = "BloodPudding", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Blood_pudding,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Blueberries"] = new SharedItemData
            {
                ItemName = "Blueberries", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Blueberries,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["boar_base_attack"] = new SharedItemData
            {
                ItemName = "boar_base_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.boar_attack1,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["BombOoze"] = new SharedItemData
            {
                ItemName = "BombOoze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Ooze_bomb,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["BoneFragments"] = new SharedItemData
            {
                ItemName = "BoneFragments", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Bone_fragments,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["bonemass_attack_aoe"] = new SharedItemData
            {
                ItemName = "bonemass_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.heal,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_punch"] = new SharedItemData
            {
                ItemName = "bonemass_attack_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_spawn"] = new SharedItemData
            {
                ItemName = "bonemass_attack_spawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.heal,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_throw"] = new SharedItemData
            {
                ItemName = "bonemass_attack_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slime_throw,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Bow"] = new SharedItemData
            {
                ItemName = "Bow", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Crude_bow,
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowDraugrFang"] = new SharedItemData
            {
                ItemName = "BowDraugrFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Draugr_fang,
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowFineWood"] = new SharedItemData
            {
                ItemName = "BowFineWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Finewood_bow,
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowHuntsman"] = new SharedItemData
            {
                ItemName = "BowHuntsman", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Huntsman_bow,
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["Bread"] = new SharedItemData
            {
                ItemName = "Bread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Bread,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Bronze"] = new SharedItemData
            {
                ItemName = "Bronze", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Bronze,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BronzeNails"] = new SharedItemData
            {
                ItemName = "BronzeNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Bronze_nails,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CapeDeerHide"] = new SharedItemData
            {
                ItemName = "CapeDeerHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Deer_hide_cape,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeLinen"] = new SharedItemData
            {
                ItemName = "CapeLinen", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Linen_cape,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeLox"] = new SharedItemData
            {
                ItemName = "CapeLox", IsTeleportable = true, UsesDurability = true, MaxDurability = 1200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Lox_cape,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeOdin"] = new SharedItemData
            {
                ItemName = "CapeOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Cape_of_Odin,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeTest"] = new SharedItemData
            {
                ItemName = "CapeTest", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.CAPE_TEST,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeTrollHide"] = new SharedItemData
            {
                ItemName = "CapeTrollHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Troll_hide_cape,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeWolf"] = new SharedItemData
            {
                ItemName = "CapeWolf", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wolf_fur_cape,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["Carrot"] = new SharedItemData
            {
                ItemName = "Carrot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Carrot,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CarrotSeeds"] = new SharedItemData
            {
                ItemName = "CarrotSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Carrot_seeds,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CarrotSoup"] = new SharedItemData
            {
                ItemName = "CarrotSoup", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Carrot_soup,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Chain"] = new SharedItemData
            {
                ItemName = "Chain", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Chain,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Chitin"] = new SharedItemData
            {
                ItemName = "Chitin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Chitin,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Cloudberry"] = new SharedItemData
            {
                ItemName = "Cloudberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Cloudberries,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Club"] = new SharedItemData
            {
                ItemName = "Club", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Coal"] = new SharedItemData
            {
                ItemName = "Coal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Coal,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Coins"] = new SharedItemData
            {
                ItemName = "Coins", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 999, DisplayName = Loki.Properties.Resources.Coins,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CookedLoxMeat"] = new SharedItemData
            {
                ItemName = "CookedLoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Cooked_lox_meat,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CookedMeat"] = new SharedItemData
            {
                ItemName = "CookedMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Cooked_meat,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Copper"] = new SharedItemData
            {
                ItemName = "Copper", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Copper,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CopperOre"] = new SharedItemData
            {
                ItemName = "CopperOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Copper_ore,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CryptKey"] = new SharedItemData
            {
                ItemName = "CryptKey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Swamp_key,
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["Crystal"] = new SharedItemData
            {
                ItemName = "Crystal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Crystal,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Cultivator"] = new SharedItemData
            {
                ItemName = "Cultivator", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Cultivator,
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["Dandelion"] = new SharedItemData
            {
                ItemName = "Dandelion", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Dandelion,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Deathsquito_sting"] = new SharedItemData
            {
                ItemName = "Deathsquito_sting", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wraith_melee,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["DeerHide"] = new SharedItemData
            {
                ItemName = "DeerHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Deer_hide,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["DragonEgg"] = new SharedItemData
            {
                ItemName = "DragonEgg", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragon_egg,
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["DragonTear"] = new SharedItemData
            {
                ItemName = "DragonTear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Dragon_tear,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["dragon_bite"] = new SharedItemData
            {
                ItemName = "dragon_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragon_claw_left,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_claw_left"] = new SharedItemData
            {
                ItemName = "dragon_claw_left", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragon_claw_left,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_claw_right"] = new SharedItemData
            {
                ItemName = "dragon_claw_right", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragon_claw_left,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_coldbreath"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.dragon_breath,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_coldbreath_OLD"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.dragon_breath,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_spit_shotgun"] = new SharedItemData
            {
                ItemName = "dragon_spit_shotgun", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.cold_ball,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_taunt"] = new SharedItemData
            {
                ItemName = "dragon_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.scream,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["draugr_arrow"] = new SharedItemData
            {
                ItemName = "draugr_arrow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Ironhead_arrow,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["draugr_axe"] = new SharedItemData
            {
                ItemName = "draugr_axe", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragur_axe,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["draugr_bow"] = new SharedItemData
            {
                ItemName = "draugr_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bow,
                MaxQuality = 1, ItemType = (ItemType)4,
            },
            ["draugr_sword"] = new SharedItemData
            {
                ItemName = "draugr_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragur_axe,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_antler"] = new SharedItemData
            {
                ItemName = "Eikthyr_antler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.StagAttack1,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_charge"] = new SharedItemData
            {
                ItemName = "Eikthyr_charge", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.StagAttack2,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_flegs_OLD"] = new SharedItemData
            {
                ItemName = "Eikthyr_flegs_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.StagAttack1,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_stomp"] = new SharedItemData
            {
                ItemName = "Eikthyr_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["ElderBark"] = new SharedItemData
            {
                ItemName = "ElderBark", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Ancient_bark,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Entrails"] = new SharedItemData
            {
                ItemName = "Entrails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Entrails,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Feathers"] = new SharedItemData
            {
                ItemName = "Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Feathers,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Fenring_attack_claw"] = new SharedItemData
            {
                ItemName = "Fenring_attack_claw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.claw,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_attack_jump"] = new SharedItemData
            {
                ItemName = "Fenring_attack_jump", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.claw,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_taunt"] = new SharedItemData
            {
                ItemName = "Fenring_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.scream,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["FineWood"] = new SharedItemData
            {
                ItemName = "FineWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Fine_wood,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FirCone"] = new SharedItemData
            {
                ItemName = "FirCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Fir_cone,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FishCooked"] = new SharedItemData
            {
                ItemName = "FishCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Cooked_fish,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["FishingBait"] = new SharedItemData
            {
                ItemName = "FishingBait", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Fishing_bait,
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["FishingRod"] = new SharedItemData
            {
                ItemName = "FishingRod", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Fishing_rod,
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["FishRaw"] = new SharedItemData
            {
                ItemName = "FishRaw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Raw_fish,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FishWraps"] = new SharedItemData
            {
                ItemName = "FishWraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Fish_wraps,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Flametal"] = new SharedItemData
            {
                ItemName = "Flametal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Flametal,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FlametalOre"] = new SharedItemData
            {
                ItemName = "FlametalOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Flametal_ore,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Flax"] = new SharedItemData
            {
                ItemName = "Flax", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Flax,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Flint"] = new SharedItemData
            {
                ItemName = "Flint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Flint,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FreezeGland"] = new SharedItemData
            {
                ItemName = "FreezeGland", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Freeze_gland,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["gd_king_punch"] = new SharedItemData
            {
                ItemName = "gd_king_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_rootspawn"] = new SharedItemData
            {
                ItemName = "gd_king_rootspawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.spawn,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_scream"] = new SharedItemData
            {
                ItemName = "gd_king_scream", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.scream,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_shoot"] = new SharedItemData
            {
                ItemName = "gd_king_shoot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.shaman_attack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_stomp"] = new SharedItemData
            {
                ItemName = "gd_king_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Ghost_attack"] = new SharedItemData
            {
                ItemName = "Ghost_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinArmband"] = new SharedItemData
            {
                ItemName = "GoblinArmband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinBrute_ArmGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ArmGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinBrute_Attack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Brute_sword,
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinBrute_Backbones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Backbones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["GoblinBrute_ExecutionerCap"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ExecutionerCap", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["GoblinBrute_HipCloth"] = new SharedItemData
            {
                ItemName = "GoblinBrute_HipCloth", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["GoblinBrute_LegBones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_LegBones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)18,
            },
            ["GoblinBrute_RageAttack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_RageAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Brute_sword,
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinBrute_ShoulderGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ShoulderGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["GoblinBrute_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Brute_taunt,
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinClub"] = new SharedItemData
            {
                ItemName = "GoblinClub", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinHelmet"] = new SharedItemData
            {
                ItemName = "GoblinHelmet", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinKing_Beam"] = new SharedItemData
            {
                ItemName = "GoblinKing_Beam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.dragon_breath,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Meteors"] = new SharedItemData
            {
                ItemName = "GoblinKing_Meteors", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.spawn,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Nova"] = new SharedItemData
            {
                ItemName = "GoblinKing_Nova", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinKing_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.scream,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinLegband"] = new SharedItemData
            {
                ItemName = "GoblinLegband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinLoin"] = new SharedItemData
            {
                ItemName = "GoblinLoin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["GoblinShaman_attack_fireball"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_fireball", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.fireballattack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_attack_poke"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_poke", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_attack_protect"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_protect", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.heal,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_Headdress_antlers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_antlers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["GoblinShaman_Headdress_feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["GoblinShaman_Staff_Bones"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Bones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["GoblinShaman_Staff_Feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Club,
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["GoblinShoulders"] = new SharedItemData
            {
                ItemName = "GoblinShoulders", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_plate_armor,
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinSpear"] = new SharedItemData
            {
                ItemName = "GoblinSpear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Flint_spear,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinSword"] = new SharedItemData
            {
                ItemName = "GoblinSword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_sword,
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinTorch"] = new SharedItemData
            {
                ItemName = "GoblinTorch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Torch,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinTotem"] = new SharedItemData
            {
                ItemName = "GoblinTotem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Fuling_totem,
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["GreydwarfEye"] = new SharedItemData
            {
                ItemName = "GreydwarfEye", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Greydwarf_eye,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Greydwarf_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_elite_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_elite_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_shaman_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.shaman_attack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_shaman_heal"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_heal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.heal,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_throw"] = new SharedItemData
            {
                ItemName = "Greydwarf_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.throw_stone,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greyling_attack"] = new SharedItemData
            {
                ItemName = "Greyling_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Guck"] = new SharedItemData
            {
                ItemName = "Guck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Guck,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Hair1"] = new SharedItemData
            {
                ItemName = "Hair1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Ponytail_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair10"] = new SharedItemData
            {
                ItemName = "Hair10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Side_Swept_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair11"] = new SharedItemData
            {
                ItemName = "Hair11", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Braided_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair12"] = new SharedItemData
            {
                ItemName = "Hair12", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Braided_3,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair13"] = new SharedItemData
            {
                ItemName = "Hair13", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Braided_4,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair14"] = new SharedItemData
            {
                ItemName = "Hair14", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Side_Swept_3,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair2"] = new SharedItemData
            {
                ItemName = "Hair2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Ponytail_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair3"] = new SharedItemData
            {
                ItemName = "Hair3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Braided_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair4"] = new SharedItemData
            {
                ItemName = "Hair4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Ponytail_3,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair5"] = new SharedItemData
            {
                ItemName = "Hair5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Short_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair6"] = new SharedItemData
            {
                ItemName = "Hair6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Long_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair7"] = new SharedItemData
            {
                ItemName = "Hair7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Ponytail_4,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair8"] = new SharedItemData
            {
                ItemName = "Hair8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Short_2,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair9"] = new SharedItemData
            {
                ItemName = "Hair9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Side_Swept_1,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["HairNone"] = new SharedItemData
            {
                ItemName = "HairNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.No_hair,
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hammer"] = new SharedItemData
            {
                ItemName = "Hammer", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Hammer,
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["HardAntler"] = new SharedItemData
            {
                ItemName = "HardAntler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Hard_antler,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["hatchling_spit_cold"] = new SharedItemData
            {
                ItemName = "hatchling_spit_cold", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.cold_ball,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["HealthUpgrade_Bonemass"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bonemass_heart,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["HealthUpgrade_GDKing"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_GDKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Elder_heart,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["HelmetBronze"] = new SharedItemData
            {
                ItemName = "HelmetBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetDrake"] = new SharedItemData
            {
                ItemName = "HelmetDrake", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Drake_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetDverger"] = new SharedItemData
            {
                ItemName = "HelmetDverger", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dverger_circlet,
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["HelmetIron"] = new SharedItemData
            {
                ItemName = "HelmetIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetLeather"] = new SharedItemData
            {
                ItemName = "HelmetLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Leather_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetOdin"] = new SharedItemData
            {
                ItemName = "HelmetOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 300,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = Loki.Properties.Resources.Hood_of_Odin,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetPadded"] = new SharedItemData
            {
                ItemName = "HelmetPadded", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Padded_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetTrollLeather"] = new SharedItemData
            {
                ItemName = "HelmetTrollLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Troll_leather_helmet,
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetYule"] = new SharedItemData
            {
                ItemName = "HelmetYule", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Yule_hat,
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["Hoe"] = new SharedItemData
            {
                ItemName = "Hoe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = Loki.Properties.Resources.Hoe,
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["Honey"] = new SharedItemData
            {
                ItemName = "Honey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Honey,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["imp_fireball_attack"] = new SharedItemData
            {
                ItemName = "imp_fireball_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.fireballattack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Iron"] = new SharedItemData
            {
                ItemName = "Iron", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Iron,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronNails"] = new SharedItemData
            {
                ItemName = "IronNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Iron_nails,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronOre"] = new SharedItemData
            {
                ItemName = "IronOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Iron_ore,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronScrap"] = new SharedItemData
            {
                ItemName = "IronScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Scrap_iron,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["KnifeBlackMetal"] = new SharedItemData
            {
                ItemName = "KnifeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Blackmetal_knife,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeChitin"] = new SharedItemData
            {
                ItemName = "KnifeChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Abyssal_razor,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeCopper"] = new SharedItemData
            {
                ItemName = "KnifeCopper", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Copper_knife,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeFlint"] = new SharedItemData
            {
                ItemName = "KnifeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Flint_knife,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["LeatherScraps"] = new SharedItemData
            {
                ItemName = "LeatherScraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Leather_scraps,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Leech_BiteAttack"] = new SharedItemData
            {
                ItemName = "Leech_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["LinenThread"] = new SharedItemData
            {
                ItemName = "LinenThread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Linen_thread,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxMeat"] = new SharedItemData
            {
                ItemName = "LoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Lox_meat,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxPelt"] = new SharedItemData
            {
                ItemName = "LoxPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Lox_pelt,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxPie"] = new SharedItemData
            {
                ItemName = "LoxPie", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Lox_meat_pie,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["lox_bite"] = new SharedItemData
            {
                ItemName = "lox_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.lox_bite,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["lox_stomp"] = new SharedItemData
            {
                ItemName = "lox_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["MaceBronze"] = new SharedItemData
            {
                ItemName = "MaceBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_mace,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceIron"] = new SharedItemData
            {
                ItemName = "MaceIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_mace,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceNeedle"] = new SharedItemData
            {
                ItemName = "MaceNeedle", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Porcupine,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceSilver"] = new SharedItemData
            {
                ItemName = "MaceSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Frostner,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MeadBaseFrostResist"] = new SharedItemData
            {
                ItemName = "MeadBaseFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Frost_resistance,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Medium_healing,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Minor_healing,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBasePoisonResist"] = new SharedItemData
            {
                ItemName = "MeadBasePoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Poison_resistance,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Medium_stamina,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Minor_stamina,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseTasty"] = new SharedItemData
            {
                ItemName = "MeadBaseTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_base__Tasty,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadFrostResist"] = new SharedItemData
            {
                ItemName = "MeadFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Frost_resistance_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Medium_healing_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Minor_healing_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadPoisonResist"] = new SharedItemData
            {
                ItemName = "MeadPoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Poison_resistance_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Medium_stamina_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Minor_stamina_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadTasty"] = new SharedItemData
            {
                ItemName = "MeadTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Tasty_mead,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Mushroom"] = new SharedItemData
            {
                ItemName = "Mushroom", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Mushroom,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MushroomBlue"] = new SharedItemData
            {
                ItemName = "MushroomBlue", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Blue_mushroom,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MushroomYellow"] = new SharedItemData
            {
                ItemName = "MushroomYellow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Yellow_mushroom,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["NeckTail"] = new SharedItemData
            {
                ItemName = "NeckTail", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Neck_tail,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["NeckTailGrilled"] = new SharedItemData
            {
                ItemName = "NeckTailGrilled", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Grilled_Neck_tail,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Neck_BiteAttack"] = new SharedItemData
            {
                ItemName = "Neck_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.jaws,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Needle"] = new SharedItemData
            {
                ItemName = "Needle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Needle,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Obsidian"] = new SharedItemData
            {
                ItemName = "Obsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Obsidian,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Ooze"] = new SharedItemData
            {
                ItemName = "Ooze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Ooze,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["PickaxeAntler"] = new SharedItemData
            {
                ItemName = "PickaxeAntler", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Antler_pickaxe,
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["PickaxeBronze"] = new SharedItemData
            {
                ItemName = "PickaxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 120,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_pickaxe,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["PickaxeIron"] = new SharedItemData
            {
                ItemName = "PickaxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_pickaxe,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["PickaxeStone"] = new SharedItemData
            {
                ItemName = "PickaxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stone_pickaxe,
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["PineCone"] = new SharedItemData
            {
                ItemName = "PineCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Pine_cone,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["PlayerUnarmed"] = new SharedItemData
            {
                ItemName = "PlayerUnarmed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Unarmed,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["QueenBee"] = new SharedItemData
            {
                ItemName = "QueenBee", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Queen_bee,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["QueensJam"] = new SharedItemData
            {
                ItemName = "QueensJam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Queens_jam,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Raspberry"] = new SharedItemData
            {
                ItemName = "Raspberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Raspberries,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["RawMeat"] = new SharedItemData
            {
                ItemName = "RawMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Raw_meat,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Resin"] = new SharedItemData
            {
                ItemName = "Resin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Resin,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["RoundLog"] = new SharedItemData
            {
                ItemName = "RoundLog", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Core_wood,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Ruby"] = new SharedItemData
            {
                ItemName = "Ruby", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Ruby,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Sausages"] = new SharedItemData
            {
                ItemName = "Sausages", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Sausages,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["SerpentMeat"] = new SharedItemData
            {
                ItemName = "SerpentMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Serpent_meat,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SerpentMeatCooked"] = new SharedItemData
            {
                ItemName = "SerpentMeatCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Cooked_serpent_meat,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["SerpentScale"] = new SharedItemData
            {
                ItemName = "SerpentScale", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Serpent_scale,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SerpentStew"] = new SharedItemData
            {
                ItemName = "SerpentStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Serpent_stew,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Serpent_attack"] = new SharedItemData
            {
                ItemName = "Serpent_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Serpent_bite,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Serpent_taunt"] = new SharedItemData
            {
                ItemName = "Serpent_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Serpent_Taunt,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SharpeningStone"] = new SharedItemData
            {
                ItemName = "SharpeningStone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Sharpening_stone,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["ShieldBanded"] = new SharedItemData
            {
                ItemName = "ShieldBanded", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Banded_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBlackmetal"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Black_metal_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBlackmetalTower"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetalTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Black_metal_tower_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBronzeBuckler"] = new SharedItemData
            {
                ItemName = "ShieldBronzeBuckler", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_buckler,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldIronSquare"] = new SharedItemData
            {
                ItemName = "ShieldIronSquare", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldIronTower"] = new SharedItemData
            {
                ItemName = "ShieldIronTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_tower_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldKnight"] = new SharedItemData
            {
                ItemName = "ShieldKnight", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Knight_shield,
                MaxQuality = 1, ItemType = (ItemType)5,
            },
            ["ShieldSerpentscale"] = new SharedItemData
            {
                ItemName = "ShieldSerpentscale", IsTeleportable = true, UsesDurability = true, MaxDurability = 250,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Serpent_scale_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldSilver"] = new SharedItemData
            {
                ItemName = "ShieldSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Silver_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldWood"] = new SharedItemData
            {
                ItemName = "ShieldWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wood_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldWoodTower"] = new SharedItemData
            {
                ItemName = "ShieldWoodTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wood_tower_shield,
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["Silver"] = new SharedItemData
            {
                ItemName = "Silver", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Silver,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SilverNecklace"] = new SharedItemData
            {
                ItemName = "SilverNecklace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Silver_Necklace,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SilverOre"] = new SharedItemData
            {
                ItemName = "SilverOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Silver_ore,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["skeleton_bow"] = new SharedItemData
            {
                ItemName = "skeleton_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bow,
                MaxQuality = 1, ItemType = (ItemType)4,
            },
            ["skeleton_mace"] = new SharedItemData
            {
                ItemName = "skeleton_mace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragur_axe,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["skeleton_sword"] = new SharedItemData
            {
                ItemName = "skeleton_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragur_axe,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SledgeIron"] = new SharedItemData
            {
                ItemName = "SledgeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_sledge,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["SledgeStagbreaker"] = new SharedItemData
            {
                ItemName = "SledgeStagbreaker", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stagbreaker,
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["SpearBronze"] = new SharedItemData
            {
                ItemName = "SpearBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_spear,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearChitin"] = new SharedItemData
            {
                ItemName = "SpearChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Abyssal_harpoon,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SpearElderbark"] = new SharedItemData
            {
                ItemName = "SpearElderbark", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Ancient_bark_spear,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearFlint"] = new SharedItemData
            {
                ItemName = "SpearFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Flint_spear,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearWolfFang"] = new SharedItemData
            {
                ItemName = "SpearWolfFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Fang_spear,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["StaminaUpgrade_Greydwarf"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Greydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stamina_Greydwarf,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["StaminaUpgrade_Troll"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Troll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stamina_Troll,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["StaminaUpgrade_Wraith"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Wraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Stamina_Wraith,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Stone"] = new SharedItemData
            {
                ItemName = "Stone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Stone,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["stonegolem_attack1_spike"] = new SharedItemData
            {
                ItemName = "stonegolem_attack1_spike", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Spike_attack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack2_left_groundslam"] = new SharedItemData
            {
                ItemName = "stonegolem_attack2_left_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.One_hand_ground_slam,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack3_spikesweep"] = new SharedItemData
            {
                ItemName = "stonegolem_attack3_spikesweep", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Spike_sweep,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack_doublesmash"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_doublesmash", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack_sonicboom_NOTUSED"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_sonicboom_NOTUSED", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["StoneGolem_clubs"] = new SharedItemData
            {
                ItemName = "StoneGolem_clubs", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)7,
            },
            ["StoneGolem_hat"] = new SharedItemData
            {
                ItemName = "StoneGolem_hat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["StoneGolem_spikes"] = new SharedItemData
            {
                ItemName = "StoneGolem_spikes", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)7,
            },
            ["SurtlingCore"] = new SharedItemData
            {
                ItemName = "SurtlingCore", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Surtling_core,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SwordBlackmetal"] = new SharedItemData
            {
                ItemName = "SwordBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Blackmetal_sword,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordBronze"] = new SharedItemData
            {
                ItemName = "SwordBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Bronze_sword,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordCheat"] = new SharedItemData
            {
                ItemName = "SwordCheat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Cheat_sword,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SwordIron"] = new SharedItemData
            {
                ItemName = "SwordIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Iron_sword,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordIronFire"] = new SharedItemData
            {
                ItemName = "SwordIronFire", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dyrnwyn,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordSilver"] = new SharedItemData
            {
                ItemName = "SwordSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Silver_sword,
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Tankard"] = new SharedItemData
            {
                ItemName = "Tankard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Tankard,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["TankardOdin"] = new SharedItemData
            {
                ItemName = "TankardOdin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Mead_horn_of_Odin,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["tentaroot_attack"] = new SharedItemData
            {
                ItemName = "tentaroot_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Dragur_axe,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Thistle"] = new SharedItemData
            {
                ItemName = "Thistle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Thistle,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Tin"] = new SharedItemData
            {
                ItemName = "Tin", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Tin,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TinOre"] = new SharedItemData
            {
                ItemName = "TinOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Tin_ore,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Torch"] = new SharedItemData
            {
                ItemName = "Torch", IsTeleportable = true, UsesDurability = true, MaxDurability = 20,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Torch,
                MaxQuality = 1, ItemType = (ItemType)15,
            },
            ["TrollHide"] = new SharedItemData
            {
                ItemName = "TrollHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Troll_hide,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["troll_groundslam"] = new SharedItemData
            {
                ItemName = "troll_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_log_swing_h"] = new SharedItemData
            {
                ItemName = "troll_log_swing_h", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.LOG,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_log_swing_v"] = new SharedItemData
            {
                ItemName = "troll_log_swing_v", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.LOG,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_punch"] = new SharedItemData
            {
                ItemName = "troll_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.slap,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_throw"] = new SharedItemData
            {
                ItemName = "troll_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.fireballattack,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["TrophyBlob"] = new SharedItemData
            {
                ItemName = "TrophyBlob", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Blob_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyBoar"] = new SharedItemData
            {
                ItemName = "TrophyBoar", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Boar_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyBonemass"] = new SharedItemData
            {
                ItemName = "TrophyBonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Bonemass_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDeathsquito"] = new SharedItemData
            {
                ItemName = "TrophyDeathsquito", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Deathsquito_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDeer"] = new SharedItemData
            {
                ItemName = "TrophyDeer", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Deer_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDragonQueen"] = new SharedItemData
            {
                ItemName = "TrophyDragonQueen", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Moder_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugr"] = new SharedItemData
            {
                ItemName = "TrophyDraugr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Draugr_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugrElite"] = new SharedItemData
            {
                ItemName = "TrophyDraugrElite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Draugr_Elite_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugrFem"] = new SharedItemData
            {
                ItemName = "TrophyDraugrFem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Draugr_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyEikthyr"] = new SharedItemData
            {
                ItemName = "TrophyEikthyr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Eikthyr_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyFenring"] = new SharedItemData
            {
                ItemName = "TrophyFenring", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Fenring_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyForestTroll"] = new SharedItemData
            {
                ItemName = "TrophyForestTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Troll_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyFrostTroll"] = new SharedItemData
            {
                ItemName = "TrophyFrostTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Troll_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblin"] = new SharedItemData
            {
                ItemName = "TrophyGoblin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Fuling_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinBrute"] = new SharedItemData
            {
                ItemName = "TrophyGoblinBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Fuling_berserker_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinKing"] = new SharedItemData
            {
                ItemName = "TrophyGoblinKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Yagluth_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinShaman"] = new SharedItemData
            {
                ItemName = "TrophyGoblinShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Fuling_shaman_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarf"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Greydwarf_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarfBrute"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Greydwarf_Brute_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarfShaman"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Greydwarf_Shaman_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyHatchling"] = new SharedItemData
            {
                ItemName = "TrophyHatchling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Drake_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyLeech"] = new SharedItemData
            {
                ItemName = "TrophyLeech", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Leech_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyLox"] = new SharedItemData
            {
                ItemName = "TrophyLox", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Lox_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyNeck"] = new SharedItemData
            {
                ItemName = "TrophyNeck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Neck_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySerpent"] = new SharedItemData
            {
                ItemName = "TrophySerpent", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 0, DisplayName = Loki.Properties.Resources.Serpent_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySGolem"] = new SharedItemData
            {
                ItemName = "TrophySGolem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Stone_Golem_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySkeleton"] = new SharedItemData
            {
                ItemName = "TrophySkeleton", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Skeleton_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySkeletonPoison"] = new SharedItemData
            {
                ItemName = "TrophySkeletonPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Rancid_remains_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySurtling"] = new SharedItemData
            {
                ItemName = "TrophySurtling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Surtling_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyTheElder"] = new SharedItemData
            {
                ItemName = "TrophyTheElder", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.The_Elder_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyWolf"] = new SharedItemData
            {
                ItemName = "TrophyWolf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Wolf_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyWraith"] = new SharedItemData
            {
                ItemName = "TrophyWraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = Loki.Properties.Resources.Wraith_trophy,
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["Turnip"] = new SharedItemData
            {
                ItemName = "Turnip", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Turnip,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TurnipSeeds"] = new SharedItemData
            {
                ItemName = "TurnipSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = Loki.Properties.Resources.Turnip_seeds,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TurnipStew"] = new SharedItemData
            {
                ItemName = "TurnipStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = Loki.Properties.Resources.Turnip_stew,
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["VegvisirShard_Bonemass"] = new SharedItemData
            {
                ItemName = "VegvisirShard_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Yagluth_thing,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Wishbone"] = new SharedItemData
            {
                ItemName = "Wishbone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wishbone,
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["WitheredBone"] = new SharedItemData
            {
                ItemName = "WitheredBone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Withered_bone,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfFang"] = new SharedItemData
            {
                ItemName = "WolfFang", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Wolf_fang,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfPelt"] = new SharedItemData
            {
                ItemName = "WolfPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Wolf_pelt,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Wolf_Attack1"] = new SharedItemData
            {
                ItemName = "Wolf_Attack1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.WolfAttack1,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wolf_Attack2"] = new SharedItemData
            {
                ItemName = "Wolf_Attack2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.WolfAttack2,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wolf_Attack3"] = new SharedItemData
            {
                ItemName = "Wolf_Attack3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.WolfAttack3,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wood"] = new SharedItemData
            {
                ItemName = "Wood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Wood,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["wraith_melee"] = new SharedItemData
            {
                ItemName = "wraith_melee", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = Loki.Properties.Resources.Wraith_melee,
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["YagluthDrop"] = new SharedItemData
            {
                ItemName = "YagluthDrop", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = Loki.Properties.Resources.Yagluth_thing,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["YmirRemains"] = new SharedItemData
            {
                ItemName = "YmirRemains", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = Loki.Properties.Resources.Ymir_flesh,
                MaxQuality = 1, ItemType = (ItemType)1,
            },
        };

        public static SharedItemData TryFindSharedData(string itemName) => 
            ItemData.TryGetValue(itemName, out SharedItemData sharedData) ? sharedData : null;

        public static IEnumerable<SharedItemData> AllItems => ItemData.Values;
    }
}

