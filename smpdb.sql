-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 03, 2026 at 06:53 PM
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
-- Database: `smpdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `abonnement`
--

CREATE TABLE `abonnement` (
  `abonnentId` int(11) NOT NULL,
  `abonnierteNutzerId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `beitrag`
--

CREATE TABLE `beitrag` (
  `beitragid` int(11) NOT NULL,
  `text` text DEFAULT NULL,
  `titel` text NOT NULL,
  `erstelltAm` datetime NOT NULL,
  `autor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `beitrag`
--

INSERT INTO `beitrag` (`beitragid`, `text`, `titel`, `erstelltAm`, `autor`) VALUES
(4, NULL, 'Hallo Welt', '2026-03-02 20:19:36', 3);

-- --------------------------------------------------------

--
-- Table structure for table `bild`
--

CREATE TABLE `bild` (
  `bildid` int(11) NOT NULL,
  `dateiname` text NOT NULL,
  `beitragid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bild`
--

INSERT INTO `bild` (`bildid`, `dateiname`, `beitragid`) VALUES
(5, '715de59c-5d68-4635-b222-0cdbb1302f10.jpg', 4),
(6, 'e71de9fe-2a09-4374-bdf9-5f573c5e94dd.jpg', 4),
(7, 'cb090e08-1b53-493a-8226-b57903100c62.jpg', 4),
(8, '4526fc58-d19e-4ff9-9a12-8f240ba13606.jpeg', 4),
(9, '656762d5-a664-4468-b901-a1d4725e299f.jpeg', 4);

-- --------------------------------------------------------

--
-- Table structure for table `kommentar`
--

CREATE TABLE `kommentar` (
  `kommentarid` int(11) NOT NULL,
  `nachricht` varchar(99) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `beitragId` int(11) NOT NULL,
  `autor` int(11) NOT NULL,
  `oberKommentarId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `likes`
--

CREATE TABLE `likes` (
  `nutzerId` int(11) NOT NULL,
  `beitragId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `likes`
--

INSERT INTO `likes` (`nutzerId`, `beitragId`) VALUES
(4, 4);

-- --------------------------------------------------------

--
-- Table structure for table `nutzer`
--

CREATE TABLE `nutzer` (
  `nutzerId` int(11) NOT NULL,
  `benutzerName` text NOT NULL,
  `passwort` text NOT NULL,
  `email` text NOT NULL,
  `zuletztAktiv` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nutzer`
--

INSERT INTO `nutzer` (`nutzerId`, `benutzerName`, `passwort`, `email`, `zuletztAktiv`) VALUES
(1, 'Nutzername...', 'Passwort festlegen...', 'Email Eingeben', '2026-02-13 12:14:59'),
(2, 'hilfe', '234', 'hilfe@gmail.com', '2026-02-13 12:16:50'),
(3, 'mario', '6s75CRWQqAYMe/ubQeHA5QvRFkmSvt8ItvKWRQ5Zc7Sj76P2+Bud/nsnOF21/GTb', 'ashdu@ask.de', '2026-03-02 20:19:06'),
(4, 'bitte', 'yLXuLEZXESjvzD3Lem9oD0HR7lauLQxnXRw82UUgV03zPkJP1VTnxL9jio3ndZ/k', 'hilfe@sdas', '2026-03-03 18:46:51');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `abonnement`
--
ALTER TABLE `abonnement`
  ADD PRIMARY KEY (`abonnentId`,`abonnierteNutzerId`),
  ADD KEY `abonnierteNutzerFK` (`abonnierteNutzerId`);

--
-- Indexes for table `beitrag`
--
ALTER TABLE `beitrag`
  ADD PRIMARY KEY (`beitragid`),
  ADD KEY `autorFK` (`autor`);

--
-- Indexes for table `bild`
--
ALTER TABLE `bild`
  ADD PRIMARY KEY (`bildid`),
  ADD KEY `help` (`beitragid`);

--
-- Indexes for table `kommentar`
--
ALTER TABLE `kommentar`
  ADD PRIMARY KEY (`kommentarid`),
  ADD KEY `beitragFK` (`beitragId`),
  ADD KEY `oberKommentarId` (`oberKommentarId`),
  ADD KEY `asd` (`autor`);

--
-- Indexes for table `likes`
--
ALTER TABLE `likes`
  ADD PRIMARY KEY (`nutzerId`,`beitragId`),
  ADD KEY `beitragIDFK` (`beitragId`);

--
-- Indexes for table `nutzer`
--
ALTER TABLE `nutzer`
  ADD PRIMARY KEY (`nutzerId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `beitrag`
--
ALTER TABLE `beitrag`
  MODIFY `beitragid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `bild`
--
ALTER TABLE `bild`
  MODIFY `bildid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `kommentar`
--
ALTER TABLE `kommentar`
  MODIFY `kommentarid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `nutzer`
--
ALTER TABLE `nutzer`
  MODIFY `nutzerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `abonnement`
--
ALTER TABLE `abonnement`
  ADD CONSTRAINT `abonnentFk` FOREIGN KEY (`abonnentId`) REFERENCES `nutzer` (`nutzerId`),
  ADD CONSTRAINT `abonnierteNutzerFK` FOREIGN KEY (`abonnierteNutzerId`) REFERENCES `nutzer` (`nutzerId`);

--
-- Constraints for table `beitrag`
--
ALTER TABLE `beitrag`
  ADD CONSTRAINT `autorFK` FOREIGN KEY (`autor`) REFERENCES `nutzer` (`nutzerId`);

--
-- Constraints for table `bild`
--
ALTER TABLE `bild`
  ADD CONSTRAINT `help` FOREIGN KEY (`beitragid`) REFERENCES `beitrag` (`beitragid`) ON UPDATE CASCADE;

--
-- Constraints for table `kommentar`
--
ALTER TABLE `kommentar`
  ADD CONSTRAINT `asd` FOREIGN KEY (`autor`) REFERENCES `nutzer` (`nutzerId`),
  ADD CONSTRAINT `beitragFK` FOREIGN KEY (`beitragId`) REFERENCES `beitrag` (`beitragid`),
  ADD CONSTRAINT `oberKommentarId` FOREIGN KEY (`oberKommentarId`) REFERENCES `kommentar` (`kommentarid`);

--
-- Constraints for table `likes`
--
ALTER TABLE `likes`
  ADD CONSTRAINT `beitragIDFK` FOREIGN KEY (`beitragId`) REFERENCES `beitrag` (`beitragid`),
  ADD CONSTRAINT `nutzerIdFK` FOREIGN KEY (`nutzerId`) REFERENCES `nutzer` (`nutzerId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
