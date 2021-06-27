<h1 align="center">Unity Platformer</h1>

## About this project

The ***Unity Platformer*** is a simple platformer game developed with the purpose of learning how to use the Unity Engine, as well as learning how to work with imported 3D objects and audio.

### Part 1: Models and Textures

**Results of this part**:
- Created the first stage.
- Established the playable character's movement controls.
- Implemented camera control.

### Part 2: UI

**Results of this part**:
- Created the following stages:
  - Main Menu
  - Options Menu (Sliders not implemented yet).
  - Two more levels.
- Created a functional level selection screen.
- Implemented a pause screen (which also pauses the game).
- Implemented a timer that starts when you move and stops when you reach the goal.
- Completing a stage shows a results screen, with the final time and the option to either return to the main menu or go to the next level.
  - Returns to the main menu if you completed the final level.
- Camera Y-axis can be inverted, if prefered.
  - This configuration persists after closing the game.

### Part 3: Animation

**Results of this part**:
- Replaced the capsule placeholder with a human.
- Added animations to the human for the following situations:
  - Idle
  - Moving
  - Jumping
  - Falling from a large distance
  - Lands from a large distance.
- Added animated intros for each level.

### Part 4: Audio

**Results of this part**:
- Main menu and each level now have their own background music.
- Footsteps now make a sound, depending if moving on grass or rock.
- Landing (from a large distance) makes a "thump" sound.
- Added bird noises when near of a tree.
  - Not all trees have this sound.
- Added cricket noises when near tall grass or foillage.
  - Not all foillage has this sound.
- Added a jingle after completing a level. This also stops the current level's background music.
- Volume slider on the Options Menu are functional, and the adjustments persist even after closing the game.

## Running this project

If you are interested in running the Unity project, keep the following in mind:
- Unity Engine **2019.4 or better**.

## Plans for the future

While I am happy with the current state of the project, I'm aware that there is room for improvement.

### Movement rework

Based on the knowledge I gained on a previous project, I decided to use Physics-based movement for the character. While it helped me to focus on the X and Z movement, I'm not that content on how the character jumps, especially when jumping from a steep.

My plan involves on replacing the Physics based movement with Unity's CharacterController.

### Level Redesign

I'm content on leaving the game with three stages, but I know I could improve the design of those levels.

Besides adding more foillage and platform variety, I plan on changing the layout of the level so it doesn't feel like, random floating platforms.

***

## Contact info
### **Jaime Andrés Gálvez Villamarin**
- LinkedIn: [Jaime Andrés Gálvez Villamarin](https://www.linkedin.com/in/jaime-andr%C3%A9s-g%C3%A1lvez-villamarin-434472192/)
- Twitter: [@JaimeAndrsGlve1](https://twitter.com/JaimeAndrsGlve1)


## Credits
- Kenney: https://kenney.nl/
- Oculus Audio Pack: https://developer.oculus.com/downloads/package/oculus-audio-pack-1/
- Mindful Audio: https://mindful-audio.com/
- “Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)
   Licensed under Creative Commons: By Attribution 3.0
   http://creativecommons.org/licenses/by/3.0/
