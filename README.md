# Yann's Essentials - Restart Visual Studio

[![Build status](https://ci.appveyor.com/api/projects/status/ghwvajcd2wifg4cm/branch/develop?svg=true)](https://ci.appveyor.com/project/YannDuran/restart-visual-studio/branch/develop)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/b0cbfde4-9b7a-4a8e-96d9-a689d37b2279)
<!--or get the [CI build](http://vsixgallery.com/extension/b0cbfde4-9b7a-4a8e-96d9-a689d37b2279/).-->

<!------------------------------------------->

**The easiest and simplest way of restarting Visual Studio (both normal and as administrator)**.

- *If you like this extension, please come back and add add a *Review* (either with or without text), so people will know what users think of it.*

- *If for some reason you didn't like it, or have any suggestions for improving it, just let me know via the *Q AND A* section.*

See the [changelog](CHANGELOG.md) for changes and the roadmap for the future.

## Features
- Restart Visual Studio
- Restart Visual Studio As Administrator

#### Restart Visual Studio
To restart Visual Studio **without** this extension, you would have to:

>- Close the running instance of Visual Studio
>- Open Visual Studio again
>- Open the solution you were working on

To restart Visual Studio **using** this extension:

>- Click the *Restart Visual Studio* button on the *Yann's Essentials Toolbar* 
(if you've enabled the toolbar)


><img src="art/Restart (Normal).png" alt="Restart (normal)" />

Or

>- Right-click in any *code* window
>- Click on *Luminous Essentials* in the context menu
>- Click on *Restart Visual Studio*

><img src="art/Restart (code).png" alt="Restart (from code)" />

Visual Studio restarts and you'll find yourself with the same solution 
that you were previously working on opened for you automatically.

One thing to note is that clicking *Restart Visual Studio* will restart in whichever mode it's in when you clicked it.
So if you're currently running *As Admin*, clicking this button will not return you to running in *Normal* mode.

#### Restart Visual Studio As Admin
To restart Visual Studio as administrator **without** this extension, 
you would have to:

>- Close the running instance of Visual Studio
>- Open Visual Studio again, by
>>- right-clicking the *Visual Studio icon* in your *Taskbar*, *Desktop* or *Start Menu*
>>- clicking on *Run As Administrator*
>- Open the solution you were working on

To restart Visual Studio as administrator **using** this extension:

>- Click the *Restart Visual Studio* button on the *Yann's Essentials Toolbar* 
(if you've enabled the toolbar)

><img src="art/Restart (elevated).png" alt="Restart (as Admin)" />

Or

>- Right-click in any *code* window
>- Click on *Luminous Essentials* in the context menu
>- Click on *Restart Visual Studio*

><img src="art/Restart (code).png" alt="Restart (from code)" />

Visual Studio restarts (as admin) and you'll find yourself with the same solution 
that you were previously working on opened for you automatically.

*Restart Visual Studio As Admin* will **always** restart in *As Admin* mode, 
whether you were already running in *As Admin* mode or *Normal* mode.

## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features used by this project.

## License
[Apache 2.0](LICENSE)