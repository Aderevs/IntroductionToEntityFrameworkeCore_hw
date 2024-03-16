# IntroductionToEntityFrameworkeCore_hw
Завдання 1
Розробіть консольну програму з використанням одного списку з типом (List< ваш вибір >) одного з варіантів.

1. Магазин – Product
1) + Id: Guid
2) + Name: string
3) + Cost: double
4) + Description: string
5) + Quantity: int

2. Користувач – User
1) + Id: Guid
2) + Name: string
3) + LastName: string
4) + Login: string
5) + Password: string
6) + Email: string

3. Замовлення – Order
1) + Id: Guid
2) + Name: string
3) + Create: datetime
4) + Update: datetime
5) + Description: string
Заповніть ваш список значеннями (10 значень).
Виведіть на екран значення за індексом > 1, 5, 0, 7
Знайдіть та виведіть індекси > 1, 5 за властивістю Id
Знайдіть та виведіть індекси > 0, 7 за властивістю Name

Завдання 2
Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application. 
Потрібно: 
Інсталюйте необхідні пакети для роботи з Entity Framework Створіть контекст бази даних MyDatabaseContext та
використовуючи матеріали завдання 1 (цього уроку), перенесіть ваш список у якості колекції DbSet, 
виконайте міграцію Заповніть таким самим способом, що і в першому завдані, через контекст MyDatabaseContext 
вашу колекцію тими самими значеннями. Переконайтесь, що дані збереглись у базу. Знайти та вивести > 1, 5, 0, 7 
з Product/User/Order (ваш варінт) контексту за ім’ям

Завдання 3*
Використовуючи Visual Studio, створіть проєкт за шаблоном Windows Forms Application. 
Потрібно: 
Створити моделі сутностей, використовуючи техніку Database First.(Підключити існуючу базу даних з завдання 2 (цього уроку) ) 
Додати на форму DataGridView і Button Реалізувати можливість виведення інформації в DataGridView за натисканням на Button.