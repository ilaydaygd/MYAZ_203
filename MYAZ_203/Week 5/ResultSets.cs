using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
     public  class ResultSets
    {
        public static Result Action1()
        {
            return new Successed();
        }
        public static Result Action2()
        {
            return new Successed(" İşlem başarılı tamamlandı.");
        }
        public static Result Action3()
        {
            return new Failed();
        }
        public static Result Action4()
        {
            return new Failed(" İşlem başarısız tamamlandı.");
        }
    }
}
