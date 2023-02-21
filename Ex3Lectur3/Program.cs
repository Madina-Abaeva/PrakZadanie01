// for
string Method(int count,string text)
{
string result=string.Empty;
for(int i=0;i < count ; i++)
{

result = result + text;

}

return result;
}
string ex = Method(4,"text");
Console.WriteLine(ex);
