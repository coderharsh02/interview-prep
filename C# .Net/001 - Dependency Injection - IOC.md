1. What is need of DI ?

DI is a methodology where in rather than the caller creating the instance its injected by some framework or some other mechanism.

2. Explain IOC (Inversion Of Control).

Inversion control is a principle where we say focus on main work and other tasks delegate to someone else.

By using DI we are implementing Inversion of Control principle, here consider a controller its main task is to serve the request, it would delegate any unnecessay task to someone else.

3. What is the benifit of DI?
DI helps to implement decoupled architecture where you can change at one place and changes are reflected at many places.

4. Scoped vs Transient vs Singleton?

Scoped, Transient and Singleton define the lifetime of the Dependency injected object.

Singleton   -   Only one instace is created for the whole web application

Scoped      -   For every new request new instance will be injected
            -   In the same request if we DI multiple times same instance is injected

Transient   -   For every new request new instance will be injected
            -   In the same request if we DI multiple times new - new instance will be injected


5.  When to use what?

Singleton - Caching, Shared Services, HitCounter

Scoped - Most of the time we use scoped, Repository for same transaction, business objects

Transient - Instances should not affect each other like different transaction, thread safety as objects are different instances, same object asked mutiple times in the constructor
