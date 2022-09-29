string words = Console.ReadLine();
Console.WriteLine(words);
string[] nums = words.Split(",");
int index = new Random().Next(0,nums.Length);
Console.WriteLine(nums[index]);

//случайное слово из списка(через запятую)

