-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 22, 2020 at 04:54 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.4.0

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
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`id`, `name`, `staffamount`, `managerid`, `date`) VALUES
(35, 'Cleaning', 30, 29, '2020-05-07 11:03:34'),
(41, 'Investments', 15, 12, '2020-05-07 12:54:26'),
(42, 'Purchasing', 30, 40, '2020-05-13 11:46:59'),
(43, 'Human Resources', 10, 40, '2020-05-13 11:47:24');

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
  `hiredate` text DEFAULT NULL,
  `firedate` text DEFAULT NULL,
  `hourlywage` decimal(10,2) NOT NULL,
  `password` text NOT NULL,
  `token` varchar(255) DEFAULT NULL,
  `tokenexpires` datetime DEFAULT NULL,
  `city` text NOT NULL,
  `gender` text NOT NULL,
  `zipcode` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `firstname`, `lastname`, `email`, `address`, `department`, `position`, `hiredate`, `firedate`, `hourlywage`, `password`, `token`, `tokenexpires`, `city`, `gender`, `zipcode`) VALUES
(36, 'Kristian', 'Lachev', 'kristian_robert@gmail.com', 'Gravesanderstaraat 8', 35, 'EMPLOYEE', '2020-05-14', NULL, '20.00', '28TYS/z+IoS6Eb7/uFOoxA==', '7jtsx3qm9v', '2020-06-14 13:21:08', 'Eindhoven', 'M', '2312'),
(37, 'Radoslav', 'Karaganchev', 'rado23@gmail.com', 'Sunderstraat 123A', 41, 'EMPLOYEE', '2020-05-21', '1993', '20.00', 'YHTGqjSI88Ld3/KnyoIaqw==', NULL, NULL, 'Eindhoven', 'M', '2312'),
(38, 'Lukas', 'Rimavicius', 'luksys@gmail.com', 'Orendstraat 20', 35, 'EMPLOYEE', '2020-05-24', NULL, '20.00', 'tZxnvxlqR1gZHkL3ZnDOug==', NULL, NULL, 'Eindhoven', 'M', '1232'),
(39, 'Ivan', 'Marinchev', 'ivan@gmail.com', 'Gravesanderstraat 1', -1, 'EMPLOYEE', '2020-05-14', '2020-06-21', '15.00', '6VEAgaww/6g/ELaM3hysBw==', NULL, NULL, 'Eindhoven', 'M', '1232'),
(40, 'Kraso', 'Krasov', 'krasovish@gmail.com', 'Fungefaht 123', 0, 'MANAGER', '2020-05-16', NULL, '30.00', 'Cs8D9Aj5DqDcunhtMAYg2w==', NULL, NULL, 'Amsterdam', 'M', '1123AV'),
(41, 'Stephan', 'Kudo', 'yest@gmail.com', 'Testing', 41, 'EMPLOYEE', '2020-06-12', NULL, '15.00', '28TYS/z+IoS6Eb7/uFOoxA==', NULL, NULL, 'Eindhoven', 'M', '5418'),
(42, 'Toni', 'Storaro', 'tonkata@gmail.com', 'Sofeto', 43, 'EMPLOYEE', '2020-06-21', NULL, '12.00', '28TYS/z+IoS6Eb7/uFOoxA==', NULL, NULL, 'Sofia', 'M', '1231');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `id` int(11) NOT NULL,
  `ordered_on` varchar(255) NOT NULL,
  `made_by` varchar(100) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `items_quantity` int(255) NOT NULL,
  `is_aborted` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10005 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `ordered_on`, `made_by`, `total`, `items_quantity`, `is_aborted`) VALUES
(10001, '22/06/2020 19:01:17', 'admin', '8.44', 4, 0),
(10000, '22/06/2020 17:20:43', 'admin', '8.24', 3, 0),
(10002, '22/06/2020 19:42:24', 'admin', '20.92', 8, 0),
(10003, '22/06/2020 19:42:57', 'admin', '13.44', 6, 1),
(10004, '22/06/2020 19:47:02', 'admin', '10.20', 0, 0);

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
  `datecreated` date DEFAULT NULL,
  `dateupdated` datetime DEFAULT NULL,
  `updatedby` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`productid`)
) ENGINE=InnoDB AUTO_INCREMENT=183 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productid`, `productname`, `quantity`, `sellingprice`, `buyingprice`, `stockactivity`, `minquantity`, `datecreated`, `dateupdated`, `updatedby`) VALUES
(166, 'Date', 22, '3.00', '3.00', 1, 12, '2020-04-22', '2020-06-22 07:47:03', ''),
(167, 'Jorje', -13, '2.00', '2.00', 1, 31, '2020-04-22', '2020-06-22 07:47:04', 'admin'),
(168, 'Cola', 406, '2.00', '1.00', 1, 32, '2020-04-24', '2020-06-22 07:47:03', ''),
(169, 'Pepsi', 63, '3.24', '1.22', 1, 10, '2020-04-24', '2020-06-22 07:42:58', ''),
(170, 'Ruffles', 93, '1.20', '1.00', 1, 10, '2020-04-24', '2020-06-22 07:47:03', ''),
(171, 'Oreo', 54, '1.40', '1.00', 1, 10, '2020-04-24', '2020-06-21 12:30:07', ''),
(172, 'Crunch', 40, '1.11', '0.32', 1, 10, '2020-04-24', '2020-06-21 12:30:07', ''),
(173, 'Furion', 189, '12.03', '9.55', 1, 10, '2020-04-24', '2020-06-21 12:30:06', ''),
(174, 'Kalati', 30, '42.24', '4.52', 1, 10, '2020-04-24', '2020-05-30 05:19:52', NULL),
(175, 'Tacos', 400, '2.00', '2.00', 1, 4, '2020-05-07', '2020-06-07 09:27:00', 'admin'),
(176, 'Chips', 50, '2.00', '1.00', 1, 10, '2020-05-07', '2020-05-30 05:19:52', NULL),
(177, 'Pasta', 0, '5.00', '5.00', 1, 21, '2020-05-30', '2020-06-21 12:18:29', 'admin'),
(178, 'Chocolate', 31, '2.12', '12.00', 1, 12, '2020-05-30', '2020-06-07 08:54:20', 'admin'),
(179, 'Pizzas', 29, '3.12', '4.21', 1, 30, '2020-06-07', '2020-06-07 10:34:07', 'admin'),
(180, 'Salami', 60, '3.23', '4.23', 0, 10, '2020-06-07', '2020-06-07 10:32:58', 'admin'),
(181, 'Lukanka', 32, '12.00', '12.00', 1, 1, '2020-06-07', NULL, NULL),
(182, 'Cheese', 32, '1.00', '2.00', 1, 32, '2020-06-07', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

DROP TABLE IF EXISTS `transactions`;
CREATE TABLE IF NOT EXISTS `transactions` (
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `product_price` decimal(10,2) NOT NULL,
  `product_buyingprice` decimal(10,0) NOT NULL,
  `completed_on` varchar(255) DEFAULT NULL,
  `added_on` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`order_id`, `product_id`, `product_price`, `product_buyingprice`, `completed_on`, `added_on`) VALUES
(10000, 169, '3.24', '1', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 169, '3.24', '1', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 166, '3.00', '3', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 169, '3.24', '1', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 170, '1.20', '1', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10000, 168, '2.00', '1', '22/06/2020 14:47:58', '2020-06-22 16:43:50'),
(10001, 168, '2.00', '1', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10001, 166, '3.00', '3', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10001, 168, '2.00', '1', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10001, 169, '3.24', '1', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10001, 167, '2.00', '2', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10001, 167, '2.00', '2', '22/06/2020 14:48:30', '2020-06-22 16:43:50'),
(10002, 170, '1.20', '1', '22/06/2020 14:48:36', '2020-06-22 16:43:50'),
(10002, 169, '3.24', '1', '22/06/2020 14:48:36', '2020-06-22 16:43:50'),
(10002, 167, '2.00', '2', '22/06/2020 14:48:36', '2020-06-22 16:43:50'),
(10002, 168, '2.00', '1', '22/06/2020 14:48:36', '2020-06-22 16:43:50'),
(10002, 167, '2.00', '2', '22/06/2020 14:48:36', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 16:38:25', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 16:38:25', '2020-06-22 16:43:50'),
(10000, 169, '3.24', '1', '22/06/2020 16:38:25', '2020-06-22 16:43:50'),
(10000, 168, '2.00', '1', '22/06/2020 16:38:25', '2020-06-22 16:43:50'),
(10000, 168, '2.00', '1', '22/06/2020 16:40:03', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 16:40:03', '2020-06-22 16:43:50'),
(10000, 169, '3.24', '1', '22/06/2020 16:40:03', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 16:40:03', '2020-06-22 16:43:50'),
(10000, 169, '3.24', '1', '22/06/2020 16:41:26', '2020-06-22 16:43:50'),
(10000, 166, '3.00', '3', '22/06/2020 16:41:26', '2020-06-22 16:43:50'),
(10000, 170, '1.20', '1', '22/06/2020 16:41:26', '2020-06-22 16:43:50'),
(10000, 167, '2.00', '2', '22/06/2020 16:41:26', '2020-06-22 16:43:50'),
(2, 169, '3.24', '1', '22/06/2020 16:44:55', '2020-06-22 16:44:56'),
(2, 167, '2.00', '2', '22/06/2020 16:44:55', '2020-06-22 16:44:56'),
(2, 168, '2.00', '1', '22/06/2020 16:44:55', '2020-06-22 16:44:56'),
(2, 167, '2.00', '2', '22/06/2020 16:44:55', '2020-06-22 16:44:56'),
(10000, 169, '3.24', '1', '22/06/2020 17:17:56', '2020-06-22 17:17:58'),
(10000, 168, '2.00', '1', '22/06/2020 17:17:56', '2020-06-22 17:17:58'),
(10000, 167, '2.00', '2', '22/06/2020 17:17:56', '2020-06-22 17:17:58'),
(10000, 167, '2.00', '2', '22/06/2020 17:17:56', '2020-06-22 17:17:58'),
(10000, 168, '2.00', '1', '22/06/2020 17:17:56', '2020-06-22 17:17:58'),
(10000, 168, '2.00', '1', '22/06/2020 17:20:43', '2020-06-22 17:20:47'),
(10000, 166, '3.00', '3', '22/06/2020 17:20:43', '2020-06-22 17:20:47'),
(10000, 169, '3.24', '1', '22/06/2020 17:20:43', '2020-06-22 17:20:47'),
(10001, 168, '2.00', '1', '22/06/2020 19:01:17', '2020-06-22 19:01:19'),
(10001, 167, '2.00', '2', '22/06/2020 19:01:17', '2020-06-22 19:01:19'),
(10001, 169, '3.24', '1', '22/06/2020 19:01:17', '2020-06-22 19:01:19'),
(10001, 170, '1.20', '1', '22/06/2020 19:01:17', '2020-06-22 19:01:19'),
(10002, 170, '1.20', '1', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 167, '2.00', '2', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 166, '3.00', '3', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 169, '3.24', '1', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 169, '3.24', '1', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 169, '3.24', '1', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 168, '2.00', '1', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10002, 166, '3.00', '3', '22/06/2020 19:42:24', '2020-06-22 19:42:27'),
(10004, 167, '2.00', '2', '22/06/2020 19:47:02', '2020-06-22 19:47:04'),
(10004, 170, '1.20', '1', '22/06/2020 19:47:02', '2020-06-22 19:47:04'),
(10004, 168, '2.00', '1', '22/06/2020 19:47:02', '2020-06-22 19:47:04'),
(10004, 166, '3.00', '3', '22/06/2020 19:47:02', '2020-06-22 19:47:04'),
(10004, 168, '2.00', '1', '22/06/2020 19:47:02', '2020-06-22 19:47:04');

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

-- --------------------------------------------------------

--
-- Table structure for table `workshift`
--

DROP TABLE IF EXISTS `workshift`;
CREATE TABLE IF NOT EXISTS `workshift` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `shift` text NOT NULL,
  `date` text NOT NULL,
  `empId` int(11) NOT NULL,
  `pending` tinyint(4) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1324 DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
