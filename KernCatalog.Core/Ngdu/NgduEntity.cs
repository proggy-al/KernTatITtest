// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;

/// <summary>НГДУ.</summary>
/// <remarks>Db: kern_catalog.ngdu.</remarks>
public partial class NgduEntity 
{

	/// <summary>Создать валидатор сущности <see cref="NgduEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<NgduEntity> Validator(IStringLocalizer localizer)
	{
		return NgduEntityValidators.Validator(localizer);
	}

	/// <summary>Создать валидатор сущности <see cref="NgduEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<NgduEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return NgduEntityValidators.NullableValidator(localizer);
	}
}
