# 🎓 Y.H.B University System

**Version:** 0.2.1  
**Developer:** Youssef Harby Bayoumi  
**Training Program:** Final Project – Enactus Community  
**Start Date:** April 21, 2025  
**Last Update:** June 7, 2025  

---

## 📘 About the Project

Y.H.B University System is a console-based educational management system written in **C#**. It serves as a training project for student and administrator interactions within a university setting. The system provides features like authentication, academic material access, and admin-level student management.

---

## 🆕 What’s New in Version 0.2.1

- 🗑 **Student Deletion Feature**
  - Admins can now **delete student records**
  - Integrated confirmation prompts to prevent accidental data loss

- 🧩 **Improved Admin Menu**
  - New option added to manage deletions (Option 4)
  - Unified function for edit and delete views: `ShowDataForEditOrDelete()`

- ⚙️ **Functional Enhancements**
  - Enhanced validation for edit/delete operations
  - Better array management and resizing after deletions

- 🚫 **Improved Error Handling**
  - Clear messaging for invalid actions
  - Robust checks for empty or invalid student selection

---

## 🧩 Full Feature Overview

### 🔐 User Authentication
- Student login with **3-attempt limit**
- Admin login with **role-based permissions**
- Strong password validation (minimum 8 characters)

### 👨‍🎓 Student Functionalities
- Access academic resources for:
  - Level 1–3, each with two semesters
- Personalized welcome on login
- Structured material access by file system

### 👨‍🏫 Administrator Functionalities
- View all student data
- Add student (single or multiple)
- Edit student info (Name, ID, Email, Password)
- ✅ **Delete student records**
- Add new administrators securely

---

## 🛠 Technologies Used

- **Language:** C# (.NET Console)
- **IDE:** Visual Studio / VS Code
- **Framework:** .NET Framework/Core
- **Storage:** In-memory (arrays)
- **File I/O:** Academic materials loaded from external files

---

## 🧪 Technical Highlights

- **Structs:** Used for defining student/admin entities
- **Dynamic Arrays:** Resized during add/edit/delete
- **Validation Methods:**
  - `validateInput()` – Numeric input
  - `validateEmail()` – Domain format support
  - `validateName()` – Text-only name validation
  - `validatePassword()` – Length & complexity
- **File Path Example:**
  ```
  materiats University/level [1-3]/semester [1-2]
  Path: C:\Users\LEGION\Desktop\vs c2022\c#\Project_Y.H.B_University.System\
  ```

---

## 🔄 Update History

| Version  | Date        | Notes                                  |
|----------|-------------|----------------------------------------|
| 0.1      | May 1, 2025 | Initial release                        |
| 0.2      | Jun 7, 2025 | Added multi-level courses & admin tools|
| 0.2.1    | Jun 7, 2025 | Student deletion, validation, cleanup  |

---

## 🚧 Future Roadmap

- Add persistent file/database storage
- Implement course enrollment
- Include GPA/grades tracking
- Faculty login & content support
- Full web version (ASP.NET or Blazor)

---

## 💻 How to Run

1. Clone or download the repository
2. Open with Visual Studio
3. Build and run (`Ctrl + F5`)
4. Follow instructions in the console

---

## 🧑‍💻 Developer Info

- 👨‍💻 Developed by **Youssef Harby Bayoumi**
- 🎓 Project for **Enactus Community Training Program**
- 📢 Feedback & contributions welcome!

---

## 🕊 Free Palestine

This project includes a message of solidarity:
> **Free Palestine** – Human rights and dignity for all

---

## 📄 License

This project is for educational and training purposes only.  
Use, share, or modify with credit – not for commercial distribution.
