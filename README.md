# Algorithms Library

- [Algorithms Library](#algorithms-library)
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Algorithms](#algorithms)
  - [Fibonacci sequence calculator](#fibonacci-sequence-calculator)
  - [Triangular numbers calculator](#triangular-numbers-calculator)
  - [Sieve of Eratosthenes](#sieve-of-eratosthenes)
  - [Hanoi tower solver](#hanoi-tower-solver)
  - [Factorial calculator](#factorial-calculator)
- [License](#license)

# Introduction

This is a console application written in C# using the .NET framework and Visual Studio. The program allows users to input various algorithms and get the results based on their input. The application is designed with a menu system that provides options for users to select different algorithms to run.

The following algorithms are included in the program:

- Fibonacci sequence calculator
- Triangular numbers calculator
- Factorial calculator
- Hanoi towers solver
- Sieve of Eratosthenes
 
Users can navigate the menu to select the algorithm they wish to run and input the required - values. The program then executes the algorithm and displays the results to the user.

This application can be useful for anyone interested in learning more about programming algorithms or practicing their skills in this area. It provides a convenient and easy-to-use interface for running and testing different algorithms.

To get started with the application, follow the installation instructions below.

# Prerequisites
To run this program, you will need to have the following installed on your computer:

- [Visual Studio (2017 or later)](https://visualstudio.microsoft.com/pl/)
- [.NET Framework (4.7.2 or later)](https://dotnet.microsoft.com/en-us/download)

If you don't have Visual Studio or .NET Framework installed, you can download and install them from the links above.

Please note that this program has only been tested on Windows operating systems. It may not work on other platforms, such as macOS or Linux.

# Installation
To install and run this program on your local machine, follow these steps:

1. Clone this repository to your local machine using Git or download the zip file and extract it to a directory of your choice.

```bash
git clone https://github.com/JakubKorytko/algorithms-library.git
```

2. Open the `Algorithms.sln` solution file in Visual Studio.

3. Build the solution by clicking on the Build menu and selecting Build Solution (or by pressing F6). This will compile the program and create an executable file.

4. Once the build is complete, you can run the program by pressing F5 or by clicking on the Debug menu and selecting Start Debugging.

5. The program will start and display a menu with options for running different algorithms. Follow the on-screen instructions to input the required values and run the algorithm of your choice.

Congratulations! You have successfully installed and run the Algorithms Library on your local machine. If you encounter any issues during the installation process, please refer to the Troubleshooting section below or contact the developer for assistance.

# Usage
To use the Algorithms Library, follow these steps:

1. Open the program by running the executable file (`Algorithms.exe`) that was created during the installation process.

2. The program will display a menu with options for running different algorithms. Type the name of the algorithm you want to run and press Enter. For example, to run the Fibonacci sequence calculator, type "fibonacci" and press Enter.

3. Follow the on-screen instructions to input the required values for the algorithm. For example, for the Fibonacci sequence calculator, you will need to enter the number of terms you want to generate.

4. Once you have input the required values, the program will execute the algorithm and display the results on the screen. Follow any additional prompts to continue running the program or to exit.

To exit the program at any time, type "exit" and press Enter.

Here are the available algorithms and their corresponding commands in the menu:

- Hanoi towers solver - `hanoi`
- Fibonacci sequence calculator - `fibonacci`
- Triangular numbers calculator - `triangular`
- Sieve of Eratosthenes - `eratosthenes`
- Factorial calculator - `factorial`

- You can navigate the menu by typing "menu" and pressing Enter at any time. (except when you are running an algorithm)

That's it! The Algorithms Library is simple and easy to use. Have fun exploring different algorithms and experimenting with your own inputs.

# Algorithms

The Algorithms Library includes the following algorithms:

## Fibonacci sequence calculator

The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding numbers. The sequence starts with 0 and 1, and each subsequent number is the sum of the two preceding numbers. For example, the first ten numbers in the sequence are:

```
0, 1, 1, 2, 3, 5, 8, 13, 21, 34
```

## Triangular numbers calculator

A triangular number is a number that can be represented as a triangle of dots. For example, the number 6 is a triangular number because it can be represented as a triangle with 6 dots:

```
      *
    *   *
  *   *   *
```

To use the Triangular numbers calculator in the Algorithms Library, type "triangular" in the menu and enter the number of terms you want to generate.

## Sieve of Eratosthenes

The Sieve of Eratosthenes is a simple and efficient algorithm for finding all prime numbers up to a given limit. The algorithm works by iteratively marking as composite (i.e., not prime) the multiples of each prime, starting with the multiples of 2. For example, to find all prime numbers up to 30, we start with the number 2 and mark its multiples (4, 6, 8, etc.) as composite. Then we move to the next prime number (3) and mark its multiples (6, 9, 12, etc.) as composite. We continue this process until all primes have been processed.

To use the Sieve of Eratosthenes in the Algorithms Library, type "eratosthenes" in the menu and enter the maximum number you want to generate primes up to.

## Hanoi tower solver

The Towers of Hanoi is a classic puzzle game where you have three rods and a number of disks of different sizes which can slide onto any rod. The puzzle starts with the disks in a neat stack in ascending order of size on one rod, the smallest at the top. The objective of the puzzle is to move the entire stack to another rod, obeying the following simple rules:

1. Only one disk can be moved at a time.
2. Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack or on an empty rod.
3. No disk may be placed on top of a smaller disk.

To use the Hanoi tower solver in the Algorithms Library, type "hanoi" in the menu and enter the number of disks you want to solve for. It will then display the steps required to solve the puzzle.

## Factorial calculator
The factorial of a positive integer n is the product of all positive integers from 1 to n. For example, the factorial of 5 (written as 5!) is:

```
5! = 5 * 4 * 3 * 2 * 1 = 120
```

To use the Factorial calculator in the Algorithms Library, type "factorial" in the menu and enter the number you want to calculate the factorial for. The app will display the result.

# License

This project is licensed under the MIT License - see the [LICENSE]("./LICENSE") file for details.