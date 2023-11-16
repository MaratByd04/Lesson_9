using System.Collections.Generic;

namespace Lesson_9.Exercise
{
    class Program
    {
        static void Main()
        {
            Team russia = new Team("Россия", 15);
            Team france = new Team("Франция", 15);
            Team china = new Team("Китай", 15);
            Team kazakhstan = new Team("Казахстан", 15);

            List<Team> teams = new List<Team> { russia, france, china, kazakhstan };

            BigRace bigRace = new BigRace(teams);
            bigRace.RunRace();
            
        }
    }
}
