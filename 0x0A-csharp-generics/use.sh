mkdir $1
cd $1

dotnet new console
dotnet build
dotnet run
