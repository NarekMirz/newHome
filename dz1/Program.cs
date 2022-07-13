// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.Write("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine(" ");

int index = 0;
char simvol;
int element;
int sum = 0;

while (index < number.Length)
{
    simvol = number[index];
    element = (int)Char.GetNumericValue(simvol);
    sum = sum + element;
    index++;
 
}

Console.WriteLine("Сумма цифр: " + sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = new int[8];

void CreatArray(int[] collection)
{
    int lenth = 8;  
    int index = 0;

    while (index < lenth)
    {
        array[index] = new Random().Next(1, 1000);
        index++;
    } 
}

void PrintArray(int[] arrayPrint)
{
    int lenth = 8;    
    int index = 0;
    while (index < lenth)
    {
        if (index == 0)
        {
            Console.Write("[");
        }

        Console.Write(arrayPrint[index]);
        if (index < lenth - 1) 
        {
            Console.Write(", ");
        }

        if (index == lenth - 1)
        {
            Console.Write("]");
        }
        index++;
    }
}

CreatArray(array);
PrintArray(array);*/