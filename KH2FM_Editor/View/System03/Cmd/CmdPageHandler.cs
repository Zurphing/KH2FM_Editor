﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using KH2FM_Editor.Model.COMMON;
using KH2FM_Editor.Model.System03.Cmd;
using KH2FM_Editor.View.Common;

namespace KH2FM_Editor.View.System03.Cmd
{
    class CmdPageHandler : memoryLoadFile
    {
        public CmdFile CmdFileLoaded { get; set; }
        public ObservableCollection<CmdItem> CmdFileItems { get; set; }

        public CmdPageHandler(CmdFile file)
        {
            MemOffsetFallback = "21CCB5A0"; // PCSX2 CCZ's eng patch
            MemOffset = MemOffsetFallback;
            stringToFind = "cmd";

            findAddress();
            Console.WriteLine("DEBUG > CmdPageHandler > Processing file...");
            CmdFileLoaded = file;
            processFile();
            Console.WriteLine("DEBUG > CmdPageHandler > File processed!");
        }

        public void processFile()
        {
            Console.WriteLine("DEBUG > CmdPageHandler > Getting file info...");

            CmdFileItems = new ObservableCollection<CmdItem>();
            foreach (CmdItem entry in CmdFileLoaded.Entries)
            {
                CmdFileItems.Add(entry);
            }
        }

        public void insertDataToFile()
        {
            CmdFileLoaded.Entries = new ObservableCollection<Str_EntryItem>();
            foreach (CmdItem entry in CmdFileItems)
            {
                CmdFileLoaded.Entries.Add(entry);
            }
        }

        public void act_testData()
        {
            Console.WriteLine("DEBUG > CmdPageHandler > Writing to Pcsx2...");
            // For whenever an entry is added
            //insertDataToFile();
            List<byte> fileToWrite = CmdFileLoaded.getAsByteList();
            writeFileToProcess(fileToWrite);
            Console.WriteLine("DEBUG > CmdPageHandler > Finished writing!");
        }

        public void act_save()
        {
            if (CmdFileLoaded == null) return;
            Console.WriteLine("DEBUG > CmdPageHandler > Saving...");
            insertDataToFile();
            Console.WriteLine("DEBUG > CmdPageHandler > Finished saving!");
        }
    }
}
