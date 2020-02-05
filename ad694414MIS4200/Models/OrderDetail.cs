namespace ad694414MIS4200.Models
{
    public class OrderDetail
    {
        public int orderDetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }

        //link order detail to order
        public int orderId { get; set; }
        public int MyProperty { get; set; }
    }
}