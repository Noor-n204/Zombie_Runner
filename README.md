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
Added forest environment. Implemented EnvironmentSpawner.cs script responsible to spawn forest prefabs once the player reaches the midpoint of the current forest prefab. This is made to give players a feel of an infinite environment. The midpoint of the environment is detected through Checkpoint.cs script. A gameobject with a box collider of trigger type has checkpoint script attached with it. Whenever the player gets into the trigger of this collider, it calls the environmentspawner to destroy the previous forest and randomly spawn the new forest out of 3 in front of the current forest.

     
 
https://user-images.githubusercontent.com/82387551/208715030-64907504-c179-409b-83a7-50be2fec21ef.mp4


# week 7
Integrated PlayerController.cs script responsible to move the player in the game. Player always moves forward in the environment at a constant speed (Can change depending upon the distance covered to keep up the difficulty). Player's basic animator controller was added with Idle, run, and death animations. Player controller has an Update function that moves the player. The movement starts when the user clicks the play button. Player can be paused by clicking the pause button and resuming to move again.
Added player right and left movements on pressing 'A' and 'D' key respectively. We faced a bug were the character would go off the paths if we keep pressing left or right. The bug was in the values

