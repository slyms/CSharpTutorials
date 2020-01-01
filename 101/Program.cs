using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.HelloWorldMethod();

            Numbers numbers = new Numbers();
            numbers.NumbersMethod();

            BranchesAndLoops branchesAndLoops = new BranchesAndLoops();
            branchesAndLoops.BranchesAndLoopsMethod();

            ListCollections listCollections = new ListCollections();
            listCollections.ListCollectionsMethod();


            var account = new IntroductionToClasses.BankAccount("John Rockefeller", 1000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}$ initial balance");

            Console.ReadLine();

        }
    }
}
