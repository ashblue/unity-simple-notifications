# Simple Notifications

A simple API for displaying notifications to a user during gameplay.

## Quick Start

Simple notifications provides a simple API to generate your notification messages in a manner similar to Skyrim. Just call the API as so when setup from any script.

```c#
NotificationManager.Instance.AddLine(_message);
```

## Installation

Simple Notifications is used through [Unity's Package Manager](https://docs.unity3d.com/Manual/CustomPackages.html). In order to use it you'll need to add the following lines to your `Packages/manifest.json` file. After that you'll be able to visually control what specific version of Simple Notifications you're using from the package manager window in Unity. This has to be done so your Unity editor can connect to NPM's package registry.

```json
{
  "scopedRegistries": [
    {
      "name": "NPM",
      "url": "https://registry.npmjs.org",
      "scopes": [
        "com.fluid"
      ]
    }
  ],
  "dependencies": {
    "com.fluid.simple-notifications": "1.0.0"
  }
}
```

After the package is installed you need to do a few extra things so you have a canvas to reference.

1. Export the `Assets/Examples/Prefabs` and then import them into your project. 
     1. If you don't want to do that for a custom setup you'll need to do the following instead
     1. Create a new canvas add a `NotificationController` script to it (fill in fields). Generate a prefab in the project from it
     1. Create a new canvas line with a `LineController` script (fill in fields). Generate a prefab in the project from it. Add it to the `NotificationController` prefab we just created
 1. Create a new asset in your project under `Resources` with the right click menu `Create/Fluid/Simple Notifications/Settings`
     1. Add the canvas to the settings file

## Releases

Archives of specific versions and release notes are available on the [releases page](https://github.com/ashblue/unity-simple-notifications/releases).

## Nightly Builds

To access nightly builds of the `develop` branch that are package manager friendly, you'll need to manually edit your `Packages/manifest.json` as so. 

```json
{
    "dependencies": {
      "com.fluid.simple-notifications": "https://github.com/ashblue/unity-simple-notifications.git#nightly"
    }
}
```

Note that to get a newer nightly build you must delete this line and any related lock data in the manifest, let Unity rebuild, then add it back. As Unity locks the commit hash for Git urls as packages.

## Development Environment

If you wish to run to run the development environment you'll need to install the latest [node.js](https://nodejs.org/en/). Then run the following from the root once.

`npm install`

If you wish to create a build run `npm run build` from the root and it will populate the `dist` folder.

### Making Commits

All commits should be made using [Commitizen](https://github.com/commitizen/cz-cli) (which is automatically installed when running `npm install`). Commits are automatically compiled to version numbers on release so this is very important. PRs that don't have Commitizen based commits will be rejected.

To make a commit type the following into a terminal from the root

```bash
npm run commit
```

---

This project was generated with [Oyster Package Generator](https://github.com/ashblue/oyster-package-generator).
