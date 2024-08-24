Deploy to Azure App Service:

1. **Deployment Options**:
   - Azure App Service supports both automated and manual deployment methods.

2. **Automated Deployment (Continuous Deployment)**:
   - A process to push new features and bug fixes quickly and repeatedly with minimal user impact.
   - **Azure DevOps Services**: Code is pushed to Azure DevOps, built, tested, and deployed to an Azure Web App.
   - **GitHub**: Automatically deploys changes pushed to the production branch in a connected GitHub repository.
   - **Bitbucket**: Similar to GitHub, supports automated deployment with Bitbucket repositories.

3. **Manual Deployment Options**:
   - **Git**: Deploys by pushing code to a Git URL associated with the App Service.
   - **CLI (`az webapp up`)**: Packages and deploys an app using the Azure CLI, capable of creating a new App Service if needed.
   - **Zip Deploy**: Deploys using a ZIP file sent to App Service via HTTP utilities like `curl`.
   - **FTP/S**: Traditional method to push code using FTP or FTPS.

4. **Deployment Slots**:
   - Use deployment slots in the Standard App Service Plan tier or better to deploy to a staging environment.
   - **Swap Slots**: Swap staging and production slots to eliminate downtime by warming up worker instances to match production scale.

5. **Continuous Code Deployment**:
   - For projects with branches for testing, QA, and staging, each branch should be continuously deployed to a staging slot.
   - Allows stakeholders to assess and test the deployed branch easily.

6. **Continuous Container Deployment**:
   - Deploy custom containers from Azure Container Registry or other registries into a staging slot, then swap into production to avoid downtime.
   - **Build and Tag Image**: Tag images with identifiable information (e.g., git commit ID, timestamp) rather than using the default "latest" tag for easier debugging.
   - **Push Tagged Image**: Push the tagged image to the container registry.
   - **Update Deployment Slot**: Update the deployment slot with the new image tag, causing the site to restart and pull the new container image.