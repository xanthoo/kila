-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 18, 2020 at 11:49 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kilrdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
  `productid` int(11) NOT NULL AUTO_INCREMENT,
  `productname` text NOT NULL,
  `quantity` int(11) NOT NULL,
  `sellingprice` decimal(10,2) DEFAULT NULL,
  `buyingprice` decimal(10,2) DEFAULT NULL,
  `stockactivity` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`productid`)
) ENGINE=InnoDB AUTO_INCREMENT=146 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productid`, `productname`, `quantity`, `sellingprice`, `buyingprice`, `stockactivity`) VALUES
(1, 'Coke', 22, '3.00', '4.00', 0),
(2, 'Ruffles', 112, '2.32', '1.22', 1),
(4, 'Coffee', 32, '5.52', '5.12', 1),
(31, 'God', 34, '1.00', '1.00', 1),
(137, 'LSD', 32, '42.22', '20.00', 1),
(138, 'Malka', 32, '2.00', '31.00', 1),
(139, 'Leas', 32, '2.00', '31.00', 1),
(140, 'Les', 3, '2.00', '3.00', 1),
(145, 'Webite', 3213, '3123123.00', '242424.00', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
