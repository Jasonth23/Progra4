using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra4.AW.Products.Model
{
    public partial class Product
    {
        public float SizeInInches { get {
                float elResultado = 0;
                if (SizeUnitMeasureCode != null && SizeUnitMeasureCode == "CM")
                {
                    
                    float tamanoFloat = 0;
                    float.TryParse(Size, out tamanoFloat);
                    elResultado = tamanoFloat / (float)2.54;
                   
                    

                }
                return elResultado;
            } set { }
        }

    }
}
