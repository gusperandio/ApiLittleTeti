using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LittleTeti.Extensions;

public static class ModelStateExtension
{
    public static List<string> GetErrors(this ModelStateDictionary modelState)
    {
        var result = new List<string>();
        foreach (var errors in modelState.Values)
            result.AddRange(errors.Errors.Select(error => error.ErrorMessage));

        return result;
    }
}