# 🎓 Y.H.B University System  

**Version:** 1.0  
**Developer:** Youssef Harby Bayoumi  
**Training Program:** Final Project – Enactus Community  
**Start Date:** April 21, 2025  
**Last Update:** July 2025  

---

## 📘 About the Project  

Y.H.B University System is a **console-based university management tool** built in **C#**, developed as part of a training program.  
The system focuses on **student and admin operations** including login, registration, academic material access, GPA management, and full CRUD functionalities with improved data handling.  

---

## 🆕 What’s New in Version 1.0  

- 🔐 **Enhanced Authentication System**
  - Login & registration improved with better validation  
  - Maximum login attempt limitation for students and admins  

- 📂 **Persistent Student Data**
  - Student data is now stored in `student_data.txt`  
  - Admins can fully view, edit, and manage records dynamically  

- 📊 **Academic Materials Access**
  - Students can navigate **levels (1–3)** and choose **semesters (1–2)**  
  - Displays academic materials for each selection  

- 🧹 **Advanced Admin Tools**
  - Add multiple students in bulk  
  - Edit student info (Name, ID, Email, Password, GPA)  
  - Delete individual students or wipe all data at once with confirmation  

- 🎨 **Improved User Interface**
  - ASCII-art styled home screen with color-coded sections  
  - Clearer navigation and messages for user actions  

---

## 🧩 Full Feature Overview  

### 🔐 User Authentication
- Secure login for students and admins  
- Input validation for **name**, **email**, **password**, and **GPA**  
- Maximum 3 attempts before lockout  

### 👨‍🎓 Student Functionalities
- Register new student accounts  
- Login to access academic materials by level & semester  
- Personalized greeting on login  
- GPA view in dashboard  

### 👨‍🏫 Administrator Functionalities
- Secure login with username & password  
- View, add, edit, and delete student records  
- Bulk deletion and confirmation prompts  
- Ability to **register new admin accounts**  

---

## 🛠 Technologies Used  

- **Language:** C# (.NET Console)  
- **IDE:** Visual Studio / VS Code  
- **Framework:** .NET Framework/Core  
- **Storage:** Persistent file-based storage (`student_data.txt`)  
- **File I/O:** Reads and writes student records and academic materials  

---

## 🧪 Technical Highlights  

- Data handling with **arrays and file I/O**  
- Modular validation methods:  
  - `ValidateInput()`, `ValidateEmail()`, `ValidateName()`, `ValidatePassword()`, `ValidateGPA()`  
- Academic materials loading from local directories based on **level & semester**  

---

## 🔄 Update History  

| Version  | Date        | Notes                                                     |
|----------|-------------|-----------------------------------------------------------|
| 0.1      | May 1, 2025 | Initial release                                           |
| 0.2      | Jun 7, 2025 | GPA management + admin CRUD tools                         |
| 1.0      | Jul 29, 2025   | Persistent storage, enhanced admin tools, full feature set|

---

## 🚧 Future Roadmap  

- Database integration (SQL) for scalability  
- GPA analysis and reports  
- Faculty panel with dedicated logins  
- Graphical user interface (GUI) version  

---

## 💻 How to Run  

1. Clone or download the repository  
2. Open the solution in Visual Studio  
3. Build and run (Ctrl + F5)  
4. Use the menu to navigate between **Login**, **Register**, **Admin**, and **About**  

---

## 🧑‍💻 Developer Info  

- 👨‍💻 **Youssef Harby Bayoumi**  
- 🎓 Built under Enactus Training Initiative  
- 📬 Feedback and suggestions are welcome!  

---

## 🕊 Free Palestine  

> **Free Palestine** – Human rights and dignity for all  

---

## 📄 License  

This software is for educational purposes only.  
Use, share, or modify freely with credit. Not for commercial use.
