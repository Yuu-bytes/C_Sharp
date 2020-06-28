using DiarioPressao.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiarioPressao
{
    public class DataBase
    {
        public bool Inserir(EntradaDTO newEntrada)
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                newEntrada.Id = Guid.NewGuid();
                var entradaCollection = db.GetCollection<EntradaDTO>("entradas");
                entradaCollection.Insert(newEntrada);
                return true;
            }
        }

        public List<EntradaDTO> Listar()
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                var entradaCollection = db.GetCollection<EntradaDTO>("entradas");
                return entradaCollection.FindAll().ToList();
            }
        }
    }
}