

CREATE TABLE public.cl_assettype (
	cl_assettype_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_assettype_value_shortstring varchar(50) not NULL,
	cl_assettype_value_longstring varchar(255) not NULL,
	cl_assettype_description varchar(255) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_assettype_pkey PRIMARY KEY (cl_assettype_id)
);
CREATE UNIQUE INDEX idu_cl_assettype_shortstring ON public.cl_assettype USING btree (cl_assettype_value_shortstring) WITH (fillfactor='80');


CREATE TABLE public.rt_asset (
	rt_asset_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	"name" varchar(255) NOT NULL,
	cl_assettype_id uuid NOT NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT rt_assets_pkey PRIMARY KEY (rt_asset_id)
);

ALTER TABLE public.rt_asset ADD CONSTRAINT rt_asset_cl_assettype_id_fkey FOREIGN KEY (cl_assettype_id) REFERENCES public.cl_assettype(cl_assettype_id);




CREATE TABLE public.rt_assethierarchy (
	rt_assethierarchy_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	"name" varchar(255) NOT NULL,
	parent_asset_id uuid NOT NULL,
	child_asset_id uuid NOT NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT rt_assethierarchy_pkey PRIMARY KEY (rt_assethierarchy_id)
);

ALTER TABLE public.rt_assethierarchy ADD CONSTRAINT rt_assethierarchy_parent_asset_id_fkey FOREIGN KEY (parent_asset_id) REFERENCES public.rt_asset(rt_asset_id);
ALTER TABLE public.rt_assethierarchy ADD CONSTRAINT rt_assethierarchy_child_asset_id_fkey FOREIGN KEY (child_asset_id) REFERENCES public.rt_asset(rt_asset_id);




CREATE TABLE public.cl_measurementcategory (
	cl_measurementcategory_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_measurementcategory_value_shortstring varchar(255) NULL,
	cl_measurementcategory_value_longstring varchar(500) NULL,
	cl_measurementcategory_description varchar(1000) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_measurementcategory_pkey PRIMARY KEY (cl_measurementcategory_id)
);
CREATE UNIQUE INDEX idu_cl_measurementcategory_shortstring ON public.cl_measurementcategory USING btree (cl_measurementcategory_value_shortstring) WITH (fillfactor='80');



CREATE TABLE public.cl_measurementtype (
	cl_measurementtype_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_measurementtype_value_shortstring varchar(255) NULL,
	cl_measurementtype_value_longstring varchar(500) NULL,
	cl_measurementtype_description varchar(1000) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_measurementtype_pkey PRIMARY KEY (cl_measurementtype_id)
);
CREATE UNIQUE INDEX idu_cl_measurementtype_shortstring ON public.cl_measurementtype USING btree (cl_measurementtype_value_shortstring) WITH (fillfactor='80');




CREATE TABLE public.cl_uomtype (
	cl_uomtype_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	rt_uomtype_value_shortstring varchar(50) NULL,
	rt_uomtype_value_longstring varchar(255) NULL,
	rt_uomtype_description varchar(255) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_uomtype_pkey PRIMARY KEY (cl_uomtype_id)
);
CREATE UNIQUE INDEX idu_cl_uomtype_shortstring ON public.cl_uomtype USING btree (rt_uomtype_value_shortstring) WITH (fillfactor='80');


CREATE TABLE public.cl_uomclassification (
	cl_uomclassification_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_uomclassification_shortstring varchar(50) NOT NULL,
	cl_uomclassification_longstring varchar(255) NOT NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_uomclassification_pkey PRIMARY KEY (cl_uomclassification_id)
);
CREATE UNIQUE INDEX idu_cl_uomclassification_shortstring ON public.cl_uomclassification USING btree (cl_uomclassification_shortstring) WITH (fillfactor='80');



CREATE TABLE public.cl_uom (
	cl_uom_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_uomtype_id uuid NOT NULL,
	cl_uom_value_shortstring varchar(50) NULL,
	cl_uom_value_longstring varchar(255) NULL,
	cl_uom_description varchar(255) NULL,
	cl_uomclassification_id uuid NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_uom_pkey PRIMARY KEY (cl_uom_id)
);
CREATE UNIQUE INDEX idu_cl_uom_shortstring ON public.cl_uom USING btree (cl_uom_value_shortstring) WITH (fillfactor='80');
CREATE INDEX idx_cl_uom_uomtype_1 ON public.cl_uom USING btree (cl_uomtype_id) WITH (fillfactor='80');
CREATE INDEX idx_fk_cl_uom_cl_uomclassification_id ON public.cl_uom USING btree (cl_uomclassification_id) WITH (fillfactor='80');
CREATE INDEX idx_fk_cl_uom_cl_uomtype_id ON public.cl_uom USING btree (cl_uomtype_id) WITH (fillfactor='80');


ALTER TABLE public.cl_uom ADD CONSTRAINT cl_uom_cl_uomclassification_id_fkey FOREIGN KEY (cl_uomclassification_id) REFERENCES public.cl_uomclassification(cl_uomclassification_id);
ALTER TABLE public.cl_uom ADD CONSTRAINT cl_uom_cl_uomtype_id_fkey FOREIGN KEY (cl_uomtype_id) REFERENCES public.cl_uomtype(cl_uomtype_id);


CREATE TABLE public.re_measurementcategorytotype (
	re_measurementcategorytotype_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_assettype_id uuid NOT NULL,
	cl_measurementtype_id uuid NOT NULL,
	cl_measurementcategory_id uuid NOT NULL,
	cl_uomtype_id uuid NULL,
	description varchar(255) NULL,
	required bool NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT re_measurementcategorytotype_pkey PRIMARY KEY (re_measurementcategorytotype_id)
);

ALTER TABLE public.re_measurementcategorytotype ADD CONSTRAINT re_measurementcategorytotype_cl_assettype_id_fkey FOREIGN KEY (cl_assettype_id) REFERENCES public.cl_assettype(cl_assettype_id);
ALTER TABLE public.re_measurementcategorytotype ADD CONSTRAINT re_measurementcategorytotype_cl_uomtype_id_fkey FOREIGN KEY (cl_uomtype_id) REFERENCES public.cl_uomtype(cl_uomtype_id);




CREATE TABLE public.rt_template (
	rt_template_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	rt_asset_id uuid not NULL,
	cl_assettype_id uuid NULL,
	"name" varchar(255) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT rt_template_pkey PRIMARY KEY (rt_template_id)
);


ALTER TABLE public.rt_template ADD CONSTRAINT rt_template_cl_assettype_id_fkey FOREIGN KEY (cl_assettype_id) REFERENCES public.cl_assettype(cl_assettype_id);
ALTER TABLE public.rt_template ADD CONSTRAINT rt_template_rt_asset_id_fkey FOREIGN KEY (rt_asset_id) REFERENCES public.rt_asset(rt_asset_id);




CREATE TABLE public.cl_datatype (
	cl_datatype_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	cl_datatype_value_shortstring varchar(100) NULL,
	cl_datatype_value_longstring varchar(255) NULL,
	cl_datatype_description varchar(255) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT cl_datatype_pkey PRIMARY KEY (cl_datatype_id)
);
CREATE UNIQUE INDEX idu_cl_datatype_shortstring ON public.cl_datatype USING btree (cl_datatype_value_shortstring, cl_datatype_description) WITH (fillfactor='80');



CREATE TABLE public.re_templatevariable (
	re_templatevariable_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	rt_template_id uuid NOT NULL,
	re_measurementcategorytotype_id uuid NOT NULL,
	editable bool NOT NULL,
	required bool NOT NULL,
	cl_uom_id uuid NULL,
	cl_datatype_id uuid NULL,
	dropdownsource varchar(55) NULL,
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT re_templatevariable_pkey PRIMARY KEY (re_templatevariable_id)
);
CREATE INDEX idx_fk_re_templatevariable_cl_uom_id ON public.re_templatevariable USING btree (cl_uom_id) WITH (fillfactor='80');
CREATE INDEX idx_fk_re_templatevariable_re_measurementcategorytotype_id ON public.re_templatevariable USING btree (re_measurementcategorytotype_id) WITH (fillfactor='80');
CREATE INDEX idx_fk_re_templatevariable_rt_template_id ON public.re_templatevariable USING btree (rt_template_id) WITH (fillfactor='80');


-- public.re_templatevariable foreign keys

ALTER TABLE public.re_templatevariable ADD CONSTRAINT re_templatevariable_cl_uom_id_fkey FOREIGN KEY (cl_uom_id) REFERENCES public.cl_uom(cl_uom_id);
ALTER TABLE public.re_templatevariable ADD CONSTRAINT re_templatevariable_re_measurementcategorytotype_id_fkey FOREIGN KEY (re_measurementcategorytotype_id) REFERENCES public.re_measurementcategorytotype(re_measurementcategorytotype_id) ON UPDATE CASCADE;
ALTER TABLE public.re_templatevariable ADD CONSTRAINT re_templatevariable_rt_template_id_fkey FOREIGN KEY (rt_template_id) REFERENCES public.rt_template(rt_template_id);




CREATE TABLE public.rt_assetmeasurement (
	rt_assetmeasurement_id uuid NOT NULL DEFAULT uuid_generate_v4(),
	re_measurementcategorytotype_id uuid NOT NULL,
	rt_asset_id uuid NOT NULL,
	value varchar(55) NULL,
	"timestamp" timestamp NOT NULL,
	updated_at timestamp NULL DEFAULT now(),
	deleted bool NOT NULL DEFAULT false,
	transaction_id uuid,
	CONSTRAINT rt_assetmeasurement_pkey PRIMARY KEY (rt_asset_id, re_measurementcategorytotype_id, "timestamp")
);

ALTER TABLE public.rt_assetmeasurement ADD CONSTRAINT rt_assetmeasurement_re_measurementcategorytotype_id_fkey FOREIGN KEY (re_measurementcategorytotype_id) REFERENCES public.re_measurementcategorytotype(re_measurementcategorytotype_id) ON UPDATE CASCADE;
ALTER TABLE public.rt_assetmeasurement ADD CONSTRAINT rt_assetmeasurement_rt_asset_id_fkey FOREIGN KEY (rt_asset_id) REFERENCES public.rt_asset(rt_asset_id);
