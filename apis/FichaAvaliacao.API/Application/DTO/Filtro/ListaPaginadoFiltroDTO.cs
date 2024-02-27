using Core.Util.Model;

namespace FichaAvaliacao.API.Application.DTO.Filtro
{
    public class ListaPaginadoFiltroDTO : PageRequest
    {
        /// <summary>
        /// Filtro por nome para busca
        /// </summary>
        public string Nome { get; set; }
    }
}
