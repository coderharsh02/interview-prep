
---

## ✅ **Lecture 27: Default Values for Route Parameters**

### ✅ **Objective:**

Learn **how to set default values for route parameters** and understand **why it's useful**.

---

### 📌 **Problem:**

When a route expects parameters (like `ID` or `BookID`) and you don’t supply them in the URL, that route won’t match. Instead, the default route (e.g., root URL `/`) gets executed.

#### Example:

```plaintext
/products/101        ✅ Works – ID provided
/products/           ❌ Fails – No ID, so default route is executed
```

---

### 🛠️ **Solution: Set Default Route Parameters**

You can assign default values directly in the route template using `=`.

#### 🔸 Syntax:

```csharp
app.MapGet("/products/{id=101}", ...);
app.MapGet("/books/author/{authorName=JohnSmith}/{bookId=1}", ...);
```

* `{id=101}` → Default value is `101` if none is provided
* `{authorName=JohnSmith}` and `{bookId=1}` → Both have defaults

---

### 💡 **How it works:**

* If the user provides values in the URL → **those values are used**.
* If not → **default values are used**.

#### Example URLs:

| URL                      | Output                          |
| ------------------------ | ------------------------------- |
| `/products/`             | Product with ID = 101           |
| `/products/123`          | Product with ID = 123           |
| `/books/author/`         | Author = JohnSmith, Book ID = 1 |
| `/books/author/Mark/145` | Author = Mark, Book ID = 145    |

---

### 🧠 **Important Notes:**

* Route parameter names are **case-insensitive**.
* You can provide default values for **any or all route parameters**.
* Default values must be **fixed values**, **not variables or expressions**.
* You **don’t need quotes** around string defaults (e.g., `JohnSmith`, not `'JohnSmith'`).

---

### ✅ **Benefits:**

* Improves **user experience** by allowing optional URL parts.
* Makes APIs more **flexible** and **forgiving**.

---
