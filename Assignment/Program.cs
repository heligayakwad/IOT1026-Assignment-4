using System;

namespace Assignment
{
    /// <summary>
    /// Represents a robot that can execute commands.
    /// </summary>
    public class Robot
    {
        private IRobotCommand[] _commands;
        private int _numCommands;

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with a default maximum number of commands.
        /// </summary>
        public Robot()
        {
            _commands = new IRobotCommand[10];
            _numCommands = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with the specified maximum number of commands.
        /// </summary>
        /// <param name="maxCommands">The maximum number of commands that the robot can store.</param>
        public Robot(int maxCommands)
        {
            _commands = new IRobotCommand[maxCommands];
            _numCommands = 0;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the robot is powered on.
        /// </summary>
        public bool IsPowered { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate of the robot's position.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the robot's position.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets the number of commands loaded into the robot.
        /// </summary>
        public int NumCommands
        {
            get { return _numCommands; }
        }

        /// <summary>
        /// Loads a command into the robot.
        /// </summary>
        /// <param name="command">The command to be loaded.</param>
        public void LoadCommand(IRobotCommand command)
        {
            if (_numCommands < _commands.Length)
            {
                _commands[_numCommands] = command;
                _numCommands++;
                Console.WriteLine("Command loaded: " + command.GetType().Name);
            }
            else
            {
                Console.WriteLine("Command not loaded. Maximum number of commands reached.");
            }
        }

        /// <summary>
        /// Runs all the loaded commands in sequence.
        /// </summary>
        public void Run()
        {
            for (int i = 0; i < _numCommands; i++)
            {
                _commands[i].Run(this);
            }
        }
    }
}
