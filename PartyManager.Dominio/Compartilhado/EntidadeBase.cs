﻿namespace PartyManager.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
          public int id;

          public abstract void AtualizarRegistros(TEntidade registroAtualizado);

          public abstract string[] ValidarErros();
    }
}