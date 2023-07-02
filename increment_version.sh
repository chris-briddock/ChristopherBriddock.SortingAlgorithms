#!/bin/bash

# Read the current version from the project file
PROJECT_FILE="src/ChristopherBriddock.SortingAlgorithms/ChristopherBriddock.SortingAlgorithms.csproj"
CURRENT_VERSION=$(grep -oPm1 "(?<=<Version>)[^<]+" "$PROJECT_FILE")

# Split the current version into components
IFS='.' read -ra VERSION_COMPONENTS <<< "$CURRENT_VERSION"

# Increment the appropriate version component (e.g., minor)
VERSION_COMPONENTS[1]=$((VERSION_COMPONENTS[1]+1))

# Construct the new version string
NEW_VERSION="${VERSION_COMPONENTS[0]}.${VERSION_COMPONENTS[1]}.${VERSION_COMPONENTS[2]}"

# Update the project file with the new version
sed -i "s/<Version>$CURRENT_VERSION<\/Version>/<Version>$NEW_VERSION<\/Version>/" "$PROJECT_FILE"

# Output the new version for reference
echo "$NEW_VERSION"
