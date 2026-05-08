// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk.Entities;

/// <summary>НГДУ.</summary>
/// <remarks>Db: kern_catalog.ngdu.</remarks>
public partial class NgduEntity : Entity<Guid>
{

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
	public string Ngdunaim { get; set; }

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: ngducomment character varying(2048).</remarks>
	[AllowNull]
	public string Ngducomment { get; set; }

	/// <summary>Актуальность.</summary>
	/// <remarks>Db: act boolean.</remarks>
	public bool Act { get; set; }
}
