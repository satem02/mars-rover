using MarsRover.Console.Commands;
using System;

namespace MarsRover.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var rover = new Rover("1 2 N");

            rover.SpinLeft();

            System.Console.WriteLine(rover.direction);

            System.Console.ReadLine();
        }
    }
}
