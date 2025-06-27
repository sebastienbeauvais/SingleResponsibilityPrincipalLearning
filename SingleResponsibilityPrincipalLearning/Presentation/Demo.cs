using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibilityPrincipalLearning.Business.Car;
using SingleResponsibilityPrincipalLearning.Business.Interfaces;

namespace SingleResponsibilityPrincipalLearning.Presentation
{
    public class Demo
    {
        private readonly IBadCar _badCar;
        private readonly GoodCar _goodCar;
        public Demo(IBadCar badCar, GoodCar goodCar)
        {
            _badCar = badCar;
            _goodCar = goodCar;
        }
        public void Run()
        {
            ShowIntro();
            ShowMenuOptions();
            var userInput = Console.ReadLine();
            while (userInput != "3")
            {
                switch (userInput)
                {
                    case "1":
                        _badCar.ExecuteBadCarImplementation();
                        break;
                    case "2":
                        _goodCar.ExecuteGoodCarImplementation();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                ShowMenuOptions();
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Exiting the program. Thank you for using the Single Responsibility Principle demo!");
        }
        private void ShowMenuOptions()
        {
            Console.WriteLine("\nPlease select from the following options:\n");
            Console.WriteLine("1. Execute the BadCar Implementation");
            Console.WriteLine("2. Execute the GoodCar Implementation");
            Console.WriteLine("3. Exit the program");
        }
        private void ShowIntro()
        {
            Console.WriteLine("##############################################################################################");
            Console.WriteLine("The following program was created to demonstrate the Single Responsibility Principle (SRP).\n");
            Console.WriteLine("The Single Responsibility Principle states that a class should have only one reason to change, meaning it should only have one job or responsibility.\n");
            Console.WriteLine("Ideally you should run each example in this program. On the surface they may return similar results, but the underlying code is vastly different.\n");
            Console.WriteLine("Set some debugging points in the code and observe the control flow. Notice the difference between the GoodCar implementation and the BadCar implementation.\n");
            Console.WriteLine("##############################################################################################");
        }
    }
}
