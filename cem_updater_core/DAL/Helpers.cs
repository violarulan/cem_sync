﻿using System;

namespace cem_updater_core.DAL
{
    public class Helpers
    {
        public static int ConvertRange(string range)
        {
            if (Int32.TryParse(range, out var r))
            {
                return r;
            }
            switch (range)
            {
                case "station": return 0;
                case "solarsystem": return 32767;
                case "region": return 65535;
                default: return 65535;
            }
        }

        public  static string GetMarketConnString(bool tq = false)
        {
            return tq ? connectionstring_market_tq : connectionstring_market_cn;
        }

        public static string GetKBConnString(bool tq = false)
        {
            return tq ? connectionstring_kb_tq : connectionstring_kb_cn;
        }

        public static string connectionstring_market_cn;
        public static string connectionstring_market_tq;
        public static string connectionstring_kb_cn;
        public static string connectionstring_kb_tq;
    }
}