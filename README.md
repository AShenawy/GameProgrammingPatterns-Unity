# GameDesignPatterns

## CodeMonkey Team Members
 - AbdelSalam Megahed
 - Ahmed ElShenawy
 - Alper Üste
 - Syeda Ghazal

## Language & Game Engine Used 
All patterns were implemented in C# on the Unity 2019.2 game engine.

## Patterns:
 - ByteCode
 - Component   
 - Subclasss Sandbox
 - Service Locator
 - Dirty Flag
 - Event Queue


## ByteCode:
Bytecode is a Behavioural Pattern, the objective of patterns in this group is to quickly describe and refine a large number of behaviour. You develop your own programming language called bytecode. 
This is especially useful if you want your users to modify the game because bytecode can't accidentally reach strange parts of the game engine and it controls how much memory it uses.
When to use Bytecode pattern in your game
It should be used when your game has a lot of different behaviours and the language you are programming in is:
Too low-level, making it tedious or error-prone to program in.
It has slow compile times
 


## Component:
Component pattern objective is allowing a single entity to span several domains with no coupling the domains to each other. In short, components are isolated functionalities that can be attached to an object to offer that functionality to that particular object. That way, when an object requires a definite kind of functionality, you just insert the related component.
When to use Component pattern:
This pattern should be used when you want to describe a variety of objects that share different capabilities. And, when you have a class that touches many domains which you want to keep decoupled from each other.


## Subclass Sandbox:
The Subclass Sandbox pattern is generally quite simple, where code only needs to be changed in the base class, while all subclasses shouldn't have to be changed so the base class has to be able to give all of the operations a derived class needs to execute. If this pattern used well, it can direct to huge reduction in code repetition.
When to use Subclass Sandbox pattern:
This pattern should be used when you have a base class with different derived classes and you want to reduce coupling among those derived classes and the rest of the program.

## Service Locator:
Service locator pattern provides a way of reducing coupling between classes and their dependencies by encapsulating the process involved in obtaining a dependent service.
When to use Service Locator pattern:
The Service Locator pattern is a good option when you would like to decouple your classes from their dependencies but with minimum change in your source code. And when you would want to cut off the dependencies and especially when these dependencies are not identified at compile time.


## Dirty Flag:
A set of primary data changes over time. A set of derived data is determined from this using some expensive process. A “dirty” flag tracks when the derived data is out of sync with the primary data. It is set when the primary data changes. If the flag is set when the derived data is needed, then it is reprocessed and the flag is cleared. Otherwise, the previous cached derived data is used.
When to use Dirty Flag pattern in your game
The primary data has to change more often than the derived data is used.
It should be hard to update incrementally.

## Event Queue:
A queue stores a series of notifications or requests in first-in, first-out order. Sending a notification enqueues the request and returns. The request processor then processes items from the queue at a later time. Requests can be handled directly or routed to interested parties. This decouples the sender from the receiver both statically and in time.
When to use Event Queue pattern in your game
Queues give control to the code that pulls from it — the receiver can delay processing, aggregate requests, or discard them entirely. But queues do this by taking control away from the sender. All the sender can do is throw a request on the queue and hope for the best. This makes queues a poor fit when the sender needs a response.
     
