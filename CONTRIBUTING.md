# Contributing Guidelines

Thank you for your interest in contributing to this project! 🎉
Contributions of all kinds --- bug fixes, features, documentation, and improvements --- are welcome.

Please take a moment to read these guidelines before getting started.

------------------------------------------------------------------------

## Prerequisites

Before contributing, ensure you have:

-   **Windows OS** (Required for WinForms development)
-   **.NET Framework 4.7.2 or later**
-   **Visual Studio 2019/2022** (Recommended for the best development experience)
-   **Git**
-   A basic understanding of **C# and WinForms**

------------------------------------------------------------------------

## How to Contribute

### 1. Fork the Repository

Create a fork of this repository to your own GitHub account.

### 2. Clone Your Fork

```bash
git clone https://github.com/your-username/Color-Apps-In-Csharp-WinForms.git
cd Color-Apps-In-Csharp-WinForms
```

### 3. Create a Feature Branch

```bash
git checkout -b feature/short-descriptive-name
```

Examples:
- `feature/add-new-palette-algorithm`
- `fix/color-hex-clipping-issue`
- `docs/update-installation-steps`

------------------------------------------------------------------------

### 4. Make Your Changes

-   Keep changes focused and minimal.
-   Follow existing project structure (ensure shared logic goes into `ExternalClasses`).
-   Avoid mixing unrelated changes in one commit.

------------------------------------------------------------------------

### 5. Build and Test Locally

Before submitting a PR, make sure the project builds successfully:

1.  Open `ColorPickerApp.sln` in **Visual Studio**.
2.  Select **Build > Build Solution** (or press `Ctrl+Shift+B`).
3.  Run the application (`F5`) and manually verify that your changes work as expected and don't break existing features.

> [!NOTE]
> Since this project uses WinForms, ensure you test the UI on different screen resolutions if possible.

------------------------------------------------------------------------

### 6. Commit Your Changes

Use clear and meaningful commit messages:

- `Add XYZ color format support`
- `Fix crash when exporting to Desktop on locked systems`
- `Refactor ColorHelper for better performance`

Avoid vague messages like: `fix`, `changes`, `update stuff`.

------------------------------------------------------------------------

### 7. Submit a Pull Request

Push your branch and open a Pull Request against the `main` branch.

------------------------------------------------------------------------

## Coding Guidelines

Please follow these rules to keep the codebase clean and consistent:

-   Follow standard **C# and .NET coding conventions**.
-   Use meaningful names for classes, methods, and variables.
-   Prefer readability over cleverness.
-   **WinForms Design:** Keep the UI clean and consistent with the existing minimalist aesthetic.
-   No breaking changes without prior discussion.

------------------------------------------------------------------------

## Pull Request Guidelines

-   One logical change per Pull Request.
-   Reference the related issue (if applicable).
-   Clearly explain what was changed and why.
-   Include a screenshot if you have made UI changes.

### PR Checklist

-   [ ] Code builds locally in Visual Studio.
-   [ ] Manually tested functionality.
-   [ ] No breaking changes.
-   [ ] Documentation updated (if needed).

------------------------------------------------------------------------

## Reporting Bugs

When reporting a bug, please include:

-   Steps to reproduce.
-   Expected behavior vs. Actual behavior.
-   Your Windows version and .NET Framework version.
-   Any screenshots of the error or visual glitches.

------------------------------------------------------------------------

## Feature Requests

Feature requests are welcome! Please open an issue and describe:

-   The problem you are trying to solve.
-   Why the feature is needed.
-   Any suggested implementation ideas.

------------------------------------------------------------------------

## Decision Making

The project maintainer has final authority on all changes, releases, and roadmap decisions.

------------------------------------------------------------------------

## Code of Conduct

By participating in this project, you agree to abide by the project's Code of Conduct.

------------------------------------------------------------------------

Thank you again for contributing and helping improve this project! 🙌
