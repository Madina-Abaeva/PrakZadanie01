﻿int[] array = { 11, 12, 13, 14, 15, 16, 17, 18 };
int n = array.Length;//dlina massiva

int find = 18;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;   // index + 1
}
