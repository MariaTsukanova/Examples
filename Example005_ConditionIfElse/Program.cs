Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "maria")
{
    Console.WriteLine("Hooray, it's Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}