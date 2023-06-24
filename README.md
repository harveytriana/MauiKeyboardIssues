# The Screen is partially scrolled when showing virtual keyboard - MAUI .NET 7.

When you give focus to an Entry control the virtual keyboard is displayed, but the top of the screen is apparently displaced and doesn't look complete. I report it as an ISSUE because the same does not happen in MAUI .NET 6.

The following image illustrates the issue. Even the navigation title was displaced by the keyboard image.

<p align="center">
    <img src="https://github.com/harveytriana/MauiKeyboardIssues/blob/master/Screens/net7-1.png" width="35%" height="35%">
</p>

When we hide the keyboard, the screen is shown full.

<p align="center">
<img src="https://github.com/harveytriana/MauiKeyboardIssues/blob/master/Screens/net7-2.png" width="35%" height="35%">
</p>

This is the correct behavior, the same application in MAUI .NET 6:

<p align="center">
<img src="https://github.com/harveytriana/MauiKeyboardIssues/blob/master/Screens/net6-1.png" width="35%" height="35%">
</p>

Something

<p align="center">
<img src="https://github.com/harveytriana/MauiKeyboardIssues/blob/master/Screens/net6-2.png" width="35%" height="35%">
</p>


