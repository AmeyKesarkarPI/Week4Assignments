using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class ManufactureDate : Item
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string StringDate
        {
            get
            {
                DateTime date = new DateTime(Year,Month,1);
                return date.ToString("MMM, yyyy");
            } set
            {

            }
        }
    }
}
