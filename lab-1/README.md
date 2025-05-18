# 1. DRY
Клас [Money](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Money.cs) централізовано обробляє грошові операції. Це допомагає уникнути дублювання коду
# 2. KISS
Класи мають чітко визначену відповідальність і не містять зайвої складності. Наприклад, [Money](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Money.cs) обробляє тільки грошові операції, а [Product](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Product.cs) лише інформацію про товар. Методи та їх назви логічно відображають їхнє призначення - [DecreasePrice](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Product.cs#L20C15-L25)
# 3. SOLID 
- S - [Warehouse](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Warehouse.cs) займається тільки обробкою товарів на складі, а [Reporting](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Reporting.cs) реєстрацією надходжень та відвантажень.
- O - Можна розширити функціональність класу [Warehouse](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Warehouse.cs), додавши нові методи, не змінюючи існуючий код.
# 4. YAGNI
Код не перевантажений зайвими методами, лише необхідні функції: зберігання даних, знижки, реєстрація надходжень/відправлень.
# 5. Composition Over Inheritance
Клас [Product](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Product.cs) використовує [Money](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Product.cs#L12) як властивість, а не наслідує його 
# 7. Fail Fast 
Метод [RegisterShipment](https://github.com/vt231pdm/software-design/blob/main/lab-1/lab-1/Reporting.cs#L19-L31) перевіряє наявність товару 