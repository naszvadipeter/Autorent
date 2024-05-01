# Authentication és Authorization dokumentáció

Az Authentication JWT token segítségével történik.

Az Authorization-hoz egy `Role` oszlop felvétele a `users` táblában. Szövegesen tárolja a felhasználó szerepkörét: `admin` vagy `user`

Server oldalon a végpontok védelme:
- `Login:` Nincs védelem
- `GetUser:` Admin szerepkör szükséges
- `GetAllUsers:` Admin szerepkör szükséges
- `GetAllCars:` Bármely szerepkör megfelelő
- `GetCarImage:` Bármely szerepkör megfelelő
- `GetAllCategories:` Bármely szerepkör megfelelő
- `AddRental:` User szerepkör szükséges
