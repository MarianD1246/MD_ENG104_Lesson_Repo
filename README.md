# ENG104 Week 1 notes

## Unit testing

It is key that the unit testing script start with:

``` C# 
using Nunit.Framework;
```

To group test cases we can use [Category(x)] x being the name of test group:

``` c# 
[Category("Edge cases")]
```

To feed our method with a test we enter, an int being the input and a string message being the expected result.

```C#
[TestCase(0, "Good evening!")]
[TestCase(5, "Good morning!")]
```

The test methods have a long naming convention such that in thousands of methods it is easily recognise what specific code block has been tested. As such the naming conventions goes something like this: GivenEdgeCase_Greeting_returnRightMessage, given edge case being the desire test, Greeting being the method/script being tested and return right message is our expectation from running set test.

``` C# 
public void GivenEdgeCase_Greeting_returnRightMessage(int time, string expected){}
```

A way to test a Method is :

``` c# 
  public void GivenEdgeCase_Greeting_returnRightMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }
```

