# Unity3DStudy
Code made in the projects of the Unity 3D course from GameDev.Tv

## Obstacle Course

This first project will teach basics of 3D game like:
- Creating 3D objects
- Moving 3D ojects
- Cinemachine Camera
- 3D collision

## Addressables

Addressables is a way to save memory. [This article|https://thegamedev.guru/unity-addressables/tutorial-learn-the-basics/] brings the cases in which it's important to manage better the memory. When you consume too much memory, it's possible to the OS to close your program in the smallest task that put your software in background. In game this may cost the lost of some gameplay time and a furious player.

Some of the enemies of memory is:
- A principal object that contains references to many other objects that not necessary will be used;
- Global variables that are constant draining memory. Avoid them;
