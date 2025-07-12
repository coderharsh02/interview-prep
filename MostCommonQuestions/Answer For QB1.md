1. **Tell me about yourself**

Sure! I'm Harsh Shah, currently working as an Associate Software Engineer at Radix Software Services in Ahmedabad. I have over 2 years of experience in full-stack development, mainly using ASP.NET, Angular, and SQL Server. My role involves designing APIs, implementing complex business logic, and integrating front-end components using Angular.

I hold a Bachelor's degree in Computer Science Engineering with a CGPA of 9.91, and I’ve also earned the Microsoft Azure Fundamentals (AZ-900) certification. I’m passionate about clean code, scalable projects, and constantly improving my skills.

I’m now looking for new challenges where I can contribute to impactful projects, grow as a developer, and work in a collaborative environment that values learning and innovation.

PPF 
Present - Your current role and responsibilities,
Past    - Your previous experience, education, and achievements, 
Future  - Why you’re excited about this opportunity and how it aligns with your goals.

2. **Tell me about the project you have worked on**

I’ve been working on a full-stack project in the recruitment domain, which acts as a middleware between recruitment agencies and their ATS (Applicant Tracking Systems). It operates in Australia and recently expanded to UK. Traditionally, recruiters manually entered candidate data into their ATS, which was time-consuming and inconsistent. Our goal was to digitalize and streamline this workflow.

We have designed a dynamic form engine that helps to create forms that are completely configurable — with field definitions, validations, and layouts all stored in the database — and vary based on the client’s requirements. Once a candidate fills out the form, the data goes through verification and is then integrated into the client’s ATS using secure APIs, majorly following the OAuth 2.0 Client Credentials flow for authorization.

It also involved generating digital contracts with signature, dynamic report generation and integration with ATS.

A major recent feature was UK background check module, which I worked on with two other team members. This involved integrating with third-party APIs to perform candidate background checks along with candidate onboarding.

Overall, I’ve had end-to-end involvement across backend, frontend, integrations, and deployments.

2. **Project Architecture:**
The architecture follows a layered approach:
- **Presentation Layer (Angular):** Handles UI rendering and user interactions.
- **API Layer (ASP.NET Core Web API):** Exposes endpoints for frontend to interact with.
- **Business Logic Layer (Services):** Contains the core logic of the application.
- **Data Access Layer (Repository with EF Core):** Abstracts DB access and performs CRUD operations.
- **Database Layer (SQL Server):** Stores user data, form structure, and configurations.

3. **Authentication & Authorization:**
Implemented using JWT (JSON Web Token):
- **Authentication** checks if the user is who they say they are, typically by verifying credentials.
- **Authorization** checks what the authenticated user is allowed to do, like accessing specific APIs or UI elements.
JWT contains claims about the user, and it's validated with a secret key in middleware.

4. **Middlewares:**
Yes, I have used middlewares for:
- Logging requests and responses
- Handling exceptions globally
- Validating JWT tokens for secured APIs

5. **HTTP Status Codes:**
- **200 OK:** Success
- **201 Created:** Resource created
- **400 Bad Request:** Client error
- **401 Unauthorized:** Authentication required
- **403 Forbidden:** No permission
- **404 Not Found:** Resource not found
- **500 Internal Server Error:** Server failure

6. **PUT vs PATCH:**
- **PUT** updates the entire resource and replaces it completely.
- **PATCH** applies partial updates to a resource (only some fields).

7. **Design Patterns:**
- **Repository Pattern:** Abstracts database interactions, keeps business logic separate from data access.
- **Clean Architecture:** Focuses on maintainability and testability by separating application layers (Domain, Application, Infrastructure, UI).

8. **Dependency Injection:**
A design pattern to inject dependencies at runtime rather than compile time. Promotes loose coupling and easier testing.

9. **Scoped vs Transient vs Singleton:**
- **Scoped:** One instance per request (API call).
- **Transient:** New instance every time it’s requested.
- **Singleton:** Single instance throughout the application's lifetime.

10. **Singleton Class:**
A class with:
- A private constructor
- A static variable to hold the instance
- A static method/property to access the instance

11. **Types of Constructors:**
- **Default:** No parameters
- **Parameterized:** Accepts parameters
- **Copy Constructor:** Creates a copy of an object
- **Static Constructor:** Initializes static members
- **Private Constructor:** Restricts instantiation

12. **Private Constructor:**
Yes, used in Singleton pattern or when you want to restrict class instantiation (e.g., utility classes).

13. **Threads:**
Yes, threads allow tasks to run concurrently. Useful for background operations (e.g., file IO, network calls) without freezing UI.

14. **Abstract Class vs Interface:**
- **Abstract Class:** Can have method implementations and fields. Inheritance is allowed.
- **Interface:** Only method declarations (prior to C# 8). Multiple inheritance is possible.

15. **Object of Abstract Class:**
No, cannot be instantiated directly.

16. **Object of Abstract Class:**
Create an instance of a subclass that implements all abstract members.

17. **2nd Largest Element in Array:**
```csharp
int SecondLargest(int[] arr) {
    int first = int.MinValue, second = int.MinValue;
    foreach (var num in arr) {
        if (num > first) {
            second = first;
            first = num;
        } else if (num > second && num != first) {
            second = num;
        }
    }
    return second;
}
```

18. **Function vs Stored Procedure:**
- **Function:** Returns a single value, used in SELECT queries, no side-effects
- **Stored Procedure:** Can perform inserts/updates, support transactions, return multiple result sets

19. **Transaction:**
A unit of work that ensures all operations either complete successfully or are all rolled back (ACID).

20. **Primary Key vs Unique Key:**
- **Primary Key:** Unique and non-null, only one per table
- **Unique Key:** Allows NULLs, can be multiple

21. **NULL in Unique Key:**
Yes, multiple NULLs allowed because NULL != NULL

22. **Joins:**
- **INNER JOIN**: Returns matching rows
- **LEFT JOIN**: All from left, matching from right
- **RIGHT JOIN**: All from right, matching from left
- **FULL JOIN**: All from both sides
- **CROSS JOIN**: Cartesian product

23. **Table without Primary Key:**
Yes, but not ideal. Can lead to duplicate and inconsistent data.

24. **Temp Table vs Table Variable:**
- **Temp Table (#):** Supports indexes, persists until session ends
- **Table Variable (@):** Limited scope, in-memory, less overhead

25. **Temp Table in Another Proc:**
Only if the temp table is created outside and accessible in the scope.

26. **Primary Key on Multiple Columns:**
Yes, called a Composite Primary Key

27. **CTE:**
Yes, useful for simplifying complex queries, recursive queries

28. **Entity Framework:**
Yes, using EF Core for ORM

29. **Approach Used:**
Code First with Migrations to generate database schema from models

30. **Scaffolding:**
Yes, used for generating boilerplate code for CRUD operations using EF models

31. **Truncate vs Delete:**
- **Truncate:** Fast, resets identity, no WHERE
- **Delete:** Can use WHERE, logs each row

32. **Find Duplicate Emails:**
```sql
SELECT Email, COUNT(*) 
FROM Employee 
GROUP BY Email 
HAVING COUNT(*) > 1;
```

33. **LINQ:**
Yes, used for querying collections and databases using C#

34. **JWT Token Elements:**
- Header: Algorithm & token type
- Payload: Claims/data
- Signature: Verifies sender and integrity

35. **Angular Data Binding:**
- Interpolation: `{{data}}`
- Property Binding: `[src]="imagePath"`
- Event Binding: `(click)="method()"`
- Two-way Binding: `[(ngModel)]="value"`

36. **Parent to Child / Child to Parent:**
- Parent to Child: `@Input()`
- Child to Parent: `@Output()` and `EventEmitter`

37. **Angular Pipeline:**
Pipes transform data in template (e.g., `{{date | date:'short'}}`), Custom pipes can be created.

38. **Interceptor:**
Used to modify HTTP requests globally (add headers like Authorization, handle errors)

39. **Asynchronous Programming:**
Yes, helps run tasks concurrently without blocking main thread. `async/await` makes it easier.

40. **Polymorphism:**
Ability to use a unified interface for different data types. Supports overriding and overloading.

41. **Overriding in Same Class:**
No, only overloading (same method name, different parameters) is allowed in the same class. Overriding requires inheritance.

