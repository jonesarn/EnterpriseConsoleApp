using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enterprise.Repository;

namespace Enterprise.ConsoleApp
{
    public class UserInterface
    {
        bool isRunning = true;
        EnterpriseRepository _repo = new EnterpriseRepository();
        CustomConsole _custom = new CustomConsole();
        public void Run()
        {
            while(isRunning)
            {
                _custom.PrintMainMenu();
                _custom.EnterSelection();
                string input = GetUserInput();
                UserInputSwitchCase(input);
            }
        }
        private string GetUserInput()
        {
            return Console.ReadLine();
        }
        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    CreateCar();
                    break;
                case "2":
                    ViewAllCar();
                    break;
                case "3":
                    ViewCar();
                    break;
                case "4":
                    ExitApp();
                    break;
                default:
                    break;
            }
        }
        private void CreateCar()
        {
            _custom.EnterCustomerName();
            string customerName = GetUserInput();

            _custom.EnterCarName();
            string carName = GetUserInput();

            _custom.PrintCarColor();
            _custom.EnterSelection();
            string carColorInput = GetUserInput();
            CarColor carColor = CarColor.black;
            
            switch (carColorInput)
            {
                case "1":
                    carColor = CarColor.black;
                    break;
                case "2":
                    carColor = CarColor.blue;
                    break;
                case "3":
                    carColor = CarColor.red;
                    break;
                case "4":
                    carColor = CarColor.silver;
                    break;
                case "5":
                    carColor = CarColor.white;
                    break;
                default:
                    break;
            }
        }
        private void ViewAllCar()
        {
            List<EnterpriseCars> carlist = _repo.GetAllCars();
            foreach (EnterpriseCars customer in carlist)
            {
                _custom.PrintCustomerInfo(customer);
            }
        }
        private void ViewCar()
        {

        }
        private void ExitApp()
        {
            isRunning = false;
            _custom.exitApplicationMessage();
        }
    }
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine(
                "1. Add Car\n"
                +"2.View all cars\n"
                +"3. View one car\n"
                +"4.Exit"
            );
        }
        public void EnterSelection()
        {
            Console.WriteLine("Enter Selection: ");
        }
        public void EnterCustomerName()
        {
            Console.Write("Customer Name: ");
        }
        public void EnterCarName()
        {
            Console.Write("Car Name: ");
        }
        public void PrintCarColor()
        {
            Console.WriteLine("Car Color4
                Type:\n" +
                    "1. Black\n" +
                    "2. blue\n" +
                    "3. red\n"+
                    "4.Silver\n"+
                    "5.white");
        }
        public void PrintCustomerInfo(EnterpriseCars enterpriseCars)
        {
            string isRented = $"{enterpriseCars.IsRented} is rented";
            if (enterpriseCars.IsRented == true)
            {
                Console.WriteLine($"{enterpriseCars.NameOfCustomer} has rented {enterpriseCars.Car}");
            }
        }
        public void exitApplicationMessage()
        {
            Console.Write("Press any key to leave.");
            Console.ReadKey();
        }
        
    }
}