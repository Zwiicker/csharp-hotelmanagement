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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // -- implementado --
            if (true)
            bool verificarCapacidade = Suite.Capacidade >= hospedes.Count;
            if (verificarCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // -- implementado --
            throw new Exception("Capacidade não permitida. A quantidade de hóspedes não pode exceder a capacidade  da suíte");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // -- implementado --
            int quantidadeDeHospedes = Hospedes.Count;
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // -- implementado --
            decimal valor = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // -- implementado --
            if (DiasReservados>=10)
            {
                valor = valor - valor*10/100;
            }

            return valor;
        }
    }
}