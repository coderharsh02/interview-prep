Describe Microsoft Entra Conditional Access

### **Azure Conditional Access Summary**

1. **Definition**
   - **Conditional Access**: A tool in Microsoft Entra ID that controls access to resources based on identity signals like user identity, location, and device.

   - **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-azure-identity-access-security/media/conditional-access-9bd268b8.png)

2. **Functionality**
   - **Signal Collection**: During sign-in, Conditional Access collects various signals from the user (e.g., location, device).
   - **Decision Making**: Based on collected signals, Conditional Access decides to either allow access, deny access, or prompt for multifactor authentication (MFA).
   - **Enforcement**: Implements the decision, such as granting access, blocking access, or requiring additional authentication.

3. **Granular MFA Experience**
   - **Context-Based MFA**: Users may be required to provide MFA based on their location, device, or other unusual sign-in signals.
   - **Flexible Challenges**: For known locations or secure devices, MFA may not be required, while unusual or high-risk situations may trigger additional authentication requirements.

4. **Use Cases**
   - **Requiring MFA**: Enforce MFA based on factors such as user role, location, or network. For instance, MFA can be mandated for administrators or for users accessing from outside the corporate network.
   - **Restricting Access to Approved Applications**: Limit access to services only through specific client applications.
   - **Managing Devices**: Ensure access only from devices that meet security and compliance standards.
   - **Blocking Untrusted Sources**: Prevent access from unknown or unexpected locations.

5. **Benefits**
   - **Enhanced Security**: By using conditional access policies, organizations can better secure their resources and ensure that access is granted based on context.
   - **User Productivity**: Allows users to access resources securely from various locations and devices while minimizing disruptions to their workflow.