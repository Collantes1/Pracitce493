using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Calculation
    {
        public Calculation() { }

        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double product = 0;
            double material = 0;
            if (count <= 0)
            {
                count = 0;
            }
            if (width <= 0)
            {
                width = 0;
            }
            if (length <= 0)
            {
                length = 0;
            }
            if (materialType > 2)
            {
                material = 0;
            }
            switch (productType)
            {
                case 0:
                    product = 0;
                    break;
                case 1:
                    product = 1.1;
                    break;
                case 2:
                    product = 2.5;
                    break;
                case 3:
                    product = 8.43;
                    break;
            }
            switch (materialType)
            {
                case 0:
                    material = 0;
                    break;
                case 1:
                    material = 0.003;
                    break;
                case 2:
                    material = 0.012;
                    break;
            }
            double MaterialQuantity = product *(1+ material) * width * length * count;
            int materialQuantity = (int)Math.Ceiling(MaterialQuantity);
            return materialQuantity;
        }
    }

}
