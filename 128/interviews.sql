-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 06, 2019 at 10:01 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `altrastudios`
--

-- --------------------------------------------------------

--
-- Table structure for table `interviews`
--

CREATE TABLE `interviews` (
  `id` int(10) UNSIGNED NOT NULL,
  `Name` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Category` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Image` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Count` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `interviews`
--

INSERT INTO `interviews` (`id`, `Name`, `Category`, `Image`, `Count`, `created_at`, `updated_at`) VALUES
(1, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(2, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(3, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(4, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(5, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(6, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(7, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(8, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(9, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(10, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(11, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(12, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(13, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(14, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(15, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(16, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(17, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(18, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(19, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(20, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(21, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(22, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(23, '.Net Development', 'Web Development', 'https://altrastudios.com/images/interviews/asp-net-banner.jpg', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00'),
(24, 'T-SQL', 'Database', 'https://altrastudios.com/images/interviews/tsql.png', '50', '2019-01-05 22:00:00', '2019-01-05 22:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `interviews`
--
ALTER TABLE `interviews`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `interviews`
--
ALTER TABLE `interviews`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
