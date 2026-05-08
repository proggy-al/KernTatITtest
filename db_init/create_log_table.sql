-- ============================================================================
-- Скрипт создания таблицы sdk_log.log
-- ============================================================================

-- Проверяем существование таблицы перед созданием
DO $$
BEGIN
  IF EXISTS (
    SELECT 1
    FROM pg_catalog.pg_tables 
    WHERE schemaname = 'sdk_log'
      AND tablename = 'log'
  ) THEN
    RAISE NOTICE 'Таблица sdk_log.log уже существует.';
  ELSE
    -- Создаём схему, если не существует
    CREATE SCHEMA IF NOT EXISTS sdk_log;

    -- Создаём таблицу
    CREATE TABLE sdk_log.log (
      uid UUID NOT NULL,
      parent_uid UUID,
      date_time TIMESTAMP(6) WITHOUT TIME ZONE NOT NULL,
      severity VARCHAR(100) NOT NULL,
      message TEXT NOT NULL,
      properties JSONB NOT NULL,
      CONSTRAINT log__pk PRIMARY KEY(uid),
      CONSTRAINT log__fk__log_parent FOREIGN KEY (parent_uid)
        REFERENCES sdk_log.log(uid)
        ON DELETE RESTRICT
        ON UPDATE NO ACTION
        NOT DEFERRABLE
    );

    -- Отключаем сбор статистики для колонок (оптимизация)
    ALTER TABLE sdk_log.log ALTER COLUMN uid SET STATISTICS 0;
    ALTER TABLE sdk_log.log ALTER COLUMN parent_uid SET STATISTICS 0;
    ALTER TABLE sdk_log.log ALTER COLUMN date_time SET STATISTICS 0;
    ALTER TABLE sdk_log.log ALTER COLUMN message SET STATISTICS 0;

    -- Комментарии к таблице и колонкам
    COMMENT ON TABLE sdk_log.log IS 'Лог.';
    COMMENT ON COLUMN sdk_log.log.uid IS 'Глобальный уникальный идентификатор.';
    COMMENT ON COLUMN sdk_log.log.parent_uid IS 'Предок.';
    COMMENT ON COLUMN sdk_log.log.date_time IS 'Дата и время возникновения.';
    COMMENT ON COLUMN sdk_log.log.severity IS 'Уровень лога.';
    COMMENT ON COLUMN sdk_log.log.message IS 'Сообщение.';
    COMMENT ON COLUMN sdk_log.log.properties IS 'Свойства.';

    -- Индекс для поиска по родительскому элементу
    CREATE INDEX log__idx__parent_uid ON sdk_log.log USING btree (parent_uid);

    -- Назначаем владельца
    ALTER TABLE sdk_log.log OWNER TO postgres;

    -- Оптимизация хранения: отключаем TOAST для TEXT/JSONB
    ALTER TABLE sdk_log.log ALTER COLUMN message SET STORAGE PLAIN;
    ALTER TABLE sdk_log.log ALTER COLUMN properties SET STORAGE PLAIN;

    RAISE NOTICE 'Таблица sdk_log.log создана.';
  END IF;
END;
$$;