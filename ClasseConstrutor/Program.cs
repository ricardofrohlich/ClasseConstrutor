namespace ClasseConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal a = new Animal("Caramelo", "Caramelo", "15", "Cachorro");
            a.raca = "Leão";
             a.especie = "Felino";
             a.cor = "Amarelo";
             a.peso = "337";
            // a.codigo = 1000;

            Console.WriteLine("Raça: "+a.raca+" Especie: "+a.especie);
            Console.WriteLine("Código na main: "+a.getCodigo());*/
            string cabelo, nome, cpf, email;
            Console.WriteLine("Digite a cor de cabelo: ");
            cabelo = Console.ReadLine();
            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF da pessoa: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite o email da pessoa: ");
            email = Console.ReadLine();
            Pessoa p = new Pessoa(cabelo, nome, cpf, email);
            Console.WriteLine("Pessoa instanciada com sucesso!");
            Console.WriteLine("Nome: "+p.nome);
            Console.WriteLine("CPF: "+p.cpf);
            Console.WriteLine("E-mail: "+p.email);
            Console.WriteLine("Cabelo cor: "+p.cordocabelo);


        }
    }
}