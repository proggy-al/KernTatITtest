// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk.Entities;

/// <summary>УБР.</summary>
/// <remarks>Db: kern_catalog.ubr.</remarks>
public partial class UbrEntity : Entity<Guid>
{

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
	public string Ubrnaim { get; set; }

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: ubrcomment character varying(2048).</remarks>
	[AllowNull]
	public string Ubrcomment { get; set; }

	/// <summary>Актуальность.</summary>
	/// <remarks>Db: act boolean.</remarks>
	public bool Act { get; set; }
}
