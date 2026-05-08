// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;

/// <summary>Площадь.</summary>
/// <remarks>Db: kern_catalog.oilsquare.</remarks>
public partial class OilsquareEntity 
{

	/// <summary>Создать валидатор сущности <see cref="OilsquareEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilsquareEntity> Validator(IStringLocalizer localizer)
	{
		return OilsquareEntityValidators.Validator(localizer);
	}

	/// <summary>Создать валидатор сущности <see cref="OilsquareEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilsquareEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return OilsquareEntityValidators.NullableValidator(localizer);
	}
}
