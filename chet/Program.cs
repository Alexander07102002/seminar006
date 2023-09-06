/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

void FillArray (int[] collection) {
    int lenth = collection.Length;
    for (int count = 0; count<lenth; count++) {
        collection[count]=int.Parse(Console.ReadLine());
    }
}

void PrintArray (int[] col) {
    int len = col.Length;
    for (int index =0;index<len;index++) {
        Console.WriteLine(col[index]);
    }
}

Console.WriteLine("Сколько нужно значений?");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значения");
int[] array = new int[k];

FillArray(array);
Console.WriteLine("Данные :");
PrintArray(array);
Console.WriteLine();


int chet (int[] arr) {
    int le = arr.Length;
    int i = 0;
    int k = 0;
    while (i<le) {
        if (arr[i]%2==0 ) {
            k++;
        }
        i++;
    }
    return k;
}

int sum = chet(array);
Console.WriteLine(sum);

