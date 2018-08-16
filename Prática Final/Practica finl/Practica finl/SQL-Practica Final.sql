USE registro;

create table tbladministracion
(
	
	Nombres nvarchar(50) not null,
	Apellidos nvarchar(50) not null,
	Direccion nvarchar(50) not null,
	Fecha_de_Nacimiento nvarchar(50) not null,
	Edad nvarchar(50) not null,
	Sexo nvarchar(50) not null,
	Telefono nvarchar(50) not null,
	Celular nvarchar(50) not null,
	Cedula nvarchar(50) not null,
	Año_De_Ingreso nvarchar(50)not null,
	Mes_De_Ingreso nvarchar(50) not null,
	Carrera nvarchar(50) not null,
	Matricula nvarchar(50) not null,
	Edificio nvarchar(50) not null,
	Tanda nvarchar(50) not null,
	Cuatrimestre nvarchar(50) not null,
	Seccion nvarchar(50) not null,
	Aula nvarchar(50) not null,	
)
create table tblcontabilidad
(
	
	Nombres nvarchar(50) not null,
	Apellidos nvarchar(50) not null,
	Direccion nvarchar(50) not null,
	Fecha_de_Nacimiento nvarchar(50) not null,
	Edad nvarchar(50) not null,
	Sexo nvarchar(50) not null,
	Telefono nvarchar(50) not null,
	Celular nvarchar(50) not null,
	Cedula nvarchar(50) not null,
	Año_De_Ingreso nvarchar(50)not null,
	Mes_De_Ingreso nvarchar(50) not null,
	Carrera nvarchar(50) not null,
	Matricula nvarchar(50) not null,
	Edificio nvarchar(50) not null,
	Tanda nvarchar(50) not null,
	Cuatrimestre nvarchar(50) not null,
	Seccion nvarchar(50) not null,
	Aula nvarchar(50) not null,	
)
create table tblcivil
(
	
	Nombres nvarchar(50) not null,
	Apellidos nvarchar(50) not null,
	Direccion nvarchar(50) not null,
	Fecha_de_Nacimiento nvarchar(50) not null,
	Edad nvarchar(50) not null,
	Sexo nvarchar(50) not null,
	Telefono nvarchar(50) not null,
	Celular nvarchar(50) not null,
	Cedula nvarchar(50) not null,
	Año_De_Ingreso nvarchar(50)not null,
	Mes_De_Ingreso nvarchar(50) not null,
	Carrera nvarchar(50) not null,
	Matricula nvarchar(50) not null,
	Edificio nvarchar(50) not null,
	Tanda nvarchar(50) not null,
	Cuatrimestre nvarchar(50) not null,
	Seccion nvarchar(50) not null,
	Aula nvarchar(50) not null,	
)
create table tblsistema
(
	
	Nombres nvarchar(50) not null,
	Apellidos nvarchar(50) not null,
	Direccion nvarchar(50) not null,
	Fecha_de_Nacimiento nvarchar(50) not null,
	Edad nvarchar(50) not null,
	Sexo nvarchar(50) not null,
	Telefono nvarchar(50) not null,
	Celular nvarchar(50) not null,
	Cedula nvarchar(50) not null,
	Año_De_Ingreso nvarchar(50)not null,
	Mes_De_Ingreso nvarchar(50) not null,
	Carrera nvarchar(50) not null,
	Matricula nvarchar(50) not null,
	Edificio nvarchar(50) not null,
	Tanda nvarchar(50) not null,
	Cuatrimestre nvarchar(50) not null,
	Seccion nvarchar(50) not null,
	Aula nvarchar(50) not null,	
)


INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Pedro','Fernandez','Guandolio','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Contabilidad','17-ECTN-1-001','2','Noche','Primero','402','1');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Pablo','Perez','Guandolio','04/07/1997','20','M','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria en Sistema','17-EISN-1-001','4','Noche','Primero','404','1');
INSERT INTO tblcivil  (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Estephanie','Almonte','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria Civil','17-EICN-1-001','3','Noche','Primero','403','1');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Annie','Miosotis','Villa Mella','20/10/1995','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Administracion de Empresa','17-EAEM-1-001','1','Noche','Primero','401','1');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Jonathan','Ramirez','Capotillo','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Contabilidad','17-ECTN-1-002','2','Noche','Primero','402','1');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Hele','Bautista','Herrera','04/07/1997','20','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria en Sistema','17-EISN-1-002','4','Noche','Primero','404','1');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Glennibel','Suero','Santo Domingo','15/08/1994','23','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria Civil','17-EIcN-1-002','3','Noche','Primero','403','1');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Clairet','Altagracia','Santo Domingo','01/05/1998','19','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Administracion de Empresa','17-EAEN-1-002','1','Noche','Primero','401','1');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Anthony','Peralta','Distrito Nacional','20/04/1993','24','M','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Contabilidad','17-ECTN-1-003','2','Noche','Primero','402','1');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Derlin','Rosario','Distrito Nacional','04/07/1996','21','M','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria en Sistema','17-EISN-1-003','4','Noche','Primero','404','1');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Idauris','Alcantara','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Ingenieria Civil','17-EIcN-1-003','3','Noche','Primero','403','1');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Madelin','Borbon','Villa Mella','07/04/1996','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Enero','Administracion de Empresa','17-EAEN-1-003','1','Noche','Primero','401','1');

INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Papu','Montero','Guandolio','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Contabilidad','17-MCTT-1-001','2','Tarde','Primero','412','2');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Papo','Pereira','Guandolio','04/07/1997','20','M','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria en Sistema','17-MIST-1-001','4','Tarde','Primero','414','2');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Estephie','Ramiro','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria Civil','17-MICT-1-001','3','Tarde','Primero','413','2');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Ana','Ortega','Villa Mella','20/10/1995','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Administracion de Empresa','17-MAET-1-001','1','Tarde','Primero','411','2');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Jonny','Rodriguez','Capotillo','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Contabilidad','17-MCTT-1-002','2','Tarde','Primero','412','2');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Helena','Encarnacion','Herrera','04/07/1997','20','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria en Sistema','17-MIST-1-002','4','Tarde','Primero','414','2');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Glen','Ortiz','Santo Domingo','15/08/1994','23','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria Civil','17-MIcT-1-002','3','Tarde','Primero','413','2');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Clay','Oliveira','Santo Domingo','01/05/1998','19','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Administracion de Empresa','17-MAET-1-002','1','Tarde','Primero','411','2');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Andy','Santana','Distrito Nacional','20/04/1993','24','M','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Contabilidad','17-MCTT-1-003','2','Tarde','Primero','412','2');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Darvin','Javier','Distrito Nacional','04/07/1996','21','M','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria en Sistema','17-MIST-1-003','4','Tarde','Primero','414','2');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Indra','De Los Santos','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Ingenieria Civil','17-MIcT-1-003','3','Tarde','Primero','413','2');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Madara','Ubaez','Villa Mella','07/04/1996','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Mayo','Administracion de Empresa','17-MAET-1-003','1','Tarde','Primero','411','2');


INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('john','Gonzales','Guandolio','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Contabilidad','17-ACTM-1-001','2','Mañana','Primero','422','3');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Moises','Gomez','Guandolio','04/07/1997','20','M','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria en Sistema','17-AISM-1-001','4','Mañana','Primero','424','3');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Esther','Aristis','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria Civil','17-AICM-1-001','3','Mañana','Primero','423','3');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Juana','Garcia','Villa Mella','20/10/1995','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Administracion de Empresa','17-AAEM-1-001','1','Mañana','Primero','421','3');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Jorge','Gotrox','Capotillo','04/07/1994','23','M','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Contabilidad','17-ACTM-1-002','2','Mañana','Primero','422','3');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Heleirys','Medina','Herrera','04/07/1997','20','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria en Sistema','17-AISM-1-002','4','Mañana','Primero','424','3');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Gerorima','Suero','Santo Domingo','15/08/1994','23','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria Civil','17-AIcM-1-002','3','Mañana','Primero','423','3');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Carla','Martinez','Santo Domingo','01/05/1998','19','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Administracion de Empresa','17-AAEM-1-002','1','Mañana','Primero','421','3');
INSERT INTO tblcontabilidad (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Antonio','Morales','Distrito Nacional','20/04/1993','24','M','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Contabilidad','17-ACTM-1-003','2','Mañana','Primero','422','3');
INSERT INTO tblsistema (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Dervin','Rojas','Distrito Nacional','04/07/1996','21','M','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria en Sistema','17-AISM-1-003','4','Mañana','Primero','424','3');
INSERT INTO tblcivil (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Ida','Mendez','Santo Domingo','15/04/1999','18','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Ingenieria Civil','17-AIcM-1-003','3','Mañana','Primero','423','3');
INSERT INTO tbladministracion (Nombres, Apellidos, Direccion, Fecha_de_Nacimiento, Edad, Sexo, Telefono, Celular, Cedula, Año_De_Ingreso, Mes_De_Ingreso, Carrera, Matricula, Edificio, Tanda, Cuatrimestre, Seccion, Aula)
VALUES                ('Mary','Colon','Villa Mella','07/04/1996','22','F','000-000-0000','000-000-0000','000-0000000-0','2017','Agosto','Administracion de Empresa','17-AAEM-1-003','1','Mañana','Primero','411','3');
 
 select * from tbladministracion WHERE Nombres= Nombres ORDER BY Nombres
  select * from tblcontabilidad WHERE Nombres= Nombres ORDER BY Nombres
  select * from tblcivil WHERE Nombres= Nombres ORDER BY Nombres
  select * from tblsistema WHERE Nombres= Nombres ORDER BY Nombres

   delete tbladministracion
  delete tblcontabilidad
  delete tblcivil
  delete tblsistema

 

  create table tblmaestro
  (
    Nombres nvarchar(50) not null,
	Apellidos nvarchar(50) not null,
	Direccion nvarchar(50) not null,
	Fecha_de_Nacimiento nvarchar(50) not null,
	Edad nvarchar(50) not null,
	Sexo nvarchar(50) not null,
	Telefono nvarchar(50) not null,
	Celular nvarchar(50) not null,
	Cedula nvarchar(50) not null,
	Profesion nvarchar(50) not null,
	
  )

  
  select * from tblmaestro
  delete tblmaestro

  create table AdminEmpresa 
  (
  Nombres nvarchar(50) not null,
  Apellidos nvarchar(50) not null,
  Edificio nvarchar(50) not null,
  Seccion nvarchar(50) not null,
  Cuatrimestre nvarchar(50) not null,
  Año_de_Ingreso nvarchar(50) not null,
  Aula nvarchar(50) not null,
  Dias nvarchar(50) not null,
  Asignaturas nvarchar(50) not null,
  Tanda nvarchar(50) not null,
  Hora_Extendida nvarchar(50) not null,
  )

  create table Contabilidad (
  Nombres nvarchar(50) not null,
  Apellidos nvarchar(50) not null,
  Edificio nvarchar(50) not null,
  Seccion nvarchar(50) not null,
  Cuatrimestre nvarchar(50) not null,
  Año_de_Ingreso nvarchar(50) not null,
  Aula nvarchar(50) not null,
  Dias nvarchar(50) not null,
  Asignaturas nvarchar(50) not null,
  Tanda nvarchar(50) not null,
 Hora nvarchar(50) not null,

  )
  create table IngCivil (
  Nombres nvarchar(50) not null,
  Apellidos nvarchar(50) not null,
  Edificio nvarchar(50) not null,
  Seccion nvarchar(50) not null,
  Cuatrimestre nvarchar(50) not null,
  Año_de_Ingreso nvarchar(50) not null,
  Aula nvarchar(50) not null,
  Dias nvarchar(50) not null,
  Asignaturas nvarchar(50) not null,
  Tanda nvarchar(50) not null,
  Hora nvarchar(50) not null,
 
  )
  create table IngSistema
   (
  Nombres nvarchar(50) not null,
  Apellidos nvarchar(50) not null,
  Edificio nvarchar(50) not null,
  Seccion nvarchar(50) not null,
  Cuatrimestre nvarchar(50) not null,
  Año_de_Ingreso nvarchar(50) not null,
  Aula nvarchar(50) not null,
  Dias nvarchar(50) not null,
  Asignaturas nvarchar(50) not null,
  Tanda nvarchar(50) not null,
  Hora nvarchar(50) not null,
  
  )

  create table tblregistro
  (
  Nombre nvarchar(50) not null,
  Contraseña nvarchar(50) not null,
  )
  select * from tblregistro
  delete tblregistro

  
  select * from tblmaestro WHERE Nombres= Nombres ORDER BY Nombres
  select * from tblregistro WHERE Nombre= Nombre ORDER BY Nombre
  

  select * from AdminEmpresa WHERE Nombres= Nombres ORDER BY Nombres
  select * from Contabilidad WHERE Nombres= Nombres ORDER BY Nombres
  select * from IngCivil WHERE Nombres= Nombres ORDER BY Nombres
  select * from IngSistema WHERE Nombres= Nombres ORDER BY Nombres
 

  delete AdminEmpresa
  delete Contabilidad
  delete IngCivil
  delete IngSistema









