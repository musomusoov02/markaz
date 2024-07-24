namespace Proyekt2222
{
    public class MarkazServis

    {
        public List<Kurslar> kurs = new List<Kurslar>();
        public List<Mentorlar> teacher = new List<Mentorlar>();
        public List<Markaz_haqida> markazHaqida = new List<Markaz_haqida>();
        public List<Arizalar> ariza = new List<Arizalar>();

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
            kurs.Add(NewScience);
            Console.WriteLine("Successfully.");
        }


        public void UpdateScience()
        {
            foreach (var item in kurs)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
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
            Console.WriteLine("successfully");
        }

        public void DeleteScience()
        {
            foreach (var item in kurs)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }

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
        }

        ///---------------------------------------------------------------------------

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
        }


        public void UpdateTeacher()
        {
            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }
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
        }

        public void DeleteTeacher()
        {
            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Id}: {item.Name}");
            }

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
        }


        /// --------------------------------------------------

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
        }

        public void ListMarkaz()
        {
            if (markazHaqida.Count > 0)
            {
                foreach (var item in markazHaqida)
                {
                    Console.WriteLine($"  {item.Name}");
                }
            }
            else Console.WriteLine("Empty");
        }


        public void ClearMarkaz()
        {
            markazHaqida.Clear();
        }

        /// --------------------------------------------
        /// 

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

        }

        public void ListApplication()
        {
            if (ariza.Count > 0)
            {
                foreach (var item in ariza)
                {
                    Console.WriteLine($"  {item.Id}- Kim tomonidan: {item.KimTomonidan} [ Mazmuni: {item.Ariza} ]");
                }
            }
            else Console.WriteLine("Empty");
        }


        public void ClearApplication()
        {
            ariza.Clear();
        }

    }
}
