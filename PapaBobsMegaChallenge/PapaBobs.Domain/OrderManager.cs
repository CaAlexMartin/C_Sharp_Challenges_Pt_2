using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {

            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("Name is Required");

            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception("address is Required");

            if (orderDTO.Zip.Trim().Length == 0)
                throw new Exception("Zip Code is Required");

            if (orderDTO.Phone.Trim().Length == 0)
                throw new Exception("Phone Number is Required");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculatePizzaCost(orderDTO);
            Persistence.OrderRepository.CreateOrder(orderDTO);
        }

        public static object GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistence.OrderRepository.CompleteOrder(orderId);


        }
    }
}
