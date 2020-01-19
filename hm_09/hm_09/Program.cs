using System;

namespace hm_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityCheck securityCheck = new SecurityCheck();
            securityCheck.HelloSecurityCheck();
            securityCheck.Search();
        }
    }
}
