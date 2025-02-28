# Лабораторна робота №1

## Принципи програмування

### DRY (Don't Repeat Yourself)
- Принцип DRY дотримується у класі [Money](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Money.cs), де методи для роботи з грошима не повторюються.

### KISS (Keep It Simple, Stupid)
- Клас [Product](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Product.cs) реалізований просто, без зайвої складності.

### SOLID
- **Single Responsibility Principle (SRP)**: Кожен клас має одну відповідальність.
- **Open/Closed Principle (OCP)**: Класи [Money](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Money.cs), [Product](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Product.cs), [Warehouse](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Warehouse.cs) можна розширювати, не змінюючи їхній базовий код.
- **Liskov Substitution Principle (LSP)**: Принцип дотримується, оскільки всі класи можуть бути замінені своїми підкласами без зміни поведінки програми.
- **Interface Segregation Principle (ISP)**: Принцип дотримується, оскільки інтерфейси не перевантажені методами.
- **Dependency Inversion Principle (DIP)**: Принцип дотримується, оскільки класи залежать від абстракцій, а не від конкретних реалізацій.

### YAGNI (You Aren't Gonna Need It)
- У коді не реалізовано зайвих функцій, які не потрібні для виконання завдання.

### Composition Over Inheritance
- У коді використовується композиція (наприклад, клас [Product](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Product.cs#L5-L22) містить об'єкт класу `Money`).

### Program to Interfaces not Implementations
- У коді використовуються [інтерфейси для забезпечення гнучкості](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Reporting.cs).

### Fail Fast
- У коді передбачено [перевірки на помилки](https://github.com/Doshik143/SoftwareConstruction_Labs/blob/SC_Labs/lab-1/ClassLibrary/Reporting.cs#L18-L27), щоб програма не продовжувала роботу з некоректними даними.