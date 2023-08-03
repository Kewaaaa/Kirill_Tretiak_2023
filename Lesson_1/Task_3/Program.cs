int[] nums = new int[10];
List<int> nums2 = new List<int>();
for (int i = 0;i < nums.Length; i++)
{
    Console.Write($"Enter {i+1} number: ");
    int buffer = int.Parse(Console.ReadLine());
    nums[i] = buffer;
    nums2.Add(buffer);
    nums2.Add(buffer);
}
Console.Write("List you got: ");
foreach(int i in nums)
{
    Console.Write(i+ " ");
}
Console.Write("\nList is requared: ");
foreach(int i in nums2)
{
    Console.Write(i + " ");
}