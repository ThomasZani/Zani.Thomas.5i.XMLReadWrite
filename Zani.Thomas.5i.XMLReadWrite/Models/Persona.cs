using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Zani.Thomas._5i.XMLReadWrite
{
    public class Persona
    {
        public string cognome { get; set; }
        public string nome { get; set; }

        public string telefono { get; set; }
        public string indirizzo { get; set; }


        public Persona(XElement e)
        {
            nome = e.Attribute("nome").Value;

            cognome = e.Attribute("cognome").Value;

            telefono = e.Attribute("telefono").Value;
            indirizzo = e.Attribute("indirizzo").Value;

        }

        public Persona(string _nome,string _cognome, string _telefono, string _indirizzo)
        {
            nome = _nome;
            cognome = _cognome;
            telefono = _telefono;
            indirizzo = _indirizzo;
        }
        public Persona()
        {

        }
    }
    public class Persone : List<Persona>
    {
        public string FileName { get; }
        public XElement element { get; set; }
        public Persone(string fileName)
        {
            FileName = fileName;
            element = XElement.Load(FileName);
            foreach (XElement item in element.Elements("Persona"))
            {
                Add(new Persona(item));
            }
        }

        public void Aggiungi()
        {
            Persona m = new Persona { nome = "Thomas", cognome = "zani", telefono = "3318077598", indirizzo = "via m. bruni" };

            element.Add(new XElement("Persona",
                            new XAttribute("nome", m.nome),
                            new XAttribute("cognome", m.cognome),
                            new XAttribute("indirizzo", m.indirizzo),
                            new XAttribute("telefono", m.telefono)
                    )
                );
            element.Save(FileName);
        }
    }
}