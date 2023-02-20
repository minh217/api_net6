using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        BreakfastResponse CreateBreakfast(CreateBreakfastRequest request);
        BreakfastResponse GetBreakfast(Guid id);
        BreakfastResponse UpdateBreakfast(Guid id, UpsertBreakfastRequest request);
        BreakfastResponse DeleteBreakfast(Guid id);
    }
}