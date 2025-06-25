# CIGDI Prototyping Workshop: 2D Platformer in Unity

Welcome to the open-source Unity project for the CIGDI Framework Prototyping Workshop! This project is designed to be a hands-on example of how to use the **Co-Intelligence Game Development Ideation (CIGDI)** framework to rapidly prototype a 2D platformer.

This repository is not just a game demo; it's a living document and a practical guide that demonstrates a structured, AI-assisted workflow for turning an idea into a playable prototype efficiently.

## Project Overview

This project is a minimal but functional 2D platformer featuring:
- A single player character with physics-based movement (move and jump).
- A basic enemy system with collision-based combat.
- A simple UI and Game State Manager to handle health, menus, and restart conditions.
- A complete set of documentation designed around the CIGDI framework.

---

## What is the CIGDI Framework?

Before diving into the project, it's important to understand the workflow we're using. **CIGDI** is a structured methodology for the chaotic early stages of game development. It's designed to help solo developers and small teams build better prototypes, faster.

The core philosophy is **Co-Intelligence**: treating modern AI not just as a tool, but as a creative partner or a junior assistant. We use AI to streamline the tedious parts of development so we can focus on what's truly important: **making a great game.**

This Unity project and its `Documentation/` folder serve as a real-world example of the CIGDI process in action.

### How This Project Uses CIGDI

* **Game Concept & Design (`GameConceptDesign.md`):** This is the output of our initial **AI-Enhanced Concept Generation** and **AI-Assisted Research**. We used AI to brainstorm core mechanics and structure our initial Game Design Document.
* **Technical Design (`TechnicalDesign.md`):** This document outlines the core systems. An AI assistant can help draft these technical specs based on the GDD, saving valuable time.
* **Development Log (`DevelopmentLog.md`):** This tracks our progress, challenges, and solutions, creating a knowledge base that AI can later summarize to identify patterns or recurring issues.
* **Prototyping Sprints (`NextSessionTasks.md`):** This shows how we break down large goals (like implementing an enemy system) into small, manageable tasks for a development sprint. The initial plan in `TempPlan.md` was a raw "braindump" that we refined into these actionable steps, a process AI can facilitate.

---

## Getting Started

### Requirements
* Unity 2022.3 or later
* A code editor like Visual Studio or Rider (Cursor IDE is recommended for its integrated AI features).
* A basic understanding of Git/GitHub.

### Setup Instructions
1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/zeenaz/Workshop-Cursor-GitHub-01.git
    ```
2.  **Open in Unity:** Open the project folder using Unity Hub.
3.  **Explore the Scene:** The main scene is located in `Assets/Scenes/`. Open it to see the player, ground, and enemy setup.
4.  **Press Play:** Hit the Play button in the Unity Editor to test the current build.

### Controls
* **Move Left/Right:** `A`/`D` or `Left`/`Right` Arrow Keys
* **Jump:** `Spacebar`

---

## Current Development Sprint ⏳

This section tracks the immediate tasks for the current development phase. The goal is to implement a complete gameplay loop where the player can be defeated by an enemy and restart the game.

### High-Priority Tasks
1.  **UI Implementation:**
    * Create a functional health display system on the main UI Canvas.
    * Set up and link the UI panels for the Main Menu, Pause Menu, and Game Over screen in the `UIManager`.
2.  **Game State Management:**
    * Complete the `GameStateManager` to handle scene transitions (e.g., from Main Menu to Game).
    * Implement the player death and game restart system.
3.  **Enemy System:**
    * Finalize enemy behavior logic in the `EnemyController`.
    * Ensure the collision-based damage system is working correctly.

### Testing Checklist for this Sprint
- [ ] Does the UI health display update correctly when the player takes damage?
- [ ] Does the player die when health reaches 0?
- [ ] Does the "Game Over" screen appear upon player death?
- [ ] Does the restart functionality work as intended from the Game Over screen?
- [ ] Do all buttons in the Main Menu and Pause Menu work correctly?

*(For more granular, step-by-step instructions for these tasks, see the [NextSessionTasks.md](Documentation/NextSessionTasks.md) file.)*

---

## Project Structure & Documentation

A clean, well-organized project is a core principle of the CIGDI framework.

### Project Folders

Assets/
├── Scripts/            # All C# scripts, organized by function
├── Scenes/             # All game scenes
├── Prefabs/            # Reusable GameObjects like Player, Enemy
├── Sprites/            # All 2D art assets
└── ... (other asset folders)


### Documentation Folder
All our planning and design documents live in the `Documentation/` folder at the root of the repository. This separation keeps our game assets clean while making the "paperwork" easily accessible.

* **[Game Concept Design](Documentation/GameConceptDesign.md):** The "Why" and "What." Our high-level vision, core gameplay loop, and features.
* **[Technical Design](Documentation/TechnicalDesign.md):** The "How." The architecture and technical specifications for our game's systems.
* **[Development Log](Documentation/DevelopmentLog.md):** The "When." A running log of our progress, challenges, and decisions.
* **[Naming Conventions](Documentation/NamingConventions.md):** The "Rules." A crucial document for keeping the project clean and consistent, especially when collaborating.
* **[Task Planning Docs](Documentation):** Includes our rough `TempPlan.md` and the more refined `NextSessionTasks.md` for our current sprint.

---

## Contributing & Learning

This is an open-source project designed for learning. You are encouraged to:
* **Fork the project** and experiment with your own features.
* **Follow the documentation** to understand *why* things are built the way they are.
* **Try using the CIGDI framework** for your own prototypes! Use AI to help you draft a GDD or plan your next feature.

This project is licensed under the MIT License. Feel free to use it for your own educational purposes.
