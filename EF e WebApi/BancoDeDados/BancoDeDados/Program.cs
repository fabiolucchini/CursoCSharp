namespace BancoDeDados {
    internal class Program {
        static void Main(string[] args) {
            string connectionstring = "Server=W10PROX64EN60GB\\SQLEXPRESS;Database=CursoCSharp;User Id=fabio;Password=123456;Encrypt=False; TrustServerCertificate=False;";
            Funcionario funcionario = new Funcionario();
            funcionario.ObterLista();
            funcionario.ExecutarStoreProcedure(connectionstring, 1);
            funcionario.ExecutarStoreProcedure(connectionstring, 2);
            funcionario.ExecutarStoreProcedure(connectionstring, 22);
            //funcionario.InserirDados(connectionstring);
        }
    }
}