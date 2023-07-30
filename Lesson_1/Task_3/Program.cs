int[] nums = new int[10];

for (int i = 0;i < nums.Length; i++)
{
    Console.Write($"Enter {i+1} number: ");
    int buffer = int.Parse(Console.ReadLine());
    nums[i] = buffer;
    
}
Console.Write("Your list - ");
for (int j = 0; j < nums.Length; j++)
{
    Console.Write(nums[j]+" ");
}
Console.Write("\nList that is requared - ");
for (int k = 0; k < nums.Length; k++)
{
    Console.Write(nums[k]+ " " + nums[k]+" ");
}
