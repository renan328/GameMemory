create database JogoMemoria;
use JogoMemoria;

create table jogador(
	id int not null auto_increment primary key,
    nome varchar(255) not null,
    tempo int not null
);

insert into jogador values (default, "Lucas", 10);
insert into jogador values (default, "Renan", 11);
insert into jogador values (default, "Marcos", 12);
insert into jogador values (default, "Marcos 2", 13);

select * from jogador order by tempo desc;
