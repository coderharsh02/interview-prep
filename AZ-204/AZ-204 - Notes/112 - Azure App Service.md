Examine Azure App Service

1. **Azure App Service Overview**:
   - An HTTP-based service for hosting web applications, REST APIs, and mobile back ends.
   - Supports various programming languages and frameworks.
   - Applications can run and scale easily on both Windows and Linux-based environments.

2. **Built-in Auto Scale Support**:
   - Azure App Service includes built-in support for scaling resources.
   - **Scale up/down**: Adjust the machine's resources (CPU, RAM).
   - **Scale out/in**: Adjust the number of machine instances running the app.

3. **Container Support**:
   - Allows deployment and running of containerized web apps on Windows and Linux.
   - Supports pulling container images from Azure Container Registry or Docker Hub.
   - Supports multi-container apps, Windows containers, and Docker Compose.

4. **Continuous Integration/Deployment (CI/CD) Support**:
   - Out-of-the-box CI/CD integration with Azure DevOps, GitHub, Bitbucket, FTP, or local Git repositories.
   - Auto-syncs code and changes to the web app.
   - CI/CD support extends to containerized web apps using Azure Container Registry or Docker Hub.

5. **Deployment Slots**:
   - Separate deployment slots are available, especially useful in the Standard App Service Plan tier or better.
   - Deployment slots have their own hostnames, and content/configurations can be swapped between slots.

6. **App Service on Linux**:
   - Natively hosts web apps on Linux for supported application stacks.
   - Supports custom Linux containers (Web App for Containers).
   - Provides built-in images for various languages and frameworks like Node.js, Java, PHP, Python, .NET, and Ruby.
   - Regularly updates supported languages and versions.

7. **Command to List Supported Runtimes**:
   - To retrieve the current list of supported languages and versions for Linux, use the following command in Azure Cloud Shell:
     ```bash
     az webapp list-runtimes --os-type linux
     ```

8. **Limitations of App Service on Linux**:
   - Not supported on the Shared pricing tier.
   - Only shows features that currently work for Linux apps in the Azure portal.
   - For built-in images, code and content are allocated a storage volume backed by Azure Storage, which has higher latency than the container filesystem.
   - Apps requiring heavy read-only access to content files might benefit from using a custom container option.