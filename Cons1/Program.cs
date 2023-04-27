using ClassLibrary1;

while (true)
{
    try
    {
        Console.WriteLine("Какой класс Вы хотите создать?");
        switch (Console.ReadLine())
        {

            case "Auditory":
                UI.Print(ClassCreator.Auditory());
                break;

            case "Student":
                UI.Print(ClassCreator.Student());
                break;

          case "Lesson":
                UI.Print(ClassCreator.Lesson());
                break;    

            case "Group":
                UI.Print(ClassCreator.Group());
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
