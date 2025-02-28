Tic Tac Toe Game

A full-stack Tic Tac Toe game built with ASP.NET Core and React. This project demonstrates a clean architecture approach with separate layers for core business logic, infrastructure, and web presentation.


ScreenShots: 
## ScreenShots:

<img src="https://github.com/user-attachments/assets/dae4df1f-6dd1-467b-aea7-5a29e6716877" width="500">
<img src="https://github.com/user-attachments/assets/58576dfe-8c56-4e0f-9fdf-c2e42903e9a4" width="500">
<img src="https://github.com/user-attachments/assets/269c29b2-9ab3-4b6d-b26e-433c7a1e9398" width="500">
<img src="https://github.com/user-attachments/assets/c3ec108a-1c28-4f71-858c-50db0889b2f2" width="500">
<img src="https://github.com/user-attachments/assets/7dca8c3b-6f69-4b33-a88a-218d6b625a56" width="500">
<img src="https://github.com/user-attachments/assets/1a25be86-156c-4b75-953a-c91c8c9fcda4" width="500">
<img src="https://github.com/user-attachments/assets/7646b118-ef43-4aa2-a711-b11220c82e92" width="500">
 
## Live Demo

Try the game online: [http://tictac.somee.com/](http://tictac.somee.com/)
## Features

- Play against another player or AI opponent
- Real-time game state updates
- Responsive design that works on mobile and desktop
- Persistent game storage using Entity Framework Core
- Clean architecture with separation of concerns

## Project Structure

The solution follows a clean architecture approach with three main projects:

### TicTacToe.Core

Contains the domain entities, interfaces, and core business logic:
- Game entity
- TicTacToeService for game rules and logic
- Repository interfaces

### TicTacToe.Infrastructure

Implements the infrastructure concerns:
- Entity Framework Core DbContext
- Repository implementations (EF and In-Memory)
- Database configuration

### TicTacToe.Web

The ASP.NET Core MVC web application:
- Controllers for game actions
- Views for the user interface
- JavaScript for client-side interactions
- CSS for styling

## Technologies Used

- **Backend**:
  - ASP.NET Core 9.0
  - Entity Framework Core 9.0
  - SQL Server  
  
- **Frontend**:
  - HTML5, CSS3, JavaScript
  - jQuery for AJAX calls
  - Bootstrap 5 for responsive design

   
## How to Play

1. Start a new game by selecting either "Play against another player" or "Play against AI"
2. Click on any empty cell to make a move
3. The game will automatically detect wins or draws
4. After a game ends, you can choose to replay or return to the home page

 
