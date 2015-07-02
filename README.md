# WolfEngine

The challenge of this project is to only use the System.Drawing framework. That means _No OpenGL, no OpenTK, no DirectX, no XNA._
<p align="center">
<img src="http://www.adweek.com/socialtimes/files/2012/05/wolfenstein-logo-type-300x80.png"/>
</p>
### Map creation

Maps are in the format of (x₁, y₁, z₁)-(x₂, y₂, z₂)-texture.bmp.

a Map is an array of walls, and a wall is an object with two 3D vectors (top left and bottom right corners of the wall) and a texture bitmap.

The vectors should be written in clockwise order.

### Example Map

![Example Map](http://i.imgur.com/iTn9l56.png)

```csharp
(10, 10, 40)-(30, 10, 40)-Textures/StoneWall.bmp
(30, 10, 40)-(30, 10, 30)-Textures/StoneWall.bmp
(30, 10, 30)-(40, 10, 30)-Textures/StoneWall.bmp
(40, 10, 30)-(40, 10, 10)-Textures/StoneWall.bmp
(40, 10, 10)-(20, 10, 10)-Textures/StoneWall.bmp
(20, 10, 10)-(20, 10, 20)-Textures/StoneWall.bmp
(20, 10, 20)-(10, 10, 20)-Textures/StoneWall.bmp
(10, 10, 20)-(10, 10, 40)-Textures/StoneWall.bmp
```

#### Read more at http://emcf.github.io/projects.html
