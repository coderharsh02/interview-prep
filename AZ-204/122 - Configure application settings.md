Configure application settings

---

### Application Settings in Azure App Service:
1. **Environment Variables**: App settings in App Service are passed as environment variables to the application code.
   - **Linux Apps & Custom Containers**: App settings are passed using the `--env` flag.
2. **Accessing App Settings**: Navigate to **Environment variables > Application settings** on your app's management page.

### Application Settings for ASP.NET and ASP.NET Core:
1. **Override Behavior**: App settings in App Service override those in `<appSettings>` in _Web.config_ or _appsettings.json_.
2. **Separation of Settings**: 
   - **Development Settings**: Keep in _Web.config_ or _appsettings.json_ (e.g., local MySQL password).
   - **Production Secrets**: Store in App Service (e.g., Azure MySQL database password).
3. **Encryption**: App settings are always encrypted when stored (encrypted-at-rest).

### Adding and Editing Settings:
1. **Adding a New Setting**: 
   - Select **\+ Add**.
   - Specify if the setting is swappable if using deployment slots.
   - Select **Apply** in the dialog and **Apply** again in the **Environment variables** page.
2. **Nested JSON Keys in Linux**: 
   - For nested JSON keys in app settings, replace `:` with `__` (double underscore) and `.` with `_` (single underscore) (e.g., `ApplicationInsights:InstrumentationKey` becomes `ApplicationInsights__InstrumentationKey`).

### Bulk Editing of Application Settings:
1. **Advanced Edit**: 
   - Select **Advanced edit** to add or edit settings in bulk.
   - Use the following JSON format:
   ```
   [
     {
       "name": "<key-1>",
       "value": "<value-1>",
       "slotSetting": false
     },
     {
       "name": "<key-2>",
       "value": "<value-2>",
       "slotSetting": false
     },
     ...
   ]
   ```
   - Select **OK** and then **Apply** in the **Environment variables** page.

### Configure Connection Strings:
1. **ASP.NET and ASP.NET Core**:
   - Connection strings in App Service override those in `<connectionStrings>` in _Web.config_.
2. **Non-.NET Languages**:
   - Prefer using app settings unless the database is backed up only with a connection string in App Service.
3. **Adding/Editing Connection Strings**:
   - Follows the same principles as app settings.
   - JSON format example:
   ```
   [
     {
       "name": "name-1",
       "value": "conn-string-1",
       "type": "SQLServer",
       "slotSetting": false
     },
     {
       "name": "name-2",
       "value": "conn-string-2",
       "type": "PostgreSQL",
       "slotSetting": false
     },
     ...
   ]
   ```
4. **PostgreSQL Connection String for .NET**:
   - Set the connection string type to **Custom** due to a known issue with .NET's EnvironmentVariablesConfigurationProvider.

### Configure Environment Variables for Custom Containers:
1. **Passing Environment Variables**:
   - Use the Azure Cloud Shell to pass environment variables.
   - **Bash**:
   ```
   az webapp config appsettings set --resource-group <group-name> --name <app-name> --settings key1=value1 key2=value2
   ```
   - **PowerShell**:
   ```
   Set-AzWebApp -ResourceGroupName <group-name> -Name <app-name> -AppSettings @{"DB_HOST"="myownserver.mysql.database.azure.com"}
   ```
2. **Verification**:
   - Verify the environment variables with the URL: `https://<app-name>.scm.azurewebsites.net/Env`.