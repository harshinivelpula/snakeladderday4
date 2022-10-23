using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladderd4
{
    internal class rolldie
    {
        public int RollDie()
        {
            
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        
    }
}
