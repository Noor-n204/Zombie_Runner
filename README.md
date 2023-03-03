# Zombie_Runner

# week 1
   After investigating the options we had ,We choosed to go with option number 4 and develope a PC game.
   started doing some toturials on Unity .(7 hours)
     
# week 2     
   we started to think of a game idea , the insperation was Temple Run we’ve made changes that instead of a monster is chasing you, you are going 
   in an opposite direction, of zombies who are trying to eat you.
   created the pitch and continued the Unity toturials.(8 hours)
    
    
# week 3
  created new project and used Unity version 2020.3.30f1. base project folder hierarchy added, including packages and some main project settings.(7 hours)

# week 4+5
created zombie caracter in Maya and exported them as fbx files to the Unity project with basic animation , faced a bug with animation retargeting , fixed                them in Maya and exported them agin.
added UIManager.cs script that is used to manage all game menus and UI related jobs, currently added 3 menus (main menue, game play, pause menu).                        UIManager has a function "ButtonPressed" that listens to all the UI button click events. It takes a string as a parameter that is used to differentiate the              functionality of a button. The flow of the menus as as follows:
Upon starting/launching the game, the very first screen visible to the user will be the main menus screen. It has 1 play button. On clicking the play button the          Gameplay screen gets enabled, where the user will see his character and zombies. The top right cover contains the distance tab, players current distance travelled        will appear there. On the top left corner of the gameplay screen is a pause button. On clicking the pause button, pause screen appears that contains two buttons:        The resume button that takes player back to the gameplay screen and the end button that takes player to the main menu screen and quit the game. (19 hours)
     
     
# week 6
Added forest environment. Implemented EnvironmentSpawner.cs script responsible to spawn forest prefabs once the player reaches the midpoint of the current forest prefab. This is made to give players a feel of an infinite environment. The midpoint of the environment is detected through Checkpoint.cs script. A gameobject with a box collider of trigger type has checkpoint script attached with it. Whenever the player gets into the trigger of this collider, it calls the environmentspawner to destroy the previous forest and randomly spawn the new forest out of 3 in front of the current forest.(9 hours)

     
 
https://user-images.githubusercontent.com/82387551/208715030-64907504-c179-409b-83a7-50be2fec21ef.mp4


# week 7
Integrated PlayerController.cs script responsible to move the player in the game. Player always moves forward in the environment at a constant speed (Can change depending upon the distance covered to keep up the difficulty). Player's basic animator controller was added with Idle, run, and death animations. Player controller has an Update function that moves the player. The movement starts when the user clicks the play button. Player can be paused by clicking the pause button and resuming to move again.
Added player right and left movements on pressing 'A' and 'D' key respectively. We faced a bug were the character would go off the paths if we keep pressing left or right. The bug was in the values(10 hours)


https://user-images.githubusercontent.com/82387551/222795110-fc40c16e-c197-4c7b-87f6-2d5d755a7615.mp4




# week 8 
Added ZombiesSpawner.cs and ZombieController.cs. ZombiesSpawner is responsible for spawning zombies randomly in the lanes. Spawner instantiates 2 types of zombies, 1 remains idle while the other walks forward. Both types of zombies can attack the player once he comes in range. Both zombies has their own animators. Their gameobject has a box collider of trigger type attached and a rigidbody and ZombieController to control the AI. The damage and speed of the zombies can be set in the inspector. Also, the type of zombie is to be set in the inspector. Currently, we have 2 types so 0 and 1 index is used. 0 is for the idle zombie while 1 is for walking. The Player's health is also integrated and the game ends when the player dies. (8 hours)

# week 9

we didnt made any progress this week due to busy schedule.

# week 10
   Added zombies and player textures. fixed a couple of bugs that we faced after the previous changes. such as:
     Zombie movement through the game pause screen is fixed. Zombie keeps on moving behind the pause screen, while the player was stopped before. (7 hours)
     
     

https://user-images.githubusercontent.com/104002892/218794725-315c9707-0814-4907-9930-ca478012e692.mp4


     
 # week 11
 Integrated bullets system. Spawning bullets with the desired firerate according to the gun player has. 
 We can set the firerate in Utilities.cs with 2 constant floats named as PistolFireRate, SMGFireRate for pistol, and smg accordingly. 
 The firerate is the the delay between each bullet fired if the user press and holds Up/W key. 
 A bullet prefab is created in Prefabs/Weapons folder, this prefab gets spawned depending upon the input and firerate. 
 The speed of the bullet can be set in the inspector view of the bullet prefab. The prefab has CollisionEnter fuction that listens to the bullet hit. 
 If a zombie comes in collision with the bullet, it destroys the bullet and plays the kill animation of the zombie. (9 hours)
 
 # week 12
 
 Implemented WeaponsSpawner.cs, a script that handles the spawning of weapons. It spawns the SpawnedWeaponsHandler.cs, the script responsible for randomly appearing weapons in the scene. 
 The SpawnedWeaponHandler listens player's collision and then sets the gun (pistol, SMG) in PlayerController accordingly. 
 Both pistol and SMG bullet counts can be set in Utilities.cs script. The weapons spawn time increases in the form of multiples of the value set in inspector of WeaponsSpawner. Currenlty it spawns in following interval of seconds, (2,4,6,8,10,...) (9 hours)
 
 # week 13
 
 Added bullets, zombie kill, attack, the player hit, death, pick up guns sounds and effects.
Added skybox in the scene and fog and lighting adjustments.
Added player's running with gun animation and transition in animator. (7 hours)

# week 14
Added a quit button in the main menu screen that quits the game on clicking.we had some bugs to fix from previous pushes we did(including debugging and investigating), while working on the game during the exams,
Fixed zombie attacking the player issues, before the zombie's attack animation gets player way later even when the player passes through it. The collider on the zombie is moved further forward to start attacking before.
The zombie hit-by-bullet issue is fixed. By the solution of the previous issue, now the bullet also hits the zombie way before, as the collider was shifter forward. Fixed this issue by using the other non-trigger collider and using the OnCollisionEnter function instead of OnTriggerEnter.
The animation transition fixes the previous state getting stuck when the player gets a weapon. Issue was with the animation transition state condition, which has been set to the greater than value, whereas it was required to be set as equal to.
Fixed the distance counter error, it keeps on counting the distance till the player's death animation gets played, even the player was not moving at all. (10 hours)
 

https://user-images.githubusercontent.com/82387551/222796463-45dcef54-e180-4109-83d4-aef3deafc5e1.mp4




