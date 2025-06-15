
---

## ✅ **Lecture 12: HTTP Request Methods (Verbs) Overview**

HTTP methods (also called *verbs*) define **what action** we want to perform on the **server**. The most **common 5 HTTP methods** are:

---

### 1. **GET**

* **Purpose**: Retrieve data from the server.
* **Used For**:

  * Fetching HTML, images, CSS, JavaScript.
  * Retrieving JSON data (e.g., list of users).
* **Request Body**: ❌ *Not allowed*
* **Data Passing**: ✅ *Via URL (route parameters or query strings)*

📌 Example:

```http
GET /customers
GET /customers/101
```

---

### 2. **POST**

* **Purpose**: Create a new resource on the server.
* **Used For**:

  * Registering a new user.
  * Adding a new product or blog post.
* **Request Body**: ✅ *Required*
* **Data**: Sent in the request body as JSON/form data.

📌 Example:

```http
POST /customers
Body: { "firstName": "John", "lastName": "Smith" }
```

---

### 3. **PUT**

* **Purpose**: Update an existing resource **completely**.
* **Used For**:

  * Editing user info, updating entire object.
* **Request Body**: ✅ *Required*
* **Must Send**: All fields of the object, even if only one changed.

📌 Example:

```http
PUT /customers/101
Body: { "firstName": "John", "lastName": "Wright", "email": "...", ... }
```

---

### 4. **PATCH**

* **Purpose**: Partially update an existing resource.
* **Used For**:

  * Changing just one or a few properties.
* **Request Body**: ✅ *Required*
* **Send Only**: The field(s) you want to update.

📌 Example:

```http
PATCH /customers/101
Body: { "lastName": "Wright" }
```

---

### 5. **DELETE**

* **Purpose**: Delete a resource from the server.
* **Used For**:

  * Removing a user, product, or post.
* **Request Body**: ❌ *Not required*
* **Uses**: Unique ID (in URL) to identify what to delete.

📌 Example:

```http
DELETE /customers/101
```

👉 **Best Practice**: Always ask for confirmation before sending a delete request (e.g., confirm dialog).

---

### 🔁 Summary Table

| Method | Action         | Request Body | Use Case Example             |
| ------ | -------------- | ------------ | ---------------------------- |
| GET    | Read           | ❌            | View customers list          |
| POST   | Create         | ✅            | Register a new user          |
| PUT    | Full Update    | ✅            | Update all details of a user |
| PATCH  | Partial Update | ✅            | Change only user's last name |
| DELETE | Delete         | ❌            | Remove a customer            |

---
