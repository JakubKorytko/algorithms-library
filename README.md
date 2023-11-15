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
    - [Available commands](#available-commands)
    - [Available algorithms](#available-algorithms)
    - [Adding algorithms](#adding-algorithms)
    - [Adding shared methods](#adding-shared-methods)
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

1. Enter the project directory:

    ```bash
    cd algorithms-library
    ```

1. Open the `AlgorithmsLibrary.sln` solution file in Visual Studio.

1. Build or run the project in Visual Studio:

    - **Run the project** in the Visual Studio
      - `F5` /  `Ctrl + F5` by default
      - or `Debug` -> `Start Debugging` / `Start Without Debugging` on the toolbar

    - or **Build project** executable
      - `Ctrl + B` / `Ctrl + Shift + B` by default
      - or `Build` -> `Build Solution` / `Build AlgorithmsLibrary` on the toolbar

    The executable will be available in the `build` directory in either case.

## Usage

The application has an intuitive text-based menu.
On launch, the menu is displayed and the application waits for your input **(case-insensitive)**.

### Available commands

- `<algorithm_name>` - execute the selected [algorithm](#available-algorithms)
- `menu` - display the menu options
- `exit`

### Available algorithms

- **Eratosthenes** (Sieve of Eratosthenes)
- **SuperAlgorithm** (a sample algorithm without input)
- **Factorial** (Factorial calculator)
- **Fibonacci** (Fibonacci sequence calculator)
- **Hanoi** (Hanoi tower solver)
- **Triangular** (Triangular numbers calculator)

### Adding algorithms

Add a new class to the `Components/Algorithms` folder.
Make sure that the class is derived from the `Algorithm` class
(`AlgorithmsLibrary.AlgorithmsCore` namespace).

Also, the class should:

1. Override the public void method named `Display`
which is used to execute the algorithm
(you must handle the output within this function)  

   - **IF NOT**: The application will display
    `No display method defined for this algorithm`
    when you try to select it from the menu.

1. Override the public virtual string `Description`:

    ```c#
    public override string Description { get { return "..."; } }
    ```

   - **IF NOT**: The application will display
    `No description provided for this algorithm`
    next to it in the printed menu.

1. Have a unique class name that is displayed in the menu.

For example, see `Components/Algorithms/Algorithm.example.cs`

### Adding shared methods

If you need to add a method that is available to all algorithms,
add a new method to the `Components/AlgorithmsCore/BaseClassTools.cs` file.

The file contains a sample method that you can check to create your own.

*(Also, there are already some methods there to parse integers from the input,
check them out if you are interested)*.

## Contributing

If you find issues or have suggestions for improvements,
feel free to open an issue or submit a pull request.
Contributions are welcome!

## Contact

If you have any questions, feel free to contact me at <jakub@korytko.me>.

## License

This project is released under the MIT License. See the LICENSE file for details.
