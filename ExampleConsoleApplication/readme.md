# About

- Setting up connection string in separate class than the DbContext class
- Using .LogTo for writing to a text file.
- Several options to log information other than a text files.



appsettings.json

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

