
---

## ✅ **Lecture 23: Routing in ASP.NET Core**

---

### 🧠 **What is Routing?**

Routing is the process of **mapping incoming HTTP requests** (based on URL and HTTP method) to the **appropriate middleware function or action** in the application.

---

### 🔍 **Key Concepts**

* A **route** = URL **+** HTTP **method** (`GET`, `POST`, `PUT`, `DELETE`, etc.)
* The route determines **which function/middleware** should run for a request.

**Example:**

```
GET  /home          → returns index.html
POST /products      → creates a product
GET  /products      → returns all products
GET  /products/1    → returns a single product
PUT  /products/1    → updates the product
DELETE /products/1  → deletes the product
```

> 🚨 Same URL + Different HTTP methods = Different behaviors

---

### 🏗️ **How Routing Works in ASP.NET Core**

ASP.NET Core handles routing through **middleware**. To enable and use routing, we add two key built-in middleware components:

---

### ⚙️ **1. `UseRouting()` Middleware**

* Enables routing for the app.
* Parses the **URL path** and selects the matching **endpoint**.

```csharp
app.UseRouting();
```

---

### ⚙️ **2. `UseEndpoints()` Middleware**

* Defines the **routes** and binds them to actions or middleware functions.
* Called *after* `UseRouting()`.

```csharp
app.UseEndpoints(endpoints =>
{
    // Routes are defined here
});
```

---

### 🔁 **Routing Flow in Middleware Pipeline**

1. **Request** comes in with a URL and method.
2. `UseRouting()` identifies possible matches.
3. `UseEndpoints()` runs the **matched route’s logic** (middleware or controller).

---

### 🧠 **Takeaway**

> Routing allows mapping requests (method + path) to logic cleanly.
> Use `app.UseRouting()` to enable routing, and `app.UseEndpoints()` to define the route handling logic.

---

### 📌 **Next Lecture**

In the next lecture, you’ll **define routes** inside `UseEndpoints()` using `MapGet`, `MapPost`, etc.

---
