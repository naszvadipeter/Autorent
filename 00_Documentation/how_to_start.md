# A projekt elindításához szükséges:

## `.NET 6.0` és `.NET Framework 4.7.2`

## `MySQL`, verzió: `10.4.32-mariadb` (fejlesztés során XAMPP-ot használtunk) 
> [!IMPORTANT]
> A projekthez tartozó adatbázis importálása (a fájlok közt megtalálható az sql dump: `autorent.sql`) és a programban a lokális adatbázis kapcsolat adatainak megadása

## Adatbázis `connection string` megadása
Az `AutoRentServer` projekten belül az `autorent.database` fájlban kell átírni az adatokat a lokális mysql adatbázis adataira

`Default` értékek:
- **server:** localhost
- **user:** root
- **database:** autorent
- **port:** 3306
- **password**: ~~Nincs jelszó~~

<br />

# Alkalmazás elindítása

### Először az `AutoRentServer` projektet kell elíndítani
### Ezután az `AutoRent` projekt is elindítható, amely kapcsolódik a szerverhez
A kapcsolódás legelőször a `Login` gomb megnyomásakor indul el

# Teszt adatok

### Teszt felhasználó
A bejelentkezéshez használható `Test` felhasználó adatai:
- **Username:** `test`
- **Password:** `12345`

