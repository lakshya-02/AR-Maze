# AR Maze

**AR Maze** is an Augmented Reality game developed using Unity and Vuforia. The objective is to navigate a rolling ball through a physical maze environment, overlayed in AR, until it reaches the endpoint.

## 🧠 Features

- Augmented Reality integration with Vuforia.
- Real-time physics-based maze ball control.
- Touch-free interaction using physical device movement.
- Dynamic ball behavior with collision detection.
- End goal trigger with feedback system.

## 🎮 Gameplay

Once the image target is detected, the maze appears in AR. A ball spawns inside the maze and physics constraints are lifted after a short delay, allowing the user to tilt their phone to navigate the ball through the maze and reach the end capsule.

## 🔧 Tech Stack

- **Unity** (2022+)
- **Vuforia** Engine (Image Target-based AR)
- **C#** for game logic and interaction
- **Physics-based mechanics** using Unity's Rigidbody and Collider components
-  
## 🚀 Getting Started

1. Clone the repository or download the Unity project.
2. Open it in Unity Editor.
3. Import the Vuforia Engine (via Unity Package Manager or Vuforia SDK).
4. Set your AR camera and Image Target.
5. Add the Ball prefab and Maze to the scene.
6. Build and deploy to a mobile device.

## ✅ Important Notes

- Ball physics are frozen initially and are unfrozen after image tracking is successful.
- Ball is only instantiated once to prevent duplicate spawns.
- Make sure to enable `World Space` for UI if using Canvas in AR view.
- AR Camera position doesn’t need to be changed in-editor; real-world movement handles interaction.

## 📸 Demo

<img width="607" height="623" alt="Screenshot 2025-07-17 200459" src="https://github.com/user-attachments/assets/3b9bcd0f-9075-435c-95c5-0596016e00ed" />


https://github.com/user-attachments/assets/740624f3-a980-45cf-99f0-5301ed7e7d78



## 🙌 Credits

Created by Lakshya Singh. Inspired by AR-based maze games combining physics puzzles and spatial tracking.

---



