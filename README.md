# Algorithms Library

![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

[![Run Super-Linter](https://github.com/JakubKorytko/algorithms-library/actions/workflows/super-linter.yml/badge.svg)](https://github.com/JakubKorytko/algorithms-library/actions/workflows/super-linter.yml)

## Table of Contents

- [Algorithms Library](#algorithms-library)
  - [Table of Contents](#table-of-contents)
  - [Introduction](#introduction)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
  - [Extending Algorithms](#extending-algorithms)
  - [Contributing](#contributing)
  - [Contact](#contact)
  - [License](#license)

## Introduction

The Algorithms Library is a versatile C# project
that provides a comprehensive collection of basic algorithms
implemented within the .NET 4.7.3 framework.
This library is designed with extensibility in mind,
allowing users to easily add their own algorithms.

## Prerequisites

Before using the Algorithms Library, make sure that you have the following prerequisites:

- [Visual Studio 2022 (version 17.6.3 or later)](https://visualstudio.microsoft.com/vs/)
  - ".NET desktop development" workload installed.

## Installation

1. Clone this repository to your local machine using Git,
or download the ZIP file and extract it to a directory of your choice:

    ```bash
    git clone https://github.com/JakubKorytko/algorithms-library.git
    ```

2. Enter the project directory:

    ```bash
    cd algorithms-library
    ```

3. Open the `AlgorithmsLibrary.sln` solution file in Visual Studio.

4. Build or run the project in Visual Studio:

    - **Run the project** in the Visual Studio
      - `F5` /  `Ctrl + F5` by default
      - or `Debug` -> `Start Debugging` / `Start Without Debugging` on the toolbar

    - or **Build project** executable
      - `Ctrl + B` / `Ctrl + Shift + B` by default
      - or `Build` -> `Build Solution` / `Build AlgorithmsLibrary` on the toolbar

    Executable will be available in the "build/" subdirectory of the root directory.

## Usage

The application has an intuitive text-based menu.
On launch, the menu is displayed and the application waits for your input.

Available commands (case-insensitive) include:

- `<algorithm_name>` - run the selected algorithm
- `menu` - display the menu options
- `exit`

Basic algorithms include:

- **Eratosthenes** (Sieve of Eratosthenes)
- **SuperAlgorithm** (an example algorithm with no input)
- **Factorial** (Factorial calculator)
- **Fibonacci** (Fibonacci sequence calculator)
- **Hanoi** (Hanoi tower solver)
- **Triangular** (Triangular numbers calculator)

To extend algorithms, see the section below.

## Extending Algorithms

To add a new algorithm,
add a new class to the `Components/Algorithms` folder.
Make sure that the class is derived from the `Algorithm` class
in the `AlgorithmsLibrary.AlgorithmsCore` namespace.

Also, the class should:

1. Override the public void method called `Display`
that is used to run the algorithm
(you need to handle the output within this function)  

    - **IF NOT**: The application will display
    `No display method defined for this algorithm`
    when you try to select it from the menu.

2. Override public virtual string `Description`:

    ```c#
    public override string Description { get { return "..."; } }
    ```

    - **IF NOT**: The application will display
    `No description provided for this algorithm`
    next to it in the printed menu.

3. Have a unique class name that is displayed in the menu.

For example, see `Components/Algorithms/Algorithm.example.cs`

If you need to include a method that is available to all algorithms,
add new method to the `Components/AlgorithmsCore/BaseClassTools.cs`.

In the file, is a sample method that you can check to create your own.

*(also, there are already some methods there to parse integers from the input,
check them out if you are interested)*.

## Contributing

If you find issues or have suggestions for improvement,
feel free to open an issue or submit a pull request.
Contributions are welcome!

## Contact

If you have any questions, please contact me at <jakub@korytko.me>.

## License

This project is released under the MIT License. See the LICENSE file for details.
