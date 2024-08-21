Describe the Concept of Zero Trust

### **Zero Trust Model Summary**

1. **Core Concept**
   - **Assumption of Breach**: Zero Trust operates under the assumption that a breach is inevitable and thus treats every request as though it is originating from an uncontrolled network.
   - **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-azure-identity-access-security/media/zero-trust-cf9202be.png)
   
2. **Guiding Principles**
   - **Verify Explicitly**: Always authenticate and authorize requests based on comprehensive data points, ensuring that identity and access are continuously verified.
   - **Use Least Privilege Access**: Grant only the minimum necessary access required for users to perform their tasks. Implement Just-In-Time (JIT) and Just-Enough-Access (JEA) principles, apply risk-based adaptive policies, and enforce data protection.
   - **Assume Breach**: Reduce the potential impact of breaches by segmenting access, verifying end-to-end encryption, and utilizing analytics for visibility, threat detection, and defense improvement.

3. **Traditional vs. Zero Trust**
   - **Traditional Security**: Relied on the assumption that devices within the corporate network were secure. VPNs were used to control access, and personal devices were often restricted.
   - **Zero Trust Model**: Replaces network location assumptions with a requirement for all users and devices to authenticate. Access decisions are based on authentication and risk, not solely on network location.

4. **Access Control**
   - **Authentication**: Required for all users and devices regardless of their location within or outside the corporate network.
   - **Access Granting**: Based on verified identity and contextual information, rather than simply network presence.

5. **Implementation Considerations**
   - **Security Adaptation**: Adapts to modern, mobile, and distributed work environments by ensuring that access controls are dynamic and context-aware.
   - **Segmented Access**: Limits the blast radius of potential breaches by segmenting access and using granular policies.

6. **Visibility and Monitoring**
   - **Analytics**: Employs analytics to monitor, detect threats, and continuously improve security measures based on real-time data and insights.