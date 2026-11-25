# C# List Methods Practice

This repository contains practice exercises focused on C# `List<T>` methods, especially `Find()`, `FindAll()`, and `Exists()`.

The main goal is to understand how these methods work and how to use `Predicate<T>` to filter and search collections.

## Topics Covered

- `List<T>` fundamentals
- `Predicate<T>` delegate
- `Find()` method
- `FindAll()` method
- `Exists()` method
- Nullable return values
- Conditional logic
- Working with collections

---

## Part 1: Find() Method

The `Find()` method returns the first element that matches the specified condition.

### Exercise 01 — Find the First Even Number

Given the following list:

```csharp
List<int> numbers = new() { 5, 7, 12, 9, 18, 21 };
```

Find the first even number.

**Expected output:**
```text
12
```

### Exercise 02 — Find the First Long Name

Given the following list:

```csharp
List<string> names = new()
{
    "Ali", "Vali", "Muhammad", "Malika", "Aziz"
};
```

Find the first name that contains more than 5 characters.

**Expected output:**
```text
Muhammad
```

### Exercise 03 — Find the First Negative Number

Given the following list:

```csharp
List<int> numbers = new() { 10, 5, 0, -3, -8, 12 };
```

Find the first negative number.

**Expected output:**
```text
-3
```

### Exercise 04 — Find the First Expensive Product

Given the following list:

```csharp
List<decimal> prices = new()
{
    45.5m, 80m, 150m, 220m, 90m
};
```

Find the first product whose price is greater than 100.

**Expected output:**
```text
150
```

### Exercise 05 — Find the First Name Starting with 'A'

Given the following list:

```csharp
List<string> names = new()
{
    "ali", "vali", "Aziza", "Anvar", "Malika"
};
```

Find the first name that starts with the uppercase letter `A`.

**Expected output:**
```text
Aziza
```

---

## Part 2: FindAll() Method

The `FindAll()` method returns a new list containing all elements that match the specified condition.

### Exercise 06 — Find All Even Numbers

Given the following list:

```csharp
List<int> numbers = new()
{
    2, 5, 8, 11, 14, 17, 20, 23
};
```

Find all even numbers.

**Expected output:**
```text
2, 8, 14, 20
```

### Exercise 07 — Find All Long Names

Given the following list:

```csharp
List<string> names = new()
{
    "Ali", "Muhammad", "Vali", "Malika", "Anvar"
};
```

Find all names containing more than 4 characters.

**Expected output:**
```text
Muhammad, Malika, Anvar
```

### Exercise 08 — Find All Negative Numbers

Given the following list:

```csharp
List<int> numbers = new()
{
    -10, 5, -3, 0, 8, -15, 20
};
```

Find all negative numbers.

**Expected output:**
```text
-10, -3, -15
```

### Exercise 09 — Find Products Within a Price Range

Given the following list:

```csharp
List<decimal> prices = new()
{
    50m, 100m, 250m, 500m, 700m, 450m
};
```

Find all products whose prices are between 100 and 500, including both boundaries.

**Expected output:**
```text
100, 250, 500, 450
```

### Exercise 10 — Find Names Ending with 'a'

Given the following list:

```csharp
List<string> names = new()
{
    "Ali", "Malika", "Anvar", "Aziza", "Vali", "Madina"
};
```

Find all names ending with the letter `a`.

**Expected output:**
```text
Malika, Aziza, Madina
```

---

## Part 3: Exists() Method

The `Exists()` method checks whether at least one element in the list matches the specified condition. It returns a Boolean value (`true` or `false`).

### Exercise 11 — Check Whether Zero Exists

Given the following list:

```csharp
List<int> numbers = new()
{
    5, 10, 15, 0, 20
};
```

Check whether the list contains zero.

**Expected output:**
```text
true
```

### Exercise 12 — Check Whether Anyone Is Older Than 18

Given the following list:

```csharp
List<int> ages = new()
{
    12, 15, 16, 17, 18
};
```

Check whether at least one person is older than 18.

**Expected output:**
```text
false
```

### Exercise 13 — Check Whether a Specific Name Exists

Given the following list:

```csharp
List<string> names = new()
{
    "Ali", "Vali", "Malika", "Anvar"
};
```

Check whether the name `Malika` exists in the list.

**Expected output:**
```text
true
```

---

## Part 4: Combined Exercises

Use `Find()`, `FindAll()`, and `Exists()` together to solve the following problems.

### Exercise 14 — Student Score Analysis

Given the following list of student scores:

```csharp
List<int> scores = new()
{
    45, 78, 90, 32, 65, 88, 50
};
```

Complete the following tasks:

1. Use `Find()` to find the first score greater than 60.
2. Use `FindAll()` to find all scores greater than 60.
3. Use `Exists()` to check whether any student scored exactly 100.

**Expected output:**
```text
First: 78
All: 78, 90, 65, 88
Exists: False
```

### Exercise 15 — Product Price Analysis

Given the following list of product prices:

```csharp
List<decimal> prices = new()
{
    50m, 120m, 250m, 80m, 500m, 1000m, 300m
};
```

Complete the following tasks:

1. Use `Find()` to find the first product whose price is greater than 200.
2. Use `FindAll()` to find all products priced between 100 and 500, including both boundaries.
3. Use `Exists()` to check whether a product priced exactly 1000 exists.
4. Use `Exists()` to check whether any product costs more than 1500.
5. Display each result with a descriptive message.

**Expected output:**
```text
First product above 200: 250
Products between 100 and 500: 120, 250, 500, 300
Product priced at 1000 exists: True
Product above 1500 exists: False
```

---

## Learning Guidelines

To get the most out of these exercises:

- Create separate `Predicate<T>` methods for the conditions.
- Avoid using lambda expressions (`=>`) initially.
- Try to solve each exercise independently.
- Pay attention to the difference between `Find()`, `FindAll()`, and `Exists()`.
- Consider what happens when no matching element is found.
- Use nullable types where appropriate when handling potentially missing results.

## Goal

By completing these exercises, you should be able to understand and apply C# collection searching methods, work with predicates, and write cleaner code when manipulating collections.
