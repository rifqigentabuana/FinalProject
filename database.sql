CREATE DATABASE App_Wifi_New1

USE App_Wifi_New1

--pengguna
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
DROP TABLE Pengguna
DROP TABLE Jenis_Paket


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
hari_kamis VARCHAR(50)
)
ALTER TABLE Penggunaan ADD January VARCHAR(50)
ALTER TABLE Penggunaan ADD February VARCHAR(50)
ALTER TABLE Penggunaan ADD Maret VARCHAR(50)
ALTER TABLE Penggunaan ADD April VARCHAR(50)
INSERT INTO Penggunaan VALUES('G3NT4','20','10','40','50','60','70','300','500','400','200')
delete from Penggunaan where ID_Pengguna = 'G3NT4'
Select * from Penggunaan
go

CREATE TABLE Add_On(
id_AddOn CHAR(5) NOT NULL,
nama Varchar(30) NOT NULL,
harga NUMERIC NOT NULL
)
INSERT INTO Add_On VALUES('A001','Router Tambahan',50000)
INSERT INTO Add_On VALUES('A002','5Mbps/hari',40000)
INSERT INTO Add_On VALUES('A003','5Mbps/minggu',60000)
INSERT INTO Add_On VALUES('A004','5Mbps/bulan',80000)
INSERT INTO Add_On VALUES('A005','Netflix',30000)
INSERT INTO Add_On VALUES('A006','Cloud Storage',30000)

Select * from Add_On
go

CREATE TABLE Tagihan(
ID_Pengguna CHAR(10) FOREIGN KEY REFERENCES Pengguna(id) NOT NULL,
tanggal date,
abonement numeric not null,
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

Select total_hari_ini from Penggunaan where ID_Pengguna='G3NT4'
Select hari_senin from Penggunaan where ID_Pengguna='G3NT4'
Select hari_selasa from Penggunaan where ID_Pengguna='G3NT4'
Select hari_rabu from Penggunaan where ID_Pengguna='G3NT4'
Select hari_kamis from Penggunaan where ID_Pengguna='G3NT4'
Select paket_diambil from Penggunaan where ID_Pengguna='G3NT4'
Select tanggal from Tagihan where ID_Pengguna='G3NT4'

SELECT Jenis_Paket.download,Penggunaan.ID_Pengguna From Jenis_Paket Join Penggunaan ON Jenis_Paket.Jenis = Penggunaan.paket_diambil Where ID_Pengguna='G3NT4'

SELECT j.download FROM Jenis_Paket j JOIN Penggunaan P ON j.Jenis = p.paket_diambil WHERE p.ID_Pengguna = 'G3NT4'

SELECT p.January,p.February,p.Maret,p.April FROM Penggunaan P JOIN  Pengguna pg ON p.ID_Pengguna = pg.id  WHERE pg.id = 'G3NT4'

Select id,nama,gender,no_telp from Pengguna where id='G3NT4'

SELECT i.tgl_Lahir,i.alamat,i.email FROM Info_Pengguna i JOIN Pengguna P ON i.id_pengguna = p.id WHERE p.id = 'G3NT4'

select * from Pengguna WHERE id = 'G3NT4'

select id,nama,gender,tgl_Lahir,alamat,no_telp,email from Pengguna where id = 'G3NT4'

UPDATE Pengguna
SET nama = 'GENTA GANS', tgl_Lahir = '2002-05-03', alamat = 'Krajan Kendal', no_telp = '08566202434', email = 'gentaganteng@gmail.com'
WHERE id = 'G3NT4'

select tanggal from Tagihan where ID_Pengguna = 'G3NT4'
UPDATE Tagihan
SET tanggal = '2022/01/20'
WHERE ID_Pengguna = 'G3NT4'
SELECT * FROM Tagihan