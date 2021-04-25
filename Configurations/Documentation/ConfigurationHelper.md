<a name='assembly'></a>
# ConfigurationHelper

## Contents

- [DatabaseSettings](#T-ConfigurationHelper-DatabaseSettings 'ConfigurationHelper.DatabaseSettings')
  - [Catalog](#P-ConfigurationHelper-DatabaseSettings-Catalog 'ConfigurationHelper.DatabaseSettings.Catalog')
  - [ConnectionString](#P-ConfigurationHelper-DatabaseSettings-ConnectionString 'ConfigurationHelper.DatabaseSettings.ConnectionString')
  - [DatabaseServer](#P-ConfigurationHelper-DatabaseSettings-DatabaseServer 'ConfigurationHelper.DatabaseSettings.DatabaseServer')
  - [IntegratedSecurity](#P-ConfigurationHelper-DatabaseSettings-IntegratedSecurity 'ConfigurationHelper.DatabaseSettings.IntegratedSecurity')
  - [LogFileName](#P-ConfigurationHelper-DatabaseSettings-LogFileName 'ConfigurationHelper.DatabaseSettings.LogFileName')
  - [LoggingDestination](#P-ConfigurationHelper-DatabaseSettings-LoggingDestination 'ConfigurationHelper.DatabaseSettings.LoggingDestination')
- [Helper](#T-ConfigurationHelper-Helper 'ConfigurationHelper.Helper')
  - [ConnectionString()](#M-ConfigurationHelper-Helper-ConnectionString 'ConfigurationHelper.Helper.ConnectionString')
  - [InitConfiguration()](#M-ConfigurationHelper-Helper-InitConfiguration 'ConfigurationHelper.Helper.InitConfiguration')
  - [InitOptions\`\`1(section)](#M-ConfigurationHelper-Helper-InitOptions``1-System-String- 'ConfigurationHelper.Helper.InitOptions``1(System.String)')
  - [LogFileName()](#M-ConfigurationHelper-Helper-LogFileName 'ConfigurationHelper.Helper.LogFileName')
  - [LoggingDestination()](#M-ConfigurationHelper-Helper-LoggingDestination 'ConfigurationHelper.Helper.LoggingDestination')
- [LoggingDestination](#T-ConfigurationHelper-LoggingDestination 'ConfigurationHelper.LoggingDestination')
  - [DebugWindow](#F-ConfigurationHelper-LoggingDestination-DebugWindow 'ConfigurationHelper.LoggingDestination.DebugWindow')
  - [LogFile](#F-ConfigurationHelper-LoggingDestination-LogFile 'ConfigurationHelper.LoggingDestination.LogFile')
  - [None](#F-ConfigurationHelper-LoggingDestination-None 'ConfigurationHelper.LoggingDestination.None')

<a name='T-ConfigurationHelper-DatabaseSettings'></a>
## DatabaseSettings `type`

##### Namespace

ConfigurationHelper

##### Summary

Properties for setting up a connection string

<a name='P-ConfigurationHelper-DatabaseSettings-Catalog'></a>
### Catalog `property`

##### Summary

Default catalog

<a name='P-ConfigurationHelper-DatabaseSettings-ConnectionString'></a>
### ConnectionString `property`

##### Summary

SQL-Server connection string for Entity Framework Core

<a name='P-ConfigurationHelper-DatabaseSettings-DatabaseServer'></a>
### DatabaseServer `property`

##### Summary

SQL-Server server

<a name='P-ConfigurationHelper-DatabaseSettings-IntegratedSecurity'></a>
### IntegratedSecurity `property`

##### Summary

User Integrated security

<a name='P-ConfigurationHelper-DatabaseSettings-LogFileName'></a>
### LogFileName `property`

##### Summary

Name of Entity Framework Core log file

<a name='P-ConfigurationHelper-DatabaseSettings-LoggingDestination'></a>
### LoggingDestination `property`

##### Summary

Where to log for Entity Framework Core

<a name='T-ConfigurationHelper-Helper'></a>
## Helper `type`

##### Namespace

ConfigurationHelper

##### Summary

Responsible for reading appsettings.json properties

<a name='M-ConfigurationHelper-Helper-ConnectionString'></a>
### ConnectionString() `method`

##### Summary

Connection string for application database stored in appsettings.json
Another option would be to have the full connection string in the json file.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ConfigurationHelper-Helper-InitConfiguration'></a>
### InitConfiguration() `method`

##### Summary

Initialize ConfigurationBuilder

##### Returns

IConfigurationRoot

##### Parameters

This method has no parameters.

<a name='M-ConfigurationHelper-Helper-InitOptions``1-System-String-'></a>
### InitOptions\`\`1(section) `method`

##### Summary

Generic method to read a section from the json configuration file.

##### Returns

Instance of T

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Section to read |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Class type |

<a name='M-ConfigurationHelper-Helper-LogFileName'></a>
### LogFileName() `method`

##### Summary

Log file name

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ConfigurationHelper-Helper-LoggingDestination'></a>
### LoggingDestination() `method`

##### Summary

Log options

##### Returns



##### Parameters

This method has no parameters.

<a name='T-ConfigurationHelper-LoggingDestination'></a>
## LoggingDestination `type`

##### Namespace

ConfigurationHelper

##### Summary

Where to log or not to log too

<a name='F-ConfigurationHelper-LoggingDestination-DebugWindow'></a>
### DebugWindow `constants`

##### Summary

Log to Output window

<a name='F-ConfigurationHelper-LoggingDestination-LogFile'></a>
### LogFile `constants`

##### Summary

Log to file

<a name='F-ConfigurationHelper-LoggingDestination-None'></a>
### None `constants`

##### Summary

No logging
