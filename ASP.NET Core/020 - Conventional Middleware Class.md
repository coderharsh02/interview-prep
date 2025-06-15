
---

### ✅ **What You Already Learned Earlier**

* You created a custom middleware class by implementing the `IMiddleware` interface.
* You had to implement `InvokeAsync(HttpContext context, RequestDelegate next)` method.
* You registered and used it via an extension method (`UseMyMiddleware()`).

---

### 📌 **New Concept: Conventional Middleware Class (Using Middleware Template)**

#### 📁 Creating the Middleware

* Instead of a blank class, use the **“Middleware Class” template** in Visual Studio.
* The generated class looks like this:

```csharp
public class AnotherCustomMiddleware
{
    private readonly RequestDelegate _next;

    public AnotherCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        // Do something before next middleware
        await context.Response.WriteAsync("Another custom middleware called\n");

        await _next(context); // Call the next middleware

        // Do something after next middleware
        await context.Response.WriteAsync("Another custom middleware finished\n");
    }
}
```

---

### 🔄 **Difference Between This and `IMiddleware` Approach**

| Aspect            | `IMiddleware` Implementation                | Conventional Middleware (Template) |
| ----------------- | ------------------------------------------- | ---------------------------------- |
| Interface         | Implements `IMiddleware`                    | Doesn't implement an interface     |
| Method Signature  | `InvokeAsync(HttpContext, RequestDelegate)` | `Invoke(HttpContext)` only         |
| `RequestDelegate` | Passed as method argument                   | Injected via constructor           |
| Lifetime          | Transient (recommended DI)                  | Scoped as per pipeline order       |

---

### 🧩 Extension Method to Use Middleware

```csharp
public static class AnotherCustomMiddlewareExtension
{
    public static IApplicationBuilder UseAnotherCustomMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<AnotherCustomMiddleware>();
    }
}
```

In `Program.cs`:

```csharp
app.UseAnotherCustomMiddleware();
```

---

### 🧪 What Happens at Runtime? (Middleware Execution Flow)

1. **Middleware 1**

   * Writes "Middleware 1 called"
   * Calls `next()` → goes to Middleware 2

2. **Middleware 2**

   * Adds line breaks (or any custom logic)
   * Calls `next()` → goes to Middleware 3

3. **Middleware 3 (Your `AnotherCustomMiddleware`)**

   * Writes "Another custom middleware called"
   * Calls `next()` → goes to Terminal Middleware

4. **Terminal Middleware**

   * Writes final response (e.g., "Run middleware called")

5. **Backtrack**

   * Middleware 3 finishes → adds "Another custom middleware finished"
   * Middleware 2 resumes → finishes
   * Middleware 1 resumes → finishes

---

### 🔚 Output Example (in Response Body)

```
Middleware 1 called
\n\n
Another custom middleware called
Run middleware called
Another custom middleware finished
```

---

### ✅ Key Takeaways

* Middleware can be created using either:

  * `IMiddleware` (more testable, DI-based)
  * Template-based conventional approach (constructor-injected)
* Middleware runs in order of registration.
* The `RequestDelegate` is used to pass control to the **next middleware**.
* The response can be modified **before and after** calling the next middleware.

---

