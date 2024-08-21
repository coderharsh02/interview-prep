### **Point-Wise Summary of Azure DNS**

1. **Overview**
   - **Purpose**: A hosting service for DNS domains providing name resolution using Microsoft Azure infrastructure.
   - **Integration**: Manages DNS records with Azure credentials, APIs, tools, and billing.

2. **Benefits of Azure DNS**
   - **Reliability and Performance**: 
     - **Global Network**: Hosted on Azure’s global DNS name servers for high availability and resiliency.
     - **Anycast Networking**: Directs DNS queries to the closest server, ensuring fast performance and reliability.
   - **Security**:
     - **Azure Resource Manager**: Utilizes features like Azure RBAC for access control, activity logs for monitoring, and resource locking to prevent accidental deletions or modifications.
   - **Ease of Use**:
     - **Integration**: Manages DNS for both Azure and external resources using the Azure portal, PowerShell, Azure CLI, and REST API.
     - **Single Management Interface**: Uses the same credentials, support contract, and billing as other Azure services.
   - **Customizable Virtual Networks**:
     - **Private DNS Domains**: Allows use of custom domain names within private virtual networks.
   - **Alias Records**:
     - **Support for Alias Records**: Refers to Azure resources (e.g., public IP addresses, Traffic Manager profiles, CDN endpoints). Alias records automatically update during DNS resolution if the resource's IP address changes.

3. **Limitations**
   - **Domain Purchase**: Azure DNS does not support domain name purchases. Domains must be bought via App Service domains or third-party registrars, and then managed in Azure DNS for record management.