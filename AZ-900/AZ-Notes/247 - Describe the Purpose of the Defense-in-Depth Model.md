Describe the Purpose of the Defense-in-Depth Model


### **Defense-in-Depth Summary**

1. **Objective**
   - **Protect Information**: The primary goal is to safeguard information and prevent unauthorized access or theft through multiple protective layers.
   - **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-azure-identity-access-security/media/defense-depth-486afc12.png)
   
2. **Concept**
   - **Layers of Protection**: Defense-in-depth uses a multi-layered approach where each layer provides protection to slow down and potentially prevent attacks, ensuring that if one layer is breached, others remain in place.

3. **Layers Overview**
   - **Physical Security**
     - **Purpose**: Protects hardware in the datacenter.
     - **Measures**: Physical access controls and safeguards to prevent unauthorized physical access to assets.

   - **Identity and Access**
     - **Purpose**: Manages and secures user identities and access rights.
     - **Measures**: Single sign-on (SSO), multifactor authentication (MFA), and logging of sign-in events and changes.

   - **Perimeter**
     - **Purpose**: Protects against network-based attacks.
     - **Measures**: Distributed Denial of Service (DDoS) protection and perimeter firewalls to filter and identify large-scale attacks.

   - **Network**
     - **Purpose**: Limits and controls network communication.
     - **Measures**: Network segmentation, restricting inbound and outbound access, and secure connectivity to on-premises networks.

   - **Compute**
     - **Purpose**: Secures access to virtual machines and other compute resources.
     - **Measures**: Endpoint protection, patch management, and securing virtual machines.

   - **Application**
     - **Purpose**: Ensures that applications are secure and free from vulnerabilities.
     - **Measures**: Integrate security in the development lifecycle, use secure storage for sensitive secrets, and make security a design requirement.

   - **Data**
     - **Purpose**: Controls and secures data access.
     - **Measures**: Protect data stored in databases, disks, SaaS applications, and cloud storage, ensuring compliance with regulatory requirements for data confidentiality, integrity, and availability.

4. **Implementation in Azure**
   - **Azure Tools**: Azure provides security features and tools for each layer, ensuring comprehensive protection across physical, network, compute, application, and data layers.

5. **Overall Strategy**
   - **Redundancy and Alerting**: Each layer is designed to provide redundancy and alert information to security teams, allowing for automatic or manual responses to potential threats.

By implementing these layers, defense-in-depth aims to create a robust security posture that mitigates risks and enhances overall protection.
