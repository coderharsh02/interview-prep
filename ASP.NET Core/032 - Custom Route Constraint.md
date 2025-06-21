
---

## ✅ **Lecture 32: Custom Route Constraints**


## 🔸 **Goal of the Lecture**

To learn how to **create and use a custom (user-defined) route constraint** in ASP.NET Core.

---

## 🔸 **Why Custom Route Constraints?**

* Built-in route constraints like `alpha` only allow specific types (e.g., only letters).
* There’s **no built-in constraint for alphanumeric** values (e.g., `Manoj10`).
* Solution: Create a **custom constraint class** implementing `IRouteConstraint`.

---

## 🔸 **Step-by-Step Implementation**

### ✅ **1. Define Route in `Program.cs`**

```csharp
endpoints.MapGet("/user/{username:alphanumeric}", async context => {
    var username = Convert.ToString(context.Request.RouteValues["username"]);
    await context.Response.WriteAsync($"Welcome {username}");
});
```

Use `:alphanumeric` as a **custom constraint**, which we will define next.

---

### ✅ **2. Create Custom Constraint Class**

**Create folder**: `CustomConstraints`
**Create class**: `AlphanumericConstraint.cs`

```csharp
public class AlphanumericConstraint : IRouteConstraint
{
    public bool Match(HttpContext httpContext,
                      IRouter route,
                      string routeKey,
                      RouteValueDictionary values,
                      RouteDirection routeDirection)
    {
        if (!values.ContainsKey(routeKey)) return false;

        var value = Convert.ToString(values[routeKey]);
        var regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*$");  // Starts with letter, then alphanumerics

        return regex.IsMatch(value);
    }
}
```

---

### ✅ **3. Register Custom Constraint in `Program.cs`**

Before `builder.Build()`:

```csharp
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("alphanumeric", typeof(AlphanumericConstraint));
});
```

Don’t forget to **add the required namespace** for the custom constraint class.

---

### ✅ **4. Test Scenarios**

| URL              | Result        |
| ---------------- | ------------- |
| `/user/Manoj10`  | ✅ Allowed     |
| `/user/Manoj`    | ✅ Allowed     |
| `/user/12345`    | ❌ Not Allowed |
| `/user/Manoj@10` | ❌ Not Allowed |

---

## 🔸 **Assignment**

Create two more custom constraints:

### 🧮 **1. Month Constraint** (values from 1 to 12)

* Class name: `MonthConstraint`
* Regex: `^(1[0-2]|[1-9])$`

### 📅 **2. Date Format Constraint**

* Class name: `DateConstraint`
* Allow formats: `dd-mm-yyyy`, `dd/mm/yyyy`, `dd.mm.yyyy`
* Regex example:

```regex
^\d{2}[-/.]\d{2}[-/.]\d{4}$
```

---

## 🔚 Summary

* Custom route constraints allow fine-grained URL validation.
* Create a class implementing `IRouteConstraint`, override `Match()`.
* Register it using `ConstraintMap`.
* Useful for cleaner routing and enforcing parameter rules at the routing level.

---

