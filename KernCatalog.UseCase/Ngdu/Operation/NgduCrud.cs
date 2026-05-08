// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>"Создание" <see cref="NgduEntity"/>.</summary>
public class NgduCreateOne(NgduEntity dataIn) : EntityCreateOneOper<NgduEntity, NgduEntity>(dataIn)
{
}

/// <summary>"Создание" <see cref="NgduEntity"/> по списку.</summary>
public class NgduCreateMany(NgduEntity[] dataIn) : EntityCreateManyOper<NgduEntity, NgduEntity>(dataIn)
{
}

/// <summary>"Чтение" <see cref="NgduEntity"/>.</summary>
public class NgduReadOne(Guid dataIn) : EntityReadOneOper<NgduEntity, Guid>(dataIn)
{
}

/// <summary>"Чтение" <see cref="NgduEntity"/> по списку.</summary>
public class NgduReadMany(IReadOnlyCollection<Guid> dataIn) : EntityReadManyOper<NgduEntity, Guid>(dataIn)
{
}

/// <summary>"Изменение" <see cref="NgduEntity"/>.</summary>
public class NgduUpdateOne(NgduEntity dataIn) : EntityUpdateOneOper<NgduEntity, NgduEntity>(dataIn)
{
}

/// <summary>"Изменение" <see cref="NgduEntity"/> по списку.</summary>
public class NgduUpdateMany(IReadOnlyCollection<NgduEntity> dataIn) : EntityUpdateManyOper<NgduEntity, NgduEntity>(dataIn)
{
}

/// <summary>"Удаление" <see cref="NgduEntity"/>.</summary>
public class NgduDeleteOne(Guid dataIn) : EntityDeleteOneOper<NgduEntity, Guid>(dataIn)
{
}

/// <summary>"Удаление" <see cref="NgduEntity"/> по списку.</summary>
public class NgduDeleteMany(IReadOnlyCollection<Guid> dataIn) : EntityDeleteManyOper<NgduEntity, Guid>(dataIn)
{
}
