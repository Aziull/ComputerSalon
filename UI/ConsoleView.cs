﻿using Entity;
using Entity.Abstract;
using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using UI.Abstract;

namespace UI
{
    public class ConsoleView : IView
    {
        public IController Controller { get; set; }
        public List<string> MainOptions { get; set; }
        public List<string> ConstructorOptions { get; set; }

        public ConsoleView()
        {
            MainOptions = new List<string>(3) 
            { 
                "1)Display all avaliable components.",
                "2)Lets start config your PC!!",
                "3) EXIT"
            };
            ConstructorOptions = new List<string>(2) 
            {
                "---------------------------------------INSTRUCTION-------------------------------------",
                "Type the number that identifies the component you want to select, and then press ENTER.",
            };
            
        }

        public void Start()
        {
            Console.WriteLine($"Computer Salon\n");

            while (true)
            {
                PrintMenuItems(MainOptions, "Main");
               ConsoleKey Key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (Key)
                {
                    case ConsoleKey.D1:
                        DisplayAllMenu();
                        break;
                    case ConsoleKey.D2:
                        ConfigMenu();
                        break;
                    case ConsoleKey.D3:
                        return;
                }
                Console.WriteLine();
            }
        }
        void ConfigMenu()
        {
            PrintMenuItems(ConstructorOptions, "Comfig");
            DisplayDetailsByType(DetailType.Case);
            CaseModel Case;
            ProcessorModel Processor;
            MotherboardModel Motherboard;
            MemoryCardModel MemoryCard;
            PowerSupplyModel PowerSupply;
            while (true)
            {
                Console.WriteLine("Enter Case Id:");
                int CaseId = Convert.ToInt32(Console.ReadLine());
                if (Controller.GetById(CaseId).DetailType == DetailType.Case)
                {
                    Case = (CaseModel)Controller.GetById(CaseId);
                    Console.WriteLine(Case);
                    break;
                }
                Console.WriteLine("Enter Valid Case Id!!!");


            }

            while (true)
            {
                DisplayDetailsByType(DetailType.Processor);
                Console.WriteLine("Enter Processor Id:");
                int ProcessorId = Convert.ToInt32(Console.ReadLine());
                if (Controller.GetById(ProcessorId).DetailType == DetailType.Processor)
                {
                    Processor = (ProcessorModel)Controller.GetById(ProcessorId);
                    Console.WriteLine(Processor);
                    break;
                }
                Console.WriteLine("Enter Valid Processor Id!!!");
            }

            while (true)
            {
                DisplayDetailsByType(DetailType.Motherboard);
                Console.WriteLine("Enter Motherboard Id:");
                int MotherboardId = Convert.ToInt32(Console.ReadLine());
                if (Controller.GetById(MotherboardId).DetailType == DetailType.Motherboard)
                {
                    Motherboard = (MotherboardModel)Controller.GetById(MotherboardId);
                    Console.WriteLine(Motherboard);
                    break;
                }
                Console.WriteLine("Enter Valid Motherboard Id!!!");
            }

            while (true)
            {
                DisplayDetailsByType(DetailType.MemoryCard);
                Console.WriteLine("Enter Memory Card Id:");
                int MemoryCardId = Convert.ToInt32(Console.ReadLine());
                if (Controller.GetById(MemoryCardId).DetailType == DetailType.MemoryCard)
                {
                    MemoryCard = (MemoryCardModel)Controller.GetById(MemoryCardId);
                    Console.WriteLine(MemoryCard);
                    break;
                }
                Console.WriteLine("Enter Valid Memory Card Id!!!");

            }

            while (true)
            {
                DisplayDetailsByType(DetailType.PowerSupply);
                Console.WriteLine("Enter Power Supply Id:");
                int PowerSupplyId = Convert.ToInt32(Console.ReadLine());
                if (Controller.GetById(PowerSupplyId).DetailType == DetailType.PowerSupply)
                {
                    PowerSupply = (PowerSupplyModel)Controller.GetById(PowerSupplyId);
                    Console.WriteLine(PowerSupply);
                    break;
                }
                Console.WriteLine("Enter Valid Power Supply Id!!!");

            }


            if (Controller.IsPossibleToCreate(Case,Processor,Motherboard,MemoryCard, PowerSupply))
            {
                Console.WriteLine("Your PC is possible to create!!!");
            }
            else
            {
                Console.WriteLine("Sorry but your choise is imposible");
            }

            
        }
       /* public void DisplayCases(List<CaseModel> cases)
        {
            Console.WriteLine("Cases:");

            Controller.GetDetailByType(DetailType.Case).ForEach(Console.WriteLine);
            Console.WriteLine();
        }
        public void DisplayMemoryCars(List<MemoryCardModel> memoryCards)
        {

            Console.WriteLine("Memory Cards:");
            foreach (var item in memoryCards)
            {
                Console.WriteLine($"Id: {item.Id} | " +
                                  $"Name: {item.Name} | " +
                                  $"Price: {item.Price} | " +
                                  $"Memory card type: {item.MemoryCardType} | " +
                                  $"Wattage: {item.Wattage}");
            }
            Console.WriteLine();
        }
        public void DisplayMotherboards(List<MotherboardModel> motherboards)
        {

            Console.WriteLine("Motherboards:");
            foreach (var item in motherboards)
            {
                Console.WriteLine($"Id: {item.Id} | " +
                                  $"Name: {item.Name} | " +
                                  $"Price: {item.Price} " +
                                  $"| Memory card type: {item.MotherboardType} | \n" +
                                  $"Memory card compatibility: {item.MemoryCardTypeCompatibility} | " +
                                  $"Socket compatibility: {item.SocketTypeCompatibility}");
            }
            Console.WriteLine();
        }
        public void DisplayPowerSupplies(List<PowerSupplyModel> powerSupplies)
        {

            Console.WriteLine("Power Supplies:");
            foreach (var item in powerSupplies)
            {
                Console.WriteLine($"Id: {item.Id} | " +
                                  $"Name: {item.Name} | " +
                                  $"Price: {item.Price} " +
                                  $"| Wattage: {item.Wattage} | " +
                                  $"Power supply type: {item.PowerSupplyType}");
            }
            Console.WriteLine();
        }
        public void DisplayProcessors(List<ProcessorModel> processors)
        {

            Console.WriteLine("Processors:");
            foreach (var item in processors)
            {
                Console.WriteLine($"Id: {item.Id} | " +
                                   $"Name: {item.Name} | " +
                                   $"Price: {item.Price} " +
                                   $"| Wattage: {item.Wattage} | " +
                                   $"Socket type: {item.SocketType}");
            }
            Console.WriteLine();
        }*/
       
        void DisplayAllMenu()
        {
            PrintMenuItems(new List<string>(), "Available Components");

            #region 
            /*DisplayCases(Controller.GetAllCases());
            DisplayMemoryCars(Controller.GetAllMemoryCards());
            DisplayMotherboards(Controller.GetAllMotherboards());
            DisplayPowerSupplies(Controller.GetAllPowerSupplies());
            DisplayProcessors(Controller.GetAllProcessors());*/
            #endregion
            DisplayDetails(Controller.GetAllDetail());
        }

       
        public void DisplayDetailsByType( DetailType type)
        {
            Console.WriteLine($"{type}:");
            foreach (var item in Controller.GetDetailByType(type))
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
        }
        public void DisplayDetails(List<BaseModel> detail)
        {

            Console.WriteLine("All:");
            foreach (var item in detail)
            {
                Console.WriteLine(item);
                                   
            }
            Console.WriteLine();
        }

        private void PrintMenuItems(List<string> items, string menuTitle)
        {
            Console.WriteLine($"---------{menuTitle} Menu-------");
            items.ForEach(Console.WriteLine);
        }
    }
}
