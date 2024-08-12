using Cordwell.EmailService.API.Connector;
using Cordwell.EmailService.API.Connector.Models;
using Cordwell.EmailService.Webapp.Models;
using System.Text.RegularExpressions;

namespace Cordwell.ConcreteGo.ExportTicketsUtility
{
    public class Processor
    {
        public static Task<List<Order>> ConvertCgOrderToOrderData(List<OrderRet>? orderData, CGAPIConnector concreteGoApi)
        {
            var orders = new List<Order>();
            if (orderData == null) return Task.FromResult(orders); // Returns nothing / empty
            
            foreach (var order in orderData) {
                if (
                    order.UserDefinedFields[0].UserDefinedField.Count >= 2 
                    && !order.Removed 
                    && Regex.IsMatch(order.UserDefinedFields[0].UserDefinedField[1].Value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
                    ) {
                    var newOrder = new Order {
                        orderId = order.OrderID,
                        date = order.OrderDate!.Value,
                        customer = new Customer() {
                            name = order.CustomerName,
                            customerId = order.CustomerCode,
                            email = order.UserDefinedFields[0].UserDefinedField[1].Value, // Email
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
