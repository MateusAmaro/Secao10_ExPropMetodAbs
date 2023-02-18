using ExPropMetodAbs.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"\nTax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    switch (type)
    {
        case 'i':
            Console.Write("Health expenditures: ");
            double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new Individual(name, anualIncome, healthExpenditures));
            break;
        
        case 'c':
            Console.Write("Number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            list.Add(new Company(name, anualIncome, numberOfEmployees));
            break;
    }
}

double sum = 0.0;

Console.WriteLine("\nTAXES PAID:");
foreach (var c in list)
{
    Console.WriteLine(c.Name + ": $" + c.Tax().ToString("F2", CultureInfo.InvariantCulture));
    sum += c.Tax();
}

Console.WriteLine("\nTOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));