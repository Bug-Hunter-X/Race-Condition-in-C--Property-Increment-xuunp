public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        //This is the problematic line
        MyProperty++;
    }
}