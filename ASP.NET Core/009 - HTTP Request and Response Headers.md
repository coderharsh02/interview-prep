
---

## ✅ **Lecture 9 Summary – HTTP Request and Response Headers**

### 🔹 **HTTP Request Headers**

* **Definition**: Key-value pairs sent by the client (like browsers, Postman, Android/iOS apps) to the server.
* **Purpose**: Provide meta-information about the request.
* **Examples**:

  * `Accept`: What type of response the client can accept (`text/html`, `application/json`, etc.).
  * `Accept-Language`: Preferred language for the response (`en-US`).
  * `Content-Type`: Type of the request body being sent (`application/json`, `text/plain`, etc.).
  * `Content-Length`: Size of the request body in bytes.
  * `User-Agent`: Info about the client (browser, version, OS).

#### 🛠 How to Access Request Headers in ASP.NET Core:

```csharp
if (context.Request.Headers.ContainsKey("User-Agent"))
{
    var userAgent = context.Request.Headers["User-Agent"];
    await context.Response.WriteAsync($"User-Agent: {userAgent}");
}
```

* **Note**: `Headers` is a dictionary on `HttpRequest`, accessible via `HttpContext.Request.Headers`.

---

### 🔹 **HTTP Response Headers**

* **Definition**: Key-value pairs sent by the server to the client along with the response.
* **Purpose**: Provide meta-information about the response.
* **Not Visible to Users**: Meant for communication between server and client.

#### 🔸 **Common Response Headers**:

| Header           | Purpose                                                                        |
| ---------------- | ------------------------------------------------------------------------------ |
| `Server`         | Specifies which server software is used (e.g., Kestrel).                       |
| `Cache-Control`  | How long the response can be cached (`no-cache`, `max-age=60`).                |
| `Content-Type`   | Tells the client the format of the response (`text/html`, `application/json`). |
| `Content-Length` | Size of the response body in bytes.                                            |
| `Date`           | Timestamp when the response was generated.                                     |
| `Set-Cookie`     | Sends cookies to the browser.                                                  |
| `Location`       | Used for redirection (when applicable).                                        |

---

### 🛠 How to Set Response Headers in ASP.NET Core:

```csharp
context.Response.Headers["Content-Type"] = "text/html";
await context.Response.WriteAsync("<h2>This is a text response</h2>");
```

#### ➕ Custom Headers:

```csharp
context.Response.Headers["my-header"] = "hello world";
```

* Custom headers can be added just like standard ones.

---

### 🧪 Live Example (in browser DevTools):

* **Request**: Open DevTools → Network tab → Reload page → Select request → View **Request Headers**.
* **Response**: Same tab → View **Response Headers**.

---

## 🧠 Key Concepts Recap:

* Clients (Browser, Postman, Mobile Apps) **send request headers**.
* Servers (ASP.NET Core backend) **read request headers** and **set response headers**.
* Both headers are **dictionaries** of string key-value pairs.
* Use headers for content negotiation, language preferences, cache control, redirection, and more.

---
