mkdir M01
cd .\M01
dotnet new sln
dotnet new classlib -o ArrayHelper
New-Item -Path .\ArrayHelper -Name "Class2.cs" -ItemType "file"
dotnet sln M01.sln add ArrayHelper\ArrayHelper.csproj
dotnet new classlib -o RectangleHelper
dotnet sln M01.sln add RectangleHelper\RectangleHelper.csproj
dotnet new console -o Program
dotnet sln M01.sln add Program\Program.csproj
dotnet add .\Program\Program.csproj reference .\ArrayHelper\ArrayHelper.csproj
dotnet add .\Program\Program.csproj reference .\RectangleHelper\RectangleHelper.csproj
dotnet build
dotnet run --project .\Program\Program.csproj
dotnet publish -o win10-x64 -r win10-x64
dotnet publish -o win10-arm64 -r win10-arm64
 
