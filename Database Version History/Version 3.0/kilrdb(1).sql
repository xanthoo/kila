-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 21, 2020 at 07:59 PM
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
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4;

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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `firstname`, `lastname`, `email`, `address`, `department`, `position`, `shift`, `hiredate`, `firedate`, `hourlywage`) VALUES
(12, 'Kalata', 'Stoev', 'kro@abv.bg', 'nadaleche', 31, 'MANAGER', 'NIGHT', '2020-03-20', '1996', '1322.00'),
(13, 'Kristian', 'Lachev', 'kriso@gamil.com', 'Gravesanderstasdasd', 31, 'EMPLOYEE', 'DAY', '2020-03-20', '1996', '12.00'),
(14, 'Samurai', 'Jack', 'misho@gamil.com', 'Gore', 30, 'MANAGER', 'NIGHT', '2020-03-20', NULL, '2.00'),
(15, 'Johnny', 'Bravo', 'bravo@abv.bg', 'Ehoo', 30, 'MANAGER', 'NIGHT', '2020-03-20', NULL, '4.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=161 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productid`, `productname`, `quantity`, `sellingprice`, `buyingprice`, `stockactivity`) VALUES
(1, 'Coke', 22, '3.00', '4.00', 0),
(2, 'Ruffles', 112, '2.32', '1.22', 1),
(4, 'Coffee', 32, '5.52', '5.12', 1),
(31, 'God', 34, '1.53', '1.24', 1),
(137, 'LSD', 32, '42.22', '20.00', 1),
(138, 'Malka', 32, '2.00', '31.00', 1),
(139, 'Leas', 12, '2.00', '31.00', 1),
(140, 'Les', 3, '2.00', '3.00', 1),
(145, 'Webite', 3213, '3123123.00', '242424.00', 1),
(146, 'Hotdog', 3, '3.00', '2.00', 1),
(147, 'Tomatoes', 222, '70.00', '50.00', 1),
(148, 'Tomatoes', 222, '111.00', '50.00', 1),
(149, 'Flowers', 31, '114224.00', '434442.00', 1),
(150, 'Cigars', 200, '13041241.00', '8012412.00', 1),
(151, 'Juice', 76, '142422.00', '1552525.00', 1),
(152, 'Cheese', 311, '442.00', '142.00', 1),
(153, 'Apples', 31, '4121.00', '211423.00', 1),
(154, 'Oranges', 70, '41200.00', '4500.00', 1),
(155, 'Tesla', 2, '413.00', '412123.00', 1),
(156, 'Lays', 2400, '0.42', '1.44', 1),
(157, 'Russian Standard', 300, '20.56', '15.22', 1),
(158, '7UP', 2300, '0.96', '0.22', 1),
(159, 'Avocados', 4214, '3.41', '2.25', 0),
(160, 'Sponges', 341, '23.00', '231.00', 1);

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
