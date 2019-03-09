using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8
{
    public class AsyncStreams
    {
        private readonly string[] _conferences = {
            "NetWork",               
            "WinDays",               
            "Weblica",                   
            "Tarabica",              
            "NTK",                   
            "KulenDayz",             
            "MSCommunity",           
            "CrisCon",               
            "Sinergija",             
            "AdvancedTechnologyDays",
            "Thrive",                
            "SQLSaturday"            
        };

        private async IAsyncEnumerable<string> GetConferencesAsync()
        {
            foreach (var conference in _conferences)
            {
                await Task.Delay(100);
                yield return conference;
            }
        }

        public async Task WriteConferences()
        {
            await foreach (var conference in GetConferencesAsync())
            {
                Console.WriteLine(conference);
            }
        }
    }
}
