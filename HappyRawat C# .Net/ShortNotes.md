
---

## 🔹 OOPs / C# Concepts

### ✅ Q1. What are the Main Concepts of OOP? What are Classes and Objects?

**Core OOP Concepts:**

* **Class**
* **Object**
* **Abstraction**
* **Polymorphism**
* **Inheritance**
* **Encapsulation**

**Class:**
A **blueprint** or **logical unit** that defines fields, methods, and properties.

**Object:**
An **instance** of a class. It holds actual values in memory and interacts with other objects.

---

### ✅ Q2. What is Inheritance? Why is it Important?

**Definition:**
A **parent-child** relationship where a child class inherits properties and methods from a parent class.

**Purpose:**

* Enables **code reusability**
* Supports **abstraction**
* Promotes **hierarchical classification**

**Access Modifiers:**

* `public`: Accessible everywhere.
* `protected`: Accessible within the class and derived classes.
* `private`: Accessible only within the class itself (not even derived classes).

---

### ✅ Q3. Types of Inheritance

| Type             | Description                                                                   |
| ---------------- | ----------------------------------------------------------------------------- |
| **Single**       | One base class, one derived class.                                            |
| **Multiple**     | One derived class inherits from multiple base classes *(C# uses interfaces)*. |
| **Multilevel**   | Grandparent → Parent → Child.                                                 |
| **Hierarchical** | One base class, multiple derived classes. *(Most common)*                     |

---

### ✅ Q4. How to Prevent a Class from Being Inherited?

* Use the **`sealed`** keyword:

  ```csharp
  sealed class MyClass { }
  ```

* **Static classes** are also non-inheritable by design.

---

### ✅ Q5. What is Abstraction?

**Definition:**
Hiding **internal implementation** and showing only the **essential features** to the user.

**Achieved via:**

* **Interfaces**
* **Abstract classes**

> Focuses on **what** an object does, not **how** it does it.

---

### ✅ Q6. What is Encapsulation?

**Definition:**
Wrapping **data + methods** together into a single unit (class) and **restricting direct access** using access modifiers.

**Example:**

```csharp
private int balance;

public void Deposit(int amount)
{
    if (amount > 0 && balance + amount <= 100000)
        balance += amount;
}
```

User can’t directly set `balance` – they must use the `Deposit` method.

---

### ✅ Difference Between Abstraction and Encapsulation

| Abstraction                       | Encapsulation                         |
| --------------------------------- | ------------------------------------- |
| Focuses on **what** to expose     | Focuses on **how** to restrict access |
| Design-level concept              | Implementation-level concept          |
| Achieved via interfaces/abstracts | Achieved via access modifiers         |
| Provides a simplified interface   | Protects the internal state of object |

> 🔁 **Encapsulation implements Abstraction**

---

Here’s a clear, concise, and well-structured **revision note** for your Q7–Q10, perfect for interviews and quick recall:

---

### ✅ Q7. What is Polymorphism and Its Types?

**Polymorphism** = *Poly* (many) + *Morph* (forms)
It is the ability of an object, variable, or function to take **multiple forms**.

**Types of Polymorphism:**

1. **Compile-time Polymorphism** → *Method Overloading*
2. **Run-time Polymorphism** → *Method Overriding*

| Type         | When it occurs    | How it works                          |
| ------------ | ----------------- | ------------------------------------- |
| Compile-time | At build time     | Method selected by compiler           |
| Run-time     | At execution time | Method selected by actual object type |

---

### ✅ Q8. What is Method Overloading? How Can a Method Be Overloaded?

**Method Overloading** = *Same method name* with *different signatures* in the **same class**.
It is **compile-time polymorphism**.

**Ways to Overload:**

1. Different **number** of parameters
2. Different **types** of parameters
3. Different **order** of parameters

✅ No special keyword is needed.
✅ Compiler decides which method to invoke based on arguments.

```csharp
void Add(int a, int b) {}
void Add(double a, double b) {}
void Add(int a, double b) {}
```

---

### ✅ Q9. Difference: Method Overloading vs Method Overriding

| Feature              | Method Overloading                      | Method Overriding                              |
| -------------------- | --------------------------------------- | ---------------------------------------------- |
| Type                 | Compile-time polymorphism               | Run-time polymorphism                          |
| Class                | Same class                              | Base and derived class                         |
| Signature            | Must be **different**                   | Must be **same**                               |
| Keywords             | No keywords required                    | Uses `virtual` (base) and `override` (derived) |
| Inheritance Required | ❌ No                                    | ✅ Yes                                          |
| Purpose              | Provide multiple versions in same class | Customize base class behavior in derived class |

---

### ✅ Q10. Difference: Method Overriding vs Method Hiding

| Feature               | Method Overriding                   | Method Hiding                                      |
| --------------------- | ----------------------------------- | -------------------------------------------------- |
| Signature             | Same as base method                 | Same as base method                                |
| Keyword in base class | `virtual`                           | No need                                            |
| Keyword in derived    | `override`                          | `new`                                              |
| Runtime behavior      | Resolved at **run-time**            | Resolved at **compile-time** (when using base ref) |
| Polymorphism          | Yes – supports dynamic polymorphism | No – hides base method statically                  |

**Example:**

```csharp
class Base { public virtual void Show() { Console.WriteLine("Base"); } }
class Derived : Base { public override void Show() { Console.WriteLine("Derived"); } } // Overriding

class Base2 { public void Show() { Console.WriteLine("Base"); } }
class Derived2 : Base2 { public new void Show() { Console.WriteLine("Derived"); } } // Hiding
```

---

## 🔹 Method Behavior in Inheritance: `none`, `new`, `virtual`, `override`, `abstract`

### ✅ Key Differences: `none/new` vs `virtual/override`

| Behavior Type        | Description                                                                                                                                                              |
| -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `none`               | Regular method. **No polymorphism**. If base class reference is used, base method is called—even if the object is of derived class.                                      |
| `new`                | **Method hiding**. Derived class hides base method. But if the method is called using a **base class reference**, it still calls the base method.                        |
| `virtual + override` | **Run-time polymorphism**. When method is `virtual` in base and `override` in derived, the method of **actual object type** is called—even through base class reference. |

> 🧠 In short:
>
> * `none` / `new` → determined at **compile-time**
> * `virtual` / `override` → determined at **run-time**

---

### ✅ Example Code

```csharp
class Base
{
    public void Show1() => Console.WriteLine("Base Show1"); // none
    public virtual void Show2() => Console.WriteLine("Base Show2"); // virtual
}

class Derived : Base
{
    public new void Show1() => Console.WriteLine("Derived Show1"); // new
    public override void Show2() => Console.WriteLine("Derived Show2"); // override
}

Base obj = new Derived();
obj.Show1(); // Output: Base Show1 (method hiding, compile-time binding)
obj.Show2(); // Output: Derived Show2 (method overriding, run-time binding)
```

---

### ✅ Behavior Table: Combinations of Base & Derived Method Modifiers

| Base Method | Derived Method | Result of `Base b = new Derived(); b.Method();` |
| ----------- | -------------- | ----------------------------------------------- |
| (none)      | (none)         | Base                                            |
| (none)      | `new`          | Base                                            |
| (none)      | `override`     | ❌ *Error – override requires virtual/abstract*  |
| `virtual`   | (none)         | Base                                            |
| `virtual`   | `new`          | Base *(method hiding, no polymorphism)*         |
| `virtual`   | `override`     | Derived *(true polymorphism)*                   |
| `abstract`  | (none)         | ❌ *Error – abstract must be overridden*         |
| `abstract`  | `new`          | ❌ *Error – must override, not hide*             |
| `abstract`  | `override`     | Derived                                         |

---

### ✅ Quick Summary

* Use `virtual` in **base class** to allow method overriding.
* Use `override` in **derived class** to change base behavior.
* Use `new` in **derived class** to hide base behavior (not recommended unless necessary).
* If neither `virtual` nor `new` is used, base class method is always called with base class reference.

> ✅ Always prefer `virtual-override` when designing for polymorphism.

---

### ✅ Q11. What Are the Advantages and Limitations of OOP?

**✔ Advantages:**

1. **Code Reusability** – via Inheritance
2. **Flexibility** – via Polymorphism
3. **Security** – via Encapsulation and Data Hiding
4. **Scalability** – easy to expand apps from small to large
5. **Modularity** – easier debugging & maintenance

**✖ Limitations:**

* **Overkill for small apps** — too much design effort for simple use-cases
* **Planning required** — OOP needs upfront structure (classes, inheritance, etc.)

---

### ✅ Q12. What is the Difference Between Abstract Class and Interface?

| Feature                 | Abstract Class                                    | Interface                            |
| ----------------------- | ------------------------------------------------- | ------------------------------------ |
| Purpose                 | Partial implementation (base class)               | Pure contract (what to do)           |
| Method Type             | Can have **abstract + concrete** methods          | Only method/property **signatures**  |
| Fields, Constructors    | ✅ Can have fields & constructors                  | ❌ Cannot have fields or constructors |
| Access Modifiers        | ✅ Allowed                                         | ❌ Members are always public          |
| Multiple Inheritance    | ❌ Not supported                                   | ✅ Supported                          |
| Keywords                | `abstract`                                        | `interface`                          |
| Inheritance Requirement | Must be inherited and abstract members overridden | Must be implemented fully in class   |

---

### ✅ Q13. When to Use Interface and When Abstract Class?

**Use Abstract Class when:**

* You have **some common logic** to share across child classes
* You want **default behavior** in base class
* All child classes are part of **same hierarchy**

**Use Interface when:**

* You want to define **a contract**
* You want **unrelated classes** to follow same rules (e.g., `ISaveable`, `IDrawable`)
* You need **multiple inheritance**

🧠 *"If you know what to do but not how — use Interface.
If you know both what and how — use Abstract Class."*

---

### ✅ Q14. Why Even Create Interfaces?

**Two main reasons:**

1. ✅ To **achieve multiple inheritance**
   – Since abstract classes can't support it, interfaces do.

2. ✅ To **enforce consistency** across different classes
   – E.g., Every type of `Employee` (Permanent or Contract) must implement methods like `SetSalary()` and `AssignProject()`.

> Interfaces make sure **every class follows the same structure**, helping build **standardized, maintainable, and flexible** systems.

---

### ✅ Q15. Can an Interface Have a Constructor?

**❌ No.**

* Interfaces cannot have constructors.
* They are **not meant to create objects**, only to define **contracts**.

---

### ✅ Q16. Can You Create an Instance of an Abstract Class or Interface?

**❌ No.**

* Abstract class and Interface **cannot be instantiated**.
* They are meant to be **inherited/implemented**, not directly used.

```csharp
Animal a = new Animal();     // ❌ Error – abstract class
IRunnable r = new IRunnable(); // ❌ Error – interface
```

---

Here's a short and **interview-style answer** for:

---

### ✅ **Q17. What are access specifiers? What is the default access modifier in a class?**


Access specifiers in C# define the visibility or accessibility of classes, methods, properties, and fields. They control **where a member can be accessed** from.

---

### 🔐 **Types of Access Specifiers:**

| Modifier             | Accessible Within...                                          |
| -------------------- | ------------------------------------------------------------- |
| `public`             | Anywhere in the project or other projects (most open)         |
| `private`            | Within the same class only                                    |
| `protected`          | Within the class and its derived classes                      |
| `internal`           | Within the same assembly (project)                            |
| `protected internal` | Within the same assembly OR derived classes from anywhere     |
| `private protected`  | Within the same class OR derived classes in the same assembly |

---

### ❓ **Default Access Modifier:**

* **For a class:** `internal` (if no access modifier is given)
* **For class members:** `private` by default

---

### 🔸Example:

```csharp
class MyClass      // Default = internal
{
    int x;         // Default = private
    public int y;  // Accessible everywhere
}
```

---

Here's a concise, **interview-ready answer** for:

---

### ✅ **Q18. What is Boxing and Unboxing? Explain Casting, Implicit Casting, and Explicit Casting**

---

### 🧱 **Boxing and Unboxing**

* **Boxing** is process of converting a **value type to a reference type** (`object`).
* **Unboxing** is process of converting **reference type back to value type.**

#### 🔄 Example:

```csharp
int x = 10;
object obj = x;      // Boxing
int y = (int)obj;    // Unboxing
```

#### ⚠️ Performance Impact:

* Boxing causes **heap allocation** and adds **garbage collection pressure**.
* Unboxing requires **explicit casting** and may throw runtime exceptions.

---

### 🎯 **Casting** (Type Conversion)

Casting is the process of **converting one data type to another**, either implicitly or explicitly.

---

#### ✅ **Implicit Casting (Safe & Automatic)**

Occurs **automatically** when converting from a **smaller to a larger** compatible type.

```csharp
int a = 10;
double b = a; // Implicit
```

> Like **pouring water from a glass into a bucket** — safe and no data loss.

---

#### 🔒 **Explicit Casting (Manual & Risky)**

Required when converting from a **larger or incompatible** type to a **smaller one**.

```csharp
double x = 10.5;
int y = (int)x; // Explicit — decimal is cut off
```

> Like **pouring water from a bucket into a glass** — overflow or data loss may occur.

---

### ⚠️ Risks of Explicit Casting:

* **Data Loss:** Decimal values truncated.
* **Overflow:** Large values become incorrect.
* **Runtime Errors:** May throw `InvalidCastException` for incompatible types.

---

✅ **One-Liner:**

> Implicit casting is automatic and safe; explicit casting is manual and may cause data loss or runtime errors.


---

### ✅ Q19. What is the difference between `string` and `StringBuilder`? When to use what?

| Aspect       | `string`                           | `StringBuilder`                   |
| ------------ | ---------------------------------- | --------------------------------- |
| Mutability   | Immutable (can't be changed)       | Mutable (can be modified)         |
| Memory usage | Creates new object on every change | Modifies existing object          |
| Performance  | Slower for multiple operations     | Faster for repeated modifications |
| Use case     | Few changes or static content      | Many changes (loops, heavy edits) |

**🔹 Interview Tip**:
Use `StringBuilder` for performance in loops or repeated string edits.

---

### ✅ Q20. What are basic string operations in C#?

1. `Concat()` / `+` – Combine two or more strings
2. `Replace()` – Replace part of string
3. `Trim()` – Remove leading/trailing whitespace
4. `Contains()` – Check if a string has a substring
   (Also: `Split()`, `ToUpper()`, `ToLower()`, `Substring()` are common)

---

### ✅ Q21. What are nullable types?

* **Nullable types** allow value types to hold `null`.
* Declared using `?`:

  ```csharp
  int? x = null;
  bool? flag = null;
  ```

| Type           | Can hold `null`?  | Nullable version                 |
| -------------- | ----------------- | -------------------------------- |
| Reference type | ✅ Yes             | N/A (default behavior)           |
| Value type     | ❌ No (by default) | ✅ Yes (use `?` or `Nullable<T>`) |

**🔹 Use Case**: Useful when value is optional (e.g., database fields).

---

### ✅ Q22. What are Generics in C#? When & why to use?

> **Generics = Type-safe reusable code**

**Benefits**:

* **Type Safety** – Catch errors at compile time
* **Performance** – Avoid boxing/unboxing
* **Reusability** – Use same logic for different types

**🔹 Example: Generic method**

```csharp
public bool AreEqual<T>(T a, T b)
{
    return a.Equals(b);
}
```

**🔹 Example: Generic class**

```csharp
public class MyList<T>
{
    public void Add(T item) { ... }
}
```

**💡 Use generics when**:

* You want **type independence**
* You are writing **collections, utility libraries, or data structures**

---

### 🔹 Q23. How to implement exception handling in C#?

**Answer:** Use `try-catch-finally` blocks to handle exceptions gracefully and prevent app crashes.

* **try**: Wrap risky code.
* **catch**: Handle the exception.
* **finally**: Executes always (cleanup, closing connections).
* **throw**: Rethrow exception to preserve stack trace or escalate.

✅ *Use finally for closing DB connections, files, etc.*

---

### 🔹 Q24. Can we execute multiple catch blocks?

**Answer:** **NO** – Only **one** matching `catch` block is executed.

🧠 *Why multiple catch blocks?*
To handle different exceptions differently, e.g.:

```csharp
catch (DivideByZeroException) { }  // log nothing
catch (Exception ex) { Log(ex); }
```

---

### 🔹 Q25. What is a finally block? When to use it?

**Answer:** A `finally` block **always executes**, whether exception occurs or not.

📌 **Use Case:**
Closing database connections, releasing file handles, etc.

```csharp
try { con.Open(); }  
catch { }  
finally { con.Close(); }
```

---

### 🔹 Q26. Can we have only try block without catch?

**Answer:** **YES**, but you **must** include `finally` if `catch` is missing.

✅ Example:

```csharp
try { /* code */ }
finally { /* cleanup */ }
```

---

### 🔹 Q27. Difference between `throw` and `throw ex`?

| Feature     | `throw`                        | `throw ex`                |
| ----------- | ------------------------------ | ------------------------- |
| Stack Trace | **Preserved** (accurate)       | **Reset** to current line |
| Debugging   | Easy to locate source of error | Misleading stack trace    |

🧠 **Best Practice:** Always use plain `throw` to preserve original stack trace.

---

Here are your **interview-ready short notes** for **Q28–Q32**, with some light improvements in formatting and clarity where needed (noted at the end):

---

### ✅ Q28. What are the loop types in C#?

| Loop Type  | Description                                                                                       |
| ---------- | ------------------------------------------------------------------------------------------------- |
| `while`    | Checks condition first, then executes. Init, condition, and increment are separate.               |
| `do-while` | Executes **once at minimum**, then checks the condition.                                          |
| `for`      | Combines init, condition, and increment in a single line. Best for known ranges.                  |
| `foreach`  | Iterates over **collections** (e.g., array, List, Dictionary, etc.). Simplified syntax, no index. |

---

### ✅ Q29. What is the difference between `continue` and `break`?

| Statement  | Behavior                                           |
| ---------- | -------------------------------------------------- |
| `continue` | Skips the current iteration and moves to the next. |
| `break`    | Exits the loop completely.                         |

🧠 *Use `continue` to skip specific values. Use `break` to stop early.*

---

### ✅ Q30. What is the difference between Array and ArrayList?

| Feature     | Array                       | ArrayList                         |
| ----------- | --------------------------- | --------------------------------- |
| Type Safety | ✅ Strongly typed            | ❌ Can store any type (object)     |
| Size        | Fixed size                  | Dynamic (can grow/shrink)         |
| Performance | Faster due to static typing | Slower (boxing/unboxing involved) |

---

### ✅ Q31. What is the difference between ArrayList and Hashtable?

| Feature      | ArrayList              | Hashtable                  |
| ------------ | ---------------------- | -------------------------- |
| Data Storage | Stores **values only** | Stores **key-value pairs** |
| Access       | Access via index       | Access via unique key      |
| Type         | Not type-safe          | Not type-safe              |

---

### ✅ Q32. What are collections in C# and their types?

**Collections** are data structures used to **store, manage, and manipulate groups of objects**.

---

#### 🔹 Types of Collections:

| Namespace                       | Types                                                                                     |
| ------------------------------- | ----------------------------------------------------------------------------------------- |
| `System.Collections.Generic`    | `List<T>`, `Dictionary<TKey, TValue>`, `Stack<T>`, `Queue<T>`, `SortedList<TKey, TValue>` |
| `System.Collections.Concurrent` | `ConcurrentDictionary<TKey, TValue>`, `ConcurrentQueue<T>`, `BlockingCollection<T>`       |
| `System.Collections`            | `ArrayList`, `Hashtable`, `Queue`, `Stack` (non-generic & legacy)                         |

🧠 Prefer **generic collections** for type safety and better performance.


---

### ✅ Q33. What is `IEnumerable` in C#?

> `IEnumerable` is an interface that **enables iteration over a collection** using `foreach`.

---

### 🔹 Key Points:

* Found in `System.Collections` (non-generic) and `System.Collections.Generic` (`IEnumerable<T>`).
* Used by collections like `List`, `Array`, `Dictionary`, etc.
* Provides the method:

  ```csharp
  IEnumerator GetEnumerator();
  ```

### 🔍 Example:

```csharp
List<Employee> employees = new List<Employee>();
foreach (Employee emp in employees) { Console.WriteLine(emp.Name); }
// This works because List<T> implements IEnumerable<Employee>
```

---

### 🧠 Interview One-Liner:

> `IEnumerable` enables `foreach` loops by exposing `GetEnumerator()` which returns an `IEnumerator`.

---

### ✅ Q34. What is the difference between `IEnumerable` and `IEnumerator`?

| Interface     | Role / Purpose                                                               |
| ------------- | ---------------------------------------------------------------------------- |
| `IEnumerable` | Exposes the `GetEnumerator()` method to support iteration (e.g., `foreach`)  |
| `IEnumerator` | Used to **move through** the collection (`MoveNext()`, `Current`, `Reset()`) |

---

### 🔹 `IEnumerator` Methods:

```csharp
bool MoveNext();     // Move to next element
void Reset();        // Reset to initial position
object Current { get; } // Current element
```


---

### ✅ When building a custom collection:

You must:

1. Implement `IEnumerable` — to allow external iteration.
2. Implement `IEnumerator` — to define how iteration happens internally.

---

### ✅ Interview One-Liner:

> `IEnumerable` gives you the ability to iterate, while `IEnumerator` defines **how** to iterate. `IEnumerable` uses `IEnumerator` behind the scenes.

---

### ✅ Q35. What is the difference between `IEnumerable` and `IQueryable` in C#? Why use `IQueryable` in SQL queries?

---

### 🧠 **One-Line Answer:**

> `IEnumerable` filters data in memory (**client-side**), while `IQueryable` filters at the **database level** — making `IQueryable` more efficient for SQL queries.

---

### 🔍 **Key Differences:**

| Feature            | `IEnumerable<T>`                         | `IQueryable<T>`                                |
| ------------------ | ---------------------------------------- | ---------------------------------------------- |
| Namespace          | `System.Collections.Generic`             | `System.Linq`                                  |
| Execution Location | **Client-side (in-memory)**              | **Database/server-side**                       |
| When Filters Apply | After data is fetched                    | Before data is fetched                         |
| Performance        | Slower for large data (loads everything) | Faster for large data (fetches only needed)    |
| Use Case           | In-memory collection operations          | Remote query execution (e.g., EF, LINQ-to-SQL) |

---

### 🔄 **How They Work Internally:**

#### 🔹 IEnumerable:

```csharp
var data = dbContext.Users.ToList();  // Fetches all users
var result = data.Where(u => u.Age > 18);  // Filters on client
```

#### 🔹 IQueryable:

```csharp
var result = dbContext.Users.Where(u => u.Age > 18);  // Sends SQL: SELECT * FROM Users WHERE Age > 18
```

---

### ⚠️ **Why Prefer `IQueryable` for SQL Queries?**

✅ Filters **at the database level**,

✅ Less memory usage,

✅ Better performance,

✅ Ideal for **Entity Framework**, LINQ-to-SQL, and large datasets.

---

### 🔁 Analogy:

> `IEnumerable` is like **ordering the entire menu**, then picking what you want at the table.
> `IQueryable` is like **asking the waiter to bring only the items you want** — faster and less wasteful.

---

### ✅ Interview One-Liner:

> Use `IQueryable` for better performance in database queries — it builds SQL and filters data at the server, unlike `IEnumerable` which pulls all data and filters locally.

---

## ✅ Q36. What is the difference between `ref` and `out` parameters?

Both `ref` and `out` allow **passing parameters by reference**, letting the method modify the original variable.

| Feature                         | `ref`                 | `out`               |
| ------------------------------- | --------------------- | ------------------- |
| Initialization before passing   | ✅ Required            | ❌ Not Required      |
| Initialization before returning | ❌ Optional            | ✅ Required          |
| Use case                        | Modify existing value | Return new value(s) |

### 🧠 Example:

```csharp
void UpdateRef(ref int a) { a += 10; }

void AssignOut(out int b) { b = 20; }
```

> ✅ **Use `ref`** when modifying a value

> ✅ **Use `out`** when returning new data

---

## ✅ Q37. What is the purpose of the `params` keyword?

The `params` keyword allows passing a **variable number of arguments** to a method.

### 🧠 Example:

```csharp
void PrintNames(params string[] names)
{
    foreach (var name in names)
        Console.WriteLine(name);
}

PrintNames("A", "B", "C");
```

> ✅ Use `params` when you **don’t know the number of parameters** in advance.

---

## ✅ Q38. What is a constructor and what are its types?

A **constructor** is a special method that **initializes** a class object.
It has the same name as the class and **executes automatically** when an object is created.

### 🔸 Types of Constructors:

| Constructor Type  | Description                                                       |
| ----------------- | ----------------------------------------------------------------- |
| **Default**       | No parameters. Auto-created if no constructor is defined          |
| **Parameterized** | Takes arguments to initialize fields                              |
| **Copy**          | Creates an object by copying values from another object           |
| **Static**        | Initializes static data; runs **only once** before the first use  |
| **Private**       | Prevents external object creation; used in **singleton** patterns |

---

### ✅ Important: Static Constructor

* Declared with `static` keyword
* Runs **once** per class, before any static member is accessed
* No parameters allowed

```csharp
class Logger
{
    static Logger() { /* initialize logging config */ }
}
```

> ✅ Use it for **one-time setup** of static resources.

---

### ✅ Important: Private Constructor

* Prevents instantiating the class from outside
* Used in **utility** or **singleton** patterns

```csharp
class Config
{
    private Config() { }
    public static string AppName => "MyApp";
}
```

> ✅ Use when you want to **restrict object creation** or enforce **single instance**.

---

### ✅ Copy Constructor

```csharp
class Student
{
    public string Name;
    public Student(Student s)
    {
        this.Name = s.Name;
    }
}
```

> ✅ Used to **clone/copy** an object’s state into a new object.

---

## ✅ Q39. When to use a Private Constructor?

Use a **private constructor** when:

1. You **don’t want other classes to create an instance** of your class
2. You're implementing a **Singleton pattern**
3. You are creating a **utility/static class**

```csharp
public class Utility
{
    private Utility() { } // prevents instantiation
    public static void Log(string msg) { Console.WriteLine(msg); }
}
```

---

## ✅ Q40. What are Extension Methods in C#? When to use them?

Extension methods allow you to **add methods to an existing class** **without modifying its source code**.

---

### 🧠 Syntax:

```csharp
public static class StringExtensions
{
    public static string RightSubstring(this string str, int length)
    {
        return str.Substring(str.Length - length);
    }
}

// Usage
string result = "HelloWorld".RightSubstring(5); // Output: "World"
```

---

### 📌 Key Rules:

* Must be declared in a **static class**
* Must be a **static method**
* First parameter must use `this` keyword followed by the type you are extending

---

### ✅ When to Use:

* When you **cannot modify** the original class (e.g., .NET base classes like `string`, `DateTime`)
* For **code reuse**, utility methods, or **cleaner syntax**

---

### ✅ Interview One-Liner:

> Extension methods let you **inject new methods** into existing types like `string`, `List<T>` etc., using `this` keyword — useful when you can't modify the original class.

---


Here’s a clean and interview-ready **note for Q41** on Delegates in C#, including a **real-world use case** and a practical example.

---

## ✅ Q41. What is a Delegate in C#? When to use it?

**A delegate is a type-safe function pointer** — it holds a **reference to a method** with a specific signature (return type + parameters).

> You can think of a delegate as a **variable that stores a method**, allowing methods to be passed as parameters, or grouped dynamically at runtime.

---

### 🧠 Syntax:

```csharp
public delegate int Calculator(int a, int b);  // Delegate declaration

public class MathOps
{
    public static int Add(int a, int b) => a + b;
    public static int Mul(int a, int b) => a * b;
}

// Usage
Calculator calc = MathOps.Add;       // Point to Add
calc += MathOps.Mul;                 // Multicast delegate
int result = calc(2, 3);             // Executes both Add and Mul (only last return value retained)
```

---

### 🔄 When to Use Delegates?

✅ Use delegates when:

* You want to **pass a method as an argument**
* You need to **implement callback mechanisms**
* You are working with **event-driven programming**
* You want to **plug behavior** at runtime (strategy pattern)
* You are using **LINQ, async tasks, or lambda expressions** (they internally use delegates)

---

## ✅ Real-World Example: File Processing Strategy

Suppose you're building a **file processor** that applies different operations on file content (e.g., compress, encrypt, etc.). You can pass each processing method using delegates.

```csharp
public delegate void FileProcessor(string filePath);

public class Processor
{
    public static void Compress(string filePath) =>
        Console.WriteLine($"Compressing {filePath}");

    public static void Encrypt(string filePath) =>
        Console.WriteLine($"Encrypting {filePath}");
}

public class FileManager
{
    public void Run(string path, FileProcessor processor)
    {
        // Do some file validation...
        processor(path);  // Call passed-in method
    }
}

// Usage
var manager = new FileManager();
manager.Run("data.txt", Processor.Compress);
manager.Run("data.txt", Processor.Encrypt);
```

---

### ✅ Interview One-Liner:

> A delegate is a type-safe function pointer used to store method references, enabling callbacks, plug-in behavior, and event-driven patterns in C#.

---

## ✅ Q42. What are Multicast Delegates in C#?

A **Multicast Delegate** is a delegate that **can hold references to more than one method** with the **same signature**.
When invoked, it **calls all the methods in the order they were added**.

> ✅ You can think of it as **method chaining** — one delegate triggering a **sequence of methods**.

---

### 🧠 Example:

```csharp
public delegate void Calculator(int a, int b);

public class Operations
{
    public static void Add(int a, int b) =>
        Console.WriteLine($"Add: {a + b}");

    public static void Mul(int a, int b) =>
        Console.WriteLine($"Mul: {a * b}");
}

// Usage
Calculator calc = Operations.Add;
calc += Operations.Mul; // 👈 Multicast delegate (chaining)

calc(3, 4);  
// Output:
// Add: 7
// Mul: 12
```

> ✅ Both methods are executed **in sequence**.

---

### 🔥 Key Points:

* All methods in the delegate chain must have **same signature** (return type + parameters)
* Only the **last method’s return value is retained** (for non-void delegates)
* If one method in the chain throws an exception, **subsequent methods will not be executed**

---

### ✅ When to Use Multicast Delegates?

* Logging to multiple destinations (file + DB + console)
* UI event handling (e.g., click triggers sound + animation)
* Chained processing (e.g., pipelines, validators)

---

### ✅ Interview One-Liner:

> A multicast delegate stores references to multiple methods and invokes them sequentially — useful for event handling and chained operations.

---


Here’s a clean, interview-ready note for **`Action`, `Func`, and `Predicate` delegates in C#**, including syntax, usage, real-world analogies, and one-liners to revise quickly:

---

## ✅ Q43. What are `Action`, `Func`, and `Predicate` delegates in C#?

These are **predefined generic delegates** provided by .NET — used instead of creating custom delegate types.

---

### ✅ 1. `Action` Delegate

**Use when the method returns `void` and takes 0 or more parameters.**

```csharp
Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Harsh");
```

> 🔹 `Action` can take **up to 16 input parameters**, but **returns nothing**.

🧠 **Use Case:** Logging, sending notifications, updating UI.

---

### ✅ 2. `Func` Delegate

**Use when the method returns a value.**
It can take **0 or more input parameters**, but **must return a value** — the last type in angle brackets is always the return type.

```csharp
Func<int, int, int> add = (a, b) => a + b;
int result = add(5, 3);  // Output: 8
```

> 🔹 `Func<T1, T2, ..., TResult>`

🧠 **Use Case:** Calculations, LINQ projections (`Select`, `Where`), data processing.

---

### ✅ 3. `Predicate` Delegate

**A specialized `Func<T, bool>`**
Used when you want to evaluate a **condition** and return `true`/`false`.

```csharp
Predicate<int> isEven = x => x % 2 == 0;
bool result = isEven(4);  // true
```

🧠 **Use Case:** Filtering, search conditions (`Find`, `Exists`, `RemoveAll` in collections).

---

### ✅ Analogy:

* `Action` is like **doing something** (e.g., printing, saving) without expecting a return.
* `Func` is like **asking a question and expecting an answer**.
* `Predicate` is like **asking a yes/no question**.

---

### ✅ Interview One-Liners:

* **Action:** A delegate that points to a method with **void return type**.
* **Func:** A delegate that points to a method with **return type** and optional input parameters.
* **Predicate:** A **special type of Func** that always returns a **bool** and takes **one input**.


---

## ✅ Q43. What are Anonymous Delegates in C#?

An **Anonymous Delegate** allows you to **create a delegate inline without explicitly defining a separate method**.

> It’s useful when the logic is short and used only once — so there's no need to name a method separately.

---

### 🧠 Syntax Example:

```csharp
// Declare delegate
public delegate int Calculator(int a, int b);

// Use anonymous delegate inline
Calculator calc = delegate(int a, int b)
{
    return a + b;
};

Console.WriteLine(calc(3, 4));  // Output: 7
```

✅ No need to create a named method like `Add`.
The method body is **written inline** after `delegate`.

---

### 🔁 When to Use:

* You need **quick logic** without reusing the method elsewhere.
* You want to avoid clutter with multiple small helper methods.
* Useful in **event handling**, **inline callbacks**, and **delegates passed as parameters**.

---

### 🔄 Evolution → Lambda Expressions

Anonymous delegates were introduced in C# 2.0. Later, C# 3.0 introduced **lambda expressions** as a shorter syntax.

```csharp
// Using lambda (recommended now)
Calculator calc = (a, b) => a + b;
```

---

### ✅ Interview One-Liner:

> Anonymous delegates allow you to define method logic inline, without a separate named method — mainly used for short, single-use logic or event handling.

---

### 🔥 Real-world Use Case:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Using anonymous delegate with FindAll
List<int> evens = numbers.FindAll(delegate (int x) {
    return x % 2 == 0;
});
```

✅ Cleaner with lambda, but anonymous delegates help understand the delegate mechanism better.

---

