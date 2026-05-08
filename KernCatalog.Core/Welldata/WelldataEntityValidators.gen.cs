// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using FluentValidation;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Validation;

/// <summary>Проверка корректности: <see cref="WelldataEntity"/>.</summary>
/// <remarks>Db: kern_catalog.welldata.</remarks>
 partial class WelldataEntityValidators 
{

	/// <summary>Создать валидатор сущности <see cref="WelldataEntity"/>.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<WelldataEntity> Validator(IStringLocalizer localizer)
	{
		var validator = new Validator<WelldataEntity>(conf =>
			{
				conf.DisallowNullInstance();
				conf.RuleFor(o => o.Uid).SetValidator(new Uid(localizer));
				conf.RuleFor(o => o.Wellnum).SetValidator(new Wellnum(localizer));
				conf.RuleFor(o => o.Wellcategory).SetValidator(new Wellcategory(localizer));
				conf.RuleFor(o => o.Svn).SetValidator(new Svn(localizer));
				conf.RuleFor(o => o.Wellx).SetValidator(new Wellx(localizer));
				conf.RuleFor(o => o.Welly).SetValidator(new Welly(localizer));
				conf.RuleFor(o => o.Wella).SetValidator(new Wella(localizer));
				conf.RuleFor(o => o.OilsquareUid).SetValidator(new OilsquareUid(localizer));
				conf.RuleFor(o => o.NgduUid).SetValidator(new NgduUid(localizer));
				conf.RuleFor(o => o.UbrUid).SetValidator(new UbrUid(localizer));
				OnValidatorBuild?.Invoke(conf, localizer);
			},
			localizer
		);
		return validator;
	}

	/// <summary>Создать валидатор сущности <see cref="WelldataEntity"/>. Для null.</summary>
	/// <param name="localizer">Локализатор.</param>
	/// <returns>Валидатор.</returns>
	public static IValidator<WelldataEntity?> NullableValidator(IStringLocalizer localizer)
	{
		return Validator(localizer).ResolveNullableValidator(localizer);
	}
	/// <summary>Построитель валидатора.</summary>
	/// <param name="validator">Валидатор.</param>
	/// <param name="localizer">Локализатор.</param>
	public delegate void ValidatorBuildHandler(Validator<WelldataEntity> validator, IStringLocalizer localizer);
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
	
	/// <summary>Номер.</summary>
	/// <remarks>Db: wellnum character varying(100).</remarks>
	public partial class Wellnum : Validator<string>
	{
	
		/// <inheritdoc/>
		public Wellnum(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(100)
				.WithName(localizer["Номер."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Категория.</summary>
	/// <remarks>Db: wellcategory character varying(100).</remarks>
	public partial class Wellcategory : Validator<string>
	{
	
		/// <inheritdoc/>
		public Wellcategory(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.MaximumLength(100)
				.WithName(localizer["Категория."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Относится к СВН.</summary>
	/// <remarks>Db: svn boolean.</remarks>
	public partial class Svn : Validator<bool>
	{
	
		/// <inheritdoc/>
		public Svn(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.WithName(localizer["Относится к СВН."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Широта.</summary>
	/// <remarks>Db: wellx numeric(10,2).</remarks>
	public partial class Wellx : Validator<decimal>
	{
	
		/// <inheritdoc/>
		public Wellx(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.WithName(localizer["Широта."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Долгота.</summary>
	/// <remarks>Db: welly numeric(10,2).</remarks>
	public partial class Welly : Validator<decimal>
	{
	
		/// <inheritdoc/>
		public Welly(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.WithName(localizer["Долгота."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Альтитуда.</summary>
	/// <remarks>Db: wella numeric(10,2).</remarks>
	public partial class Wella : Validator<decimal>
	{
	
		/// <inheritdoc/>
		public Wella(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.WithName(localizer["Альтитуда."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>Площадь.</summary>
	/// <remarks>Db: oilsquare_uid uuid.</remarks>
	public partial class OilsquareUid : Validator<Guid>
	{
	
		/// <inheritdoc/>
		public OilsquareUid(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.NotEmpty()
				.WithName(localizer["Площадь."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>НГДУ.</summary>
	/// <remarks>Db: ngdu_uid uuid.</remarks>
	public partial class NgduUid : Validator<Guid>
	{
	
		/// <inheritdoc/>
		public NgduUid(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.NotEmpty()
				.WithName(localizer["НГДУ."]);
			OnRuleBuild(rule);
		}
	}
	
	/// <summary>УБР.</summary>
	/// <remarks>Db: ubr_uid uuid.</remarks>
	public partial class UbrUid : Validator<Guid>
	{
	
		/// <inheritdoc/>
		public UbrUid(IStringLocalizer localizer)
			: base(localizer)
		{
			var rule = RuleFor(v => v)
				.NotNull()
				.NotEmpty()
				.WithName(localizer["УБР."]);
			OnRuleBuild(rule);
		}
	}

}
