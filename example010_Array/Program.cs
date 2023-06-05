
int Max(int arq1, int arq2, int arq3)// метод для нахождения Макс из 3х чисел
{
    int result = arq1;
    if (arq2 > result) result = arq2;
    if (arq3 >result) result = arq3;
    return result;
}

void FillArray(int [] array)// создание массива, заполнение его числами
{
    int size = array.Length; 
    int index = 0;
    while (index < size )
    {
        array[index] = new Random().Next(1, 10); // рандом из случ.числе от 1 до 10
        index++;
    }

}

void PrintArray(int [] array) // метод вывода в консоль/терминал массива 
{
    int size = array.Length; 
    int index = 0;
    while (index < size )
    {
        Console.WriteLine($"{array[index]} ");
        index++;
    }

}

int IndexOF(int [] array, int pos) // Метод нахождения нужного элемента массива
{
    int size = array.Length; 
    int index = 0;
    int position = 0;
    while (index < size )
    {
        if(array[index] == pos)
        {
            position = index;
            break;
        }
        index++;   
    }
    return position;
}



Console.Clear();
int [] array = new int[10];
FillArray(array);
Console.WriteLine($"бугага" );
PrintArray(array);

int pos = IndexOF(array, 7); // тут мы указываем искомую цифру
Console.WriteLine($"искомая цифра находиться под индексом {pos}");

