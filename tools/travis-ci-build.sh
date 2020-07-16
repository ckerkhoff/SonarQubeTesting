#!/bin/sh
#echo "Changing to /src directory..."
#cd src
echo "Executing MSBuild.exe begin command..."
mono tools/sonar/SonarScanner.MSBuild.exe begin /o:"ckerkhoff" /k:"ckerkhoff_SonarQubeTesting" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.verbose=true /d:sonar.login=${SONAR_TOKEN}
echo "Running build..."
msbuild /p:Configuration=Release /t:Rebuild SonarQubeIssues.sln
#echo "Running tests..."
#dotnet test SonarCloud.Travis.Integration.Tests/SonarCloud.Travis.Integration.Tests.csproj
echo "Executing MSBuild.exe end command..."
mono tools/sonar/SonarScanner.MSBuild.exe end /d:sonar.login=${SONAR_TOKEN}