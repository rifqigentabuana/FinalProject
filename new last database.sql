CREATE DATABASE FINAL_PROJECT_APP_WIFI

USE FINAL_PROJECT_APP_WIFI

CREATE TABLE Pengguna(
id char(10) PRIMARY KEY NOT NULL,
nama varchar(25) not null,
gender char(1) CHECK(gender IN('L','P')),
tgl_Lahir DATE,
alamat VARCHAR(50),
no_telp varchar(15) not null,
email CHAR(50),
password varchar(15) not null,
)
INSERT Pengguna VALUES('G3NT4', 'RIFQI GENTA','L','2001/08/04','punung,kendal,pacitan','0812345678910','genta123@gmail.com','genta123')
select * from Pengguna
go

CREATE TABLE Jenis_Paket(
Jenis VARCHAR(9) PRIMARY KEY NOT NULL,
upload CHAR(5) NOT NULL,
download CHAR(5) NOT NULL,
pengguna CHAR(5) NOT NULL
)
INSERT INTO Jenis_Paket VALUES('20','4','20','6')
Select * from Jenis_Paket
go

CREATE TABLE Penggunaan(
ID_Pengguna CHAR(10) FOREIGN KEY REFERENCES Pengguna(id) NOT NULL,
paket_diambil VARCHAR(9) FOREIGN KEY REFERENCES Jenis_Paket(Jenis),
total_hari_ini VARCHAR(50),
hari_senin VARCHAR(50),
hari_selasa VARCHAR(50),
hari_rabu VARCHAR(50),
hari_kamis VARCHAR(50),
January VARCHAR(50),
February VARCHAR(50),
Maret VARCHAR(50),
April VARCHAR(50)
)
INSERT INTO Penggunaan VALUES('G3NT4','20','10','40','50','60','70','300','500','400','200')
Select * from Penggunaan
go

CREATE TABLE Tagihan(
ID_Pengguna CHAR(10) FOREIGN KEY REFERENCES Pengguna(id) NOT NULL,
tanggal date,
abnoment numeric not null,
lokal NUMERIC NOT NULL,
sljj NUMERIC NOT NULL,
percakapan_ponsel NUMERIC NOT NULL,
wifi NUMERIC NOT NULL,
diskon NUMERIC NOT NULL,
pajak NUMERIC NOT NULL,
Total NUMERIC NOT NULL
)
INSERT INTO Tagihan VALUES('G3NT4','2022/01/24',0,0,0,0,250000,0,38000,288000)
Select * from Tagihan
go

CREATE TABLE Pesanan(
	id CHAR(10) FOREIGN KEY REFERENCES Pengguna(id) NOT NULL,
	paket VARCHAR(50) NOT NULL,
	harga INT NOT NULL
);

Select total_hari_ini from Penggunaan where ID_Pengguna='G3NT4'
Select hari_senin from Penggunaan where ID_Pengguna='G3NT4'
Select hari_selasa from Penggunaan where ID_Pengguna='G3NT4'
Select hari_rabu from Penggunaan where ID_Pengguna='G3NT4'
Select hari_kamis from Penggunaan where ID_Pengguna='G3NT4'
Select paket_diambil from Penggunaan where ID_Pengguna='G3NT4'
Select tanggal from Tagihan where ID_Pengguna='G3NT4'

select id,nama,gender,tgl_Lahir,alamat,no_telp,email from Pengguna where id = 'G3NT4'

UPDATE Pengguna
SET nama = 'GENTA GANS', tgl_Lahir = '2002-05-03', alamat = 'Krajan Kendal', no_telp = '08566202434', email = 'gentaganteng@gmail.com'
WHERE id = 'G3NT4'