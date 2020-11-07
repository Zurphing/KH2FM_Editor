﻿using KH2FM_Editor.Libs.FileHandler;
using KH2FM_Editor.Model.Ard;
using KH2FM_Editor.Model.Ard.Script;
using KH2FM_Editor.Model.Bar;
using KH2FM_Editor.Model.Battle;
using KH2FM_Editor.Model.Battle.Atkp;
using KH2FM_Editor.Model.Battle.Bons;
using KH2FM_Editor.Model.Battle.Btlv;
using KH2FM_Editor.Model.Battle.Enmp;
using KH2FM_Editor.Model.Battle.Fmlv;
using KH2FM_Editor.Model.Battle.Limt;
using KH2FM_Editor.Model.Battle.Lvpm;
using KH2FM_Editor.Model.Battle.Lvup;
using KH2FM_Editor.Model.Battle.Magc;
using KH2FM_Editor.Model.Battle.Patn;
using KH2FM_Editor.Model.Battle.Plrp;
using KH2FM_Editor.Model.Battle.Przt;
using KH2FM_Editor.Model.Battle.Stop;
using KH2FM_Editor.Model.Battle.Sumn;
using KH2FM_Editor.Model.Battle.Vtbl;
using KH2FM_Editor.Model.Jiminy;
using KH2FM_Editor.Model.Jiminy.Puzz;
using KH2FM_Editor.Model.Jiminy.Worl;
using KH2FM_Editor.Model.Mixdata;
using KH2FM_Editor.Model.Mixdata.Cond;
using KH2FM_Editor.Model.Mixdata.Leve;
using KH2FM_Editor.Model.Mixdata.Reci;
using KH2FM_Editor.Model.System03;
using KH2FM_Editor.Model.System03.Cmd;
using KH2FM_Editor.Model.System03.Evtp;
using KH2FM_Editor.Model.System03.Item;
using KH2FM_Editor.Model.System03.Shop;
using KH2FM_Editor.Model.System03.Sklt;
using KH2FM_Editor.Model.System03.Trsr;
using KH2FM_Editor.Model.System03.Wmst;
using KH2FM_Editor.View.Ard.Script;
using KH2FM_Editor.View.Battle.Atkp;
using KH2FM_Editor.View.Battle.Bons;
using KH2FM_Editor.View.Battle.Btlv;
using KH2FM_Editor.View.Battle.Enmp;
using KH2FM_Editor.View.Battle.Fmlv;
using KH2FM_Editor.View.Battle.Limt;
using KH2FM_Editor.View.Battle.Lvpm;
using KH2FM_Editor.View.Battle.Lvup;
using KH2FM_Editor.View.Battle.Magc;
using KH2FM_Editor.View.Battle.Patn;
using KH2FM_Editor.View.Battle.Plrp;
using KH2FM_Editor.View.Battle.Przt;
using KH2FM_Editor.View.Battle.Stop;
using KH2FM_Editor.View.Battle.Sumn;
using KH2FM_Editor.View.Battle.Vtbl;
using KH2FM_Editor.View.Jiminy.Puzz;
using KH2FM_Editor.View.Jiminy.Worl;
using KH2FM_Editor.View.Mixdata.Cond;
using KH2FM_Editor.View.Mixdata.Leve;
using KH2FM_Editor.View.Mixdata.Reci;
using KH2FM_Editor.View.System03.Cmd;
using KH2FM_Editor.View.System03.Evtp;
using KH2FM_Editor.View.System03.Item;
using KH2FM_Editor.View.System03.Shop;
using KH2FM_Editor.View.System03.Sklt;
using KH2FM_Editor.View.System03.Trsr;
using KH2FM_Editor.View.System03.Wmst;
using System;
using System.IO;
using System.Linq;
using System.Windows.Controls;

namespace KH2FM_Editor.View.Bar
{
    class BarPageHandler
    {
        // DATA
        String FileName { get; set; }
        String FilePath { get; set; }
        public BarFile BarFileLoaded { get; set; }

        public BarPageHandler(String parentName, String filepath)
        {
            Console.WriteLine("DEBUG > BarPageHandler > Processing file...");
            processFile(parentName, filepath);
            Console.WriteLine("DEBUG > BarPageHandler > File processed!");
        }


        public void act_export()
        {
            if (BarFileLoaded == null) return;
            Console.WriteLine("DEBUG > BarPageHandler > Exporting...");
            FileHandler.saveFile(FileName, BarFileLoaded.getAsByteList());
            Console.WriteLine("DEBUG > BarPageHandler > Export saving!");
        }


        public void processFile(String parentName, String filePath)
        {
            Console.WriteLine("DEBUG > BarPageHandler > Getting file info...");
            // Get file data
            this.FilePath = filePath;
            FileName = Path.GetFileName(this.FilePath);

            Console.WriteLine("DEBUG > BarPageHandler > Reading " + FileName + "...");

            switch (FileHandler.getFileType(FileName))
            {
                case FileTypesEnum.MIXDATA:
                    BarFileLoaded = new MixdataFile(FileName, File.ReadAllBytes(filePath).ToList());
                    break;
                case FileTypesEnum.JIMINY:
                    BarFileLoaded = new JiminyFile(FileName, File.ReadAllBytes(filePath).ToList());
                    break;
                case FileTypesEnum.BATTLE:
                    BarFileLoaded = new BattleFile(FileName, File.ReadAllBytes(filePath).ToList());
                    break;
                case FileTypesEnum.SYSTEM:
                    BarFileLoaded = new SystemFile(FileName, File.ReadAllBytes(filePath).ToList());
                    break;
                case FileTypesEnum.ARD:
                    BarFileLoaded = new ArdFile(FileName, File.ReadAllBytes(filePath).ToList());
                    break;
            }
        }

        public void loadFile(Frame loadFrame, BarItem entry)
        {
            //BarFileLoaded.Items.IndexOf(entry);

            Console.WriteLine("DEBUG > BarPageHandler > Opening: " + entry.Name);

            switch (FileHandler.getFileType(FileName))
            {
                case FileTypesEnum.MIXDATA:
                    switch (entry.Name)
                    {
                        case "reci":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ReciFile));
                            loadFrame.Navigate(new ReciPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ReciFile));
                            break;
                        case "cond":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as CondFile));
                            loadFrame.Navigate(new CondPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as CondFile));
                            break;
                        case "leve":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LeveFile));
                            loadFrame.Navigate(new LevePage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LeveFile));
                            break;
                    }
                    break;
                case FileTypesEnum.JIMINY:
                    switch (entry.Name)
                    {
                        case "worl":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WorlFile));
                            loadFrame.Navigate(new WorlPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WorlFile));
                            break;
                        case "puzz":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PuzzFile));
                            loadFrame.Navigate(new PuzzPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PuzzFile));
                            break;
                        case "leve":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LeveFile));
                            loadFrame.Navigate(new LevePage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LeveFile));
                            break;
                    }
                    break;
                case FileTypesEnum.BATTLE:
                    switch (entry.Name)
                    {
                        case "atkp":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as AtkpFile));
                            loadFrame.Navigate(new AtkpPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as AtkpFile));
                            break;
                        case "ptya":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PtyaFile));
                            //loadFrame.Navigate(new PtyaPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PtyaFile));
                            break;
                        case "przt":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PrztFile));
                            loadFrame.Navigate(new PrztPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PrztFile));
                            break;
                        case "vtbl":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as VtblFile));
                            loadFrame.Navigate(new VtblPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as VtblFile));
                            break;
                        case "lvup":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LvupFile));
                            loadFrame.Navigate(new LvupPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LvupFile));
                            break;
                        case "bons":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as BonsFile));
                            loadFrame.Navigate(new BonsPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as BonsFile));
                            break;
                        case "btlv":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as BtlvFile));
                            loadFrame.Navigate(new BtlvPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as BtlvFile));
                            break;
                        case "lvpm":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LvpmFile));
                            loadFrame.Navigate(new LvpmPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LvpmFile));
                            break;
                        case "enmp":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as EnmpFile));
                            loadFrame.Navigate(new EnmpPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as EnmpFile));
                            break;
                        case "patn":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PatnFile));
                            loadFrame.Navigate(new PatnPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PatnFile));
                            break;
                        case "plrp":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PlrpFile));
                            loadFrame.Navigate(new PlrpPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PlrpFile));
                            break;
                        case "limt":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LimtFile));
                            loadFrame.Navigate(new LimtPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as LimtFile));
                            break;
                        case "sumn":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as SumnFile));
                            loadFrame.Navigate(new SumnPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as SumnFile));
                            break;
                        case "magc":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as MagcFile));
                            loadFrame.Navigate(new MagcPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as MagcFile));
                            break;
                        case "vbrt":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as VbrtFile));
                            //loadFrame.Navigate(new BarPage(FileName, (file as SimpleFileNode).FilePath));
                            //loadFrame.Navigate(new VbrtPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as VbrtFile));
                            break;
                        case "fmlv":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as FmlvFile));
                            loadFrame.Navigate(new FmlvPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as FmlvFile));
                            break;
                        case "stop":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as StopFile));
                            loadFrame.Navigate(new StopPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as StopFile));
                            break;
                    }
                    break;
                case FileTypesEnum.SYSTEM:
                    switch (entry.Name)
                    {
                        case "rcct":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as RcctFile));
                            //loadFrame.Navigate(new RcctPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as RcctFile));
                            break;
                        case "cmd\0":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as CmdFile));
                            loadFrame.Navigate(new CmdPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as CmdFile));
                            break;
                        case "went":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WentFile));
                            //loadFrame.Navigate(new WentPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WentFile));
                            break;
                        case "wmst":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WmstFile));
                            loadFrame.Navigate(new WmstPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as WmstFile));
                            break;
                        case "arif":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArifFile));
                            //loadFrame.Navigate(new ArifPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArifFile));
                            break;
                        case "item":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ItemFile));
                            loadFrame.Navigate(new ItemPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ItemFile));
                            break;
                        case "trsr":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as TrsrFile));
                            loadFrame.Navigate(new TrsrPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as TrsrFile));
                            break;
                        case "memt":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as MemtFile));
                            //loadFrame.Navigate(new MemtPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as MemtFile));
                            break;
                        case "ftst":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as FtstFile));
                            //loadFrame.Navigate(new FtstPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as FtstFile));
                            break;
                        case "shop":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ShopFile));
                            loadFrame.Navigate(new ShopPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ShopFile));
                            break;
                        case "sklt":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as SkltFile));
                            loadFrame.Navigate(new SkltPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as SkltFile));
                            break;
                        case "pref":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PrefFile));
                            //loadFrame.Navigate(new PrefPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as PrefFile));
                            break;
                        case "evtp":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as EvtpFile));
                            loadFrame.Navigate(new EvtpPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as EvtpFile));
                            break;
                        case "ipic":
                            //Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as IpicFile));
                            //loadFrame.Navigate(new IpicPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as IpicFile));
                            break;
                    }
                    break;

                case FileTypesEnum.ARD:
                    switch (entry.Name)
                    {
                        case "map\0":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            loadFrame.Navigate(new ArdScriptPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            break;
                        case "btl\0":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            loadFrame.Navigate(new ArdScriptPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            break;
                        case "evt\0":
                            Console.WriteLine("DEBUG > BarPageHandler > Opening File: " + (BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            loadFrame.Navigate(new ArdScriptPage(BarFileLoaded.SubFiles[BarFileLoaded.Items.IndexOf(entry)] as ArdScriptFile));
                            break;
                    }
                    break;
            }
        }
    }
}