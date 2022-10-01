using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Sala
    {
        int _id;
        string _identificacao;
        string _descricao;
        int _estado;
        int _voltagem;
        int _medidaLado1EmMetros;
        int _medidalado2EmMetros;
        int _numeroMaximoDePessoas;
        int _janelas;
        Endereco _localizacao;
        bool _temBanheiro;
        bool _temEstacionamento;
        bool _temArCondicionado;
        bool _temSeguro;
        List<string> _fotos;
    }
}
