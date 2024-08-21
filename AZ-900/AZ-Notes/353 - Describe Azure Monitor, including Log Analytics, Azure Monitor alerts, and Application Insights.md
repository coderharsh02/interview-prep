Describe Azure Monitor, including Log Analytics, Azure Monitor alerts, and Application Insights

### **Purpose of Azure Monitor**

1. **Overview**
   - **Function**: Collects, analyzes, and visualizes data from Azure resources, on-premises resources, and multi-cloud environments.

2. **Data Collection**
   - **Sources**: Collects logging and metric data from various application layers (e.g., application, OS, network).
   - **Storage**: Data is stored in central repositories.

3. **Data Usage**
   - **Visualization**: Provides real-time and historical performance views; supports custom views via Power BI and Kusto queries.
   - **Alerts**: Triggers alerts for critical events via SMS, email, etc., and supports autoscaling based on thresholds.

4. **Azure Log Analytics**
   - **Function**: Tool for writing and running log queries on data gathered by Azure Monitor.
   - **Capabilities**: Supports simple and complex queries, data analysis, and visualization of trends.

5. **Azure Monitor Alerts**
   - **Function**: Automated notifications for threshold breaches.
   - **Configuration**: Set alert conditions and actions; supports log and metric-based alerts.
   - **Action Groups**: Configures notifications and actions for alerts.

6. **Application Insights**
   - **Function**: Monitors web applications across Azure, on-premises, or other cloud environments.
   - **Setup**: Can be configured using an SDK or Application Insights agent.
   - **Monitoring**: Tracks request rates, response times, failure rates, dependency performance, page views, AJAX calls, user counts, and performance counters.
   - **Synthetic Requests**: Configurable to periodically send requests to monitor application status during low activity.