Console.Write("Tap username:");
string username = Console.ReadLine();

if (username.ToLower() == "maria")
{
    Console.WriteLine("Wonderful!");
}
else
{
    Console.Write("Hellow, ");
    Console.WriteLine(username);
}