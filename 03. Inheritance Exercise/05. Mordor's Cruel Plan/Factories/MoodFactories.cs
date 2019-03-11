
using MordorsCruelPlan.Moods;
using System;

namespace MordorsCruelPlan.Factories
{
    public class MoodFactories
    {
        public Mood CreateMood(string mood)
        {
            switch(mood.ToLower())
            {
                case "angry":
                    return new Mood("Angry");

                case "sad":
                    return new Mood("Sad");

                case "happy":
                    return new Mood("Happy");

                case "javascript":
                    return new Mood("JavaScript");

                default:
                    throw new Exception("Invalid type.");
            }
        }
    }
}
