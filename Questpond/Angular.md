
---

### ✅ **1. What is Angular?**

**Angular is a TypeScript-based UI framework for building dynamic web applications.**

It connects the UI (View) with business logic (Model) using binding code, so any change in model reflects in the view and vice versa.

---

### ✅ **2. AngularJS vs Angular – What’s the difference?**

**AngularJS refers to Angular 1.x using JavaScript, while Angular (2+) is rewritten in TypeScript and offers better performance.**

AngularJS (old) = JavaScript, MVC; Angular (new) = TypeScript, component-based, modular, and more optimized.

---

### ✅ **3. What are directives in Angular?**

**Directives are Angular instructions applied to the DOM to add behavior or manipulate elements.**

Examples include `*ngIf`, `*ngFor`, `[hidden]`, and `[(ngModel)]`.

---

### ✅ **4. Types of directives in Angular?**

**Three types: Structural, Attribute, and Component – remembered as SAC.**


* Structural: `*ngIf`, `*ngFor` (change layout)
* Attribute: `[hidden]`, `ngClass` (change behavior/style)
* Component: Custom elements (`<app-grid>`, etc.)

---

### ✅ **5. What is NPM and the node\_modules folder?**

**NPM is the Node Package Manager that installs project dependencies into the `node_modules` folder.**

For example, `npm install jquery` adds jQuery to the project via this folder.

---

### ✅ **6. What is TypeScript and why do we use it in Angular?**

**TypeScript is a superset of JavaScript that adds type safety, making Angular apps more robust.**

It helps catch errors during development, supports OOP concepts, and is the base language for Angular.

---

### ✅ **7. What is a decorator in Angular?**

**A decorator is a function that adds metadata to classes, telling Angular how to process them.**

Examples: `@Component` for components, `@NgModule` for modules.

---

### ✅ **8. What are annotations or metadata in Angular?**

**They are the same as decorators – used to define class behavior in Angular.**

"Metadata", "Annotations", or "Decorators" are interchangeable terms in Angular context.

---

### ✅ **9. What is a template in Angular?**

**A template defines the HTML view of a component, which can include Angular syntax like `*ngIf`, pipes, etc.**

It can be inline (in the `.ts` file) or external (linked via `templateUrl`).

---

### ✅ **10. Types of data binding in Angular?**

**Four types: Interpolation, Property, Event, and Two-Way binding.**


* Interpolation: `{{ value }}` (Component → View)
* Property: `[value]="val"`
* Event: `(click)="save()"` (View → Component)
* Two-Way: `[(ngModel)]="val"` (Syncs both ways)

---

### ✅ **11. Explain Angular architecture.**


**Angular architecture consists of Template, Component, Module, Binding, Directives, Services, and Dependency Injection.**

1. Template:- The HTML view of Angular.
2. Component:- Binds the View and Model.
3. Modules:- Groups components logically.
4. Bindings :- Defines how view and component communicate.
5. Directive :- Changes the HTML DOM behaviour.
6. Services :- Helps to share common logic across the project.
7. DI :- Dependency injection helps to inject instance across constructor.
These 7 building blocks interact to create a scalable SPA application. (Tip: Draw this during interviews.)

---

### ✅ **12. What is SPA (Single Page Application)?**

**SPA loads the app once and updates content dynamically without full page reloads.**

Only required components/views are loaded, improving performance and user experience.

---

### ✅ **13. How is SPA implemented in Angular?**

**Using Angular Routing – it maps URLs to components without reloading the full page.**

Routes are defined using `RouterModule`, and `<router-outlet>` loads the selected component dynamically.

---

### ✅ **14. How to implement Routing in Angular?**

**Three steps:**

1. **Define routes** – a collection of URL → Component mappings
2. **Add `<router-outlet>`** in the main HTML
3. **Use `routerLink` or `router.navigate()`** for navigation

---

### ✅ **15. What is Lazy Loading in Angular?**

**Lazy Loading means loading modules only when they are needed.**

This improves performance by reducing initial load time.

---

### ✅ **16. How to implement Lazy Loading in Angular?**

**Use `loadChildren` in routes and split the app into feature modules.**

This tells Angular to load a module only when its route is visited.

---

### ✅ **17. What are Services in Angular?**

**Services are reusable classes used to share logic like HTTP calls, validation, etc., across components.**

They promote separation of concerns and code reusability.

---

### ✅ **18. What is Dependency Injection (DI) in Angular?**

**DI is a design pattern where Angular injects required services into components.**

Instead of creating objects with `new`, Angular provides them via constructor injection.

---

### ✅ **19. How to implement Dependency Injection in Angular?**

**Register the service in the `providers` array of the `@NgModule` or `@Component`.**

Angular then injects the service wherever it’s needed via the constructor.

---

### ✅ **20. What are the benefits of Dependency Injection?**

**It promotes loose coupling and easier maintenance by managing object creation centrally.**

Changes in implementation require updates only in one place (providers), not throughout the app.

---

### ✅ **21. Difference between `ng serve` and `ng build`?**

**`ng serve` builds the app in memory for development; `ng build` creates optimized output in `/dist` for deployment.**

Use `ng serve` for fast testing, `ng build` for production-ready builds.

---

### ✅ **22. What does `--prod` flag do in `ng build`?**

**The `--prod` flag enables optimizations like AOT, minification, and tree-shaking for production deployment.**

It results in smaller, faster apps by removing unused code and compressing files.

---
