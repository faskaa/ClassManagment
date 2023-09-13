using ClassManagment.Services;

namespace ClassManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedOption;

            do
            {
                Console.WriteLine("1. Add classroom");
                Console.WriteLine("2. Delete classroom");
                Console.WriteLine("3. Show classrooms");
                Console.WriteLine("4. Add student");
                Console.WriteLine("5. Delete student");
                Console.WriteLine("6. Show students");
                Console.WriteLine("7. Update classroom"); // takde id of classroom, take new name and new subject. Then update
                Console.WriteLine("8. Update student"); // // takde id of student, take new name, new surname, new birthday. Then update

                Console.WriteLine("0. Exit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please, select an option:");

                while (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("Please enter valid option:");
                }

                switch (selectedOption)
                {
                    case 1:
                        MenuService.MenuAddClasroom();
                        break;
                    case 2:
                        MenuService.MenuDeleteClassroom();
                        break;
                    case 3:
                        MenuService.MenuShowClassrooms();
                        break;
                    case 4:
                        MenuService.MenuAddStudent();
                        break;
                    case 5:
                        MenuService.MenuDeleteStudent();
                        break;
                    case 6:
                        MenuService.MenuShowStudents();
                        break;
                    case 7:
                        MenuService.MenuUpdateClassroom();
                        break;
                    case 8:
                        MenuService.MenuUpdateStudent();
                        break;
                    case 0:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }
            } while (selectedOption != 0);
        }
    }
}