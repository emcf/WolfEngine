# WolfEngine

A C# .NET remake of the Wolfenstein-3D Engine. The challenge of this project: No libraries.

![Wolfenstein Logo (id Software)](http://www.adweek.com/socialtimes/files/2012/05/wolfenstein-logo-type-300x80.png)

### Map creation

Maps are in the format of (x₁, y₁, z₁)-(x₂, y₂, z₂)-texture.bmp
a Map is an array of walls, and a wall is an object with two 3D vectors (top left and bottom right corners of the wall) and a texture bitmap.

### Example Map

![Example Map](http://i.imgur.com/iTn9l56.png)

```csharp
(10, 10, 40)-(30, 10, 40)-mossy.bmp
(30, 10, 40)-(30, 10, 30)-mossy.bmp
(30, 10, 30)-(40, 10, 30)-mossy.bmp
(40, 10, 30)-(40, 10, 10)-mossy.bmp
(40, 10, 10)-(20, 10, 10)-mossy.bmp
(20, 10, 10)-(20, 10, 20)-mossy.bmp
(20, 10, 20)-(10, 10, 20)-mossy.bmp
(10, 10, 20)-(10, 10, 40)-mossy.bmp
```
