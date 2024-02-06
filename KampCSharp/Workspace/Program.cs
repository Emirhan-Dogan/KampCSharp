using Business.Abstract;
using Business.Conctere;
using Entities.Concrete.Customer;
using Entities.Concrete.Credit;

// Polymorphism
Customer customer1 = new Customer();
Customer customer2 = new Person();
Customer customer3 = new Company();

ICreditManager farmerCreditManager = new FarmerCreditManager();
ICreditManager carCreditManager = new CarCreditManager();

carCreditManager.ApplyForCredit(customer3);
farmerCreditManager.ApplyForCredit(customer2);

Console.WriteLine(
    carCreditManager.CalculateMonthlyPaymentAmount(
        new CarCredit() 
        {
            AnnualInterestRate = 41,
            LoanAmount = 10000,
            LoanTermMonths = 24
        }));

Console.WriteLine(
    farmerCreditManager.CalculateMonthlyPaymentAmount(
        new FarmerCredit()
        {
            AnnualInterestRate = 18,
            LoanAmount = 5000,
            LoanTermMonths = 12
        }));

Console.WriteLine(
    farmerCreditManager.CalculateMonthlyPaymentAmount(
        new FarmerCredit()
        {
            AnnualInterestRate = 18,
            LoanAmount = 5000,
            LoanTermMonths = 12,
            SeasonalPaymentDeferred = true
        }));
