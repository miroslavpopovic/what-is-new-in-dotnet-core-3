using System;
using System.Reflection.Metadata.Ecma335;

namespace CSharp8
{
    public class SwitchExpressions
    {
        public enum Conference
        {
            NetWork,
            WinDays,
            Weblica,
            Tarabica,
            NTK,
            KulenDayz,
            MSCommunity,
            CrisCon,
            Sinergija,
            AdvancedTechnologyDays,
            Thrive,
            SqlSaturday
        };

        public static string GetConferenceMonth(Conference conference) =>
            conference switch
            {
                Conference.NetWork => "March",
                Conference.WinDays => "April",
                Conference.Weblica => "May",
                Conference.Tarabica => "May",
                Conference.NTK => "May",
                Conference.KulenDayz => "August",
                Conference.MSCommunity => "September",
                Conference.CrisCon => "October",
                Conference.Sinergija => "October",
                Conference.Thrive => "November",
                Conference.AdvancedTechnologyDays => "December",
                Conference.SqlSaturday => "December",
                _ => throw new ArgumentException("Invalid conference")
            };

        public static string GetConferenceMonthOld(Conference conference)
        {
            switch (conference)
            {
                case Conference.NetWork:
                    return "March";
                case Conference.WinDays:
                    return "April";
                case Conference.Weblica:
                case Conference.Tarabica:
                case Conference.NTK:
                    return "May";
                case Conference.KulenDayz:
                    return "August";
                case Conference.MSCommunity:
                    return "September";
                case Conference.CrisCon:
                case Conference.Sinergija:
                    return "October";
                case Conference.Thrive:
                    return "November";
                case Conference.AdvancedTechnologyDays:
                case Conference.SqlSaturday:
                    return "December";
                default:
                    throw new ArgumentException("Invalid conference");
            }
        }
    }
}
