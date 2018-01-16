using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareemEntities
{
    public class Vehicle
    {
        public string RegNum { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public long ImeiNum { get; set; }
        public List<string> Accessories { get; set; }
    }
}
