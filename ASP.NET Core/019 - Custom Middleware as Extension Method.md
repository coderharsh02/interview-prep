
---

## 📘 **Lecture 19 Summary – Custom Middleware as Extension Method**

---

### 🎯 **Goal of Lecture:**

Transform the usage of your custom middleware from:

```csharp
app.UseMiddleware<MyMiddleware>();
```

to a **cleaner, intuitive syntax** like:

```csharp
app.MyMiddleware();
```

This is achieved using an **Extension Method**.

---

## 🧩 **What is an Extension Method?**

* It allows **adding new methods to existing types** without modifying their original source code.
* Defined in a **static class** using a **static method**, where the first parameter is prefixed with `this` for the target type.

### 🔄 Real-life Analogy:

```csharp
int x = 10;
x.IsGreaterThan(5); // Suppose this is a custom extension on int
```

You're calling a method that wasn't originally on `int`, but acts like it is — that's the **power of extension methods**.

---

## 🛠️ **Goal: Custom Middleware with `app.MyMiddleware()` Syntax**

---

### 👣 **Steps to Implement**

#### 1. ✅ **Create Custom Middleware Class (`MyMiddleware.cs`)**

```csharp
public class MyMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("== MyMiddleware Start ==\n");
        await next(context);
        await context.Response.WriteAsync("== MyMiddleware End ==\n");
    }
}
```

#### 2. 🧾 **Register in DI (in `Program.cs`)**

```csharp
builder.Services.AddTransient<MyMiddleware>();
```

---

#### 3. 🔌 **Create Extension Method Class**

```csharp
public static class CustomMiddlewareExtensions
{
    public static IApplicationBuilder MyMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<MyMiddleware>();
    }
}
```

**Why this works:**

* The class is `static`
* The method is `static`
* The first parameter is `this IApplicationBuilder app` ⇒ tells the compiler: *this method "belongs" to `IApplicationBuilder`*

---

#### 4. 🧷 **Use Your Middleware via Extension in Program.cs**

```csharp
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1 Start\n");
    await next();
    await context.Response.WriteAsync("Middleware 1 End\n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2 Start\n");
    await next();
    await context.Response.WriteAsync("Middleware 2 End\n");
});

// 🔥 Custom Middleware via Extension Method
app.MyMiddleware();

app.Run(async context =>
{
    await context.Response.WriteAsync("Terminal Middleware\n");
});
```

---

## 🧠 **Middleware Flow Recap (With Extension)**

When a request comes in, execution happens in this **stack-like** pattern:

```text
Middleware 1 Start
  Middleware 2 Start
    == MyMiddleware Start ==
      Terminal Middleware
    == MyMiddleware End ==
  Middleware 2 End
Middleware 1 End
```

---

## ✅ **Why Use Extension Method for Middleware?**

| Benefit                       | Description                                                                |
| ----------------------------- | -------------------------------------------------------------------------- |
| 💡 Clean Syntax               | `app.MyMiddleware()` is easier to read                                     |
| 📦 Encapsulation              | Logic for wiring your middleware stays with your class                     |
| ♻️ Reusability                | Use in multiple apps easily                                                |
| 📚 Matches ASP.NET Convention | Built-in middlewares (like `.UseStaticFiles()`) also use extension methods |

---

## ⚠️ **Important Notes:**

* Browser sends **favicon.ico** request by default — ignore it during debugging.
* You **must register** your `IMiddleware` implementation with the **DI container** (e.g., `AddTransient`).

---

## 🧪 **Test Output Example:**

```
Middleware 1 Start
Middleware 2 Start
== MyMiddleware Start ==
Terminal Middleware
== MyMiddleware End ==
Middleware 2 End
Middleware 1 End
```

---

## 🧾 Conclusion:

✅ Instead of repeating:

```csharp
app.UseMiddleware<MyMiddleware>();
```

You now have:

```csharp
app.MyMiddleware();
```

And you're following the same pattern as:

* `app.UseRouting()`
* `app.UseEndpoints()`
* `app.UseAuthentication()`

All of these are built using **extension methods**.

---

Would you like a **GitHub-ready code structure** or a **diagram** showing the middleware call stack?
