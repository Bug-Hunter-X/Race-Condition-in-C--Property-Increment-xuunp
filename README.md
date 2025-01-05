# Race Condition in C# Property Increment

This repository demonstrates a subtle race condition that can occur in C# when incrementing a property from multiple threads. The problem lies in the fact that the increment operation (`MyProperty++`) is not atomic.  This means that it is not guaranteed to execute as a single, indivisible operation. 

The `bug.cs` file contains the flawed code. The `bugSolution.cs` file provides a corrected version using the `Interlocked` class to ensure thread safety.

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.cs` file. You'll likely see unpredictable results if you run it with multiple threads.
3. Compare the results to the corrected version in `bugSolution.cs`.

## Solution

The solution uses the `Interlocked.Increment` method, which guarantees atomic operations. This eliminates the race condition and ensures that the property is incremented correctly even under concurrent access.
