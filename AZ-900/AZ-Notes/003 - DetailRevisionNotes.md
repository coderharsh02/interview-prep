### **1. Describe Cloud Concepts (25–30%)**

#### **1.1 Describe Cloud Computing**

- **1.1.1 Define Cloud Computing**
  - **Definition**: Cloud computing delivers computing services like servers, storage, databases, networking, software, and analytics over the internet ("the cloud"). It enables on-demand access to these resources without the need for physical hardware, providing flexibility, scalability, and cost efficiency.

- **1.1.2 Describe the Shared Responsibility Model**
  - **Definition**: Cloud security is divided between the cloud provider and the customer. 
    - **Provider**: Manages the physical infrastructure, including hardware, network, and facilities.
    - **Customer**: Manages applications, data, and user access, including configuring security settings and compliance.

- **1.1.3 Define Cloud Models, Including Public, Private, and Hybrid**
  - **Public Cloud**: Services offered over the internet by third-party providers (e.g., Azure). Resources are shared among multiple customers.
  - **Private Cloud**: Exclusive cloud infrastructure used by a single organization. It can be on-premises or hosted by a third party but is not shared with others.
  - **Hybrid Cloud**: Combines public and private clouds, allowing data and applications to be shared between them. It offers flexibility and optimized deployment strategies.

- **1.1.4 Identify Appropriate Use Cases for Each Cloud Model**
  - **Public Cloud**: Ideal for businesses needing scalability and cost-efficiency without managing physical hardware. Suitable for development, testing, and production workloads.
  - **Private Cloud**: Best for organizations with strict security, compliance, or data sovereignty requirements. Suitable for sensitive or mission-critical applications.
  - **Hybrid Cloud**: Useful for organizations that need to keep certain workloads on-premises while leveraging public cloud resources for other functions. It balances cost, security, and flexibility.

- **1.1.5 Describe the Consumption-Based Model**
  - **Definition**: In the consumption-based model, you pay only for the resources and services you use, rather than investing in large amounts of hardware and infrastructure. This model provides financial flexibility and aligns costs with actual usage.

- **1.1.6 Compare Cloud Pricing Models**
  - **On-Demand**: Pay for resources as you use them, with no long-term commitment. Ideal for variable workloads.
  - **Reserved Instances**: Prepay for resources over a fixed term (e.g., 1 or 3 years) to receive a discount. Suitable for predictable workloads.
  - **Spot Instances**: Purchase unused capacity at reduced rates, with the possibility of interruptions. Best for flexible or fault-tolerant applications.

- **1.1.7 Describe Serverless**
  - **Definition**: Serverless computing abstracts away infrastructure management, allowing developers to focus on code. Resources are automatically allocated and scaled by the cloud provider, and you only pay for the compute time used by your code. Example: Azure Functions.

#### **1.2 Describe the Benefits of Using Cloud Services**

- **1.2.1 Describe the Benefits of High Availability and Scalability in the Cloud**
  - **High Availability**: Ensures applications remain operational with minimal downtime through redundant resources and geographically dispersed data centers.
  - **Scalability**: Automatically adjusts resources based on demand, enabling applications to handle varying loads efficiently.

- **1.2.2 Describe the Benefits of Reliability and Predictability in the Cloud**
  - **Reliability**: Cloud services provide robust SLAs (Service Level Agreements) that guarantee uptime and performance.
  - **Predictability**: Cloud providers offer tools for forecasting usage and costs, helping organizations plan their budgets more accurately.

- **1.2.3 Describe the Benefits of Security and Governance in the Cloud**
  - **Security**: Cloud providers invest heavily in security measures, including data encryption, access controls, and compliance certifications (e.g., ISO, GDPR).
  - **Governance**: Tools and services for managing policies, compliance, and security configurations help organizations enforce their governance frameworks.

- **1.2.4 Describe the Benefits of Manageability in the Cloud**
  - **Manageability**: Centralized management platforms and automation tools simplify the administration of resources, updates, and configurations, reducing operational overhead.

#### **1.3 Describe Cloud Service Types**

- **1.3.1 Describe Infrastructure as a Service (IaaS)**
  - **Definition**: IaaS provides virtualized computing resources over the internet. Users can provision and manage virtual machines, storage, and networks. Example: Azure Virtual Machines.

- **1.3.2 Describe Platform as a Service (PaaS)**
  - **Definition**: PaaS delivers a platform allowing customers to develop, run, and manage applications without dealing with infrastructure complexities. Example: Azure App Services.

- **1.3.3 Describe Software as a Service (SaaS)**
  - **Definition**: SaaS delivers software applications over the internet on a subscription basis. Users access software through a web browser, with the provider handling infrastructure and platform maintenance. Example: Microsoft 365.

- **1.3.4 Identify Appropriate Use Cases for Each Cloud Service Type (IaaS, PaaS, and SaaS)**
  - **IaaS**: Suitable for hosting custom applications and services, managing workloads with high flexibility.
  - **PaaS**: Ideal for developing and deploying applications without managing underlying infrastructure, reducing development time.
  - **SaaS**: Best for end-user applications requiring minimal setup and maintenance, with automatic updates and support.

### **2. Describe Azure Architecture and Services (35–40%)**

#### **2.1 Describe the Core Architectural Components of Azure**

- **2.1.1 Describe Azure Regions, Region Pairs, and Sovereign Regions**
  - **Regions**: Geographical areas with Azure data centers providing redundancy and data residency options.
  - **Region Pairs**: Two regions within the same geography that are paired for disaster recovery and high availability.
  - **Sovereign Regions**: Data centers meeting specific legal and regulatory requirements for data sovereignty and compliance.

- **2.1.2 Describe Availability Zones**
  - **Definition**: Availability Zones are physically separated data centers within an Azure region that enhance fault tolerance and high availability by distributing resources across multiple zones.

- **2.1.3 Describe Azure Datacenters**
  - **Definition**: Facilities housing Azure’s cloud resources, including servers, storage, and networking equipment. Azure operates multiple data centers worldwide to support its global cloud services.

- **2.1.4 Describe Azure Resources and Resource Groups**
  - **Resources**: Individual components such as virtual machines, storage accounts, and databases.
  - **Resource Groups**: Logical containers for organizing and managing related Azure resources, providing a scope for access control and billing.

- **2.1.5 Describe Subscriptions**
  - **Definition**: Logical containers that provide access to Azure services and resources. Each subscription has its own billing and management boundaries.

- **2.1.6 Describe Management Groups**
  - **Definition**: Hierarchical containers that help manage access, policies, and compliance across multiple Azure subscriptions, enabling centralized management at scale.

- **2.1.7 Describe the Hierarchy of Resource Groups, Subscriptions, and Management Groups**
  - **Hierarchy**: 
    - **Management Groups**: Top-level organization for multiple subscriptions.
    - **Subscriptions**: Under management groups, containing resource groups.
    - **Resource Groups**: Contain individual resources, providing organization and management within subscriptions.

#### **2.2 Describe Azure Compute and Networking Services**

- **2.2.1 Compare Compute Types, Including Containers, Virtual Machines, and Functions**
  - **Containers**: Lightweight and portable environments for running applications. Example: Azure Kubernetes Service (AKS).
  - **Virtual Machines**: Full-fledged VMs with configurable resources and operating systems. Example: Azure Virtual Machines.
  - **Functions**: Serverless compute service for event-driven code execution. Example: Azure Functions.

- **2.2.2 Describe Virtual Machine Options, Including Azure Virtual Machines, Azure Virtual Machine Scale Sets, Availability Sets, and Azure Virtual Desktop**
  - **Azure Virtual Machines**: On-demand, scalable virtualized computing resources.
  - **Virtual Machine Scale Sets**: Automatically adjusts the number of VMs based on demand.
  - **Availability Sets**: Distributes VMs across fault and update domains to minimize downtime.
  - **Azure Virtual Desktop**: Provides a virtualized desktop environment for remote work and application access.

- **2.2.3 Describe the Resources Required for Virtual Machines**
  - **Resources**: Include CPU, memory, disk storage, and network interfaces required to run and manage virtual machines.

- **2.2.4 Describe Application Hosting Options, Including Web Apps, Containers, and Virtual Machines**
  - **Web Apps**: Host web applications on a fully managed platform without managing the underlying infrastructure. Example: Azure App Service.
  - **Containers**: Provide an isolated environment for applications, ideal for microservices and CI/CD workflows.
  - **Virtual Machines**: Offer full control over the operating system and application environment, suitable for custom workloads and legacy applications.

- **2.2.5 Describe Virtual Networking, Including the Purpose of Azure Virtual Networks, Azure Virtual Subnets, Peering, Azure DNS, Azure VPN Gateway, and ExpressRoute**
  - **Azure Virtual Networks**: Provides isolated, private network environments for Azure resources.
  - **Azure Virtual Subnets**: Logical segments within a Virtual Network to organize resources and control traffic flow.
  - **Peering**: Connects two Virtual Networks to allow resource communication.
  -

 **Azure DNS**: Provides domain name resolution for Azure resources.
  - **Azure VPN Gateway**: Connects on-premises networks to Azure via encrypted VPN tunnels.
  - **ExpressRoute**: Establishes a private connection between on-premises infrastructure and Azure, bypassing the public internet.

- **2.2.6 Define Public and Private Endpoints**
  - **Public Endpoints**: Expose Azure resources to the internet for external access.
  - **Private Endpoints**: Provide private access to Azure resources from within a Virtual Network, enhancing security.

#### **2.3 Describe Azure Storage Services**

- **2.3.1 Compare Azure Storage Services**
  - **Blob Storage**: For unstructured data like text and binary data.
  - **Queue Storage**: For storing and processing messages.
  - **Table Storage**: For NoSQL data with a key-value format.
  - **File Storage**: For file shares that can be accessed via SMB protocol.

- **2.3.2 Describe Storage Tiers**
  - **Hot**: Optimized for frequent access.
  - **Cool**: Lower cost for infrequent access.
  - **Archive**: Lowest cost for rarely accessed data with long retention.

- **2.3.3 Describe Redundancy Options**
  - **Locally Redundant Storage (LRS)**: Replicates data within a single data center.
  - **Geo-Redundant Storage (GRS)**: Replicates data across regions for disaster recovery.
  - **Read-Access Geo-Redundant Storage (RA-GRS)**: Same as GRS, with read access in the secondary region.

- **2.3.4 Describe Storage Account Options and Storage Types**
  - **General Purpose v2**: Supports all Azure storage services.
  - **Blob Storage Accounts**: Optimized for large-scale object storage.
  - **File Storage Accounts**: Specialized for file shares.

- **2.3.5 Identify Options for Moving Files, Including AzCopy, Azure Storage Explorer, and Azure File Sync**
  - **AzCopy**: Command-line tool for copying data to and from Azure Storage.
  - **Azure Storage Explorer**: GUI tool for managing Azure Storage resources.
  - **Azure File Sync**: Synchronizes on-premises files with Azure Files.

- **2.3.6 Describe Migration Options, Including Azure Migrate and Azure Data Box**
  - **Azure Migrate**: Provides tools and resources for assessing and migrating on-premises workloads to Azure.
  - **Azure Data Box**: Hardware device for transferring large amounts of data to Azure when network transfer is impractical.

#### **2.4 Describe Azure Identity, Access, and Security**

- **2.4.1 Describe Directory Services in Azure, Including Microsoft Entra ID and Microsoft Entra Domain Services**
  - **Microsoft Entra ID**: Azure Active Directory (AAD) for identity and access management.
  - **Microsoft Entra Domain Services**: Managed domain services such as domain join and group policies.

- **2.4.2 Describe Authentication Methods in Azure, Including Single Sign-On (SSO), Multi-Factor Authentication (MFA), and Passwordless**
  - **Single Sign-On (SSO)**: Users log in once to access multiple applications.
  - **Multi-Factor Authentication (MFA)**: Adds an additional verification step for enhanced security.
  - **Passwordless**: Methods like biometrics or security keys that do not require passwords.

- **2.4.3 Describe External Identities in Azure, Including Business-to-Business (B2B) and Business-to-Customer (B2C)**
  - **Business-to-Business (B2B)**: Allows external business partners to access internal resources.
  - **Business-to-Customer (B2C)**: Manages and authenticates customer identities.

- **2.4.4 Describe Microsoft Entra Conditional Access**
  - **Definition**: Policies that control access to resources based on conditions such as user location, device state, and risk level.

- **2.4.5 Describe Azure Role-Based Access Control (RBAC)**
  - **Definition**: Controls access to Azure resources by assigning roles to users or groups, defining what actions they can perform.

- **2.4.6 Describe the Concept of Zero Trust**
  - **Definition**: Security model that requires continuous verification of every user, device, and application, regardless of their location, assuming no implicit trust.

- **2.4.7 Describe the Purpose of the Defense-in-Depth Model**
  - **Definition**: Uses multiple layers of security controls to protect resources, ensuring that if one layer fails, others are still in place to mitigate threats.

- **2.4.8 Describe the Purpose of Microsoft Defender for Cloud**
  - **Definition**: A comprehensive security management system that offers threat protection, security posture management, and compliance monitoring for Azure and hybrid environments.

### **3. Describe Azure Management and Governance (30–35%)**

#### **3.1 Describe Cost Management in Azure**

- **3.1.1 Describe Factors That Can Affect Costs in Azure**
  - **Factors**: Resource type, instance size, storage options, data transfer, and usage patterns.

- **3.1.2 Compare the Pricing Calculator and the Total Cost of Ownership (TCO) Calculator**
  - **Pricing Calculator**: Estimates costs based on selected services and configurations.
  - **TCO Calculator**: Compares costs between running workloads on-premises versus in Azure, factoring in potential savings.

- **3.1.3 Describe Cost Management Capabilities in Azure**
  - **Capabilities**: Budget creation, cost analysis, and cost-saving recommendations through tools like Cost Management + Billing.

- **3.1.4 Describe the Purpose of Tags**
  - **Definition**: Metadata labels used to categorize and manage Azure resources for purposes such as cost tracking, organization, and access control.

#### **3.2 Describe Features and Tools in Azure for Governance and Compliance**

- **3.2.1 Describe the Purpose of Microsoft Purview in Azure**
  - **Definition**: Provides a unified data governance solution that includes data cataloging, classification, and data lineage to ensure compliance and data management.

- **3.2.2 Describe the Purpose of Azure Policy**
  - **Definition**: Enforces organizational standards by applying rules to resources, ensuring compliance with policies for resource configuration and management.

- **3.2.3 Describe the Purpose of Resource Locks**
  - **Definition**: Prevents accidental deletion or modification of critical resources by applying read-only or delete prevention locks.

#### **3.3 Describe Features and Tools for Managing and Deploying Azure Resources**

- **3.3.1 Describe the Azure Portal**
  - **Definition**: A web-based interface for managing and configuring Azure resources. It provides dashboards, resource management, and service configuration tools.

- **3.3.2 Describe Azure Cloud Shell, Including Azure Command-Line Interface (CLI) and Azure PowerShell**
  - **Azure CLI**: Command-line tool for managing Azure resources using simple commands.
  - **Azure PowerShell**: PowerShell module for automating Azure resource management tasks.
  - **Cloud Shell**: Integrated browser-based shell environment with built-in Azure CLI and PowerShell tools, providing a pre-configured command-line interface.

- **3.3.3 Describe the Purpose of Azure Arc**
  - **Definition**: Extends Azure management and governance capabilities to on-premises, multi-cloud, and edge environments, enabling consistent management across diverse infrastructures.

- **3.3.4 Describe Infrastructure as Code (IaC)**
  - **Definition**: Managing and provisioning infrastructure through code and automation tools, enabling repeatable and consistent deployment of resources.

- **3.3.5 Describe Azure Resource Manager (ARM) and ARM Templates**
  - **ARM**: Manages deployment, configuration, and management of Azure resources using a unified interface.
  - **ARM Templates**: JSON-based files used to define and deploy Azure resources in a declarative manner, allowing automated resource provisioning.

#### **3.4 Describe Monitoring Tools in Azure**

- **3.4.1 Describe the Purpose of Azure Advisor**
  - **Definition**: Provides personalized recommendations for optimizing Azure resources in terms of performance, security, reliability, and cost, helping users to improve their Azure environment.

- **3.4.2 Describe Azure Service Health**
  - **Definition**: Provides information about the health of Azure services and resources, including global and personalized service health status, planned maintenance, and service issues affecting your resources.

- **3.4.3 Describe Azure Monitor, Including Log Analytics, Azure Monitor Alerts, and Application Insights**
  - **Azure Monitor**: Collects, analyzes, and visualizes monitoring data from various sources to provide insights into application and infrastructure performance.
  - **Log Analytics**: Tool for querying and analyzing log data from Azure Monitor, supporting complex queries and visualizations.
  - **Azure Monitor Alerts**: Notifies users when specific thresholds or conditions are met, based on monitoring data. Can trigger automated actions or notifications.
  - **Application Insights**: Provides performance monitoring and usage analytics for applications, including real-time data on request rates, response times, and failure rates.
