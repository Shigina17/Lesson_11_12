using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesoon_11_12
{
    class Building
    {
        public static int CountOfBuilding = 0;
        public int ID { get; set; } = 156737; // первый id
        private double height;
        public double Height
        {
            get { return height; }
            set
            {

                if (value < 3)
                {
                    Console.WriteLine("Ошибка, высота здания > 3 метров");
                }
                else
                {
                    height = value;
                }

            }
        }
        public int NumOfStoreys { get; set; }
        public int NumOfFlats { get; set; }
        public int NumOfEntrance { get; set; }

        public double GetHeightOfStory()
        {
            return Height / NumOfStoreys;
        }
        public double GetAverageCountFlatsInEntrance()
        {
            return (double)NumOfFlats / NumOfEntrance;
        }
        public double GetAverageCountFlatsOnStorey()
        {
            return (double)NumOfFlats / NumOfStoreys;
        }
        public Building()
        {
            ID += CountOfBuilding;
            CountOfBuilding++;
        }
        internal Building(double height, int numStoreys, int numEntrance, int numFlats) : this()
        {
            Height = height;
            NumOfEntrance = numEntrance;
            NumOfStoreys = numStoreys;
            NumOfFlats = numFlats;
        }
        public override string ToString()
        {
            return $"Высота: {Height}, Количесвто этажей: {NumOfStoreys}, Количество подъездов: {NumOfEntrance}, Количество квартир: {NumOfFlats}";
        }
    }
}
