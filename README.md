# Templates

The *missing* (and new) project, item, multi-project, web and multi-item `dotnet new` templates for Visual Basic.

## What are Templates?

We can use Templates to create ready-to-run projects and items that make it easy to start with a working set of code. The .NET comes with a set of default templates to cover the essential project types and items that we may require like the *Console App*, *Class Libraries*, *Windows Forms App*, etc.

To see all the available templates, we can use the `dotnet new` command with the `list` option:

`dotnet new list`

This will list all built-in templates as well as the custom ones if we have installed any.

However, when you do this... you'll notice that VB isn't an available option for many of the included templates. 🤔

As a side note, you can easily filter the list to (for example) just show the available VB templates:

`dotnet new list --language VB`

## Connect with us

Many of us hang out on [Discord](https://discord.gg/Y8EH5fF6WG), some use [this invite](https://discord.gg/Y8EH5fF6WG) to join the conversations.

## How to install templates from source?

- Get a local copy of this repo; if you are new to git/GitHub, be sure to check out and utilize GitHub Desktop.
- Once you have the files locally, use a terminal prompt and change to the subfolder containing the template(s) you want to install. (ie. `./src/avalonia`)
- From this folder, type `dotnet new install ./`; this will install the all templates from the current folder.
- To uninstall (or to update), `dotnet new uninstall ./` (and to update, repeat the `install`).
- To my knowledge, these templates will be available in `dotnet new` as well as from within *Visual Studio*.

## How to create a Template?

- [How to create your own templates for dotnet new](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)
- [Custom templates for dotnet new](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- Create templates for the CLI (Tutorial)
  - [Create an item template](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)
  - [Create a project template](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-project-template)
  - [Create a template package](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package?pivots=dotnet-8-0)
- [What are project and item templates?](https://learn.microsoft.com/en-us/visualstudio/ide/creating-project-and-item-templates?view=vs-2022)
- [Locate and organize project and item templates](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates?view=vs-2022)
- [How to Create Your .NET Project Template](https://auth0.com/blog/create-dotnet-project-template/)
- [Creating .NET Project Templates](https://code-maze.com/dotnet-project-templates-creation/)

## Automated builds?

To make life a whole lot simpler, really need to utilize GitHub actions to automate the build process and potentially releases; so the structure of the repo needs to consider this.

## Publishing to Nuget?

Once we have something working, some testing under our belt and come up with a plan we will publish these to nuget so that they are easier to find and use by everyone. This includes such topics as versioning, release cadence, etc.

## Want to contribute?

We welcome suggestions, bug reports, pull requests, help with documentation, testing, etc. So if you are interested, please use the tools here on GitHub or speak with us over on [Discord](https://discord.gg/Y8EH5fF6WG).

## Lack of ideas for new templates?

Drop down to a terminal prompt and type `dotnet new list`... see one that doesn't have `VB` next to it? Sounds like a candidate...

Check out the list of additional C# and F# templates that can be found at <https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new> for a bit of inspiration.
