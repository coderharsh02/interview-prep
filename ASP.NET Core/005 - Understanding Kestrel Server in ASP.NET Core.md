
---

## **[Lecture 5: Understanding Kestrel Server in ASP.NET Core](https://youtu.be/yTBEO9dTUI4?si=7wd-nKygJd1N0dDY)**

### 🔧 **Why ASP.NET Core Needs a Web Server**

* Every **ASP.NET Core** application **requires a web server** to:

  * **Receive HTTP requests**
  * **Send HTTP responses**
* In traditional ASP.NET Web Forms / MVC, **IIS** (Internet Information Services) was the default server.

---

### 🚀 **Introduction to Kestrel**

* **Kestrel** is the **default web server** for ASP.NET Core.
* It is:

  * **Cross-platform** (works on Windows, macOS, and Linux)
  * **Lightweight**
  * **High-performance**
* **Reason for its introduction**:

  * IIS only works on **Windows**
  * ASP.NET Core is **cross-platform**
  * So a **new server was needed** that works on **all operating systems**

---

### 🔍 **How Kestrel Works**

* **Receives requests** from the network
* **Creates an `HttpContext` object**
* Forwards the `HttpContext` to the ASP.NET Core **middleware pipeline**
* After processing, it:

  * **Constructs the HTTP response**
  * **Sends it back to the client**

---

### ⚙️ **Modes of Using Kestrel**

1. **Application Server (Edge Server)**

   * Receives and processes requests **directly**
   * Suitable for **development** purpose because traffic is low

2. **With a Reverse Proxy Server (Production)**

   * Reverse proxy servers (e.g., **IIS**, **NGINX**, **Apache**) receive the request first
   * They forward the request to **Kestrel** for processing
   * **Why needed?** Kestrel lacks features like:

     * Load balancing
     * URL rewriting
     * Port sharing
     * Response caching
     * Direct file serving

---

### 🔄 **Reverse Proxy Setup in Production**

* A **reverse proxy** provides extra functionality
* **Common combinations**:

  * **Kestrel + IIS** (for Windows)
  * **Kestrel + NGINX / Apache** (for Linux/macOS)
* Even in production, **Kestrel handles the actual request processing**

---

![sfsaf](https://github.com/user-attachments/assets/18cc1a2e-556a-49b7-82c4-454d2165346f)

### 🧪 **What Happens When You Run the Application**

* Running an ASP.NET Core app:

  * Starts a **console application**
  * Launches the **Kestrel server**
  * Hosts the web app on the specified **localhost and port**
* Example output:

  ```
  Now listening on: http://localhost:5136
  ```
* This shows Kestrel is running and serving the application.

---

### 📁 **Next Steps (Covered in Next Lecture)**

* Explore `launchSettings.json`

  * This file defines how the application is launched
  * Specifies settings for **Kestrel** and optionally for **IIS Express**

---

### ✅ **Conclusion**

Kestrel is a modern, fast, cross-platform web server built for ASP.NET Core. While it’s great for development and lightweight production scenarios, it is typically used with a reverse proxy in production environments for advanced features.

---

