using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Helpers
{
    public static class OrderHelpers
    {
        public static string GenerateOrderNumber()
        {
            return "AO" + DateTime.Now.ToShortTimeString();
        }
    }
}
