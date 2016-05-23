DROP SCHEMA if exists 'ebanking';
CREATE SCHEMA 'ebanking' DEFAULT CHARACTER SET utf8 ;

use ebanking;

drop table if exists client;
create table client(
	id int NOT NULL AUTO_INCREMENT,
	name varchar(255),
	email varchar(255) not null unique,
	password varchar(255) not null,
	primary key(id)
);

drop table if exists order_type;
create table order_type(
	id int NOT NULL AUTO_INCREMENT,
	description varchar(255) not null unique,
	primary key(id)
);

drop table if exists execution_status;
create table execution_status(
	id int NOT NULL AUTO_INCREMENT,
	description varchar(255) not null unique,
	primary key(id)
);

drop table if exists company;
create table company(
	id int NOT NULL AUTO_INCREMENT,
	name varchar(255) not null unique,
	value int NOT NULL,	
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
    execution_status_id int not null,
    order_type_id int not null,
    client_id int not null,
	primary key(id),
	foreign key(execution_status_id) references execution_status(id),
	foreign key(order_type_id) references order_type(id),
	foreign key(client_id) references client(id),
	foreign key(company_id) references company(id)
);


# seeds

#companies
insert into company(name) values('Apple Inc.',100);
insert into company(name) values('Foxconn',101);
insert into company(name) values('Sony',102);
insert into company(name) values('IBM',103);
insert into company(name) values('Intel Corporation',104);
insert into company(name) values('Dell',105);
insert into company(name) values('SAP SE');
insert into company(name) values('QUALCOMM Incorporated',106);
insert into company(name) values('Alphabet Inc.',107);
insert into company(name) values('Microsoft Corporation',108);

#clients
insert into client(name, email, password) values('Mário Macedo', 'andr.macedo1@gmail.com', sha1('123456'));
insert into client(name, email, password) values('Gabriel Souto', 'gabrielsouto100d@gmail.com', sha1('123456'));

#order_type
insert into order_type(description) values('Sell');
insert into order_type(description) values('Buy');

#execution_status
insert into execution_status(description) values('Executed');
insert into execution_status(description) values('Not Executed');

