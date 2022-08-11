using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
   interface ISeries    //в interface все public
    {
        void SetStart(int x);   //устанавливает начальное значение
        int GetNext();  //возвращает следующее число ряда
        void Reset();   //выполняет сброс к начальному значению

    }
}
