# 🧮 FactorialBoundaryTests

C# Unit Test project for testing the **Factorial(int n)** function using **Boundary Value Analysis (BVA)**.  
This assignment implements a complete and logically minimal set of test cases for factorial calculation validation.

---

## 🧾 Assignment Description

**Task:**  
Using the definition for factorial and the concept of *Boundary Analysis* as described in the class video,  
write the set of **Test Cases** to test the function:

```csharp
int Factorial(int n)
```

**Behavior:**
- Returns the factorial of `n` if it can be calculated.
- Throws `ArgumentOutOfRangeException` if:
  - `n` is negative (factorial doesn’t exist), or
  - `n` is too large to be computed (overflow).

Each test case should be named:
```
TestMethodX
```
where **X** is the counter starting from 1.

---

## 🧩 Factorial Definition

```
n! = n × (n - 1) × (n - 2) × ... × 1
```

Examples:
```
4! = 4 × 3 × 2 × 1 = 24
7! = 5040
0! = 1 (by definition)
```

---

## 🧠 Boundary Analysis Logic

| Range | Input Range | Expected Behavior | Example Test Inputs |
|--------|--------------|------------------|----------------------|
| Below minimum | `n < 0` | Exception | `int.MinValue`, `-1` |
| Lower boundary | `n = 0` | Valid (returns 1) | `0` |
| Small valid | `1 ≤ n ≤ 5` | Returns factorial | `1`, `3`, `5` |
| Upper valid boundary | `12` | Last valid before overflow | `12` |
| Beyond upper boundary | `> 12` | Exception (overflow) | `13`, `int.MaxValue` |

---

## 🧪 Test Cases Overview

| # | Input | Expected Output | Description |
|---|--------|----------------|-------------|
| 1 | `int.MinValue` | Exception | Too small |
| 2 | `-1` | Exception | Negative |
| 3 | `0` | `1` | Base case |
| 4 | `1` | `1` | Small valid |
| 5 | `2` | `2` | Valid small |
| 6 | `3` | `6` | Normal |
| 7 | `5` | `120` | Mid-range |
| 8 | `12` | `479001600` | Upper valid |
| 9 | `13` | Exception | Overflow |
| 10 | `int.MaxValue` | Exception | Too large |

---

## 🧪 Example Implementation

```csharp
[TestMethod]
public void TestMethod3()
{
    Assert.AreEqual(1, Factorial(0));
}

[TestMethod]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void TestMethod9()
{
    Factorial(13);
}
```

---

## ⚙️ How to Run Tests

### ▶️ In VS Code / CLI:
```bash
dotnet build
dotnet run
```

### 📁 Project Structure:
```
FactorialBoundaryTests/
│
├── UnitTest.cs
├── Factorial.cs
└── README.md
```

---

## 🧰 Technologies Used
- **Language:** C# (.NET 8)
- **Testing Methodology:** Boundary Value Analysis (BVA)
- **Framework:** Custom MSTest-style test runner
- **Tools:** Visual Studio Code / GitHub

---

## 👨‍💻 Author
**Roman Kafitulin**  
Software Development Student @ Lake Washington Institute of Technology  
📍 Seattle, WA  
[GitHub Profile → RomanKAFI](https://github.com/RomanKAFI)
