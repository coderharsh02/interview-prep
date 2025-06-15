
## ✅ **Lecture 25: **`UseRouting` middleware and the `GetEndpoint` method**

## ✅ **Key Concepts Covered:**

### 🔹 1. **Role of `UseRouting` Middleware:**

* The `UseRouting` middleware **identifies and matches incoming requests** to the appropriate **route/endpoint** defined in the application.
* This matching is based on:

  * The **URL** of the request.
  * The **HTTP method** (GET, POST, etc.).

### 🔹 2. **How Routing Works Internally:**

* At **compile-time**, ASP.NET Core already knows about all endpoints in the code.
* At **runtime**, when a request comes in:

  * `UseRouting` matches the request with the defined routes.
  * It selects the **most appropriate endpoint** based on the URL and HTTP method.
  * This selected endpoint is stored as an **`Endpoint` object**.

### 🔹 3. **Using `GetEndpoint()` Method:**

* You can retrieve the selected endpoint programmatically using:

  ```csharp
  var endpoint = context.GetEndpoint();
  ```
* The returned `Endpoint` object contains useful information like:

  * `DisplayName` → Shows matched URL and method.
  * `RequestDelegate` → The delegate that will handle the request.

### 🔹 4. **Important Behavior Note:**

* If you call `GetEndpoint()` **before** `UseRouting` middleware in the pipeline:

  * It will **return `null`** because routing has not executed yet.
* If you call it **after** `UseRouting`:

  * It will return the matched endpoint (if any).

### 🔹 5. **Practical Demo Summary:**

* A custom middleware is created to call `GetEndpoint()` and log/write its result.
* Placed **before `UseRouting`**: `GetEndpoint()` returns null.
* Placed **after `UseRouting`**:

  * Returns valid `Endpoint` object for matched routes (e.g., `/products`).
  * For unmatched routes (e.g., `/` if not defined), still returns null.

### 🔹 6. **Use Cases of `GetEndpoint()`:**

* Helpful for:

  * **Logging matched endpoints**.
  * **Custom authorization checks**.
  * Debugging or diagnostics.
  * Writing middleware logic that depends on which route was matched.

---

## 💡 Conclusion:

* Always place `app.UseRouting()` **before** trying to access the selected route via `context.GetEndpoint()`.
* Use `GetEndpoint()` only **after routing is executed**, otherwise it will return `null`.

---
