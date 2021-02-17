using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class UsefullStrings
    {
        public static String GetString()
        {
            return "server=<SQLLOCALSERVERNAME>; initial catalog=soe; user id=<USERNAME>; password=<PASSWORD>";
        }

        public static String ErrorString()
        {
            return "An error has occurred at the database...\nMake sure that you haven't entered any invalid data..." +
                "\n\nDetails below :\n";
        }
    }
}
