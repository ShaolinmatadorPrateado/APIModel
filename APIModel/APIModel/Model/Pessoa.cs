namespace APIModel.Model
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Celular { get; set; }

        public DateOnly DataNascimento { get; set; }

        //Método contendo os dados 

        public List<Pessoa> Dados()
        {
            var Lista = new List<Pessoa>();

            var ListaPessoa = new List<Pessoa>();


            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "João Sebastião";

            var vPessoa2 = new Pessoa();
            vPessoa2.Id = 2;
            vPessoa2.Nome = "Maria Vetoria";

            var vPessoa3 = new Pessoa();
            vPessoa3.Id = 3;
            vPessoa3.Nome = "Marcus Vinicius";

            ListaPessoa.Add(vPessoa);
            ListaPessoa.Add(vPessoa2);
            ListaPessoa.Add(vPessoa3);

            return ListaPessoa; 
        }

    }
}
