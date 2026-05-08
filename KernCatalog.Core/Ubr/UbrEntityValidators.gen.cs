// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Validation;

/// <summary>Проверка корректности: <see cref="UbrEntity"/>.</summary>
/// <remarks>Db: kern_catalog.ubr.</remarks>
 partial class UbrEntityValidators 
{

	/// <summary>Создать валидатор сущности <see cref="UbrEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<UbrEntity> Validator(IStringLocalizer localizer)
	{
		var validator = new Validator<UbrEntity>(conf =>
			{
				conf.DisallowNullInstance();
				conf.RuleFor(o => o.Uid).SetValidator(new Uid(localizer));
				conf.RuleFor(o => o.Ubrnaim).SetValidator(new Ubrnaim(localizer));
				conf.RuleFor(o => o.Ubrcomment).SetValidator(new Ubrcomment(localizer));
				conf.RuleFor(o => o.Act).SetValidator(new Act(localizer));
				OnValidatorBuild?.Invoke(conf, localizer);
			},
			localizer
		);
		return validator;
	}

	/// <summary>Создать валидатор сущности <see cref="UbrEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<UbrEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return Validator(localizer).ResolveNullableValidator(localizer);
	}
	/// <summary>Построитель валидатора.</summary>
	/// <param name="validator">Валидатор.</param>
	/// <param name="localizer">Локализатор.</param>
	public delegate void ValidatorBuildHandler(Validator<UbrEntity> validator, IStringLocalizer localizer);
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
	/// <remarks>Db: ubrnaim character varying(2048).</remarks>
	public partial class Ubrnaim : Validator<string>
	{
	
		/// <inheritdoc/>
		public Ubrnaim(IStringLocalizer localizer)
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
	/// <remarks>Db: ubrcomment character varying(2048).</remarks>
	public partial class Ubrcomment : Validator<string>
	{
	
		/// <inheritdoc/>
		public Ubrcomment(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(2048)
				.WithName(localizer["Комментарий."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Актуальность.</summary>
	/// <remarks>Db: act boolean.</remarks>
	public partial class Act : Validator<bool>
	{
	
		/// <inheritdoc/>
		public Act(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.WithName(localizer["Актуальность."]);
			OnRuleBuild(rule);
		}
	}

}
