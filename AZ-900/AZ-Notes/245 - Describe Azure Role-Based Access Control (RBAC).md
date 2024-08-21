Describe Azure Role-Based Access Control (RBAC)

### **Azure Role-Based Access Control (RBAC) Summary**

1. **Purpose**
   - **Azure RBAC**: Manages access to Azure resources by assigning roles with specific permissions to users or groups. It follows the principle of least privilege, granting only the necessary access required to perform tasks.

2. **Roles and Permissions**
   - **Built-in Roles**: Azure provides predefined roles with common permissions, e.g., Owner, Contributor, Reader.
   - **Custom Roles**: You can create custom roles with specific permissions tailored to your needs.
   - **Role Assignment**: When a user or group is assigned a role, they inherit the permissions associated with that role.

3. **Scope**
   - **Scope Definition**: Access permissions are applied to a scope, which can be a management group, subscription, resource group, or individual resource.
   - **Hierarchical Inheritance**: Permissions assigned at a parent scope (e.g., management group) are inherited by child scopes (e.g., subscriptions, resource groups).

4. **Examples**
   - **Owner Role**: Full control over all resources within a management group or subscription.
   - **Reader Role**: Read-only access to view resources within a scope without making changes.

5. **Application of RBAC**
   - **Scope Examples**:
     - **Management Group**: A collection of multiple subscriptions.
     - **Subscription**: A single subscription.
     - **Resource Group**: A grouping of related resources.
     - **Resource**: An individual Azure resource.
   - **Role Examples**:
     - **Observer**: View access with no modification rights.
     - **Admin**: Full management rights.

6. **Enforcement**
   - **Azure Resource Manager (ARM)**: Azure RBAC permissions are enforced through ARM, which handles actions and management of resources.
   - **Access Tools**: Managed through Azure Portal, Azure Cloud Shell, Azure PowerShell, and Azure CLI.
   - **Allow Model**: Permissions are granted based on role assignments. Combining multiple roles can accumulate permissions (e.g., both read and write if assigned roles with those permissions).

7. **Limitations**
   - **Application Level Security**: Azure RBAC does not enforce permissions at the application or data level; application security must be managed separately.