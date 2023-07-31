Console.Write("Input first string: ");
string string1 = Console.ReadLine();
Console.Write("Input second string: ");
string string2 = Console.ReadLine();

if (string1.Length > string2.Length)
{
    string result = string1 + string2;
    Console.WriteLine(result);
}else if (string1.Length < string2.Length)
{
    string[] result = string1.Split(string2[0]);
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
    }

}
else
{
    Console.WriteLine("*some void*");
}