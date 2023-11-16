
namespace Lesson_9.Exercise
{
    class Team
    {
        public string NameOfCountry { get; }
        public int Members { get; }

        public Team(string name, int members)
        {
            NameOfCountry = name;
            Members = members;
        }

        public void PlayTheGame(Game game)
        {
            game.Play(this);
        }
    }
}
