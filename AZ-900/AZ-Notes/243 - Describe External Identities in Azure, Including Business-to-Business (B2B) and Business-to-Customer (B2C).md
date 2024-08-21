Describe External Identities in Azure, Including Business-to-Business (B2B) and Business-to-Customer (B2C)

### **Azure External Identities Summary**

1. **Definition**
   - **External Identity**: Refers to individuals, devices, services, or entities outside your organization interacting with your resources.
   - **Microsoft Entra External ID**: Provides mechanisms for managing external users and their access to organizational resources.

   - **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-azure-identity-access-security/media/azure-active-directory-external-identities-5a892021.png)

2. **Capabilities of External Identities**

   - **Business to Business (B2B) Collaboration**:
     - **Description**: Allows external users to use their existing identities (e.g., corporate or social identities) to access your resources.
     - **Representation**: External users are added as guest users in your directory.
     - **Use Cases**: Collaboration with partners, vendors, or suppliers using their preferred identity.

   - **B2B Direct Connect**:
     - **Description**: Establishes a two-way trust with another Microsoft Entra organization for seamless collaboration.
     - **Support**: Currently supports shared channels in Microsoft Teams.
     - **Visibility**: External users are visible in Teams shared channels and monitored via the Teams admin center, but not represented in your directory.

   - **Azure Active Directory Business to Customer (B2C)**:
     - **Description**: Manages identities for consumers and customers accessing modern SaaS or custom-developed apps.
     - **Scope**: Excludes Microsoft apps and focuses on external customer interactions.

3. **Management and Access Control**

   - **Guest User Invitations**:
     - **Process**: Administrators or users can invite guest users from other tenants or social identities.
     - **Access Control**: Administrators can manage guest access and permissions.

   - **Access Reviews**:
     - **Purpose**: To ensure appropriate access levels for guest users.
     - **Process**: Reviews can be conducted by guests themselves or decision-makers.
     - **Outcome**: Based on reviews, access can be adjusted or removed as necessary.

4. **Integration**
   - **Microsoft Entra B2B**: Facilitates collaboration across organizational boundaries.
   - **Azure AD B2C**: Handles customer identity management for applications.

This overview highlights how Azure's external identity management features can enable secure and efficient collaboration with external parties and manage customer interactions.