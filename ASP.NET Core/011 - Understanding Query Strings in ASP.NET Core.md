
---

## 🎓 **Lecture 11: Understanding Query Strings in ASP.NET Core**

### 📌 What is a Query String?

* A **query string** is a way of **passing data to the server using the URL**.
* It starts **after the `?` (question mark)** in a URL.
* Multiple query strings are separated by an **`&` (ampersand)**.

### 🧪 Example:

```url
http://localhost:4200/product?id=101&name=iPhone
```

* `id=101` → key: `id`, value: `101`
* `name=iPhone` → key: `name`, value: `iPhone`

> ✅ Used only with **GET requests**, not with POST or PUT (they use request body for data).

---

### 🧭 Steps to Handle Query Strings in ASP.NET Core

#### ✅ 1. Define a Route

Check if the path is `/product`:

```csharp
if (context.Request.Path == "/product")
```

#### ✅ 2. Set Status Code

Always **set the status code** before writing the response:

```csharp
context.Response.StatusCode = 200;
```

#### ✅ 3. Access Query Strings

Use `context.Request.Query` — it is an `IQueryCollection` (similar to a dictionary).

Example:

```csharp
if (context.Request.Query.ContainsKey("id") && context.Request.Query.ContainsKey("name"))
{
    var id = context.Request.Query["id"];
    var name = context.Request.Query["name"];
    
    await context.Response.WriteAsync($"You selected the product with ID {id} and name {name}");
    return;
}
```

#### ✅ 4. Default Response

If query strings are not present:

```csharp
await context.Response.WriteAsync("You are in products page");
```

---

### 🚀 Demo Use Cases

#### ➤ With Query Strings:

```url
http://localhost:4200/product?id=101&name=iPhone
```

**Output:**

```
You selected the product with ID 101 and name iPhone
```

#### ➤ Without Query Strings:

```url
http://localhost:4200/product
```

**Output:**

```
You are in products page
```

---

### ⚠️ Important Notes:

* Always check if the query string **exists using `ContainsKey`** before accessing it.
* **Never** set response body or status code **after sending the response**.
* Query strings are part of **request URL** and can be accessed from `HttpContext.Request.Query`.

---

### ✅ Summary:

| Concept        | Explanation                                         |
| -------------- | --------------------------------------------------- |
| Query String   | Data sent in URL after `?`, separated with `&`      |
| Used In        | GET requests only                                   |
| Access In Code | `context.Request.Query["key"]`                      |
| Safe Access    | Use `ContainsKey("key")` before accessing           |
| Response Order | Set `StatusCode`, then `WriteAsync` (in that order) |

---
