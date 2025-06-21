
---

## ✅ **Lecture 30 Summary: Route Constraints - Continue**

### 🔹 **Continuation of Route Constraints**

In this lecture, we expand on route constraints beyond basic data types like `int`, `datetime`, `guid`, etc.

---

### 🔸 **String Length Constraints**

#### ✅ `minlength(n)`

* Ensures a route parameter has **at least `n` characters**.

#### ✅ `maxlength(n)`

* Ensures a route parameter has **at most `n` characters**.

#### ✅ `length(min,max)`

* Ensures a route parameter has a character **length between `min` and `max`**.

#### ✅ `length(n)`

* Ensures the route parameter has **exactly `n` characters**.

> 🔍 Example:

```csharp
[Route("books/author/{authorName:alpha:minlength(4):maxlength(16)}")]
```

Or with combined constraint:

```csharp
[Route("books/author/{authorName:alpha:length(4,8)}")]
```

---

### 🔸 **Integer Value Constraints**

#### ✅ `min(n)`

* Accepts values **≥ `n`**.

#### ✅ `max(n)`

* Accepts values **≤ `n`**.

#### ✅ `range(min,max)`

* Accepts values **between `min` and `max` inclusive**.

> 🔍 Example:

```csharp
[Route("products/{id:int:min(10):max(1000)}")]
```

Or combined:

```csharp
[Route("products/{id:int:range(10,1000)}")]
```

---

### 🔸 **Behavior on Constraint Violation**

If a route parameter **fails to match** the constraint:

* The current route **does not match**.
* The **default endpoint/middleware** (if configured) will be executed instead.

---

### 🔜 **Coming Next**

* **Regex Constraints**
* **`required` and `when` constraints**

---
