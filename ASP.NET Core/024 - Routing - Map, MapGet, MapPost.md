
---

## ✅ **Lecture 24: **ASP.NET Core Routing – `Map`, `MapGet`, `MapPost`**

Routing is the process of mapping incoming **HTTP requests** (based on URL and HTTP method) to the appropriate **middleware** or **endpoint**.

---

### 🧩 **Three Important Methods to Define Routes**

### 1. **`Map()`**

* Handles **any HTTP method** (`GET`, `POST`, `PUT`, `DELETE`, etc.)
* Syntax:

  ```csharp
  endpoints.Map("/home", async context =>
  {
      await context.Response.WriteAsync("You are in homepage");
  });
  ```
* When a request (any method) is made to `/home`, the middleware executes and returns the response.

---

### 2. **`MapGet()`**

* Handles only **HTTP GET** requests.
* Syntax:

  ```csharp
  endpoints.MapGet("/product", async context =>
  {
      await context.Response.WriteAsync("You are in products page");
  });
  ```
* If a **POST/PUT/DELETE** request is made to this route, the response is **405 Method Not Allowed**.

---

### 3. **`MapPost()`**

* Handles only **HTTP POST** requests.
* Syntax:

  ```csharp
  endpoints.MapPost("/product", async context =>
  {
      await context.Response.WriteAsync("New product created");
  });
  ```

---

### 📌 **Custom “Page Not Found” Middleware**

* If none of the defined routes match, a final fallback middleware using `app.Run()` can return a default message.
* Syntax:

  ```csharp
  app.Run(async (HttpContext context) =>
  {
      await context.Response.WriteAsync("The page you are requesting for is not found");
  });
  ```

---

### 🧠 **Key Points to Remember**

| Method      | URL Match | HTTP Method Match | Executes Middleware |
| ----------- | --------- | ----------------- | ------------------- |
| `Map()`     | ✅         | ✅ All methods     | Yes                 |
| `MapGet()`  | ✅         | ✅ Only GET        | Yes (on GET)        |
| `MapPost()` | ✅         | ✅ Only POST       | Yes (on POST)       |

* If a route matches and middleware is executed, **`next()` is not called**, so other middlewares are skipped.
* If **no route matches**, the last middleware (usually the `app.Run`) will be triggered.

---

### 🛠 Example Testing Scenarios:

| Request         | Expected Response                                     |
| --------------- | ----------------------------------------------------- |
| GET `/home`     | You are in homepage                                   |
| GET `/product`  | You are in products page                              |
| POST `/product` | New product created                                   |
| GET `/unknown`  | The page you are requesting for is not found          |
| POST `/home`    | You are in homepage (since `Map` handles all methods) |

---

