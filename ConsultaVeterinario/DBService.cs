using ConsultaVeterinario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaVeterinario
{
    public class DBService
    {
        public bool Cadastrar(Dados entrada)
        {
            using (var db = new LiteDB.LiteDatabase("Contas.db"))
            {
                entrada.Id = Guid.NewGuid();
                var entradaCollection = db.GetCollection<Dados>("entradas");
                entradaCollection.Insert(entrada);
                return true;
            }
        }
        public Dados BuscaPorId(Guid id)
        {
            using (var db = new LiteDB.LiteDatabase("Contas.db"))
            {
                var entradaCollection = db.GetCollection<Dados>("entradas");
                return entradaCollection.FindOne(x => x.Id == id);
            }
        }

        public bool Alterar(Dados obj)
        {
            using (var db = new LiteDB.LiteDatabase("Contas.db"))
            {
                var entradaCollection = db.GetCollection<Dados>("entradas");
                var result = entradaCollection.FindOne(x => x.Id == obj.Id);

                result.Animal = obj.Animal;
                result.DataHora = obj.DataHora;
                result.Consulta = obj.Consulta;

                return entradaCollection.Update(result);
            }
        }

        public List<Dados> Listar()
        {
            using (var db = new LiteDB.LiteDatabase("Contas.db"))
            {
                var entradaCollection = db.GetCollection<Dados>("entradas");
                return entradaCollection.FindAll().ToList();
            }
        }
    }
}
