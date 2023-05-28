# Easings


This library is a collection of easing functions, also known as easing curves or tweening functions, that allow for smooth transitions and animations in Unity.

Functionality

Glaas.EasingCurves library contains the following easing functions:

    Linear
    Ease In / Out / InOut Sine
    Ease In / Out / InOut Quad
    Ease In / Out / InOut Cubic
    Ease In / Out / InOut Quart
    Ease In / Out / InOut Quint
    Ease In / Out / InOut Expo
    Ease In / Out / InOut Circ
    Ease In / Out / InOut Back
    Ease In / Out / InOut Elastic
    Ease In / Out / InOut Bounce

The library includes a total of 31 easing functions. Each of these functions accepts a single float input (ranging from 0 to 1), and outputs a transformed float (also ranging from 0 to 1) according to the specific easing curve.

How to Use

To use any of these functions, simply call the function with the required easing curve, for example:

```csharp
float easedValue = Glaas.EasingCurves.Easings.EaseInSine(x);
```
If you want to get a curve function by its name, use the GetCurveByName function:

```csharp

var curve = Glaas.EasingCurves.Easings.GetCurveByName("EaseInSine");
```
You can also evaluate a specific value according to a specific curve using the Evaluate function:

```csharp

float easedValue = Glaas.EasingCurves.Easings.Evaluate(x, Glaas.EasingCurves.Easings.Curve.EaseInSine);
```
Additional Information

If you encounter any issues, or have any suggestions for improvement, feel free to open an issue on the repository.

Disclaimer

This is a basic easing functions library, and it may not cover all specific requirements for complex animations. However, the library provides a foundation on which more complex functionality can be built.

## Installations Instructions
You can install this package in two ways.
### A) Package Manager (GIT Url)
The suggested way to install this package is through the Unity's Package Manager itself, via a GIT url. This way, you will be notified once new versions get released, and you will be able to download them directly from the Unity Editor.

-> **The GIT url you need to add to the Package manager is the following** (copy and paste it): **https://github.com/Glaas/Easings.git**

For more info on how to install custom packages from a GIT Url, please read here: https://docs.unity3d.com/Manual/upm-ui-giturl.html

*P.S. If you want, you can also use the GIT url from other branches or other forked repositories.\
Example with the "dev" branch: https://github.com/Glaas/Easings.git#develop*

### B) Manual Install
You can also install this package manually, by copying the source files directly into your project's assets folder. (You'd have to do this every time there is a new update.)

---

If you find this useful, please let me know!

---

## Contributing
If you want to contribute:

1. Fork the project: https://github.com/Glaas/Easings/fork
2. Create your own feature branch
3. Commit your changes to GitHub
4. Push to the branch 
5. Create a new Pull Request

More information about contributing here: https://github.com/firstcontributions/first-contributions

---


## Links
- [Twitter](https://twitter.com/GlaasGD)
- [Website](https://sebdec.net/aboutme.html)
---
