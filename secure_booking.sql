-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 29, 2025 at 05:04 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `secure_booking`
--

-- --------------------------------------------------------

--
-- Table structure for table `audit_log`
--

CREATE TABLE `audit_log` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `action` varchar(100) DEFAULT NULL,
  `timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `audit_log`
--

INSERT INTO `audit_log` (`id`, `user_id`, `action`, `timestamp`) VALUES
(1, 1, 'Login Success', '2025-05-29 21:44:45'),
(2, NULL, 'Login Failed', '2025-05-29 22:15:45'),
(3, NULL, 'Login Failed', '2025-05-29 22:15:59'),
(4, NULL, 'Login Failed', '2025-05-29 22:16:17'),
(5, NULL, 'Login Failed', '2025-05-29 22:17:13'),
(6, NULL, 'Login Failed', '2025-05-29 22:18:12'),
(7, 1, 'Login Success', '2025-05-29 22:19:02'),
(8, 1, 'Login Success', '2025-05-29 22:21:09'),
(9, 1, 'Login Success', '2025-05-29 22:34:17'),
(10, 1, 'Login Success', '2025-05-29 22:38:45'),
(11, 2, 'Login Success', '2025-05-29 22:39:21'),
(12, 2, 'Login Success', '2025-05-29 22:39:51'),
(13, 1, 'Login Success', '2025-05-29 22:40:25'),
(14, NULL, 'Login Failed', '2025-05-29 22:53:03'),
(15, NULL, 'Login Failed', '2025-05-29 22:53:05'),
(16, NULL, 'Login Failed', '2025-05-29 22:53:07'),
(17, NULL, 'Login Failed', '2025-05-29 22:53:09'),
(18, NULL, 'Login Failed', '2025-05-29 22:53:10'),
(19, 1, 'Login Success', '2025-05-29 22:53:28'),
(20, 2, 'Login Success', '2025-05-29 22:54:27'),
(21, 2, 'Login Success', '2025-05-29 22:58:06');

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `booking_date` datetime DEFAULT NULL,
  `details` text DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp(),
  `location` varchar(100) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`id`, `user_id`, `booking_date`, `details`, `created_at`, `location`, `status`, `type`) VALUES
(1, 1, '2025-05-29 21:44:47', 'Hello', '2025-05-29 21:44:52', NULL, NULL, NULL),
(2, 1, '2025-05-29 22:34:19', 'Hello', '2025-05-29 22:34:30', 'Hello', 'Confirmed', 'Event');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` enum('admin','user') NOT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role`, `created_at`) VALUES
(1, 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'admin', '2025-05-29 21:44:23'),
(2, 'staff', '1562206543da764123c21bd524674f0a8aaf49c8a89744c97352fe677f7e4006', 'user', '2025-05-29 21:46:47'),
(3, 'admin2', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', '2025-05-29 22:17:46');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `audit_log`
--
ALTER TABLE `audit_log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `audit_log`
--
ALTER TABLE `audit_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `audit_log`
--
ALTER TABLE `audit_log`
  ADD CONSTRAINT `audit_log_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
