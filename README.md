# Fall2020_CSC403_Project




### Multi-key movement - Brendan
Originally, players were only able to move with one arrow key at a time. This branch adds the ability to use more than one key (including WASD). This was accomplished by making, mainly, changes to `FrmLevel.cs`. Both KeyDown() and KeyUp() were modified to two only two things: reset player movement and call a new function, `CheckKeys()`. This new function reads a new instance variable `KeyBindings`and checks *individually* for each binding whether or not the key is pressed. This way, any number of keys can be pressed at any time during the level and `CheckKeys()` should never miss any.

`FrmLevel.cs`'s changes required a few more tweaks. 
1. CheckKeys()` requires a few more inputs. 
2. Since `CheckKeys()` determines the player's next movement direction, `Characer.GoUp()`, `Character.GoDown()`, etc. have been consolidated into a single `Character.GoVector(Vector2 MoveDir)` function. `CheckKeys()` simply calls `GoVector()` with its calculated movement vector. 
3. The `Vector2` struct got a few new functions: `static Add(Vector2 VectorA, Vector2 VectorB)`, `NormalizeSquare()`, and `IsZero()`. `Add()` returns a new vector which is a combination of the provided two. `NormalizeSquare()` makes sure that the magnitude of the vector in either the x or y direction is not greater than 1 unit. `IsZero()` is self-explanatory.

Key bindings can be altered by changing the `KeyBindings` array in `FrmLevel.cs`.