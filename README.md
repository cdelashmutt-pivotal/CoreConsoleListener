# CoreConsoleListener

An example project showing a way to have a console app listening to a passed port in Cloud Foundry.

This project publishes a [self-contained deployment](https://docs.microsoft.com/en-us/dotnet/articles/core/deploying/deploy-with-cli#a-namesimpleselfa-self-contained-deployment-without-third-party-dependencies) suitable for running on a Windows Diego cell, and creates a [framework dependent deployment](https://docs.microsoft.com/en-us/dotnet/articles/core/deploying/deploy-with-cli#framework-dependent-deployment) for running on a Linux cell.

## Prerequisites
Grab the latest [.NET Core SDK](https://www.microsoft.com/net/core) for your platform and install it.

## Build

1. Clone this repository and `cd` to it in Powershell.
1. `.\build-all.ps`

## Push the app
### Windows Cell
`PS C:\> cf push`

### Linux Cell
`PS C:\> cf push -f manifest-linux.yml`
