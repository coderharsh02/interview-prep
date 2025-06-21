
---

## ✅ **Lecture 29 Summary: Route Constraints in ASP.NET Core**

#### 🧠 **What is a Route Constraint?**

Route constraints **restrict** the type or format of data that a route parameter can accept.

---

### 🛠️ **Problem Before Constraints**

* You define a route like `/products/{id}`.
* If you access `/products/101` → `id = 101` ✅
* If you access `/products/hello` → `id = "hello"` ❌ (Invalid, but it still tries to handle it)

This leads to **runtime exceptions** when converting `"hello"` to `int`.

---

### 🔒 **Fix: Use Route Constraint**

To restrict `id` to only accept **integer values**, modify the route:

```csharp
app.MapGet("/products/{id:int}", async (HttpContext context) => {
    // Code
});
```

* Now only `/products/123` will match.
* `/products/abc` or `/products/12abc` will **not** match and fall back to the default route.

🚫 **Common mistake:** Do NOT use a space between `{id:` and `int}` → ❌ `{id: int}`

---

### 💡 **How Constraints Work (Flow Summary)**

1. Request comes in.
2. ASP.NET Core routing middleware:

   * Checks if the URL matches a route pattern.
   * Checks if the **constraint** is satisfied.
   * If yes → execute the endpoint.
   * If no → check next route or fall back to default.

---

### ✍️ **Author Example: Text Constraint**

```csharp
app.MapGet("/books/author/{authorName:alpha}/{bookId:int?}", async (HttpContext context) => {
    // Handler
});
```

* `authorName:alpha` → Accepts only letters (A–Z, a–z).

  * `"JohnSmith"` ✅
  * `"John-Smith"` ❌ (contains `-`)
  * `"123"` ❌

* `bookId:int?` → Optional integer.

---

### ⚠️ **Why Conversion is Still Needed**

Even with a constraint like `:int`, the value you get from:

```csharp
var id = context.Request.RouteValues["id"];
```

is of type `object`. You still need to convert it to `int` manually:

```csharp
int productId = Convert.ToInt32(id);
```

---

### 📘 **Valid Constraint Types (From Docs)**

* `int` ✅
* `bool`
* `datetime`
* `decimal`
* `double`
* `float`
* `guid`
* `long`
* `alpha` (only letters)
* `min`, `max`, `length`, `range`, `regex`, etc.

📝 You **cannot** use C# types like `short`, `byte`, etc. as route constraints.

👉 For full list: [Official ASP.NET Core Routing Docs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing)

---

### ✅ **Recap**

| Feature                   | Use                |
| ------------------------- | ------------------ |
| Make a param required     | Remove `?`         |
| Restrict to int only      | `{id:int}`         |
| Restrict to alphabet only | `{name:alpha}`     |
| Optional + type check     | `{id:int?}`        |
| Still need conversion?    | ✅ Yes, from object |

---
