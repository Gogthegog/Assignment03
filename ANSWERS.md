# Answers

Exercise 1 
var FlattenNumber = xs.SelectMany( xs => xs);

Exercise 2
var DivisibleBySeven = ys.Where( ys => ys % 7 == 0 && ys > 42);

Exercise 3 
var LeapYear = ys.Where( ys => ys % 4 == 0 &&(ys % 100 != 0 || ys % 400 == 0));



 Action<string> write = s => Console.WriteLine(new String(s.Reverse().ToArray()));
