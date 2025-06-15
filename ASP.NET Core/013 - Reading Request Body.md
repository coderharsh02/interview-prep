
---

## ✅ **Lecture 13: Reading Request Body in ASP.NET Core**

In this lecture, we learn how to **read the request body** from an ASP.NET Core application. Since browsers by default only allow **GET requests** without a webpage (like a form), we use **Postman**, a tool that lets us simulate various types of HTTP requests including **POST**, **PUT**, and more.

---

### 🛠️ **Why Use Postman?**

* Browsers can’t send POST requests directly without a webpage.
* Postman allows:

  * Sending requests of any HTTP method.
  * Adding custom **headers**, **body**, and **authorization**.
  * Selecting different **body formats** (raw, JSON, XML, form data, etc.).

---

### 📦 **Reading HTTP Method and Request Body**

Inside the middleware, we:

1. **Read HTTP method**:

   ```csharp
   var method = context.Request.Method;
   ```

2. Based on the method (GET or POST), we branch logic.

3. **Read request body as a stream**:

   ```csharp
   using var reader = new StreamReader(context.Request.Body);
   string data = await reader.ReadToEndAsync();
   ```

4. We return the data in the response:

   ```csharp
   await context.Response.WriteAsync("Request body contains " + data);
   ```

---

### 🔍 **Example of Reading POST Data**

In Postman, if you send:

```text
demo text
```

You will receive:

```text
Request body contains demo text
```

---

### 🔄 **Sending Query-Like Data in Body**

Instead of plain text, if you send:

```
id=101&name=iPhone&name=Samsung
```

It is treated as a **string**, not a dictionary. So to convert:

---

### 📖 **Parsing Query String Manually**

We use:

```csharp
using Microsoft.AspNetCore.WebUtilities;
var dict = QueryHelpers.ParseQuery(data);
```

* This returns a `Dictionary<string, StringValues>`, because keys like `name` can have **multiple values**.

* To use:

  ```csharp
  if (dict.ContainsKey("id"))
      string id = dict["id"];

  if (dict.ContainsKey("name"))
      string name = dict["name"][0]; // First value
  ```

* You can loop through `StringValues` if you want to access all values.

---

### 📚 **Why Learn This Way?**

* This method shows how request data is **manually read and parsed**, which is foundational.
* However, **in real-world ASP.NET Core MVC apps**, we use **Model Binding** to automatically bind request data to objects, making the process much simpler.

---

### ✅ **Conclusion**

* Learned how to use Postman for testing POST requests.
* Read raw request body using `StreamReader`.
* Converted URL-encoded data in body into a dictionary using `QueryHelpers.ParseQuery()`.
* Understood the difference between foundational and real-world approaches (manual reading vs model binding).

---
