using myapp.Models;

namespace myapp.Dtos
{
    public class ResultadoDTO
    {
        public string Resultado { get; set; }
        public List<Rolagem> Rolagens { get; set; }
        public ResultadoDTO(string r, List<Rolagem> rl){
            Resultado = r;
            Rolagens = rl;
        }
    }
}