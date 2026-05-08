// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Infra.PostgreSql;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Entities;

/// <summary>НГДУ.</summary>
/// <remarks>Db: kern_catalog.ngdu.</remarks>
[EntityWithAudit]
internal partial class NgduDb : Entity<Guid>
{

	/// <summary>Модель БД.</summary>
	internal static readonly ModelTable Model = 
		new(
			typeof(NgduDb),
			"kern_catalog",
			"ngdu",
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
	/// <remarks>Db: ngdunaim character varying(2048).</remarks>
	[AllowNull]
	public string Ngdunaim { get; set; } = default!;

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: ngducomment character varying(2048).</remarks>
	[AllowNull]
	public string Ngducomment { get; set; } = default!;

	/// <summary>Актуальность.</summary>
	/// <remarks>Db: act boolean.</remarks>
	public bool Act { get; set; }
}
