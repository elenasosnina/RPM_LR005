using ClassLibrary1;

while (true)
{
    try
    {
        Console.WriteLine("Какой класс Вы хотите создать?");
        switch (Console.ReadLine())
        {
            case "СalendarAndThematicPlan":
                UI.Print(ClassCreator.CalendarAndThematicPlan());
                break;
            default:
                Console.WriteLine("Такого класса не существует");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
