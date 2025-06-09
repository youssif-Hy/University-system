# 🎓 Y.H.B University System

**Version:** 0.3  
**Developer:** Youssef Harby Bayoumi  
**Training Program:** Final Project – Enactus Community  
**Start Date:** April 21, 2025  
**Last Update:** June 7, 2025  

---

## 📘 About the Project

Y.H.B University System is a console-based university management tool built in **C#**, developed as part of a training program. The system focuses on student and admin operations including login, academic material access, GPA management, and full CRUD functionalities.

---

## 🆕 What’s New in Version 0.3

- 📊 **GPA Management System**
  - Admins can now view and edit student GPAs
  - GPA is validated (values between 0.0 and 4.0 only)
  - GPA is stored and displayed in student records

- 🧹 **Bulk Data Operations**
  - Added "Delete All Students" feature for admin
  - Confirmation prompts to prevent accidental data loss

- 🧠 **Improved Logic & Flow**
  - Student struct now includes GPA field
  - Array resizing optimized for large-scale operations

- 🎨 **UI Enhancements**
  - GPA now visible in student data displays
  - Improved menu structure for better navigation

---

## 🧩 Full Feature Overview

### 🔐 User Authentication
- Secure login for students and admins
- Login attempt limit (3 attempts)
- Password strength enforcement

### 👨‍🎓 Student Functionalities
- Access academic materials by:
  - 📘 Level 1 (Semesters 1 & 2)
  - 📗 Level 2 (Semesters 1 & 2)
  - 📕 Level 3 (Semesters 1 & 2)
- Personalized greeting on login
- GPA view in dashboard

### 👨‍🏫 Administrator Functionalities
- View, add, edit, and delete student records
- GPA editing & validation
- Bulk student deletion
- Add new admins with credentials

---

## 🛠 Technologies Used

- **Language:** C# (.NET Console)
- **IDE:** Visual Studio / VS Code
- **Framework:** .NET Framework/Core
- **Storage:** In-memory arrays (temporary)
- **File I/O:** Reads academic materials from local files

---

## 🧪 Technical Highlights

- **Data Structures:**
  - `struct` used for Student with GPA included
- **Validation Methods:**
  - `validateInput()`, `validateEmail()`, `validateName()`, `validatePassword()`, `validateGPA()`
- **File Path Example:**
  ```
  materiats University/level [1-3]/semester [1-2]
  C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\
  ```

---

## 🔄 Update History

| Version  | Date        | Notes                                        |
|----------|-------------|----------------------------------------------|
| 0.1      | May 1, 2025 | Initial release                              |
| 0.2      | Jun 7, 2025 | Added deletion and validation tools          |
| 0.3      | Jun 7, 2025 | GPA management + bulk deletion functionality |

---

## 🚧 Future Roadmap

- Persistent file or database storage
- Course registration module
- GPA analysis and report cards
- Faculty panel & interaction
- Web version using ASP.NET

---

## 💻 How to Run

1. Clone the repository or copy the project
2. Open the solution in Visual Studio
3. Build and run (Ctrl + F5)
4. Use menu to navigate between student/admin operations

---

## 🧑‍💻 Developer Info

- 👨‍💻 **Youssef Harby Bayoumi**
- 🎓 Project built under Enactus Training Initiative
- 📬 Feedback and suggestions welcome!

---

## 🕊 Free Palestine

This project includes a message of solidarity:
> **Free Palestine** – Human rights and dignity for all

---

## 📄 License

This software is for educational purposes only.  
Use, share, or modify freely with credit. Not for commercial use.
