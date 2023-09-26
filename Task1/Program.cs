//Verilmiş 4 rəqəmli ədədin mərtəbələrinin cəmini (Məsələn: input 1234, output 10) tapan alqoritmi yazın.
//Butun coxreqemliler ucun kecerlidir

//Console.WriteLine("Ededi daxil edin:");

//int num = int.Parse(Console.ReadLine());
//int sum = 0;

//while (num / 10 > 0)
//{
//    sum += num % 10;
//    num/= 10;
//}
//Console.WriteLine(sum+num);






//Task2
//Verilmiş 3 rəqəmli ədədin bütün mərtəbələrinin bir-birindən fərqli olub olmadığını tapan alqoritmi yazın
//(Məsələn: input 223, output "ferqli olmayan rəqəmlər var " (false) ).


Console.WriteLine("Ededi daxil edin:");

int num = int.Parse(Console.ReadLine());

if (num / 100 < 10)
{
    if (num % 10 == (num / 10) % 10 || num % 10 == num / 100 || (num / 10) % 10 == num / 100)
    {
        Console.WriteLine("ferqli olmayan reqemler var");
    }
    else Console.WriteLine("ferqlidir");
}