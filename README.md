# Tic Tac Toe Game

A full-stack Tic Tac Toe game built with ASP.NET Core and React. This project demonstrates a clean architecture approach with separate layers for core business logic, infrastructure, and web presentation.


![Tic Tac Toe Game](https://images.unsplash.com/photo-1611996575749-79a3a250f948?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80)
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

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- SQL Server 
- Visual Studio 2022 

### Installation

1. Clone the repository:
   
2. Update the connection string in `TicTacToe.Web/appsettings.json` if needed.

3. Build and run the application:
   
## How to Play

1. Start a new game by selecting either "Play against another player" or "Play against AI"
2. Click on any empty cell to make a move
3. The game will automatically detect wins or draws
4. After a game ends, you can choose to replay or return to the home page


## Game Rules

- Players take turns placing their mark (X or O) on the board
- The first player to get three of their marks in a row (horizontally, vertically, or diagonally) wins
- If all cells are filled and no player has won, the game ends in a draw 

## Database

The application uses Entity Framework Core with SQL Server. Migrations are automatically applied at startup.

 
