# API dokumentáció

### URL: `http://localhost:5240`
> Fejlesztés közben, lokálisan futtatva
---

## Login
### `POST` `/login`
Megkeresi a kapott felhasználónév és jelszó párost az adatbázisban tárolt felhasználók között és visszaad egy JWT tokent és a felhasználó adatait JSON formátumban (jelszót nem küldi el, csak üres stringet).

### Request
Felhasználónév és jelszó **`JSON`** formátumban
```json
{ 
    "username": "test",
    "password": "12345"
}
```
### Response
A felhasználó `ID`-je (ha a felhasználó nem létezik akkor `null`)
```json
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOiI0Iiwicm9sZSI6InVzZXIiLCJuYmYiOjE3MTQ1NjI3NzQsImV4cCI6MTcxNDY0OTE3NCwiaWF0IjoxNzE0NTYyNzc0LCJpc3MiOiJkb3RuZXQtdXNlci1qd3RzIiwiYXVkIjpbImh0dHA6Ly9sb2NhbGhvc3Q6MjU1NzIiLCJodHRwczovL2xvY2FsaG9zdDo0NDM4MCIsImh0dHBzOi8vbG9jYWxob3N0OjcyNTMiLCJodHRwOi8vbG9jYWxob3N0OjUyNDAiXX0.N2NeKGP1K6k_StahX6kg6wW2vX_tCzglGMJla_SkVDo",
    "user": {
        "id": 4,
        "username": "test",
        "name": "Test",
        "password": "",
        "role": "user",
        "rentals": []
    }
}
```
vagy
```json
"User not found!"
```
---

## GetUser
### `GET` `/getUser`
A paraméterben megadott felhasználó azonosítóhoz tartozó felhasználó adatait adja eredményül `JSON` formátumban. (Ha az ID nem létezik akkor `null`)

`Admin` szerep szükséges.

### Request
`JWT token a header-ben.`

Felhasználó ID (URL-ben paraméterként)
```json
/getUser?id=1
```
### Response
A felhasználó adatai (ha a felhasználó nem létezik akkor `null`)
```json
{
  "Id": 1,
  "Username": "example",
  "Name": "Example User",
  "Password": "12345",
  "Rentals": []
}
```
vagy
```json
null
```
---

## GetAllUsers
### `GET` `/getAllUsers`
Az adatbázisban szereplő összes felhasználót adja eredményül. Az felhasználók tartalmazzák a hozzájuk tartozó kölcsönzéseket is.

`Admin` szerep szükséges.

### Request
`JWT token a header-ben.`

```
Nincs paraméter
```
### Response
Az adatbázisban megtalálható felhasználók adatai `JSON` formátumban
```json
[
  {
    "Id": 4,
    "Username": "test",
    "Name": "Test",
    "Password": "12345",
    "Role": "user",
    "Rentals": []
  },
  {
    "Id": 5,
    "Username": "admin",
    "Name": "Admin",
    "Password": "admin",
    "Role": "admin",
    "Rentals": []
  }
]
```
vagy
```json
null
```
---

## GetAllCars
### `GET` `/getAllCars`
Az adatbázisban szereplő összes autót adja eredményül (a szerveren tárolt képekkel együtt). Az autók tartalmazzák a hozzájuk tartozó kölcsönzéseket és akciókat is.

Bármely szerepkör felhasználója elérheti.

### Request
`JWT token a header-ben.`

```
Nincs paraméter
```
### Response
Az adatbázisban megtalálható autók adatai `JSON` formátumban (a képek `byte tömb`ként, `base64string` formátumban)
```json
[
  {
    "Id": 1,
    "CategoryId": 3,
    "Brand": "Audi",
    "Model": "E-Tron",
    "DailyPrice": 20000,
    "Category": {
        "Id": 3,
        "Name": "Electric",
        "Cars": []
    },
    "Rentals": [
      {
        "Id": 4,
        "UserId": 2,
        "CarId": 1,
        "FromDate": "2024-03-27",
        "ToDate": "2024-03-29",
        "Created": "2024-03-30T18:14:33",
        "Car": null,
        "User": null
      },
      {
        "Id": 1,
        "UserId": 2,
        "CarId": 1,
        "FromDate": "2024-03-30",
        "ToDate": "2024-04-02",
        "Created": "2024-03-30T17:58:36",
        "Car": null,
        "User": null
      }
    ],
    "Sale": null,
    "ByteImage": "iVBORw0KGgo....."
    },
    {
        "Id": 2,
        "CategoryId": 1,
        "Brand": "Honda",
        "Model": "CR-V",
        "DailyPrice": 10000,
        "Category": {
            "Id": 1,
            "Name": "Petrol",
            "Cars": []
        },
        "Rentals": [],
        "Sale": {
            "Id": 3,
            "Description": "15% off",
            "Percent": 15,
            "Cars": []
        },
        "ByteImage": "iVBORw....."
    }
]
```
---

## GetCarImage
### `GET` `/getCarImage`
A paraméterben megadott autó azonosítóhoz tartozó autó képét adja eredményül `byte tömb`-ként, `base64string` formátumban. (Ha az ID nem létezik akkor `null`)

Bármely szerepkör felhasználója elérheti.

### Request
`JWT token a header-ben.`

Autó ID (URL-ben paraméterként)
```json
/getCarImage?carId=1
```
### Response
Az autóhoz tartozó kép (ha az autó nem létezik akkor `null`)
```json
"iVBORw0KGgoAAAANS......"
```
vagy
```json
null
```
---

## GetAllCategories
### `GET` `/getAllCategories`
Az adatbázisban szereplő összes kategóriát adja eredményül. A kategóriák tartalmazzák a hozzájuk tartozó autókat is.

Bármely szerepkör felhasználója elérheti.

### Request
`JWT token a header-ben.`

```
Nincs paraméter
```
### Response
Az adatbázisban megtalálható kategóriák adatai `JSON` formátumban
```json
[
    {
        "Id": 1,
        "Name": "Petrol",
        "Cars": [
            {
                "Id": 2,
                "CategoryId": 1,
                "Brand": "Honda",
                "Model": "CR-V",
                "DailyPrice": 10000,
                "SaleId": 3,
                "Rentals": [],
                "Sale": null
            },
            {
                "Id": 3,
                "CategoryId": 1,
                "Brand": "Suzuki",
                "Model": "Swift",
                "DailyPrice": 7000,
                "SaleId": null,
                "Rentals": [],
                "Sale": null
            }
        ]
    },
    {
        "Id": 2,
        "Name": "Diesel",
        "Cars": [
            {
                "Id": 8,
                "CategoryId": 2,
                "Brand": "Jeep",
                "Model": "Compass",
                "DailyPrice": 14000,
                "SaleId": 4,
                "Rentals": [],
                "Sale": null
            }
        ]
    }
]
```
---

## AddRental
### `POST` `/addRental`
Létrehoz egy új foglalást a kapott adatokkal.

`User` szerep szükséges.

### Request
`JWT token a header-ben.`

Foglalás adatai: felhasználó ID, autó ID, kezdő és befejezési dátum, **`JSON`** formátumban
```json
{
    "UserId": 1,
    "CarId": 1,
    "FromDate": "2024-04-01",
    "ToDate": "2024-04-10"
}  
```
### Response
Művelet eredménye:

`Sikeres foglalás:`
```json
"OK"
```

`Sikertelen foglalás:`
```json
"ERROR"
```
---
