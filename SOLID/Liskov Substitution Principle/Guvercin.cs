using System;

namespace Guvercin
{
    public class Guvercin:IYuruyenler,IUcanlar
    {
        public string Yuru()
        {
            return "yürüdü";
        }
        public string Uc()
        {
            return "uçtu";
        }
    }
}