﻿using System;
using System.Collections.Generic;

namespace KH2FM_Editor_WPF.Data
{
    class ItemCategories
    {
        public static Dictionary<ushort, String> valuesDic = new Dictionary<ushort, string>() {
{ 0 , "Consumable" },
{ 1 , "Boost" },
{ 2 , "Keyblade" },
{ 3 , "Staff" },
{ 4 , "Shield" },
{ 5 , "Aladdin weapon" },
{ 6 , "Auron weapon" },
{ 7 , "Beast weapon" },
{ 8 , "Jack weapon" },
{ 9 , "Ping / Mulan weapon" },
{ 10 , "Riku weapon" },
{ 11 , "Simba weapon" },
{ 12 , "Sparrow weapon" },
{ 13 , "Tron weapon" },
{ 14 , "Armor" },
{ 15 , "Accessory" },
{ 16 , "Synthesis" },
{ 17 , "Moguri Recipe" },
{ 18 , "Magic" },
{ 19 , "Ability" },
{ 20 , "Summon" },
{ 21 , "Form" },
{ 22 , "Map" },
{ 23 , "Report" }
        };

        public static String getName(ushort id)
        {
            if (valuesDic.ContainsKey(id)) return valuesDic[id];
            return "";
        }
    }
}
