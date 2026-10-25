# Unity Physics Rig — Open Source

An open-source VR physics rig for Unity, designed to provide a foundation for hand-based locomotion and multiplayer VR projects.

Originally built with Gorilla Tag-style hand locomotion in mind, this physics rig can be modified, expanded, and adapted to suit your own game mechanics and development needs.

Also it uses Photon, but you can also edit that to whatever networking system you like!

## Overview

This project provides a starting point for developers looking to implement a physics-based VR player rig in Unity. Whether you're experimenting with hand locomotion, creating a multiplayer VR game, or building your own player movement system, this project is intended to give you something useful to work from.

The source is open for developers to explore, edit, and improve for their own projects.

### Features

- **Physics-Based VR Rig:** A foundation for VR player movement using physics.
- **Hand Locomotion Support:** Originally designed for hand-based movement systems.
- **Multiplayer Integration:** Designed to work alongside Photon VR.
- **Customizable Source Code:** Modify the scripts and setup to fit your project.
- **Open Source:** Explore the implementation and build upon it for your own games.

## Requirements

Before using this project, make sure you have the following dependencies installed.

| Dependency | Description |
|---|---|
| Unity | Required to open and develop the project. |
| Photon VR | Multiplayer VR functionality and player networking. |
| Easy Inputs v4 | Input handling for VR controllers. |
| XR Packages | Unity XR components required by your setup. |

### Required Downloads

**1. Photon VR**

Repository: https://github.com/fchb1239/PhotonVR

**2. Easy Inputs v4**

[Download Easy Inputs v4](https://drive.google.com/file/d/1HM6XJHwz1fD-a_n0oDRmCG4KdGOcW7px/view?usp=sharing)

**3. Unity XR Packages**

Install the XR packages required by your Unity version and VR headset. Depending on your project setup, these may include the XR Plug-in Management package and a compatible XR provider.

## Getting Started

Follow these steps to get started with the physics rig.

1. Clone or download this repository.
2. Open the project in a compatible version of Unity.
3. Install the required dependencies listed above.
4. Review the included scenes, scripts, prefabs, and Inspector references.
5. Set up the rig and connect any required references.
6. Configure Photon VR and your input system if you're using multiplayer functionality.
7. Test the rig in your target VR environment before integrating it into your game.

**Important:** The exact setup may depend on your Unity version, XR configuration, and the scripts included in the project.

## Compatibility and Customization

This project was originally built for Gorilla Tag-style hand locomotion. It is not intended to be a universal, drop-in VR controller for every project without modification.

You are encouraged to adapt the source code to fit your own requirements, including:

- Custom player movement and locomotion.
- Different VR controller input systems.
- Custom physics interactions.
- Multiplayer player representations.
- Alternative player rigs and collision setups.
- Additional mechanics and gameplay features.

Some modifications may be required before the rig works with a different locomotion system or networking configuration.

## Contributing

Found a bug, improved a script, or made a useful modification?

Contributions and suggestions are welcome. Feel free to fork the repository, experiment with the code, and share improvements that could benefit other developers.

When contributing, try to keep changes organized and include a brief explanation of what was changed.

## Disclaimer

This project is provided as an open-source development resource. It may require additional configuration or modification to work correctly in your specific Unity project.

Third-party dependencies, including Photon VR and Easy Inputs, remain subject to their respective licenses and terms.

## Credits

- **Project Author:** Whos.Matthew
- **Photon VR:** https://github.com/fchb1239/PhotonVR
- **Easy Inputs:** Original creators and maintainers


**Have fun developing!**
