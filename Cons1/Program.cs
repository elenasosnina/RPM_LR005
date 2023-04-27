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


            case "Speciality":
                UI.Print(ClassCreator.Speciality());
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
