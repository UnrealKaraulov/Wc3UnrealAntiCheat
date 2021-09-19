using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace getlinescount
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            List<string> lines = new List<string>( File.ReadAllLines( "test.txt" ) );
            foreach ( string str in lines )
                Console.WriteLine( str );
            Console.WriteLine( "Lines:"+lines.Count);
            Console.ReadKey( );
        }
    }
}
