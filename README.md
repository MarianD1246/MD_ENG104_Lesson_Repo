# ENG104 Week 1 notes

## Unit testing

It is key that the unit testing script start with:

``` C# 
using Nunit.Framework;
using ProgramNameSpace
```

ProgramNameSpace being the project namespace we add to be referenced later on when testing. 

To set up the test correctly right click the dependencies under your unit testing project name and add the desired projects.

![NunitTestingAddDependencyReference](D:\C#Projects\GitRepo\MD_ENG104_Lesson_Repo\_img\NunitTestingAddDependencyReference.JPG)

![NunitTestingAddDependencyReference2](D:\C#Projects\GitRepo\MD_ENG104_Lesson_Repo\_img\NunitTestingAddDependencyReference2.JPG)



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

A way to test a Method is using Assert.That(x, IsEqualTo()):

``` c# 
  public void GivenEdgeCase_Greeting_returnRightMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }
```

 Then run the testcases and await the results.



## Turning Operators to factorise if/case statements

``` c# 
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                    sum += i;
                else if (i % 5 == 0))
                    sum += i;
                else 
                    sum +=0;
            }
            return sum;

        }
```

The code above can be re-written as:

``` c# 
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                sum = i % 2 == 0 ? sum += i : i % 5 == 0 ? sum += i : sum += 0;
            }
            return sum;
        }
```

Using the _?_ operator after a statement is similar to doing an if statement thus 
```c#
if (i % 2 == 0 ) 
    sum += i;
//can be rewriten as 
sum = i % == 0 ? sum + = i;
```

The re-written code above will throw an error as the statement is uncomplete.

Like switch cases with a default, using the ? operator needs an default or else.

``` c#
sum = i % == 0 ? sum + = i : max += 0;
```

By adding : max += 0, we increment by 0 causing no change and completing the statement.
