using Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class DBPressaoService
    {
        public bool Inserir(Pressao newEntrada)
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                newEntrada.Id = Guid.NewGuid();
                var entradaCollection = db.GetCollection<Pressao>("entradas");
                entradaCollection.Insert(newEntrada);
                return true;
            }
        }

        public List<Pressao> Listar()
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                var entradaCollection = db.GetCollection<Pressao>("entradas");
                return entradaCollection.FindAll().ToList();
            }
        }

        public bool Excluir(Guid id)
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                var entradaCollection = db.GetCollection<Pressao>("entradas");
                return entradaCollection.Delete(id);
            }
        }

        public Pressao BuscaPorId(Guid id)
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                var entradaCollection = db.GetCollection<Pressao>("entradas");
                return entradaCollection.FindOne(x => x.Id == id);
            }
        }

        public bool Alterar(Pressao obj)
        {
            using (var db = new LiteDB.LiteDatabase("BancoDeDados.db"))
            {
                var entradaCollection = db.GetCollection<Pressao>("entradas");
                var result = entradaCollection.FindOne(x => x.Id == obj.Id);

                result.Data = obj.Data;
                result.Sistolica = obj.Sistolica;
                result.Diastolica = obj.Diastolica;
                result.Batimentos = obj.Batimentos;
                result.Periodo = obj.Periodo;

                return entradaCollection.Update(result);
            }
        }
    }
}
