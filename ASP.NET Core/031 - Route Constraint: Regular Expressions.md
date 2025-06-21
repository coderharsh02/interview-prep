
---

## ✅ **Lecture 31: Route Constraints using Regex**


### 🎯 **Goal of Lecture:**

To learn how to apply **regex (regular expression)** as a **route constraint** in ASP.NET Core minimal APIs for **parameter validation** directly within the route.

---

### 🧠 **What is Regex Constraint?**

* **Regex (Regular Expression):** A pattern-matching syntax used across programming languages.
* In routing, it's used to **restrict acceptable values** for a route parameter.

---

### 🛠️ **Examples Covered:**

---

#### ✅ **Example 1: Quarterly Report**

**Route:** `/quarterly-report/{year:int:min(1999):minlength(4)}/{month:regex(^March|June|September|December$)}`

* **Purpose:** Only allow specific months for quarterly reports.
* **Regex Explanation:** `^March|June|September|December$` ensures only these exact month names are accepted.

**Returned Response:**

```csharp
"This is the quarterly report for {year} {month}"
```

🔁 If an invalid month like "November" is passed → falls back to **default route**.

---

#### ✅ **Example 2: Monthly Report**

**Route:** `/monthly-report/{month:regex(^([1-9]|1[0-2])$)}`

* **Purpose:** Only allow month numbers from 1 to 12.
* **Regex Breakdown:**

  * `[1-9]` → 1 to 9
  * `1[0-2]` → 10 to 12

**Returned Response:**

```csharp
"This is the monthly report for month number {month}"
```

---

#### ✅ **Example 3: Daily Report with Date Format**

**Route:** `/daily-report/{date:regex(^((19|20)\\d\\d)[-/\\.](0[1-9]|1[012])[-/\\.](0[1-9]|[12][0-9]|3[01])$)}`

* **Purpose:** Accepts a full date in formats like `YYYY-MM-DD`, `YYYY/MM/DD`, or `YYYY.MM.DD`.
* **Regex Explanation:**

  * `((19|20)\d\d)` → Year from 1900 to 2099
  * `[-/.]` → Accepts `-`, `/`, or `.`
  * `(0[1-9]|1[012])` → Months from 01 to 12
  * `(0[1-9]|[12][0-9]|3[01])` → Days from 01 to 31

📌 **Limitation:** This regex does not validate calendar logic (e.g., 31st Feb is still accepted).

---

### ⚠️ **Best Practice (Important Note):**

Microsoft **recommends not using regex constraints for validation**. Instead:

**✅ Use if-statements inside your handler:**

```csharp
if (month == "March" || month == "June" || ...) {
   // Valid logic
} else {
   // return 400 Bad Request
}
```

✅ This provides more **meaningful errors** and **flexibility** than route-level regex constraints.

---

### 📝 **Takeaways:**

* Use `regex()` route constraint for advanced validation **when needed**, but prefer in-code validation.
* Combine constraints like `int`, `min()`, `minlength()` with `regex()` for complex parameter rules.
* Always validate user input within the handler to return accurate HTTP status codes.

---
