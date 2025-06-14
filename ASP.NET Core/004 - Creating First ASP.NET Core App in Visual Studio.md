
---

### ✅ **[Lecture 4: Creating First ASP.NET Core App in Visual Studio](https://youtu.be/nuh-MxHLIB0?si=a9JQE7uUlEWPnFxn)**

---

### 1. **Creating a New Project**

* Open **Visual Studio** and click **"Create a new project"**.
* Filter by:

  * **Language:** C#
  * **Project type:** Web
* Choose **ASP.NET Core Empty** template (good for learning from scratch).
* Click **Next**.

---

### 2. **Project Configuration**

* **Project Name:** e.g., `MyFirstApp`
* **Location:** Choose your folder, like `C:\ASPNETCore\`
* **Solution Name:** Keep same as project or change it.
* **Checkbox:**

  * If checked: solution and project files go in the same folder.
  * If unchecked: they go into separate folders. (We leave it unchecked.)
* Click **Next**.

---

### 3. **Framework & Options**

* Select **.NET 7.0** (or latest installed).
* Uncheck:

  * **Configure HTTPS**
  * **Enable Docker**
* Click **Create**

---

### 4. **Understanding the Created Project**

* It creates an **empty ASP.NET Core project** with only one file: `Program.cs`.

---

### 5. **Important Concepts**

#### ⚙️ `Program.cs` Explained:

ASP.NET Core apps **start from this file**, just like a console app.

Since C# 9, you don’t need `Main()` method explicitly—top-level statements are used instead.

```csharp
var builder = WebApplication.CreateBuilder(args); // returns the instance of WebApplication Builder
var app = builder.Build(); // return the instance of WebApplication
app.MapGet("/", () => "Hello World!"); // Defines route
app.Run(); // Runs the app (starts server)
```

---

### 6. **How it Works**

* `CreateBuilder()` → Sets up config, logging, DI, etc.
* `Build()` → Prepares the app to be run.
* `MapGet()` → Maps a **GET route** (here `/`) to return a string.
* `Run()` → Starts the **web server**.

> ✅ Note: Even though it’s a web app, it's **technically a console app** under the hood.

---

### 7. **Running the App**

* When you run it:

  * A **console window** opens → It’s the server.
  * A **browser** opens with `localhost:<port>`, which is your root URL (`/`).
  * You see the response `"Hello World!"`.

---

### 8. **Updating the Response**

* Modify the return string in `MapGet()`:

```csharp
app.MapGet("/", () => "This is my first ASP.NET Core app");
```

* Use **Hot Reload** to reflect changes without restarting.

  * If hot reload doesn’t work, stop and re-run the app.

---

### 9. **What Happens If You Remove `app.Run()`?**

* The server won’t start.
* Console window will show: **Exited with code 0**.
* You won't get any response from the browser because the server didn’t run.

---

### 10. **Key Takeaway**

> ✅ An **ASP.NET Core application is a console application** that hosts a web server and web app using top-level code starting in `Program.cs`.

---

