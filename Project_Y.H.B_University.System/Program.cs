using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
namespace Project_Y.H.B_University.System
{
    internal class Program
    {
        private struct Data
        {
            public string Name;
            public string ID;
            public string Email;
            public string Password;
        }
        static void Main(string[] args)
        {

            //logein
            //Home interface
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //هنا واجهة البداية مع القليل من التعديل في الالوان
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" __   __        __   __        _______                                                 \r\n|  | |  |      |  | |  |      |  _    |                                                \r\n|  |_|  |      |  |_|  |      | |_|   |                                                \r\n|       |      |       |      |       |                                                \r\n|_     _| ___  |       | ___  |  _   |                                                 \r\n  |   |  |   | |   _   ||   | | |_|   |                                                \r\n  |___|  |___| |__| |__||___| |_______|                                                 \r\n");
            Console.WriteLine(" __   __  __    _  ___   __   __  _______  ______    _______  ___   _______  __   __   \r\n|  | |  ||  |  | ||   | |  | |  ||       ||    _ |  |       ||   | |       ||  | |  |  \r\n|  | |  ||   |_| ||   | |  |_|  ||    ___||   | ||  |  _____||   | |_     _||  |_|  |  \r\n|  |_|  ||       ||   | |       ||   |___ |   |_||_ | |_____ |   |   |   |  |       |  \r\n|       ||  _    ||   | |       ||    ___||    __  ||_____  ||   |   |   |  |_     _|  \r\n|       || | |   ||   |  |     | |   |___ |   |  | | _____| ||   |   |   |    |   |    \r\n|_______||_|  |__||___|   |___|  |_______||___|  |_||_______||___|   |___|    |___|    \r\n");
            Console.Write(" _______  __   __  _______  _______  _______  __   __                                  \r\n|       ||  | |  ||       ||       ||       ||  |_|  |                                 \r\n|  _____||  |_|  ||  _____||_     _||    ___||       |                                 \r\n| |_____ |       || |_____   |   |  |   |___ |       |                                 \r\n|_____  ||_     _||_____  |  |   |  |    ___||       | Free Palestine                                \r\n _____| |  |   |   _____| |  |   |  |   |___ | ||_|| |");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" v.0.1");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("                                 \r\n|_______|  |___|  |_______|  |___|  |_______||_|   |_|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" > Team Enactus <");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nWelcome to the Y.H.B University System");
            Console.Write("Press any key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
           
            //login or register or exit or about or admin
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Admin");
            Console.WriteLine("4. About");
            Console.WriteLine("5. Exit\n");
            Console.Write("Please select an option: ");
            int VBTOM,numStudents=0,semester=0,level=0;
            int option=0;
            while (true)
            {
                option = validateInput(Console.ReadLine());
                if (option>5||option<0)
                {
                    Console.Write("Invalid option. Please enter a valid number: ");
                }
                else if (option==1||option==2||option==3||option==4||option==5)
                {
                    break;
                }
                
            }
            bool check = false;
            string[] adminusername = new string[3];
            string[] adminusername2 = new string[0];
            string[] adminpassword = new string[3];
            string[] adminpassword2 = new string[0];
            adminusername[0] = "youssef_Hy1";
            adminusername[1] = "thomas_EN";
            adminpassword[0] = "Youssef@123";
            adminpassword[1] = "Thomas@123";
            Data[] student = new Data[0];
            Data[] student2 = new Data[0];
            Console.Clear();
            switch (option)
            {
                case 1:
                    //login
                    if (student.Length != 0)
                    {
                        check = false;
                        level = 0;
                        semester = 0;

                        for (int i = 0; i < student.Length; i++)
                        {
                            Console.Write("Enter your ID: ");
                            string id = Console.ReadLine();
                            Console.Write("Enter your password: ");
                            string password = Console.ReadLine();
                            if (id == student[i].ID && password == student[i].Password)
                            {
                                Console.Clear();
                                Console.WriteLine("Login successful");
                                Console.WriteLine("Welcome " + student[i].Name);
                                check = true;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid ID or password");
                                Console.WriteLine("You have " + (2 - i) + " attempts left");
                            }
                        }
                        if (check)
                        {
                            Console.WriteLine("1.level 1");
                            Console.WriteLine("2.level 2");
                            Console.WriteLine("3.level 3");
                            Console.Write("Enter the level number for which you want materiats:");
                            while (level != 1 && level != 2 && level != 3)
                            {
                                level = validateInput(Console.ReadLine());
                                if (level != 1 && level != 2 && level != 3)
                                {
                                    Console.WriteLine("Invalid option. Please try again.");
                                }
                            }
                            Console.Clear();
                            if (level == 1)
                            {
                                Console.WriteLine("Welcome to level 1 materiats");
                                Console.WriteLine("1.First Semester");
                                Console.WriteLine("2.Second Semester");
                                Console.Write("Enter the semester number for which you want materiats:");
                                while (semester != 1 && semester != 2 && semester != 3)
                                {
                                    semester = validateInput(Console.ReadLine());
                                    if (semester != 1 && semester != 2 && semester != 3)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                showmateriatsLevel1(semester);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();


                            }
                            else if (level == 2)
                            {
                                Console.WriteLine("Welcome to level 2 resources");
                                Console.WriteLine("1.First Semester");
                                Console.WriteLine("2.Second Semester");
                                Console.Write("Enter the semester number for which you want materiats:");
                                while (semester != 1 && semester != 2 && semester != 3)
                                {
                                    semester = validateInput(Console.ReadLine());
                                    if (semester != 1 && semester != 2 && semester != 3)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                showmateriatsLevel2(semester);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (level == 3)
                            {
                                Console.WriteLine("Welcome to level 3 resources");
                                Console.WriteLine("1.First Semester");
                                Console.WriteLine("2.Second Semester");
                                Console.Write("Enter the semester number for which you want materiats:");
                                while (semester != 1 && semester != 2 && semester != 3)
                                {
                                    semester = validateInput(Console.ReadLine());
                                    if (semester != 1 && semester != 2 && semester != 3)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                showmateriatsLevel3(semester);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }
                    }
                    else
                    { 
                        Console.WriteLine("**********************************************************");
                        Console.WriteLine("No student data available. Please register first.");
                        Console.WriteLine("**********************************************************");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                    }
                   
                    VBTOM = Switch1();
                    if (VBTOM == 1) goto case 1;
                    else if (VBTOM == 2) goto case 2;
                    else if (VBTOM == 3) goto case 3;
                    else if (VBTOM == 4) goto case 4;
                    else if (VBTOM == 5) goto case 5;
                    break;
                case 2:
                    //register
                    if (student.Length == 0 )
                    {
                        student = new Data[1];
                        Console.Write("Enter student name: ");
                        student[0].Name = validateName(Console.ReadLine());
                        Console.Write("Enter student ID: ");
                        student[0].ID = Console.ReadLine();
                        Console.Write("Enter student email: ");
                        student[0].Email = validateEmail(Console.ReadLine());
                        Console.Write("Enter student password: ");
                        student[0].Password = validatePassword(Console.ReadLine());
                        Console.WriteLine("Student registered successfully.");
                    }
                    else if (student.Length != 0)
                    {
                        student2 = new Data[student.Length];
                        Array.Copy(student, student2, student.Length);
                        student = new Data[student.Length + 1];
                        Array.Copy(student2, student, student2.Length);
                        student2 = null;
                        for (int i = student.Length-1; i < student.Length; i++)
                        {
                            Console.WriteLine("Enter data for student " + (i + 1));
                            Console.Write("Enter student name: ");
                            student[i].Name = validateName(Console.ReadLine());
                            Console.Write("Enter student ID: ");
                            student[i].ID = Console.ReadLine();
                            Console.Write("Enter student email: ");
                            student[i].Email = validateEmail(Console.ReadLine());
                            Console.Write("Enter student password: ");
                            student[i].Password = validatePassword(Console.ReadLine());
                            Console.WriteLine("Student registered successfully.");
                        }
                    }
                    
                    VBTOM = Switch1();
                    if (VBTOM == 1) goto case 1;
                    else if (VBTOM == 2) goto case 2;
                    else if (VBTOM == 3) goto case 3;
                    else if (VBTOM == 4) goto case 4;
                    else if (VBTOM == 5) goto case 5;
                    break;
                case 3:
                    //admin
                    Console.Clear();
                    Console.WriteLine("welcome Admin");
                    Console.WriteLine("1. Login ");
                    Console.WriteLine("2. Register");
                    Console.Write("Please select an option: ");
                    int option1 = 0;
                    while (option1 != 1 && option1 != 2)
                    {
                        option1 = validateInput(Console.ReadLine());
                        if (option1 != 1 && option1 != 2)
                        {
                            Console.WriteLine("Invalid option. Please try again.");
                        }
                    }
                    bool isValid;
                    if (option1 == 1)
                    {
                        isValid = Access_Permission(adminusername, adminpassword);
                        if (isValid)
                        {
                            Console.Clear();
                            Console.WriteLine("***********************************************************");
                            Console.WriteLine("Welcome Admin");
                            Console.WriteLine("1. Show Student Data");
                            Console.WriteLine("2. Add some Student Data");
                            Console.Write("Please select an option: ");
                            int option2 = 0;
                            while (option2 != 1 && option2 != 2)
                            {
                                option2 = validateInput(Console.ReadLine());
                                if (option2 != 1 && option2 != 2)
                                {
                                    Console.WriteLine("Invalid option. Please try again.");
                                }
                            }
                            Console.WriteLine("***********************************************************\n\n");
                            if (option2 == 1)
                            {
                                if (student.Length != 0) 
                                {
                                    Console.WriteLine("**********************************************************");
                                    Console.WriteLine("Welcome to the student data section");
                                    Console.WriteLine("Student Data:");
                                    ShowData(student);
                                    Console.WriteLine("**********************************************************\n\n");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("**********************************************************");
                                    Console.WriteLine("No student data available.");
                                    Console.WriteLine("**********************************************************\n\n");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                }
                            }
                            else if (option2 == 2)
                            {
                                Console.WriteLine("**********************************************************");
                                Console.Write("Enter the number of additional students: ");
                                numStudents = validateInput(Console.ReadLine());
                                student2 = new Data[student.Length];
                                Array.Copy(student, student2, student.Length);
                                student = new Data[student.Length + numStudents];
                                Array.Copy(student2, student, student2.Length);
                                student2 = null;
                                for (int i = student.Length-numStudents; i < student.Length; i++)
                                {
                                    Console.WriteLine("Enter data for student " + (i + 1));
                                    Console.Write("Enter student name: ");
                                    student[i].Name = validateName(Console.ReadLine());
                                    Console.Write("Enter student ID: ");
                                    student[i].ID = Console.ReadLine();
                                    Console.Write("Enter student email: ");
                                    student[i].Email = validateEmail(Console.ReadLine());
                                    Console.Write("Enter student password: ");
                                    student[i].Password = validatePassword(Console.ReadLine());
                                    Console.WriteLine("**********************************************************");
                                }
                            }
                        }
                    }
                    else if (option1 == 2)
                    {
                        adminusername2 =new string[adminusername.Length+1];
                        Array.Copy(adminusername, adminusername2, adminusername.Length);
                        adminusername = new string[adminusername.Length + 1];
                        Array.Copy(adminusername2, adminusername, adminusername2.Length);
                        adminusername2 = null; 
                        adminpassword2 = new string[adminpassword.Length + 1];
                        Array.Copy(adminpassword, adminpassword2, adminpassword.Length);
                        adminpassword = new string[adminpassword.Length + 1];
                        Array.Copy(adminpassword2, adminpassword, adminpassword.Length);
                        adminpassword2 = null;
                        RegisterForAdmin(adminusername, adminpassword);
                        Console.Clear();
                        Console.WriteLine("New admin registered successfully.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid option");
                    }

                    VBTOM = Switch1();
                    if (VBTOM == 1) goto case 1;
                    else if (VBTOM == 2) goto case 2;
                    else if (VBTOM == 3) goto case 3;
                    else if (VBTOM == 4) goto case 4;
                    else if (VBTOM == 5) goto case 5;
                    break;
                case 4:
                    //about
                    Console.Clear();
                    Console.WriteLine("**********************************************************");
                    Console.WriteLine("Welcome to the Y.H.B University System");
                    Console.WriteLine("About the Project\n\nThis project is a university system designed to assist students and administrators in managing student data and resources.\n\n");
                    Console.WriteLine("Origin\n\nThis project was created by Youssef Harby Bayoumi\r\nIt is the final project for a training program in collaboration with the Enactus community.\n");
                    Console.WriteLine("Program Description\n\nThis system is designed to be used by both students and university administrators.\n\n•   * Administrators use the system to store and manage student data, which can be retrieved upon request.\n\n•   * Students use the program to register their information or log in to access useful resources such as book links or PDF files available within the system.\n\n");
                    Console.WriteLine("Future Goals\n\nThe developer hoped to make the system capable of saving data in a dedicated data file, but due to time constraints, this feature has not been implemented yet.\r\nTherefore, the program is still under development and not a complete version as of now.\n\n");
                    Console.WriteLine("Update History\n\n   * Project development started on April 21, 2025\n\n   * Submitted on May 1, 2025");
                    Console.WriteLine("   * Version 0.1\n\n");
                    Console.WriteLine("**********************************************************\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    VBTOM = Switch1();
                    if (VBTOM == 1) goto case 1;
                    else if (VBTOM == 2) goto case 2;
                    else if (VBTOM == 3) goto case 3;
                    else if (VBTOM == 4) goto case 4;
                    else if (VBTOM == 5) goto case 5;
                    break;
                case 5:
                    //  exit
                    Console.Clear();
                    Exit_Message();
                    break;
            }
        }
        public static int Switch1()
        {
            Console.Clear();
            int option;
            while (true)
            {
                Console.WriteLine("\n\n\n****************************************************************************************************");
                Console.WriteLine("Do you want to continue in the program ?");
                Console.WriteLine("1:YES ");
                Console.WriteLine("2:NO ");
                Console.Write("Please select an option: ");
                option = validateInput(Console.ReadLine());
                if (option == 1 || option == 2)
                    break;
                else
                    Console.WriteLine("Invalid option. Please try again.");
                Console.WriteLine("****************************************************************************************************");
            }
            if (option == 1)
            { 
                Console.Clear();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Admin");
                Console.WriteLine("4. About");
                Console.WriteLine("5. Exit\n");
                Console.Write("Please select an option: ");
                while (true)
                {
                    option = validateInput(Console.ReadLine());
                    if (option > 5 || option < 0)
                    {
                        Console.Write("Invalid option. Please enter a valid number: ");
                    }
                    else if (option == 1 || option == 2 || option == 3 || option == 4 || option == 5)
                    {
                        break;
                    }

                }
                Console.WriteLine("**********************************************************");
            }
            else 
            {
                Exit_Message();
            }
            return option;
        }
        static void Exit_Message()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n _______  __   __  _______  __    _  ___   _    __   __  _______  __   __            \r\n|       ||  | |  ||   _   ||  |  | ||   | | |  |  | |  ||       ||  | |  |           \r\n|_     _||  |_|  ||  |_|  ||   |_| ||   |_| |  |  |_|  ||   _   ||  | |  |           \r\n  |   |  |       ||       ||       ||      _|  |       ||  | |  ||  |_|  |           \r\n  |   |  |       ||       ||  _    ||     |_   |_     _||  |_|  ||       |           \r\n  |   |  |   _   ||   _   || | |   ||    _  |    |   |  |       ||       |           \r\n  |___|  |__| |__||__| |__||_|  |__||___| |_|    |___|  |_______||_______|           \r\n");
            Console.WriteLine(" _______  _______  ______      __   __  _______  ___   __    _  _______             \r\n|       ||       ||    _ |    |  | |  ||       ||   | |  |  | ||       |            \r\n|    ___||   _   ||   | ||    |  | |  ||  _____||   | |   |_| ||    ___|            \r\n|   |___ |  | |  ||   |_||_   |  |_|  || |_____ |   | |       ||   | __             \r\n|    ___||  |_|  ||    __  |  |       ||_____  ||   | |  _    ||   ||  |            \r\n|   |    |       ||   |  | |  |       | _____| ||   | | | |   ||   |_| |            \r\n|___|    |_______||___|  |_|  |_______||_______||___| |_|  |__||_______|            \r\n");
            Console.WriteLine(" _______  __   __  ______      __   __  __    _  ___   __   __  _______  ______    _______  ___   _______  __   __                                                 \r\n|       ||  | |  ||    _ |    |  | |  ||  |  | ||   | |  | |  ||       ||    _ |  |       ||   | |       ||  | |  |                                               \r\n|   _   ||  | |  ||   | ||    |  | |  ||   |_| ||   | |  |_|  ||    ___||   | ||  |  _____||   | |_     _||  |_|  |                                                \r\n|  | |  ||  |_|  ||   |_||_   |  |_|  ||       ||   | |       ||   |___ |   |_||_ | |_____ |   |   |   |  |       |                                                \r\n|  |_|  ||       ||    __  |  |       ||  _    ||   | |       ||    ___||    __  ||_____  ||   |   |   |  |_     _|                                                \r\n|       ||       ||   |  | |  |       || | |   ||   |  |     | |   |___ |   |  | | _____| ||   |   |   |    |   |                                                  \r\n|_______||_______||___|  |_|  |_______||_|  |__||___|   |___|  |_______||___|  |_||_______||___|   |___|    |___|                                                  \r\n");
            Console.WriteLine(" _______  __   __  _______  _______  _______  __   __                                \r\n|       ||  | |  ||       ||       ||       ||  |_|  |                               \r\n|  _____||  |_|  ||  _____||_     _||    ___||       |                               \r\n| |_____ |       || |_____   |   |  |   |___ |       |                               \r\n|_____  ||_     _||_____  |  |   |  |    ___||       |                               \r\n _____| |  |   |   _____| |  |   |  |   |___ | ||_|| |                               \r\n|_______|  |___|  |_______|  |___|  |_______||_|   |_|\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press any key to exit...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
        static bool Access_Permission(string [] adminusername, string[] adminpassword)
        {
            int VACCESSP = 3;
            bool isValid = false;
            string adminusername1;
            string adminpassword1;
            while (VACCESSP-- > 0)
            {
                Console.WriteLine("**********************************************************");
                Console.Write("Enter your username: ");
                adminusername1 = Console.ReadLine();
                Console.Write("Enter your password: ");
                adminpassword1 = Console.ReadLine();
                Console.WriteLine("**********************************************************\n\n");
                for (int i = 0; i < adminusername.Length; i++)
                {
                    if (adminusername1 == adminusername[i] && adminpassword1 == adminpassword[i])
                    {
                        Console.WriteLine("**********************************************************");
                        Console.WriteLine("Login successful");
                        isValid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("**********************************************************");
                        Console.WriteLine("Invalid username or password");
                        Console.WriteLine("You have " + VACCESSP + " attempts left");
                        Console.WriteLine("**********************************************************");
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }   

            }
            if (VACCESSP == 0)
            {
                Console.WriteLine("You have exceeded the maximum number of attempts");
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
            }
            return isValid;
        }
        static void ShowData(Data[] data)
        {
            foreach (Data data1 in data)
            {
                Console.WriteLine($"**********************************************************\nName:{data1.Name}\nID:{data1.ID}\nEmail:{data1.Email}\nPassword:{data1.Password}\n**********************************************************");
            }
        }
        static void RegisterForAdmin(string[] adminusername,string[] adminpassword)
        {
            Console.WriteLine("You need to enter an existing administrator account to register a new admin.");
            bool x= Access_Permission(adminusername, adminpassword);
            if (x)
            {
                
                Console.WriteLine("**********************************************************");
                Console.Write("Enter the new admin username: ");
                adminusername[adminusername.Length-1] = Console.ReadLine();
                Console.Write("Enter the new admin password: ");
                adminpassword[adminpassword.Length-1]= Console.ReadLine();
                Console.WriteLine("New admin registered successfully.");
                Console.WriteLine("**********************************************************\n");
            }
            else
            {
                Console.WriteLine("**********************************************************\n");
                Console.WriteLine("Invalid admin credentials. Registration failed.\n");
                Console.WriteLine("**********************************************************");
            }
        }
        static void showmateriatsLevel1(int semester)
        {
            string path;
            if (semester == 1)
            {
               path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 1\semester 1";
            }
            else
            {
                path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 1\semester 2";
            }
            using (var level1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var reader = new StreamReader(level1))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }
        static void showmateriatsLevel2(int semester)
        {
            string path;
            if (semester == 1)
            {
                path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 2\semester 1";
            }
            else
            {
                path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 2\semester 2";
            }
            using (var level2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var reader = new StreamReader(level2))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }
        static void showmateriatsLevel3(int semester)
        {
            string path;
            if (semester == 1)
            {
                 path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 3\semester 1";
            }
            else
            {
                path = @"C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\materiats Unviersity\level 3\semester 2";
            }
            using (var level3 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var reader = new StreamReader(level3))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }
        static int validateInput(string input)
        {
            int value;
            while (!int.TryParse(input, out value))
            {

                Console.WriteLine("**********************************************************");
                Console.Write("Invalid input. Please enter a valid number: ");
                input = Console.ReadLine();
                Console.WriteLine("**********************************************************");
            }
            return value;
        }
        static string validateEmail(string email)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (email.Contains("@gmail.com")|| email.Contains("@outlook.com") || email.Contains("@hotmial.com") || email.Contains("@gmail.com") || email.Contains("@live.com") || email.Contains("@yahoo.com") || email.Contains("@icloud.com"))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid email address. please enter a valid Enter student email: ");
                    email = Console.ReadLine();
                }
            }
            return email;
        }
        static string validateName(string name)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (name.Length >= 3 && name.Length <= 20 && !name.Contains("1")&& !name.Contains("2")&& !name.Contains("3")&& !name.Contains("4")&& !name.Contains("5")&& !name.Contains("6")&& !name.Contains("7")&& !name.Contains("8")&& !name.Contains("9")&& !name.Contains("0"))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid name. Please enter a valid name: ");
                    name = Console.ReadLine();
                }
            }
            return name;
        }
        static string validatePassword(string password)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (password.Length >= 8)
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid password. Please enter a valid password: ");
                    password = Console.ReadLine();
                }
            }
            return password;
        }
    }
}
