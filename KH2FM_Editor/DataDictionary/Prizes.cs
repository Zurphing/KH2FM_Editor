﻿using System;
using System.Collections.Generic;

namespace KH2FM_Editor.DataDictionary
{
    public class Prizes
    {
        // 2 Bytes
        public static Dictionary<ushort, String> valuesDictionary = new Dictionary<ushort, string>() {
{ 1 , "Soldier" },
{ 2 , "Shadow" },
{ 3 , "Large Body" },
{ 4 , "Armored Knight" },
{ 5 , "Surveillance Robot" },
{ 6 , "Dusk" },
{ 7 , "Trick Ghost" },
{ 8 , "Rabid Dog" },
{ 9 , "Hook Bat" },
{ 10 , "Minute Bomb" },
{ 11 , "Assault Rider" },
{ 12 , "Hammer Frame" },
{ 13 , "Aeroplane" },
{ 14 , "Torch [OC]" },
{ 15 , "Samurai" },
{ 16 , "Soul [OC]" },
{ 17 , "Rapid Thruster" },
{ 18 , "Bolt Tower" },
{ 19 , "" },
{ 22 , "Dragoon" },
{ 23 , "Assassin" },
{ 24 , "Sniper" },
{ 25 , "Dancer" },
{ 26 , "Berserker" },
{ 27 , "Gambler" },
{ 28 , "Sorcerer" },
{ 29 , "Creeper" },
{ 30 , "Nightwalker" },
{ 32 , "Fortuneteller" },
{ 33 , "Luna Bandit" },
{ 34 , "Hot Rod" },
{ 35 , "Cannon Gun" },
{ 36 , "Living Bones" },
{ 37 , "Devastator" },
{ 38 , "Lance Soldier" },
{ 39 , "Driller Mole" },
{ 40 , "Shaman" },
{ 41 , "Neoshadow" },
{ 42 , "Magnum Loader" },
{ 43 , "Morning Star" },
{ 44 , "Tornado Step" },
{ 45 , "Gargoyle Knight" },
{ 46 , "Gargoyle Warrior" },
{ 47 , "Silver Rock" },
{ 48 , "Wight Knight" },
{ 49 , "Emerald Blues" },
{ 50 , "Crimson Jazz" },
{ 51 , "Loudmouth" },
{ 52 , "Creeper Plant" },
{ 53 , "Cerberus (Dog Paddle RC)" },
{ 54 , "Thresholder (Knockout before RC)" },
{ 56 , "Possessor" },
{ 60 , "Lock" },
{ 61 , "Shock" },
{ 62 , "Barrel" },
{ 63 , "Air Pirate" },
{ 64 , "Fat Bandit" },
{ 65 , "Fiery Globe" },
{ 66 , "Icy Cube" },
{ 69 , "Aerial Knocker" },
{ 70 , "Small urn [OC]" },
{ 71 , "Big urn [OC] (And Urninator RC)" },
{ 72 , "" },
{ 73 , "Strafer" },
{ 74 , "" },
{ 75 , "" },
{ 76 , "" },
{ 77 , "" },
{ 78 , "" },
{ 79 , "" },
{ 80 , "" },
{ 81 , "" },
{ 82 , "Illuminator" },
{ 83 , "" },
{ 84 , "" },
{ 85 , "Shadow Stalker (Chandelier)" },
{ 86 , "Shadow Stalker (Pillar)" },
{ 87 , "Undead Pirate A" },
{ 88 , "Undead Pirate B" },
{ 89 , "Undead Pirate C" },
{ 90 , "Armor stand [BC]" },
{ 91 , "Small rocket [LoD]" },
{ 92 , "Big rocket [LoD]" },
{ 93 , "Rocket Cart [LoD]" },
{ 94 , "" },
{ 95 , "" },
{ 96 , "Bookmaster" },
{ 97 , "Al limit (Quickplay (Al))" },
{ 98 , "Al limit (Quickplay (Sora))" },
{ 99 , "Al limit (Speedster end)" },
{ 100 , "Al limit (Speedster start)" },
{ 102 , "" },
{ 103 , "Abu ice crystal" },
{ 104 , "" },
{ 105 , "" },
{ 106 , "" },
{ 107 , "Water Clone" },
{ 108 , "Aladdin dash attack" },
{ 109 , "Peter Pan (Sora hit and limit X)" },
{ 111 , "Stitch limit (ukelele)" },
{ 112 , "Graveyard / Toy Soldier" },
{ 114 , "" },
{ 115 , "Lance Soldier (Hitting itself)" },
{ 116 , "Lance Soldier (Running)" },
{ 117 , "Lance Soldier (Hitting itself (double drop))" },
{ 118 , "Lance Soldier (Lance Tug RC)" },
{ 119 , "Dusk (STT Day 3 SoS before door)" },
{ 120 , "Dusk (STT)" },
{ 121 , "Creeper (STT)" },
{ 122 , "" },
{ 123 , "Creeper Plant (Root Ravager RC)" },
{ 125 , "Loudmouth (Heal Stomp RC)" },
{ 126 , "Gambler (Reaction Command)" },
{ 127 , "Peter Pan limit (Triangle)" },
{ 128 , "Peter Pan limit (X)" },
{ 129 , "Meg (Hydra battle)" },
{ 130 , "Assassin (STT Day 6)" },
{ 131 , "" },
{ 132 , "" },
{ 133 , "Luxord (Reaction Command)" },
{ 134 , "Card" },
{ 135 , "" },
{ 136 , "" },
{ 137 , "" },
{ 138 , "Bulky Vendor (Capsule Prize)" },
{ 139 , "Bulky Vendor (Rare Capsule)" },
{ 140 , "Bulky Vendor (Limited Capsule)" },
{ 141 , "Bulky Vendor (Prime Capsule)" },
{ 142 , "Bulky Vendor (Any defeat)" },
{ 143 , "" },
{ 144 , "Hydra (Vanquish RC)" },
{ 145 , "Dusk (STT Day 1)" },
{ 146 , "" },
{ 147 , "Box [BC]" },
{ 148 , "" },
{ 149 , "Junk break [TT]" },
{ 150 , "Bee [TT]" },
{ 151 , "" },
{ 152 , "Hazard hit [HT]" },
{ 154 , "Junk hitting junk [TT]" },
{ 155 , "Bag/Anchor hit [PoC]" },
{ 156 , "Mushroom (Odds) 1" },
{ 157 , "Mushroom (Odds) 2" },
{ 158 , "Mushroom (Odds) 3" },
{ 159 , "Mushroom (Odds) 4" },
{ 160 , "Mushroom (Odds) 5" },
{ 161 , "Mushroom (Evens) 1" },
{ 162 , "Mushroom (Evens) 2" },
{ 163 , "Mushroom (Evens) 3" },
{ 164 , "Mushroom (Evens) 4" },
{ 165 , "Mushroom (Evens) 5" },
{ 166 , "Mushroom (Prizes) 1" },
{ 167 , "Mushroom (Prizes) 2" },
{ 168 , "Mushroom (Prizes) 3" },
{ 169 , "Mushroom (Prizes) 4" },
{ 170 , "Mushroom (Prizes) 5" },
{ 171 , "Beffudler" },
{ 172 , "Camo Cannon" },
{ 173 , "Aerial Viking" },
{ 174 , "Aerial Champ" },
{ 175 , "Necromancer" },
{ 176 , "Magic Phantom" },
{ 177 , "Spring Metal" },
{ 178 , "Runemaster" },
{ 179 , "Iron Hammer" },
{ 180 , "Lance Warrior" },
{ 181 , "Mad Ride" },
{ 182 , "Reckless" },
{ 183 , "Sphere hit [CoR]" },
{ 184 , "Sphere last hit [CoR]" },
{ 185 , "Valve [CoR]" },
{ 186 , "" },
{ 187 , "" },
{ 188 , "Soothe/Herb/Heal/Mend (Zexion RC)" },
{ 189 , "Spirit (Zexion RC)" },
{ 190 , "Stamina (Zexion RC)" },
{ 191 , "Riches/Wealth (Zexion RC)" },
{ 192 , "Jackpot/Bounty (Zexion RC)" },
{ 193 , "Treasure/Lucky (Zexion RC)" },
{ 194 , "Bonus (Zexion RC)" },
{ 195 , "Lingering Will magic seal" },
{ 196 , "Lingering Will attack seal" },
{ 197 , "" },
{ 198 , "" }
        };

        public static String getValue(ushort id)
        {
            if (valuesDictionary.ContainsKey(id)) return valuesDictionary[id];
            return "";
        }
    }
}
