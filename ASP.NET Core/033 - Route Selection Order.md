
---

## ✅ **Lecture 33: Route Matching and Precedence Rules**


### 🎯 **Objective**:

Understand **how ASP.NET Core picks a route** when multiple route patterns could match a given URL. This is especially crucial when route patterns are **similar**.

---

### ✅ **Important Note**:

> **Route matching does *not* depend on the order** in which routes are defined.
> It follows **specific precedence rules** to determine the best match.

---

### 🧭 **ASP.NET Core Route Precedence Rules**:

---

#### **1. Most Segments First**

* The route with **more segments** has **higher precedence**.

**Example**:

```plaintext
URL: /books/category/author/123
Routes:
1. /books/category/author
2. /books/category/author/{bookId}

→ Route 2 will be matched because it has more segments and matches better.
```

---

#### **2. Literal Text Beats Parameters**

* A route with **literal values** takes precedence over one with **route parameters**.

**Example**:

```plaintext
Routes:
1. /books/category/{author}
2. /books/category/SteveSmith

URL: /books/category/SteveSmith

→ Route 2 will be chosen as it contains a literal value.
URL: /books/category/Mike

→ Route 1 will be chosen because 2 doesn’t match.
```

---

#### **3. Route Parameters with Constraints Win**

* Route with a **constraint** (e.g., `int`) has **higher priority** than one without.

**Example**:

```plaintext
Routes:
1. /books/category/{bookId}
2. /books/category/{bookId:int}

URL: /books/category/10 → Route 2 (because 10 is an integer)
URL: /books/category/john → Route 1 (as 2 expects only int)
```

---

#### **4. Catch-All Routes Have Lowest Precedence**

* A **catch-all parameter** (e.g., `{*slug}`) matches anything and is used as a fallback.

**Example**:

```plaintext
Routes:
1. /posts/{*slug}       → catch-all
2. /posts/{slug}

URL: /posts/routing-in-core → Route 2 (more specific)
URL: /posts/routing/in/core → Route 1 (Route 2 doesn't match more than one segment)
```

---

### 🧠 **Why This Matters**:

* When you define routes like:

  * `/products/{id}`
  * `/products/shoes`

  You need to **understand which route will be matched** for `/products/shoes`. Otherwise, unexpected controllers/actions may get triggered.

---

### 📝 Summary Table

| Rule No. | Rule Description           | Higher Precedence When...                        |
| -------- | -------------------------- | ------------------------------------------------ |
| 1        | More Segments              | Route has more path segments                     |
| 2        | Literal vs Parameter       | Route has literal values instead of placeholders |
| 3        | With vs Without Constraint | Route parameter has constraint (e.g., `int`)     |
| 4        | Normal vs Catch-All        | Route is **not** a catch-all                     |

---
