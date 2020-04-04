-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 04, 2020 at 02:18 PM
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
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
CREATE TABLE IF NOT EXISTS `department` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  `staffamount` int(11) DEFAULT NULL,
  `managerid` int(11) DEFAULT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`id`, `name`, `staffamount`, `managerid`, `date`) VALUES
(34, 'Sashko2', 32, 68, '2020-03-23 01:49:05');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
CREATE TABLE IF NOT EXISTS `employee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` text NOT NULL,
  `lastname` text NOT NULL,
  `email` text NOT NULL,
  `address` text NOT NULL,
  `department` int(11) NOT NULL,
  `position` text NOT NULL,
  `shift` text NOT NULL,
  `hiredate` text DEFAULT NULL,
  `firedate` text DEFAULT NULL,
  `hourlywage` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `firstname`, `lastname`, `email`, `address`, `department`, `position`, `shift`, `hiredate`, `firedate`, `hourlywage`) VALUES
(12, 'Kalata', 'Stoev', 'kro@abv.bg', 'nadaleche', 31, 'MANAGER', 'NIGHT', '2020-03-20', '1996', '1322.00'),
(13, 'Kristian', 'Lachev', 'kriso@gamil.com', 'Gravesanderstasdasd', 31, 'EMPLOYEE', 'DAY', '2020-03-20', '1996', '12.00'),
(14, 'Samurai', 'Jack', 'misho@gamil.com', 'Gore', 34, 'MANAGER', 'NIGHT', '2020-03-20', NULL, '2.00'),
(15, 'Johnny', 'Bravo', 'bravo@abv.bg', 'Ehoo', 30, 'MANAGER', 'NIGHT', '2020-03-20', NULL, '4.00'),
(16, 'Ivan', 'Dolov', 'Kurban', 'Na maika ti putkata', 34, 'MANAGER', 'NIGHT', '2020-03-23', '1994', '10.00'),
(17, 'John', 'Doe', 'Kurban', 'Na maika ti putkata', 34, 'MANAGER', 'AFTERNOON', '2020-03-23', NULL, '20.00');

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
  `minquantity` int(255) DEFAULT NULL,
  PRIMARY KEY (`productid`)
) ENGINE=InnoDB AUTO_INCREMENT=165 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productid`, `productname`, `quantity`, `sellingprice`, `buyingprice`, `stockactivity`, `minquantity`) VALUES
(162, 'Invas', 2, '11.00', '32.00', 1, 3),
(163, 'Oprah', 24, '1.00', '3.00', 1, 20),
(164, 'Ruffles', 1, '4.00', '2.00', 1, 12);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `position` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `position`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
