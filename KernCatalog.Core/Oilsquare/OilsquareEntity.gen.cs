// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk.Entities;

/// <summary>Площадь.</summary>
/// <remarks>Db: kern_catalog.oilsquare.</remarks>
public partial class OilsquareEntity : Entity<Guid>
{

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
	public string Oilsquarenaim { get; set; }

	/// <summary>Комментарий.</summary>
	/// <remarks>Db: oilsquarecomment character varying(2048).</remarks>
	[AllowNull]
	public string Oilsquarecomment { get; set; }

	/// <summary>Месторождение.</summary>
	/// <remarks>Db: oilfield_uid uuid.</remarks>
	public Guid OilfieldUid { get; set; }
}
