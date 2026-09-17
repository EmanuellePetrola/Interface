using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
        class CampoTexto : CampoFormulario, IValidavel
        {
            public CampoTexto(string nomeDoCampo, string valor)
                : base(nomeDoCampo, valor)
            {
            }

            public bool Validar()
            {
                return !string.IsNullOrWhiteSpace(Valor);
            }
        
    
