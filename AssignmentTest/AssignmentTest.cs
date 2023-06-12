using NUnit.Framework;
using System;

namespace AssignmentTest
{
    [TestFixture]
    public class RobotTests
    {
        [Test]
        public void PowerTest()
        {
            Robot testRobot = new Robot();
            Assert.IsFalse(testRobot.IsPowered);

            testRobot.IsPowered = true;
            Assert.IsTrue(testRobot.IsPowered);

            testRobot.IsPowered = false;
            Assert.IsFalse(testRobot.IsPowered);
        }

        [Test]
        public void WestCommandTest()
        {
            Robot testRobot = new Robot();
            Assert.AreEqual(0, testRobot.X);

            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(0, testRobot.X);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(-2, testRobot.X);

            testRobot.Run();
            Assert.AreEqual(-4, testRobot.X);
        }

        [Test]
        public void EastCommandTest()
        {
            Robot testRobot = new Robot();
            Assert.AreEqual(0, testRobot.X);

            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(0, testRobot.X);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(2, testRobot.X);

            testRobot.Run();
            Assert.AreEqual(4, testRobot.X);
        }

        [Test]
        public void SouthCommandTest()
        {
            Robot testRobot = new Robot();
            Assert.AreEqual(0, testRobot.Y);

            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(0, testRobot.Y);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(-2, testRobot.Y);

            testRobot.Run();
            Assert.AreEqual(-4, testRobot.Y);
        }

        [Test]
        public void NorthCommandTest()
        {
            Robot testRobot = new Robot();
            Assert.AreEqual(0, testRobot.Y);

            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(0, testRobot.Y);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(2, testRobot.Y);

            testRobot.Run();
            Assert.AreEqual(4, testRobot.Y);
        }

        [Test]
        public void BachataCommandTest()
        {
            Robot testRobot = new Robot();
            Assert.AreEqual(0, testRobot.X);
            Assert.AreEqual(0, testRobot.Y);

            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(0, testRobot.X);
            Assert.AreEqual(0, testRobot.Y);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(-6, testRobot.X);
            Assert.AreEqual(0, testRobot.Y);
        }
    }

    public class RobotTester
    {
        public static void Main()
        {
            Robot robot = new Robot();

            Console.WriteLine("Enter commands for the robot (type 'exit' to quit):");

            string input = string.Empty;
            while (input.ToLower() != "exit")
            {
                Console.Write("> ");
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                IRobotCommand
