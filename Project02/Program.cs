string words = Console.ReadLine();
Console.WriteLine(words);
string[] nums = words.Split(",");//Split разьединить через знак ","
int index = new Random().Next(0,nums.Length);
Console.WriteLine(nums[index]);
Console.WriteLine(String.Join(" ",nums));//join обьелинить через " " - пробел