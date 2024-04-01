# A projekt elind�t�s�hoz sz�ks�ges:

## `.NET 6.0` �s `.NET Framework 4.7.2`

## `MySQL`, verzi�: `10.4.32-mariadb` (fejleszt�s sor�n XAMPP-ot haszn�ltunk) 
> [!IMPORTANT]
> A projekthez tartoz� adatb�zis import�l�sa (a f�jlok k�zt megtal�lhat� az sql dump: `autorent.sql`) �s a programban a lok�lis adatb�zis kapcsolat adatainak megad�sa

## Adatb�zis `connection string` megad�sa
Az `AutoRentServer` projekten bel�l az `autorent.database` f�jlban kell �t�rni az adatokat a lok�lis mysql adatb�zis adataira

`Default` �rt�kek:
- **server:** localhost
- **user:** root
- **database:** autorent
- **port:** 3306
- **password**: ~~Nincs jelsz�~~

<br />

# Alkalmaz�s elind�t�sa

### El�sz�r az `AutoRentServer` projektet kell el�nd�tani
### Ezut�n az `AutoRent` projekt is elind�that�, amely kapcsol�dik a szerverhez
A kapcsol�d�s legel�sz�r a `Login` gomb megnyom�sakor indul el

