
---
# OOP Concepts Interview Notes

## 1. Why do we need OOPs?

=> OOP helps us to think in terms of real-world objects.  
Give example regarding hospitals.

---

## 2. What is class and object?

=> A class is a type or a blueprint, and an object is an instance of that class.

---

## 3. What are the important pillars in OOP?

=> Four pillars of OOP:

1. Abstraction (Show only what is necessary)  
2. Encapsulation (Hide Complexity)  
3. Polymorphism (Object can act differently under different conditions)  
4. Inheritance (Parent-Child Relationships)

---

## [4. What is the difference between Abstraction and Encapsulation?](https://youtu.be/1Q4I63-hKcY?si=HtK8NW29EG_jJRMh)

=> Encapsulation implements Abstraction.  
Abstraction happens during the design phase.  
Encapsulation happens during the implementation phase.

**Abstraction:**  
The concept of allowing the user of your class to have access to only what they need. (Concept)

**Encapsulation:**  
The physical code that prevents the user from accessing fields or methods you do not want them to access. (Actual Implementation)

**Good example:**  
If a user is trying to deposit to an account balance.  
Account balances can't be negative or over 100,000, say.  
So your add function has a check.

A user of the class can circumvent these checks by saying `obj.balance = -123;`

This is bad, so we want to use "Abstraction" to allow the user access to only the things we want them to.

So we make balance private, and now the user can only add through YOUR function.  
The act of making the field private and adding a modifier method is "Encapsulation".

So we can say, Encapsulation implements Abstraction.

---

## 5. Explain Inheritance. Explain 'is-a' relationship.

Inheritance defines a parent-child relationship between two classes.  
For example:

```csharp
class Employee 
{
    string name;
    string address;
    bool validateEmployee();
}

class Manager : Employee 
{
    bool validateManager();
}
````

If we create an object of the Manager class, then it can use all the inherited properties
of the Employee class that are public and also the properties of the Manager class.

**Note:** Here, access modifiers play an important role: `public`, `protected`, and `private`

* If a property or method has a `public` access modifier, then it would be accessible both inside and outside the class.
  It can be used by the object as well as inside the child class that inherits the parent class.

* If a property or method has a `protected` access modifier, then it would be accessible only inside the class and not
  accessible to the object of the class. It can be used only inside the class and by the child class that inherits
  the parent class.

* If a property or method has a `private` access modifier, then it would be accessible only inside the class and
  not accessible to the object of the class. The child class that inherits the
  parent class cannot use these properties of the parent class.

---

## 6. Virtual Keyword OR Virtual Methods OR Method Overriding

\=> The `virtual` keyword helps us to define some logic inside the parent class
which can be overridden in the child class.

---

## 7. Difference between none-new and virtual-override (code - `virtual-override-new.cs`)

The `override` modifier may be used on virtual methods and must be used on abstract methods.
This indicates to the compiler to use the last defined implementation of a method.
Even if the method is called on a reference to the base class, it will use the
implementation overriding it.

The `new` modifier instructs the compiler to use your child class implementation instead
of the parent class implementation. Any code that is not referencing your class but
the parent class will use the parent class implementation.

\=> In `none-new` type when we have an object of derived class stored in a base class variable and call the
none-new method on that object, it would call the method of the base class.

While in `virtual-override` type, when we have an object of derived class stored in a base class variable,
calling the `virtual-override` method on that object would call the method of the derived class.

**All combinations of none, virtual, override, new, and abstract:**

| Base Method | Derived Method | Base b = new Derived().Method() |
| ----------- | -------------- | ------------------------------- |
|             |                | B                               |
|             | new            | B                               |
|             | override       | Error                           |
| virtual     |                | B                               |
| virtual     | new            | B                               |
| virtual     | override       | D                               |
| abstract    |                | Error                           |
| abstract    | new            | Error                           |
| abstract    | override       | D                               |

---

## 8. Method Overloading

\=> Method Overloading means same method names with different signatures
in the same class.

```csharp
class Employee 
{
    void Add(string name);
    void Add(string name, string address);
}
```

---

## 9. Method Overloading vs Method Overriding

\=> Method Overloading means having the same method names with different signatures in the same class
or in a parent-child relationship.

While Method Overriding comes into existence when we have a parent-child relationship, where
we have, say, `Add` method in the parent class marked as `virtual`, and in the child class, we may want to
provide different behaviour for the `Add` method. So, we use the `override` keyword and redefine the method
with the same name in the child class with the same signature.

---

## 10. Polymorphism

\=> Poly means many and morph means to change as per situation.
\=> Polymorphism in OOP can be seen as the ability of an object to act differently
under different conditions.

---

## 11. Can we implement Polymorphism without Inheritance?

\=> No, we cannot implement polymorphism without inheritance.

---

## 12. Two kinds of Polymorphism

* Static Polymorphism (Compile-Time Polymorphism) → implemented by Method Overloading
* Dynamic Polymorphism (Runtime Polymorphism) → implemented by Method Overriding

**Why is Method Overriding known as Runtime Polymorphism?**
Because it decides which implemented method to call on the object at runtime.
While in the case of Method Overloading, it is fixed at the time of compilation
which of the overloaded methods would be called. That’s why Method Overloading
helps to achieve static polymorphism.

---

## 13. Operator Overloading

\=> Concept of Polymorphism — here we can reuse same operators like +, -, \* and others
with various functionalities.

For example:
`1 + 1`, `1 + "Shiv"`, `1 + 1.1`
Here, the same + operator accepts various types of arguments and executes different
functions based on what it receives. That's operator overloading.

---

## 14. Custom Operator Overloading

\=> Yes, we can do custom operator overloading. For example, for a class `X`, if we want to
apply the `+` operator on the objects of class `X`, then inside class `X` we can define:

```csharp
public static X operator + (X o1, X o2)
{
    X y = new X();
    // perform some operation using o1 and o2 and return y
    return y;
}
```

---

## 15. What is an abstract class?

\=> Abstract class is a partially defined parent class.

Here, some implementation is defined in the abstract class and the remaining
implementation is left for the child class to implement.

This partially defined class is inherited by normal classes
and they implement the remaining parts of the parent class.

---

## 16. Are abstract methods of an abstract class virtual?

\=> Yes, abstract methods in an abstract class are by default virtual.

---

## 17. Can we create an instance of an abstract class?

\=> No, we cannot create the object or instance of an abstract class
as it is partially defined.

---

## 18. Is it necessary to implement abstract method in child class?

\=> Yes, it is necessary to implement all the abstract methods of the parent class in
the child class, unless the child class itself is an abstract class.

---

## 19. Why simple parent class cannot replace the abstract class?

\=> As simple classes cannot be defined as partially implemented, we cannot
declare abstract methods in a simple class. For that, we need to
use an abstract class.

---

## 20. Interface

\=> Interface is a Contract.
It is a legal binding between the developer who is creating the class and the consumer
who is using the class.

---

## 21. Can we write logic in Interface?

\=> No, we cannot write logic in an Interface. In an interface, you only have pure signatures.

---

## 22. Are interface members public by default?

\=> By default, all the properties and methods of the interface are public.