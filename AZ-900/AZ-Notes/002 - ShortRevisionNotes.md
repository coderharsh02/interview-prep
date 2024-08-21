### **1. Describe Cloud Concepts (25–30%)**

#### **1.1 Describe Cloud Computing**
- **1.1.1 Define Cloud Computing**
  - **Definition**: Delivery of computing services (servers, storage, databases, etc.) over the internet ("the cloud") for faster innovation, flexible resources, and economies of scale.

- **1.1.2 Describe the Shared Responsibility Model**
  - **Definition**: The cloud provider manages the infrastructure, while the customer manages the applications, data, and configurations.

- **1.1.3 Define Cloud Models, Including Public, Private, and Hybrid**
  - **Public Cloud**: Services offered over the internet by third-party providers (e.g., Azure).
  - **Private Cloud**: Cloud infrastructure operated solely for one organization, either on-premises or hosted by a third party.
  - **Hybrid Cloud**: Combination of public and private clouds, allowing data and applications to be shared between them.

- **1.1.4 Identify Appropriate Use Cases for Each Cloud Model**
  - **Public Cloud**: Cost-effective, scalable services for general use.
  - **Private Cloud**: Sensitive data handling, custom security needs.
  - **Hybrid Cloud**: Data sovereignty, critical applications requiring private infrastructure.

- **1.1.5 Describe the Consumption-Based Model**
  - **Definition**: Pay-as-you-go pricing where you pay only for the resources you use.

- **1.1.6 Compare Cloud Pricing Models**
  - **On-Demand**: Pay for what you use with no long-term commitments.
  - **Reserved Instances**: Commit to a certain level of usage for a discount.
  - **Spot Instances**: Use spare capacity at a lower cost, with possible interruptions.

- **1.1.7 Describe Serverless**
  - **Definition**: Execution model where cloud providers manage the infrastructure, scaling automatically, and you only pay for the compute time consumed by your application.

#### **1.2 Describe the Benefits of Using Cloud Services**
- **1.2.1 Describe the Benefits of High Availability and Scalability in the Cloud**
  - **High Availability**: Minimizes downtime with redundant resources.
  - **Scalability**: Automatically adjusts resources based on demand.

- **1.2.2 Describe the Benefits of Reliability and Predictability in the Cloud**
  - **Reliability**: Consistent performance with service level agreements (SLAs).
  - **Predictability**: Clear cost and performance metrics.

- **1.2.3 Describe the Benefits of Security and Governance in the Cloud**
  - **Security**: Advanced security features and compliance certifications.
  - **Governance**: Tools for managing policies and compliance.

- **1.2.4 Describe the Benefits of Manageability in the Cloud**
  - **Manageability**: Centralized control and monitoring tools for managing resources.

#### **1.3 Describe Cloud Service Types**
- **1.3.1 Describe Infrastructure as a Service (IaaS)**
  - **Definition**: Provides virtualized computing resources over the internet. Example: Azure Virtual Machines.

- **1.3.2 Describe Platform as a Service (PaaS)**
  - **Definition**: Provides hardware and software tools over the internet, typically used for application development. Example: Azure App Services.

- **1.3.3 Describe Software as a Service (SaaS)**
  - **Definition**: Delivers software applications over the internet on a subscription basis. Example: Microsoft 365.

- **1.3.4 Identify Appropriate Use Cases for Each Cloud Service Type (IaaS, PaaS, and SaaS)**
  - **IaaS**: Customizable infrastructure needs.
  - **PaaS**: Application development and deployment.
  - **SaaS**: Ready-to-use software solutions.

### **2. Describe Azure Architecture and Services (35–40%)**

#### **2.1 Describe the Core Architectural Components of Azure**
- **2.1.1 Describe Azure Regions, Region Pairs, and Sovereign Regions**
  - **Regions**: Geographical locations containing Azure data centers.
  - **Region Pairs**: Two regions within the same geography for disaster recovery.
  - **Sovereign Regions**: Data centers with specific legal and compliance requirements.

- **2.1.2 Describe Availability Zones**
  - **Definition**: Physically separated data centers within a region to enhance fault tolerance.

- **2.1.3 Describe Azure Datacenters**
  - **Definition**: Facilities that house Azure’s cloud resources, including servers, storage, and networking equipment.

- **2.1.4 Describe Azure Resources and Resource Groups**
  - **Resources**: Individual components such as VMs, storage, and databases.
  - **Resource Groups**: Logical containers for organizing and managing Azure resources.

- **2.1.5 Describe Subscriptions**
  - **Definition**: Logical containers that provide access to Azure resources and billing.

- **2.1.6 Describe Management Groups**
  - **Definition**: Hierarchical containers used to manage access, policies, and compliance across multiple subscriptions.

- **2.1.7 Describe the Hierarchy of Resource Groups, Subscriptions, and Management Groups**
  - **Hierarchy**: Management Groups > Subscriptions > Resource Groups > Resources.

#### **2.2 Describe Azure Compute and Networking Services**
- **2.2.1 Compare Compute Types, Including Containers, Virtual Machines, and Functions**
  - **Containers**: Lightweight, portable application environments (e.g., Azure Kubernetes Service).
  - **Virtual Machines**: Full VMs that can run any software (e.g., Azure Virtual Machines).
  - **Functions**: Event-driven, serverless compute (e.g., Azure Functions).

- **2.2.2 Describe Virtual Machine Options, Including Azure Virtual Machines, Azure Virtual Machine Scale Sets, Availability Sets, and Azure Virtual Desktop**
  - **Azure Virtual Machines**: On-demand scalable computing resources.
  - **Virtual Machine Scale Sets**: Automatically scale VMs to meet demand.
  - **Availability Sets**: Ensures VMs are distributed across fault and update domains.
  - **Azure Virtual Desktop**: Virtualized desktop environment for remote access.

- **2.2.3 Describe the Resources Required for Virtual Machines**
  - **Resources**: CPU, memory, storage, and networking.

- **2.2.4 Describe Application Hosting Options, Including Web Apps, Containers, and Virtual Machines**
  - **Web Apps**: Host web applications without managing infrastructure (e.g., Azure App Service).
  - **Containers**: For lightweight, isolated applications.
  - **Virtual Machines**: For full control over the operating system and applications.

- **2.2.5 Describe Virtual Networking, Including the Purpose of Azure Virtual Networks, Azure Virtual Subnets, Peering, Azure DNS, Azure VPN Gateway, and ExpressRoute**
  - **Azure Virtual Networks**: Private network to connect Azure resources.
  - **Azure Virtual Subnets**: Logical segments of a Virtual Network.
  - **Peering**: Connects two Virtual Networks.
  - **Azure DNS**: Domain name system services.
  - **Azure VPN Gateway**: Connects on-premises networks to Azure.
  - **ExpressRoute**: Private, dedicated network connection to Azure.

- **2.2.6 Define Public and Private Endpoints**
  - **Public Endpoints**: Accessible over the internet.
  - **Private Endpoints**: Accessible only within a virtual network.

#### **2.3 Describe Azure Storage Services**
- **2.3.1 Compare Azure Storage Services**
  - **Blob Storage**: For unstructured data.
  - **File Storage**: For file shares accessible via SMB protocol.
  - **Queue Storage**: For messaging between applications.
  - **Table Storage**: For NoSQL data.

- **2.3.2 Describe Storage Tiers**
  - **Hot**: Frequently accessed data.
  - **Cool**: Infrequently accessed data.
  - **Archive**: Long-term storage for rarely accessed data.

- **2.3.3 Describe Redundancy Options**
  - **Locally Redundant Storage (LRS)**: Replicates data within a single region.
  - **Geo-Redundant Storage (GRS)**: Replicates data across regions.
  - **Read-Access Geo-Redundant Storage (RA-GRS)**: Provides read access to replicated data in a secondary region.

- **2.3.4 Describe Storage Account Options and Storage Types**
  - **Storage Account Options**: General-purpose v2 (GPv2), Blob storage.
  - **Storage Types**: Blob, File, Queue, and Table storage.

- **2.3.5 Identify Options for Moving Files, Including AzCopy, Azure Storage Explorer, and Azure File Sync**
  - **AzCopy**: Command-line tool for copying data.
  - **Azure Storage Explorer**: GUI tool for managing storage accounts.
  - **Azure File Sync**: Synchronizes on-premises file servers with Azure File shares.

- **2.3.6 Describe Migration Options, Including Azure Migrate and Azure Data Box**
  - **Azure Migrate**: Tool for assessing and migrating on-premises workloads.
  - **Azure Data Box**: Physical device for transferring large amounts of data to Azure.

#### **2.4 Describe Azure Identity, Access, and Security**
- **2.4.1 Describe Directory Services in Azure, Including Microsoft Entra ID and Microsoft Entra Domain Services**
  - **Microsoft Entra ID**: Identity management and access control.
  - **Microsoft Entra Domain Services**

: Managed domain services such as domain join and group policy.

- **2.4.2 Describe Authentication Methods in Azure, Including Single Sign-On (SSO), Multi-Factor Authentication (MFA), and Passwordless**
  - **SSO**: Allows users to access multiple applications with one login.
  - **MFA**: Adds a second layer of security beyond passwords.
  - **Passwordless**: Authentication methods that do not rely on passwords.

- **2.4.3 Describe External Identities in Azure, Including Business-to-Business (B2B) and Business-to-Customer (B2C)**
  - **B2B**: Allows external users to access internal resources.
  - **B2C**: Manages consumer identities and authentication.

- **2.4.4 Describe Microsoft Entra Conditional Access**
  - **Definition**: Policies that provide access controls based on conditions like user location, device compliance, and risk levels.

- **2.4.5 Describe Azure Role-Based Access Control (RBAC)**
  - **Definition**: Manages user access to Azure resources based on roles assigned.

- **2.4.6 Describe the Concept of Zero Trust**
  - **Definition**: Security model that assumes no implicit trust, requiring verification for every access request.

- **2.4.7 Describe the Purpose of the Defense-in-Depth Model**
  - **Definition**: Security approach that uses multiple layers of defense to protect resources.

- **2.4.8 Describe the Purpose of Microsoft Defender for Cloud**
  - **Definition**: Unified security management system that provides threat protection and security posture management.

### **3. Describe Azure Management and Governance (30–35%)**

#### **3.1 Describe Cost Management in Azure**
- **3.1.1 Describe Factors That Can Affect Costs in Azure**
  - **Factors**: Resource type, usage patterns, and pricing models.

- **3.1.2 Compare the Pricing Calculator and the Total Cost of Ownership (TCO) Calculator**
  - **Pricing Calculator**: Estimates costs for different services.
  - **TCO Calculator**: Compares costs of running services on-premises vs. in Azure.

- **3.1.3 Describe Cost Management Capabilities in Azure**
  - **Capabilities**: Budgeting, cost analysis, and cost optimization tools.

- **3.1.4 Describe the Purpose of Tags**
  - **Definition**: Metadata labels used to organize and manage resources for cost tracking and reporting.

#### **3.2 Describe Features and Tools in Azure for Governance and Compliance**
- **3.2.1 Describe the Purpose of Microsoft Purview in Azure**
  - **Definition**: Data governance and management service providing data cataloging and classification.

- **3.2.2 Describe the Purpose of Azure Policy**
  - **Definition**: Enforces rules and effects over resources to ensure compliance with organizational standards.

- **3.2.3 Describe the Purpose of Resource Locks**
  - **Definition**: Prevents accidental deletion or modification of resources.

#### **3.3 Describe Features and Tools for Managing and Deploying Azure Resources**
- **3.3.1 Describe the Azure Portal**
  - **Definition**: Web-based interface for managing Azure resources.

- **3.3.2 Describe Azure Cloud Shell, Including Azure Command-Line Interface (CLI) and Azure PowerShell**
  - **Azure CLI**: Command-line tool for managing Azure resources.
  - **Azure PowerShell**: PowerShell module for Azure resource management.
  - **Cloud Shell**: Browser-based shell environment with pre-configured tools.

- **3.3.3 Describe the Purpose of Azure Arc**
  - **Definition**: Extends Azure management and services to on-premises, multi-cloud, and edge environments.

- **3.3.4 Describe Infrastructure as Code (IaC)**
  - **Definition**: Managing and provisioning infrastructure using code and automation.

- **3.3.5 Describe Azure Resource Manager (ARM) and ARM Templates**
  - **ARM**: Manages deployment and configuration of Azure resources.
  - **ARM Templates**: JSON files for defining and deploying Azure resources.

#### **3.4 Describe Monitoring Tools in Azure**
- **3.4.1 Describe the Purpose of Azure Advisor**
  - **Definition**: Provides recommendations for improving Azure resource performance, security, reliability, and cost.

- **3.4.2 Describe Azure Service Health**
  - **Definition**: Monitors and provides information about the health of Azure services and resources.

- **3.4.3 Describe Azure Monitor, Including Log Analytics, Azure Monitor Alerts, and Application Insights**
  - **Azure Monitor**: Collects and analyzes monitoring data.
  - **Log Analytics**: Tool for querying and analyzing logs.
  - **Azure Monitor Alerts**: Notifies when thresholds are breached.
  - **Application Insights**: Monitors application performance and usage.