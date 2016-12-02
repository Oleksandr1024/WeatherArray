using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {

            var metaoDataArr = CreateData();

        }

        public static MetioData[][][] CreateData()
        {
            MetioData[][][] metaoDataArr = new MetioData[10][][];
            for (int y = 0; y < 10; y++)
            {
                metaoDataArr[y] = new MetioData[12][];
                for (int m = 0; m < 12; m++)
                {
                    metaoDataArr[y][m] = new MetioData[DateTime.DaysInMonth(2000 + y, m + 1)];
                    for (int d = 0; d < metaoDataArr[y][m].Length; d++)
                    {
                        metaoDataArr[y][m][d] = new MetioData();
                    }
                }
            }

            return metaoDataArr;
        }



    }




    public enum Weather { Sunny, Rain, Snow, Cloudy }
    public class MetioData
    {
        public int temp;
        public int windSpeed;
        public Weather weather;
        static Random r = new Random(1245);

        public MetioData()
        {
            temp = r.Next(-40, 45); ;
            windSpeed = r.Next(0, 100);
            weather = (Weather)r.Next(0, 3);
        }
    }



}
