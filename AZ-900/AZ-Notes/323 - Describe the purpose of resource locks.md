Describe the purpose of resource locks

### **Purpose of Resource Locks**

1. **Prevent Accidental Changes**
   - **Primary Function**: Prevents resources from being accidentally deleted or altered, even with Azure RBAC in place.

2. **Scope of Application**
   - **Levels**: Can be applied to individual resources, resource groups, or entire subscriptions.
   - **Inheritance**: Locks applied at a higher level (e.g., resource group) automatically apply to all subordinate resources.

3. **Types of Resource Locks**
   - **Delete Lock**: Prevents deletion of the resource but allows reading and modification.
   - **ReadOnly Lock**: Prevents deletion and modification, only allowing reading. Equivalent to Reader role permissions.

4. **Management Methods**
   - **Azure Portal**: Manage locks via the Settings section of a resource’s Settings pane.
   - **PowerShell, Azure CLI, ARM Templates**: Alternative methods to manage resource locks.

5. **Modifying Locked Resources**
   - **Removal of Lock**: To change or delete a locked resource, first remove the lock.
   - **RBAC Permissions**: Resource locks override RBAC permissions; even resource owners must remove the lock to make changes.