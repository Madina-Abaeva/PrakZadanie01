// pokazat' chetnoe chislo ot 1 do N
void evenNumbers(int N)
{
    int index = 2;
    while (index <= N)
    {

        System.Console.WriteLine(index);
        index = index + 2;

    }
}
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}
int N = GetNumber("vvedite chislo");
evenNumbers(N);
