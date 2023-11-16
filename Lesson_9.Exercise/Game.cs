using System;

namespace Lesson_9.Exercise
{
    class Game
    {
        public string NameOfgame { get; }

        public Game(string name)
        {
            NameOfgame = name;
        }

        public void Play(Team team)
        {
            Console.WriteLine($"{team.NameOfCountry} играет в *{NameOfgame}*");
        }
    }
}
