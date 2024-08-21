Describe Directory Services in Azure, Including Microsoft Entra ID and Microsoft Entra Domain Services

### **Azure Directory Services Summary**

1. **Microsoft Entra ID**
   - **Purpose**: Cloud-based identity and access management service.
   - **Functions**:
     - **Authentication**: Verifies identities for access to applications and resources; supports self-service password reset, multifactor authentication, and custom banned password lists.
     - **Single Sign-On (SSO)**: Allows access to multiple applications with a single set of credentials, simplifying access management.
     - **Application Management**: Manages cloud and on-premises apps using features like Application Proxy, SaaS apps, and My Apps portal.
     - **Device Management**: Registers and manages devices; enables device-based Conditional Access policies.
   - **Users**:
     - **IT Administrators**: Control access based on business requirements.
     - **App Developers**: Integrate identity management into applications.
     - **Users**: Manage their own identities and passwords.
     - **Service Subscribers**: Used by Microsoft 365, Azure, and other Microsoft services for authentication.

2. **Microsoft Entra Connect**
   - **Purpose**: Connects on-premises Active Directory with Microsoft Entra ID.
   - **Functions**:
     - **Synchronization**: Syncs user identities and changes between on-premises AD and Microsoft Entra ID.
     - **Features**: Supports SSO, multifactor authentication, and self-service password reset in both systems.

3. **Microsoft Entra Domain Services**
   - **Purpose**: Provides managed domain services like domain join, group policy, LDAP, and Kerberos/NTLM authentication.
   - **Benefits**:
     - **Managed Service**: Eliminates the need to deploy and manage domain controllers in the cloud.
     - **Integration**: Integrates with Microsoft Entra ID, allowing use of existing credentials and user accounts.
   - **Operation**:
     - **Namespace and DCs**: Creates a managed domain with a unique namespace and deploys two Windows Server domain controllers.
     - **Management**: Azure handles DCs, including backups and encryption.
     - **Synchronization**: One-way sync from Microsoft Entra ID to Entra Domain Services; changes in the managed domain are not synchronized back to Entra ID.

4. **Use Cases for Microsoft Entra Domain Services**:
   - **Legacy Applications**: Supports running legacy applications in the cloud without modern authentication methods.
   - **Lift-and-Shift**: Facilitates moving on-premises applications and resources to Azure with minimal changes.