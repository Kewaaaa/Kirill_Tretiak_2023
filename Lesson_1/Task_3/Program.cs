int[] nums = new int[10];
int[] dublicates = new int[20];
int index = 0;
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    int buffer = int.Parse(Console.ReadLine());
    nums[i] = buffer;
    dublicates[index] = nums[i];
    dublicates[index + 1] = nums[i];
    index+=2;
    
}


Console.Write("List is requared: ");
foreach(int i in dublicates)
{
    Console.Write(i+" ");
}