using System;

Documento documento = new Documento();
Foto foto = new Foto();

documento.Salvar();
foto.Salvar();

Console.ReadKey();

interface ISalvavel
{
    void Salvar();
}
