int[] nums = new int[10];
List<int> dublicate = new List<int>();
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    int buffer = int.Parse(Console.ReadLine());
    nums[i] = buffer;  
}

Console.Write("List you got: ");
foreach(int i in nums)
{
    Console.Write(i+" ");
}
Console.Write("\nSelect the number you want to dublicate: ");
int selectedNum = int.Parse(Console.ReadLine());
for (int i = 0;i < nums.Length; i++)
{
    if (nums[i] == selectedNum)
    {
        dublicate.Add(selectedNum);
    }
    dublicate.Add(nums[i]);
}
foreach(int i in dublicate)
{
    Console.Write(i+" ");
}