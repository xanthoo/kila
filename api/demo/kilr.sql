-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: 2020 m. Kov 01 d. 10:01
-- Server version: 5.7.28-0ubuntu0.18.04.4
-- PHP Version: 7.2.24-0ubuntu0.18.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kilr`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `departments`
--

CREATE TABLE `departments` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `departments`
--

INSERT INTO `departments` (`id`, `name`) VALUES
(1, 'South House'),
(2, 'North House');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `employees`
--

CREATE TABLE `employees` (
  `id` int(11) NOT NULL,
  `department_id` int(11) DEFAULT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `adress` varchar(255) NOT NULL,
  `shift` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `hourly_wage` int(11) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `employees`
--

INSERT INTO `employees` (`id`, `department_id`, `first_name`, `last_name`, `adress`, `shift`, `position`, `hourly_wage`, `email`) VALUES
(1, 1, 'Lukas', 'Rimavicius', 'Home str. 42', 'Morning', 'Director', 5, 'sdfeerrw@gmail.com'),
(2, 2, 'John', 'Sally', 'Deedas str. 3', 'Evening', 'Cooker', 9, 'emmammm@gmail.com');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `stock`
--

CREATE TABLE `stock` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `minimum` int(11) DEFAULT NULL,
  `maximum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employees_fk0` (`department_id`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Apribojimai eksportuotom lentelėm
--

--
-- Apribojimai lentelei `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_fk0` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
