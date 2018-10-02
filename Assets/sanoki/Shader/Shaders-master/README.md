# Shaders
A collection of shaders written in CG/ShaderLab for Unity used in the development of Poi.

BetterTransparentDiffuse.shader
------
The default Unity shader for transparent objects suffers from some overlapping issues on complex objects (as seen on the left). This shader fixes the problem by rendering the object in two passes (as seen on the right). The center opaque image is for reference.<br /> <br />
![Alt text](http://i.imgur.com/hdVh1cd.png "Transparent (improved)")

Silhouette.shader
------
This simple two-pass shader renders a silhouette on top of all other geometry when occluded. We used this effect in Poi for objects that weren't marked as camera occluders so players would always be able to see the character.<br /> <br />
![Alt text](http://i.imgur.com/SlbcsBo.png "Silhouette")

Checkerboard.shader
------
A basic shader to render a two-colored checkerboard pattern using the existing vertex UV coords. <br /> <br />
![Alt text](http://i.imgur.com/p1wmJNZ.png "Checkerboard")

DiffuseTwoSided.shader
------
For rendering both sides of an object. For example if it's non-convex or an animated plane used for a flag/cloth, etc. <br /> <br />
![Alt text](http://i.imgur.com/aZl21ag.png "Diffuse two-sided")

ScreenDistortion.shader
------
This image effect takes a normal map as input and applies it to the screen as a post-process. The normal map will always be centered and scaled appropriately independent of aspect ratio and window resolution. We used this effect for the telescope item in Poi, but it would also work great for sniper scopes, etc.<br /> <br />
![Alt text](http://i.imgur.com/69SYsON.png "Screen Distortion")
![Alt text](http://i.imgur.com/q8Gs5z2.png "Screen Distortion (in-game)")
