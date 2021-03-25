﻿using KH2FM_Editor.Libs.Pcsx2;
using KH2FM_Editor.Libs.Utils;
using KH2FM_Editor.Model.Battle.Sumn;
using KH2FM_Editor.Model.COMMON;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KH2FM_Editor.View.Battle.Sumn
{
    class SumnPageHandler
    {
        // DATA
        //String FileName { get; set; }
        //String FilePath { get; set; }
        public SumnFile SumnFileLoaded { get; set; }
        public ObservableCollection<SumnItem> SumnFileItems { get; set; }

        // OPTIONS
        public string MemOffset { get; set; }
        public static string MemOffsetFallback = "21D19658"; // Crazycatz's English patch
        public static bool AddressFound = false;

        public SumnPageHandler(SumnFile file)
        {
            MemOffset = MemOffsetFallback;
            findAddress();
            Console.WriteLine("DEBUG > SumnPageHandler > Processing file...");
            SumnFileLoaded = file;
            processFile();
            Console.WriteLine("DEBUG > SumnPageHandler > File processed!");
        }

        public void processFile()
        {
            Console.WriteLine("DEBUG > SumnPageHandler > Getting file info...");

            SumnFileItems = new ObservableCollection<SumnItem>();
            foreach (SumnItem entry in SumnFileLoaded.Entries)
            {
                SumnFileItems.Add(entry);
            }
        }

        public void insertDataToFile()
        {
            SumnFileLoaded.Entries = new ObservableCollection<Str_EntryItem>();
            foreach (SumnItem entry in SumnFileItems)
            {
                SumnFileLoaded.Entries.Add(entry);
            }
        }

        public void act_testData()
        {
            Console.WriteLine("DEBUG > SumnPageHandler > Writing to Pcsx2...");
            // For whenever an entry is added
            //insertDataToFile();
            List<byte> fileToWrite = SumnFileLoaded.getAsByteList();
            Pcsx2Memory.writePcsx2(int.Parse(MemOffset, System.Globalization.NumberStyles.HexNumber), fileToWrite.Count, fileToWrite);
            Console.WriteLine("DEBUG > SumnPageHandler > Finished writing!");
        }

        public void act_save()
        {
            if (SumnFileLoaded == null) return;
            Console.WriteLine("DEBUG > SumnPageHandler > Saving...");
            insertDataToFile();
            Console.WriteLine("DEBUG > SumnPageHandler > Finished saving!");
        }

        public void findAddress()
        {
            if (AddressFound) return;
            int addressInt = Pcsx2Memory.findBarFileAddress("sumn");
            AddressFound = true;
            if (addressInt == -1) return;
            MemOffset = FormatHandler.getHexString8(addressInt);
        }
    }
}
