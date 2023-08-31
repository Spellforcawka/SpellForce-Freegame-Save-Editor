using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFSE
{
    internal class Experience
    {
        public static Dictionary<Byte, Int32> ForLevel = new Dictionary<Byte, Int32>()
        {
            {  1, 0       }, {  2, 30      }, {  3, 165     }, {  4, 400     }, {  5, 800     },
            {  6, 1500    }, {  7, 2500    }, {  8, 4000    }, {  9, 6000    }, { 10, 9000    },
            { 11, 13000   }, { 12, 18000   }, { 13, 24000   }, { 14, 31000   }, { 15, 39000   },
            { 16, 48000   }, { 17, 58000   }, { 18, 69000   }, { 19, 81000   }, { 20, 94000   },
            { 21, 108000  }, { 22, 123000  }, { 23, 139000  }, { 24, 156000  }, { 25, 175000  },
            { 26, 200000  }, { 27, 230000  }, { 28, 265000  }, { 29, 305000  }, { 30, 350000  },
            { 31, 400000  }, { 32, 455000  }, { 33, 515000  }, { 34, 580000  }, { 35, 650000  },
            { 36, 725000  }, { 37, 805000  }, { 38, 890000  }, { 39, 980000  }, { 40, 1075000 },
            { 41, 1175000 }, { 42, 1280000 }, { 43, 1390000 }, { 44, 1505000 }, { 45, 1625000 },
            { 46, 1880000 }, { 47, 2155000 }, { 48, 2450000 }, { 49, 2755000 }, { 50, 3070000 },
            { 51, 9999999 } // 💜
        };

        public static Byte ToPercent(Byte currentLevel, Int32 currentExp)
        {
            Int32 range = ForLevel[(byte)(currentLevel + 1)] - ForLevel[currentLevel];
            Byte result = (Byte)(100 * (currentExp - ForLevel[currentLevel]) / range);
            return result;
        }

        public static Int32 FromPercent(Byte currentLevel, Byte percent)
        {
            Int32 range = ForLevel[(byte)(currentLevel + 1)] - ForLevel[currentLevel];
            return ForLevel[currentLevel] + range * percent / 100;
        }
    }
}
