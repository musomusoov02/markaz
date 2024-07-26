using System.Text.Json;

namespace Proyekt2222
{
    public class MarkazServis
    {


        public MarkazServis()
        {
            ReadKurslar();
            ReadArizalar();
            ReadMentorlar();
            ReadMarkazHaqida();
        }

        ///------------------------------------------------------------GetCurrent
        public static string GetKurslarPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\Kurslar.json";
            return currentPath;
        }

        public static string GetMehtorlarPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\Mehtorlar.json";
            return currentPath;
        }

        public static string GetMarkazHaqidaPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\MarkazHaqida.json";
            return currentPath;
        }

        public static string GetArizalarPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\Arizalar.json";
            return currentPath;
        }

        ///------------------------------------------------------------Read
        public void ReadKurslar()
        {
            if(File.Exists(GetKurslarPath()))
            {
                string json= string.Empty;
                using (StreamReader ReadKurs=new StreamReader(GetKurslarPath()))
                {
                    json = ReadKurs.ReadToEnd();
                }
                kurs = JsonSerializer.Deserialize<List<Kurslar>>(json);
            }
            else
            {
                kurs= new List<Kurslar>();
            }
        }

        public void ReadArizalar()
        {
            if (File.Exists(GetArizalarPath()))
            {
                string json = string.Empty;
                using (StreamReader ReadArizalar = new StreamReader(GetArizalarPath()))
                {
                    json = ReadArizalar.ReadToEnd();
                }
                ariza = JsonSerializer.Deserialize<List<Arizalar>>(json);
            }
            else
            {
                ariza = new List<Arizalar>();
            }
        }

        public void ReadMentorlar()
        {
            if (File.Exists(GetMehtorlarPath()))
            {
                string json = string.Empty;
                using (StreamReader ReadKurs = new StreamReader(GetMehtorlarPath()))
                {
                    json = ReadKurs.ReadToEnd();
                }
                teacher = JsonSerializer.Deserialize<List<Mentorlar>>(json);
            }
            else
            {
                teacher = new List<Mentorlar>();
            }
        }
        public void ReadMarkazHaqida()
        {
            if (File.Exists(GetMarkazHaqidaPath()))
            {
                string json = string.Empty;
                using (StreamReader ReadKurs = new StreamReader(GetMarkazHaqidaPath()))
                {
                    json = ReadKurs.ReadToEnd();
                }
                markazHaqida = JsonSerializer.Deserialize<List<Markaz_haqida>>(json);
            }
            else
            {
                markazHaqida = new List<Markaz_haqida>();
            }
        }

         ///------------------------------------------------------------Save
        public void SaveKurslar()
        {
            string str = JsonSerializer.Serialize(kurs);
            using (StreamWriter sw = new StreamWriter(GetKurslarPath()))
            {
                sw.WriteLine(str);
            }
        }

        public void SaveArizalar()
        {
            string str = JsonSerializer.Serialize(ariza);
            using (StreamWriter sw = new StreamWriter(GetArizalarPath()))
            {
                sw.WriteLine(str);
            }
        }
        public void SaveMentorlar()
        {
            string str = JsonSerializer.Serialize(teacher);
            using (StreamWriter sw = new StreamWriter(GetMehtorlarPath()))
            {
                sw.WriteLine(str);
            }
        }

        public void SaveMarkazHaqida()
        {
            string str = JsonSerializer.Serialize(markazHaqida);
            using (StreamWriter sw = new StreamWriter(GetMarkazHaqidaPath()))
            {
                sw.WriteLine(str);
            }
        }

        ///-----------------------------------------------------------------------------------------------------------


        public List<Kurslar> kurs = new List<Kurslar>();
        public List<Mentorlar> teacher = new List<Mentorlar>();
        public List<Markaz_haqida> markazHaqida = new List<Markaz_haqida>();
        public List<Arizalar> ariza = new List<Arizalar>();

        ///-----------------------------------------------------------------------------------science

        public void AddScience()
        {
            Console.Write("Science Name: ");
            string scienceName = Console.ReadLine();

            int newId = kurs.Count > 0 ? kurs.Max(s => s.Id) + 1 : 1;
            Kurslar NewScience = new Kurslar
            {
                Id = newId,
                Name = scienceName
            };
            if (!string.IsNullOrEmpty(scienceName)) kurs.Add(NewScience);
            else
            {
                Console.WriteLine("kiritilmadi: ");
                return;
            }
            Console.WriteLine("Successfully.");

            SaveKurslar();
        }


        public void UpdateScience()
        {
            ListScience();
            Console.Write("scienceId: ");
            int scienceId;
            while (!int.TryParse(Console.ReadLine(), out scienceId))
            {
                Console.WriteLine("Try again.");
            }
            var kursToUpdate = kurs.FirstOrDefault(k => k.Id == scienceId);
            if (kursToUpdate == null)
            {
                Console.WriteLine("not found");
                return;
            }
            Console.Write("New Name: ");
            string scienceName = Console.ReadLine();
            if (!string.IsNullOrEmpty(scienceName))
            {
                kursToUpdate.Name = scienceName;
            }
            else
            {
                Console.WriteLine("kirilmadi:");
                return;
            }
            Console.WriteLine("successfully");
            SaveKurslar();
        }

        public void DeleteScience()
        {
            ListScience();
            int scienceId;
            while (!int.TryParse(Console.ReadLine(), out scienceId))
            {
                Console.WriteLine("Try again.");
            }
            var kurslar = kurs.FirstOrDefault(k => k.Id == scienceId);
            if (kurslar != null)
            {
                kurs.Remove(kurslar);
            }
            else
            {
                Console.WriteLine("not found!");
            }
            SaveKurslar();
        }

        public void ListScience()
        {
            if (kurs.Count > 0)
            {
                foreach (var item in kurs)
                {
                    Console.WriteLine($" {item.Id}: {item.Name}");
                }
            }
            else Console.WriteLine("Empty");
        }

        public void ClearScience()
        {
            kurs.Clear();
            SaveKurslar();
        }

        ///--------------------------------------------------------------------------- teacher

        public void AddTeacher()
        {
            Console.Write("Science Name: ");
            string TeacherName = Console.ReadLine();

            int newId = teacher.Count > 0 ? teacher.Max(s => s.Id) + 1 : 1;
            Mentorlar NewTeacher = new Mentorlar
            {
                Id = newId,
                Name = TeacherName
            };
            teacher.Add(NewTeacher);
            Console.WriteLine("Successfully.");
            SaveMentorlar();
        }


        public void UpdateTeacher()
        {
            ListTeacher();
            Console.Write("scienceId: ");
            int TeacherId;
            while (!int.TryParse(Console.ReadLine(), out TeacherId))
            {
                Console.WriteLine("Try again.");
            }
            var teacherToUpdate = teacher.FirstOrDefault(k => k.Id == TeacherId);
            if (teacherToUpdate == null)
            {
                Console.WriteLine("not found");
                return;
            }
            Console.Write("New Name: ");
            string TeacherName = Console.ReadLine();
            if (!string.IsNullOrEmpty(TeacherName))
            {
                teacherToUpdate.Name = TeacherName;
            }
            Console.WriteLine("successfully");
            SaveMentorlar();
        }

        public void DeleteTeacher()
        {
            ListTeacher();

            int TeacherId;
            while (!int.TryParse(Console.ReadLine(), out TeacherId))
            {
                Console.WriteLine("Try again.");
            }
            var Teacherlar = teacher.FirstOrDefault(k => k.Id == TeacherId);
            if (Teacherlar != null)
            {
                teacher.Remove(Teacherlar);
            }
            else
            {
                Console.WriteLine("not found!");
            }
            SaveMentorlar();
        }


        public void ListTeacher()
        {
            if (teacher.Count > 0)
            {
                foreach (var item in teacher)
                {
                    Console.WriteLine($" {item.Id}: {item.Name}");
                }
            }
            else Console.WriteLine("Empty");
        }

        public void ClearTeacher()
        {
            teacher.Clear();
            SaveMentorlar() ;
        }

        /// --------------------------------------------------markaz

        public void AddMarkaz()
        {
            Console.Write("markaz Name: ");
            string MarkazName = Console.ReadLine();

            int newId = markazHaqida.Count > 0 ? markazHaqida.Max(s => s.Id) + 1 : 1;
            Markaz_haqida NewMarkaz = new Markaz_haqida
            {
                Id = newId,
                Name = MarkazName
            };
            markazHaqida.Add(NewMarkaz);
            Console.WriteLine("Successfully.");
            SaveMarkazHaqida();
        }

        public void ListMarkaz()
        {
            if (markazHaqida.Count > 0)
            {
                foreach (var item in markazHaqida)
                {
                    Console.WriteLine($"  {item.Name},");
                }
            }
            else Console.WriteLine("Empty");
        }

        public void ClearMarkaz()
        {
            markazHaqida.Clear();
            SaveMarkazHaqida() ;
        }

        /// --------------------------------------------applcation

        public void AddApplication()
        {
            Console.Write("Ariza Mazmuni: ");
            string MarkazName = Console.ReadLine();
            Console.Write("Kim tomonidan: ");
            string kimTomonidan = Console.ReadLine();

            int newId = ariza.Count > 0 ? ariza.Max(s => s.Id) + 1 : 1;
            Arizalar Newariza = new Arizalar
            {
                Id = newId,
                Ariza = MarkazName,
                KimTomonidan = kimTomonidan
            };
            ariza.Add(Newariza);
            Console.WriteLine("Successfully.");
            
            SaveArizalar();
        }

        public void ListApplication()
        {
            if (ariza.Count > 0)
            {
                Console.Clear();
                Console.WriteLine($"No:|");
                foreach (var item in ariza)
                {
                    Console.WriteLine($"{item.Id}. | F.I.SH => {item.KimTomonidan} || CONTENT => {item.Ariza} ");
                }
            }
            else Console.WriteLine("Empty");
        }

        public void ClearApplication()
        {
            ariza.Clear();
            SaveArizalar() ;
        }
    }
}
