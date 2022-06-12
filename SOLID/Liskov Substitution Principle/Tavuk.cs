using System;

namespace Liskov_Substitution_Principle
{
    public class Tavuk:IYuruyenler
    {
        public string Yuru()
        {
                return "yürüdü";
        }
    }
}