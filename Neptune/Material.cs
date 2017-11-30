using NeptuneLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune
{
    class Material
    {
        public string MaterialID { get; set; }
        public string MaterialName { get; set; }
        public MaterialCategoryClass MaterialCategory { get; set; }
        public decimal MaterialQuantity { get; set; }
        public decimal MaterialDepletionAlert { get; set; }
        public decimal MaterialPrice { get; set; }
        public DateTime MaterialAdditionDate { get; set; }
        public Worker MaterialAddedBy { get; set; }
        public DateTime MaterialUpdateDate { get; set; }
        public Worker MaterialLastUpdatedBy { get; set; }
        public string Display
        {
            get
            {
                return String.Format("{0}, {1}", MaterialID, MaterialName);
            }
        }

        public Material()
        {
            MaterialAddedBy = new Worker();
            MaterialLastUpdatedBy = new Worker();
            MaterialCategory = new MaterialCategoryClass();
        }
    }
}
