// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Validation;

/// <summary>Проверка корректности: <see cref="OilfieldEntity"/>.</summary>
/// <remarks>Db: kern_catalog.oilfield.</remarks>
 partial class OilfieldEntityValidators 
{

	/// <summary>Создать валидатор сущности <see cref="OilfieldEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilfieldEntity> Validator(IStringLocalizer localizer)
	{
		var validator = new Validator<OilfieldEntity>(conf =>
			{
				conf.DisallowNullInstance();
				conf.RuleFor(o => o.Uid).SetValidator(new Uid(localizer));
				conf.RuleFor(o => o.Oilfieldnaim).SetValidator(new Oilfieldnaim(localizer));
				conf.RuleFor(o => o.Oilfieldcomment).SetValidator(new Oilfieldcomment(localizer));
				OnValidatorBuild?.Invoke(conf, localizer);
			},
			localizer
		);
		return validator;
	}

	/// <summary>Создать валидатор сущности <see cref="OilfieldEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilfieldEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return Validator(localizer).ResolveNullableValidator(localizer);
	}
	/// <summary>Построитель валидатора.</summary>
	/// <param name="validator">Валидатор.</param>
	/// <param name="localizer">Локализатор.</param>
	public delegate void ValidatorBuildHandler(Validator<OilfieldEntity> validator, IStringLocalizer localizer);
	/// <summary>Валидатор построен.</summary>
	public static event ValidatorBuildHandler? OnValidatorBuild;

	/// <summary>Уникальный идентификатор.</summary>
	/// <remarks>Db: uid uuid.</remarks>
	public partial class Uid : Validator<Guid?>
	{
	
		/// <inheritdoc/>
		public Uid(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.NotEmpty()
				.WithName(localizer["Уникальный идентификатор."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Наименование.</summary>
	/// <remarks>Db: oilfieldnaim character varying(2048).</remarks>
	public partial class Oilfieldnaim : Validator<string>
	{
	
		/// <inheritdoc/>
		public Oilfieldnaim(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(2048)
				.WithName(localizer["Наименование."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Комментарий.</summary>
	/// <remarks>Db: oilfieldcomment character varying(2048).</remarks>
	public partial class Oilfieldcomment : Validator<string>
	{
	
		/// <inheritdoc/>
		public Oilfieldcomment(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(2048)
				.WithName(localizer["Комментарий."]);
			OnRuleBuild(rule);
		}
	}

}
