using DevTrackR.ShippingOrders.Application.ViewModels;
using DevTrackR.ShippingOrders.Core.Entities;

namespace DevTrackR.ShippingOrders.Application.Services
{
    public class ShippingServiceService : IShippingServiceService
    {
        public Task<List<ShippingServiceViewModel>> GetAll()
        {
            var shippingServices = new List<ShippingService> {
                new ShippingService("Selo", 0, 1.2m),
                new ShippingService("Envio com Registro", 2.2m, 5),
                new ShippingService("Envio sem Registro", 1m, 3)
            };

            return Task.FromResult(
                shippingServices
                    .Select(ShippingServiceViewModel.FromEntity)
                    .ToList()
            );
        }
    }
}