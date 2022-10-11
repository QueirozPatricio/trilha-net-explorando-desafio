namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTADO POR Patricio
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTADO POR Patricio
                throw new Exception("A quantidade de hospedes não pode exceder a capacidade da suíte");                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO POR Patricio            
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // *IMPLEMENTADO POR Patricio
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO POR Patricio
            if (DiasReservados >= 10)
            {
                valor -= (valor * 10/100);
            }

            return valor;
        }
    }
}