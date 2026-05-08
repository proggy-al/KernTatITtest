// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;

/// <summary>Месторождение.</summary>
/// <remarks>Db: kern_catalog.oilfield.</remarks>
public partial class OilfieldEntity 
{

	/// <summary>Создать валидатор сущности <see cref="OilfieldEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilfieldEntity> Validator(IStringLocalizer localizer)
	{
		return OilfieldEntityValidators.Validator(localizer);
	}

	/// <summary>Создать валидатор сущности <see cref="OilfieldEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilfieldEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return OilfieldEntityValidators.NullableValidator(localizer);
	}
}
