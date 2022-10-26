# Team CSC403-002 22F Scrum Project

## Documentation

### In-game music and sounds - Kennedy

Created or obtained game music and sound effects for a multitude of scenarios. Some are played only once, and some are loops which is continuously played.
Below, There is a list of all of the sounds and music that were added, their purpose, and if they were created or obtained from the internet. (Any music that was created was created by Kennedy Ford)

#### world_music.waw
- Created as a loop to give a particular ambiance to the level map.

#### battle_music.wav
- Created as a loop to enhance the battle experience with a sense of urgency.

#### death_music.wav
- Created as a sound to be played once when the player is killed in battle (not looped).

#### win_music.wav
- Created as a sound to be played when the player wins a battle (not looped).

#### pause_sound.wav
- Obtained from the internet for when the user clicks the Escape key to pull up the pause menu (originally from Mario 64) (not looped).

#### oof_sound.mp3
- Obtained from the internet for when the user is hit (not looped) (this sound can be found in many different games).

#### attack_sound1.wav & attack_sound2.wav
- Obtained from the internet for when the player attacks. (originally from Zelda: Ocarina of Time young Link attack sounds) (not looped)

### Multi-key movement - Brendan
Originally, players were only able to move with one arrow key at a time. This branch adds the ability to use more than one key (including WASD). This was accomplished by making, mainly, changes to `FrmLevel.cs`. Both KeyDown() and KeyUp() were modified to two only two things: reset player movement and call a new function, `CheckKeys()`. This new function reads a new instance variable `KeyBindings`and checks *individually* for each binding whether or not the key is pressed. This way, any number of keys can be pressed at any time during the level and `CheckKeys()` should never miss any.

`FrmLevel.cs`'s changes required a few more tweaks. 
1. CheckKeys()` requires a few more inputs. 
2. Since `CheckKeys()` determines the player's next movement direction, `Characer.GoUp()`, `Character.GoDown()`, etc. have been consolidated into a single `Character.GoVector(Vector2 MoveDir)` function. `CheckKeys()` simply calls `GoVector()` with its calculated movement vector. 
3. The `Vector2` struct got a few new functions: `static Add(Vector2 VectorA, Vector2 VectorB)`, `NormalizeSquare()`, and `IsZero()`. `Add()` returns a new vector which is a combination of the provided two. `NormalizeSquare()` makes sure that the magnitude of the vector in either the x or y direction is not greater than 1 unit. `IsZero()` is self-explanatory.

Key bindings can be altered by changing the `KeyBindings` array in `FrmLevel.cs`.
