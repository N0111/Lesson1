//Коробчук А.
//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация
// выводится в одну строчку:
//а) используя склеивание;
Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите фамилию: ");
string surname = Console.ReadLine();
Console.WriteLine("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост(в метрах): ");
double h = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вес (в килограмах): ");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Здравствуйте " + surname + " " + name + " в ваши " + age + " рост " + h+ " при весе " + m + " абсолютно нормально");

//б) используя форматированный вывод;
Console.WriteLine(" Здравствуйте {0} {1} в ваши {2} рост {3} при весе {4} абсолютно нормально", surname, name, age, h, m);

//в) используя вывод со знаком $.
Console.WriteLine($" Здравствуйте {surname} {name} в ваши {age} рост {h} при весе {m} абсолютно нормально");

// 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы
//  тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах,
//   h — рост в метрах.
double i = m/(h*h);
Console.WriteLine($"ИМТ = {i:F2}");

