# FunctionalCsharp

F# provides two operators to use and compose functions : operators >> and |>.

## Operator >>

This operator takes two functions and creates a new one.

Example:
```fsharp
let addOne x = x + 1
let multiplyByTwo x = x * 2

let combin = addOne >> multiplyByTwo
let result = combin 3 // result == 8
```

Here `combin` is a function that takes one integer x and outputs 2*(x+1). That is, it first apply the function addOne and then call multiplyByTwo on the output of addOne.

Goal : implement the equivalent in C#

```csharp
Func<int,int> addOne = (int x) => x + 1;
Func<int,int> multiplyByTwo = (int x) => 2*x;

Func<int,int> combin = addOne.Compose(multiplyByTwo);

var result = combin(3); // result == 8
```

## Operator |>

This operator allows you to pass the output of one function as the input of another one.

Example:
```fsharp
let addOne x = x + 1
let multiplyByTwo x = x * 2

let result = 3 
  |> addOne 
  |> multiplyByTwo // result == 8
```
```csharp
Func<int,int> addOne = (int x) => x + 1;
Func<int,int> multiplyByTwo = (int x) => 2*x;

int result = 3
  .Pipe(addOne)
  .Pipe(multiplyByTwo) // result == 8
```

## IfNotNull method in C#

Similar to the `|>` operator but stops at soon as one input is null down the chain.


# Roadmap

- [x] Compose method
- [x] Pipe method
- [ ] IfNotNull method

# C# concepts

- [ ] Generics
- [ ] Extension methods
