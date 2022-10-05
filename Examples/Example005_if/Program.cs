Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Приветули ЕПТ!");
}
else
{
    Console.Write("Приветули, ");
    Console.WriteLine(username);
}