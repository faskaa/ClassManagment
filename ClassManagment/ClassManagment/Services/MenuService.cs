using ClassManagment.Data.Models;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassManagment.Services
{
    internal class MenuService
    {
        private static ClassroomService classroomService = new();
        
        public static void MenuAddClasroom ()
        {
            try
            {
                Console.WriteLine("Enter classroom's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter classroom's subject:");
                string subject = Console.ReadLine()!;

                int classRoomId = classroomService.AddClassroom(name, subject);

                Console.WriteLine($"Classroom with ID:{classRoomId} was created!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteClassroom(id);

                Console.WriteLine($"Classroom with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowClassrooms()
        {
            var table = new ConsoleTable("ID","Name","Subject");

            foreach (var classroom in classroomService.ShowClassrooms())
            {
                table.AddRow(classroom.Id, classroom.Name, classroom.Subject);
            }

            table.Write();
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine()!;

                Console.WriteLine("Enter student's birthday (MM/dd/yyyy):");
                DateOnly birthday = DateOnly.Parse(Console.ReadLine()!);

                int studentId = classroomService.AddStudent(name, surname, birthday);

                Console.WriteLine($"Student with ID:{studentId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteStudent()
        {
            try
            {
                Console.WriteLine("Enter students's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteStudent(id);

                Console.WriteLine($"Student with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowStudents()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Birthday");

            foreach (var student in classroomService.ShowStudents())
            {
                table.AddRow(student.Id, student.Name, student.Surname, student.Birthday);
            }

            table.Write();
        }

        public static void MenuUpdateClassroom()
        {
            try
            {
                Console.WriteLine("Enter Id");
                int id = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter new name");
                String newName = Console.ReadLine()!;
                Console.WriteLine("Enter new subject");
                String newSubject = Console.ReadLine()!;
                var updatedclassroom = new Classroom()
                {
                    Name = newName,
                    Subject = newSubject,
                };
                classroomService.UpdateClasroom(id, newName, newSubject);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }


        }
        public static void MenuUpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter ID");
                int id = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter new name");
                String newName = Console.ReadLine()!;
                Console.WriteLine("Enter new surname");
                String newSurname = Console.ReadLine()!;
                Console.WriteLine("Enter new birthday");
                DateOnly newDate = DateOnly.Parse(Console.ReadLine()!);

                var updatedstudent = new Student()
                {
                    Name = newName,
                    Surname = newSurname,
                    Birthday = newDate
                };

                classroomService.UpdateStudent(id, newName, newSurname, newDate);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
