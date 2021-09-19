using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace CheatPackToData
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            string curdir = Directory.GetCurrentDirectory( );
            string outdirectory = curdir + @"\" + Path.GetFileName( curdir );
            Console.WriteLine( outdirectory );
            try
            {
                Directory.CreateDirectory( outdirectory );
            }
            catch
            {

            }
            foreach ( string file in Directory.GetFiles( curdir , "*.txt" ) )
            {
                string [ ] data = File.ReadAllLines( file );
                List<string> tempdata = new List<string>( );
                //Найти function , все строки внести в список, после найти endfunction и сохранить.
                //Попутно стереть все лишние строки
                int fileid = 0;

                string regexstartfunc = @"^\s*function";
                string regexendfunc = @"^\s*endfunction";
                string regexremovequotes = @"^(.*?)"".*?""(.*)";


                List<string> tempoutdata = new List<string>( );

                for ( int i = 0 ; i < data.Length ; i++ )
                {
                    if ( Regex.Match( data [ i ] , regexstartfunc ).Success )
                    {
                        tempoutdata.Clear( );
                        fileid++;
                    }
                    else if ( Regex.Match( data [ i ] , regexendfunc ).Success )
                    {
                        File.WriteAllLines( outdirectory + @"\" + fileid + ".txt" , tempoutdata.ToArray( ) );
                        tempoutdata.Clear( );
                    }
                    else
                    {
                        Match removequotes = Regex.Match( data [ i ].Replace( "\\\"" , "x" ) , regexremovequotes );
                        if ( removequotes.Success )
                            tempoutdata.Add( removequotes.Groups [ 1 ].Value + removequotes.Groups [ 2 ].Value );
                        else
                            tempoutdata.Add( data [ i ] );
                    }

                }

            }

        }
    }
}
