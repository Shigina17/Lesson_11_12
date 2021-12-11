using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesoon_11_12
{
    class TenBuildings
    {
        private Building[] buildings = new Building[10];
        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемент {index} - отсутствует");
                }
                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемент {index} - отсутствует");
                }
                buildings[index] = value;
            }
        }
    }
}
