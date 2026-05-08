// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Infra.PostgreSql;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Entities;

/// <summary>Месторождение.</summary>
/// <remarks>Db: kern_catalog.oilfield.</remarks>
[EntityWithAudit]
internal partial class OilfieldDb : Entity<Guid>
{

	/// <summary>Модель БД.</summary>
	internal static readonly ModelTable Model = 
		new(
			typeof(OilfieldDb),
			"kern_catalog",
			"oilfield",
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
	/// <remarks>Db: oilfieldnaim character varying(2048).</remarks>
	[AllowNull]
	public string Oilfieldnaim { get; set; } = default!;

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: oilfieldcomment character varying(2048).</remarks>
	[AllowNull]
	public string Oilfieldcomment { get; set; } = default!;
}
