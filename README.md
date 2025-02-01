# 🏦 Console-Based Banking System

## 📌 Project Overview
This is a **.NET Console Application** that simulates basic banking operations. Users can create accounts, deposit and withdraw money, check their balance, and view account details. The system uses **file-based storage (JSON)** to persist account data.

---

## 🚀 Features
✅ **Create Account** – Open a new bank account with an initial deposit.  
✅ **View Account Details** – Retrieve account details using the account number.  
✅ **Deposit Money** – Add money to an existing account.  
✅ **Withdraw Money** – Withdraw money, ensuring sufficient balance.  
✅ **Check Balance** – Display the current balance of an account.  
✅ **Data Persistence** – Accounts are stored in a JSON file (`accounts.json`).  

---

## 🔧 Technologies Used
- **C# (.NET Console Application)**
- **Collections (`List<T>`)**
- **File Handling (JSON Serialization)**
- **Newtonsoft.Json (for JSON operations)**

---

## 📂 Project Structure

```
📦 ConsoleBasedBankingSystem
 ┣ 📜 Program.cs             # Main entry point for the application
 ┣ 📜 Account.cs             # Account class with properties and methods
 ┣ 📜 BankingService.cs      # Core business logic (CRUD operations)
 ┣ 📜 accounts.json          # File storage for account data
 ┣ 📜 README.md              # Project documentation
```

---

## 🎮 How to Run the Application

1️⃣ **Clone the Repository**
```sh
git clone https://github.com/yourusername/ConsoleBasedBankingSystem.git
cd ConsoleBasedBankingSystem
```

2️⃣ **Open in Visual Studio / VS Code**  
- Ensure you have **.NET SDK** installed.

3️⃣ **Run the Application**  
```sh
dotnet run
```

---

## 📝 Future Enhancements
🔹 **Transaction History** – Store & display deposits/withdrawals.  
🔹 **Error Handling** – Improve input validation and exception handling.  
🔹 **Backup & Recovery** – Handle file corruption & recovery mechanisms.  

---

## 📌 Author
**👤 Rushikesh Anil Katkar**  
💼 Junior .NET Developer at NextWebi IT Solutions  
📧 [Your Email]  
🔗 [Your LinkedIn](https://www.linkedin.com/in/yourprofile/)  

---

## ⭐ Contributions & Feedback
Feel free to fork this project, raise issues, and suggest improvements! 🚀  
If you liked this project, don't forget to give it a **⭐ star**! 😊  
