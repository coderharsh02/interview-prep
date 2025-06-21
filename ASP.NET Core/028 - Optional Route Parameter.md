
---

## ✅ **Lecture 27: Optional Route Parameters**


### ✅ **Objective:**

Learn how to **make route parameters optional** without setting a default value.

---

### 📌 **Problem:**

When a route contains required parameters (e.g., `{id}`) and you **don’t supply them**, the route doesn’t match and the default middleware gets executed — **even if it’s the right path**.

#### Example:

```plaintext
/products/101   ✅ Matches
/products/      ❌ Doesn’t match unless default value is provided
```

---

### 🛠️ **Solution: Use Optional Route Parameters**

You can make a parameter **optional** by appending a `?` to its name in the route template:

#### 🔸 Syntax:

```csharp
app.MapGet("/products/{id?}", async (string? id) => {
    if (id != null)
        return Results.Ok($"This is product with ID {id}");
    else
        return Results.Ok("You are in the products page");
});
```

---

### 💡 **Behavior:**

* If **value is provided** → it's used.
* If **no value is provided** → parameter becomes `null`.
* No **default fallback value** is assumed.

---

### 🧠 **Important Notes:**

* Do **not use `Convert.ToInt32`** directly on a possibly null parameter — it will default to 0 and mislead you.

  **Instead**, keep the parameter nullable (`string?` or `int?`) and check before converting:

  ```csharp
  if (id != null) {
      int productId = Convert.ToInt32(id);
      // Use productId
  }
  ```

---

### 🔁 **Applied Example:**

#### For `/products/{id?}`

| URL             | Output                       |
| --------------- | ---------------------------- |
| `/products/101` | This is product with ID 101  |
| `/products/`    | You are in the products page |

---

### 📚 **Second Example: `/books/author/{authorName}/{bookId?}`**

#### Logic:

* If `bookId` is provided → show specific book details.
* If `bookId` is not provided → show list of books by that author.

#### Example:

```csharp
app.MapGet("/books/author/{authorName}/{bookId?}", async (string authorName, string? bookId) => {
    if (bookId != null)
        return Results.Ok($"This is the book authored by {authorName} and book ID is {bookId}");
    else
        return Results.Ok($"Following are the list of books authored by {authorName}");
});
```

---

### 🧪 **Test Scenarios:**

| URL                           | Output                                                    |
| ----------------------------- | --------------------------------------------------------- |
| `/books/author/JohnSmith/123` | This is the book authored by JohnSmith and book ID is 123 |
| `/books/author/JohnSmith`     | Following are the list of books authored by JohnSmith     |

---

### ✅ **Recap:**

* Use `?` to make parameters optional: `{param?}`
* Always check for `null` before using the optional parameter.
* Great for **flexible routes** with fewer endpoint methods.

---
