// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Core;

using System.Diagnostics.CodeAnalysis;
using Tn.Sdk.Entities;

/// <summary>Скважина.</summary>
/// <remarks>Db: kern_catalog.welldata.</remarks>
public partial class WelldataEntity : Entity<Guid>
{

	/// <summary>Уникальный идентификатор.</summary>
	/// <remarks>Db: uid uuid.</remarks>
	public Guid? Uid
	{
		get => PkInternal;
		set => PkInternal = value;
	}

	/// <summary>Номер.</summary>
	/// <remarks>Db: wellnum character varying(100).</remarks>
	[AllowNull]
	public string Wellnum { get; set; }

	/// <summary>Категория.</summary>
	/// <remarks>Db: wellcategory character varying(100).</remarks>
	[AllowNull]
	public string Wellcategory { get; set; }

	/// <summary>Относится к СВН.</summary>
	/// <remarks>Db: svn boolean.</remarks>
	public bool Svn { get; set; }

	/// <summary>Широта.</summary>
	/// <remarks>Db: wellx numeric(10,2).</remarks>
	public decimal Wellx { get; set; }

	/// <summary>Долгота.</summary>
	/// <remarks>Db: welly numeric(10,2).</remarks>
	public decimal Welly { get; set; }

	/// <summary>Альтитуда.</summary>
	/// <remarks>Db: wella numeric(10,2).</remarks>
	public decimal Wella { get; set; }

	/// <summary>Площадь.</summary>
	/// <remarks>Db: oilsquare_uid uuid.</remarks>
	public Guid OilsquareUid { get; set; }

	/// <summary>НГДУ.</summary>
	/// <remarks>Db: ngdu_uid uuid.</remarks>
	public Guid NgduUid { get; set; }

	/// <summary>УБР.</summary>
	/// <remarks>Db: ubr_uid uuid.</remarks>
	public Guid UbrUid { get; set; }
}
