
---

# **[Lecture 7 Notes: How the Web Works (Client-Server Architecture, HTTP, TCP/IP)](https://youtu.be/KSPlGDxOilM?si=QQrsZPKsF1z5M37-)**

## ✅ **Why Learn This First?**

* ASP.NET Core is used for building **web applications**.
* To understand ASP.NET Core deeply, you need to understand how **the web works**, especially how **clients and servers interact using HTTP**.
* Core concepts: **HTTP Request/Response**, **Headers**, **Status Codes**, **TCP/IP**, **DNS**, etc.

---

## 🌐 **Client-Server Architecture**

* Web architecture follows a **Request-Response Model**.
* **Client**: Sends requests. E.g., browser, mobile app, desktop app.
* **Server**: Receives requests, processes them, and sends responses. Needs web server software like **IIS** or **Apache**.
* Example:

  * ASP.NET Core app hosted on server with IP: `192.168.20.134`.
  * Domain name used: `www.demoapp.com`.
  * Accessing `/home` triggers a request for homepage HTML.

---

## 🌍 **What Happens When You Type a URL**

1. **DNS Resolution**:

   * Domain names (e.g., `demoapp.com`) are **human-friendly aliases** for IP addresses.
   * **DNS (Domain Name Server)** maps domain name → server IP address (e.g., `192.168.20.134`).
   * Also determines **port number** (e.g., `:8000`) if not default.

2. **TCP/IP Connection Establishment**:

   * A **TCP/IP socket connection** is opened between client and server.
   * TCP/IP are protocols used for **data transfer**:

     * **TCP**: Breaks request/response into small **packets**, reassembles at destination.
     * **IP**: Routes packets using IP addresses.
   * Connection is **short-lived**: created per request and closed after response is received.

3. **Sending HTTP Request**:

   * **HTTP (HyperText Transfer Protocol)** is the protocol for communication.
   * Can also be **HTTPS** (secure, encrypted with **TLS/SSL**).
   * Request Structure:

     * **Start Line**:

       * HTTP **method**: `GET`, `POST`, `PUT`, `PATCH`, `DELETE`.
       * **Target resource** (e.g., `/home`).
       * HTTP version (`HTTP/1.1`, etc.).
     * **Request Headers**: Metadata (e.g., browser type, language, timestamp).
     * **Request Body**: Optional, contains data (e.g., in POST/PUT).

---

## 📥 **HTTP Methods Overview**

| Method | Purpose                             | Request Body |
| ------ | ----------------------------------- | ------------ |
| GET    | Retrieve data from server           | ❌ No         |
| POST   | Send data to create a resource      | ✅ Yes        |
| PUT    | Replace an existing resource        | ✅ Yes        |
| PATCH  | Update part of an existing resource | ✅ Yes        |
| DELETE | Delete a resource                   | ❌/✅ Depends  |

---

## 📤 **HTTP Response**

* Sent **by server** after processing request.
* Structure:

  * **Start Line**:

    * HTTP Version
    * **Status Code** (e.g., `200`, `404`, `500`)
    * **Status Message** (e.g., `OK`, `Not Found`)
  * **Response Headers**: Metadata (e.g., content type, caching, custom headers).
  * **Response Body**: Actual data (HTML, JSON, etc.).

### 🔢 **Common HTTP Status Codes**

| Code | Meaning                      |
| ---- | ---------------------------- |
| 200  | OK (Success)                 |
| 404  | Not Found (Resource missing) |
| 500  | Internal Server Error        |

---

## 📂 **Multiple Requests for One Page**

* A single page (like `/home`) can require **multiple resources**:

  * CSS, JS, Images, Fonts, etc.
* The initial HTML references these assets → browser makes **additional HTTP requests** to fetch them.
* Each file (CSS, JS, etc.) has its **own request/response cycle**.

---

## 📦 **TCP/IP – Behind the Scenes**

* **TCP**:

  * Breaks request/response into small **packets**.
  * Ensures packets are **reordered and complete** at destination.
* **IP**:

  * Sends packets through network.
  * Routes them using **IP addresses** to the correct server.

---

## 🔐 **HTTP vs HTTPS**

* HTTPS = HTTP + Encryption via **SSL/TLS**.
* Prevents data tampering, eavesdropping.
* The structure of requests and responses remains the **same**, only **secured**.

---

## ✅ Summary

* Web communication relies on:

  * **DNS** for resolving domain to IP.
  * **TCP/IP** for transporting packets.
  * **HTTP** for structuring requests and responses.
* As a backend developer:

  * You **don’t control the request format** (set by client).
  * But you **do control the response** (headers, status, body).
* Understanding HTTP deeply is essential for efficient backend development in ASP.NET Core.

---