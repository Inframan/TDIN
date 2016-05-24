DROP SCHEMA if exists 'ebanking';
CREATE SCHEMA 'ebanking' DEFAULT CHARACTER SET utf8 ;

use ebanking;


drop table if exists client;
create table client(
	id int NOT NULL AUTO_INCREMENT,
	name varchar(255),
	email varchar(255) not null unique,
	primary key(id)
);


drop table if exists company;
create table company(
	id int NOT NULL AUTO_INCREMENT,
	name varchar(255) not null unique,
	quanitity int NOT NULL,
	value real NOT NULL,
	primary key(id)
);

drop table if exists orders;
create table orders(
	id int NOT NULL AUTO_INCREMENT,
	quantity int not null,
	request_date datetime,
	execution_value float,
	execution_date datetime,
	company_id int not null,
    execution_status varchar(255),
    order_type varchar(255) not null,
    client_id int not null,
	primary key(id),
	foreign key(execution_status_id) references execution_status(id),
	foreign key(client_id) references client(id),
	foreign key(company_id) references company(id)
);

#companies
insert into company(name) values('Apple Inc.');
insert into company(name) values('Foxconn');
insert into company(name) values('Sony');
insert into company(name) values('IBM');
insert into company(name) values('Intel Corporation');
insert into company(name) values('Dell');
insert into company(name) values('SAP SE');
insert into company(name) values('QUALCOMM Incorporated');
insert into company(name) values('Alphabet Inc.');
insert into company(name) values('Microsoft Corporation');

#clients
insert into client(name, email, password) values('Mário Macedo', 'andr.macedo1@gmail.com');
insert into client(name, email, password) values('Gabriel Souto', 'gabrielsouto100d@gmail.com');

#execution_status
insert into execution_status(description) values('Executed');
insert into execution_status(description) values('Not Executed');

