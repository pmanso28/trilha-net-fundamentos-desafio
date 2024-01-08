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
            Console.WriteLine("Digite a placa do veículo para estacionar:"); //Please type the license plate of the vehicle you are trying to add
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:"); //Please type the license plate of the vehicle to remove 
            
            string placa = Console.ReadLine();
            
            // Verifica se o veículo existe
            // Validates the existence of the vehicle
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:"); //Please type the amount of hours the vehicle stood parked

                int horas = 0;
                
                try
                {
                    horas = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(
                        "Houve um erro computando as horas! Por favor " +              // There was an error computing the hours parked,
                        "certifique-se de que só digitou números e tente novamente!"); // please make sure you've typed only numbers and try again.
                    RemoverVeiculo();
                }

                decimal permanencia = precoPorHora * horas;
                
                decimal valorTotal = precoInicial + permanencia;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}"); //The vehicle {License Plate} was removed and the total price was of {Price}
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. " + //Sorry, this vehicle is not parked here, 
                                  "Por favor confira se digitou a placa corretamente");  //please check if you've written the correct license plate.
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            // Check if there are any parked vehicles.
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:"); //The parked vehicles are:
                foreach (var vaga in veiculos)
                {
                    Console.WriteLine(vaga);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados."); //There are no vehicles parked
            }
        }
    }
}
