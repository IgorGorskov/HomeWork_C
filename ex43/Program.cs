Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"x = {(b2 - b1)/(k1 - k2)}; y = {k1 * (b2 - b1)/(k1 - k2) + b1};");