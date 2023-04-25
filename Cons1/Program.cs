using ClassLibrary1;

while (true)
{
    try
    {
        Console.WriteLine("Какой класс Вы хотите создать?");
        switch (Console.ReadLine())
        {
            case "Lesson":
                UI.Print(ClassCreator.Lesson());
                break;
            case "Auditory":
                UI.Print(ClassCreator.Auditory());
                break;
            case "Group":
                UI.Print(ClassCreator.Group());
                break;
            case "Employee":
                UI.Print(ClassCreator.Employee());
                break;
            case "Discipline":
                UI.Print(ClassCreator.Discipline());
                break;
            case "Pair":
                UI.Print(ClassCreator.Pair());
                break;
            case "TypeLesson":
                UI.Print(ClassCreator.TypeLesson());
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
