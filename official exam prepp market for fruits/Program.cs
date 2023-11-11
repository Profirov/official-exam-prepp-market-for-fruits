double strawberyPriceInLev = double.Parse(Console.ReadLine());  
double bananasInKg = double.Parse(Console.ReadLine());  
double orangeInKg = double.Parse(Console.ReadLine());
double rassberryInKg  = double.Parse(Console.ReadLine());
double strawberryInKg = double.Parse(Console.ReadLine());

double raspberryPrice = strawberyPriceInLev * 0.5;
double orangePrise = raspberryPrice - (0.4 * raspberryPrice);
double bananaPrise = raspberryPrice - (0.8 * raspberryPrice);
double sumOfRasberry = rassberryInKg * raspberryPrice;
double sumOfOrange = orangeInKg * orangePrise;
double sumOfBanana = bananasInKg * bananaPrise;
double sumOfStrawbery = strawberryInKg * strawberyPriceInLev;

double neededMoney = sumOfBanana + sumOfStrawbery + sumOfRasberry + sumOfOrange;

Console.WriteLine($"{neededMoney:F2}");