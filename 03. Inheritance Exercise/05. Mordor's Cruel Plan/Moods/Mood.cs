
namespace MordorsCruelPlan.Moods
{
    public class Mood
    {
        public Mood(string moodName)
        {
            this.Name = moodName;
        }

        public string  Name { get; private set; }
    }
}
