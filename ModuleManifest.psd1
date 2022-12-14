@{
    RootModule             = "MouseSettings.dll"
    ModuleVersion          = {0}
    CompatiblePSEditions   = @("Core", "Desktop")
    GUID                   = '8ba9c86f-a7ad-43bb-97c7-1e76608d38cd'
    Author                 = 'MartinGC94'
    CompanyName            = 'Unknown'
    Copyright              = '(c) 2022 MartinGC94. All rights reserved.'
    Description            = 'Module for managing mouse settings on Windows.'
    PowerShellVersion      = '5.1'
    FormatsToProcess       = @()
    FunctionsToExport      = @()
    CmdletsToExport        = @({1})
    VariablesToExport      = @()
    AliasesToExport        = @()
    DscResourcesToExport   = @()
    FileList               = @({2})
    PrivateData            = @{
        PSData = @{
             Tags         = @("Mouse", "Settings","Options","Configuration")
             ProjectUri   = 'https://github.com/MartinGC94/MouseSettings'
             ReleaseNotes = @'
{3}
'@
        }
    }
}