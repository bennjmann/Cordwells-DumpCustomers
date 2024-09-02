using ConcreteGo.SDK.Models.Orders;
using Cordwell.EmailService.Webapp.Models;

namespace Cordwell.ConcreteGo.ExportTicketsUtility
{
    public class Processor
    {
        public static Task<List<Order>> ConvertCgOrderToOrderData(List<OrderRet>? orderData)
        {
            var orders = new List<Order>();
            if (orderData == null) return Task.FromResult(orders); // Returns nothing / empty
            
            foreach (var order in orderData) {
                if (order?.UserDefinedFields?.UserDefinedField?.Count >= 2 && order.Removed != 1) {
                    var newOrder = new Order {
                        orderId = order.OrderID,
                        date = order.OrderDate!.Value,
                        customer = new Customer() {
                            name = order.CustomerName,
                            customerId = order.CustomerCode,
                            email = order.UserDefinedFields.UserDefinedField[1].Value, // Email
                            emailTwo = order.UserDefinedFields.UserDefinedField[0].Value, // Email
                        }
                    };

                    if (!orders.Exists(o => o.customer.name == newOrder.customer.name)) {
                        orders.Add(newOrder);
                    }
                }
            }
            
            return Task.FromResult(orders);
        }
        
    }
}
