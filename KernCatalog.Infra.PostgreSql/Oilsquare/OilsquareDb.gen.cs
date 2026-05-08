// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Infra.PostgreSql;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Entities;

/// <summary>Площадь.</summary>
/// <remarks>Db: kern_catalog.oilsquare.</remarks>
[EntityWithAudit]
internal partial class OilsquareDb : Entity<Guid>
{

	/// <summary>Модель БД.</summary>
	internal static readonly ModelTable Model = 
		new(
			typeof(OilsquareDb),
			"kern_catalog",
			"oilsquare",
			"uid",
			"uuid"
		);

	/// <summary>Уникальный идентификатор.</summary>
	/// <remarks>Db: uid uuid.</remarks>
	public Guid? Uid
	{
		get => PkInternal;
		set => PkInternal = value;
	}

	/// <summary>Наименование.</summary>
	/// <remarks>Db: oilsquarenaim character varying(2048).</remarks>
	[AllowNull]
	public string Oilsquarenaim { get; set; } = default!;

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: oilsquarecomment character varying(2048).</remarks>
	[AllowNull]
	public string Oilsquarecomment { get; set; } = default!;

	/// <summary>Месторождение.</summary>
	/// <remarks>Db: oilfield_uid uuid.</remarks>
	public Guid OilfieldUid { get; set; }
}
