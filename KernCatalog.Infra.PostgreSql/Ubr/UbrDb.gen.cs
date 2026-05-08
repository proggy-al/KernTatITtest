// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Infra.PostgreSql;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Entities;

/// <summary>УБР.</summary>
/// <remarks>Db: kern_catalog.ubr.</remarks>
[EntityWithAudit]
internal partial class UbrDb : Entity<Guid>
{

	/// <summary>Модель БД.</summary>
	internal static readonly ModelTable Model = 
		new(
			typeof(UbrDb),
			"kern_catalog",
			"ubr",
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
	/// <remarks>Db: ubrnaim character varying(2048).</remarks>
	[AllowNull]
	public string Ubrnaim { get; set; } = default!;

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: ubrcomment character varying(2048).</remarks>
	[AllowNull]
	public string Ubrcomment { get; set; } = default!;

	/// <summary>Актуальность.</summary>
	/// <remarks>Db: act boolean.</remarks>
	public bool Act { get; set; }
}
