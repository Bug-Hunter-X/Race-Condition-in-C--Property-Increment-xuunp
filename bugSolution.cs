using System.Threading;

public class MyClass {
    public int MyProperty { get; private set; }

    public void MyMethod() {
        Interlocked.Increment(ref MyProperty);
    }
}