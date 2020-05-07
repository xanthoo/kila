-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2020 at 08:45 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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

CREATE TABLE `department` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `staffamount` int(11) DEFAULT NULL,
  `managerid` int(11) DEFAULT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`id`, `name`, `staffamount`, `managerid`, `date`) VALUES
(34, 'Sashko2', 32, 68, '2020-03-23 01:49:05');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
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
  `zipcode` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `firstname`, `lastname`, `email`, `address`, `department`, `position`, `hiredate`, `firedate`, `hourlywage`, `password`, `token`, `tokenexpires`, `city`, `gender`, `zipcode`) VALUES
(12, 'Kalata', 'Stoev', 'kro@abv.bg', 'nadaleche', 31, 'MANAGER', '2020-03-20', '1996', '1322.00', '', NULL, NULL, '', '', ''),
(13, 'Kristian', 'Lachev', 'kristian_robert@abv.bg', 'Gravesanderstasdasd', 31, 'EMPLOYEE', '2020-03-20', '1996', '12.00', '4444', '', '2020-04-28 19:11:14', '', '', ''),
(14, 'Samurai', 'Jack', 'misho@gamil.com', 'Gore', 34, 'MANAGER', '2020-03-20', NULL, '2.00', '', NULL, NULL, '', '', ''),
(15, 'Johnny', 'Bravo', 'bravo@abv.bg', 'Ehoo', 30, 'MANAGER', '2020-03-20', NULL, '4.00', '', NULL, NULL, '', '', ''),
(16, 'Ivan', 'Dolov', 'Kurban', 'Na maika ti putkata', 34, 'MANAGER', '2020-03-23', '1994', '10.00', '', NULL, NULL, '', '', ''),
(17, 'John', 'Doe', 'Kurban', 'Na maika ti putkata', 34, 'MANAGER', '2020-03-23', NULL, '20.00', '', NULL, NULL, '', '', ''),
(18, 'Ivan', 'Marinchev', 'ivanmarinchev00@gmail.com', 'U vas', 34, 'MANAGER', '2020-04-08', NULL, '50.00', '', NULL, NULL, '', '', ''),
(19, 'Ivan', 'Marinchev', 'ivanko56@abv.bg', 'pak u vas', 34, 'ADMINISTRATOR', '2020-04-08', NULL, '20.00', '', NULL, NULL, '', '', ''),
(20, 'Ivan ', 'Marinchev', 'ivan@abv.com', 'nziaz', 34, 'MANAGER', '2020-04-08', '1986', '20.00', '', NULL, NULL, '', '', ''),
(21, 'George', 'Orwell', 'biggeorge@gmail.com', 'England', 34, 'ADMINISTRATOR', '2020-04-08', '1986', '10.00', '1234', NULL, NULL, '', '', ''),
(22, 'test', 'test', 'test_test@gmail.com', 'Test Street', 34, 'MANAGER', '2020-04-08', '1986', '80.00', 'test', 'x2p3ei8tal', '2020-04-27 18:06:10', '', '', ''),
(23, 'asdf', 'qwedsa', 'asdw@gmail.com', 'dgasda', 34, 'MANAGER', '2020-05-08', '2009', '15.00', 'AxsPtj+UIAjsKppYpq4BJw==', NULL, NULL, '', '', ''),
(24, 'Ivan', 'Marinchev', 'ivan@gmail.com', 'Johannes', 34, 'EMPLOYEE', '2020-05-14', NULL, '16.00', 'sxDQAtUTC9p8gopuEF37Zw==', NULL, NULL, '', '', ''),
(25, 'Ivan', 'Marinchev', 'sddsaads@gmail.com', 'Johannes ', 34, 'ADMINISTRATOR', '2020-05-29', NULL, '15.00', 'GlYas1ZFOIvdc9ER2f2nGA==', NULL, NULL, 'Eindhoven', 'M', '5612JC'),
(26, 'Georgi', 'Rakovski', 'grakovski@gmail.com', 'Koprivshtica', 34, 'EMPLOYEE', '2020-05-14', NULL, '50.00', 'zWt2DV6DnDiPPV7fuwinwQ==', NULL, NULL, 'Den Haag', 'M', '1234HP'),
(27, 'asd', 'sdfdg', 'sadasd@gmail.com', 'dasfdg', 34, 'ADMINISTRATOR', '2020-05-21', NULL, '14.00', 'bQU5RtuVIMxoeGkS1ZkNnQ==', NULL, NULL, 'Dasdw', 'M', 'adsf'),
(28, 'sdafg', 'sadfdgdfh', 'dfsgf@gmail.com', 'adwfsgfh', 0, 'ADMINISTRATOR', '2020-06-05', NULL, '15.00', 'hcn1A3clN0DrU0qmDnDlRg==', NULL, NULL, 'asdw', 'M', 'sdafdg'),
(29, 'sdafg', 'sadfdgdfh', 'dfsgf@gmail.com', 'adwfsgfh', 0, 'MANAGER', '2020-06-05', NULL, '15.00', 'hcn1A3clN0DrU0qmDnDlRg==', NULL, NULL, 'asdw', 'M', 'sdafdg'),
(30, 'sdafg', 'sadfdgdfh', 'dfsgf@gmail.com', 'adwfsgfh', 34, 'EMPLOYEE', '2020-06-05', NULL, '15.00', 'hcn1A3clN0DrU0qmDnDlRg==', NULL, NULL, 'asdw', 'M', 'sdafdg'),
(31, 'Henry', 'Cavil', 'superman@gmail.com', 'High Street', 0, 'MANAGER', '2020-05-21', NULL, '16.00', '54y/wEMnUyvnHlL/auxQEQ==', NULL, NULL, 'Amsterdam', 'M', '420'),
(32, 'Henry', 'Cavil', 'superman@gmail.com', 'High Street', 34, 'EMPLOYEE', '2020-05-21', NULL, '16.00', '54y/wEMnUyvnHlL/auxQEQ==', NULL, NULL, 'Amsterdam', 'M', '420'),
(33, 'Henry', 'Cavil', 'superman@gmail.com', 'High Street', 0, 'ADMINISTRATOR', '2020-05-21', NULL, '16.00', '54y/wEMnUyvnHlL/auxQEQ==', NULL, NULL, 'Amsterdam', 'M', '420');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `productid` int(11) NOT NULL,
  `productname` text NOT NULL,
  `quantity` int(11) NOT NULL,
  `sellingprice` decimal(10,2) DEFAULT NULL,
  `buyingprice` decimal(10,2) DEFAULT NULL,
  `stockactivity` tinyint(1) DEFAULT NULL,
  `minquantity` int(255) DEFAULT NULL,
  `datecreated` date DEFAULT NULL,
  `dateupdated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productid`, `productname`, `quantity`, `sellingprice`, `buyingprice`, `stockactivity`, `minquantity`, `datecreated`, `dateupdated`) VALUES
(166, 'Date', 32, '3.00', '3.00', 1, 12, '2020-04-22', '2020-04-24 00:00:00'),
(167, 'Jorje', 11, '2.00', '2.00', 1, 31, '2020-04-22', '2020-04-24 00:00:00'),
(168, 'Cola', 422, '2.00', '1.00', 1, 32, '2020-04-24', '2020-04-24 00:00:00'),
(169, 'Pepsi', 80, '3.24', '1.22', 1, 10, '2020-04-24', NULL),
(170, 'Ruffles', 100, '1.20', '1.00', 1, 10, '2020-04-24', NULL),
(171, 'Oreo', 55, '1.40', '1.00', 1, 10, '2020-04-24', NULL),
(172, 'Crunch', 41, '1.11', '0.32', 1, 10, '2020-04-24', NULL),
(173, 'Furion', 190, '12.03', '9.55', 1, 10, '2020-04-24', NULL),
(174, 'Kalati', 30, '42.24', '4.52', 1, 10, '2020-04-24', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `position` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `position`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 0);

-- --------------------------------------------------------

--
-- Table structure for table `workshift`
--

CREATE TABLE `workshift` (
  `id` int(11) NOT NULL,
  `shift` text NOT NULL,
  `date` text NOT NULL,
  `empId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `workshift`
--

INSERT INTO `workshift` (`id`, `shift`, `date`, `empId`) VALUES
(1, 'DAY', '2020-04-09', 21),
(2, 'AFTERNOON', '2020-04-10', 21),
(3, 'DAY', '2020-05-01', 17),
(4, 'NIGHT', '2020-05-09', 23),
(5, 'NIGHT', '2020-05-09', 23);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `workshift`
--
ALTER TABLE `workshift`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=175;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `workshift`
--
ALTER TABLE `workshift`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
