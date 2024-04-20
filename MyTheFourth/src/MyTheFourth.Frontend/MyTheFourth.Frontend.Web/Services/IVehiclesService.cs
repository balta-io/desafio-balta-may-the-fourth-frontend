


public interface IVehiclesService
{

    public Task<Vehicle?> GetVehicleAsync(string vehicleId);
    public Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page = null, int? pageSize = null);
}
