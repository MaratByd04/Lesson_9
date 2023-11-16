using System;
using System.Collections.Generic;

namespace Lesson_9.Exercise
{
    class BigRace
    {
        private List<Team> teams;
        private List<Game> games;

        public BigRace(List<Team> teams)
        {
            this.teams = teams;

            games = new List<Game>
            {
                new Game("Пляж"),
                new Game("Мышеловка"),
                new Game("Море"),
                new Game("Рыбалка"),
                new Game("Почтальоны"),
                new Game("Горка")
            };
        }

        public void RunRace()
        {
            foreach (Game game in games)
            {
                foreach (Team team in teams)
                {
                    team.PlayTheGame(game);                   
                }
                Console.WriteLine();
            }
        }
    }
}

