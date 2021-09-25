## Answers

# Extension 1

`var FlattenNumber = xs.SelectMany( xs => xs);`

# Extension 2

`var DivisibleBySeven = ys.Where( ys => ys % 7 == 0 && ys > 42);`

# Extension 3

`var LeapYear = ys.Where( ys => ys % 4 == 0 &&(ys % 100 != 0 || ys % 400 == 0));`

# Delegate 1

Instead of testing what was printed to the console, we decided to change the test method to return a string, however, please note that no logic was changed.
`Action<string> write = s => Console.WriteLine(new String(s.Reverse().ToArray()));`

# Delegate 2

`Func<decimal, decimal, decimal> Add = (x, y) => x+y;`

# Delegate 3

```C#
Func<string, int, bool> StringIntEqual = (string a, int x) => {
    return (int.TryParse(a, out int b) && b.Equals(x));
};
```
