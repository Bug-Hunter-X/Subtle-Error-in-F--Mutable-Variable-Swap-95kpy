# Subtle Error in F# Mutable Variable Swap

This repository demonstrates a subtle error in a seemingly simple F# program that attempts to swap two mutable variables using a clever but flawed approach.  The bug involves unintended side effects when working with mutable variables and the order of operations. This example highlights the importance of careful attention to detail when using mutable state in F#.

## How to Run

1.  Make sure you have the .NET SDK installed.
2.  Clone this repository.
3.  Open the `bug.fs` file to examine the flawed code.
4.  Open the `bugSolution.fs` file to see the corrected code.
5.  Compile and run the code using the F# compiler (fsc.exe).