///////////// zadanie 1 /////////////////////
//using Rekrutacja.Workers.Template;
//using Soneta.Business;
//using Soneta.Kadry;
//using Soneta.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//[assembly: Worker(typeof(TemplateWorker), typeof(Pracownicy))]
//namespace Rekrutacja.Workers.Template
//{
//    public class TemplateWorker
//    {
//        public class TemplateWorkerParametry : ContextBase
//        {

//            [Caption("A:")]
//            public int A { get; set; }

//            [Caption("B:")]
//            public int B { get; set; }

//            [Caption("Data obliczeń")]
//            public Date DataObliczen { get; set; }

//            [Caption("Operacja")]
//            public string Operacja { get; set; }
//            public TemplateWorkerParametry(Context context) : base(context)
//            {
//                this.DataObliczen = Date.Today;
//            }
//        }
//        [Context]
//        public Context Cx { get; set; }
//        [Context]
//        public TemplateWorkerParametry Parametry { get; set; }
//        [Action("Kalkulator",
//           Description = "Prosty kalkulator",
//           Priority = 10,
//           Mode = ActionMode.ReadOnlySession,
//           Icon = ActionIcon.Accept,
//           Target = ActionTarget.ToolbarWithText)]
//        public void WykonajAkcje()
//        {
//            DebuggerSession.MarkLineAsBreakPoint();
//            double a = this.Parametry.A;
//            double b = this.Parametry.B;
//            string operacja = this.Parametry.Operacja;
//            Date dataObliczen = this.Parametry.DataObliczen;
//            List<Pracownik> pracownicy = ((Pracownik[])this.Cx[typeof(Pracownik[])]).ToList();

//            using (Session nowaSesja = this.Cx.Login.CreateSession(false, false, "ModyfikacjaPracownika"))
//            {
//                using (ITransaction trans = nowaSesja.Logout(true))
//                {
//                    foreach (var pracownik in pracownicy)
//                    {
//                        var pracownikZSesja = nowaSesja.Get(pracownik);
//                        switch (operacja)
//                        {
//                            case "+":
//                                pracownikZSesja.Features["Wynik"] = a + b;
//                                break;

//                            case "-":
//                                pracownikZSesja.Features["Wynik"] = a - b;
//                                break;

//                            case "/":
//                                if (b != 0)
//                                    pracownikZSesja.Features["Wynik"] = a / b;
//                                break;

//                            case "*":
//                                pracownikZSesja.Features["Wynik"] = a * b;
//                                break;
//                            default:
//                                continue;
//                        }

//                        pracownikZSesja.Features["DataObliczen"] = dataObliczen;
//                    }

//                    trans.CommitUI();
//                }
//                nowaSesja.Save();
//            }
//        }
//    }
//}
///////////////////////////////////
///

///////////////// Zadanie 2 //////////////////////
//using Rekrutacja.Workers.Template;
//using Soneta.Business;
//using Soneta.Kadry;
//using Soneta.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//[assembly: Worker(typeof(TemplateWorker), typeof(Pracownicy))]
//namespace Rekrutacja.Workers.Template
//{
//    public enum Figura
//    {
//        kwadrat,
//        prostokat,
//        trojkat,
//        kolo
//    }
//    public class TemplateWorker
//    {
//        public class TemplateWorkerParametry : ContextBase
//        {

//            [Caption("A:")]
//            public int A { get; set; }

//            [Caption("B:")]
//            public int B { get; set; }

//            [Caption("Data obliczeń")]
//            public Date DataObliczen { get; set; }

//            [Caption("Figura")]
//            public Figura Figura { get; set; }
//            public TemplateWorkerParametry(Context context) : base(context)
//            {
//                this.DataObliczen = Date.Today;
//            }
//        }
//        [Context]
//        public Context Cx { get; set; }
//        [Context]
//        public TemplateWorkerParametry Parametry { get; set; }
//        [Action("Kalkulator",
//           Description = "Prosty kalkulator",
//           Priority = 10,
//           Mode = ActionMode.ReadOnlySession,
//           Icon = ActionIcon.Accept,
//           Target = ActionTarget.ToolbarWithText)]
//        public void WykonajAkcje()
//        {
//            DebuggerSession.MarkLineAsBreakPoint();
//            double a = this.Parametry.A;
//            double b = this.Parametry.B;
//            Figura figura = this.Parametry.Figura;
//            Date dataObliczen = this.Parametry.DataObliczen;
//            List<Pracownik> pracownicy = ((Pracownik[])this.Cx[typeof(Pracownik[])]).ToList();

//            using (Session nowaSesja = this.Cx.Login.CreateSession(false, false, "ModyfikacjaPracownika"))
//            {
//                using (ITransaction trans = nowaSesja.Logout(true))
//                {
//                    foreach (var pracownik in pracownicy)
//                    {
//                        var pracownikZSesja = nowaSesja.Get(pracownik);
//                        switch (figura)
//                        {
//                            case Figura.prostokat:
//                                pracownikZSesja.Features["Wynik"] = FormatujWynik(a * b);
//                                break;

//                            case Figura.kolo:
//                                pracownikZSesja.Features["Wynik"] = FormatujWynik(Math.Pow(a, 2) * Math.PI);
//                                break;

//                            case Figura.kwadrat:
//                                pracownikZSesja.Features["Wynik"] = FormatujWynik(Math.Pow(a, 2));
//                                break;

//                            case Figura.trojkat:
//                                pracownikZSesja.Features["Wynik"] = FormatujWynik((a * b) / 2);
//                                break;
//                            default:
//                                continue;
//                        }

//                        pracownikZSesja.Features["DataObliczen"] = dataObliczen;
//                    }

//                    trans.CommitUI();
//                }
//                nowaSesja.Save();
//            }
//        }

//        double FormatujWynik(double number) => Convert.ToDouble(Convert.ToInt32(number));
//    }
//}
//////////////////////////////////


///////////////////////// zadanie 3 ////////////////////////////////
//using Rekrutacja.Workers.Template;
//using Soneta.Business;
//using Soneta.Kadry;
//using Soneta.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//[assembly: Worker(typeof(TemplateWorker), typeof(Pracownicy))]
//namespace Rekrutacja.Workers.Template
//{
//    public enum Figura
//    {
//        kwadrat,
//        prostokat,
//        trojkat,
//        kolo
//    }
//    public class TemplateWorker
//    {
//        public class TemplateWorkerParametry : ContextBase
//        {

//            [Caption("A:")]
//            public string A { get; set; }

//            [Caption("B:")]
//            public string B { get; set; }

//            [Caption("Data obliczeń")]
//            public Date DataObliczen { get; set; }

//            [Caption("Figura")]
//            public Figura Figura { get; set; }
//            public TemplateWorkerParametry(Context context) : base(context)
//            {
//                this.DataObliczen = Date.Today;
//            }
//        }
//        [Context]
//        public Context Cx { get; set; }
//        [Context]
//        public TemplateWorkerParametry Parametry { get; set; }
//        [Action("Kalkulator",
//           Description = "Prosty kalkulator",
//           Priority = 10,
//           Mode = ActionMode.ReadOnlySession,
//           Icon = ActionIcon.Accept,
//           Target = ActionTarget.ToolbarWithText)]
//        public void WykonajAkcje()
//        {
//            DebuggerSession.MarkLineAsBreakPoint();
//            double a = KonwertujNaLiczbeTypuInt(this.Parametry.A);
//            double b = KonwertujNaLiczbeTypuInt(this.Parametry.B);
//            Figura figura = this.Parametry.Figura;
//            Date dataObliczen = this.Parametry.DataObliczen;
//            List<Pracownik> pracownicy = ((Pracownik[])this.Cx[typeof(Pracownik[])]).ToList();

//            using (Session nowaSesja = this.Cx.Login.CreateSession(false, false, "ModyfikacjaPracownika"))
//            {
//                using (ITransaction trans = nowaSesja.Logout(true))
//                {

//                    if (a != 0 && b != 0)
//                    {
//                        foreach (var pracownik in pracownicy)
//                        {
//                            var pracownikZSesja = nowaSesja.Get(pracownik);
//                            switch (figura)
//                            {
//                                case Figura.prostokat:
//                                    pracownikZSesja.Features["Wynik"] = FormatujWynik(a * b);
//                                    break;

//                                case Figura.kolo:
//                                    pracownikZSesja.Features["Wynik"] = FormatujWynik(Math.Pow(a, 2) * Math.PI);
//                                    break;

//                                case Figura.kwadrat:
//                                    pracownikZSesja.Features["Wynik"] = FormatujWynik(Math.Pow(a, 2));
//                                    break;

//                                case Figura.trojkat:
//                                    pracownikZSesja.Features["Wynik"] = FormatujWynik((a * b) / 2);
//                                    break;
//                                default:
//                                    continue;
//                            }

//                            pracownikZSesja.Features["DataObliczen"] = dataObliczen;
//                        }

//                        trans.CommitUI();

//                    }

//                }
//                nowaSesja.Save();
//            }
//        }

//        double FormatujWynik(double numer) => Convert.ToDouble(Convert.ToInt32(numer));

//        int KonwertujNaLiczbeTypuInt(string liczba)
//        {
//            int wynik = 0;

//            if (!String.IsNullOrEmpty(liczba) && CzyLiczba(liczba))
//            {
//                liczba = liczba.Replace(" ", string.Empty).Trim();
//                int i = 0;

//                foreach (char znak in liczba)
//                {
//                    wynik = wynik * 10 + (liczba[i] - '0');
//                    i++;
//                }
//                return wynik;
//            }
//            return wynik;

//        }
//        bool CzyLiczba(string liczba)
//        {
//            liczba = liczba.Replace(" ", string.Empty).Trim();
//            foreach (char znak in liczba)
//            {
//                if (!char.IsNumber(znak))
//                    return false;
//            }
//            return true;
//        }
//    }
//}
