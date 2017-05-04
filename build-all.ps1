# Restore all dependencies
& dotnet restore

# Create the Windows self-contained app
& dotnet publish -c release -f net451 -r win81-x64

# Create the portable app for running on Linux
dotnet publish -c release -f netcoreapp1.1
