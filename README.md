
# 🎓 Y.H.B University System

**Version:** 0.2  
**Developer:** Youssef Harby Bayoumi  
**Training Program:** Final Project – Enactus Community  
**Start Date:** April 21, 2025  
**Last Update:** June 7, 2025  

---

## 📘 About the Project

Y.H.B University System is a comprehensive console-based university management tool developed in **C#**, aiming to streamline interactions between **students** and **administrators**. It allows for secure user authentication, structured access to academic content, and admin-level control over data.

This project is the outcome of a professional training initiative in collaboration with **Enactus**.

---

## 🧩 Features

### 🔐 User Authentication
- Secure **login/registration** for students
- Multi-level **admin access** with authentication
- Password strength enforced (min 8 characters)

### 🎓 Student Capabilities
- Access to academic materials by:
  - 📘 Level 1 (Semesters 1 & 2)  
  - 📗 Level 2 (Semesters 1 & 2)  
  - 📕 Level 3 (Semesters 1 & 2)
- Personalized dashboard with name-based welcome message
- Login attempt limit (3 tries before lockout)

### 🧑‍💼 Admin Features
- 👥 **Student Data Management**
  - View all student records
  - Add multiple students
  - Edit existing student data (name, ID, email, password)
- 🛡️ **Admin Management**
  - Add new admins (requires existing admin privilege)
  - Secure admin authentication

### 🧠 System Enhancements
- ✉️ **Enhanced Input Validation**
  - Email domains supported: `@gmail.com`, `@outlook.com`, etc.
  - Name length & character checks
  - Safe numeric input validation
- 📂 **File Integration**
  - Reads academic content from external files
- 🖥️ **Improved Console UI**
  - Color-coded sections
  - Error messages with context
  - Streamlined menu design

---

## 🛠 Technologies Used

- **Language:** C# (.NET Console Application)
- **IDE:** Visual Studio 2022
- **Framework:** .NET Framework / .NET Core
- **Storage:** File-based for materials (no database yet)

---

## 🧾 Data Management

### 📌 Data Structures
- Uses `struct` to manage students (Name, ID, Email, Password)
- Dynamic resizing for storing student/admin lists

### 📁 File Paths
- Course materials are read from:
  - `materiats University/level [1-3]/semester [1-2]`
  - Example path:  
    `C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\`

### 🧪 Validation Functions
- `validateInput()` – numeric input check
- `validateEmail()` – valid email formats only
- `validateName()` – ensures alphabetic names, 3–20 chars
- `validatePassword()` – min 8-character password enforcement

---

## 🕒 Update History

| Version | Date         | Description |
|---------|--------------|-------------|
| 0.1     | May 1, 2025  | Initial release with basic login & admin prototype |
| 0.2     | June 7, 2025 | Course material files, improved admin tools, validation upgrades, UI refinements |

---

## 🚀 Planned Improvements

- 💾 Persistent data storage (via files or databases)
- 📝 Course registration functionality
- 📊 Grade tracking and reporting
- 🧑‍🏫 Faculty account support
- 🌐 Web-based version (ASP.NET or Blazor)

---

## 💻 How to Run

1. Clone or download the project
2. Open the solution in **Visual Studio**
3. Build and run the application (`Ctrl + F5`)
4. Follow console prompts to navigate and interact with the system

---

## 💡 Example Console Output

```
Welcome to the Y.H.B University System

 1. Login  
 2. Register  
 3. Admin  
 4. About  
 5. Exit

> Please choose an option:
```

---

## 📋 Requirements

- Windows OS  
- .NET Framework  
- ~500MB of disk space for storing material files  

---

## 🤝 Credits

- Developed by **Youssef Harby Bayoumi**
- Supervised by **Enactus Community Training Team**
- Special thanks to mentors and peers for their support

---

## 🕊 Free Palestine

> **Free Palestine** – Human rights and dignity for all people.  
> This message is proudly displayed in the system banner.

---

## 📄 License

This project is built for educational purposes. You may freely use or modify it for learning and development, but commercial use is prohibited without prior consent.
