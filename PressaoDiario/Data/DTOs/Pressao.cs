﻿using System;

namespace Data.DTOs
{
    public class Pressao
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public int Sistolica { get; set; }
        public int Diastolica { get; set; }
        public int Batimentos { get; set; }
        public int Periodo { get; set; }
        public bool Visualizado { get; set; }
    }
}
