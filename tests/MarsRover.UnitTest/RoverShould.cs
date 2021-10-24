using MarsRover.Console.Commands;
using System;
using Xunit;

namespace MarsRover.UnitTest
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {

            var rover = new Rover("1 2 N");

            rover.SpinLeft();

            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void SpinRight()
        {
            var rover = new Rover("1 2 N");

            rover.SpinRight();

            Assert.Equal("E" , rover.direction);
        }

        [Fact]
        public void StepForward()
        {
            var rover = new Rover("1 2 N");

            rover.StepForward();

            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void Move_Command_LMLMLMLMM()
        {
            var rover = new Rover("1 2 N");
            var commands = "LMLMLMLMM";
            rover.Move(commands);

            Assert.Equal("1 3 N", $"{rover.x} {rover.y} {rover.direction}");
        }

        [Fact]
        public void Move_Command_MMRMMRMRRM()
        {
            var rover = new Rover("3 3 E");
            var commands = "MMRMMRMRRM";
            rover.Move(commands);

            Assert.Equal("5 1 E", $"{rover.x} {rover.y} {rover.direction}");
        }
    }
}
