We use middleware like UseAuthentication() and UseAuthorization() to integrate identity and access control into the pipeline. But they don’t enforce protection by themselves. We need to use the [Authorize] filter on controllers or actions to actually enforce access restrictions. Without it, the middleware runs but doesn't block any request.


Here’s a **comprehensive interview guide on ASP.NET Core Filters**, covering everything you need — key concepts, real-world usage, differences from middleware, types of filters, and common interview questions with sample answers.

---

## ✅ **What Are Filters in ASP.NET Core?**

* **Filters** are components that allow code to run **before or after** specific stages in the request processing pipeline.
* They are used **within the MVC framework**, not in general middleware.
* Filters are mainly for **cross-cutting concerns** like:

  * Authorization
  * Logging
  * Exception handling
  * Caching
  * Validation

---

## ✅ **Why Use Filters When We Have Middleware?**

| Aspect    | Middleware                       | Filters                                   |
| --------- | -------------------------------- | ----------------------------------------- |
| Scope     | Global (applies to all requests) | Per-controller or per-action              |
| Execution | Before routing                   | After routing                             |
| Use Cases | Auth pipeline, logging, CORS     | Access control, model validation, caching |
| Access    | No route info                    | Full access to action, route, and model   |

💡 **Both go hand-in-hand** — e.g., `UseAuthorization` middleware + `[Authorize]` filter

---

## ✅ **Types of Filters in ASP.NET Core**

| Filter Type       | Interface / Attribute  | Purpose / When it Runs                       |
| ----------------- | ---------------------- | -------------------------------------------- |
| **Authorization** | `IAuthorizationFilter` | Before everything. Handles security.         |
| **Resource**      | `IResourceFilter`      | Runs before model binding, can short-circuit |
| **Action**        | `IActionFilter`        | Around action execution                      |
| **Exception**     | `IExceptionFilter`     | On unhandled exceptions                      |
| **Result**        | `IResultFilter`        | Around result generation (views, JSON)       |

---

## ✅ **Commonly Used Built-in Filters**

| Attribute                    | Type          | Purpose                       |
| ---------------------------- | ------------- | ----------------------------- |
| `[Authorize]`                | Authorization | Restricts access              |
| `[AllowAnonymous]`           | Authorization | Skips authorization           |
| `[ValidateAntiForgeryToken]` | Action        | Prevent CSRF                  |
| `[ExceptionFilter]`          | Exception     | Custom error handling         |
| `[ActionFilter]`             | Action        | Logs, modifies inputs, timing |

---

## ✅ **How to Register Filters**

### 1. **Globally** in `Startup.cs` or `Program.cs`:

```csharp
services.AddControllersWithViews(options =>
{
    options.Filters.Add(typeof(MyCustomFilter));
});
```

### 2. **At Controller or Action Level**

```csharp
[ServiceFilter(typeof(MyCustomFilter))]
public class HomeController : Controller
{
    public IActionResult Index() => View();
}
```

---

## ✅ **Custom Filter Example (Action Filter)**

```csharp
public class LogActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Before Action");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After Action");
    }
}
```

Register via DI and apply with `[ServiceFilter(typeof(LogActionFilter))]`

---

## 🔍 **Important Interview Questions on Filters**

### 1. ❓ *What are filters in ASP.NET Core?*

* Answer: Filters are components used to inject logic at different stages of the MVC request pipeline. They run after routing and before/after controller actions.

---

### 2. ❓ *What is the difference between middleware and filters?*

* Middleware: Runs **before routing**, global scope.
* Filters: Run **after routing**, can be controller- or action-specific.
* Middleware is used for **cross-cutting concerns** globally, while filters offer more **granular control**.

---

### 3. ❓ *What are the different types of filters in ASP.NET Core?*

* Authorization Filter
* Resource Filter
* Action Filter
* Result Filter
* Exception Filter

---

### 4. ❓ *Which filter runs first: Authorization or Action?*

* **Authorization** → **Resource** → **Action** → **Result**
  Exception filters run only on unhandled exceptions.

---

### 5. ❓ *What is the difference between `IActionFilter` and `ActionFilterAttribute`?*

* `IActionFilter`: Interface to implement a custom filter manually.
* `ActionFilterAttribute`: Base class that implements `IActionFilter`, easier to use with attributes.

---

### 6. ❓ *What is the use of `IResourceFilter`?*

* Runs **before model binding**.
* Good for **caching** or **early short-circuiting** requests.

---

### 7. ❓ *How do you apply a filter globally?*

* Use `options.Filters.Add(new MyFilter())` inside `AddControllersWithViews()`.

---

### 8. ❓ *Can filters access route data or models?*

* Yes — especially `ActionFilter`, `ResourceFilter`, and `ResultFilter`.

---

### 9. ❓ *How is an exception handled using filters?*

* Implement `IExceptionFilter` or derive from `ExceptionFilterAttribute` to handle errors globally or per action.

---

### 10. ❓ *What is the use of `[ServiceFilter]` vs `[TypeFilter]`?*

* Both allow DI injection in filters.
* `ServiceFilter` fetches from **registered DI services**.
* `TypeFilter` creates a **new instance** with optional constructor arguments.

---

## 📌 Quick Tip for Interview:

> ❝Use Middleware for global policies like authentication. Use Filters when you want fine-grained logic inside the MVC pipeline, like logging, validation, or conditional authorization.❞

---

Would you like me to create a PDF summary of this for quick revision?
