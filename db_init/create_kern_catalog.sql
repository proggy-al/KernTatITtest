-- ============================================================================
-- Скрипт создания схемы kern_catalog и таблиц
-- Запускается как одна атомарная операция
-- ============================================================================

-- ============================================================================
-- Схема kern_catalog
-- ============================================================================

CREATE SCHEMA if not exists kern_catalog AUTHORIZATION postgres;
GRANT ALL ON SCHEMA kern_catalog TO postgres;

-- Таблица: ngdu
CREATE TABLE if not exists kern_catalog.ngdu (
	uid uuid DEFAULT gen_random_uuid() NOT NULL,
	ngdunaim varchar(2048) NOT NULL,
	ngducomment varchar(2048) NOT NULL,
	act bool NOT NULL DEFAULT true,
	row_created_date timestamp without time zone DEFAULT now() NOT NULL,    
    row_created_by character varying(255) NOT NULL,
    row_modified_date timestamp without time zone,
    row_modified_by character varying(255),
    row_deleted_date timestamp without time zone,
    row_deleted_by character varying(255),
    row_source character(1) DEFAULT 'D'::bpchar NOT NULL,
	CONSTRAINT ngdu_pk PRIMARY KEY (uid)
);
CREATE INDEX ngdu_naim_idx1 ON kern_catalog.ngdu USING btree (lower((ngdunaim)::text));
COMMENT ON TABLE kern_catalog.ngdu IS 'НГДУ.';
COMMENT ON COLUMN kern_catalog.ngdu.uid IS 'Уникальный идентификатор.';
COMMENT ON COLUMN kern_catalog.ngdu.ngdunaim IS 'Наименование.';
COMMENT ON COLUMN kern_catalog.ngdu.ngducomment IS 'Комментарий.';
COMMENT ON COLUMN kern_catalog.ngdu.act IS 'Актуальность.';
COMMENT ON COLUMN kern_catalog.ngdu.row_created_date IS 'Дата и время создания записи.';
COMMENT ON COLUMN kern_catalog.ngdu.row_created_by IS 'Учетная запись пользователя, создавшего запись.';
COMMENT ON COLUMN kern_catalog.ngdu.row_modified_date IS 'Дата и время последнего изменения записи.';
COMMENT ON COLUMN kern_catalog.ngdu.row_modified_by IS 'Учетная запись пользователя, изменившего запись.';
COMMENT ON COLUMN kern_catalog.ngdu.row_deleted_date IS 'Дата и время логического удаления записи.';
COMMENT ON COLUMN kern_catalog.ngdu.row_deleted_by IS 'Учетная запись пользователя, удалившего записью.';
COMMENT ON COLUMN kern_catalog.ngdu.row_source IS 'Источник записи выраженный символом (A,C,D,F,I,M,P).';
ALTER TABLE kern_catalog.ngdu OWNER TO postgres;
GRANT ALL ON TABLE kern_catalog.ngdu TO postgres;

-- Таблица: ubr
CREATE TABLE if not exists kern_catalog.ubr (
	uid uuid DEFAULT gen_random_uuid() NOT NULL,
	ubrnaim varchar(2048) NOT NULL,
	ubrcomment varchar(2048) NOT NULL,
	act bool NOT NULL DEFAULT true,
	row_created_date timestamp without time zone DEFAULT now() NOT NULL,
    row_created_by character varying(255) NOT NULL,
    row_modified_date timestamp without time zone,
    row_modified_by character varying(255),
    row_deleted_date timestamp without time zone,
    row_deleted_by character varying(255),
    row_source character(1) DEFAULT 'D'::bpchar NOT NULL,
	CONSTRAINT ubr_pk PRIMARY KEY (uid)
);
CREATE INDEX ubr_naim_idx1 ON kern_catalog.ubr USING btree (lower((ubrnaim)::text));
COMMENT ON TABLE kern_catalog.ubr IS 'УБР.';
COMMENT ON COLUMN kern_catalog.ubr.uid IS 'Уникальный идентификатор.';
COMMENT ON COLUMN kern_catalog.ubr.ubrnaim IS 'Наименование.';
COMMENT ON COLUMN kern_catalog.ubr.ubrcomment IS 'Комментарий.';
COMMENT ON COLUMN kern_catalog.ubr.act IS 'Актуальность.';
COMMENT ON COLUMN kern_catalog.ubr.row_created_date IS 'Дата и время создания записи.';
COMMENT ON COLUMN kern_catalog.ubr.row_created_by IS 'Учетная запись пользователя, создавшего запись.';
COMMENT ON COLUMN kern_catalog.ubr.row_modified_date IS 'Дата и время последнего изменения записи.';
COMMENT ON COLUMN kern_catalog.ubr.row_modified_by IS 'Учетная запись пользователя, изменившего запись.';
COMMENT ON COLUMN kern_catalog.ubr.row_deleted_date IS 'Дата и время логического удаления записи.';
COMMENT ON COLUMN kern_catalog.ubr.row_deleted_by IS 'Учетная запись пользователя, удалившего записью.';
COMMENT ON COLUMN kern_catalog.ubr.row_source IS 'Источник записи выраженный символом (A,C,D,F,I,M,P).';
ALTER TABLE kern_catalog.ubr OWNER TO postgres;
GRANT ALL ON TABLE kern_catalog.ubr TO postgres;

-- Таблица: oilfield
CREATE TABLE if not exists kern_catalog.oilfield (
	uid uuid DEFAULT gen_random_uuid() NOT NULL,
	oilfieldnaim varchar(2048) NOT NULL,
	oilfieldcomment varchar(2048) NOT NULL,	
	row_created_date timestamp without time zone DEFAULT now() NOT NULL,
    row_created_by character varying(255) NOT NULL,
    row_modified_date timestamp without time zone,
    row_modified_by character varying(255),
    row_deleted_date timestamp without time zone,
    row_deleted_by character varying(255),
    row_source character(1) DEFAULT 'D'::bpchar NOT NULL,
	CONSTRAINT oilfield_pk PRIMARY KEY (uid)
);
CREATE INDEX oilfield_naim_idx1 ON kern_catalog.oilfield USING btree (lower((oilfieldnaim)::text));
COMMENT ON TABLE kern_catalog.oilfield IS 'Месторождение.';
COMMENT ON COLUMN kern_catalog.oilfield.uid IS 'Уникальный идентификатор.';
COMMENT ON COLUMN kern_catalog.oilfield.oilfieldnaim IS 'Наименование.';
COMMENT ON COLUMN kern_catalog.oilfield.oilfieldcomment IS 'Комментарий.';
COMMENT ON COLUMN kern_catalog.oilfield.row_created_date IS 'Дата и время создания записи.';
COMMENT ON COLUMN kern_catalog.oilfield.row_created_by IS 'Учетная запись пользователя, создавшего запись.';
COMMENT ON COLUMN kern_catalog.oilfield.row_modified_date IS 'Дата и время последнего изменения записи.';
COMMENT ON COLUMN kern_catalog.oilfield.row_modified_by IS 'Учетная запись пользователя, изменившего запись.';
COMMENT ON COLUMN kern_catalog.oilfield.row_deleted_date IS 'Дата и время логического удаления записи.';
COMMENT ON COLUMN kern_catalog.oilfield.row_deleted_by IS 'Учетная запись пользователя, удалившего записью.';
COMMENT ON COLUMN kern_catalog.oilfield.row_source IS 'Источник записи выраженный символом (A,C,D,F,I,M,P).';
ALTER TABLE kern_catalog.oilfield OWNER TO postgres;
GRANT ALL ON TABLE kern_catalog.oilfield TO postgres;

-- Таблица: oilsquare
CREATE TABLE if not exists kern_catalog.oilsquare (
	uid uuid DEFAULT gen_random_uuid() NOT NULL,
	oilsquarenaim varchar(2048) NOT NULL,
	oilsquarecomment varchar(2048) NOT NULL,
	oilfield_uid uuid NOT NULL,	
	row_created_date timestamp without time zone DEFAULT now() NOT NULL,
    row_created_by character varying(255) NOT NULL,
    row_modified_date timestamp without time zone,
    row_modified_by character varying(255),
    row_deleted_date timestamp without time zone,
    row_deleted_by character varying(255),
    row_source character(1) DEFAULT 'D'::bpchar NOT NULL,
	CONSTRAINT oilsquare_pk PRIMARY KEY (uid),
	CONSTRAINT oilsquare_oilfield_fk FOREIGN KEY (oilfield_uid) REFERENCES kern_catalog.oilfield(uid) ON DELETE RESTRICT
);
CREATE INDEX oilsquare_naim_idx1 ON kern_catalog.oilsquare USING btree (lower((oilsquarenaim)::text));
COMMENT ON TABLE kern_catalog.oilsquare IS 'Площадь.';
COMMENT ON COLUMN kern_catalog.oilsquare.uid IS 'Уникальный идентификатор.';
COMMENT ON COLUMN kern_catalog.oilsquare.oilsquarenaim IS 'Наименование.';
COMMENT ON COLUMN kern_catalog.oilsquare.oilsquarecomment IS 'Комментарий.';
COMMENT ON COLUMN kern_catalog.oilsquare.oilfield_uid IS 'Месторождение.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_created_date IS 'Дата и время создания записи.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_created_by IS 'Учетная запись пользователя, создавшего запись.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_modified_date IS 'Дата и время последнего изменения записи.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_modified_by IS 'Учетная запись пользователя, изменившего запись.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_deleted_date IS 'Дата и время логического удаления записи.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_deleted_by IS 'Учетная запись пользователя, удалившего записью.';
COMMENT ON COLUMN kern_catalog.oilsquare.row_source IS 'Источник записи выраженный символом (A,C,D,F,I,M,P).';
ALTER TABLE kern_catalog.oilsquare OWNER TO postgres;
GRANT ALL ON TABLE kern_catalog.oilsquare TO postgres;

-- Таблица: welldata
CREATE TABLE if not exists kern_catalog.welldata (
	uid uuid DEFAULT gen_random_uuid() NOT NULL,
	wellnum varchar(100) NOT NULL,
	wellcategory varchar(100) NOT NULL CHECK (wellcategory IN ('добывающая', 'оценочная', 'поисковая', 'разведочная', 'эксплуатационная')),
	svn bool NOT NULL DEFAULT true,
	wellx numeric(10,2) NOT NULL DEFAULT 0,
	welly numeric(10,2) NOT NULL DEFAULT 0,
	wella numeric(10,2) NOT NULL DEFAULT 0,	
	oilsquare_uid uuid NOT NULL,	
	ngdu_uid uuid NOT NULL,	
	ubr_uid uuid NOT NULL,	
	row_created_date timestamp without time zone DEFAULT now() NOT NULL,
    row_created_by character varying(255) NOT NULL,
    row_modified_date timestamp without time zone,
    row_modified_by character varying(255),
    row_deleted_date timestamp without time zone,
    row_deleted_by character varying(255),
    row_source character(1) DEFAULT 'D'::bpchar NOT NULL,
	CONSTRAINT welldata_pk PRIMARY KEY (uid),
	CONSTRAINT welldata_oilsquare_fk FOREIGN KEY (oilsquare_uid) REFERENCES kern_catalog.oilsquare(uid) ON DELETE RESTRICT,
	CONSTRAINT welldata_ngdu_fk FOREIGN KEY (ngdu_uid) REFERENCES kern_catalog.ngdu(uid) ON DELETE RESTRICT,
	CONSTRAINT welldata_ubr_fk FOREIGN KEY (ubr_uid) REFERENCES kern_catalog.ubr(uid) ON DELETE RESTRICT
);
CREATE INDEX welldata_num_idx1 ON kern_catalog.welldata USING btree (lower(wellnum));
CREATE INDEX welldata_ngdu_idx2 ON kern_catalog.welldata USING btree (ngdu_uid);
CREATE INDEX welldata_ubr_idx3 ON kern_catalog.welldata USING btree (ubr_uid);
CREATE INDEX welldata_oilsquare_idx3 ON kern_catalog.welldata USING btree (oilsquare_uid);
COMMENT ON TABLE kern_catalog.welldata IS 'Скважина.';
COMMENT ON COLUMN kern_catalog.welldata.uid IS 'Уникальный идентификатор.';
COMMENT ON COLUMN kern_catalog.welldata.wellnum IS 'Номер.';
COMMENT ON COLUMN kern_catalog.welldata.wellcategory IS 'Категория.';
COMMENT ON COLUMN kern_catalog.welldata.svn IS 'Относится к СВН.';
COMMENT ON COLUMN kern_catalog.welldata.wellx IS 'Широта.';
COMMENT ON COLUMN kern_catalog.welldata.welly IS 'Долгота.';
COMMENT ON COLUMN kern_catalog.welldata.wella IS 'Альтитуда.';
COMMENT ON COLUMN kern_catalog.welldata.oilsquare_uid IS 'Площадь.';
COMMENT ON COLUMN kern_catalog.welldata.ngdu_uid IS 'НГДУ.';
COMMENT ON COLUMN kern_catalog.welldata.ubr_uid IS 'УБР.';
COMMENT ON COLUMN kern_catalog.welldata.row_created_date IS 'Дата и время создания записи.';
COMMENT ON COLUMN kern_catalog.welldata.row_created_by IS 'Учетная запись пользователя, создавшего запись.';
COMMENT ON COLUMN kern_catalog.welldata.row_modified_date IS 'Дата и время последнего изменения записи.';
COMMENT ON COLUMN kern_catalog.welldata.row_modified_by IS 'Учетная запись пользователя, изменившего запись.';
COMMENT ON COLUMN kern_catalog.welldata.row_deleted_date IS 'Дата и время логического удаления записи.';
COMMENT ON COLUMN kern_catalog.welldata.row_deleted_by IS 'Учетная запись пользователя, удалившего записью.';
COMMENT ON COLUMN kern_catalog.welldata.row_source IS 'Источник записи выраженный символом (A,C,D,F,I,M,P).';

ALTER TABLE kern_catalog.welldata OWNER TO postgres;
GRANT ALL ON TABLE kern_catalog.welldata TO postgres;

-- ============================================================================
-- Схема localization
-- ============================================================================
CREATE SCHEMA if not exists localization AUTHORIZATION postgres;
GRANT ALL ON SCHEMA localization TO postgres;

CREATE TABLE if not exists localization.resource (
	id serial4 NOT NULL,
	culture varchar(8) NULL,
	"name" varchar(150) NULL,
	value varchar(500) NULL,
	"scope" varchar(500) NULL
);
ALTER TABLE localization.resource OWNER TO postgres;
GRANT ALL ON TABLE localization.resource TO postgres;