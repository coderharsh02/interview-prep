Describe the Purpose of Tags

### **Purpose of Tags in Azure**

1. **Resource Management**
   - **Organization**: Helps locate and manage resources based on workloads, environments, business units, and owners.

2. **Cost Management and Optimization**
   - **Cost Reporting**: Enables grouping of resources for cost reporting, internal cost allocation, budget tracking, and cost forecasting.

3. **Operations Management**
   - **Service-Level Agreements (SLAs)**: Helps group resources based on criticality for formulating SLAs, ensuring appropriate uptime and performance guarantees.

4. **Security**
   - **Data Classification**: Assists in classifying resources by security level (e.g., public, confidential) for better data protection.

5. **Governance and Regulatory Compliance**
   - **Compliance**: Helps identify resources that meet governance or compliance standards (e.g., ISO 27001) and enforces tagging standards for consistency.

6. **Workload Optimization and Automation**
   - **Resource Visualization**: Tags help in visualizing resources related to complex deployments and aid in automating tasks through tools like Azure DevOps.

### **Managing Resource Tags**

1. **Tag Management**:
   - Tags can be added, modified, or deleted using Windows PowerShell, Azure CLI, Azure Resource Manager templates, REST API, or Azure portal.

2. **Azure Policy**:
   - Enforces tagging rules and conventions.
   - Can require specific tags for new resources or reapply removed tags.

3. **Custom Tagging Schemas**:
   - Tags are not inherited from subscriptions or resource groups; custom schemas can be applied at different levels (resource, resource group, subscription).

### **Example Tagging Structure**

- **Name-Value Pairs**:
  - **AppName**: The name of the application the resource is part of.
  - **CostCenter**: Internal cost center code.
  - **Owner**: Name of the business owner responsible for the resource.
  - **Environment**: Environment name (e.g., "Prod," "Dev," "Test").
  - **Impact**: Importance level (e.g., "Mission-critical," "High-impact," "Low-impact").

- **Tag Enforcement**:
  - Specific tags like Impact might be applied selectively based on the resource’s criticality, not necessarily enforced for all resources.