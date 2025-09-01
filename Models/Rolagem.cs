
namespace myapp.Models 
{
    public class Rolagem
    {
        public string Macro { get; set; }
        public List<string> Resultados { get; set; }
        public int Soma { get; set; }

        public Rolagem(string m, List<string> r, int s)
        {
            Macro = m;
            Resultados = r;
            Soma = s;
        }
    }
}