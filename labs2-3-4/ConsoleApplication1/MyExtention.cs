using System;


namespace Intelect
{
    public static class StringExtension
    {
        public static  double getIntelect(this HomoSapiens human)
        {
            return human.getSoshialSkills() * 2;
        }
    }
}