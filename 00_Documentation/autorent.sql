-- --------------------------------------------------------
-- Hoszt:                        localhost
-- Szerver verzió:               10.4.22-MariaDB - mariadb.org binary distribution
-- Szerver OS:                   Win64
-- HeidiSQL Verzió:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Adatbázis struktúra mentése a autorent.
DROP DATABASE IF EXISTS `autorent`;
CREATE DATABASE IF NOT EXISTS `autorent` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `autorent`;

-- Struktúra mentése tábla autorent. cars
CREATE TABLE IF NOT EXISTS `cars` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_id` int(11) DEFAULT NULL,
  `brand` varchar(255) DEFAULT NULL,
  `model` varchar(255) DEFAULT NULL,
  `daily_price` int(11) DEFAULT NULL,
  `sale_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `category_id` (`category_id`),
  KEY `FK_cars_sales` (`sale_id`),
  CONSTRAINT `FK_cars_sales` FOREIGN KEY (`sale_id`) REFERENCES `sales` (`id`),
  CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése autorent.cars: ~10 rows (hozzávetőleg)
INSERT INTO `cars` (`id`, `category_id`, `brand`, `model`, `daily_price`, `sale_id`) VALUES
	(1, 3, 'Audi', 'E-Tron', 20000, NULL),
	(2, 1, 'Honda', 'CR-V', 10000, 3),
	(3, 1, 'Suzuki', 'Swift', 7000, NULL),
	(4, 1, 'Ford', 'S-Max', 14000, NULL),
	(5, 1, 'Honda', 'Civic Type-R', 22500, 2),
	(6, 2, 'Volkswagen', 'Golf 7', 12000, NULL),
	(7, 2, 'Toyota', 'Land Cruiser', 16500, 4),
	(8, 2, 'Jeep', 'Compass', 14000, 4),
	(9, 3, 'Tesla', 'Model S', 32000, NULL),
	(10, 3, 'BMW', 'i3', 500, NULL);

-- Struktúra mentése tábla autorent. category
CREATE TABLE IF NOT EXISTS `category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése autorent.category: ~3 rows (hozzávetőleg)
INSERT INTO `category` (`id`, `name`) VALUES
	(1, 'Petrol'),
	(2, 'Diesel'),
	(3, 'Electric');

-- Struktúra mentése tábla autorent. rentals
CREATE TABLE IF NOT EXISTS `rentals` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `car_id` int(11) DEFAULT NULL,
  `from_date` date DEFAULT NULL,
  `to_date` date DEFAULT NULL,
  `created` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `car_id` (`car_id`),
  CONSTRAINT `rentals_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  CONSTRAINT `rentals_ibfk_2` FOREIGN KEY (`car_id`) REFERENCES `cars` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése autorent.rentals: ~4 rows (hozzávetőleg)
INSERT INTO `rentals` (`id`, `user_id`, `car_id`, `from_date`, `to_date`, `created`) VALUES
	(1, 2, 1, '2024-03-30', '2024-04-02', '2024-03-30 16:58:36'),
	(2, 2, 5, '2024-04-03', '2024-04-04', '2024-03-30 17:01:35'),
	(3, 1, 5, '2024-04-07', '2024-04-07', '2024-03-30 17:02:15'),
	(4, 2, 1, '2024-03-27', '2024-03-29', '2024-03-30 17:14:33');

-- Struktúra mentése tábla autorent. sales
CREATE TABLE IF NOT EXISTS `sales` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(255) DEFAULT NULL,
  `percent` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése autorent.sales: ~4 rows (hozzávetőleg)
INSERT INTO `sales` (`id`, `description`, `percent`) VALUES
	(1, '5% off', 5),
	(2, '10% off', 10),
	(3, '15% off', 15),
	(4, '20% off', 20),
	(5, '25% off', 25);

-- Struktúra mentése tábla autorent. users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Tábla adatainak mentése autorent.users: ~1 rows (hozzávetőleg)
INSERT INTO `users` (`id`, `username`, `name`, `password`) VALUES
	(1, 'mark', 'Márk', '12345'),
	(2, 'peter', 'Péter', '12345')
	(3, 'milan', 'Milán', '12345');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
