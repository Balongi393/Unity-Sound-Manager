# Unity C# Sound Manager

## Overview

This Unity C# Sound Manager is a versatile solution for handling various types of sounds in your game, including gameplay sounds, UI sounds, and background sounds. It provides a centralized system for managing and playing audio clips, promoting clean code architecture, and easy sound integration across your project.

## Features

- **Modular Sound Categories:** Separates sounds into three categories - Gameplay, UI, and Background, allowing organized sound management.
- **Dynamic Dictionary System:** Utilizes dictionaries to store and retrieve audio clips dynamically, making it easy to expand and modify your sound library.
- **Singleton Design:** Implements a singleton pattern to ensure only one instance of the Sound Manager exists throughout the game, maintaining consistency in sound playback.

## How to Use

1. **Download the Repository:**
   Clone or download the repository and open it in Unity.

2. **Setup Folder Structure:**
   Organize your audio clips in the "Resources" folder. Create subfolders such as "Gameplay," "UI," and "Background" to categorize your sounds.

3. **Add Audio Clips:**
   Add your audio clips to the respective folders. Ensure they are set as "AudioClip" types and have clear, meaningful names.

4. **Update Sound Dictionaries:**
   Open the SoundManager script and update the dictionaries in the Awake method. Add entries for each audio clip, specifying the category and correct path.

5. **Usage in Scripts:**
   In your scripts, use the SoundManager.instance.PlayGameplaySound, SoundManager.instance.PlayUISound, or SoundManager.instance.PlayBackgroundSound methods to trigger the respective sounds.

   ![Example](https://github.com/Balongi393/Unity-C-Sound-Manager/assets/62468041/6d242e46-517c-477e-9440-48e7ee02998b)

6. **Test in Unity:**
   Attach the SoundManager script to an empty GameObject in your scene. Play your scene in Unity and test the sound playback in different scenarios.

7. **Customization and Expansion:**
   Feel free to extend the Sound Manager according to your project needs. Add features such as volume control, fade in/out, or integrate with Unity's audio mixer for more advanced audio management.

## Contribution

If you find any issues or want to contribute to the Sound Manager, feel free to fork the repository, make your changes, and create a pull request.

This Sound Manager serves as a foundation for maintaining a clean and efficient audio system in your Unity game. Customize and expand it to enhance the overall gaming experience.
