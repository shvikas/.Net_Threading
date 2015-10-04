# .Net Threading

Samples and information for .Net Threading, which I can refer later on.

## Threading Basics
Thread is the smallest unit of execution.

Each application runs in its own process. Every process has its own virtual memory and has at least one thread called primary thread.

.Net sub-divides processes in Application Domains. By using an AppDomain, it is possible to launch several applications within the same process. Although, each application domain is started with a single thread, code in that application domain can create additional application domains and additional threads. Every Application Domain can contain one or more threads. Managed threads can move freely between many application domains in same process.

CPU executes threads in time slices. After a time slice expires *context switching* is performed to load another thread. For this, all the state data, stack details and CPU registers values for the thread are saved.

### Thread Memory Usage
Every thread has its own call stack. 

1. Local variables in Function:
The local variables in a function are stored in thread's call stack. So every thread will have a different copy of these.

2. Local variables of a class:
local variables of a class are shared between different threads.

3. Static variables of a class:
Static variables of a class are shared between different threads running on different instances.

4. ThreadStaticAttribute decorated variables:
The ThreadStatic attribute is applied on static variables and it makes the thread to have a separate copy of this variable for each thread.

5. ThreadLocal
The ThreadLocal mechanism is required for making a separate copy of data item. ThreadStatic has also the same purpose and is a better choice from performance perspective as compared to ThreadLocal. ThreadLocal should be used when we want to make this decision at run time.  

### Thread synchronization
Threads works asynchronously and there is a risk that their simultaneous access to some resources may corrupt data and state. So, we need that access to some resources e.g. file handles, memory, and network connections must be coordinated. The mechanisms for coordination between different thread access to resoures is called Thread Synchronization.



