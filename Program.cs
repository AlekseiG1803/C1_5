Console.WriteLine("Ты кто?");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
    {
        Console.WriteLine("Привет, дорогая!");
    }
else
    {
        Console.Write("Здравствуйте, ");
        Console.WriteLine(username);
    }