
---

## ✅ **Lecture 17: Chaining Multiple Middlewares in ASP.NET Core**

### 🔹 What You Learned:

* How to **chain multiple middleware components** using the `Use` method.
* Difference between `Run` and `Use` when building the middleware pipeline.
* How middleware is executed in the **order of registration**.
* Role of the `next()` delegate in passing control to the next middleware.

---

### 🧱 Middleware Basics Recap:

* A **middleware** is a function that can:

  * Access the incoming **HTTP context**
  * Perform operations
  * Optionally call the next middleware

---

### 🆚 `Run` vs `Use`:

| Aspect    | `Run`                                        | `Use`                                                               |
| --------- | -------------------------------------------- | ------------------------------------------------------------------- |
| Type      | Terminal middleware (short-circuits)         | Non-terminal middleware (can pass control)                          |
| Arguments | Accepts a **single** argument: `HttpContext` | Accepts **two** arguments: `HttpContext` and `RequestDelegate next` |
| Usage     | Cannot chain further                         | Can call `await next(context)` to chain to the next middleware      |

---

### 🔄 Chaining Middleware Using `Use`:

Example:

```csharp
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1 Start\n");
    await next(context); // Moves to Middleware 2
    await context.Response.WriteAsync("Middleware 1 End\n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2 Start\n");
    await next(context); // Moves to Middleware 3
    await context.Response.WriteAsync("Middleware 2 End\n");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Middleware 3 (Terminal)\n");
});
```

**Execution Order:**

```
Middleware 1 Start
Middleware 2 Start
Middleware 3 (Terminal)
Middleware 2 End
Middleware 1 End
```

* The flow goes **top-down**, and control is returned **bottom-up** after `next()` is awaited.

---

### 🛑 What Happens If You Don't Call `next()`?

* That middleware becomes **terminal** (like `Run`).
* No further middleware will be executed.
* Can be useful when you want to **short-circuit** the request, e.g., for authentication failure.

---

### 🧠 Additional Concepts Covered:

* `Run` and `Use` are **extension methods** on `IApplicationBuilder`.
* You can write logic **after `await next()`** to do post-processing.
* **`Run`** methods are suitable for **final responses**.

---

### 🔧 Technical Notes:

* If you skip specifying types in lambda parameters, you **must** call `next()`, or you’ll get a **compile-time error**.
* `app` is of type `WebApplication`, which implements `IApplicationBuilder`, so you can call `Use`/`Run` on it.

---

### ✅ Conclusion:

To chain multiple middleware components in ASP.NET Core:

* Use `app.Use()` with two arguments.
* Always call `await next(context)` to move to the next middleware.
* Use `app.Run()` only when defining the **last terminal middleware**.

---

