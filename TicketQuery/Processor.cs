using ConcreteGo.SDK.Models.Tickets;
using Cordwell.ConcreteGo.ExportTicketsUtility.Models;

namespace TicketQuery
{
    public class Processor
    {
       public static Task<List<RunData>> ConvertCgTicketsToRunData(List<TicketRet> ticketData)
        {
            var result = new List<RunData>();
                foreach (var ticket in ticketData) {
                    foreach (var product in ticket.Products.Product) {
                        var runItem = new RunData
                        {
                            Ship_Date = (DateTime)ticket.PrintedTime,
                            Ticket_Number = ticket.TicketCode,
                            Ticket_Id = ticket.TicketID,
                            Plant_Id = ticket.PlantCode,
                            PlantDesc = ticket.PlantName,
                            Job_ID = ticket.OrderID,
                            Customer_PO_Number = ticket.PurchaseOrder,
                            Customer_Name = ticket.CustomerName,
                            Customer_Number = ticket.CustomerCode,
                            Qty = product.PriceQty,
                            Price = product.Price,
                            Address1 = ticket.DeliveryAddr1,
                            Address2 = ticket.DeliveryAddr2,
                            Address3 = ticket.DeliveryAddr3,
                            Prepared_For_Billing_Flag = ticket.Reviewed,
                            Status_ID = ticket.CurrentStatus,
                            Product_Number = product.ItemCode,
                            UOM = product.PriceQtyUnit,
                            Truck_Number = ticket.TruckCode,
                            ProdDesc = product.Description,
                            Order_Date = (DateTime)ticket.OrderDate,
                            reviewed = ticket.Reviewed,
                            Order_Id = ticket.OrderID,
                            Order_Code = ticket.OrderCode,
                            Project_Code = ticket.ProjectCode,
                            Project_Name = ticket.ProjectName,
                            Purchase_Order = ticket.PurchaseOrder,
                            Job_Number = ticket.JobNumber,
                            Tax_Code = ticket.TaxCode,
                            Current_Status = ticket.CurrentStatus,
                            Active_Status = ticket.Active,
                            Item_Code = product.ItemCode,
                            Tax_Amount = product.TaxAmount,
                            Price_Amount = product.Amount,
                            Account_Link_Code = product.AccountLinkCode,
                            TicketQty = product.TicketQty == null ? 0 : (decimal)product.TicketQty,
                            TicketAmount = ticket.Amount == null ? 0 : (decimal)ticket.Amount,
                            IsMix = product.IsMix
                        };
                        if (ticket.PlantCode == "YAN1" || ticket.PlantCode == "YAN2")
                        {
                            runItem.MyobItemNumber = "4" + runItem.Account_Link_Code;
                        }
                        else
                        {
                            runItem.MyobItemNumber = "6" + runItem.Account_Link_Code;
                        }
                       
                        if (product.IsMix == true)
                        {
                            runItem.Product_Type_ID = 1;
                        }
                        else
                        {
                            runItem.Product_Type_ID = 5;
                        }
                        result.Add(runItem);
                    }
                    
                    
                    //TODO Check for any nulls. If there is a null return location.
                }
                return Task.FromResult(result);
        }
        
    }
}
