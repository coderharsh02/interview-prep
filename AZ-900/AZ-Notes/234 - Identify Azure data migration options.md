### **Azure Data Migration Options Summary**

1. **Azure Migrate**
   - **Purpose**: Facilitates migration from on-premises environments to Azure.
   - **Features**:
     - **Unified Platform**: Centralized portal for managing and tracking migrations.
     - **Tools**:
       - **Azure Migrate: Discovery and Assessment**: Discover and assess on-premises servers (VMware, Hyper-V, physical) for migration.
       - **Azure Migrate: Server Migration**: Migrate various server types (VMware VMs, Hyper-V VMs, physical servers, public cloud VMs) to Azure.
       - **Data Migration Assistant**: Assess SQL Servers, identify migration issues, and optimize databases.
       - **Azure Database Migration Service**: Migrate on-premises databases to Azure SQL services.
       - **Azure App Service Migration Assistant**: Assess and migrate .NET and PHP web apps to Azure App Service.

2. **Azure Data Box**
   - **Purpose**: Physical migration service for transferring large amounts of data to and from Azure.
   - **Features**:
     - **Device**: Secure, rugged storage device with up to 80 TB capacity.
     - **Process**:
       - **Order Device**: Request via Azure portal.
       - **Setup and Transfer**: Connect to network, transfer data using local web UI.
       - **Return Device**: Send back for automatic data upload; tracked end-to-end in Azure portal.
   - **Use Cases**:
     - **Import Data**:
       - **One-time Migration**: Large data transfers from on-premises to Azure.
       - **Media Library**: Moving offline tapes to Azure.
       - **VM/SQL Migration**: Transfer VM farms, SQL servers, applications to Azure.
       - **Historical Data**: Move data for analysis with HDInsight.
     - **Export Data**:
       - **Disaster Recovery**: Restore Azure data to on-premises in emergencies.
       - **Security Requirements**: Export data due to compliance needs.
       - **Migration**: Transfer data to another cloud provider or back to on-premises.

   - **Data Security**:
     - **Import**: Disks wiped clean per NIST 800-88r1 standards after upload.
     - **Export**: Disks erased upon arrival at Azure datacenter.