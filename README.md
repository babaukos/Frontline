# Frontline
This is a simple example for adding front line visualization
## Problems
-In this example, points are recalculated in Update , which is not very good.
-The front line, at sharp points, is very broken. To eliminate this, you need to use bazier curves
-For good, you need to use a shader that is drawn on top of the terrain
