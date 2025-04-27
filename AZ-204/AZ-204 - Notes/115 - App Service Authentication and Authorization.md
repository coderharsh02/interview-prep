Explore authentication and authorization in App Service

1. **Overview**:
   - **Azure App Service**: Provides built-in authentication and authorization.
   - **Minimal Code**: Allows user sign-in and data access with minimal or no code.

2. **Why Use Built-In Authentication**:
   - **Flexibility**: You can use other security features or write custom utilities.
   - **Time-Saving**: Built-in feature saves time by providing federated identity support.

3. **Integration**:
   - **Built-In**: Integrated directly into the platform.
   - **No Requirements**: No need for specific languages, SDKs, or security expertise.

4. **Supported Providers**:
   - **Examples**: Microsoft Entra ID, Facebook, Google, Twitter.
   - **Endpoints**:
     - Microsoft: `/.auth/login/aad`
     - Facebook: `/.auth/login/facebook`
     - Google: `/.auth/login/google`
     - Twitter: `/.auth/login/twitter`
     - OpenID Connect: `/.auth/login/<providerName>`
     - GitHub: `/.auth/login/github`

5. **How It Works**:
   - **Module Function**: Runs in the same sandbox as your application code.
   - **Tasks**:
     - Authenticate users and clients.
     - Validate, store, and refresh OAuth tokens.
     - Manage authenticated sessions.
     - Inject identity information into HTTP headers.
   - **Configuration**: Managed via Azure Resource Manager or configuration files.

6. **Linux/Containers**:
   - **Separate Container**: Runs isolated from application code.
   - **No Direct Integration**: Not integrated with specific language frameworks.

7. **Authentication Flow**:
   - **Without Provider SDK**:
     - Redirect to `/.auth/login/<provider>`.
     - Post-authentication redirects to `/.auth/login/<provider>/callback`.
     - App Service adds an authenticated cookie.
   - **With Provider SDK**:
     - Sign-in directly with provider's SDK and receive a token.
     - Post-authentication involves sending the token to `/.auth/login/<provider>` for validation.
     - App Service returns its own authentication token.

8. **Authorization Behavior**:
   - **Allow Unauthenticated Requests**:
     - Defers authorization to application code.
     - Passes authentication information in HTTP headers.
   - **Require Authentication**:
     - Rejects unauthenticated traffic.
     - Redirects to the configured identity provider or returns HTTP 401 Unauthorized/403 Forbidden.

9. **Token Store**:
   - **Built-In**: A repository of tokens associated with users.
   - **Availability**: Accessible immediately upon enabling authentication.

10. **Logging and Tracing**:
    - **Application Logs**: Authentication and authorization traces are logged.
    - **Error Details**: Can be reviewed in application logs for unexpected errors.