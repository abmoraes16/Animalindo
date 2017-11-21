using System;
using Pet.Dominio.ClassePai.ClassesFilhas;

namespace Repositorio
{
    public class ServicosRep : Dominio.ICrud
    {
        public string Cadastrar()
        {
        Servicos serv = new Servicos();
        string composicao = "Código do Serviço: "+ serv.IdServico+
                            "Horario do Produto: "+serv.HorarioServico+
                            "Duração do Serviço: "+serv.DuracaoServico+
                            "Preço do Serviço: "+serv.PrecoServico;
                                
        return "Informações do Serviço\n\n"+composicao; 
        }

        public string Consultar()
        {
            throw new NotImplementedException();
        }
    }
}