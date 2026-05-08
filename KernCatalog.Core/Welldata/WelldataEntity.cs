// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;

/// <summary>Скважина.</summary>
/// <remarks>Db: kern_catalog.welldata.</remarks>
public partial class WelldataEntity 
{

	/// <summary>Создать валидатор сущности <see cref="WelldataEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<WelldataEntity> Validator(IStringLocalizer localizer)
	{
		return WelldataEntityValidators.Validator(localizer);
	}

	/// <summary>Создать валидатор сущности <see cref="WelldataEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<WelldataEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return WelldataEntityValidators.NullableValidator(localizer);
	}
}
