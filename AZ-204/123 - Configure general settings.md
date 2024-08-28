Configure general settings

---

### General Settings Configuration in Azure App Service:
1. **Accessing General Settings**:
   - Navigate to **Configuration > General settings** to configure common settings for your app.
   - Some settings may require scaling up to higher pricing tiers.

### Available General Settings:

1. **Stack Settings**:
   - **Software Stack**: Select the programming language and SDK versions for running the app.
   - **Linux Apps & Custom Containers**: Option to set an optional start-up command or file.

2. **Platform Settings**:
   - **Platform Bitness**: Choose between 32-bit or 64-bit for Windows apps.
   - **FTP State**: Option to allow only FTPS or disable FTP entirely.
   - **HTTP Version**: Set to **2.0** to enable support for the HTTPS/2 protocol.
     - **Note**: Modern browsers support HTTP/2 over TLS; non-encrypted traffic uses HTTP/1.1.
     - To ensure HTTP/2, secure your custom DNS name.
   - **Web Sockets**: Enable for applications using ASP.NET SignalR or socket.io.
   - **Always On**:
     - Keeps the app loaded even when there's no traffic.
     - Without it, the app is unloaded after 20 minutes of inactivity, causing high latency due to warm-up time.
     - Required for continuous WebJobs or WebJobs triggered using a CRON expression.
   - **ARR Affinity**:
     - Ensures clients are routed to the same instance in a multi-instance deployment.
     - Can be turned **Off** for stateless applications.
   - **HTTPS Only**: Redirects all HTTP traffic to HTTPS when enabled.
   - **Minimum TLS Version**: Set the minimum TLS encryption version required by the app.

3. **Debugging**:
   - Enable remote debugging for ASP.NET, ASP.NET Core, or Node.js apps.
   - This option automatically turns off after 48 hours.

4. **Incoming Client Certificates**:
   - Require client certificates for mutual TLS authentication.
   - TLS mutual authentication restricts access by enabling different authentication types for the app.