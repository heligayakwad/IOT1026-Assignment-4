using System;

namespace Assignment
{
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
            Console.WriteLine("Robot powered off");
        }
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
            Console.WriteLine("Robot powered on");
        }
    }

    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X -= 2;
                Console.WriteLine("Robot moved west");
            }
            else
            {
                Console.WriteLine("Robot is not powered. Cannot execute command.");
            }
        }
    }

    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X += 2;
                Console.WriteLine("Robot moved east");
            }
            else
            {
                Console.WriteLine("Robot is not powered. Cannot execute command.");
            }
        }
    }

    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y -= 2;
                Console.WriteLine("Robot moved south");
            }
            else
            {
                Console.WriteLine("Robot is not powered. Cannot execute command.");
            }
        }
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y += 2;
                Console.WriteLine("Robot moved north");
            }
            else
            {
                Console.WriteLine("Robot is not powered. Cannot execute command.");
            }
        }
    }
}
