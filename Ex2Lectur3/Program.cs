// prinimaet i vozvr 
string Method(int count,string text)
{
int i = 0;
string result = String.Empty;
while(i<count)
{ result= result + text;
i++;
}
return result;
}

string res=Method(4,"text");
Console.WriteLine(res);