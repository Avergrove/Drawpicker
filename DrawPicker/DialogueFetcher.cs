using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{
    class DialogueFetcher
    {
        public static String GetText(String key)
        {
            if (key.Equals("intro"))
            {
                return $@"

====================================================
|                                                    
|    Draw Picker                                     
|    Written by Avergrove, please send any feedback
|    to Avergrove@gmail.com, thank you!
|                                                   
=====================================================
            ";
            }

            else if (key.Equals("help"))
            {
                return $@"Help Commands:
    add [name]: Adds a person's name into the list
    roll: Generates a list of artists and targets pairs to draw
    
    dick size: Generates a list of everyone's dick size in ASCII length. Because we're big scary adults.
    help: You need this.
    
    exit: Closes the software.
";
            }

            return "";
        }
    }
}
