using SolicitacoesCompras2.Model;

namespace SolicitacoesCompras2.Abstract
{
    public abstract class Approver
    {
        protected Approver successor;
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessarPedidoCompra(PedidoCompra pedido);
    }
}
