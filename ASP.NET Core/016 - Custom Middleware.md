
---

## ✅ **Lecture 16: Creating Custom Middleware**:

### 1. **Project Setup**

* Created a new **ASP.NET Core Empty Project** (C#).
* Named it `middleware`.
* Chose **.NET 7.0**, no HTTPS.

---

### 2. **Understanding `Program.cs` Structure**

* `WebApplicationBuilder builder = WebApplication.CreateBuilder(args);`

  * Initializes the builder (for configuration, DI, etc.)
* `WebApplication app = builder.Build();`

  * Creates the ASP.NET Core app.
* `app.Run();`

  * Starts the server.

---

### 3. **Adding First Middleware using `Run()`**

```csharp
app.Run(async context =>
{
    await context.Response.WriteAsync("Welcome from ASP.NET Core app");
});
```

* This middleware is executed for **every request**, regardless of the URL path.
* Because it **doesn’t call `next()`**, this becomes a **terminal (short-circuiting) middleware**.

---

### 4. **Adding a Second Middleware**

```csharp
app.Run(async context =>
{
    await context.Response.WriteAsync("This is my first ASP.NET Core app");
});
```

* Only the **first `Run()` middleware** executes.
* Second one is **ignored**. Why?

---

### 5. ❗ **Why Only One Middleware Executes with `Run()`**

* Because `Run()` **does not support chaining**.
* It does **not accept a `next` parameter**, so you can't pass control to the next middleware.
* Hence, middlewares registered using `Run()` are always **terminal**.

---

## 📌 **Key Takeaways**:

| Concept                                       | Explanation                                                             |
| --------------------------------------------- | ----------------------------------------------------------------------- |
| **Middleware**                                | Function executed per request to handle request/response                |
| **Terminal Middleware**                       | Middleware that ends the pipeline and does not call the next one        |
| **Run() method**                              | Used to register terminal middleware. Doesn’t support `next()` chaining |
| **Only the first `Run()` executes**           | Because it does not pass control to the next middleware                 |
| **Use `await context.Response.WriteAsync()`** | To write content to the HTTP response                                   |

---

## 🔜 What's Next?

In **Lecture 17**, you'll learn how to chain multiple middlewares using the `Use()` method, which **supports the `next` delegate** and allows multiple middlewares to execute in sequence.

Would you like a diagram showing the difference between `Run()` and `Use()` middlewares?
