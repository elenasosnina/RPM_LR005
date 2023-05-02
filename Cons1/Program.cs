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
            case "Material":
                UI.Print(ClassCreator.Material());
                break;
            case "Speciality":
                UI.Print(ClassCreator.Speciality());
                break;
            case "Pair":
                UI.Print(ClassCreator.Pair());
                break;
            case "Corpus":
                UI.Print(ClassCreator.Corpus());
                break;
            case "Competence":
                UI.Print(ClassCreator.Competence());
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
