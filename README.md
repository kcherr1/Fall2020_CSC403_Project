# Team CSC403-002 22F Scrum Project


## Documentation

### In-game music and sounds - Kennedy

Created or obtained game music and sound effects for a multitude of scenarios. Some are played only once, and some are loops which is continuously played.
Below, There is a list of all of the sounds and music that were added, their purpose, and if they were created or obtained from the internet. (Any music that was created was created by Kennedy Ford)

<br/>

#### Currently Implemented Sounds / Music:
<hr/>

#### world_music.waw
- Created as a loop to give a particular ambiance to the level map.

#### battle_music.wav
- Created as a loop to enhance the battle experience with a sense of urgency.

#### death_music.wav
- Created as a sound to be played once when the player is killed in battle (not looped).

<br/><br/>

### Sounds / Music to Be Implemented:
<hr/>

#### win_music.wav
- Created as a sound to be played when the player wins a battle (not looped).

#### pause_sound.wav
- Obtained from the internet for when the user clicks the Escape key to pull up the pause menu (originally from Mario 64) (not looped).

#### oof_sound.mp3
- Obtained from the internet for when the user is hit (not looped) (this sound can be found in many different games).

#### attack_sound1.wav & attack_sound2.wav
- Obtained from the internet for when the player attacks. (originally from Zelda: Ocarina of Time young Link attack sounds) (not looped)

<br/><br/>

### Known Bugs:
- When the final boss music plays, the GUI freezes due to a sleep function added to make sure the final_battle.wav file doesn't play and overlap the battle_music.wav.
- After the user defeats the final boss, the world music will begin to play again. Need to add a success screen that stops the music and gives the user the ability to either end the game or restart the game.
