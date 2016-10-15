using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loduApp.Models
{
    public class LudoModel
    {


    }

    public class Set
    {
        public Set(Color color,string user)
        {
            User = user;
            Points = 0;
            First.Color = color;
            Second.Color = color;
            Third.Color = color;
            Fourth.Color = color;

        }
        public int Points { get; set; }
        public string User { get; set; }
        public Place First { get; set; }
        public Place Second { get; set; }
        public Place Third { get; set; }
        public Place Fourth { get; set; }
    }

    public class Place
    {
        public Place()
        {
            Position = 0;
        }
        public int Position { get; set; }
        public Color Color { get; set; }

        public bool Equal(Place opp)
        {
            int displaced = (opp.Position-Displace(this.Color,opp.Color));
            if (this.Color == opp.Color)
                return false;
            if (IsOnStar(opp))
                return false;
             //ToDo: checking code
            return displaced==this.Position;
        }
        public int Displace(Color to,Color From)
        {
           
            switch (to)
            {
                case Color.Red:
                    switch (From)
                    {
                        case Color.Red:
                            return 0;
                        case Color.Green:
                            return -13;
                        case Color.Yellow:
                            return -(13 * 2);
                            
                        case Color.Blue:
                            return -(13 * 3);
                           
                        default:
                            return 0;
                    }
                    
                case Color.Green:
                    switch (From)
                    {
                        case Color.Red:
                            return 13;
                        case Color.Green:
                            return 0;
                        case Color.Yellow:
                            return -(13 * 1);

                        case Color.Blue:
                            return -(13 * 2);

                        default:
                            return 0;
                    }
                case Color.Yellow:
                    switch (From)
                    {
                        case Color.Red:
                            return +(13*2);
                        case Color.Green:
                            return +(13 * 1);
                        case Color.Yellow:
                            return 0;

                        case Color.Blue:
                            return -(13);

                        default:
                            return 0;
                    }
                case Color.Blue:
                    switch (From)
                    {
                        case Color.Red:
                            return +(13 * 3);
                        case Color.Green:
                            return +(13 * 2);
                        case Color.Yellow:
                            return +(13);

                        case Color.Blue:
                            return 0;

                        default:
                            return 0;
                    }
                default:
                    return 0;
            }
           
        }


        public bool IsOnStar(Place opp)
        {
            if (opp.Position >= (int)Stars.HomeIn && opp.Position <= (int)Stars.Home)
                return true;
            if (opp.Position == (int)Stars.First ||
                opp.Position == (int)Stars.Second ||
                opp.Position == (int)Stars.Third ||
                opp.Position == (int)Stars.Fourth ||
                opp.Position == (int)Stars.Fifth ||
                opp.Position == (int)Stars.Sixth ||
                opp.Position == (int)Stars.Seventh)
                return true;
            return false;
        }
    }

    public enum Color
    {
        Red=1,Green=2,Yellow=3,Blue=4
    }
    public enum Stars
    {
        First = 1,
        Second = 9,
        Third = 22,
        Fourth = 27,
        Fifth = 35,
        Sixth = 40,
        Seventh = 48,
        HomeIn = 52,
        Home = 57
    }


    public class Dice
    {
        private static Random rn = new Random();
        public static int RollDice()
        {
            return rn.Next(1, 6);
        }
    }
}
