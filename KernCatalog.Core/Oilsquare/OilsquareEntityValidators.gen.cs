// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Validation;

/// <summary>Проверка корректности: <see cref="OilsquareEntity"/>.</summary>
/// <remarks>Db: kern_catalog.oilsquare.</remarks>
 partial class OilsquareEntityValidators 
{

	/// <summary>Создать валидатор сущности <see cref="OilsquareEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilsquareEntity> Validator(IStringLocalizer localizer)
	{
		var validator = new Validator<OilsquareEntity>(conf =>
			{
				conf.DisallowNullInstance();
				conf.RuleFor(o => o.Uid).SetValidator(new Uid(localizer));
				conf.RuleFor(o => o.Oilsquarenaim).SetValidator(new Oilsquarenaim(localizer));
				conf.RuleFor(o => o.Oilsquarecomment).SetValidator(new Oilsquarecomment(localizer));
				conf.RuleFor(o => o.OilfieldUid).SetValidator(new OilfieldUid(localizer));
				OnValidatorBuild?.Invoke(conf, localizer);
			},
			localizer
		);
		return validator;
	}

	/// <summary>Создать валидатор сущности <see cref="OilsquareEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<OilsquareEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return Validator(localizer).ResolveNullableValidator(localizer);
	}
	/// <summary>Построитель валидатора.</summary>
	/// <param name="validator">Валидатор.</param>
	/// <param name="localizer">Локализатор.</param>
	public delegate void ValidatorBuildHandler(Validator<OilsquareEntity> validator, IStringLocalizer localizer);
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
	/// <remarks>Db: oilsquarenaim character varying(2048).</remarks>
	public partial class Oilsquarenaim : Validator<string>
	{
	
		/// <inheritdoc/>
		public Oilsquarenaim(IStringLocalizer localizer)
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
	/// <remarks>Db: oilsquarecomment character varying(2048).</remarks>
	public partial class Oilsquarecomment : Validator<string>
	{
	
		/// <inheritdoc/>
		public Oilsquarecomment(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(2048)
				.WithName(localizer["Комментарий."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Месторождение.</summary>
	/// <remarks>Db: oilfield_uid uuid.</remarks>
	public partial class OilfieldUid : Validator<Guid>
	{
	
		/// <inheritdoc/>
		public OilfieldUid(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.NotEmpty()
				.WithName(localizer["Месторождение."]);
			OnRuleBuild(rule);
		}
	}

}
