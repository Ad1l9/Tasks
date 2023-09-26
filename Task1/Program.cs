//Verilmiş 4 rəqəmli ədədin mərtəbələrinin cəmini (Məsələn: input 1234, output 10) tapan alqoritmi yazın.
//Butun coxreqemliler ucun kecerlidir

Console.WriteLine("Ededi daxil edin:");

int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num / 10 > 0)
{
    sum += num % 10;
    num/= 10;
}
Console.WriteLine(sum+num);
