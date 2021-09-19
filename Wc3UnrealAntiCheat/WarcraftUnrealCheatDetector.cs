using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Ionic.Zip;
using System.Diagnostics;

namespace Wc3UnrealAntiCheat
{

    public partial class WarcraftUnrealCheatDetector : Form
    {
        List<GlobalStruct> readglobaldata = new List<GlobalStruct>( );

        bool DeepChecked = true;
        bool Unpacked = false;
        string filename = "noname";

        struct FuncStruct
        {
            public string funcname;
            public string [ ] funcdata;
            public GlobalStruct [ ] localvars;
        }


        struct GlobalStruct
        {
            public string globalname;
            public string globaldata;
        }


        struct wtsstring
        {
            public int number;
            public string data;
        }



        wtsstring [ ] GetWtsStringsFromFile ( string filename )
        {
            List<wtsstring> wtsdata = new List<wtsstring>( );

            string [ ] filedata = File.ReadAllLines( filename );

            for ( int i = 0 ; i < filedata.Length ; i++ )
            {
                string regexgetnumber = @"^\s*STRING\s\s*(\d+)";
                string regexopen = @"^\s*\{";
                string regexclose = @"^\s*\}";
                string badstr = @"^\s*$";
                Match getstrnumber = Regex.Match( filedata [ i ] , regexgetnumber );
                try
                {
                    if ( getstrnumber.Success )
                    {
                        wtsstring tempstr = new wtsstring( );
                        tempstr.number = int.Parse( getstrnumber.Groups [ 1 ].Value );
                        string outwts = "";

                        int addi = 0;
                        while ( true )
                        {
                            addi++;
                            if ( Regex.Match( filedata [ i + addi ] , regexopen ).Success )
                            {
                                addi++;
                                break;
                            }
                        }

                        while ( true )
                        {
                            if ( Regex.Match( filedata [ i + addi ] , regexclose ).Success )
                            {
                                break;
                            }
                            outwts += filedata [ i + addi ];

                            addi++;
                        }
                        tempstr.data = outwts.Replace( "\r\n" , "\n" ).Replace( "\r" , "" ).Replace( "\n" , "|n" ).Replace( "\\" , "?" ).Replace( "\"" , "?" ).Replace( "\'" , "?" );

                        wtsdata.Add( tempstr );

                    }



                }
                catch
                {

                }
            }


            return wtsdata.ToArray( );
        }

        struct CheatPack
        {
            public List<FuncStruct> data;
            public string CheatPackName;
            public List<string> regexdata;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute( "user32.dll" )]
        public static extern int SendMessage ( IntPtr hWnd ,
                         int Msg , int wParam , int lParam );
        [DllImportAttribute( "user32.dll" )]
        public static extern bool ReleaseCapture ( );

        private void DragForm ( object sender ,
        System.Windows.Forms.MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture( );
                SendMessage( Handle , WM_NCLBUTTONDOWN , HT_CAPTION , 0 );
            }
        }

        public WarcraftUnrealCheatDetector ( )
        {
            InitializeComponent( );
        }

        private void MapOpenButton_MouseEnter ( object sender , EventArgs e )
        {
            MapOpenButton.Image = Properties.Resources.OpenMapOver;
        }

        private void MapOpenButton_MouseLeave ( object sender , EventArgs e )
        {
            MapOpenButton.Image = Properties.Resources.OpenMapDef;
        }

        private void MapOpenButton_MouseDown ( object sender , MouseEventArgs e )
        {
            MapOpenButton.Image = Properties.Resources.OpenMapDef;
        }

        private void MapOpenButton_MouseUp ( object sender , MouseEventArgs e )
        {
            MapOpenButton.Image = Properties.Resources.OpenMapOver;
        }

        private void CloseButton_MouseDown ( object sender , MouseEventArgs e )
        {
            CloseButton.Image = Properties.Resources.CloseDef;
        }

        private void CloseButton_MouseUp ( object sender , MouseEventArgs e )
        {
            CloseButton.Image = Properties.Resources.CloseOver;
        }

        private void CloseButton_MouseEnter ( object sender , EventArgs e )
        {
            CloseButton.Image = Properties.Resources.CloseOver;
        }

        private void CloseButton_MouseLeave ( object sender , EventArgs e )
        {
            CloseButton.Image = Properties.Resources.CloseDef;
        }

        private void CloseButton_Click ( object sender , EventArgs e )
        {
            try
            {
                string cheatpackpath = Path.GetTempPath( ) + @"cheatunrealdb";
                Directory.Delete( cheatpackpath , true );
            }
            catch
            {

            }

            try
            {
                Environment.Exit( 0 );
            }
            catch
            {
                Application.Exit( );
            }
        }

        private string GetPassword ( )
        {
            string password = "Un";
            password += "re";
            password += "al";
            password += "Ch";
            password += "ea";
            password += "tD";
            password += "et";
            password += "ec";
            password += "to";
            password += "r!";
            return password;
        }

        public void SaveProgress ( object sender , SaveProgressEventArgs e )
        {

            if ( this.InvokeRequired )
            {
                this.Invoke( new Action<Object , SaveProgressEventArgs>( SaveProgress ) , new Object [ ] { sender , e } );
            }
            else
            {
                switch ( e.EventType )
                {
                    case ZipProgressEventType.Saving_Started:
                        //Console.WriteLine("pb max {0}", e.EntriesTotal);
                        this.progressBar1.Maximum = e.EntriesTotal;
                        this.progressBar1.Value = 0;
                        this.progressBar1.Minimum = 0;
                        this.progressBar1.Step = 1;
                        break;

                    case ZipProgressEventType.Saving_AfterWriteEntry:
                        this.progressBar1.PerformStep( );
                        break;
                }
                this.Update( );
                Application.DoEvents( );
            }
        }

        public void ReadProgress ( object sender , ReadProgressEventArgs e )
        {

            if ( this.InvokeRequired )
            {
                this.Invoke( new Action<Object , ReadProgressEventArgs>( ReadProgress ) , new Object [ ] { sender , e } );
            }
            else
            {
                switch ( e.EventType )
                {
                    case ZipProgressEventType.Reading_Started:
                        this.progressBar1.Maximum = 3347;
                        this.progressBar1.Value = 50;
                        this.progressBar1.Minimum = 0;
                        this.progressBar1.Step = 1;
                        break;

                    case ZipProgressEventType.Reading_AfterReadEntry:
                        this.progressBar1.PerformStep( );
                        break;
                }
                this.Update( );
                Application.DoEvents( );
            }
        }


        public void ExtractProgress ( object sender , ExtractProgressEventArgs e )
        {

            if ( this.InvokeRequired )
            {
                this.Invoke( new Action<Object , ExtractProgressEventArgs>( ExtractProgress ) , new Object [ ] { sender , e } );
            }
            else
            {
                switch ( e.EventType )
                {
                    case ZipProgressEventType.Extracting_BeforeExtractAll:
                        this.progressBar1.Maximum = 3347;
                        this.progressBar1.Value = 0;
                        this.progressBar1.Minimum = 0;
                        this.progressBar1.Step = 1;
                        break;

                    case ZipProgressEventType.Extracting_AfterExtractEntry:
                        this.progressBar1.PerformStep( );
                        break;
                }
                this.Update( );
                Application.DoEvents( );
            }
        }

        public void AddProgress ( object sender , AddProgressEventArgs e )
        {

            if ( this.InvokeRequired )
            {
                this.Invoke( new Action<Object , AddProgressEventArgs>( AddProgress ) , new Object [ ] { sender , e } );
            }
            else
            {
                switch ( e.EventType )
                {
                    case ZipProgressEventType.Adding_Started:
                        //Console.WriteLine("pb max {0}", e.EntriesTotal);
                        this.progressBar1.Maximum = e.EntriesTotal;
                        this.progressBar1.Value = 0;
                        this.progressBar1.Minimum = 0;
                        this.progressBar1.Step = 1;
                        break;

                    case ZipProgressEventType.Adding_AfterAddEntry:
                        this.progressBar1.PerformStep( );
                        break;
                }
                this.Update( );
                Application.DoEvents( );
            }
        }
        private void Zipit ( object sender , DoWorkEventArgs e )
        {

            if ( Unpacked )
                return;

            string cheatpackpath = Path.GetTempPath( ) + @"cheatunrealdb";

            if ( Directory.Exists( cheatpackpath ) )
            {
                Directory.Delete( cheatpackpath , true );
            }


            var options = new ReadOptions { ReadProgress = ReadProgress };
            ZipFile zip = new ZipFile( );
            zip.Password = GetPassword( );
            zip = ZipFile.Read( Directory.GetCurrentDirectory( ) + @"\cheats.zip" , options );

            // This call to ExtractAll() assumes:
            //   - none of the entries are password-protected.
            //   - want to extract all entries to current working directory
            //   - none of the files in the zip already exist in the directory;
            //     if they do, the method will throw.
            zip.Password = GetPassword( );
            zip.AddProgress += AddProgress;
            zip.ExtractProgress += ExtractProgress;
            zip.SaveProgress += SaveProgress;
            zip.Password = GetPassword( );
            zip.ExtractAll( cheatpackpath );
            zip.Dispose( );
            Unpacked = true;
        }


        bool workworked = false;
        bool cheatfound = false;

        string filepath = string.Empty;

        private void RunWorkerCompleted (
    object sender , RunWorkerCompletedEventArgs e )
        {
            readglobaldata = new List<GlobalStruct>( );
            List<FuncStruct> readstringdata = new List<FuncStruct>( );



            bool foundmainfunction = false;
            bool globalsfound = false;
            bool endglobalsfound = false;
            string [ ] inputdata = File.ReadAllLines( filepath );
            string regextest1 = @"^\s*$";
            string regextest2 = @"^\s*//";
            string regexstartfunc = @"^\s*function\s+(.*?)\s+";
            string regexendfunc = @"^\s*endfunction";

            for ( int i = 0 ; i < inputdata.Length ; i++ )
            {
                if ( Regex.Match( inputdata [ i ] , regextest1 ).Success || Regex.Match( inputdata [ i ] , regextest2 ).Success )
                    continue;

                Match getfunc = Regex.Match( inputdata [ i ] , regexstartfunc );

                if ( getfunc.Success )
                {
                    if ( !foundmainfunction && Regex.Match( inputdata [ i ] , @"\Wmain\W" ).Success )
                    {
                        foundmainfunction = true;
                    }

                    FuncStruct tmpfunc = new FuncStruct( );
                    tmpfunc.funcname = getfunc.Groups [ 1 ].Value;

                    List<GlobalStruct> readlocaldata = new List<GlobalStruct>( );

                    List<string> outputfuncdata = new List<string>( );
                    int n = i + 1;
                    for ( ; n < inputdata.Length ; n++ )
                    {
                        if ( Regex.Match( inputdata [ n ] , regextest1 ).Success || Regex.Match( inputdata [ n ] , regextest2 ).Success )
                            continue;
                        Match getendfunc = Regex.Match( inputdata [ n ] , regexendfunc );
                        if ( getendfunc.Success )
                            break;

                        if ( inputdata [ n ].IndexOf( "string" , StringComparison.Ordinal ) > -1 )
                        {
                            string strRegex = @"string\s+([a-zA-Z0-9_]+)\s*=\s*\""(.*?)\""";
                            Match getstringglobal = Regex.Match( inputdata [ i ] , strRegex );
                            if ( getstringglobal.Success )
                            {
                                GlobalStruct tmpglstr = new GlobalStruct( );
                                tmpglstr.globalname = getstringglobal.Groups [ 1 ].Value;
                                tmpglstr.globaldata = getstringglobal.Groups [ 2 ].Value;
                                readlocaldata.Add( tmpglstr );
                            }
                        }
                        outputfuncdata.Add( inputdata [ n ] );

                    }
                    tmpfunc.localvars = readlocaldata.ToArray( );
                    i = n;
                    tmpfunc.funcdata = outputfuncdata.ToArray( );
                    readstringdata.Add( tmpfunc );
                }
                else
                {
                    if ( !globalsfound && Regex.Match( inputdata [ i ] , @"^\s*globals" ).Success )
                    {
                        globalsfound = true;
                        continue;
                    }

                    if ( !endglobalsfound && Regex.Match( inputdata [ i ] , @"^\s*endglobals" ).Success )
                    {
                        endglobalsfound = true;
                        continue;
                    }

                    if ( globalsfound && !endglobalsfound )
                    {
                        string strRegex = @"string\s+([a-zA-Z0-9_]+)\s*=\s*\""(.*?)\""";
                        Match getstringglobal = Regex.Match( inputdata [ i ] , strRegex );
                        if ( getstringglobal.Success )
                        {
                            GlobalStruct tmpglstr = new GlobalStruct( );
                            tmpglstr.globalname = getstringglobal.Groups [ 1 ].Value;
                            tmpglstr.globaldata = getstringglobal.Groups [ 2 ].Value;
                            readglobaldata.Add( tmpglstr );
                        }
                    }
                }
            }


            List<CheatPack> CheatPacks = new List<CheatPack>( );
            string cheatpackpath = Path.GetTempPath( ) + @"cheatunrealdb";


            foreach ( string dir in Directory.GetDirectories( cheatpackpath ) )
            {
                CheatPack tempcheat = new CheatPack( );
                tempcheat.CheatPackName = Path.GetFileName( dir );
                List<FuncStruct> cheatpackfunctions = new List<FuncStruct>( );
                foreach ( string file in Directory.GetFiles( dir , "*.txt" ) )
                {
                    FuncStruct tempfunc = new FuncStruct( );
                    tempfunc.funcname = Path.GetFileNameWithoutExtension( file );
                    tempfunc.funcdata = File.ReadAllLines( file );
                    cheatpackfunctions.Add( tempfunc );
                }

                if ( Directory.Exists( dir + @"\DeepScan" ) && File.Exists( dir + @"\DeepScan\scandata.txt" ) )
                {
                    tempcheat.regexdata = new List<string>( File.ReadAllLines( dir + @"\DeepScan\scandata.txt" ) );
                }
                else
                {
                    tempcheat.regexdata = new List<string>( );
                }

                tempcheat.data = new List<FuncStruct>( cheatpackfunctions.ToArray( ) );
                CheatPacks.Add( tempcheat );
            }


            bool cheatpackfound = false;

            List<string> outdebuglog = new List<string>( );
            outdebuglog.Add( "Loaded " + CheatPacks.Count + " cheatpacks." );
            outdebuglog.Add( "Start scanning : \"" + filename + "\" map ." );

            /* string DebugPath = Directory.GetCurrentDirectory()+@"\debugdata";
             if ( !Directory.Exists( DebugPath ) )
                 Directory.CreateDirectory( DebugPath );*/
            // перебираем все читпаки и ищем совпадение
            if ( foundmainfunction && globalsfound && endglobalsfound )
            {
                List<FuncStruct> backfunclist = new List<FuncStruct>( readstringdata.ToArray( ) );

                if ( !DeepChecked )
                {
                    foreach ( CheatPack currentcheatpack in CheatPacks )
                    {

                        outdebuglog.Add( "Scanning " + currentcheatpack.CheatPackName + " cheatpack." );

                        if ( currentcheatpack.data.Count == 0 )
                        {
                            outdebuglog.Add( "No scan data found. Skip this cheatpack..." );
                            continue;
                        }

                        //  MessageBox.Show( "Проверяем на читпак: " + currentcheatpack.CheatPackName );
                        //Список функций карты


                        // Список проверенных функций что бы не проверять повторно
                        List<int> skiplist1 = new List<int>( );
                        List<int> skiplist2 = new List<int>( );


                        // перебираем все функции из карты
                        for ( int i = 0 ; i < backfunclist.Count ; i++ )
                        {
                            /*  File.WriteAllLines( DebugPath + @"\" + currentcheatpack.CheatPackName + i + "DUUMP.txt" , backfunclist [ i ].funcdata );
                                    */

                            // Если функция уже использована, пропускаем
                            if ( skiplist1.Contains( i ) )
                                continue;

                            // перебираем все функции из читпака
                            for ( int n = 0 ; n < currentcheatpack.data.Count ; n++ )
                            {

                                // Если функция уже использована, пропускаем
                                if ( skiplist2.Contains( n ) )
                                    continue;

                                // Если количество строк в 2х функциях совпадает то проверяем дальше
                                if ( currentcheatpack.data [ n ].funcdata.Length == backfunclist [ i ].funcdata.Length )
                                {


                                    // Список проверенных строк что бы не проверять повторно
                                    List<int> tmpskiplist1 = new List<int>( );
                                    List<int> tmpskiplist2 = new List<int>( );

                                    // Перебираем строки текущей функции
                                    for ( int m = 0 ; m < backfunclist [ i ].funcdata.Length ; m++ )
                                    {
                                        // Если строка уже использовалась - пропускаем
                                        if ( tmpskiplist1.Contains( m ) )
                                            continue;



                                        // Перебираем строки текущего читпака
                                        for ( int x = 0 ; x < currentcheatpack.data [ n ].funcdata.Length ; x++ )
                                        {

                                            // Если строка уже использовалась - пропускаем
                                            if ( tmpskiplist2.Contains( x ) )
                                                continue;

                                            // Если есть совпадение - установить okay в true иначе ищем дальше
                                            if ( backfunclist [ i ].funcdata [ m ].IndexOf( currentcheatpack.data [ n ].funcdata [ x ] , StringComparison.Ordinal ) > -1 )
                                            {
                                                // Добавляем строки в список использованных 
                                                tmpskiplist1.Add( m );
                                                tmpskiplist2.Add( x );
                                                goto nextline;
                                            }
                                        }



                                        // Сравниваем следующую функцию читпака
                                        goto skip1lvl;



nextline:
                                        continue;
                                    }

                                    // Добавляем функции в список использованных 
                                    skiplist1.Add( i );
                                    skiplist2.Add( n );
                                    /*  outdebuglog.Add( "Function " + backfunclist [ i ].funcname + " == " + currentcheatpack.data [ n ].funcname + "." );
                                      File.WriteAllLines(DebugPath+@"\"+ currentcheatpack.CheatPackName + i + "org.txt" , backfunclist [ i ].funcdata );
                                      File.WriteAllLines( DebugPath + @"\" + currentcheatpack.CheatPackName + i + "cheat.txt" , currentcheatpack.data [ n ].funcdata );
                                    */
                                    goto nextfunction;
                                }

skip1lvl:
                                continue;
                            }


/* if ( skiplist2.Count == currentcheatpack.data.Length - 1 )
 {

     MessageBox.Show( "Found!" + currentcheatpack.CheatPackName );
 }*/



nextfunction:
                            continue;
                        }


                        if ( skiplist2.Count == currentcheatpack.data.Count )
                        {
                            cheatpackfound = true;
                            CheatPicture.Image = Properties.Resources.CheatDetected;
                            CheatLabel.Text = currentcheatpack.CheatPackName;
                            workworked = false;
                            outdebuglog.Add( "Cheatpack " + currentcheatpack.CheatPackName + " detected!" );
                            return;
                        }
                        else
                        {

                            if ( skiplist2.Count == 0 || currentcheatpack.data.Count == 0 )
                                outdebuglog.Add( "Cheatpack " + currentcheatpack.CheatPackName + " : " + "0% match." );
                            else
                                outdebuglog.Add( "Cheatpack " + currentcheatpack.CheatPackName + " : " + Convert.ToInt32( ( Convert.ToDouble( skiplist2.Count ) / Convert.ToDouble( currentcheatpack.data.Count ) ) * 100.0d ).ToString( ) + "% match." );

                            /*  outdebuglog.Add( "If cheatpack not detected, please remove next files:" );

                              string needremove = string.Empty;

                              for ( int n = 0 ; n < currentcheatpack.data.Count ; n++ )
                              {
                                  if ( skiplist2.Contains( n ) )
                                      continue;
                                  else
                                      needremove += ", " + currentcheatpack.data [ n ].funcname;
                              }
                              outdebuglog.Add( needremove );*/

                        }
                        /*
                        nextcheatpack:
                                        continue;*/
                    }
                }
                else
                {
                    outdebuglog.Add( "[DEEP] Activated! Skip cheatpack scanner!" );
                }

                if ( !cheatpackfound && !DeepChecked )
                {
                    outdebuglog.Add( "Start alternative scanning!" );
                    foreach ( CheatPack currentcheatpack in CheatPacks )
                    {
                        if ( currentcheatpack.regexdata.Count == 0 )
                            continue;

                        List<int> skiplist2 = new List<int>( );


                        // перебираем все функции из карты
                        for ( int i = 0 ; i < backfunclist.Count ; i++ )
                        {

                            for ( int n = 0 ; n < currentcheatpack.regexdata.Count ; n++ )
                            {
                                if ( skiplist2.Contains( n ) )
                                    continue;

                                string [ ] finddata = Regex.Split( currentcheatpack.regexdata [ n ] , "//" );
                                if ( finddata.Length == 2 )
                                {
                                    foreach ( string str in backfunclist [ i ].funcdata )
                                    {
                                        if ( str.IndexOf( finddata [ 0 ] ) > -1 )
                                        {
                                            if ( Regex.Match( str , finddata [ 1 ] ).Success )
                                            {
                                                skiplist2.Add( n );
                                                //  outdebuglog.Add( "Debug: match -> " + finddata [ 1 ] );
                                                break;
                                            }
                                        }
                                    }
                                }
                                else
                                    MessageBox.Show( "Error in regex of cheatpack:" + currentcheatpack.CheatPackName );
                            }

                        }


                        if ( currentcheatpack.regexdata.Count == skiplist2.Count || skiplist2.Count > currentcheatpack.regexdata.Count )
                        {
                            cheatpackfound = true;
                            CheatPicture.Image = Properties.Resources.CheatDetected;
                            CheatLabel.Text = "DEEP:" + currentcheatpack.CheatPackName;
                            workworked = false;
                            outdebuglog.Add( "Cheatpack " + currentcheatpack.CheatPackName + " detected!" );
                            return;
                        }
                        else
                        {
                            if ( skiplist2.Count == 0 || currentcheatpack.data.Count == 0 )
                                outdebuglog.Add( "DEEP:" + "Cheatpack " + currentcheatpack.CheatPackName + " : " + "0% match." );
                            else
                                outdebuglog.Add( "DEEP:" + "Cheatpack " + currentcheatpack.CheatPackName + " : " + Convert.ToInt32( ( Convert.ToDouble( skiplist2.Count ) / Convert.ToDouble( currentcheatpack.data.Count ) ) * 100.0d ).ToString( ) + "% match." );
                        }
                    }
                }



                if ( !cheatpackfound || DeepChecked )
                {

                    if ( !cheatpackfound && !DeepChecked )
                        outdebuglog.Add( "ALTERNATIVE SCANNING: Sorry, no cheatpack found!" );
                    outdebuglog.Add( "Now just scan cheats... (example -test in DoTA, etc...)" );


                    for ( int i = 0 ; i < backfunclist.Count ; i++ )
                    {
                        for ( int n = 0 ; n < backfunclist [ i ].funcdata.Length ; n++ )
                        {
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "DoNotSaveReplay" ) > -1 )
                            {
                                cheatfound = true;
                                outdebuglog.Add( "Found cheat : \"Replay kill\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetPlayerState" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetPlayerState.*?PLAYER_STATE_RESOURCE_GOLD.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Add gold by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetPlayerState.*?PLAYER_STATE_RESOURCE_LUMBER.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Add lumber by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }

                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "HeroStat" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call.*?HeroStat.*?S2I" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify herostat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call.*?HeroStat.*?S2R" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify herostat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call.*?HeroStat.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify herostat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SkillPoints" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call.*?SkillPoints.*?S2I.*?GetEventPlayerChatString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify skillpoints by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetUnitInvulnerable" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitInvulnerable.*?GetTriggerPlayer" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Unit invulnerable\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }

                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitInvulnerable.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Unit invulnerable by command.\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitInvulnerable.*?GetEventPlayerChatString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Unit invulnerable by command.\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "RemoveUnit" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*RemoveUnit\W.*?GetTriggerPlayer" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Remove unit!\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }

                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*RemoveUnit\W.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Remove unit by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*RemoveUnit\W.*?GetEventPlayerChatString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Remove unit by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetGameSpeed" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetGameSpeed\W" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found possible cheat : \"Change game speed!\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetUnitOwner" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitOwner.*?GetTriggerPlayer.*?,.*?GetTriggerPlayer.*?true" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Change unit owner\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitOwner.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Change unit owner by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }
                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetUnit" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnit.*?GetEventPlayerChatString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify unitstat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnit.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Modify unitstat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnit.*?S2I" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found possible cheat : \"Modify unitstat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnit.*?S2R" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found possible cheat : \"Modify unitstat by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }

                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetPlayerState" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetPlayerState.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Add resources by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetPlayerState.*?S2I" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Add resources by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }




                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetUnitAbilityLevel" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitAbilityLevel.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Change ability level by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                                else if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*SetUnitAbilityLevel.*?S2I" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"Change ability level by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }

                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "CustomDefeat" ) > -1 )
                            {
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"call\s*CustomDefeat.*?SubString" ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "Found cheat : \"WIN/LOOSE(Defeat) by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                }
                            }

                            if ( backfunclist [ i ].funcdata [ n ].IndexOf( "GetPlayerName" ) > -1 && backfunclist [ i ].funcdata [ n ].IndexOf( "==" ) > -1 )
                            {
                                cheatfound = true;
                                outdebuglog.Add( "Found possible cheat : \"Username binding(привязка к нику)\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                string regexgetuser1 = @"GetPlayerName.*?==.*?\""(.+?)\""";
                                string regexgetuser2 = @"\""(.+?)\"".*?==.*?GetPlayerName";
                                Match getuser1 = Regex.Match( backfunclist [ i ].funcdata [ n ] , regexgetuser1 );
                                Match getuser2 = Regex.Match( backfunclist [ i ].funcdata [ n ] , regexgetuser2 );

                                if ( getuser1.Success )
                                {
                                    outdebuglog.Add( "(Ник или часть ника) Possible username (or substring of username.) is \"" + getuser1.Groups [ 1 ].Value + "\"." );
                                }
                                else if ( getuser2.Success )
                                {
                                    outdebuglog.Add( "(Ник или часть ника) Possible username (or substring of username..) is \"" + getuser2.Groups [ 1 ].Value + "\"." );
                                }
                                else
                                {
                                    bool userfound = false;

                                    for ( int z = 0 ; z < backfunclist [ i ].localvars.Length ; z++ )
                                    {
                                        if ( backfunclist [ i ].localvars [ z ].globaldata.Length == 0 )
                                            continue;

                                        string testregex = @"\W" + backfunclist [ i ].localvars [ z ].globalname + @"\W";
                                        Match GetDeepUsername = Regex.Match( backfunclist [ i ].funcdata [ n ] , testregex );
                                        if ( GetDeepUsername.Success )
                                        {
                                            userfound = true;
                                            outdebuglog.Add( "(Ник или часть ника) Possible username (or substring of username...) is \"" + backfunclist [ i ].localvars [ z ].globaldata + "\"." );
                                        }
                                    }

                                    if ( !userfound )
                                    {
                                        for ( int z = 0 ; z < readglobaldata.Count ; z++ )
                                        {
                                            if ( readglobaldata [ z ].globaldata.Length == 0 )
                                                continue;
                                            string testregex = @"\W" + readglobaldata [ z ].globalname + @"\W";
                                            Match GetDeepUsername = Regex.Match( backfunclist [ i ].funcdata [ n ] , testregex );
                                            if ( GetDeepUsername.Success )
                                            {
                                                userfound = true;
                                                outdebuglog.Add( "(Ник или часть ника) Possible username (or substring of username...) is \"" + readglobaldata [ z ].globaldata + "\"." );
                                            }
                                        }

                                    }
                                }

                            }

                        }
                    }


                    if ( File.Exists( Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" ) )
                    {
                        cheatfound = true;
                        outdebuglog.Add( "[DEEP] Warning. Found custom blizzard.j, Scanner not working with this script. Read it manually!" );
                    }
                    if ( File.Exists( Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" ) )
                    {
                        cheatfound = true;
                        outdebuglog.Add( "[DEEP] Warning. Found custom common.j, Scanner not working with this script. Read it manually!" );
                    }


                    string ReturnBug1 = @"function.*?takes.*?integer.*?code";
                    string ReturnBug2 = @"function.*?takes.*?code.*?integer";
                    string ReturnBug3 = @"function.*?takes.*?returns.*?code";


                    if ( DeepChecked )
                    {
                        int SubStringCount = 0;

                        for ( int i = 0 ; i < backfunclist.Count ; i++ )
                        {
                            for ( int n = 0 ; n < backfunclist [ i ].funcdata.Length ; n++ )
                            {
                                if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SubString" ) > -1 )
                                {
                                    SubStringCount++;
                                }



                                if ( backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".dll" ) > -1 ||
                                    backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".bat" ) > -1 ||
                                    backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".cmd" ) > -1 ||
                                    backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".com" ) > -1 ||
                                    backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".inf" ) > -1 ||
                                    backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".exe" ) > -1 )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "[DEEP] Found possible Executable file in script files!(" + i + ")" );
                                    break;
                                }

                                if ( backfunclist [ i ].funcdata [ n ].IndexOf( "Preload" ) > -1 )
                                {
                                    if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"^\s*call\s+Preload" ).Success )
                                    {
                                        cheatfound = true;
                                        outdebuglog.Add( "[DEEP] Found \"Preload\" functions! It can be used by cheatpacks. (for example: to destroy the game)." );
                                        break;
                                    }
                                    else
                                    {
                                        if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , @"\WPreload\W" ).Success )
                                        {
                                            cheatfound = true;
                                            outdebuglog.Add( "[DEEP] Possible found \"Preload\" functions! It can be used by cheatpacks. (for example: to destroy the game)." );
                                            break;
                                        }
                                        else if ( backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".dll" ) > 0 || backfunclist [ i ].funcdata [ n ].ToLower( ).IndexOf( ".exe" ) > 0 )
                                        {
                                            cheatfound = true;
                                            outdebuglog.Add( "[DEEP] Possible found \"Preload\" functions! It can be used by cheatpacks. (for example: to destroy the game)." );
                                            break;
                                        }
                                    }
                                }

                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , ReturnBug1 ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "[DEEP] This map use ReturnBug. Can be contain malware code." );
                                    break;
                                }
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , ReturnBug2 ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "[DEEP] This map use ReturnBug. Can be contain malware code." );
                                    break;
                                }
                                if ( Regex.Match( backfunclist [ i ].funcdata [ n ] , ReturnBug3 ).Success )
                                {
                                    cheatfound = true;
                                    outdebuglog.Add( "[DEEP] Possible use ReturnBug. Can be contain malware code." );
                                    break;
                                }

                                if ( backfunclist [ i ].funcdata [ n ].IndexOf( "SetPlayer" ) > -1 )
                                {
                                    string regex1 = @"call\s*SetPlayerState.*?,([\w\d_]*)\)";
                                    Match regexmatch1 = Regex.Match( backfunclist [ i ].funcdata [ n ] , regex1 );




                                    if ( regexmatch1.Success )
                                    {
                                        string regex2 = @"\W" + regexmatch1.Groups [ 1 ].Value + @"\s*=.*?SubString";

                                        for ( int x = n ; x >= 0 ; x-- )
                                        {
                                            if ( Regex.Match( backfunclist [ i ].funcdata [ x ] , regex2 ).Success )
                                            {
                                                cheatfound = true;
                                                outdebuglog.Add( "[DEEP] Found cheat : \"Add resources by command\"" + ". See function with name : \"" + backfunclist [ i ].funcname + "\"." );
                                                break;
                                            }
                                        }
                                    }

                                }
                            }
                        }


                        if ( SubStringCount > 55 )
                        {
                            cheatfound = true;
                            outdebuglog.Add( "[VERY VERY DEEP] Suspicious script! I think is possible cheatpack! :) ." );
                        }
                    }
                }

                if ( !cheatpackfound && !cheatfound )
                {
                    CheatPicture.Image = Properties.Resources.No_cheat_detected;
                    CheatLabel.Text = string.Empty;
                }
                else if ( cheatfound )
                {
                    CheatPicture.Image = Properties.Resources.CheatDetected;
                    CheatLabel.Text = "See log file..";
                }
            }
            else
            {
                outdebuglog.Add( "Error. Jass code can't execute. Sorry..." );
            }
            File.WriteAllLines( "outdebug.txt" , outdebuglog.ToArray( ) );

            if ( cheatfound )
                Process.Start( Directory.GetCurrentDirectory( ) + @"\outdebug.txt" );
            cheatfound = false;
            workworked = false;
        }


        private void MapOpenButton_Click ( object sender , EventArgs e )
        {
            if ( workworked )
                return;

            workworked = true;
            CheatPicture.Image = null;
            CheatLabel.Text = string.Empty;
            OpenFileDialog select_j_dialog = new OpenFileDialog( );
            select_j_dialog.Filter = "JassFile|*.txt;*.j|Warcraft Maps|*.w3x;*.w3m|All supported|*.txt;*.j;*.mpq;*.w3x;*.w3m";
            select_j_dialog.FilterIndex = 3;
            //  select_j_dialog.InitialDirectory = Directory.GetCurrentDirectory( );
            select_j_dialog.ShowDialog( );

            filepath = select_j_dialog.FileName;

            if ( filepath.Length < 2 || !File.Exists( filepath ) )
            {
                CheatPicture.Image = Properties.Resources.No_cheat_detected;
                CheatLabel.Text = string.Empty;
                MessageBox.Show( "Error, no file!" , "Error" );
                workworked = false;
                return;
            }

            if ( Path.GetExtension( filepath ).ToLower( ).IndexOf( "w3x" ) > -1 || Path.GetExtension( filepath ).ToLower( ).IndexOf( "w3m" ) > -1 )
            {
                filename = Path.GetFileNameWithoutExtension( filepath );
                IntPtr hMpq = IntPtr.Zero;
                bool bReopenResult = StormLib.SFileOpenArchive( filepath , 0 , StormLib.MPQ_OPEN_READ_ONLY , out hMpq );

                filepath = Directory.GetCurrentDirectory( ) + @"\extractedscript.j";
                if ( File.Exists( filepath ) )
                    File.Delete( filepath );
                if ( File.Exists( Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" ) )
                    File.Delete( Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" );
                if ( File.Exists( Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" ) )
                    File.Delete( Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" );
                if ( bReopenResult && hMpq != IntPtr.Zero )
                {
                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "war3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "War3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "WAR3MAP.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {


                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "war3map.J" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "scripts\\war3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "Scripts\\war3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "Scripts\\War3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }
                    if ( !File.Exists( filepath ) )
                    {
                        try
                        {
                            StormLib.SFileExtractFile( hMpq , "scripts\\War3map.j" , filepath , StormLib.SFILE_OPEN_FROM_MPQ );
                        }
                        catch
                        {

                        }
                    }

                    if ( !File.Exists( filepath ) )
                    {
                        MessageBox.Show( "Error, bad mpq archive!#2" , "Error" );
                        workworked = false;
                        return;
                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "blizzard.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "common.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "scripts\\blizzard.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "scripts\\common.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "blizzard.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "common.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "Scripts\\blizzard.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript2.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "Scripts\\common.j" , Directory.GetCurrentDirectory( ) + @"\extractedscript3.j" , StormLib.SFILE_OPEN_FROM_MPQ );
                    }
                    catch
                    {

                    }


                    try
                    {
                        StormLib.SFileExtractFile( hMpq , "war3map.wts" , Directory.GetCurrentDirectory( ) + @"\strings.wts" , StormLib.SFILE_OPEN_FROM_MPQ );
                        if ( File.Exists( Directory.GetCurrentDirectory( ) + @"\strings.wts" ) )
                        {
                            wtsstring [ ] wtslist = GetWtsStringsFromFile( Directory.GetCurrentDirectory( ) + @"\strings.wts" );

                            try
                            {
                                File.Delete( Directory.GetCurrentDirectory( ) + @"\strings.wts" );
                            }
                            catch
                            {

                            }

                            if ( wtslist.Length > 0 )
                            {
                                //TRIGSTR_1695
                                File.Delete( filepath + "_txt" );
                                File.Move( filepath , filepath + "_txt" );
                                string [ ] scriptdata = File.ReadAllLines( filepath + "_txt" );
                                File.Delete( filepath + "_txt" );
                                List<string> outscriptdata = new List<string>( );
                                foreach ( string str in scriptdata )
                                {
                                    string outstrstr = str;
tryrestart:
                                    string regextogetstrnum = @"(TRIGSTR_)(\d+)";

                                    if ( outstrstr.IndexOf( "TRIGSTR" , StringComparison.Ordinal ) > -1 )
                                    {
                                        Match getnum = Regex.Match( outstrstr , regextogetstrnum );
                                        if ( getnum.Success )
                                        {
                                            int numofstr = int.Parse( getnum.Groups [ 2 ].Value );
                                            string fullstr = getnum.Groups [ 1 ].Value + getnum.Groups [ 2 ].Value;

                                            for ( int i = 0 ; i < wtslist.Length ; i++ )
                                            {
                                                if ( numofstr == wtslist [ i ].number )
                                                {
                                                    outstrstr = outstrstr.Replace( fullstr , wtslist [ i ].data );
                                                    goto tryrestart;
                                                }

                                            }

                                        }
                                    }
                                    outscriptdata.Add( outstrstr );
                                }
                                File.WriteAllLines( filepath , outscriptdata.ToArray( ) );
                            }
                        }
                    }
                    catch
                    {

                    }

                    try
                    {
                        StormLib.SFILE_FIND_DATA f = new StormLib.SFILE_FIND_DATA( );
                        uint FileHandle = StormLib.SFileFindFirstFile( hMpq , "*" , f , "" );
                        MessageBox.Show( f.szPlainName );
                        while ( StormLib.SFileFindNextFile( FileHandle , f ) )
                        {
                            MessageBox.Show( f.szPlainName );
                        }

                    }
                    catch
                    {

                    }

                }
                else
                {
                    MessageBox.Show( "Error, bad mpq archive!#1" , "Error" );
                    workworked = false;
                    return;
                }
            }
            else
                filename = "noname";


            var backgroundWorker1 = new System.ComponentModel.BackgroundWorker( );
            backgroundWorker1.WorkerSupportsCancellation = false;
            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker1.DoWork += Zipit;
            backgroundWorker1.RunWorkerAsync( );
            backgroundWorker1.RunWorkerCompleted += RunWorkerCompleted;



        }

        private void DeepScanSelected_Click ( object sender , EventArgs e )
        {
            DeepChecked = !DeepChecked;

            if ( DeepChecked )
            {
                DeepScanSelected.Image = Properties.Resources.DeepChecked;
            }
            else
            {
                DeepScanSelected.Image = Properties.Resources.DeepDef;
            }
        }

        private void DeepScanSelected_MouseEnter ( object sender , EventArgs e )
        {
            if ( !DeepChecked )
            {
                DeepScanSelected.Image = Properties.Resources.DeepOver;
            }
        }

        private void DeepScanSelected_MouseLeave ( object sender , EventArgs e )
        {
            if ( !DeepChecked )
            {
                DeepScanSelected.Image = Properties.Resources.DeepDef;
            }
        }
    }
}
