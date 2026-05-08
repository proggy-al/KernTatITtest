// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk.Entities;

/// <summary>Месторождение.</summary>
/// <remarks>Db: kern_catalog.oilfield.</remarks>
public partial class OilfieldEntity : Entity<Guid>
{

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
	public string Oilfieldnaim { get; set; }

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: oilfieldcomment character varying(2048).</remarks>
	[AllowNull]
	public string Oilfieldcomment { get; set; }
}
