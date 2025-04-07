# Dread Halls

A first-person horror game built in Unity with procedurally generated maze-like environments, atmospheric lighting, and enemy AI.

![Dread Halls Screenshot](screenshots/screenshot.png)

## Description

Dread Halls is a first-person horror experience that challenges players to navigate through procedurally generated maze-like environments while avoiding dangerous entities. The game features:

- Procedurally generated levels ensuring a unique experience each playthrough
- Atmospheric lighting that creates tension through limited visibility
- Enemy AI that hunts the player through the environment
- Immersive audio cues that enhance the horror experience

This project was created as part of CS50's Game Development course, marking a transition into 3D game development.

## How to Play

### Controls
- WASD: Movement
- Mouse: Look around
- Shift: Run (limited stamina)
- E: Interact with objects

### Objective
Navigate through the maze and find the exit while avoiding the entities that lurk in the darkness.

## Development

### Built With
- Unity Engine
- C# for game logic and AI
- Unity's Standard Assets for first-person controller

### Project Structure
- `Assets/Scripts/` - Contains all C# scripts including level generation logic
- `Assets/Prefabs/` - Reusable game objects like wall and floor blocks
- `Assets/DungeonModules/` - Modular pieces used for procedural generation
- `Assets/Scenes/` - Different game scenes (title, play, game over)
- `Assets/Sounds/` - Audio files for atmosphere and effects
- `Assets/Fonts/` - Custom fonts used in the UI

## Installation and Setup

1. Clone the repository
2. Open the project in Unity (version 2018.x or later)
3. Open the scene `Assets/Scenes/Title.unity` to start from the beginning

## Demo

[Watch the gameplay demo](https://www.youtube.com/watch?v=K3X_o2Jlahg&t=2s)

## Features

- **Procedural Level Generation**: Each playthrough features a unique maze layout
- **Atmospheric Horror**: Dim lighting and ambient sounds create a tense atmosphere
- **Enemy AI**: Entities that patrol the halls and react to player presence
- **Pickup System**: Collectible items scattered throughout the maze
- **Level Counter**: Track your progress as you descend deeper into the halls

## Credits

- Developed by Ethan Perello
- Created as part of CS50's Game Development course
- Audio credits:
  - Background ambient: "Whispers Loop Mix" by AshleyXXPiano
  - Horror effects: "Bad Horror Movie Sound" by Lennyboy
  - Game over music: "Game Over Dark Orchestra" from Mixkit
