# in-class-activities
## Devlogs
### W1
After taking Camera off of the Cat GameObject, and running it, the camera just stays in place as we see the Cat moving. This happens because GameObjects nested in another object's hiearchy, will also move with that object, since we took it out of GameObject Cat's hierarchy, Camera no longer moves with it.

[itch.io link](https://ktongson.itch.io/gdim)

### W2

- Why are the r, g, and b variables floats instead of ints, bools, or strings?
The r, g, and b, are floats instead of int, bool, or str because they are decimal values.

- Why is the _bounce variable an int instead of a float, bool, or string?
The _bounce variable is an int instead of flt, bool, or str because its' values are whole numbers, there's no such thing as a half bounce.

- The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?
We didn't finish the statement of code by ending it with a ';'.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 