using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Pytania
    {
        public int Id { get; set; }
        public int Kategoria { get; set; }
        public string Tresc { get; set; }
        public Odpowiedz Odp1 { get; set; }
        public Odpowiedz Odp2 { get; set; }
        public Odpowiedz Odp3 { get; set; }
        public Odpowiedz Odp4 { get; set; }
        public List<Odpowiedz> Odpowiedzi { get; set; } = new List<Odpowiedz>();

    }
}

