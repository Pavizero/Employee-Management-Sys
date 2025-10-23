# Downgrade .NET 8 projects to .NET 5 and fix language issues
Write-Host "Starting downgrade process..." -ForegroundColor Cyan

# Update all csproj files
Get-ChildItem -Recurse -Include *.csproj | ForEach-Object {
    $file = $_.FullName
    (Get-Content $file) |
        ForEach-Object {
            $_ -replace '<TargetFramework>net8\.0-windows</TargetFramework>', '<TargetFramework>net5.0-windows</TargetFramework>' `
               -replace '<ImplicitUsings>enable</ImplicitUsings>', ''
        } | Set-Content $file

    # Add LangVersion if missing
    if ((Get-Content $file) -notmatch '<LangVersion>') {
        (Get-Content $file) -replace '(?<=<UseWindowsForms>true</UseWindowsForms>)', "`r`n    <LangVersion>9.0</LangVersion>" |
            Set-Content $file
    }
    Write-Host "Updated: $file" -ForegroundColor Green
}

# Define C# 10/11/12 features
$features = @{
    "File-scoped namespace" = "namespace\s+\w+\s*;";
    "Global using" = "global\s+using";
    "Required keyword" = "\brequired\b";
    "Raw string literal" = '"""';
    "Collection expressions" = "=\s*\[[^\]]+\];";
    "Primary constructor" = "class\s+\w+\s*\(";
}

Write-Host "`nScanning .cs files for modern features..." -ForegroundColor Cyan

# Process .cs files
Get-ChildItem -Recurse -Include *.cs | ForEach-Object {
    $file = $_.FullName
    $content = Get-Content $file
    $changed = $false

    # ✅ Fix file-scoped namespace → block namespace
    if ($content -match $features["File-scoped namespace"]) {
        $content = $content -replace 'namespace\s+(\w+)\s*;', "namespace `$1`r`n{"
        $content += "`r`n}" # close namespace
        $changed = $true
        Write-Host "Fixed file-scoped namespace in: $file" -ForegroundColor Green
    }

    # ✅ Auto-convert global using → normal using
    if ($content -match $features["Global using"]) {
        $content = $content -replace 'global\s+using', 'using'
        $changed = $true
        Write-Host "Converted global using in: $file" -ForegroundColor Green
    }

    # ✅ Report other modern features
    foreach ($feature in $features.Keys) {
        if ($content -match $features[$feature] -and $feature -notin @("File-scoped namespace","Global using")) {
            Write-Host "$feature found in $file (manual fix required)" -ForegroundColor Yellow
        }
    }

    if ($changed) {
        $content | Set-Content $file
    }
}

Write-Host "`nDowngrade completed. Please manually fix any reported features." -ForegroundColor Cyan
