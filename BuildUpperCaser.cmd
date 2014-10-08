msbuild UpperCaser\UpperCaser.csproj /p:webpublishmethod=filesystem;PublishUrl=..\Artifacts\UpperCaser /t:WebFileSystemPublish
nuget pack UpperCaser.nuspec -nopackageanalysis
