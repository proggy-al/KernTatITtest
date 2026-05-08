// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Validation;

/// <summary>Проверка корректности: <see cref="NgduEntity"/>.</summary>
/// <remarks>Db: kern_catalog.ngdu.</remarks>
 partial class NgduEntityValidators 
{

	/// <summary>Создать валидатор сущности <see cref="NgduEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<NgduEntity> Validator(IStringLocalizer localizer)
	{
		var validator = new Validator<NgduEntity>(conf =>
			{
				conf.DisallowNullInstance();
				conf.RuleFor(o => o.Uid).SetValidator(new Uid(localizer));
				conf.RuleFor(o => o.Ngdunaim).SetValidator(new Ngdunaim(localizer));
				conf.RuleFor(o => o.Ngducomment).SetValidator(new Ngducomment(localizer));
				conf.RuleFor(o => o.Act).SetValidator(new Act(localizer));
				OnValidatorBuild?.Invoke(conf, localizer);
			},
			localizer
		);
		return validator;
	}

	/// <summary>Создать валидатор сущности <see cref="NgduEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<NgduEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return Validator(localizer).ResolveNullableValidator(localizer);
	}
	/// <summary>Построитель валидатора.</summary>
	/// <param name="validator">Валидатор.</param>
	/// <param name="localizer">Локализатор.</param>
	public delegate void ValidatorBuildHandler(Validator<NgduEntity> validator, IStringLocalizer localizer);
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
	/// <remarks>Db: ngdunaim character varying(2048).</remarks>
	public partial class Ngdunaim : Validator<string>
	{
	
		/// <inheritdoc/>
		public Ngdunaim(IStringLocalizer localizer)
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
	/// <remarks>Db: ngducomment character varying(2048).</remarks>
	public partial class Ngducomment : Validator<string>
	{
	
		/// <inheritdoc/>
		public Ngducomment(IStringLocalizer localizer)
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
