$githubToken = $env:GITHUB_TOKEN
$apiUrl = "https://api.github.com/repos/$env:GITHUB_REPOSITORY/actions/runs/$env:GITHUB_RUN_ID/env"
$variableName = "VERSION_NUMBER"

# Get the current version number from the environment variable
$currentVersion = [int]$env:VERSION_NUMBER

# Increment the version number
$newVersion = $currentVersion + 1

# Create a JSON payload with the updated environment variable
$envVarJson = @{
    name = $variableName
    value = $newVersion
} | ConvertTo-Json

# Update the environment variable using the GitHub API
Invoke-RestMethod -Uri $apiUrl -Method Patch -Headers @{
    "Authorization" = "Bearer $githubToken"
    "Content-Type" = "application/json"
} -Body $envVarJson
