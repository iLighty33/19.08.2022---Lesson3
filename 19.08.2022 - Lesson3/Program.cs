// See https://aka.ms/new-console-template for more information
using C_sharp_HW_2;
FileInfo file = new FileInfo(@"C:\Users\iLigh\Source\Repos\19.08.2022---Lesson3\19.08.2022 - Lesson3\\save.txt");

List<string> strings = new List<string>();
List<Uchastniki> uchastniki = new List<Uchastniki>();

int count = Uchastniki.Vvod_age("Введите количество участников: ");

void vyvod()
{
    Console.WriteLine("Все участники:");
    string s;
    foreach (var item in uchastniki)
    {
        Console.WriteLine(item.ToString());
        s = item.ToString();
    }
}

for (int i = 0; i < count; i++)
{
    uchastniki.Add(new Uchastniki(i + 1));
}

string s = "";
while (s != "7")
{
    Console.WriteLine();
    vyvod();
    Console.WriteLine();
    Console.WriteLine("[0] Вывести список участников");
    Console.WriteLine("[1] Добавить участника");
    Console.WriteLine("[2] Удалить участника");
    Console.WriteLine("[3] Изменить возраст");
    Console.WriteLine("[4] Изменить ФИО");
    Console.WriteLine("[5] Reader. Считать участников из файла");
    Console.WriteLine("[6] Writer. Записать участников в файл");
    Console.WriteLine("[7] Выход");


    s = Console.ReadLine();
    if (s == "7")
    {
        break;
    }

    switch (s)
    {
        case "0":
            vyvod();
            break;
        case "1":
            uchastniki.Add(new Uchastniki(uchastniki.Count));
            Console.WriteLine();
            vyvod();
            break;
        case "2":
            Console.WriteLine("Введите ID участника: ");
            uchastniki.RemoveAt(Uchastniki.Vvod_age("") - 1);
            Console.WriteLine();
            vyvod();
            break;
        case "3":
            Console.WriteLine("Введите ID участника: ");
            int _age = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите новый возраст: ");
            (uchastniki.ElementAt(_age)).Age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            vyvod();
            break;
        case "4":
            Console.WriteLine("Введите ID участника: ");
            int _name = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите новое ФИО: ");
            uchastniki.ElementAt(_name).Name = String.Format(Console.ReadLine());
            Console.WriteLine();
            vyvod();
            break;
        case "5":
            using (StreamReader reader = new(@"C:\Users\iLigh\Source\Repos\19.08.2022---Lesson3\19.08.2022 - Lesson3\save.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    strings.Add(line);
                }
            }

            break;
        case "6":
            using (StreamWriter writer = new(@"C:\Users\iLigh\Source\Repos\19.08.2022---Lesson3\19.08.2022 - Lesson3\save.txt", false))
            {

                Console.WriteLine("Введите Id, Имя, Возраст участника");
                foreach (var item in uchastniki)
                {
                    writer.WriteLine(item.Id + "!" + item.Name + "!" + item.Age);
                }

                //Console.writer(item.ToString());
                writer.Close();
            }
            break;

        case "7":

            break;

        default:
            {
                break;
            }

    }
}

Console.WriteLine("До свидания!!");

return;

    