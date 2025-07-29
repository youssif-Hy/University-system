using System;
using System.Linq;
using System.IO;
namespace Project_Y.H.B_University.System
{
    internal class Program
    {
        // مسار ملف بيانات الطلاب
        public static string path = "student_data.txt";
       
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
            Console.Write(" v.0.2");
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
            // التحقق من صحة الإدخال
            while (true)
            {
                option = ValidateInput(Console.ReadLine());
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
          
            Console.Clear();
            // عرض واجهة المستخدم الرئيسية بناءً على الخيار المحدد من قبل المستخدم
            switch (option)
            {
                case 1:
                    //login
                    //تسجيل دخول الطلاب اذا كان هناك طلاب مسجلين مسبقًا
                    if (File.Exists(path))
                    {
                        check = false;
                        level = 0;
                        semester = 0;
                        // استخدام حلقة for للسماح للمستخدم بمحاولة تسجيل الدخول حتى 3 مرات
                        string[] lines = File.ReadAllLines(path);
                        for (int i = 0; i <= 3; i++)
                        {
                            // حلقة for للتحقق من صحة بيانات تسجيل الدخول
                            foreach (string line in lines)
                            {
                                
                                // عرض رسالة لتسجيل الدخول
                                Console.Write("Enter your ID: ");
                                string id = Console.ReadLine();
                                Console.Write("Enter your password: ");
                                string password = Console.ReadLine();
                                // التحقق من صحة بيانات تسجيل الدخول
                                string[] studentData = line.Split(',');
                                if (id == studentData[0] && password == studentData[1])
                                {
                                    Console.Clear();
                                    Console.WriteLine("Login successful");
                                    Console.WriteLine("\nWelcome " + studentData[2]);
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
                            
                            // إذا تم تسجيل الدخول بنجاح، يتم كسر الحلقة
                            if (check)
                            {
                                break;
                            }
                        }
                        bool continueLogin = true;
                        // حلقة while للسماح للمستخدم بالاستمرار في اخذ المراجع الخاصة بالجامعه حتى يختار الخروج
                        while (continueLogin) 
                        {
                            
                            if (check)
                            {
                                // عرض رسالة ترحيب واختيار المستوى الدراسي
                                Console.Clear();
                                Console.WriteLine("1.level 1");
                                Console.WriteLine("2.level 2");
                                Console.WriteLine("3.level 3");
                                Console.Write("Enter the level number for which you want materiats:");
                                // التحقق من صحة إدخال المستوى الدراسي
                                while (level != 1 && level != 2 && level != 3)
                                {
                                    level = ValidateInput(Console.ReadLine());
                                    if (level != 1 && level != 2 && level != 3)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                Console.Clear();
                                // عرض رسالة ترحيب واختيار الفصل الدراسي في المستوى الدراسي المحدد
                                if (level == 1)
                                {
                                    Console.WriteLine("Welcome to level 1 materiats");
                                    Console.WriteLine("1.First Semester");
                                    Console.WriteLine("2.Second Semester");
                                    Console.Write("Enter the semester number for which you want materiats:");
                                    while (semester != 1 && semester != 2 && semester != 3)
                                    {
                                        semester = ValidateInput(Console.ReadLine());
                                        if (semester != 1 && semester != 2 && semester != 3)
                                        {
                                            Console.WriteLine("Invalid option. Please try again.");
                                        }
                                    }
                                    // عرض المواد الدراسية للمستوى الأول والفصل الدراسي المحدد من خلال الدالة showmateriatsLevel1
                                    ShowMateriatsLevel1(semester);
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
                                        semester = ValidateInput(Console.ReadLine());
                                        if (semester != 1 && semester != 2 && semester != 3)
                                        {
                                            Console.WriteLine("Invalid option. Please try again.");
                                        }
                                    }
                                    // عرض المواد الدراسية للمستوى الثاني والفصل الدراسي المحدد من خلال الدالة showmateriatsLevel2
                                    ShowMateriatsLevel2(semester);
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
                                        semester = ValidateInput(Console.ReadLine());
                                        if (semester != 1 && semester != 2 && semester != 3)
                                        {
                                            Console.WriteLine("Invalid option. Please try again.");
                                        }
                                    }
                                    // عرض المواد الدراسية للمستوى الثالث والفصل الدراسي المحدد من خلال الدالة showmateriatsLevel3
                                    ShowMateriatsLevel3(semester);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                           
                            }
                            // اذا لم يتمكن المستخدم من تسجيل الدخول بعد 3 محاولات
                            else if (!check)
                            {
                                Console.WriteLine("You have exceeded the maximum number of attempts");
                                Console.WriteLine("If you have forgotten your password or ID, you must contact the administrator.");
                                break;
                            }
                            // سؤال المستخدم إذا كان يريد المزيد من المواد الدراسية لمستويات أخرى
                            Console.WriteLine("Do you want more materials for other levels?");
                            Console.WriteLine("1.YES");
                            Console.WriteLine("2.NO");
                            Console.Write("Please select an option: ");
                            int choice = 0;
                            // التحقق من صحة الإدخال
                            while (choice != 1 && choice != 2)
                            {
                                Console.Write("Enter your choice: ");
                                choice = ValidateInput(Console.ReadLine());
                                if (choice != 1 && choice != 2)
                                {
                                    Console.WriteLine("Invalid option. Please try again.");
                                }
                            }
                            // إذا كان المستخدم يريد المزيد من المواد الدراسية
                            if (choice == 1)
                            {
                                level = 0; 
                                semester = 0;
                            }
                            // إذا كان المستخدم لا يريد المزيد من المواد الدراسية
                            else if (choice == 2)
                            {
                                continueLogin = false; 
                            }
                        }
                    }
                    // إذا لم يكن هناك طلاب مسجلين مسبقًا
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
                    //تسجيل دخول الطلاب اذا لم يكن هناك طلاب مسجلين مسبقًا
                    if (!File.Exists(path))
                    {
                        Console.Write("Enter your name: ");
                        string Name = ValidateName(Console.ReadLine());
                        Console.Write("Enter your ID: ");
                        string ID = Console.ReadLine();
                        Console.Write("Enter your email: ");
                        string Email = ValidateEmail(Console.ReadLine());
                        Console.Write("Enter your password: ");
                        string Password = ValidatePassword(Console.ReadLine());
                        double GPA = 0;
                        Console.WriteLine("Student registered successfully.");
                        // إنشاء ملف جديد لتخزين بيانات الطلاب
                        File.WriteAllText(path, $"{ID},{Password},{Name},{Email},{GPA}\n");

                    }
                    //تسجيل دخول الطلاب اذا كان هناك طلاب مسجلين مسبقًا
                    else 
                    {
                      
                        // عرض رسالة لإدخال بيانات الطالب الجديد
                        Console.WriteLine("Enter data for student ");
                        Console.Write("Enter your name: ");
                        string Name = ValidateName(Console.ReadLine());
                        Console.Write("Enter your ID: ");
                        string ID = Console.ReadLine();
                        Console.Write("Enter your email: ");
                        string Email = ValidateEmail(Console.ReadLine());
                        Console.Write("Enter your password: ");
                        string Password = ValidatePassword(Console.ReadLine());
                        Console.WriteLine("Student registered successfully.");
                        double GPA = 0; // تعيين المعدل التراكمي الافتراضي إلى 0
                        // إضافة بيانات الطالب الجديد إلى الملف
                        File.AppendAllText(path, $"{ID},{Password},{Name},{Email},{GPA}\n");
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
                    // واجهة المشرف الافتراضية
                    Console.WriteLine("welcome Admin");
                    Console.WriteLine("1. Login ");
                    Console.WriteLine("2. Register");
                    Console.Write("Please select an option: ");
                    int option1 = 0;
                    // التحقق من صحة الإدخال
                    while (option1 != 1 && option1 != 2)
                    {
                        option1 = ValidateInput(Console.ReadLine());
                        if (option1 != 1 && option1 != 2)
                        {
                            Console.WriteLine("Invalid option. Please try again.");
                        }
                    }
                    bool isValid;
                    // التحقق من صحة بيانات المشرف
                    if (option1 == 1)
                    {
                        isValid = Access_Permission(adminusername, adminpassword);
                        if (isValid)
                        {
                            while (true)
                            { 
                                Console.Clear();
                                // عرض واجهة المشرف
                                Console.WriteLine("***********************************************************");
                                Console.WriteLine("Welcome Admin");
                                Console.WriteLine("1. Show Student Data");
                                Console.WriteLine("2. Add some Student Data");
                                Console.WriteLine("3. Edit data for a student");
                                Console.WriteLine("4. delete data for a student");
                                Console.WriteLine("5. delete all data for all students");
                                Console.Write("Please select an option: ");
                                int option2 = 0;
                                // التحقق من صحة الإدخال
                                while (option2 != 1 && option2 != 2 && option2 != 3 && option2 != 4 && option2 != 5)
                                {
                                    option2 = ValidateInput(Console.ReadLine());
                                    if (option2 != 1 && option2 != 2 && option2 != 3 && option2 != 4 && option2 != 5)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                Console.WriteLine("***********************************************************\n\n");
                                // إذا كان المشرف يريد عرض بيانات الطلاب
                                if (option2 == 1)
                                {
                                    // عرض بيانات الطلاب
                                    if (File.Exists(path))
                                    {
                                        // قراءة بيانات الطلاب من الملف
                                        string[] student = File.ReadAllLines(path);
                                        Console.WriteLine("**********************************************************");
                                        Console.WriteLine("Welcome to the student data section");
                                        Console.WriteLine("Student Data:");
                                        ShowData(student);
                                        Console.WriteLine("**********************************************************\n\n");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadKey();
                                    }
                                    // إذا لم يكن هناك بيانات للطلاب
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
                                    // إضافة بيانات طلاب جديدة
                                    Console.WriteLine("**********************************************************");
                                    Console.Write("Enter the number of additional students: ");
                                    numStudents = ValidateInput(Console.ReadLine());
                                    
                                    // إضافة بيانات الطلاب الجدد
                                    
                                    for (int i =  0; i < numStudents; i++)
                                    {
                                        // عرض رسالة لإدخال بيانات الطالب
                                        Console.WriteLine("Enter data for student " + (i + 1));
                                        Console.Write("Enter student name: ");
                                        string Name = ValidateName(Console.ReadLine());
                                        Console.Write("Enter student ID: ");
                                        string ID = Console.ReadLine();
                                        Console.Write("Enter student email: ");
                                        string Email = ValidateEmail(Console.ReadLine());
                                        Console.Write("Enter student password: ");
                                        string Password = ValidatePassword(Console.ReadLine());
                                        Console.Write("Enter student GPA: ");
                                        double GPA = ValidateGPA(double.Parse(Console.ReadLine()));
                                        Console.WriteLine("**********************************************************");
                                        if (File.Exists(path)) 
                                        {
                                            File.AppendAllText(path, $"{ID},{Password},{Name},{Email},{GPA}\n");
                                        }
                                        else
                                        {
                                            File.WriteAllText(path, $"{ID},{Password},{Name},{Email},{GPA}\n");
                                        }
                                    }
                                }
                                else if (option2 == 3)
                                {
                                    // تعديل بيانات طالب
                                    Console.Clear();
                                    // التحقق من وجود بيانات للطلاب قبل محاولة تعديل أي طالب
                                    if (File.Exists(path))
                                    {
                                        // عرض بيانات الطلاب قبل التعديل
                                        int number = ShowDataForEditOrDelete();
                                        Console.Write("Enter the student number you want to edit: ");
                                        int studentNumber;
                                        while (true)
                                        {
                                            studentNumber = ValidateInput(Console.ReadLine());
                                            if (studentNumber > 0 && studentNumber <= number)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Invalid student number. Please enter a valid number: ");
                                            }
                                        }
                                        // قراءة بيانات الطلاب من الملف
                                        string[] student = File.ReadAllLines(path);
                                        string[] studentData = student[studentNumber - 1].Split(',');
                                        Console.Clear();
                                        Console.WriteLine($"**********************************************************\nStudent Number: {studentNumber}\nName:{studentData[0]}\nID:{studentData[1]}\nEmail:{studentData[2]}\nPassword:{studentData[3]}\nGPA:{studentData[4]}\n**********************************************************");
                                        Console.WriteLine("What do you want to edit?");
                                        Console.WriteLine("1. Name");
                                        Console.WriteLine("2. ID");
                                        Console.WriteLine("3. Email");
                                        Console.WriteLine("4. Password");
                                        Console.WriteLine("5. GPA");
                                        Console.Write("Please select an option: ");
                                        int editOption = 0;
                                        // التحقق من صحة الإدخال
                                        while (editOption != 1 && editOption != 2 && editOption != 3 && editOption != 4 && editOption != 5)
                                        {
                                            editOption = ValidateInput(Console.ReadLine());
                                            if (editOption != 1 && editOption != 2 && editOption != 3 && editOption != 4 && editOption != 5)
                                            {
                                                Console.WriteLine("Invalid option. Please try again.");
                                            }
                                        }
                                        // تعديل البيانات بناءً على الخيار المحدد
                                        if (editOption == 1)
                                        {
                                            Console.Write("Enter new name: ");
                                            studentData[0] = ValidateName(Console.ReadLine());
                                        }
                                        else if (editOption == 2)
                                        {
                                            Console.Write("Enter new ID: ");
                                            studentData[1] = Console.ReadLine();
                                        }
                                        else if (editOption == 3)
                                        {
                                            Console.Write("Enter new email: ");
                                            studentData[2] = ValidateEmail(Console.ReadLine());
                                        }
                                        else if (editOption == 4)
                                        {
                                            Console.Write("Enter new password: ");
                                            studentData[3] = ValidatePassword(Console.ReadLine());
                                        }
                                        else if (editOption == 5)
                                        {
                                            Console.Write("Enter new GPA: ");
                                            studentData[4] =Convert.ToString(ValidateGPA(double.Parse(Console.ReadLine())));
                                        }
                                        // تحديث بيانات الطالب في المصفوفة
                                        student[studentNumber - 1] = string.Join(",", studentData);
                                        // كتابة البيانات المعدلة مرة أخرى إلى الملف
                                        File.WriteAllLines(path, student);
                                    }
                                    // إذا لم يكن هناك بيانات للطلاب، يتم عرض رسالة تفيد بعدم وجود بيانات لتعديلها
                                    else
                                    {
                                        Console.WriteLine("**********************************************************");
                                        Console.WriteLine("No student data available to edit.");
                                        Console.WriteLine("**********************************************************\n\n");
                                    }
                                }
                                // حذف بيانات طالب
                                else if (option2 == 4)
                                {
                                    Console.Clear();
                                    // التحقق من وجود بيانات للطلاب قبل محاولة حذف أي طالب
                                    if (File.Exists(path))
                                    {
                                        // عرض بيانات الطلاب قبل الحذف
                                       int number = ShowDataForEditOrDelete();
                                        Console.Write("Enter the student number you want to delete: ");
                                        // التحقق من صحة إدخال رقم الطالب
                                        int studentNumber;
                                        while (true)
                                        {
                                            studentNumber = ValidateInput(Console.ReadLine());
                                            if (studentNumber > 0 && studentNumber <= number)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Invalid student number. Please enter a valid number: ");
                                            }
                                        }
                                        string[] student = File.ReadAllLines(path);
                                        // حذف بيانات الطالب المحدد من المصفوفة
                                        student = student.Where((s, index) => index != studentNumber - 1).ToArray();
                                        // كتابة البيانات المعدلة مرة أخرى إلى الملف
                                        File.WriteAllLines(path, student);
                                        // تقليص حجم المصفوفة بعد حذف الطالب
                                        ShowDataForEditOrDelete();
                                    }
                                    // إذا لم يكن هناك بيانات للطلاب، يتم عرض رسالة تفيد بعدم وجود بيانات لحذفها
                                    else
                                    {
                                        Console.WriteLine("**********************************************************");
                                        Console.WriteLine("No student data available to delete.");
                                        Console.WriteLine("**********************************************************\n\n");
                                    }
                                }
                                else if (option2 == 5)
                                {
                                    // حذف جميع بيانات الطلاب
                                    Console.Clear();
                                    // التحقق من وجود بيانات للطلاب قبل محاولة حذفها
                                    if (File.Exists(path))
                                    {
                                        Console.WriteLine("Are you sure you want to delete all student data?");
                                        Console.WriteLine("1.YES");
                                        Console.WriteLine("2.NO");
                                        Console.Write("Please select an option: ");
                                        int deleteOption = 0;
                                        // التحقق من صحة الإدخال
                                        while (deleteOption != 1 && deleteOption != 2)
                                        {
                                            deleteOption = ValidateInput(Console.ReadLine());
                                            if (deleteOption != 1 && deleteOption != 2)
                                            {
                                                Console.WriteLine("Invalid option. Please try again.");
                                            }
                                        }
                                        // إذا كان المشرف يريد حذف جميع البيانات
                                        if (deleteOption == 1)
                                        {
                                            // حذف ملف بيانات الطلاب
                                            File.Delete(path);
                                            Console.WriteLine("All student data has been deleted successfully.");
                                        }
                                        // إذا كان المشرف لا يريد حذف جميع البيانات
                                        else if (deleteOption == 2)
                                        {
                                            Console.WriteLine("No data was deleted.");
                                        }
                                    }
                                    // إذا لم يكن هناك بيانات للطلاب، يتم عرض رسالة تفيد بعدم وجود بيانات لحذفها
                                    else
                                    {
                                        Console.WriteLine("**********************************************************");
                                        Console.WriteLine("No student data available to delete.");
                                        Console.WriteLine("**********************************************************\n\n");
                                    }
                                }
                                // سؤال المشرف إذا كان يريد الاستمرار في إدارة البيانات
                                Console.WriteLine("Do you want to continue managing student data?");
                                Console.WriteLine("1.YES");
                                Console.WriteLine("2.NO");
                                Console.Write("Please select an option: ");
                                int continueOption = 0;
                                // التحقق من صحة الإدخال
                                while (continueOption != 1 && continueOption != 2)
                                {
                                    continueOption = ValidateInput(Console.ReadLine());
                                    if (continueOption != 1 && continueOption != 2)
                                    {
                                        Console.WriteLine("Invalid option. Please try again.");
                                    }
                                }
                                // إذا كان المشرف يريد الاستمرار في إدارة البيانات
                                if (continueOption == 1)
                                {
                                    // سوف تستمر الحلقة في عرض واجهة المشرف
                                }
                                // إذا كان المشرف لا يريد الاستمرار في إدارة البيانات
                                else if (continueOption == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Exiting admin interface...");
                                    break; // الخروج من الحلقة
                                }
                            }
                        }
                    }
                    else if (option1 == 2)
                    {
                        // استخدام نفس الطريقة لتكبير مصفوفة المشرفين وإضافة مشرف جديد
                        adminusername2 = new string[adminusername.Length+1];
                        Array.Copy(adminusername, adminusername2, adminusername.Length);
                        adminusername = new string[adminusername.Length + 1];
                        Array.Copy(adminusername2, adminusername, adminusername2.Length);
                        adminusername2 = null; 
                        adminpassword2 = new string[adminpassword.Length + 1];
                        Array.Copy(adminpassword, adminpassword2, adminpassword.Length);
                        adminpassword = new string[adminpassword.Length + 1];
                        Array.Copy(adminpassword2, adminpassword, adminpassword.Length);
                        adminpassword2 = null;
                        // استخدام دالة RegisterForAdmin لتسجيل مشرف جديد
                        RegisterForAdmin(adminusername, adminpassword);
                        Console.Clear();
                        Console.WriteLine("New admin registered successfully.");
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
                    // عرض معلومات حول المشروع
                    Console.WriteLine("**********************************************************");
                    Console.WriteLine("Welcome to the Y.H.B University System");
                    Console.WriteLine("About the Project\n\nThis project is a university system designed to assist students and administrators in managing student data and resources.\n\n");
                    Console.WriteLine("Origin\n\nThis project was created by Youssef Harby Bayoumi\r\nIt is the final project for a training program in collaboration with the Enactus community.\n");
                    Console.WriteLine("Program Description\n\nThis system is designed to be used by both students and university administrators.\n\n•   * Administrators use the system to store and manage student data, which can be retrieved upon request.\n\n•   * Students use the program to register their information or log in to access useful resources such as book links or PDF files available within the system.\n\n");
                    Console.WriteLine("Future Goals\n\nThe developer hoped to make the system capable of saving data in a dedicated data file, but due to time constraints, this feature has not been implemented yet.\r\nTherefore, the program is still under development and not a complete version as of now.\n\n");
                    Console.WriteLine("Update History\n\n   * Project development started on April 21, 2025\n\n   * Submitted on May 1, 2025\n\n   * First update Jun 7, 2025");
                    Console.WriteLine("   * Version 0.2\n\n");
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
        // دالة لعرض واجهة التبديل بين الخيارات و اذا كان المستخدم يريد الاستمرار في البرنامج أم لا
        public static int Switch1()
        {
            Console.Clear();
            // عرض خيارات الاستمرار في البرنامج
            int option;
            while (true)
            {
                Console.WriteLine("\n\n\n****************************************************************************************************");
                Console.WriteLine("Do you want to continue in the program ?");
                Console.WriteLine("1:YES ");
                Console.WriteLine("2:NO ");
                Console.Write("Please select an option: ");
                option = ValidateInput(Console.ReadLine());
                if (option == 1 || option == 2)
                    break;
                else
                    Console.WriteLine("Invalid option. Please try again.");
                Console.WriteLine("****************************************************************************************************");
            }
            // إذا كان المستخدم يريد الاستمرار في البرنامج، يتم عرض الخيارات الرئيسية مرة أخرى
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
                // التحقق من صحة الإدخال
                while (true)
                {
                    option = ValidateInput(Console.ReadLine());
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
            // إذا كان المستخدم لا يريد الاستمرار في البرنامج، يتم عرض رسالة وداع والخروج من البرنامج
            else
            {
                Exit_Message();
            }
            return option;
        }
        // دالة للخروج من البرنامج مع رسالة وداع
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
        // دالة لتسجيل الدخول والتحقق من صلاحيات المشرف
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
        // دالة لعرض بيانات الطلاب
        static void ShowData(string[] data)
        {
            foreach (string line in data)
            {
                string[] parts = line.Split(',');
                Console.WriteLine($"**********************************************************\nName:{parts[0]}\nID:{parts[1]}\nEmail:{parts[2]}\nPassword:{parts[3]}\nGPA:{parts[4]}\n**********************************************************");
            }
        }
        // دالة لعرض بيانات الطلاب لتعديلها أو حذفها
        static int ShowDataForEditOrDelete( )
        {
            // قراءة بيانات الطلاب من الملف
            string[] data = File.ReadAllLines(path);
            int i = 0;
            foreach (var student in data)
            {
                i++;
                string[] parts = student.Split(',');
                Console.WriteLine($"**********************************************************\nStudent Number: {i}\nName:{parts[0]}\nID:{parts[1]}\nEmail:{parts[2]}\nPassword:{parts[3]}\nGPA:{parts[4]}\\n**********************************************************");
            }
            return i;
        }
        // دالة لتسجيل مشرف جديد
        static void RegisterForAdmin(string[] adminusername,string[] adminpassword)
        {
            Console.WriteLine("You need to enter an existing administrator account to register a new admin.");
            // التحقق من صحة بيانات المشرف الحالي
            bool x = Access_Permission(adminusername, adminpassword);
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
        // دالة لعرض المواد الدراسية للمستوى الأول
        static void ShowMateriatsLevel1(int semester)
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
        // دالة لعرض المواد الدراسية للمستوى الثاني
        static void ShowMateriatsLevel2(int semester)
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
        // دالة لعرض المواد الدراسية للمستوى الثالث
        static void ShowMateriatsLevel3(int semester)
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
        // دالة للتحقق من صحة الإدخال
        static int ValidateInput(string input)
        {
            int value;
            while (!int.TryParse(input, out value))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
                input = Console.ReadLine();
            }
            return value;
        }
        // دالة للتحقق من صحة البريد الإلكتروني
        static string ValidateEmail(string email)
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
        // دالة للتحقق من صحة الاسم
        static string ValidateName(string name)
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
        // دالة للتحقق من صحة كلمة المرور
        static string ValidatePassword(string password)
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
        // دالة للتحقق من صحة معدل التقدير (GPA)
        static double ValidateGPA(double GPA)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (GPA >= 0 && GPA <= 4)
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid GPA. Please enter a valid GPA (0-4): ");
                    while (!double.TryParse(Console.ReadLine(), out GPA) || GPA < 0 || GPA > 4)
                    {
                        Console.Write("Invalid input. Please enter a valid GPA (0-4): ");
                    }
                }
            }
            return GPA;
        }
    }
}
