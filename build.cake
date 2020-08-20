var target = Argument("target", "Build");
var Configuration = Argument("configuration", "Release");
Task("Restore")
    .Does(() =>
{
    DotNetCoreRestore();
});
Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetCoreBuild("ambconsole.csproj", new DotNetCoreBuildSettings
    {
        Configuration = Configuration
    });
});

RunTarget(target);