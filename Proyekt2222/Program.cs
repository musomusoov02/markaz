using System.IO;
using System.Net.WebSockets;

namespace Proyekt2222
{
    class Program
    {


        /*string CurrentPath = directory.GetCurrentDirectory(;
        currentPath+=  "\\teacher.json";
       



        public static string GetTeacherPath()
        {
            string CurrentPath = directory.GetCurrentDirectory(;
            currentPath += "\\teacher.json";
            Console.wtriteline(currentPath);
            return currentPath =

        }


        public static string GetTeacherPath()
        {
            tring CurrentPath = directory.GetCurrentDirectory(;
            currentPath += "\\Student.json";
            Console.wtriteline(currentPath);
            return currentPath =
        
        }*/



        static int ArrowIndex(List<string> Buyruqlar,string Name)
        {
            bool exit = false;
            int selectIndex = 0;

            while (!exit)
            {
                Console.Clear();
                    Console.WriteLine(Name);
                for (int i = 0; i < Buyruqlar.Count; i++)
                {
                    if (i == selectIndex) Console.WriteLine($">>>>  {Buyruqlar[i]}");
                    else Console.WriteLine($"      {Buyruqlar[i]}");
                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) selectIndex = (selectIndex + 1) % Buyruqlar.Count;
                else if (key.Key == ConsoleKey.UpArrow) selectIndex = (selectIndex - 1 + Buyruqlar.Count) % Buyruqlar.Count;
                else if (key.Key == ConsoleKey.Enter) return selectIndex;



            }
            return selectIndex;
        }



        static void Main(string[] args)
        {
            MarkazServis markazServis = new MarkazServis();

            List<string> Buyruqlar = new List<string>()
                {
                    "O'quv markazi",
                    "O'quvchi",
                };
            List<string> CenterBuyruqlar = new List<string>()
                {
                    "Sciene",
                    "Teacher",
                    "About the training center",
                    "Application",
                    "Back"
                };
            List<string> ScieneBuyruqlar = new List<string>()
                {
                    "Add Sciene",
                    "Update Sciene",
                    "Delete Sciene",
                    "List Sciene",
                    "Clear Sciene",
                    "Back"
                };


            List<string> TeacherBuyruqlar = new List<string>()
                {
                    "Add Teacher",
                    "Update Teacher",
                    "Delete Teacher",
                    "List Teacher",
                    "Clear Teacher",
                    "Back"
                };
            List<string> MarkazBuyruqlar = new List<string>()
                {
                    "Add Text",
                    "List Markaz",
                    "Clear Markaz",
                    "Back"
                };

            List<string> ApplicationBuyruqlar = new List<string>()
                {
                    "List Application",
                    "Clear Application",
                    "Back"
                };






            bool exit = false;
            int selectIndex = 0;

            while (!exit)
            {
                qator1:
                Console.Clear();
                for (int i = 0; i < Buyruqlar.Count; i++)
                {
                    if (i == selectIndex) Console.WriteLine($">>>>  {Buyruqlar[i]}");
                    else Console.WriteLine($"      {Buyruqlar[i]}");
                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) selectIndex = (selectIndex + 1) % Buyruqlar.Count;
                else if (key.Key == ConsoleKey.UpArrow) selectIndex = (selectIndex - 1 + Buyruqlar.Count) % Buyruqlar.Count;
                else if (key.Key == ConsoleKey.Enter)
                {

                    switch (selectIndex)
                    {
                        case 0:

                            string Name = "Admin";
                        centerbuyruqlar:

                            int IndexGeneral = ArrowIndex(CenterBuyruqlar,Name);
                            switch (IndexGeneral)
                            {
                                case 0:
                                    scieneBuyruqlar:
                                    int Index = ArrowIndex(ScieneBuyruqlar, Name);
                                    switch (Index)
                                    {
                                        case 0:
                                            markazServis.AddScience();
                                            Console.ReadKey();
                                            goto scieneBuyruqlar;

                                            break;
                                        case 1:
                                            markazServis.UpdateScience();
                                            Console.ReadKey();
                                            goto scieneBuyruqlar;


                                            break;
                                        case 2:
                                            Console.ReadKey();
                                            markazServis.DeleteScience();
                                            Console.ReadKey();
                                            goto scieneBuyruqlar;


                                            break;
                                        case 3:
                                            markazServis.ListScience();
                                            Console.ReadKey();
                                            goto scieneBuyruqlar;

                                            break;
                                        case 4:
                                            markazServis.ClearScience();
                                            Console.ReadKey();
                                            goto scieneBuyruqlar;


                                            break;
                                        case 5:

                                            goto centerbuyruqlar;
                                            break;

                                        default:
                                            Console.WriteLine("Not found!");
                                            break;
                                    }





                                    break;
                                case 1:
                                    teacherBuyruqlar:
                                    int IndexTeacher = ArrowIndex(TeacherBuyruqlar, Name);
                                    switch (IndexTeacher)
                                    {
                                        case 0:
                                            markazServis.AddTeacher();
                                            Console.ReadKey();
                                            goto teacherBuyruqlar;

                                            break;
                                        case 1:
                                            markazServis.UpdateTeacher();
                                            Console.ReadKey();
                                            goto teacherBuyruqlar;


                                            break;
                                        case 2:
                                            Console.ReadKey();
                                            markazServis.DeleteTeacher();
                                            Console.ReadKey();
                                            goto teacherBuyruqlar;


                                            break;
                                        case 3:
                                            markazServis.ListTeacher();
                                            Console.ReadKey();
                                            goto teacherBuyruqlar;

                                            break;
                                        case 4:
                                            markazServis.ClearTeacher();
                                            Console.ReadKey();
                                            goto teacherBuyruqlar;


                                            break;
                                        case 5:
                                            goto centerbuyruqlar;
                                            break;

                                        default:
                                            Console.WriteLine("Not found!");
                                            break;
                                    }



                                    break;
                                case 2:

                                    markazBuyruqlar:
                                    int IndexMarkaz = ArrowIndex(MarkazBuyruqlar, Name);
                                    switch (IndexMarkaz)
                                    {
                                        case 0:
                                            markazServis.AddMarkaz();
                                            Console.ReadKey();
                                            goto markazBuyruqlar;

                                            break;
                                        case 1:
                                            markazServis.ListMarkaz();
                                            Console.ReadKey();
                                            goto markazBuyruqlar;


                                            break;
                                        case 2:
                                            Console.ReadKey();
                                            markazServis.ClearMarkaz();
                                            Console.ReadKey();
                                            goto markazBuyruqlar;


                                            break;

                                        case 3:
                                            goto centerbuyruqlar;
                                            break;

                                        default:
                                            Console.WriteLine("Not found!");
                                            break;
                                    }




                                    break;
                                case 3:
                                    applicationBuyruqlar:
                                    int IndexApplication = ArrowIndex(ApplicationBuyruqlar, Name);
                                    switch (IndexApplication)
                                    {
                                        case 0:
                                            markazServis.ListApplication();
                                            Console.ReadKey();
                                            goto applicationBuyruqlar;

                                            break;
                                        case 1:
                                            markazServis.ClearApplication();
                                            Console.ReadKey();
                                            goto applicationBuyruqlar;


                                            break;
                                        case 2:
                                            goto centerbuyruqlar;
                                            break;

                                        default:
                                            Console.WriteLine("Not found!");
                                            break;
                                    }



                                    break;
                                case 4:
                                    goto qator1;




                                    break;
                            }
                            break;



                        case 1:
                            string NameStudent = "Student";
                        centerbuyruqlar1:


                            int indexStudent = ArrowIndex(CenterBuyruqlar, NameStudent);
                            switch (indexStudent)
                            {
                                case 0:

                                    markazServis.ListScience();
                                    Console.ReadKey();
                                    goto centerbuyruqlar1;
                                    break;



                                case 1:

                                    markazServis.ListTeacher();
                                    Console.ReadKey();
                                    goto centerbuyruqlar1;

                                    break;


                                case 2:
                                    markazServis.ListMarkaz();
                                    Console.ReadKey();
                                    goto centerbuyruqlar1;




                                    break;
                                case 3:
                                    markazServis.AddApplication();
                                    Console.ReadKey();
                                    goto centerbuyruqlar1;



                                    break;
                                case 4:
                                    goto qator1;

                                    break;

                            }
                    break;

                    case 2:
                        exit = true;
                            break;

                    }
            }
        }
    }
}