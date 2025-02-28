# 🎮 Tic Tac Toe Game  
A full-stack Tic Tac Toe game built with **ASP.NET Core** and **React**. This project follows a **clean architecture** approach, separating core business logic, infrastructure, and web presentation.  

---

## 🖼️ ScreenShots  

<img src="https://github.com/user-attachments/assets/dae4df1f-6dd1-467b-aea7-5a29e6716877" width="500">
<img src="https://github.com/user-attachments/assets/58576dfe-8c56-4e0f-9fdf-c2e42903e9a4" width="500">
<img src="https://github.com/user-attachments/assets/269c29b2-9ab3-4b6d-b26e-433c7a1e9398" width="500">
<img src="https://github.com/user-attachments/assets/c3ec108a-1c28-4f71-858c-50db0889b2f2" width="500">
<img src="https://github.com/user-attachments/assets/7dca8c3b-6f69-4b33-a88a-218d6b625a56" width="500">
<img src="https://github.com/user-attachments/assets/1a25be86-156c-4b75-953a-c91c8c9fcda4" width="500">
<img src="https://github.com/user-attachments/assets/7646b118-ef43-4aa2-a711-b11220c82e92" width="500">

---

## 🌐 Live Demo  
🚀 Try the game online: [🎮 Play Now](http://tictac.somee.com/)

---

## ✨ Features  

✅ Play against another player or AI opponent  
✅ Real-time game state updates  
✅ Responsive design (works on mobile & desktop)  
✅ Persistent game storage using **Entity Framework Core**  
✅ Clean architecture with separation of concerns  

---

## 📌 Project Structure  

The project follows a **clean architecture** approach with three main layers:  

### TicTacToe.Core  
🔹 Contains domain entities, interfaces, and business logic:  
- Game entity  
- `TicTacToeService` for game rules & logic  
- Repository interfaces  

### TicTacToe.Infrastructure  
🔹 Implements infrastructure concerns:  
- **Entity Framework Core** DbContext  
- Repository implementations (**EF Core**)  
- Database configuration  

### TicTacToe.Web  
🔹 The **ASP.NET Core MVC** web application:  
- **Controllers** for game actions  
- **Views** for the user interface  
- **JavaScript** for client-side interactions  
- **CSS** for styling  

---

## 🛠️ Technologies Used  

### 🔹 **Backend**  
-  **ASP.NET Core 9.0**  
-  **Entity Framework Core 9.0**  
-  **SQL Server**  

### 🔹 **Frontend**  
-  **HTML5, CSS3, JavaScript**  
-  **jQuery** for AJAX calls  
-  **Bootstrap 5** for responsive design  

---

## 🎲 How to Play  

1️⃣ Start a new game:  
   - Select **"Play against another player"** or **"Play against AI"**  
2️⃣ Click on any empty cell to make a move  
3️⃣ The game will **automatically detect** wins or draws  
4️⃣ After a game ends, you can **replay** or return to the home page  

---

🚀 **Enjoy the game & have fun!** 🎉
