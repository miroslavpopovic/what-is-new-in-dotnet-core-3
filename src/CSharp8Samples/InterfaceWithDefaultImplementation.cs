using System;

namespace CSharp8
{
    public interface IConferenceSpeaker
    {
        void Speak();

        public string GetSpeakerName()
        {
            return "John Doe";
        }

        public static string GetDefaultConference()
        {
            return "Build";
        }
    }

    public class ConferenceSpeaker : IConferenceSpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Present a talk");
        }
    }
}
