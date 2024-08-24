Examine Azure App Service plans:

1. **Overview of App Service Plan**:
   - An app in Azure App Service always runs within an App Service plan.
   - An App Service plan defines the compute resources for a web app, and multiple apps can share the same plan.

2. **Key Components of an App Service Plan**:
   - **Operating System**: Windows or Linux.
   - **Region**: Where the compute resources are located (e.g., West US, East US).
   - **Number of VM Instances**: The amount of virtual machines available for the app.
   - **Size of VM Instances**: The scale of VM resources (Small, Medium, Large).
   - **Pricing Tier**: Defines features and cost, with various options like Free, Shared, Basic, Standard, Premium, Isolated, etc.

3. **Pricing Tiers**:
   - **Shared Compute (Free and Shared)**: Apps run on the same VM as other customers’ apps, with limited CPU quotas and no scaling out.
   - **Dedicated Compute (Basic, Standard, Premium tiers)**: Apps run on dedicated VMs, with higher tiers offering more VM instances for scaling out.
   - **Isolated**: Runs on dedicated VMs within dedicated Virtual Networks, offering network and compute isolation with maximum scale-out capabilities.

4. **Free and Shared Tiers**:
   - Base tiers for development and testing, with apps sharing the same VMs with other customers’ apps.

5. **How Apps Run and Scale**:

   1. **Free and Shared Tiers**:
      - Apps receive CPU minutes on a shared VM instance.
      - Apps in these tiers **cannot scale out**.

   2. **Other Tiers (Basic, Standard, Premium, etc.)**:
      - **App Runs on All VM Instances**: An app runs on all VM instances configured in the App Service plan.
      - **Shared Resources**: If multiple apps are in the same App Service plan, they share the same VM instances.
      - **Deployment Slots**: All deployment slots of an app also run on the same VM instances.
      - **Resource Usage**: Enabling diagnostic logs, performing backups, or running WebJobs consumes CPU cycles and memory on the same VM instances.

   3. **App Service Plan as a Scale Unit**:
      - The App Service plan is the **scale unit** for the apps.
      - If the plan is configured to run, for example, five VM instances, all apps in the plan run on those five instances.
      - If autoscaling is enabled, all apps in the plan scale out together based on the autoscale settings.

6. **Scaling Up or Down**:
   - You can change the pricing tier of the App Service plan at any time to scale up or down.
   - Isolating an app into a separate App Service plan can improve performance by allocating dedicated compute resources.

7. **Cost Efficiency**:
   - You can save money by putting multiple apps into one App Service plan, but be mindful of resource capacity and expected load.

8. **When to Isolate an App**:
   - The app is resource-intensive.
   - You want to scale the app independently from other apps.
   - The app needs to be deployed in a different geographical region.

9. **Benefits of Isolation**:
   - Allocates a new set of resources specifically for your app.
   - Provides greater control over app performance and scalability.