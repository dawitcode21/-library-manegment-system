
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_library_manegment_system
{
     public class book
    {
       
        public int ISBN { get; set; }
        public string TITLE { get; set; }
        public string AUTHOR { get; set; }
        public int publicationdate { get; set; }
        public book()
        {

        }

        public book(int isBN, string tITLE, string aUTHOR, int publicationdate)
        {
            this.ISBN = isBN;
            this.TITLE = tITLE;
            this.AUTHOR = aUTHOR;
            this.publicationdate = publicationdate;
        }


       


        
    }


}
