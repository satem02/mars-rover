using System;

namespace MarsRover.Console.Commands
{
    public class Rover
    {
        public int x;
        public int y;
        public string direction;

        public Rover(string location)
        {
            var locations = location.Split(" ");
            Int32.TryParse(locations[0] , out x);
            Int32.TryParse(locations[1], out y);
            direction = locations[2];
        }

        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    break;
            }
        }

        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    break;
            }
        }

        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    break;
            }
        }

        public void Move(string roverCommand)
        {
            var commands = roverCommand.ToCharArray();

            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
