using System;

namespace DiarioPressao.Models
{
    public class EntradaDTO
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public int Sistolica { get; set; }
        public int Diastolica { get; set; }
        public int Batimentos { get; set; }
    }
}