using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarData17_05_2021
{

    /// <summary>
    /// Use Para Coletar Uma Data, 
    /// Use Para Imprimir Uma Data, 
    /// Possiveis Erros:
    /// FormatException
    /// </summary>
    public class PegarData
    {
        /// <summary>
        /// Este método retorna uma Data,
        /// Erro possivel FormatException
        /// </summary>
        /// <returns>Retorna um DateTime</returns>
        public DateTime PegarDataProximaDaRealidade()
        {
            Console.WriteLine("Informe o Ano");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Mês");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Dia");
            int dia = Convert.ToInt32(Console.ReadLine());

            ValidarData(ano, mes, dia);

            return new DateTime(ano, mes, dia);
        }

        /// <summary>
        /// Este Método Imprime na tela uma Data,
        /// </summary>
        /// <param name="data">Data para imprimir</param>
        public void MostrarData(DateTime data)
        {
            Console.WriteLine("Mostrando Data:");
            Console.WriteLine("Ano: " + data.Year);
            Console.WriteLine("Mês: " + data.Month);
            Console.WriteLine("Dia: " + data.Day);
        }
        private static void ValidarData(int ano, int mes, int dia)
        {
            if (mes > 12 || mes <= 0)
            {
                throw new FormatException("Mês não pode ser igual a Zero");
            }
            else if (dia == 0)
            {
                throw new FormatException("Dia Não pode ser igual a Zero");
            }
            else if (ano == 0)
            {
                throw new FormatException("Ano Não Pode Ser Igual a Zero");
            }
            else if (ano < 1000 || ano > 3000)
            {
                throw new FormatException("Ano Muito Distante Da Realidade");
            }

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia > 31)
                {
                    throw new FormatException("Dia não pode ter mais que 31 dias no mês selecionado");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia > 30)
                {
                    throw new FormatException("Dia não pode ter mais que 30 dias no mês selecionado");
                }
            }
            else if (mes == 2)
            {
                float aux = ano % 4;

                if (aux == 0)
                {
                    if (dia > 29)
                    {
                        throw new FormatException("Dia não pode ter mais que 29 dias no mês e ano selecionado");

                    }
                }
                if (aux != 0)
                {
                    if (dia > 28)
                    {
                        throw new FormatException("Dia não pode ter mais que 28 dias no mês e ano selecionado");

                    }
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            //Minha Classe para manipular datas
            PegarData data = new PegarData();

            //tratamento de exception para FormatException
            try
            {
                // criando e pegando os dados da Data
                DateTime DataQualquer = data.PegarDataProximaDaRealidade();

                Console.WriteLine("Data Valida!");

                //mostrando a data Valida
                data.MostrarData(DataQualquer);
            }
            catch (FormatException ex)
            {
                //mostrando o Erro
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n"+ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nObrigado Por Usar a linha de pegar Datas MeisterClub\nVolte Sempre!");
            }
        }




    }
}
