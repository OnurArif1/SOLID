using System;

namespace Liskov_Substitution_Principle
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