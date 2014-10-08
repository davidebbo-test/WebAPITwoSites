msbuild WebAPIFoo\WebAPIFoo.csproj /p:webpublishmethod=filesystem;PublishUrl=..\Artifacts /t:WebFileSystemPublish
nuget pack WebAPIFoo.nuspec -nopackageanalysis
