# About

:heavy_check_mark: Read EF Core connection string from appsettings.json

:heavy_check_mark: Configuring EF Core logging from appsettings.json

</br>

**Options** for logging

```csharp
Public Enum LoggingDestination
    DebugWindow
    LogFile
    None
End Enum
```
</br>

**Usage**: reads appsettings.json

```json
{
  "database": {
    "DatabaseServer": ".\\SQLEXPRESS",
    "Catalog": "School",
    "IntegratedSecurity": "true",
    "UsingLogging": "true",
    "LoggingDestination": "LogFile",
    "LogFileName": "karen.txt" 
  }
}
```
---

```csharp
Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)

	If Not optionsBuilder.IsConfigured Then

		Select Case Helper.LoggingDestination()
			Case LoggingDestination.DebugWindow
				LogQueryInfoToDebugOutputWindow(optionsBuilder)
			Case LoggingDestination.LogFile
				LogQueryInfoToFile(optionsBuilder)
			Case LoggingDestination.None
				NoLogging(optionsBuilder)
			Case Else
				Throw New ArgumentOutOfRangeException()
		End Select

	End If

End Sub
```

</br>


![img](assets/efcore.png) ![image](assets/Versions.png) 
![img](assets/vb1.png)


# NuGet packages

|Id| Versions | 
| :--- | :---         |
|Microsoft.Extensions.Configuration.FileExtensions|  {5.0.0} | 
|Newtonsoft.Json|  {12.0.3} | 
|Microsoft.Extensions.Configuration.Binder|   {5.0.0} |
|Microsoft.Extensions.Configuration.Json|   {5.0.0} | 
|Microsoft.Extensions.Configuration|   {5.0.0} | 

</br>

# See also

These are all C#

- Microsoft TechNet: 
  - [.NET Core desktop application configurations (C#)](https://social.technet.microsoft.com/wiki/contents/articles/54173.net-core-desktop-application-configurations-c.aspx)
  - [Entity Framework/Entity Framework Core dynamic connection strings (C#)](https://social.technet.microsoft.com/wiki/contents/articles/54079.entity-frameworkentity-framework-core-dynamic-connection-strings-c.aspx)
  - [Entity Framework Core/Windows Forms tips and tricks](https://social.technet.microsoft.com/wiki/contents/articles/53635.entity-framework-corewindows-forms-tips-and-tricks.aspx)
- Microsoft docs
  - [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
  - [Porting from EF6 to EF Core](https://docs.microsoft.com/en-us/ef/efcore-and-ef6/porting/)
- Tools
  - [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools)
  
---

![img](assets/kpmvp1.png)