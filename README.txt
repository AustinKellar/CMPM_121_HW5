Controls:
- WASD to move
- L Shift to sprint
- Space to jump
- F to toggle flashlight

Cameras:
- Room 1: static camera
- Room 2: Camera that looks at the player (fixed position)
- Room 3: Camera that follows the player along z axis (fixed rotation)

Lights:
- Room 1: Realtime point light near the camera
- Room 2: Realtime spot light near the camera that looks at the player
- Room 3: Baked light above the cylinder and capsule
- Player flashlight: Realtime spot light that follows the player
- All lights have shadows set to Hard Shadows

Notes:
- I got the player asset from the asset store. It came with a movement script but I deleted it
  so that I could make my own movement code. I am using the animations that came with the asset.
  I also used this asset for assignment 2. None of the movement code has changed since then.