create database db;

create table NewAdmission (
	NAID int not null IDENTITY(1,1) primary key,
	fname varchar(250) not null,
	mname varchar(250) not null,
	gender varchar(10) not null,
	dob varchar(50) not null,
	mobile bigint not null,
	email varchar(150),
	semester varchar(100) not null,
	prog varchar(150) not null,
	sname varchar(150) not null,
	duration varchar(120) not null,
	addres varchar(250) not null
)

fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres

select * from NewAdmission

create table fees (
	fid int not null IDENTITY(1,1) primary key,
	NAID int not null,
	fees int not null
)

select * from fees