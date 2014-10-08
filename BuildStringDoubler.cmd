msbuild StringDoubler\StringDoubler.csproj /p:webpublishmethod=filesystem;PublishUrl=..\Artifacts\StringDoubler /t:WebFileSystemPublish
nuget pack StringDoubler.nuspec -nopackageanalysis
