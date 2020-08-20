var target = Argument("target", "Build");
var Configuration = Argument("configuration", "Release");
Task("Restore")
    .Does(() =>
{
    DotnetCoreRestore();
});
Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    //DotNetCoreBuild("./app/App/App.csproj", new DotnetCoreBuildSettings
    //{
        //Configuration = Configuration
    //});
});

RunTarget(target);