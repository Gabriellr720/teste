Console.WriteLine("_____Math_____");
Console.WriteLine("Digite um número");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while(i <= 10)
{
    Console.WriteLine(num + "x" + i + "=" + num * i);
    i++;
}