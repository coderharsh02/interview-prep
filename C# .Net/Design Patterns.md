1. Which design pattern have you used in your projects?

5 patterns

1. Repository Pattern           Non-Gof
2. Unit of Work                 Non-Gof
3. Singleton                    Gof
4. CQRS                         Non-Gof
5. Factory Pattern              Gof


Try to answer it as NUP 

natural 
usage 
project based


We use the Repository Pattern to abstract the data access layer.
Instead of writing repetitive code for each entity, we use a Generic Repository, where all basic operations like Add, Update, GetAll are generalized for any entity.

Then, to manage multiple repositories together and ensure transactional safety, we use a Unit of Work (UOW).
It acts like a single transaction boundary — so if multiple changes happen, either all succeed, or all rollback together.

This keeps the system clean, testable, and follows the Single Responsibility Principle!

# 📖 Expanded Answer:

---

**"We use the Repository Pattern to abstract the data access layer."**

👉 In a typical application, if every part of the code directly talks to Entity Framework (or database queries), it becomes hard to manage, test, and maintain.  
The **Repository Pattern** provides a centralized place to handle data access logic for an entity — like fetching, inserting, updating records — without exposing the actual database logic to the rest of the application.  
This keeps our code cleaner and focused.

---

**"Instead of writing repetitive code for each entity, we use a Generic Repository."**

👉 If we manually create a repository for every entity like `StudentRepository`, `TeacherRepository`, `CourseRepository` — and they all have the same methods (`GetAll`, `GetById`, `Add`, `Update`, `Delete`) — it's a lot of duplicate code.  
Using a **Generic Repository**, we write all these methods **once** using Generics (`TEntity`) and reuse them for any entity.  
This follows the **DRY (Don't Repeat Yourself)** principle and reduces maintenance overhead.

---

**"Then, to manage multiple repositories together and ensure transactional safety, we use a Unit of Work (UOW)."**

👉 In real-world scenarios, an operation often involves **multiple entities**.  
For example, if we enroll a student in a course, we might need to update both `Student` and `Enrollment` tables.  
Here, **Unit of Work** acts like a manager that coordinates multiple repository operations together.  
It keeps track of changes and commits them in a **single transaction**.  
If anything fails during the operation, it rolls back all changes — ensuring **data consistency**.

---

**"It acts like a single transaction boundary — so if multiple changes happen, either all succeed, or all rollback together."**

👉 This is critical for maintaining **atomicity** in database operations — especially in financial, inventory, or any sensitive systems.

---

**"This keeps the system clean, testable, and follows the Single Responsibility Principle (SRP)."**

👉 Because:
- The **repository** is only responsible for **data access**.
- The **Unit of Work** is responsible for **transaction management**.
- The **services** handle **business logic**.

This clear separation makes the code easier to **test** (mock repositories/UoW in unit tests) and **scale** (adding new entities becomes much easier).

---

# 🧠 So summarized:
| Concept | Key Points |
|:--|:--|
| **Repository** | Abstracts database operations for one entity |
| **Generic Repository** | Reuses common operations for all entities |
| **Unit of Work** | Manages multiple repositories in a single transaction |
| **Benefits** | Clean, Testable, DRY, SRP followed, Transaction safe |

---

# ✅ Ready-To-Say Final Version

> "We use the Repository Pattern to abstract the data access layer, ensuring the rest of the app isn't directly dependent on database logic.  
> Instead of duplicating basic CRUD methods for every entity, we implement a Generic Repository to generalize them across entities.  
> When operations span multiple repositories, we manage them through a Unit of Work, which maintains a single transaction boundary — either all operations succeed together or all rollback.  
> This design keeps the system clean, testable, transactional safe, and follows SOLID principles like Single Responsibility."


SchoolManagementSystem/
│
├── Controllers/
│    ├── StudentsController.cs
│    ├── TeachersController.cs
│    └── CoursesController.cs
│
├── Services/
│    ├── IStudentService.cs
│    ├── StudentService.cs
│    ├── ITeacherService.cs
│    ├── TeacherService.cs
│    └── ICourseService.cs
│    └── CourseService.cs
│
├── Repositories/
│    ├── IRepository.cs
│    ├── Repository.cs
│    ├── IUnitOfWork.cs
│    └── UnitOfWork.cs
│
├── Entities/
│    ├── Student.cs
│    ├── Teacher.cs
│    ├── Course.cs
│    └── Enrollment.cs
│
├── Data/
│    └── AppDbContext.cs
│
├── Program.cs
└── appsettings.json



Repository Pattern

1. Explain Repository Pattern 
- It helps to abstract and centralize the data access logic thus providing a clean and consistent interface for CRUD operation on models
- It helps to create a higher level of abstraction over the data access layer

            (Abstraction)
App  ------> Repository  ------>  Sql Server, Ado.net, Oracle, File, Cloud

- Data Access Layer (DAL) - focuses on technical details of data access like how to connect to database, etc
- Repository patters provides a higher level of abstraction over DAL.



2. Generic Repository Pattern 
- It is an extension to repository pattern. 
- Rather than creating seperate interfaces / classes for each entity, you can just create a generic interface / class for all entities.

3. UOW (Unit of Work)
- It helps to abstract / implement transactions in Repository/

4. Do we need Repository Pattern if using Entity Framework.
-  No, you don't strictly need the Repository Pattern with EF, but it can provide structure, flexibility, and benefits in larger applications.
-  It helps to do looke coupling.
-  Repository Pattern helps to achieve abstraction over hetergenious data sources like, files, http (rest, api, cloud service) or databases
-  Entity Framework or ADO.NET provides abstraction over heterogenous RDBS

5. Did you do Unit Testing With Repository?
6. How does Repository Pattern make Unit testing easy?
7. How can we do mock testing with Repository?

- All above flavor of question stresses the importance of Unit testing and moc testing in repository.
Interviewer would like to know that do you understand the importance of unit testing in repository.


Singleton Pattern (Over used/discussed/talked)
(Static Keyword / Private Constructor)

1. Explain Singleton Pattern adn the use of the same?
2. Can we use static class rather than using a private constructor?
3. Static vs Singleton Pattern?
4. How did you implement thread safety in Singleton?
5. What is double null check in singleton, can we get rid of it?
6. Can singleton pattern code be made easy with Lazy keyword?


CQRS (Command Query Responsibilty Segregation) (Non-Gof)
(Microservices Architecture)

1. Seperate Classes for Insert, Update, Delete, Read
2. Single Responsibilty Model
3. Benifits
    - Clean Code
    - Performance

Factory Pattern

1. Why do we need Factory Pattern?
2. What is the implication of new keyword?
3. Factory pattern halps for loose coupling, Explain?
4. What is DI and IOC?
5. the real factory pattern?

Factory Pattern helps in centralizing the object creation this creating a loosely copuled architecture.
Changes at one place and it reflects to many places easily

# 1️⃣ **Why do we need Factory Pattern?**

**Answer:**

> "**Factory Pattern** is needed when the creation of objects needs to be **dynamic**, **abstracted**, or **centralized**.  
> Instead of writing `new` everywhere and tightly coupling our code with concrete classes, we delegate object creation to a Factory.  
> This promotes **loose coupling**, **single responsibility**, and **easy extension** when new types are introduced."

---
# 2️⃣ **What is the implication of `new` keyword?**

**Answer:**

> "**Using `new` keyword** directly inside business logic causes **tight coupling**.  
> If you `new` up classes yourself, your code becomes **dependent** on specific concrete implementations.  
> It becomes **harder to change**, **harder to test**, and **harder to extend** because you can't easily swap implementations."

(👉 that's why **Factory Pattern** or **Dependency Injection** is used — to avoid `new` keyword directly.)

---
# 3️⃣ **Factory pattern helps with loose coupling, Explain?**

**Answer:**

> "**Factory Pattern** removes the responsibility of object creation from business logic.  
> Instead of hardcoding `new SomeClass()`, we call the Factory.  
> The calling code depends only on **abstractions** (interfaces), not on concrete classes.  
> This makes the system **loosely coupled**, **open to extension**, and **easy to unit test**."

Example:
```csharp
var paymentService = paymentFactory.GetPaymentService("Stripe");
paymentService.Pay();
```
No `new StripeService()` — **Loose Coupling** achieved ✅

---
# 4️⃣ **What is DI and IoC?**

**Answer:**

✅ **Dependency Injection (DI):**

> "**Dependency Injection** is a design pattern where an object's dependencies are **provided externally** (injected) rather than the object creating them itself.  
> It helps in building **loosely coupled**, **testable**, and **maintainable** applications."

✅ **Inversion of Control (IoC):**

> "**Inversion of Control** is the broader principle behind DI.  
> It means the **control of object creation and dependency management is inverted** from the class itself to a container or framework."

✅ **Simple way to remember:**
- **IoC** = overall principle (handing over control)
- **DI** = one way of achieving IoC (injecting dependencies)

---
# 5️⃣ **What is the real Factory Pattern?**

**Answer:**

> "**Factory Pattern** is a **creational design pattern** that provides an **interface** or **method** to **create objects** in a **superclass**, but **allows subclasses to alter the type of objects** that will be created.  
> It abstracts and encapsulates the object creation process."

✅ **Factory Method** (one object at a time)  
✅ **Abstract Factory** (family of related objects)

Example (basic Factory):

```csharp
public class PaymentFactory
{
    public static IPaymentService Create(string type)
    {
        return type switch
        {
            "Stripe" => new StripePaymentService(),
            "PayPal" => new PayPalPaymentService(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}
```

---
# ✨ Quick way to answer in interview:

- **Factory Pattern**: Used when object creation should be **abstracted** and **centralized**.
- **Avoid `new` keyword** inside business logic.
- **Factory helps loose coupling** by hiding concrete class dependencies.
- **DI** is a way to **inject dependencies**, and **IoC** is the **principle** behind DI.
- **Real Factory Pattern** provides **object creation abstraction** with extension support.