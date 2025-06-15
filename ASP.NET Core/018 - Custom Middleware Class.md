
---

## ✅ **Lecture 18 – Custom Middleware Class in ASP.NET Core**

---

### 🎯 **Topic:** Creating Custom Middleware in ASP.NET Core

---

### ✅ **What You Learned:**

#### 1. **Middleware Using Lambda (RequestDelegate):**

```csharp
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1 Start\n");
    await next();
    await context.Response.WriteAsync("Middleware 1 End\n");
});
```

* **Best for:** Simple or inline logic (1–2 lines).
* **Not reusable or testable**.

---

#### 2. **Why Use a Custom Middleware Class?**

* When logic becomes **complex**, move to a separate **class**.
* **Benefits**:

  * Better **readability**, **maintainability**, and **reusability**
  * Can use **Dependency Injection** (e.g., logging, services, DB context)

---

## 🏗️ **Creating Custom Middleware Class**

---

### 🔹 Option 1: Using `IMiddleware` (Recommended for DI)

#### 📄 `MyMiddleware.cs`

```csharp
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public class MyMiddleware : IMiddleware
{
    private readonly ILogger<MyMiddleware> _logger;

    public MyMiddleware(ILogger<MyMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        _logger.LogInformation("MyMiddleware Start");
        await context.Response.WriteAsync("MyMiddleware Start\n");

        await next(context); // Pass to next

        _logger.LogInformation("MyMiddleware End");
        await context.Response.WriteAsync("MyMiddleware End\n");
    }
}
```

#### 🔧 Register in `Program.cs`

```csharp
builder.Services.AddTransient<MyMiddleware>();
```

#### 🔁 Use in Pipeline

```csharp
app.UseMiddleware<MyMiddleware>();
```

---

### 🔹 Option 2: Using a Normal Class (No `IMiddleware`, Just `Invoke`)

#### 📄 `ClassicMiddleware.cs`

```csharp
public class ClassicMiddleware
{
    private readonly RequestDelegate _next;

    public ClassicMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("ClassicMiddleware Start\n");
        await _next(context);
        await context.Response.WriteAsync("ClassicMiddleware End\n");
    }
}
```

#### 🔁 Use in Pipeline

```csharp
app.UseMiddleware<ClassicMiddleware>();
```

> ✅ **Note:** This version doesn't support **constructor-based DI** (you must use `context.RequestServices.GetService<T>()` if needed).

---

## 🔍 **DI Middleware vs Classic Middleware Comparison**

| Feature                      | `IMiddleware`                         | Classic Middleware (with `Invoke`) |
| ---------------------------- | ------------------------------------- | ---------------------------------- |
| Interface Required           | ✅ `IMiddleware`                       | ❌ No Interface                     |
| DI in Constructor            | ✅ Supported out-of-the-box            | ❌ Not directly supported           |
| Registration in DI Container | ✅ Required (`AddTransient`)           | ❌ Not required                     |
| Reusability                  | ✅ High                                | ✅ Medium                           |
| Use Case                     | Complex, testable, DI-heavy scenarios | Simple reusable logic without DI   |

---

## 🧠 Middleware Execution Flow:

Order of registration in `Program.cs` determines execution:

```csharp
app.UseMiddleware<Middleware1>(); // executes first
app.UseMiddleware<Middleware2>(); // executes second
app.Run(async context => {
    await context.Response.WriteAsync("Terminal Middleware\n");
});
```

Execution resembles a **stack** (Last In, First Out for `next()` after response):

```
Middleware1 Start
Middleware2 Start
Terminal Middleware
Middleware2 End
Middleware1 End
```

---

## 🛠️ Debug Tips:

* Ignore favicon requests (`/favicon.ico`)
* Use `Developer Exception Page` to catch errors in the middleware
* Place breakpoints inside middleware `Invoke`/`InvokeAsync` to track flow

---

## ✅ Conclusion:

| When to use              | Use This                                |
| ------------------------ | --------------------------------------- |
| One-liner or quick check | Lambda middleware (`app.Use(...)`)      |
| Reusable logic with DI   | `IMiddleware` with `UseMiddleware<T>()` |
| Slightly reusable, no DI | Classic class with `Invoke()`           |

---

