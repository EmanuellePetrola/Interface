using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    abstract class CampoFormulario
        {
            public string NomeDoCampo { get; set; }
            public string Valor { get; set; }

            public CampoFormulario(string nomeDoCampo, string valor)
            {
                NomeDoCampo = nomeDoCampo;
                Valor = valor;
            }
        }
    }

