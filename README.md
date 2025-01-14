[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

How would you describe this game world in objects?
What attributes and actions do these objects have?
How do these objects act on or affect each other?

Player Bunny

Attributes: 
- Bunny Sprite
- WASD: Moves Around
- Space to Plant Seeds

Affected Objects:
- Pass Through Flower 
- Can Go Over Screen
- Can Still Move Around when # of Seeds is 0
- Can No Longer Place Any Seeds when Seeds Remaining = 0

Flower

Attributes:
- Appears on Screen when Space is pressed
- Can be placed anywhere on the screen

Affected Objects:
- Stays on Screen, Never Moves

UI

Attributes:
- Number of Seeds Planted
- Number of Seeds Remaining

Affected Objects:
- Number of Seeds Remaining Changes by -1 when Seed is Planted
- Number of Seeds Plants Changes by +1 when Seed is Planted/Placed on Screen
- Only Changes when Seed is Planted




## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

When starting this project, I followed the outline of my breakdown to complete the project, such as starting with the player movement and concluding with the UI updating whenever the player plants a seed on the Unity scene. I started by changing the Sprite Renderer to another Bunny Sprite from the Sprite Folder and putting the Player's Transform & Plant Count UI Script into the Player (Script) to make it easier to track the Bunny Sprite's position (for later use) and updating the UI. I then started choosing which Plant to make into a Prefab from the Sprites Folder, then turning the Sprite into a Prefab by putting the (Plant) GameObject into the Prefab Folder. After this process, I started updating the Update() function within the Player script to add movement to the (player) Bunny Sprite by making it so that when the player triggers the WASD input, the player's Transform value changes throughout the game, such as the A & D keys modifying the player's Transform X value and W & S keys changing the Y value. The next thing I decided to work on was making it so that when the player presses the Space key, it will call upon the PlantSeed() function and clone the SeedSprite, which I made into a Prefab (beforehand). However, this process slightly differed from making the player's movement since instead of utilizing the (Input.GetKey), I had to use (Input.GetKeyUp) to make the Plant Prefab only Instantiate (clone) once even when the player is holding the Space key. Speaking of Instantiate, cloning the Plant Prefab needed the player's Transform position so the Plant GameObject spawns wherever the Bunny Sprite is on the Unity scene (game screen).

After finishing with the player's movement and making the Plant Prefab spawn and follow along with the Bunny Sprite's position when the player presses Space, I needed to work on the UI for the game by making the SeedsPlantedNumber and SeedsRemainingNumber text update as the Space key is pressed. Starting this process was tricky since I needed the UI, specifically the _numSeedsLeft and _numSeedsPlanted text, to update alongside the PlantSeed() function or when the Space key is detected. Luckily, the PlantCountUI Script allows us to manage these updates by providing an UpdateSeeds() function to directly change the UI when the PlantSeed() function is called upon, specifically _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted). However, this logic initially did not add to the _numSeedsPlanted or subtract from the _numSeedsLeft. I realized that the issue was not in the UpdateSeeds() function, rather it was in the If statement of the Space key since I needed to add _numSeedsPlanted++ and _numSeedsLeft-- to the if statement before PlantSeed() is called since that is what changes the number of seeds planted and remaining text, which (now) changes the UI by adding a value of one to the number of seeds planted and subtracting a value of one from the number of seeds remaining (which is set at 5 in the Start() function).

Overall this project was enjoyable to work on since it allowed me to practice previous topics learned from GDIM 31 and showed me how breaking down the game helps with translating these ideas into the coding stage.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
