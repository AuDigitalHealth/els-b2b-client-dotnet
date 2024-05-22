del *.nupkg

msbuild ELS.sln /p:Configuration=Release

REM Use dotnet for packaging now
REM NuGet.exe pack ELS/ELS.csproj -Properties Configuration=Release
dotnet pack .\ELS\ELS.csproj -c Release -o .

pause

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -Source https://www.nuget.org/api/v2/package"
