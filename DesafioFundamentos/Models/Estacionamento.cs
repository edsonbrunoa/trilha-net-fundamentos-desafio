namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // *IMPLEMENTADO*
            String recebendoVeiculos = Console.ReadLine();
            veiculos.Add(recebendoVeiculos);
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");

            // *IMPLEMENTADO*
            String recebendoPlaca = Console.ReadLine();
            string placa = recebendoPlaca;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // *IMPLEMENTADO*
                String quantidadeHoraEstacionado = Console.ReadLine();

                int horasEstacionado = Convert.ToInt32(quantidadeHoraEstacionado);
                int horas = 0;
                decimal valorTotal = 0; 
                
                horas = horasEstacionado;
                valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO*
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
                Console.WriteLine("-------------------------------------------------------");
            if (veiculos.Any())
            {
                Console.WriteLine("             Os veículos estacionados são:               ");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*
                int contadorVeiculos = 0;
                foreach(string veiculosListados in veiculos){
                    Console.WriteLine($"Vaga N° {contadorVeiculos} com veiculo de placa - {veiculosListados}");
                    contadorVeiculos++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
                Console.WriteLine("-------------------------------------------------------");
        }
    }
}
