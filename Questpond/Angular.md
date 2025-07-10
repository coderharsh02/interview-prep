
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

### ✅ **26. Explain ViewChild and ViewChildren?**

**`ViewChild` gets a reference to a single DOM element or component, while `ViewChildren` returns a list of multiple elements or components.**

They are used to access child elements or components from the parent component class.

```ts
@ViewChild('myDiv') divRef!: ElementRef;
@ViewChildren('item') items!: QueryList<ElementRef>;
```

**Example Analogy:**
Think of `ViewChild` as selecting **one item** from the DOM like `document.querySelector`, while `ViewChildren` is like `document.querySelectorAll`.

---


### ✅ **27. Why do we need Template Reference Variables in Angular?**

**Template reference variables are variables defined in the template that allow direct access to DOM elements, directives, or component instances within the HTML.**

They allow us to access properties or invoke methods directly from the template without needing extra logic in the component TypeScript file.

---

### ✅ **28. What is Content Projection in Angular?**

**Content Projection is the process of inserting content from a parent component into a specific location within a child component’s template using the `<ng-content>` tag.**

It allows developers to build reusable and flexible components where the structure is defined in the child, and the content is provided by the parent.


---

### ✅ **29. Explain Content projection Slot?**

**A content projection slot is a named placeholder (`<ng-content select="...">`) in a child component that allows projecting specific parts of the parent content into designated areas.**

This is used when a component has multiple content areas, and you want to control what content goes where.

### ✅ **30. What is ContentChild and ContentChildren?**
**The ContentChild & ContentChildren are decorators, which we use to Query and get the reference to the Projected Content in the DOM.**

 Projected content is the content that this component receives from a parent component.


### ✅ **31. ViewChild vs ViewChildren vs ContentChild vs ContentrChildren?**

**`ViewChild` and `ViewChildren` are used to access elements or child components declared inside the component’s own template.**

**`ContentChild` and `ContentChildren` are used to access projected content passed into the component using `<ng-content>` — typically from the parent."**

---

### ✅ **Example on Content Projection and ContentChild**:

We’ll create a reusable `CardComponent` (child) and use it in a `ParentComponent`, projecting custom content from the parent.

---

### 🔹 **Child Component: `card.component.ts`**

```ts
import { Component, ContentChild, ElementRef, AfterContentInit } from '@angular/core';

@Component({
  selector: 'app-card',
  template: `
    <div class="card">
      <h3>Card Header</h3>
      <ng-content></ng-content>
      <p>Card Footer</p>
    </div>
  `
})
export class CardComponent implements AfterContentInit {
  @ContentChild('projectedContent') content!: ElementRef;

  ngAfterContentInit() {
    console.log('Projected content:', this.content.nativeElement.textContent);
  }
}
```

---

### 🔹 **Parent Component: `parent.component.html`**

```html
<app-card>
  <p #projectedContent>This is projected from parent!</p>
</app-card>
```

---

### ✅ **Explanation:**

* `<ng-content>` inside `CardComponent` marks the spot where parent-provided HTML will be **inserted**.
* The parent passes `<p #projectedContent>` into the `<app-card>`, and it gets rendered inside.
* The child accesses that `<p>` using `@ContentChild('projectedContent')`.

---

### 🧠 Interview Tip:

> Content projection lets us build reusable components where the **HTML structure is fixed**, but **content is customizable** by the parent.

---

### ✅ **32. Explain the importance of Component Lifecycle in Angular**

**The Component Lifecycle helps us hook into key moments like creation, rendering, data updates, and destruction of a component.**

---

### ✅ **Why it's important:**

It lets developers:

* Initialize data when a component loads
* Detect and respond to input changes
* Run cleanup logic (like unsubscribing) when a component is destroyed
* Access the DOM after rendering
* Manage performance and avoid memory leaks

---

### ✅ **33. Explain Events and Sequence of Component Lifecycle in Angular**

**Angular lifecycle events are method hooks that fire in a specific order as the component is created, updated, and destroyed.**

---

### ✅ **Sequence of Lifecycle Events (with explanation):**

| Lifecycle Hook            | When it runs                                              | Use it for...                          |
| ------------------------- | --------------------------------------------------------- | -------------------------------------- |
| `constructor()`           | When component is instantiated                            | Basic initialization, avoid logic here |
| `ngOnChanges()`           | On every change to `@Input()` props                       | React to input value changes           |
| `ngOnInit()`              | After first `ngOnChanges()` (once)                        | API calls, initialization logic        |
| `ngDoCheck()`             | On every change detection run                             | Custom change detection                |
| `ngAfterContentInit()`    | After content projected via `<ng-content>` is initialized | For content projection setup           |
| `ngAfterContentChecked()` | After every check of projected content                    | Respond to content updates             |
| `ngAfterViewInit()`       | After component’s view (template) loads                   | `@ViewChild` DOM access                |
| `ngAfterViewChecked()`    | After every check of component's view                     | Respond to template changes            |
| `ngOnDestroy()`           | Just before component is destroyed                        | Cleanup: unsubscribe, clear timers     |

---

### ✅ **Full Sequence (with flow):**

```ts
constructor()
→ ngOnChanges()
→ ngOnInit()
→ ngDoCheck()
→ ngAfterContentInit()
→ ngAfterContentChecked()
→ ngAfterViewInit()
→ ngAfterViewChecked()
→ [repeated ngDoCheck, ngAfterContentChecked, ngAfterViewChecked on changes]
→ ngOnDestroy() (when component is removed)
```

---


### ✅ **34. Constructor vs ngOnInit() in Angular?**

| **Aspect**                    | **Constructor**                             | **ngOnInit()**                                   |
| ----------------------------- | ------------------------------------------- | ------------------------------------------------ |
| **What it is**                | A TypeScript feature to create the class    | An Angular lifecycle method                      |
| **When it runs**              | When the component is first created         | After Angular sets inputs and adds it to the DOM |
| **DI (Dependency Injection)** | ✅ Used to inject services                   | ✅ Services already injected                      |
| **Input properties**          | ❌ Not safe to access                        | ✅ Inputs are fully available                     |
| **Angular lifecycle**         | Runs before Angular starts change detection | Runs after first change detection                |
| **Common usage**              | Inject services, set default values         | Make API calls, use input data, initialize logic |

---

### 🎯 **One-liner to say in interview:**

> "Constructor is used for class setup and injecting services, but `ngOnInit()` is the right place for initialization logic that depends on input properties or Angular bindings — because it runs after the component is part of the Angular tree."

### ✅ **35. How to make HTTP calls using Angular?**

**We use Angular’s built-in `HttpClient` service from `@angular/common/http` to make HTTP calls like GET, POST, PUT, DELETE, etc.**

---

### 🔹 **Step-by-Step Process:**

1. **Import `HttpClientModule` in AppModule**

```ts
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [HttpClientModule]
})
export class AppModule {}
```

2. **Inject `HttpClient` in your service or component**

```ts
import { HttpClient } from '@angular/common/http';

constructor(private http: HttpClient) {}
```

3. **Make the HTTP call**

```ts
this.http.get('https://api.example.com/users').subscribe(response => {
  console.log(response);
});
```

---

### 🔹 **Common Methods:**

| Method          | Use Case               |
| --------------- | ---------------------- |
| `http.get()`    | Fetch data from server |
| `http.post()`   | Submit new data        |
| `http.put()`    | Update existing data   |
| `http.delete()` | Remove data            |

---

### ✅ **Best Practices (Senior Perspective):**

* Always use a **service** to make HTTP calls (not directly in the component).
* Use **RxJS operators** like `map`, `catchError`, `retry` for better error handling and transformation.
* Handle errors using `.pipe(catchError(...))`
* Consider using **interceptors** for adding auth tokens or logging.

---

### 🧠 **One-liner for Interview:**

> "We use `HttpClient` from `@angular/common/http`, injected via DI, to make HTTP requests in Angular. It returns observables, allowing reactive patterns and proper error handling."

---


### ✅ **36. What is the need of `subscribe()` in Angular?**

**We use `subscribe()` to execute an Observable and receive its data or handle its events. Without `subscribe()`, the Observable won't run.**

---

### 🔹 **Why it's needed:**

Angular's `HttpClient` and many async operations (like `valueChanges` in forms) return **Observables**, which are **lazy** — they don’t do anything until you `subscribe()`.

---

### 🔹 **Use cases of `subscribe()`:**

* Getting data from an API:

```ts
this.http.get('/api/users').subscribe(data => {
  this.users = data;
});
```

* Listening to form changes:

```ts
this.myForm.get('email')?.valueChanges.subscribe(val => {
  console.log('Email changed:', val);
});
```

---

### 🔁 **Analogy:**

Think of an Observable as a **Netflix subscription**. The data (movie) is there, but unless you **subscribe**, you won’t see anything.

---

### ✅ **Interview One-liner:**

> "`subscribe()` is used to start listening to an Observable — it triggers execution and lets us handle the emitted values, errors, or completion."

---

Let me know if you want the difference between `subscribe()` and `async` pipe next!
