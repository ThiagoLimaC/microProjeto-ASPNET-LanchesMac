namespace LanchesMac.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        public string CarrinhCompra { get; set; }
    }
}
