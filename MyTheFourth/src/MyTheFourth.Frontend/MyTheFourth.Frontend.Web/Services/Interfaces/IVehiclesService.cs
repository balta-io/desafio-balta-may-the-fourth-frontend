using MyTheFourth.Frontend.Web.Models;

namespace MyTheFourth.Frontend.Web.Services.Interfaces;

public interface IVehiclesService
{

    public Task<Vehicle?> GetVehicleAsync(string vehicleId);
    public Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page = null, int? pageSize = null);
}