
---

### ✅ **1. What is Angular?**

**Angular is a TypeScript-based UI framework for building dynamic web applications.**

It binds the HTML UI with Javascript model.

This helps to reduce effort of writing those lengthy lines of code for binding.

Adding to it, it also helps to build SPA by using the concept of routing.

It also supports other features like HTTP, DI, Parent Child Data passing.

---

### ✅ **2. AngularJS vs Angular – What’s the difference?**

**AngularJS refers to Angular 1.x using JavaScript, while Angular (2+) is rewritten in TypeScript and offers better performance.**

AngularJS is controller-based using $scope, while Angular 2+ is component-based where the UI is built using reusable, self-contained components.

AngularJS had no official CLI, while Angular 2+ provides a powerful CLI (Angular CLI) to generate components, services, run builds, and manage the project lifecycle.

---

### ✅ **3. What are directives in Angular?**

**Directives are classes that add additional behavior to elements in your Angular applications.**

Examples include `*ngIf`, `*ngFor`, `[hidden]`, and `[(ngModel)]`.

---

### ✅ **4. Types of directives in Angular?**

**Three types: Structural, Attribute, and Component – remembered as SAC.**

d
* Structural: `*ngIf`, `*ngFor` (change DOM layout by adding and removing elements)
* Attribute: `[hidden]`, `ngClass` (change behavior/style of HTML elements)
* Component: Custom elements (`<app-grid>`, etc.)

---

### ✅ **5. What is NPM and the node\_modules folder?**

**NPM is the Node Package Manager that installs project dependencies into the `node_modules` folder.**

For example, `npm install jquery` adds jQuery to the project via this folder.

---

### ✅ **6. Explain the importance of package.json file in Angular?**

**package.json file contains all project dependencies references.**

So rather than installing one package at a time we can install all package in one go.

---

### ✅ **7. What is TypeScript and why do we use it in Angular?**

**TypeScript is a superset of JavaScript that adds type safety, making Angular apps more robust.**

It helps catch errors during development, supports OOP concepts, and is the base language for Angular.

---

### ✅ **8. Explain importance of Angular CLI?**

**The Angular CLI is a command-line interface tool which allows to scaffold, develop, test, deploy, and maintain Angular applications directly from a command shell.**

---

### ✅ **9. Explain importance of Component and Modules?**

**Component is where we write the binding code.**
**Module is where we group component logically.**

---

### ✅ **10. What is a decorator in Angular?**
**A decorator is a special type of functions, prefixed with the @ symbol, that provide a way to add metadata or modify the behavior of classes, properties, methods, or parameters.**

Examples: `@Component` for components, `@NgModule` for modules.

---

### ✅ **11. What are annotations or metadata in Angular?**

**They are the same as decorators – used to define class behavior in Angular.**

"Metadata", "Annotations", or "Decorators" are interchangeable terms in Angular context.

---

### ✅ **12. What is a template in Angular?**

**A template defines the HTML view of a component.**

It is a combination of regular HTML and angular-specific syntax.

It allows us to do data binding, use pipes and directives.

It can be inline (in the `.ts` file) or external (linked via `templateUrl`).

---

### ✅ **13. Explain data binding and types of data binding in Angular?**

**Data binding defines how the view and component comunicate with each other**

**Four types: Interpolation, Property, Event, and Two-Way binding.**

* Expression / Interpolation: `{{ value }}` (Component → View)
* Property: `[value]="val"`
* Event: `(click)="save()"` (View → Component) (Event from view to component)
* Two-Way: `[(ngModel)]="val"` (Syncs both ways)

---

### ✅ **14. Explain Angular architecture.**


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

### ✅ **15. What is SPA (Single Page Application)?**
**A Single Page Application (SPA) is a type of web application that loads and updates content dynamically without refreshing the entire page.**

---

### ✅ **16. How is SPA implemented in Angular?**

**In Angular, Single Page Applications (SPAs) are implemented using routing.**
**Routing is the collection that maps URLs to components.**
**It helps to define the navigation of angular application.**

Routes are defined using `RouterModule`, and `<router-outlet>` loads the selected component dynamically.

---

### ✅ **17. How to implement Routing in Angular?**

**Three steps:**

1. **Define routes** – a collection of URL → Component mappings
2. **Add `<router-outlet>`** in the main HTML
3. **Use `routerLink` or `router.navigate()`** for navigation

---

### ✅ **18. What is Lazy Loading in Angular?**

**Lazy Loading means loading modules only when they are needed.**

This improves performance by reducing initial load time.

---

### ✅ **19. How to implement Lazy Loading in Angular?**

**Use `loadChildren` in   and split the app into feature modules.**

This tells Angular to load a module only when its route is visited.

---

### ✅ **20 . What are Services in Angular?**

**Angular services are classes that encapsulate logic meant to be shared among different components and modules.**

They promote separation of concerns and code reusability.

---

### ✅ **21. What is Dependency Injection (DI) in Angular?**

**DI is a design pattern where rather than creating object instances within the component using new keyword, Angular injects it via constructor.**

---

### ✅ **22. How to implement Dependency Injection in Angular?**

**Register the service in the `providers` array of the `@NgModule` or `@Component`.**

Angular then injects the service wherever it’s needed via the constructor.

---

### ✅ **23. What are the benefits of Dependency Injection?**

**Dependency Injection helps to decouple class dependencies by managing object creation centrally.**
Changes in implementation require updates only in one place (providers), not throughout the app.

---

### ✅ **24. Difference between `ng serve` and `ng build`?**

**`ng serve` builds the app inmemory for development; `ng build` creates optimized output in `/dist` for deployment.**

Use `ng serve` for fast testing, `ng build` for production-ready builds.

---

### ✅ **25. What does `--prod` flag do in `ng build`?**

**The `--prod` flag enables optimizations like AOT, minification, and tree-shaking for production deployment.**

It results in smaller, faster apps by removing unused code and compressing files.

---
