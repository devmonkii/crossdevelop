using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Android.Core
{
    public class Reading
    {
        private String _category;

        public int Temperature { get; set; }

        public String Category
        {
            get
            {
                if (Temperature > 50)
                {
                    _category = "red";
                }
                else
                {
                    _category = "green";
                }
                return _category;
            }
            set { _category = value; }
        }
    }
}
