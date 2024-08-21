Describe the purpose of Azure Policy

### **Purpose of Azure Policy**

1. **Compliance Management**
   - **Policy Creation**: Allows creation, assignment, and management of policies to ensure resource configurations meet corporate standards.
   - **Compliance Enforcement**: Enforces rules across resources to maintain compliance.

2. **Policy Definition**
   - **Individual Policies**: Define specific rules for resource configurations.
   - **Initiatives**: Group related policies together into initiatives for broader compliance goals.

3. **Scope and Inheritance**
   - **Level-Based Policies**: Apply policies at various levels (resource, resource group, subscription).
   - **Inheritance**: Policies set at a higher level are automatically applied to all subordinate groupings.

4. **Built-In Definitions**
   - **Predefined Policies**: Comes with built-in definitions for different services such as Storage, Networking, Compute, Security Center, and Monitoring.
   - **Examples**: Policies can restrict VM sizes, and monitor existing resources for compliance.

5. **Automatic Remediation**
   - **Noncompliance Fixes**: Can automatically remediate noncompliant resources (e.g., applying missing tags).
   - **Exceptions**: Allows flagging resources to prevent automatic fixes for specific cases.

6. **Integration with Azure DevOps**
   - **CI/CD Integration**: Applies policies related to pre-deployment and post-deployment phases in Azure DevOps pipelines.

7. **Azure Policy Initiatives**
   - **Group Policies**: Initiatives group related policies to track compliance for larger goals.
   - **Example Initiative**: "Enable Monitoring in Azure Security Center" includes policies for monitoring SQL databases, OS vulnerabilities, and endpoint protection, among others.

