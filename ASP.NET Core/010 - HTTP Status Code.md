
---

## 🎓 **Lecture 10: HTTP Status Codes**

### ✅ **What is a Status Code?**

* It's a response from the **server** to the **client**.
* It tells the client what happened with the request: **Success, Failure, Redirection, or Error**.

---

## 📘 **Categories of HTTP Status Codes**

| Range   | Category      | Meaning                          |
| ------- | ------------- | -------------------------------- |
| 100–199 | Informational | Request received, continuing     |
| 200–299 | Success       | Request successful               |
| 300–399 | Redirection   | Further action needed            |
| 400–499 | Client Error  | Request has an error             |
| 500–599 | Server Error  | Server failed to fulfill request |

---

## 🔢 **Important Status Codes**

### 🔹 **1xx: Informational**

* `101 Switching Protocols`: Server agrees to switch the protocol (e.g., HTTP → HTTPS).

### 🔹 **2xx: Success**

* `200 OK`: Request successful.
* `201 Created`: New resource created (used in `POST`, `PUT`).

### 🔹 **3xx: Redirection**

* `302 Found`: Redirected to another URL.

  * E.g., `view-products` → `products/view`
* `304 Not Modified`: Used in caching.

  * Static files (JS/CSS/images) not modified → browser uses **cached version**.

### 🔹 **4xx: Client Errors**

* `400 Bad Request`: Invalid data/missing fields in the request.

  * E.g., missing `lastName` during user registration.
* `401 Unauthorized`: User must login to access the resource.
* `404 Not Found`: Resource or endpoint doesn't exist.

  * E.g., wrong URL or product ID not found.

### 🔹 **5xx: Server Errors**

* `500 Internal Server Error`: Server failed unexpectedly.

  * Could not handle the request.

---

## 🧑‍💻 **Demo in ASP.NET Core**

### 🔸 Using `Run()` vs `MapGet()`

* `MapGet("/path")`: Callback runs only for specific path.
* `Run()`: Callback runs for **every request**.

### 🔸 Code Logic (Example)

```csharp
app.Run(async context =>
{
    var path = context.Request.Path;

    if (path == "/" || path == "/home")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("You are in home page");
    }
    else if (path == "/contact")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("You are in contact page");
    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("The page you are looking for is not found");
    }
});
```

### 🔸 Output Examples:

* `/` or `/home` → 200 OK → “You are in home page”
* `/contact` → 200 OK → “You are in contact page”
* `/about` → 404 Not Found → “The page you are looking for is not found”

> 🔍 Use **Browser Dev Tools → Network tab** to inspect the status codes and responses.

---

## 📝 Final Notes:

* You don’t need to **memorize** all status codes — you'll learn through **usage and experience**.
* You can explore more on: [https://developer.mozilla.org/en-US/docs/Web/HTTP/Status](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)

---

