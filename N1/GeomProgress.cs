using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class GeomProgress : ISeries

    {
        int step;
        int startValue;
        int currentValue;
       
        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(int s)
        {
            step = s;
        }
    }
}