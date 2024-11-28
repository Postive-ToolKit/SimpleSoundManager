# SimpleSoundManager

SimpleSoundManager is a Unity package designed for easy management and usage of sound assets. 
With the help of SoundDB, you can add new sounds, adjust volume, pitch, 3D sound settings, and more.

This package is based on the [CategorizedDB](https://github.com/Postive-ToolKit/CategorizedDB) package. 
Please install [CategorizedDB](https://github.com/Postive-ToolKit/CategorizedDB) first.

## Table of Contents
- [SimpleSoundManager](#simplesoundmanager)
  - [Table of Contents](#table-of-contents)
  - [Other Languages](#other-languages)
  - [Features](#features)
  - [Getting Started](#getting-started)
    - [Creating SoundDB](#creating-sounddb)
    - [SoundDB Editor](#sounddb-editor)
    - [Adding SoundData](#adding-sounddata)
    - [Modifying SoundData Values](#modifying-sounddata-values)
      - [Settings Overview:](#settings-overview)
      - [2D and 3D Sound](#2d-and-3d-sound)
      - [3D Sound Settings](#3d-sound-settings)
    - [Deleting SoundData](#deleting-sounddata)
    - [Selecting Sound](#selecting-sound)
    - [Playing Sound](#playing-sound)
  - [Installation](#installation)
    - [Using Git URL](#using-git-url)
  - [Conclusion](#conclusion)
## Other Languages
- [한국어](Doc/README-kr.md)
## Features
- Manage sounds
- Add and modify sound properties
- Change sound categories

## Getting Started
Here’s how to install using the [Unity Package Manager](#using-git-url).

### Creating SoundDB
![image](https://github.com/user-attachments/assets/f792856b-9d35-4925-a8fa-155a4cab6cf2)

First, create a database to manage sounds. Go to `Assets > Create > Data > SoundDB` to create a SoundDB.

### SoundDB Editor
![image](https://github.com/user-attachments/assets/e4b94d4b-99ff-4448-9a2a-2ca358d28c2a)

The SoundDB Editor is used to manage the database of SimpleSoundManager. Using the editor, you can add or edit sounds.

- The left TreeView allows selecting categories or sounds, and you can open a context menu with a right-click to add or delete sounds.
- The right Inspector lets you modify the selected category or sound data and settings.

### Adding SoundData
![image](https://github.com/user-attachments/assets/2d63fda4-58b2-4193-9b30-8c1465a6c9a9)

You can open the context menu in the left TreeView by right-clicking. The currently selected category is shown at the top of the menu. If no category is selected, sounds will be added to the Root category.

To return to the Root category after selecting a specific category, double-click in the TreeView.

### Modifying SoundData Values
![image](https://github.com/user-attachments/assets/52e2ac77-6992-4a80-ad1c-c6e03c363ec4)

At the top of the sound settings, you can set the category and name of the SoundData. These settings determine the path displayed in the editor.

The `Sound Settings` section below allows you to configure the volume, pitch, and whether the sound is 2D or 3D.

#### Settings Overview:
- `Mixer`: Select the mixer to adjust the volume of the sound.
- `Clips`: Choose sound clips to play. If more than one is selected, one is played randomly.
- `Spatial Blend`: Adjust the blend between 2D and 3D sound. 0 means 2D, and 1 means 3D. Enabling 3D sound activates additional options.
- `Use Random Volume`: Toggle random volume settings.
  - `Volume`: Set sound volume or a range for random volume if enabled.
- `Use Random Pitch`: Toggle random pitch settings.
  - `Pitch`: Set sound pitch or a range for random pitch if enabled.

#### 2D and 3D Sound
2D sounds are unaffected by position, while 3D sounds vary with distance. Adjust the `Spatial Blend` to configure the ratio of 2D to 3D sound.

For 3D sound, set the `Spatial Blend` to a value above 0 and configure `Min Distance` and `Max Distance`. These determine the effective range of the sound.

#### 3D Sound Settings
![image](https://github.com/user-attachments/assets/c22cef17-b1ad-421d-ac89-0d2014913300)

When using 3D sound, additional settings appear:
- `Min Distance`: Set the minimum distance for the sound.
- `Max Distance`: Set the maximum distance for the sound.

**Graph Properties:**
- `Doppler Level`: Adjust the Doppler effect.
- `Volume Rolloff`: Configure volume attenuation over distance.
- `Spatial Blend`: Control the extent of 3D sound.
- `Reverb Zone Mix`: Adjust the effect of reverb zones.

### Deleting SoundData
![image](https://github.com/user-attachments/assets/0a52bcac-ab4d-4cf5-8d23-0b64d42eff43)

Select the sound you want to delete, right-click, and choose `Delete` from the menu.

### Selecting Sound
![image](https://github.com/user-attachments/assets/e7480efa-722e-4a56-9184-027df7a63b19)

### Playing Sound
Sound playback is managed via the `SoundManager` class. Use the following code to play sounds:

```csharp
using Postive.SimpleSoundAssetManager.Runtime;
using Postive.SimpleSoundAssetManager.Runtime.Attributes;
using UnityEngine;
public class TestComponent : MonoBehaviour
{
    [SoundSelector] [SerializeField] private string _sound;

    private void PlaySound() {
        SoundManager.PlaySound(_sound, transform.position);
    }
}
```

- Use the `SoundSelector` attribute to choose a sound from the SoundDB.
- `SoundManager.PlaySound` plays the sound using its GUID.

You can pass a `Vector3` or `Transform` to specify the playback position.

## Installation
Before installing, ensure you’ve already installed [CategorizedDB](https://github.com/Postive-ToolKit/CategorizedDB).

### Using Git URL
Tested on Unity versions 2019.3.4f1 and above. Use the following URL in Unity Package Manager to install:

`https://github.com/Postive-ToolKit/SimpleSoundManager.git`

![image](https://github.com/user-attachments/assets/c1a97d72-5be2-429f-89ac-0198418abf2d)

![image](https://github.com/user-attachments/assets/186f3c73-23e9-4c41-96c6-5256b43a234a)

## Conclusion
Follow the steps above to install and use SimpleSoundManager. Simplify sound management and usage in Unity with SimpleSoundManager!