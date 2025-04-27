Discover App Service networking features
---

### Overview:
1. **Default Accessibility**: Apps hosted in Azure App Service are accessible via the internet by default and can only reach internet-hosted endpoints.
2. **Traffic Control**: Many applications require controlling inbound and outbound network traffic.
3. **Deployment Types**:
   - **Multitenant Public Service**: Hosts App Service plans (Free, Shared, Basic, Standard, Premium, PremiumV2, PremiumV3).
   - **Single-Tenant App Service Environment (ASE)**: Hosts Isolated SKU App Service plans directly in an Azure virtual network.

### Multi-tenant App Service Networking Features:
1. **System Structure**: Azure App Service is a distributed system with two main roles:
   - **Front ends**: Handle incoming HTTP/HTTPS requests.
   - **Workers**: Host customer workloads.
2. **Multi-Tenant Network**: App Service roles exist in a multi-tenant network, which cannot connect directly to your network.
3. **Feature Categories**:
   - **Inbound Features**: Manage incoming traffic.
   - **Outbound Features**: Manage outgoing traffic.
4. **Feature Mixing**: Features can be mixed to solve networking challenges with some exceptions.

### Inbound and Outbound Features:

| **Inbound Features**           | **Outbound Features**                        |
|--------------------------------|----------------------------------------------|
| App-assigned address           | Hybrid Connections                           |
| Access restrictions            | Gateway-required virtual network integration |
| Service endpoints              | Virtual network integration                  |
| Private endpoints              |                                              |

### Inbound Use Cases and Features:

| **Inbound Use Case**                                              | **Feature**             |
|-------------------------------------------------------------------|-------------------------|
| Support IP-based SSL needs for your app                           | App-assigned address    |
| Support unshared dedicated inbound address for your app           | App-assigned address    |
| Restrict access to your app from a set of well-defined addresses  | Access restrictions     |

### Default Networking Behavior:
1. **Scale Units**: App Service scale units support multiple customers. 
   - Free and Shared SKU plans: Host customer workloads on multitenant workers.
   - Basic and higher plans: Host workloads dedicated to a single App Service plan.
2. **Scaling**: Scaling out adds new worker instances, replicating apps across workers in the same App Service plan.

### Outbound Addresses:
1. **Worker VMs**:
   - Different plans (Free, Shared, Basic, Standard, Premium) use different worker VM types.
   - PremiumV2 and PremiumV3 plans use distinct VM types with different outbound addresses.
2. **Outbound Address Listing**: 
   - Outbound addresses for your app are listed in the app’s properties and are shared across apps on the same worker VM family.
   - The property `possibleOutboundIpAddresses` lists all possible outbound IPs for a scale unit.

### Finding Outbound IPs:
1. **Azure Portal**: Access **Properties** in your app's left-hand navigation to find current outbound IP addresses.
2. **Azure CLI Commands**:
   - To find current outbound IPs:  
     ```
     az webapp show \
     --resource-group <group_name> \
     --name <app_name> \ 
     --query outboundIpAddresses \
     --output tsv
     ```
   - To find all possible outbound IPs:  
     ```
     az webapp show \
     --resource-group <group_name> \ 
     --name <app_name> \ 
     --query possibleOutboundIpAddresses \
     --output tsv
     ```