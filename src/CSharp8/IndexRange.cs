using System;

namespace CSharp8
{
    public class IndexRange
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
        public void Sample()
        {
            var conferences = new[]
            {
                                             // index      from back
                "NetWork",                   // 0          ^12
                "WinDays",                   // 1          ^11
                "Weblica",                   // 2          ^10     
                "Tarabica",                  // 3          ^9
                "NTK",                       // 4          ^8
                "KulenDayz",                 // 5          ^7
                "MSCommunity",               // 6          ^6
                "CrisCon",                   // 7          ^5
                "Sinergija",                 // 8          ^4
                "AdvancedTechnologyDays",    // 9          ^3
                "Thrive",                    // 10         ^2
                "SQLSaturday"                // 11         ^1
            };

            var lastConferenceOfTheYear = conferences[^1];

            var middleYearConferences = conferences[3..7]; // 3, 4, 5, 6

            var firstThreeConferences = conferences[..3];

            var lastThreeConferences = conferences[^3..];

            Index index = ^3;
            Range range = 4..7;
        }
    }
}
