
create table Admin(
adminID int  primary key,
kullaniciAdi varchar(250),
sifre varchar(250)
);
insert into Admin (adminID,kullaniciAdi,sifre) 
values ('1','admin','1234');


/********************************************/

create table Doktor(
doktorID int primary key,
doktorAdiSoyadi varchar(250),
klinikID int,
klinikAdi varchar(250),
kullanciAdi varchar(250),
sifre varchar(250),

);
ALTER TABLE Doktor
ADD CONSTRAINT fk_doktor FOREIGN KEY (klinikID) REFERENCES klinik(klinikID);

insert into Doktor(doktorID,doktorAdiSoyadi,klinikID,klinikAdi,kullanciAdi,sifre) 
values ('7','Canan Karatay','7 ','Ýç Hastalýklarý (Dahiliye)','doktor7','12345');

insert into Doktor(doktorID,doktorAdiSoyadi,klinikID,klinikAdi,kullanciAdi,sifre) 
values ('16', 'Stephen Vincent Strange', '12', 'Nöroloji', 'doktor16', '12345');

insert into Doktor(doktorID,doktorAdiSoyadi,klinikID,klinikAdi,kullanciAdi,sifre) VALUES 
('17', 'Suat Birtan', '10', 'Kardiyoloji', 'doktor17', '12345'),
('18', 'Levent Atahanlý', '12', 'Nöroloji', 'doktor18', '12345'),
('19', 'Gregory House', '2', 'Deri ve Zührevi Hastalýklar (Cildiye)', 'doktor19', '12345'),
('20', ' Ateþ Hekimoðlu', '3', 'Enfeksiyon Hastalýklarý', 'doktor20', '12345'),
('21', 'Sara Tancredi', '5', 'Genel Cerrahi', 'doktor21', '12345');



DELETE FROM Doktor
WHERE doktorID = 7;

INSERT INTO Doktor (doktorID, doktorAdiSoyadi, klinikID, klinikAdi, kullanciAdi, sifre) VALUES 
('1', 'Yasemin Özel', '1', 'Çocuk Saðlýðý ve Hastalýklarý', 'doktor1', '12345'),
('2', 'Ahmet Yýldýz', '2', 'Deri ve Zührevi Hastalýklar (Cildiye)', 'doktor2', '12345'),

('3', 'Selin Kara', '3', 'Enfeksiyon Hastalýklarý', 'doktor3', '12345'),
('4', 'Mehmet Can', '4', 'Fizik Tedavi ve Rehabilitasyon', 'doktor4', '12345'),
('5', 'Ayþe Demir', '5', 'Genel Cerrahi', 'doktor5', '12345'),
('6', 'Burak Eren', '6', 'Göðüs Cerrahisi', 'doktor6', '12345'),

('8', 'Zeynep Gül', '8', 'Kadýn Hastalýklarý ve Doðum', 'doktor8', '12345'),
('9', 'Emre Þahin', '9', 'Kalp ve Damar Cerrahisi', 'doktor9', '12345'),
('10', 'Duygu Aslan', '10', 'Kardiyoloji', 'doktor10', '12345'),

('11', 'Kerem Aksoy', '11', 'Kulak Burun Boðaz Hastalýklarý', 'doktor11', '12345'),
('12', 'Gizem Taþ', '12', 'Nöroloji', 'doktor12', '12345'),

('13', 'Mert Özkan', '13', 'Ortopedi ve Travmatoloji', 'doktor13', '12345'),
('14', 'Elif Aydýn', '14', 'Ruh Saðlýðý ve Hastalýklarý (Psikiyatri)', 'doktor14', '12345'),
('15', 'Canan Er', '15', 'Üroloji', 'doktor15', '12345');



select * from Doktor

/*************************************************/

create table klinik(
klinikID int IDENTITY(1,1) primary key,
klinikAdi varchar(250)

);

INSERT INTO klinik (klinikAdi)
VALUES 
('Çocuk Saðlýðý ve Hastalýklarý'),
('Deri ve Zührevi Hastalýklar (Cildiye)'),
('Enfeksiyon Hastalýklarý'),
('Fizik Tedavi ve Rehabilitasyon'),
('Genel Cerrahi'),
('Göðüs Cerrahisi'),
('Ýç Hastalýklarý (Dahiliye)'),
('Kadýn Hastalýklarý ve Doðum'),
('Kalp ve Damar Cerrahisi'),
('Kardiyoloji'),
('Kulak Burun Boðaz Hastalýklarý'),
('Nöroloji'),
('Ortopedi ve Travmatoloji'),
('Ruh Saðlýðý ve Hastalýklarý (Psikiyatri)'),
('Üroloji');

/****************************************************************/

create table Hasta(

TCno varchar(250) primary key,
ad varchar(250),
soyad varchar(250),
sifre varchar(250),
anneAd varchar(50),
babaAd varchar(50),
dogumTarihi varchar(250),
cinsiyet varchar(50),
telNo varchar(250),
ePosta varchar(250)

);

DELETE FROM Hasta
WHERE TCno = 965818135;

insert into Hasta (TCno,ad,soyad,sifre,anneAd,babaAd,dogumTarihi,cinsiyet,telNo,ePosta) 
values ('965818135','Yasemin','özel','1234','gülay','hüseyin','20.01.2003','kadýn','03322522525','y@outlook.com');

insert into Hasta (TCno,ad,soyad,sifre,anneAd,babaAd,dogumTarihi,cinsiyet,telNo,ePosta) 
values ('12345678901','melisa','özel','12345','gülay','hüseyin','20.01.2004','kadýn','03322522525','y@outlook.com');

insert into Hasta (TCno,ad,soyad,sifre,anneAd,babaAd,dogumTarihi,cinsiyet,telNo,ePosta) 
values ('12345678902','Zenan','Parlar','1234','Hatice','Akýn','12.05.1995','kadýn','0544444444','znn@outlook.com');

/**************************************************************/


DROP TABLE Randevu;

CREATE TABLE Randevu (
    randevuID INT IDENTITY(1,1) PRIMARY KEY,
    doktorID INT NOT NULL,
    klinikID INT NOT NULL,
    TCno VARCHAR(250),
    tarih DATE NOT NULL,
    saat varchar(250),
	tarihVeSaat varchar(250) unique,
    CONSTRAINT FK_Randevu_Doktor FOREIGN KEY (doktorID) REFERENCES Doktor(doktorID),
    CONSTRAINT FK_Randevu_Klinik FOREIGN KEY (klinikID) REFERENCES klinik(klinikID),
   CONSTRAINT FK_Randevu_Hasta FOREIGN KEY (TCno) REFERENCES Hasta(TCno)
);

/*****************************************************/

create table Yatis(
yatisID varchar(250) primary key,
hastaID varchar(250),
constraint fk_Yatis foreign key (hastaID) references hasta(TCno)

);

/************************************************************/

create table Tahlil(
tahlilID varchar(255),
hastaTC varchar(250),
tahlilAdi varchar(250),
constraint fk_Tahlil foreign key (hastaTC) references hasta(TCno)
);

