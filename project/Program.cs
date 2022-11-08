
string [] array = {"Привет", "друзья", "как", "ваши", "дела", "?"};
int n = 0;                                                                                    
                                                 
int indexRecNewArray = 0;

for (int i = 0; i < array.Length; i++) // определяет размер нового массива;
{
    if (array[i].Length <= 3)
    {
        n ++;
    }
}
string [] newArray = new string[n];

for (int i = 0; i < array.Length; i++) // печать newArray;
{
    if (array[i].Length <= 3)
    {
        newArray[indexRecNewArray] = array[i];
        indexRecNewArray ++; 
    }
}

Console.WriteLine($"[{string.Join(", ", newArray)}]");

