create database JogoMemoria;
use JogoMemoria;

create table jogador(
	id int not null auto_increment primary key,
    nome varchar(255) not null,
    tempo varchar(255)
);

