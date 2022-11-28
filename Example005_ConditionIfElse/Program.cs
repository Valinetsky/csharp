Console.Write("Input username: ");
string username = Console.ReadLine();

if (username.ToLower() == "mary")
{
	Console.WriteLine("Nice to meet you, Mary!!!");
}

if (username.ToLower() != "mary")
{
	Console.WriteLine("Hello, " + username);
}
