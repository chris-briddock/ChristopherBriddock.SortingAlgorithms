# Read the current version from the project file
$projectFilePath = "src/ChristopherBriddock.SortingAlgorithms/ChristopherBriddock.SortingAlgorithms.csproj"
$projectFileContent = Get-Content -Path $projectFilePath
$currentVersion = [regex]::Match($projectFileContent, '<Version>(.*?)<\/Version>').Groups[1].Value

# Split the current version into components
$versionComponents = $currentVersion -split '\.'

# Increment the appropriate version component (e.g., minor)
$versionComponents[1] = [int]$versionComponents[1] + 1

# Construct the new version string
$newVersion = $versionComponents -join '.'

# Update the project file with the new version
$projectFileContent = $projectFileContent -replace "<Version>(.*?)<\/Version>", "<Version>$newVersion</Version>"
$projectFileContent | Set-Content -Path $projectFilePath

# Output the new version for reference
$newVersion
