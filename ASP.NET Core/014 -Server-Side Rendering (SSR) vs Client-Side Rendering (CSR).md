
---

### ✅ **Page Rendering in Web Development **Server-Side Rendering (SSR)** vs **Client-Side Rendering (CSR)****

#### 🔷 **What happens when a user makes a request to a server?**

* The user (via browser/client) expects **UI (HTML/CSS)** to be rendered.
* The UI can be **generated** either:

  * On the **server** → Server-Side Rendering (SSR)
  * On the **client** → Client-Side Rendering (CSR)

---

### 🖥️ **Server-Side Rendering (SSR)**

#### ➕ Example Tech: ASP.NET Core MVC, Node.js (with Pug), PHP

#### 🛠 How it works:

1. Client sends request → Server receives it.
2. Server:

   * Fetches data from DB.
   * Uses a **templating engine** (e.g., Razor View Engine).
   * Generates a full HTML page dynamically with data embedded.
3. Server sends back **HTML + CSS + JS** → Browser renders UI.

#### 🧠 Key Points:

* Views are **rendered at server**.
* **Razor view engine** is used in ASP.NET Core MVC.
* This is the approach followed in this course.

---

### 💻 **Client-Side Rendering (CSR)**

#### ➕ Example Tech: Angular, React, Vue (with APIs built in ASP.NET Core, Node.js, etc.)

#### 🛠 How it works:

1. Client loads initial page (often minimal HTML/JS).
2. Makes **API requests** to the server (ASP.NET Core Web API).
3. Server responds with **JSON data**, not HTML.
4. **Client-side JS** (Angular/React/etc.) dynamically builds and renders UI using templates.

#### 🧠 Key Points:

* Views are **rendered at client**.
* Server only sends **data**, not HTML.
* Faster, more interactive UIs but requires JS frameworks.

---

### ⚖️ **SSR vs CSR – Summary Table**

| Feature            | SSR (Server-Side)           | CSR (Client-Side)                         |
| ------------------ | --------------------------- | ----------------------------------------- |
| Rendering Location | Server                      | Client                                    |
| Response Content   | HTML + CSS + JS             | JSON (data only)                          |
| Example            | ASP.NET Core MVC with Razor | ASP.NET Core Web API + Angular/React      |
| Good for           | SEO, simple/static pages    | Rich UIs, SPAs (Single Page Applications) |
| Speed (First Load) | Slower (full HTML load)     | Faster after initial load                 |

---

### 🧩 ASP.NET Core Use Cases:

| Tech Stack                 | Rendering Type    | Description                             |
| -------------------------- | ----------------- | --------------------------------------- |
| **ASP.NET Core MVC**       | Server-Side (SSR) | You build dynamic pages using Razor     |
| **ASP.NET Core Blazor**    | Client-Side (CSR) | UI built using C# instead of JS         |
| **ASP.NET Core + Angular** | CSR               | Web API serves data; Angular renders UI |

---

### 🎯 Conclusion:

* **This course uses ASP.NET Core MVC**, so you’ll focus on **server-side rendering** with Razor views.
* It's crucial to understand both SSR and CSR to choose the right architecture based on the application’s needs.

---
