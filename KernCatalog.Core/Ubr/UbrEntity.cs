// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;

/// <summary>УБР.</summary>
/// <remarks>Db: kern_catalog.ubr.</remarks>
public partial class UbrEntity 
{

	/// <summary>Создать валидатор сущности <see cref="UbrEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<UbrEntity> Validator(IStringLocalizer localizer)
	{
		return UbrEntityValidators.Validator(localizer);
	}

	/// <summary>Создать валидатор сущности <see cref="UbrEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<UbrEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return UbrEntityValidators.NullableValidator(localizer);
	}
}
