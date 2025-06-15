
---

## ✅ **Lecture 26: Route Parameters in ASP.NET Core**

## 🔹 What is a Route Parameter?

* A **route parameter** is a **named segment in the URL** whose value can **change**.
* Used to **pass dynamic values** in the URL, like an ID or name.

### Example:

```
/products/101
```

* Here, `/products/` is fixed, but `101` is dynamic — this is a **route parameter**.

```
/books/author/JohnSmith/123
```

* Route Parameters: `JohnSmith` (Author Name), `123` (Book ID)

---

## 🔹 Why Use Route Parameters?

* To **fetch resources dynamically** based on URL input.
* Allows building RESTful endpoints like:

  * `GET /products/{id}`
  * `GET /books/author/{authorName}/{bookId}`

---

## 🔹 Defining Route Parameters in ASP.NET Core

Use `{}` inside the URL pattern when defining routes in `MapGet()`:

```csharp
app.MapGet("/products/{id}", async (HttpContext context) => {
    var id = Convert.ToInt32(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"This is product with ID {id}");
});
```

### Key Points:

* `id` inside `{}` is the route parameter.
* Use `context.Request.RouteValues["id"]` to access it.
* Since this returns `object`, convert it using `Convert.ToInt32`.

---

## 🔹 Example: Multiple Route Parameters

```csharp
app.MapGet("/books/author/{authorName}/{bookId}", async (HttpContext context) => {
    var authorName = Convert.ToString(context.Request.RouteValues["authorName"]);
    var bookId = Convert.ToInt32(context.Request.RouteValues["bookId"]);

    await context.Response.WriteAsync($"This is the book authored by {authorName} and book ID is {bookId}");
});
```

* Route: `/books/author/StephenKing/12345`
* Output: `This is the book authored by StephenKing and book ID is 12345`

---

## 🔹 Important Notes

* **Route parameter names are case-insensitive**.
* Do **not** use **spaces** in route parameter names.
* You can have **multiple** route parameters in one URL.

---

## ✅ Summary

| Feature                 | Explanation                                       |
| ----------------------- | ------------------------------------------------- |
| **Route Parameter**     | Variable part in a URL                            |
| **Syntax**              | `{parameterName}` in route definition             |
| **Accessing Value**     | `context.Request.RouteValues["paramName"]`        |
| **Conversion**          | Use `Convert.ToInt32()` or `ToString()` as needed |
| **Multiple Parameters** | Separate with slashes `/author/{author}/{id}`     |

---