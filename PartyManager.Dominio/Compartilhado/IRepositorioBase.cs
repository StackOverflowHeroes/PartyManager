namespace PartyManager.Dominio.Compartilhado
{
    public interface IRepositorioBase<T>
    {    
        public void Inserir(T novoCliente);
        public void Editar(int id, T registro);
        public void Deletar(T clienteSelecionado);
        public List<T> SelecionarTodos();
        public T SelecionarPorId(int id);
    }
}
