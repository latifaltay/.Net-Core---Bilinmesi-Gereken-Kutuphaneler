// See https://aka.ms/new-console-template for more information




using Solid.App.DIPGoodAndBad;
using Solid.App.SRP.Bad;

Console.WriteLine("Hello, World!");


// OPEN CLOSED PRINCIPLE

//SalaryCalculator salaryCalculator = new SalaryCalculator();

// OCP Bad way

//using Solid.App.OCPBad;

//Console.WriteLine($"Low Salary : { salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle Salary : { salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High Salary : { salaryCalculator.Calculate(1000, SalaryType.High)}");

//Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, SalaryType.High)}");


// OCP Good way 1

//using Solid.App.OCPGood;

//Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, new MediumSalaryCalculate())}");
//Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager Salary : {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");


// OCP Good way 2

//using Solid.App.OCPGood2;

//Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, new MediumSalaryCalculate().Calculate)}");
//Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
//Console.WriteLine($"Manager Salary : {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");


//Console.WriteLine($"Custom Salary : {salaryCalculator.Calculate(1000, x => 
//{
//    return x * 10;
//} )}");



// Liskov Substitution Principle

//using static Solid.App.LSPBad.LSPBad;

// LSP Bad Example 1

//BasePhone Phone;

//var i = 2;

//if (i == 1)
//{
//    Phone = new IPhone();
//}
//else
//{
//    Phone = new Nokia3310();
//}

//Phone.Call();
//Phone.TakePhoto();





// LSP Bad Example 2

//BasePhone Phone = new IPhone();

//Phone.Call();
//Phone.TakePhoto();

//Phone = new Nokia3310();

//Phone.Call();
//Phone.TakePhoto();



// LSP Good Example 

//using Solid.App.LSPGood;
//using static Solid.App.LSPGood.LSPGood;

//BasePhone phone = new IPhone();

//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia3310();

//phone.Call();


// DIP 

var ProductService = new ProductService(new ProductRepositoryFromOracleServer());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));