using Agenda.Datos;
using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Logica
{
    public class LogicaPersonas
    {
        private RepositorioPersonas _repositorioPersonas;

        public LogicaPersonas()
        {
            _repositorioPersonas = new RepositorioPersonas();
        }

        public void InsertaPersona(Persona persona)
        {
            _repositorioPersonas.InsertaPersona(persona);
        }

        public Persona ObtienePersona(int id)
        {
            return _repositorioPersonas.ObtienePersona(id);
        }
    }
}
