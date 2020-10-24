﻿using System;
using System.Collections.Generic;

namespace KH2FM_Editor.DataDictionary
{
    public class Characters
    {
        // 2 Bytes
        public static Dictionary<ushort, String> valuesDictionary = new Dictionary<ushort, string>() {
{ 1 , "Sora" },
{ 2 , "Donald" },
{ 3 , "Goofy" },
{ 4 , "Mickey" },
{ 5 , "Auron" },
{ 6 , "Mulan" },
{ 7 , "Aladdin" },
{ 8 , "Jack Sparrow" },
{ 9 , "Beast" },
{ 10 , "Jack Skellington" },
{ 11 , "Simba" },
{ 12 , "Tron" },
{ 13 , "Riku" },
{ 14 , "Roxas" },
{ 15 , "Ping" },
{ 200 , "Stitch" },
{ 201 , "Genie" },
{ 202 , "Peter Pan" },
{ 203 , "Tinker Bell" },
{ 204 , "Chicken Little" }
        };

        public static String getValue(ushort id)
        {
            if (valuesDictionary.ContainsKey(id)) return valuesDictionary[id];
            return "";
        }
    }
}
