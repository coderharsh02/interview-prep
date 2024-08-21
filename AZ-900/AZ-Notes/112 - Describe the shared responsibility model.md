Describe the shared responsibility model

1. **Definition**: 
   - The shared responsibility model outlines the division of responsibilities between the cloud provider and the consumer for managing and securing cloud-based resources.

2. **Traditional Datacenter**:
   - **Consumer’s Responsibility**: 
     - Physical space maintenance.
     - Security.
     - Server maintenance and replacement.
     - Infrastructure and software management.
     - System patching and updates.

3. **Cloud Provider’s Responsibility**:
   - **Infrastructure Management**: 
     - Physical datacenter.
     - Physical network and hosts.
     - Power, cooling, and network connectivity.

4. **Consumer’s Responsibility**:
   - **Data Security**: 
     - Protecting the data and information stored in the cloud.
     - Managing access control and permissions.
   - **Application Security**: 
     - For data and applications deployed on cloud infrastructure.

5. **Shared Responsibility Based on Service Type**:
   - **Infrastructure as a Service (IaaS)**:
     - **Provider’s Responsibility**: Basic infrastructure elements like physical security, power, and connectivity.
     - **Consumer’s Responsibility**: Operating systems, applications, and data management.
   - **Platform as a Service (PaaS)**:
     - **Provider’s Responsibility**: Platform infrastructure, including operating systems and middleware.
     - **Consumer’s Responsibility**: Applications and data.
   - **Software as a Service (SaaS)**:
     - **Provider’s Responsibility**: Application and underlying infrastructure, including the software.
     - **Consumer’s Responsibility**: User access and data.

6. **Examples**:
   - **Cloud SQL Database**:
     - **Provider’s Responsibility**: Maintenance of the database itself.
     - **Consumer’s Responsibility**: Data ingested into the database.
   - **Virtual Machine with SQL Database**:
     - **Provider’s Responsibility**: Physical server.
     - **Consumer’s Responsibility**: Database maintenance, patches, and data management.

7. **Overall Responsibility**:
   - **Consumer**:
     - Information and data stored in the cloud.
     - Devices and accounts connected to the cloud.
   - **Provider**:
     - Physical security of the data center and infrastructure.
   - **Service Model Impacts**:
     - Determines the extent of responsibilities for operating systems, network controls, applications, and identity management.

8. **Shared Responsibility Model Diagram**:

    The following diagram highlights how the Shared Responsibility Model informs who is responsible for what, depending on the cloud service type.

    ![alt text](https://learn.microsoft.com/en-in/training/wwl-azure/describe-cloud-compute/media/shared-responsibility-b3829bfe.svg)