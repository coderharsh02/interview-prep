
---

## ✅ **Lecture 22: Conditional Middleware using `UseWhen()`**

---

### 📌 **Objective**

Learn how to **conditionally execute middleware** logic based on request data (e.g., headers, query string).

---

### 🧠 **Problem**

* By default, middleware is executed for **every request**.
* But sometimes we want a middleware to run **only if a specific condition is met**.

**Example:**
Only execute middleware if the query string contains:
`?isAuthorized=true`

---

### 🔧 **Solution: Use `app.UseWhen()`**

#### 🧩 `UseWhen()` Signature:

```csharp
app.UseWhen(
    condition: context => /* boolean condition */,
    configuration: appBuilder => {
        // Define middleware to run when condition is true
        appBuilder.Use(async (context, next) => {
            // Your logic
            await next(context);
        });
    }
);
```

---

### ✅ **Example: Conditional Middleware for `isAuthorized=true`**

```csharp
app.UseWhen(
    context => context.Request.Query.ContainsKey("isAuthorized") &&
               context.Request.Query["isAuthorized"] == "true",
    appBuilder =>
    {
        appBuilder.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Middleware 4 called\n\n");
            await next(context);
        });
    });
```

---

### ⚙️ **How It Works**

* If URL is `http://localhost:5000/?isAuthorized=true` → ✅ Middleware 4 runs.
* If query string is missing or `isAuthorized=false` → ❌ Middleware 4 is skipped.

---

### 📌 **Technical Notes**

* `UseWhen` takes:

  * A **predicate** (returns `bool`)
  * A **branch** that defines middleware to execute when predicate is true
* Inside the middleware:

  * You should call `await next(context)` to continue the pipeline
  * If you **don't call `next()`**, the response will stop there (terminal middleware)

---

### ⚠️ **Common Mistakes**

* ❌ Using `"true"` as a Boolean instead of string → Must use string comparison.
* ❌ Forgetting to call `next()` → Pipeline breaks unless intentional (terminal).
* ❌ Not handling case-sensitivity or missing keys → Use safe checks like `ContainsKey`.

---

### ✅ **Final Flow Output (Example)**

**Without `?isAuthorized=true`:**

```
Middleware 1 called
Middleware 2 called
Middleware 5 called
```

**With `?isAuthorized=true`:**

```
Middleware 1 called
Middleware 2 called
Middleware 4 called
Middleware 5 called
```

---

### 🧠 **Key Takeaway**

> Use `UseWhen()` to **conditionally add middleware logic** for more control over request processing.

---

