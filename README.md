# On Screen Direction and Position Indicator/Pointer for Unity

---

[Asset Store Download Link](https://u3d.as/369A)

Purpose is to simplify on screen direction indicator common in 3D games where an arrow head is pointing toward a game object, or a waypoint or an enemy or an objective.

# Setup

Setting up this system is pretty straight forward.

* There are a total of two script `OnScreenPointerController` and `OnScreenPointerObject`.

* `OnScreenPointerController` is a singleton. This script mainly contains enviroment info needed for this plugin.

* `OnScreenPointerController`needs two references. Camera related to player and ui `RectTransform` . 

* `RectTransform` will contain all the pointers. Purpose is to have one place for managing all pointers.

* `OnScreenPointerController` has Camera reference. If it is null, plugin will try to find `Main Camera` and use it.

* `OnScreenPointerObject`is attached is to target game object whose position we intend to track in realtime during our gameplay session.
  
  * `offset_local` is normalized screen size in `x` and`y`direction. During final result calculation, `offset_local.x` is multiplied with `screenWidth`and result is the padding from screen edges. (same process repeats for `y`and`screenHeight`).
  
  * `MoveInCicle` is use to place pointer at a fix distance from screen center. Smaller dimension is choosen from screen size and pointer is placed along that angle. Distance from center is controlled by `circleSizeNormalized`. Example: pointer is placed at a mid-way from screen center to screen edge when `circleSizeNormalized`is `0.5`
  
  * `inScreenSprite`: Pointer Image when object is with in screen area whether visible or not. 
  
  * `outScreenSprite`: Pointer Image when object is not in screen. Object may be infront of player but not in periphery of camera view. Object may be in back of player/camera.
  
  * `uiImagePrefab`: Prefab configured for `inScreenSprite`/`outScreenSprite`. Can be a complex assembly of views chained togather. However, current implementation has the assumption that parent Prefab will have a `Image` component.
