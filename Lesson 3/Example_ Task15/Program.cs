// Определить присутствует ли в заданном масссиве некоторое число

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину массива: ");
int y = int.Parse(Console.ReadLine());

void FillArray(int[] array)
{
    int l = array.Length;
    int i = 0;
while( i < l){
    array[i]= new Random().Next(-40,100);
    i++;
}
}
int []array = new int[y];
for (int d=0; d < array.Length; d++)
if (array [d] == x)
{
    Console.WriteLine($"Число {x} присутствует в массиве: ");
    
} 

 Console.WriteLine($"Число {x} не присутствует в массиве : ");
    

