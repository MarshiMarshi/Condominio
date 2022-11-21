create database projeto_ds_condominio;
use projeto_ds_condominio;



create table Morador (
	id_morador Integer primary key identity not null,
	nome_morador varchar(30) not null,
	rg_morador char(9) unique,
	cpf_morador char(11) unique,
	bloco_morador char(1) not null,
	apartamento numeric(3) not null,
);

create table Autorizacao (
	id_autorizacao Integer primary key identity not null,
	nome_autorizacao varchar(30) not null,
	tipo_pessoa varchar(20) not null,
	id_morador Integer constraint auto_mora_id_fk foreign key (id_morador) references Morador (id_morador)
);


create table DescricaoAusente (
	id_descricao_ausente Integer primary key identity not null,
	motivo_descricao_ausente varchar(20),
	descricao_ausente varchar(40)
);

create table DescricaoDevolutiva (
	id_descricao_devolutiva Integer primary key identity not null,
	motivo_descricao_devolutiva varchar(20),
	dt_devolutiva date,
	descricao_devolutiva varchar(40)
);

create table Encomenda (
	id_encomenda Integer primary key identity not null,
	status_encomenda varchar(20) not null,
	local_Armazem varchar(20) not null,
	dt_entrega date,
	dt_chegada date not null,
	id_destinatario Integer constraint enco_mora_id_fk foreign key (id_destinatario) references Morador (id_morador),
	id_descricao_devolutiva Integer constraint enco_desDevo_id_fk foreign key (id_descricao_devolutiva) references DescricaoDevolutiva (id_descricao_devolutiva),
	id_descricao_ausente Integer constraint enco_mora_desAuse_fk foreign key (id_descricao_ausente) references DescricaoAusente (id_descricao_ausente)
);
