using NeptuneLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    class Fly
    {
        public string FlyID { get; set; }
        public string FlyName { get; set; }
        public FlyPatternClass FlyPattern { get; set; }
        public decimal FlyPrice { get; set; }
        public DateTime FlyAdditionDate { get; set; }
        public Worker FlyAddedBy { get; set; }
        public DateTime FlyUpdateDate { get; set; }
        public Worker FlyLastUpdatedBy { get; set; }
        public List<Material> FlyMaterials { get; set; }
        public string Display
        {
            get
            {
                return $"{FlyID}, {FlyName} - {FlyPattern}";
            }
        }
    }
}