Describe Authentication Methods in Azure, Including Single Sign-On (SSO), Multi-Factor Authentication (MFA), and Passwordless


### **Azure Authentication Methods Summary**

1. **Standard Passwords**
   - **Description**: Traditional method requiring a username and password.
   - **Security**: Low security due to susceptibility to breaches and weak passwords.

2. **Single Sign-On (SSO)**
   - **Description**: Allows users to sign in once and access multiple applications or resources.
   - **Benefits**:
     - Simplifies credential management with a single ID and password.
     - Reduces password fatigue and management overhead.
   - **Limitations**: Security of SSO depends on the security of the initial authenticator.

3. **Multifactor Authentication (MFA)**
   - **Description**: Requires two or more forms of identification to authenticate.
   - **Types**:
     - **Something the user knows**: Challenge question or password.
     - **Something the user has**: Code sent to a phone or mobile device.
     - **Something the user is**: Biometric data like fingerprint or face scan.
   - **Benefits**: Increases security by adding additional layers beyond just a password.

4. **Microsoft Entra Multifactor Authentication**
   - **Description**: Microsoft service providing MFA capabilities.
   - **Features**: Users can choose additional authentication forms like phone calls or mobile app notifications.

5. **Passwordless Authentication**
   - **Description**: Replaces passwords with other forms of authentication, enhancing convenience and security.
   - **Methods**:
     - **Windows Hello for Business**: Utilizes biometric or PIN credentials tied to a Windows PC. Supports both on-premises and cloud resources.
     - **Microsoft Authenticator App**: Converts mobile phones into passwordless authentication devices. Users confirm identity via notifications, numbers, or biometrics.
     - **FIDO2 Security Keys**: Standards-based passwordless method using hardware devices (e.g., USB, Bluetooth) or platform keys built into devices.

6. **Comparison of Authentication Methods**
   - **Passwords**: High convenience, low security.
   - **Passwords + MFA**: Moderate convenience, high security.
   - **Passwordless Authentication**: High convenience and high security.
   - **Diagram**: ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-azure-identity-access-security/media/passwordless-convenience-security-30321b4d.png)