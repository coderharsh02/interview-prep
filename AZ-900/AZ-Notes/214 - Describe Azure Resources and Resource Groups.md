Describe Azure Resources and Resource Groups

Here’s a pointwise summary of Azure's management infrastructure:

### **1. Azure Resources and Resource Groups**
- **Resources**: Basic building blocks in Azure, including Virtual Machines (VMs), virtual networks, databases, and cognitive services.
- **Resource Groups**: 
  - **Purpose**: Logical groupings of resources for management and organization.
  - **Functionality**: Actions applied to a resource group affect all resources within it. Deleting a resource group deletes all its resources.
  - **Design**: Choose a resource group structure based on your needs for access control, management, and deprovisioning.
- **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-core-architectural-components-of-azure/media/resource-group-eb2d7177.png)

### **2. Azure Subscriptions**
- **Definition**: Units of management, billing, and scale.
- **Functionality**:
  - **Access**: Provides authenticated access to Azure products and services.
  - **Billing**: Separate subscriptions can be used to manage billing for different projects or departments.
  - **Access Control**: Different subscriptions can be used to apply distinct access-management policies.
- **Types of Boundaries**:
  - **Billing Boundary**: Organizes costs and generates separate billing reports for each subscription.
  - **Access Control Boundary**: Manages access policies based on organizational structures.
- **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-core-architectural-components-of-azure/media/subscriptions-d415577b.png)

### **3. Creating Additional Subscriptions**
- **Environments**: Separate subscriptions for development, testing, and production environments.
- **Organizational Structures**: Reflect different departmental needs with distinct subscription policies.
- **Billing**: Track and manage costs by separating subscriptions for various purposes (e.g., production vs. development).

### **4. Azure Management Groups**
- **Definition**: Containers for organizing multiple subscriptions and applying governance.
- **Functionality**:
  - **Hierarchy**: Manage access, policies, and compliance across multiple subscriptions.
  - **Inheritance**: Subscriptions under a management group inherit policies and access settings from the group.
  - **Flexibility**: Management groups can be nested to create a hierarchy for enterprise-grade management.
- **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-core-architectural-components-of-azure/media/management-groups-subscriptions-dfd5a108.png)

### **5. Examples of Using Management Groups**
- **Policy Application**: Enforce region-specific policies on all subscriptions and resources within a management group.
- **Access Management**: Assign Azure RBAC roles at the management group level for unified access control across all contained subscriptions and resources.

### **6. Important Facts**
- **Support**: Up to 10,000 management groups can be supported in a single directory.
- **Hierarchy**: Management groups can be nested up to six levels deep.
- **Parent-Child Relationship**: Each management group and subscription can have only one parent.

This structure helps in organizing Azure resources efficiently, managing access, and applying consistent policies across your Azure environment.