using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace ConvertCodeToMyProjectFinder
{
    class Program
    {
        static void Main ( string [ ] args )
        {



            string curdir = Directory.GetCurrentDirectory( );
            string [ ] data = File.ReadAllLines( "data.txt" );
            // Перебираем все текстовые файлы 
            foreach ( string file in Directory.GetFiles( curdir , "*.txt" ) )
            {
                //кроме data
                if ( file.IndexOf( "data" ) > -1 )
                    continue;

                // Список строк входного файла
                string [ ] inputstrlist = File.ReadAllLines( file );
                // Список строк выходного файла
                List<string> outputstrlist = new List<string>( );


                // 
                string regextest1 = @"^\s*$";
                string regextest2 = @"^\s*//";



                // перебираем строки входного файла    
                for ( int i = 0 ; i < inputstrlist.Length ; i++ )
                {
                    //если пустая строка то пропуск
                    if ( Regex.Match( inputstrlist [ i ] , regextest1 ).Success || Regex.Match( inputstrlist [ i ] , regextest2 ).Success )
                        continue;


                    // перебираем данные. если есть совпадение то однократно подменить
                    for ( int n = 0 ; n < data.Length ; n++ )
                    {

                       if ( inputstrlist [ i ].IndexOf( data [ n ] , StringComparison.Ordinal ) > -1 )
                        {
                            string checkifok = @"\W" + data [ n ] + @"\W";
                            if ( Regex.Match( inputstrlist [ i ] , checkifok ).Success )
                                outputstrlist.Add( data [ n ] );
                            else
                            {
                                checkifok = @"^\s*" + data [ n ];
                                if ( Regex.Match( inputstrlist [ i ] , checkifok ).Success )
                                    outputstrlist.Add( data [ n ] );
                                else
                                {
                                    checkifok = data [ n ] +@"\s*$";
                                    if ( Regex.Match( inputstrlist [ i ] , checkifok ).Success )
                                        outputstrlist.Add( data [ n ] );
                                    else
                                        continue;
                                }

                            }

                            goto nexttime;
                       }
                    }

                    Console.WriteLine( "Warning input text manually:" );
                    Console.WriteLine( inputstrlist [ i ] );
                    string okaystr = Console.ReadLine( );



                    if ( okaystr == "skip" )
                        goto skipskip;



                    outputstrlist.Add( okaystr );
nexttime:
                    continue;
                }

                File.WriteAllLines( file , outputstrlist.ToArray( ) );
skipskip:
                continue;
            }

        }
    }
}
