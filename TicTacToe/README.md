# Tic-Tac-Toe Game

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Features](#features)
- [Class Overview](#class-overview)
- [Project Status](#project-status)
- [Layout of Application](#layout-of-application)

## Introduction
**Tic-Tac-Toe Game** is a simple two-player application built with C# and WPF, designed to help understand the basics of Windows Presentation Foundation (WPF) and explore desktop application development in C#. The game enables two players to compete in a 3x3 grid, where the goal is to be the first to place three identical marks in a row (horizontal, vertical, or diagonal).

## Technologies
This project utilizes:
- **Programming Language**: C# (.NET Framework)
- **Framework**: WPF (Windows Presentation Foundation)

## Features
The application provides a basic yet complete Tic-Tac-Toe game experience, including:
- **Two-player mode**: Both players compete on the same device, taking turns marking spots on the grid.
- **Basic UI**: Simple, intuitive design for a clear and straightforward gaming experience.
- **Game Logic**: Manages turn-taking, checks for winning and draw conditions, and resets the game when required.

## Class Overview
Here are the primary classes and their respective roles within the project:

- **MainWindow.xaml**: Defines the visual layout of the game board and control buttons, creating a simple and user-friendly interface.
- **MainWindow.xaml.cs**: Contains all essential game logic, including:
  - **Player turns and move validation**: Ensures that players alternate turns and checks that moves are valid.
  - **Win and draw conditions**: Verifies when a player has won (three in a row) or if the game is a draw.
  - **Game reset**: Resets the game state and UI for a new round after each game.

## Project Status
Current status: **Complete**  
This project serves as a learning exercise to demonstrate C# and WPF capabilities. No additional updates are currently planned.

## Layout of Application
The game layout consists of a 3x3 grid where players can click to mark their symbol (X or O). The layout is kept minimal to focus on basic functionality and user experience.
<img width="960" alt="image" src="https://github.com/user-attachments/assets/1384108e-be44-477d-9bf2-f628ad7305d4">
