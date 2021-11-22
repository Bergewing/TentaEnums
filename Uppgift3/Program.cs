using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Avatar avatar1 = new Avatar();
            Avatar avatar2 = new Avatar();

            while (true)
            {
                Direction direction = GetDirection();
                avatar1.Move(direction);
                Direction randomDirection = GetRandomDirection();
                avatar2.Move(randomDirection);

                Console.WriteLine($"Avatar1: {avatar1}");
                Console.WriteLine($"Avatar2: {avatar2}");
            }
        }

        static Direction GetDirection()
        {
            string direction = Console.ReadLine().ToLower();
            switch (direction)
            {
                case "north":
                    return Direction.North;
                case "south":
                    return Direction.South;
                case "west":
                    return Direction.West;
                case "east":
                    return Direction.East;
                default:
                    return Direction.None;
            }
                
        }

        static Direction GetRandomDirection()
        {
            //string[] directions = new string[]
            //{
            //    "north",
            //    "south",
            //    "west",
            //    "east"
            //};
            int value = new Random().Next(0, 4);
            return (Direction)value;
        }
    }
}
