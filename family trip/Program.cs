double budgetTheyHave = double.Parse(Console.ReadLine());   
int sleepNights  = int.Parse(Console.ReadLine());
double pricePerNight  = double.Parse(Console.ReadLine());
int percentExtra = int.Parse(Console.ReadLine());


double afterExtra = budgetTheyHave * percentExtra / 100;

if (sleepNights > 7)
{
    pricePerNight -= pricePerNight * 0.05;
    
}
 afterExtra += pricePerNight * sleepNights;
if (budgetTheyHave >= afterExtra)
{
    Console.WriteLine($"Ivanovi will be left with {budgetTheyHave - afterExtra:F2} leva after vacation.");
}

else
{
    
    Console.WriteLine($"{afterExtra - budgetTheyHave:F2} leva needed.");
}
