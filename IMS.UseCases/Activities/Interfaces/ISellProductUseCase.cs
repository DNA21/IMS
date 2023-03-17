using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Activities
{
    public interface ISellProductUseCase
    { 
        Task ExecuteAsync(string salesOrderNumber, Product product, int quantity, double unitPrice, string doneBy);
    }
}