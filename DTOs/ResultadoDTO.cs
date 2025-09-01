using myapp.Models;

namespace myapp.Dtos
{
    public class ResultadoDTO(string r, List<Rolagem> rl)
    {
        public string Resultado { get; set; } = r;
        public List<Rolagem> Rolagens { get; set; } = rl;
    }
}