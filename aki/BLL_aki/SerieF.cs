using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_aki
{
    public class SerieF
    {
        public int[] serieF(int limite)
        {
            int[] ser = new int[limite];
            if (limite <= 1)
            {
                ser[0] = 0;
                ser[1] = 1;
                for (int i = 2; i < limite; i++)
                {
                    ser[i] = ser[i - 1] + ser[i - 2];

                }
            }
            else
            {
                ser[0] = 100;
            }
            return ser;
        }
    }
}
