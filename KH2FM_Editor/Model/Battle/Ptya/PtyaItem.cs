﻿using KH2FM_Editor.DataDictionary;
using KH2FM_Editor.Libs.Binary;
using KH2FM_Editor.Libs.Utils;
using KH2FM_Editor.Model.COMMON;
using System.Collections.Generic;

namespace KH2FM_Editor.Model.Battle.Ptya
{
    public class PtyaItem : Str_EntryItem
    {
        public static readonly int entrySize = 68;
        // Data Location
        public int rawOffset = 0, rawSize = 68;

        public PtyaItem()
        {
            raw = FormatHandler.getByteListOfSize(entrySize);
        }
        public PtyaItem(List<byte> rawData) : base(rawData)
        {
        }

        public string Raw
        {
            get { return DataAccess.readHexString(raw, rawOffset, rawSize); }
            set { DataAccess.writeHexString(raw, value, rawOffset, rawSize); }
        }
    }
}
