
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


### ✅ **37. How to handle errors when HTTP fails in Angular?**

**We handle HTTP errors using the `catchError` operator from RxJS inside a `pipe()` before subscribing.**

---

### 🔹 **Basic Pattern:**

```ts
import { catchError } from 'rxjs/operators';
import { of } from 'rxjs';

this.http.get('/api/users')
  .pipe(
    catchError(error => {
      console.error('Error occurred:', error);
      return of([]); // return fallback or empty result
    })
  )
  .subscribe(data => {
    this.users = data;
  });
```

---

### 🔹 **Explanation (Senior-level):**

* `HttpClient` returns an **Observable**, and if the request fails (e.g., 404, 500), it emits an **error**.
* `catchError` lets us **intercept the error** and return a safe fallback, log it, or show UI messages.
* We **must handle errors inside the `pipe()`**, or the Observable chain will break and nothing will emit.

---

### ✅ **Best Practices:**

* Create a **generic error handler** in a service.
* Use `throwError` or `of()` to return error/fallback Observable.
* Display meaningful messages to the user (using a snackbar/toast etc.).

---

### 🧠 **One-liner for Interview:**

> "We use RxJS’s `catchError` inside a `pipe()` to handle HTTP errors gracefully, ensuring the app doesn’t crash and fallback behavior is provided."

---

### ✅ **38. How to pass data between components in Angular?**

**We pass data between components using `@Input()` for parent-to-child and `@Output()` with `EventEmitter` for child-to-parent communication.**

---

### 🔹 **1. Parent → Child using `@Input()`**

* Use when the parent component sends data down to the child.

```ts
// child.component.ts
@Input() title!: string;
```

```html
<!-- parent.component.html -->
<app-child [title]="'Hello from Parent'"></app-child>
```

---

### 🔹 **2. Child → Parent using `@Output()`**

* Use when the child wants to notify the parent.

```ts
// child.component.ts
@Output() notify = new EventEmitter<string>();

sendData() {
  this.notify.emit('Data from child');
}
```

```html
<!-- parent.component.html -->
<app-child (notify)="handleNotification($event)"></app-child>
```

---

### 🔹 **3. Sibling → Sibling using Shared Service**

* Use when two unrelated components need to communicate.
* Shared service uses **RxJS `Subject` or `BehaviorSubject`**.

```ts
// data.service.ts
private msgSource = new Subject<string>();
msg$ = this.msgSource.asObservable();

sendMsg(data: string) {
  this.msgSource.next(data);
}
```

---

### ✅ **Other Ways:**

* Using a global store (NgRx)
* Using Router navigation state
* Using local/session storage for temporary data

---

### 🧠 **One-liner for Interview:**

> "We use `@Input()` and `@Output()` for parent-child data flow, and shared services with RxJS for communication between unrelated components."


### ✅ **39. Explain the importance of `@Input()`, `@Output()` & `EventEmitter` in Angular**

**`@Input()` and `@Output()` with `EventEmitter` are key Angular features that enable structured, unidirectional communication between parent and child components.**

---

### 🔹 **Why They’re Important:**

#### ✅ `@Input()`

* **Allows parent components to pass data to child components.**
* Keeps component tree communication **one-way and predictable**.

```ts
@Input() userName!: string;
```

```html
<app-child [userName]="'Harsh'"></app-child>
```

#### ✅ `@Output()` + `EventEmitter`

* **Allows child components to emit events or data back to the parent.**
* Useful for sending actions (like button clicks) or updated data.

```ts
@Output() userClicked = new EventEmitter<string>();

sendToParent() {
  this.userClicked.emit('clicked');
}
```

```html
<app-child (userClicked)="handleClick($event)"></app-child>
```

---

### 🔄 **Together — They Enable Component Reusability**

* Parent **binds input** → sends configuration/data.
* Child **emits output** → notifies parent when action happens.
* Promotes **clean separation of concerns** and **decouples components**.

---

### ✅ **Analogy:**

Like a walkie-talkie:

* **@Input()** is you receiving instructions.
* **@Output()** + **EventEmitter** is you sending updates back.

---

### 🧠 **Interview One-liner:**

> "`@Input()` lets parents pass data into children, while `@Output()` with `EventEmitter` allows children to notify parents — enabling clean, unidirectional data flow in Angular’s component architecture."


### ✅ **40. How to pass data during routing in Angular?**

**We can pass data during routing using three ways: route parameters, query parameters, and state (navigation extras).**

---

### 🔹 **1. Route Parameters (Required values in URL)**

Use when the data is part of the URL — like IDs.

**Define route:**

```ts
{ path: 'user/:id', component: UserComponent }
```

**Navigate:**

```ts
this.router.navigate(['user', 5]);
```

**Access in target component:**

```ts
this.route.snapshot.paramMap.get('id'); // '5'
```

---

### 🔹 **2. Query Parameters (Optional values in URL)**

Use for filters, search terms, etc.

**Navigate with query:**

```ts
this.router.navigate(['products'], { queryParams: { category: 'books' } });
```

**Access in component:**

```ts
this.route.snapshot.queryParamMap.get('category'); // 'books'
```

---

### 🔹 **3. Navigation Extras (State Object – no URL exposure)**

Use when you want to pass **data securely without showing in the URL**.

**Navigate with state:**

```ts
this.router.navigate(['details'], {
  state: { productId: 10, title: 'Angular Book' }
});
```

**Access in target component:**

```ts
const navData = history.state;
console.log(navData.productId); // 10
```

---

### ✅ **When to Use What?**

| Method           | Use When...                              |
| ---------------- | ---------------------------------------- |
| Route Params     | ID or required value in the URL path     |
| Query Params     | Optional filters/searches (URL visible)  |
| Navigation State | Sensitive or temporary data (not in URL) |

---

### 🧠 **Interview One-liner:**

> "We pass data during routing using route params for required values, query params for optional values, and `state` for secure, URL-free data sharing between components."


### ✅ **41. Is it a good practice to pass data using services in Angular?**

**Yes — using services is a recommended and scalable way to pass data between unrelated components, especially across different levels of the component tree.**

---

### 🔹 **Why it's a Good Practice (When Used Right):**

* Promotes **shared state** across components (e.g., a logged-in user or cart state).
* Decouples components — no direct dependency between them.
* Works well with **RxJS (Subject/BehaviorSubject)** to make the data reactive.
* Helps when:

  * Components are not directly related (like siblings or distant cousins in the component tree).
  * You want **centralized communication** or a **global store** without third-party libraries.

---

### 🧠 Example:

```ts
// shared.service.ts
private userData = new BehaviorSubject<string>('Guest');
user$ = this.userData.asObservable();

updateUser(name: string) {
  this.userData.next(name);
}
```

Now any component can **subscribe to `user$`** and react to changes.

---

### ⚠️ **When NOT to Overuse Services:**

* For parent-child communication, prefer `@Input()` and `@Output()` — it’s clearer and more Angular-idiomatic.
* Avoid creating "God services" — bloated with unrelated data.
* Overusing shared services for temporary state may lead to **tight coupling or hidden dependencies**.

---

### ✅ **Best Practice Summary:**

| Use Case                               | Preferred Approach                  |
| -------------------------------------- | ----------------------------------- |
| Parent-child data flow                 | `@Input()` and `@Output()`          |
| Unrelated or distant components        | Shared service with RxJS            |
| Global state or persistent shared data | Services or state management (NgRx) |

---

### 🎯 **Interview One-liner:**

> "Yes, using a shared service with RxJS is a scalable way to pass data between unrelated components, though for parent-child communication, `@Input()`/`@Output()` is still the cleaner choice."

### ✅ **42. What is the need of Angular Pipes?**

**Angular Pipes are used to transform data directly in the template before displaying it to the user — without modifying the underlying model.**

---

### 🔹 **Why We Need Pipes:**

* To **format data for display** (e.g., date, currency, number).
* To **transform raw values** into readable UI without writing extra logic in the component.
* Keeps templates **clean and readable** by avoiding custom formatting code in the TypeScript file.

---

### 🔹 **Built-in Pipes Examples:**

```html
{{ 1234.567 | number:'1.2-2' }}     <!-- 1,234.57 -->
{{ today | date:'shortDate' }}      <!-- 6/28/25 -->
{{ 0.75 | percent }}                <!-- 75% -->
{{ price | currency:'INR' }}        <!-- ₹1,000.00 -->
```

---

### 🔹 **Custom Pipes:**

When the built-in ones aren't enough, we can create custom pipes using `Pipe` decorator.

```ts
@Pipe({ name: 'capitalize' })
export class CapitalizePipe implements PipeTransform {
  transform(value: string): string {
    return value.charAt(0).toUpperCase() + value.slice(1);
  }
}
```

Use in template:

```html
{{ 'harsh' | capitalize }}  <!-- Harsh -->
```

---

### ✅ **Benefits of Pipes:**

* Declarative formatting in HTML
* Reusable and testable transformation logic
* Keeps business logic out of the view

---

### 🧠 **Interview One-liner:**

> "Angular Pipes help format and transform data in the template for display purposes, keeping the UI clean and avoiding cluttering the component with presentation logic."



### ✅ **43. Can you name some built-in Angular Pipes?**

**Yes — Angular provides several built-in pipes to format data like numbers, dates, strings, and JSON directly in templates.**

---

### 🔹 **Common Built-in Pipes:**

| **Pipe**    | **Purpose**                                    | **Example Usage**                            |
| ----------- | ---------------------------------------------- |--------------------------------------------- |
| `date`      | Formats date values                            | \`{{ today           ] date:'shortDate' }}\` |
| `currency`  | Formats number as currency                     | \`{{ 1000            ] currency:'INR' }}\`   |
| `percent`   | Converts number to percentage                  | \`{{ 0.85            ] percent }}\`          |
| `number`    | Formats plain numbers                          | \`{{ 12345.6789      ] number:'1.1-2' }}\`   |
| `uppercase` | Converts string to uppercase                   | \`{{ 'angular'       ] uppercase }}\`        |
| `lowercase` | Converts string to lowercase                   | \`{{ 'ANGULAR'       ] lowercase }}\`        |
| `titlecase` | Capitalizes first letter of each word          | \`{{ 'angular rocks' ] titlecase }}\`        |
| `slice`     | Returns a subset of a string/array             | \`{{ 'Angular'       ] slice:0:3 }}`→`Ang\`  |
| `json`      | Converts object to JSON string                 | \`{{ myObj           ] json }}\`             |
| `async`     | Unwraps async values like Promises/Observables | \`{{ data\$          ] async }}\`            |

---

### 🧠 **Interview One-liner:**

> "Some commonly used built-in Angular pipes are `date`, `currency`, `percent`, `uppercase`, `lowercase`, `slice`, and `async`, which help in transforming data directly in templates without writing extra logic."


### ✅ **44. How to create custom pipes in Angular?**

**To create a custom pipe in Angular, we use the `@Pipe` decorator and implement the `PipeTransform` interface.**

---

### 🔹 **Step-by-Step:**

1. **Create the Pipe File:**

```bash
ng generate pipe capitalize
```

2. **Implement the Pipe Logic:**

```ts
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'capitalize'  // used in template as | capitalize
})
export class CapitalizePipe implements PipeTransform {
  transform(value: string): string {
    if (!value) return '';
    return value.charAt(0).toUpperCase() + value.slice(1);
  }
}
```

3. **Use in Template:**

```html
<p>{{ 'harsh' | capitalize }}</p> <!-- Output: Harsh -->
```

4. **Declare in Module:**
   Make sure the pipe is declared in your module (usually `AppModule`):

```ts
@NgModule({
  declarations: [CapitalizePipe],
  // ...
})
export class AppModule {}
```

---

### ✅ **Why Use Custom Pipes:**

* To format or transform data in a reusable and readable way.
* Useful for things like trimming, filtering, or translating values directly in the template.

---

### 🧠 **Interview One-liner:**

> "Custom pipes are created using the `@Pipe` decorator and `PipeTransform` interface to format or transform data in templates when built-in pipes aren’t enough."


Sure! Here's a clean and complete **example of a custom pipe** in Angular that accepts **two parameters** — ideal for interview or project demonstration.

---

### ✅ **Custom Pipe Example: Filter Users by Name and City**

### 🔹 **Use Case:**

You want to filter a list of users based on:

* `name` (partial match)
* `city` (partial match)

---

### 🧩 **1. Generate Pipe**

```bash
ng generate pipe userMultiFilter
```

---

### 🧩 **2. Implement Pipe Logic**

```ts
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'userMultiFilter'
})
export class UserMultiFilterPipe implements PipeTransform {
  transform(users: any[], nameFilter: string, cityFilter: string): any[] {
    if (!users) return [];

    return users.filter(user => {
      const nameMatch = nameFilter
        ? user.name.toLowerCase().includes(nameFilter.toLowerCase())
        : true;

      const cityMatch = cityFilter
        ? user.city.toLowerCase().includes(cityFilter.toLowerCase())
        : true;

      return nameMatch && cityMatch;
    });
  }
}
```

---

### 🧩 **3. Declare the Pipe**

In your `AppModule` or relevant feature module:

```ts
@NgModule({
  declarations: [UserMultiFilterPipe],
})
export class AppModule {}
```

---

### 🧩 **4. Use in Component Template**

```html
<!-- Template: app.component.html -->

<input type="text" [(ngModel)]="nameTerm" placeholder="Search by name" />
<input type="text" [(ngModel)]="cityTerm" placeholder="Search by city" />

<ul>
  <li *ngFor="let user of users | userMultiFilter:nameTerm:cityTerm">
    {{ user.name }} - {{ user.city }}
  </li>
</ul>
```

---

### 🧩 **5. Component Example**

```ts
// app.component.ts
export class AppComponent {
  nameTerm = '';
  cityTerm = '';

  users = [
    { name: 'Harsh', city: 'Ahmedabad' },
    { name: 'Aman', city: 'Mumbai' },
    { name: 'Neha', city: 'Delhi' },
    { name: 'Ravi', city: 'Ahmedabad' }
  ];
}
```

---

### 🧠 **Interview Highlight Sentence:**

> "This custom pipe `userMultiFilter` uses two parameters — name and city — to dynamically filter a list of users in the UI. It demonstrates how pipes can take multiple arguments to provide flexible, reusable logic in the template."

Here’s your polished, **interview-ready** version of questions 45–55 — made crisp, technical, and confidently repeatable. I've kept your structure and added senior-level clarity with real-world context where appropriate:

---

### ✅ **45. What's the full form of RxJS?**

**RxJS stands for Reactive Extensions for JavaScript.**
It’s a library that enables reactive programming using observables to work with asynchronous data streams.

---

### ✅ **46. What is the purpose of RxJS?**

**RxJS helps handle asynchronous, event-based, and streaming data in a clean, declarative way.**
It allows transformation, filtering, and composition of data streams from sources like HTTP calls, user inputs, or timers.

---

### ✅ **47. What are Observables and Observers?**

**An Observable represents a data stream; an Observer is a consumer that reacts to the emitted values.**
Think of the Observable as a YouTube channel (producer of content) and the Observer as a subscriber who watches the content.

---

### ✅ **48. Explain the use of `subscribe()` with sample code.**

**`subscribe()` is used to attach an observer to an observable.**
It defines how to handle the emitted values, errors, or completion.

```ts
const obs$ = of(1, 2, 3);
obs$.subscribe({
  next: val => console.log(val),
  error: err => console.error(err),
  complete: () => console.log('Done')
});
```

---

### ✅ **49. How to unsubscribe in RxJS?**

**We unsubscribe to avoid memory leaks and stop listening to the observable.**
You store the subscription and call `.unsubscribe()` when no longer needed.

```ts
const sub = interval(1000).subscribe(val => console.log(val));
setTimeout(() => sub.unsubscribe(), 5000); // Stops after 5 seconds
```

---

### ✅ **50. Explain the concept of RxJS operators with an example.**

**Operators are pure functions that modify or filter observable streams.**
They allow us to transform data before it reaches the subscriber.

#### Example:

```ts
of(2, 4, 6, 8, 10).pipe(
  filter(x => x < 10),
  map(x => x + 2)
).subscribe(x => console.log(x)); // Output: 4, 6, 8, 10
```

Operators create a new observable from the source stream — forming a pipeline of data transformation.

---

### ✅ **51. How to install RxJS?**

**Use npm:**

```bash
npm install rxjs
```

It comes pre-installed with Angular, but this command is used when manually setting up RxJS in a non-Angular project.

---

### ✅ **52. Differentiate between Promise and RxJS Observable.**

| Feature        | Promise      | Observable (RxJS)        |
| -------------- | ------------ | ------------------------ |
| Data Type      | Single value | Multiple values (stream) |
| Cancelable     | ❌ No         | ✅ Yes (unsubscribe)      |
| Lazy Execution | ✅ Yes        | ✅ Yes                    |
| Chaining       | `then()`     | Operators (`pipe()`)     |

**RxJS is suitable for continuous streams, while Promises are best for one-time async operations.**

---

### ✅ **53. Where have you used RxJS in Angular?**

**Primarily in handling HTTP calls, form input streams (debouncing), auto-complete, and reactive state updates.**
I also use RxJS in route guards, polling mechanisms, and component-to-component communication.

---

### ✅ **54. Which operators have you used from RxJS?**

**Commonly used:**

* `map`, `filter`, `tap`, `switchMap`, `mergeMap`
* `debounceTime`, `distinctUntilChanged`
* `take`, `takeUntil`, `delay`, `catchError`
* `from`, `of`, `combineLatest`, `concat`

These help manage async flows, search inputs, retry logic, and combining multiple observables.

---

### ✅ **55. What is Push (Reactive) vs Pull (Imperative) model?**

**Pull (Imperative):** Consumer asks for data when needed. Example: `function getData()`.
**Push (Reactive):** Data is sent automatically when available. Example: `Observable.subscribe()`.

In reactive programming, the producer pushes data to the consumer — forming the **Publisher-Subscriber pattern**, ideal for UI events, WebSockets, and live updates.

---

### ✅ **56. What are Interceptors in Angular?**

**Interceptors are services in Angular that allow you to intercept and modify HTTP requests or responses globally before they reach the server or the component.**

---

### 🔹 **Why We Use Interceptors:**

* To attach **auth tokens** (JWT) to every request.
* To log all requests/responses.
* To handle global **errors** (e.g., unauthorized, 500).
* To show/hide **loader** on API calls.
* To modify request headers or response data consistently.

---

### 🔹 **Example: Adding Authorization Header**

```ts
@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const token = localStorage.getItem('token');
    
    const authReq = req.clone({
      setHeaders: { Authorization: `Bearer ${token}` }
    });

    return next.handle(authReq);
  }
}
```

---

### 🔹 **Registering the Interceptor:**

```ts
providers: [
  {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }
]
```

---

### ✅ **Interview One-liner:**

> "Interceptors in Angular are used to globally modify or inspect HTTP requests/responses — commonly for adding auth tokens, handling errors, or logging network traffic."



### ✅ **57. How to implement Interceptors in Angular?**

**To implement an interceptor in Angular, create a class that implements `HttpInterceptor` and register it using the `HTTP_INTERCEPTORS` token in the providers array.**

---

### 🔹 **Step-by-Step Implementation:**

#### ✅ 1. **Generate Interceptor**

```bash
ng generate interceptor auth
```

This creates: `auth.interceptor.ts`

---

#### ✅ 2. **Implement `HttpInterceptor` Interface**

```ts
import { Injectable } from '@angular/core';
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const token = localStorage.getItem('token');

    if (token) {
      const cloned = req.clone({
        setHeaders: {
          Authorization: `Bearer ${token}`
        }
      });
      return next.handle(cloned);
    }

    return next.handle(req);
  }
}
```

---

#### ✅ 3. **Register the Interceptor in App Module**

```ts
import { HTTP_INTERCEPTORS } from '@angular/common/http';

@NgModule({
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }
  ]
})
export class AppModule {}
```

---

### 🧠 **Key Points:**

* Always use `multi: true` so Angular allows multiple interceptors.
* Interceptors are **global** — they apply to all HTTP calls automatically.
* You can chain multiple interceptors (e.g., logging, error handling, auth).

---

### ✅ **Interview One-liner:**

> "To implement an Angular interceptor, create a service that implements `HttpInterceptor`, override the `intercept()` method, and register it using the `HTTP_INTERCEPTORS` token with `multi: true`."


### ✅ **58. Give some uses of Interceptors in Angular.**

**Interceptors are mainly used to handle cross-cutting concerns related to HTTP requests and responses.**

---

### 🔹 **Common Uses of Angular Interceptors:**

1. **✅ Add Authorization Token (JWT):**
   Automatically attach access tokens to outgoing requests for authenticated APIs.

   ```ts
   req.clone({ setHeaders: { Authorization: `Bearer ${token}` } })
   ```

2. **⚠️ Global Error Handling:**
   Catch and handle HTTP errors like 401 Unauthorized, 404 Not Found, or 500 Internal Server Error in one place.

   ```ts
   return next.handle(req).pipe(
     catchError((error: HttpErrorResponse) => {
       // Show toast, redirect to login, etc.
       return throwError(error);
     })
   );
   ```

3. **📊 Logging Requests/Responses:**
   Useful for debugging, auditing, or monitoring network calls.

   ```ts
   console.log('Request:', req);
   ```

4. **🌀 Show/Hide Global Loading Spinner:**
   Trigger a loader when a request starts and hide it when completed.

   ```ts
   this.loaderService.show(); // before request
   this.loaderService.hide(); // after response
   ```

5. **🧹 Modify or Sanitize Request/Response:**
   Add custom headers, transform request body, or reformat response data.

6. **🔁 Retry Failed Requests:**
   Automatically retry failed requests a specified number of times (e.g., due to network issues).

   ```ts
   return next.handle(req).pipe(retry(2));
   ```

---

### 🧠 **Interview One-liner:**

> "Angular interceptors are used for tasks like attaching auth tokens, global error handling, request logging, showing loaders, and modifying request/response bodies — all without changing individual service calls."



### ✅ **59. Can we provide multiple interceptors in Angular?**

**Yes, Angular allows multiple interceptors by using the `multi: true` property in the provider configuration.**

---

### 🔹 **How it Works:**

* All interceptors are executed in the **order they are provided** (top to bottom).
* They form a **middleware-like chain**, where each one can modify the request or response.

---

### 🔹 **Example: Registering Multiple Interceptors**

```ts
@NgModule({
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,  // Adds token
      multi: true
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderInterceptor,  // Shows loader
      multi: true
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorInterceptor,  // Handles errors
      multi: true
    }
  ]
})
export class AppModule {}
```

---

### 🔹 **Execution Order:**

* **Request:** `AuthInterceptor → LoaderInterceptor → ErrorInterceptor`
* **Response:** `ErrorInterceptor → LoaderInterceptor → AuthInterceptor`

This ensures response handling happens in reverse.

---

### ✅ **Interview One-liner:**

> "Yes, Angular supports multiple interceptors using `multi: true`, and they are executed in the order they are registered — like middleware for HTTP requests and responses."



### ✅ **60. What are the two ways of doing validation in Angular?**

**Angular supports two main types of validation: Template-driven and Reactive Form validation.**

---

### 🔹 **1. Template-driven Validation (Declarative):**

Validation logic is written directly in the HTML using Angular directives like `required`, `minlength`, `pattern`, etc.

#### Example:

```html
<form #userForm="ngForm">
  <input name="email" ngModel required email />
  <div *ngIf="userForm.controls['email']?.errors?.['required']">
    Email is required
  </div>
</form>
```

* Suited for **simple forms**
* Less code, auto-managed by Angular
* Uses `FormsModule`

---

### 🔹 **2. Reactive Form Validation (Programmatic):**

Validation logic is written in TypeScript using `FormControl` and `Validators`.

#### Example:

```ts
this.loginForm = this.fb.group({
  email: ['', [Validators.required, Validators.email]],
});
```

```html
<input formControlName="email" />
<div *ngIf="loginForm.get('email')?.errors?.['required']">
  Email is required
</div>
```

* Ideal for **complex or dynamic forms**
* Gives more control and unit-testability
* Uses `ReactiveFormsModule`

---

### ✅ **Interview One-liner:**

> "Angular supports Template-driven and Reactive form validations — the first is more declarative and simple, while the second offers better control, scalability, and testability for complex forms."



### ✅ **62. In what situations will you use Template-driven vs Reactive Forms?**

**I choose based on form complexity, dynamic behavior, and control requirements.**

---

### 🔹 **I use Template-driven forms when:**

* The form is **simple** and has **few fields**
* I want **quick setup** with minimal code
* No need for dynamic validation or conditional controls
* Example: **Contact forms**, **Newsletter signup**, or **simple login**

#### 🔸 Why?

Because `ngModel` and validation directives handle most logic in the template with minimal TypeScript code.

---

### 🔹 **I use Reactive forms when:**

* The form is **complex**, **large**, or **dynamic**
* I need to **add/remove controls** at runtime
* I want **full programmatic control** over form behavior
* I need to write **unit tests**
* Example: **User registration**, **multi-step forms**, **dynamic questionnaires**, **form arrays**

#### 🔸 Why?

Because `FormGroup`, `FormControl`, and `Validators` let me manage everything in TypeScript, which is cleaner and scalable.

---

### ✅ **Interview One-liner:**

> "For simple forms, I use Template-driven forms due to their ease of setup, but for dynamic, large, or testable forms, I prefer Reactive forms as they provide better control, scalability, and flexibility."



### ✅ **63. Explain Template Reference Variables in Angular.**

**A Template Reference Variable is a way to access a DOM element or Angular component/directive from the HTML template.**

---

### 🔹 **Syntax:**

```html
<input #myInput type="text" />
<button (click)="log(myInput.value)">Log</button>
```

Here, `#myInput` is a **template reference variable** pointing to the `<input>` element.
It allows the component or template to **refer to the DOM node** or directive instance directly.

---

### 🔹 **Where it's used:**

* Accessing DOM element values
* Triggering methods on child components
* Accessing directive APIs (like `ngForm`, `ngModel`)
* Interacting with form controls without using `ViewChild`

---

### 🔹 **Example: Accessing a child component method**

```html
<app-child #childComp></app-child>
<button (click)="childComp.sayHello()">Call Child Method</button>
```

---

### ✅ **Interview One-liner:**

> "Template reference variables allow us to refer to DOM elements, components, or directives directly from the template using the `#variableName` syntax — useful for quick access without code-behind."



### ✅ **64. How do we implement Template-driven forms in Angular?**

**We implement Template-driven forms by using the `FormsModule` and Angular directives like `ngModel` to bind form inputs directly in the HTML template.**

---

### 🔹 **Step-by-Step Implementation:**

#### ✅ 1. **Import `FormsModule` in App Module**

```ts
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [FormsModule]
})
export class AppModule {}
```

---

#### ✅ 2. **Create the Form in HTML**

```html
<form #userForm="ngForm" (ngSubmit)="submitForm(userForm)">
  <input name="username" ngModel required />
  <input name="email" ngModel email />
  <button type="submit">Submit</button>
</form>
```

---

#### ✅ 3. **Access Form Values in Component**

```ts
submitForm(form: NgForm) {
  console.log(form.value);  // { username: '...', email: '...' }
}
```

---

### 🔹 **Features You Can Use:**

* `ngModel`: Binds input to model
* `#formRef="ngForm"`: Creates form reference
* Form validation using HTML attributes: `required`, `minlength`, `pattern`, etc.
* Angular tracks form state using `formRef.valid`, `formRef.touched`, `formRef.dirty`, etc.

---

### ✅ **Interview One-liner:**

> "To implement template-driven forms, we use `FormsModule` and bind form inputs using `ngModel` in the HTML template — suitable for simple forms where logic can be managed in the markup."




### ✅ **65. How to check if overall validation and specific validations are good in Angular (Template-driven)?**

**Use Angular’s form and control state properties like `valid`, `invalid`, `touched`, and `errors` to check overall and field-level validation.**

---

### 🔹 **1. Check Overall Form Validity**

Use `form.valid` to check if the entire form is valid.

```html
<form #userForm="ngForm" (ngSubmit)="submit(userForm)">
  ...
  <button type="submit" [disabled]="!userForm.valid">Submit</button>
</form>
```

---

### 🔹 **2. Check Specific Field Validation**

Each control has its own `errors`, `valid`, `invalid`, `touched`, etc.

```html
<input name="email" ngModel required email #emailRef="ngModel" />

<!-- Show message if required or email format is wrong -->
<div *ngIf="emailRef.invalid && emailRef.touched">
  <div *ngIf="emailRef.errors?.['required']">Email is required.</div>
  <div *ngIf="emailRef.errors?.['email']">Enter a valid email.</div>
</div>
```

---

### 🔹 **3. In TypeScript (If needed)**

```ts
submit(form: NgForm) {
  if (form.valid) {
    console.log('Form is valid', form.value);
  } else {
    console.log('Form is invalid');
  }
}
```

---

### ✅ **Interview One-liner:**

> "To check overall and specific validations in Angular forms, we use the `valid`, `invalid`, and `errors` properties on the form and form controls, combined with user interaction states like `touched`."



### ✅ **66. How do we implement Reactive Forms in Angular?**

**We implement Reactive Forms using the `FormGroup`, `FormControl`, and `Validators` classes, and by importing the `ReactiveFormsModule`.**

---

### 🔹 **Step-by-Step Implementation:**

#### ✅ 1. **Import `ReactiveFormsModule`**

In your `AppModule`:

```ts
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [ReactiveFormsModule]
})
export class AppModule {}
```

---

#### ✅ 2. **Create the Form in the Component (TS)**

```ts
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({...})
export class LoginComponent {
  loginForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  submit() {
    if (this.loginForm.valid) {
      console.log(this.loginForm.value);
    }
  }
}
```

---

#### ✅ 3. **Bind the Form in HTML**

```html
<form [formGroup]="loginForm" (ngSubmit)="submit()">
  <input formControlName="email" placeholder="Email" />
  <div *ngIf="loginForm.get('email')?.errors?.['required']">Email is required</div>

  <input formControlName="password" type="password" placeholder="Password" />
  <div *ngIf="loginForm.get('password')?.errors?.['minlength']">
    Password must be at least 6 characters
  </div>

  <button type="submit" [disabled]="loginForm.invalid">Login</button>
</form>
```

---

### 🔹 **What Reactive Forms Give You:**

* Full control over form structure and validation
* Dynamic addition/removal of form controls
* Easier to unit test
* Ideal for complex forms

---

### ✅ **Interview One-liner:**

> "Reactive forms are created in TypeScript using `FormGroup`, `FormControl`, and `Validators`, giving full programmatic control over structure, validation, and dynamic behavior."



### ✅ **67. How can we implement composite validations in Angular Reactive Forms?**

**We implement composite (or multiple) validations by passing an array of validators to a form control.**

---

### 🔹 **Example: Applying Required + MinLength + Custom Validator**

```ts
this.form = this.fb.group({
  username: ['', [
    Validators.required,
    Validators.minLength(5),
    this.noSpecialCharsValidator
  ]]
});
```

---

### 🔹 **Custom Validator Example**

```ts
noSpecialCharsValidator(control: AbstractControl): ValidationErrors | null {
  const hasSpecialChars = /[^a-zA-Z0-9]/.test(control.value);
  return hasSpecialChars ? { specialChars: true } : null;
}
```

---

### 🔹 **HTML to Show Errors**

```html
<input formControlName="username" />
<div *ngIf="form.get('username')?.errors?.['required']">Username is required.</div>
<div *ngIf="form.get('username')?.errors?.['minlength']">Minimum 5 characters.</div>
<div *ngIf="form.get('username')?.errors?.['specialChars']">No special characters allowed.</div>
```

---

### 🔹 **For Template-Driven Forms**

Use multiple built-in attributes:

```html
<input name="username" ngModel required minlength="5" pattern="^[a-zA-Z0-9]*$" />
```

---

### ✅ **Interview One-liner:**

> "We apply composite validations in Reactive Forms by passing multiple validators (built-in or custom) as an array to a form control — this helps enforce multiple rules on a single field."



### ✅ **68. How to create dynamic validation in Angular Reactive Forms?**

**We create dynamic validation by adding, removing, or updating validators at runtime using `setValidators()` and `updateValueAndValidity()`.**

---

### 🔹 **Example: Set Validator Based on User Selection**

#### ✅ Component TS:

```ts
this.form = this.fb.group({
  email: [''],
  contactMethod: ['email']
});

this.form.get('contactMethod')?.valueChanges.subscribe(method => {
  const emailControl = this.form.get('email');

  if (method === 'email') {
    emailControl?.setValidators([Validators.required, Validators.email]);
  } else {
    emailControl?.clearValidators();
  }

  emailControl?.updateValueAndValidity(); // important!
});
```

---

### 🔹 **Explanation:**

* `setValidators()` is used to assign validators dynamically.
* `clearValidators()` removes existing ones.
* `updateValueAndValidity()` **must be called** to apply changes immediately.

---

### 🔹 **Use Cases:**

* Show/require fields conditionally
* Apply validators based on user roles, checkbox, or dropdown
* Switch between validation strategies (e.g. mobile vs email)

---

### ✅ **Interview One-liner:**

> "We use `setValidators()` and `updateValueAndValidity()` to apply or change validation rules dynamically at runtime based on user input or other conditions."


### ✅ **69. Can you talk about some inbuilt validators in Angular?**

**Yes, Angular provides built-in validators through the `Validators` class to handle common validation scenarios.**

---

### 🔹 **Commonly Used Inbuilt Validators:**

| Validator                   | Description                      | Example                        |
| --------------------------- | -------------------------------- | ------------------------------ |
| `Validators.required`       | Field must not be empty          | `Validators.required`          |
| `Validators.minLength(n)`   | Minimum number of characters     | `Validators.minLength(5)`      |
| `Validators.maxLength(n)`   | Maximum number of characters     | `Validators.maxLength(10)`     |
| `Validators.email`          | Validates standard email format  | `Validators.email`             |
| `Validators.pattern(regex)` | Validates against a custom regex | `Validators.pattern('[0-9]+')` |
| `Validators.nullValidator`  | Always returns null (no error)   | Useful for conditional logic   |

---

### 🔹 **Usage Example (Reactive Form):**

```ts
this.form = this.fb.group({
  email: ['', [Validators.required, Validators.email]],
  password: ['', [Validators.required, Validators.minLength(6)]],
  age: ['', [Validators.pattern('^[0-9]+$')]]
});
```

---

### 🔹 **HTML Error Display:**

```html
<input formControlName="email" />
<div *ngIf="form.get('email')?.errors?.['required']">Email is required.</div>
<div *ngIf="form.get('email')?.errors?.['email']">Invalid email format.</div>
```

---

### ✅ **Interview One-liner:**

> "Angular provides built-in validators like `required`, `email`, `minLength`, and `pattern` to handle common form validation rules easily using the `Validators` class."



### ✅ **70. How can you create your own custom validator in Angular?**

**In Angular, you can create a custom validator by writing a function that takes a `FormControl` and returns a validation error object or `null`.**

---

### 🔹 **Step-by-Step: Synchronous Custom Validator**

#### ✅ 1. **Create the Validator Function**

```ts
import { AbstractControl, ValidationErrors } from '@angular/forms';

export function noSpecialChars(control: AbstractControl): ValidationErrors | null {
  const value = control.value;
  const hasSpecial = /[^a-zA-Z0-9]/.test(value);
  return hasSpecial ? { specialCharsNotAllowed: true } : null;
}
```

---

#### ✅ 2. **Use in Reactive Form**

```ts
this.form = this.fb.group({
  username: ['', [Validators.required, noSpecialChars]]
});
```

---

#### ✅ 3. **Display Error in Template**

```html
<input formControlName="username" />
<div *ngIf="form.get('username')?.errors?.['specialCharsNotAllowed']">
  Special characters are not allowed.
</div>
```

---

### 🔹 **What Makes It “Custom”?**

You define the rule — Angular just needs a function that returns:

* `null` → valid
* `{ errorName: true }` → invalid

---

### ✅ **Interview One-liner:**

> "A custom validator in Angular is a function that takes a control and returns a validation error object or null — useful when built-in validators don't meet specific business rules."



### ✅ **71. Can we implement Angular validators without a `<form>` tag?**

**Yes, Angular validators can be applied to individual `FormControl`s without using a `<form>` tag.**

---

### 🔹 **Reactive Forms Without `<form>` Example:**

You can bind directly to a control using `[formControl]`:

```ts
// Component.ts
nameControl = new FormControl('', [Validators.required, Validators.minLength(3)]);
```

```html
<!-- No <form> tag -->
<input [formControl]="nameControl" placeholder="Enter name" />
<div *ngIf="nameControl.invalid && nameControl.touched">
  <div *ngIf="nameControl.errors?.['required']">Name is required.</div>
  <div *ngIf="nameControl.errors?.['minlength']">Minimum 3 characters required.</div>
</div>
```

---

### 🔹 **Why It Works:**

* Validators are attached to the control (`FormControl`) itself, not to the `<form>` tag.
* The `<form>` element is just a container—it’s not required for validation to function.
* This approach is useful for standalone inputs or simpler UIs.

---

### ✅ **Interview One-liner:**

> "Yes, validators in Angular work directly with `FormControl`s and don't require a `<form>` tag — making them usable even on standalone input fields."



### ✅ **72. What is `[ngModelOptions]="{standalone: true}"` in Angular?**

**`[ngModelOptions]="{standalone: true}"` tells Angular that the `ngModel` should not be part of the parent `FormGroup`.**

---

### 🔹 **Why Is This Needed?**

In **Reactive Forms**, when you use `ngModel` inside a form that uses `FormGroup`, Angular expects every `ngModel` field to be part of that group.

If not, it throws an error:

> *"ngModel cannot be used to register form controls with a parent formGroup directive."*

To **bypass** this error and still use `ngModel`, you make it **standalone**.

---

### 🔹 **Usage Example:**

```html
<form [formGroup]="userForm">
  <input formControlName="name" />

  <!-- This field is NOT part of the FormGroup -->
  <input [(ngModel)]="city" [ngModelOptions]="{standalone: true}" />
</form>
```

Here, `name` is managed by Reactive Forms, while `city` is bound using `ngModel` (template-driven), but **not registered** with the form group.

---

### 🔹 **When to Use:**

* Mixing **template-driven binding** in **reactive forms**
* Using **`ngModel`** in components that are mostly **Reactive**
* Migrating forms or for quick one-off bindings

---

### ✅ **Interview One-liner:**

> "`[ngModelOptions]='{standalone: true}'` is used to keep an `ngModel` control independent from a parent `FormGroup`, avoiding conflicts in mixed form scenarios."

