del *.nupkg

nuget restore

msbuild ELS.sln /p:Configuration=Release

NuGet.exe pack ELS/ELS.csproj -Properties Configuration=Release

pause

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -Source https://www.nuget.org/api/v2/package"
