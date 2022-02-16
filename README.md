# Frontline
<img src="https://github.com/babaukos/screenshots/blob/main/FrontlineTool.png" width="400" height="200">
This is a simple example for adding front line visualization

## Problems
- In this example, points are recalculated in Update , which is not very good.
- The front line, at sharp points, is very broken. To eliminate this, you need to use bazier curves
- For good, you need to use a shader that is drawn on top of the terrain
