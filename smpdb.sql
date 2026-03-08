-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 08. Mrz 2026 um 09:49
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `smpdb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `abonnement`
--

CREATE TABLE `abonnement` (
  `abonnentId` int(11) NOT NULL,
  `abonnierteNutzerId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `beitrag`
--

CREATE TABLE `beitrag` (
  `beitragid` int(11) NOT NULL,
  `text` text DEFAULT NULL,
  `titel` text NOT NULL,
  `erstelltAm` datetime NOT NULL,
  `autor` int(11) NOT NULL,
  `tag` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bild`
--

CREATE TABLE `bild` (
  `bildid` int(11) NOT NULL,
  `dateiname` text NOT NULL,
  `beitragid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kommentar`
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
-- Tabellenstruktur für Tabelle `likes`
--

CREATE TABLE `likes` (
  `nutzerId` int(11) NOT NULL,
  `beitragId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `nutzer`
--

CREATE TABLE `nutzer` (
  `nutzerId` int(11) NOT NULL,
  `benutzerName` text NOT NULL,
  `passwort` text NOT NULL,
  `email` text NOT NULL,
  `zuletztAktiv` datetime NOT NULL,
  `profilBild` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `abonnement`
--
ALTER TABLE `abonnement`
  ADD PRIMARY KEY (`abonnentId`,`abonnierteNutzerId`),
  ADD KEY `abonnierteNutzerFK` (`abonnierteNutzerId`);

--
-- Indizes für die Tabelle `beitrag`
--
ALTER TABLE `beitrag`
  ADD PRIMARY KEY (`beitragid`),
  ADD KEY `autorFK` (`autor`);

--
-- Indizes für die Tabelle `bild`
--
ALTER TABLE `bild`
  ADD PRIMARY KEY (`bildid`),
  ADD KEY `help` (`beitragid`);

--
-- Indizes für die Tabelle `kommentar`
--
ALTER TABLE `kommentar`
  ADD PRIMARY KEY (`kommentarid`),
  ADD KEY `beitragFK` (`beitragId`),
  ADD KEY `oberKommentarId` (`oberKommentarId`),
  ADD KEY `asd` (`autor`);

--
-- Indizes für die Tabelle `likes`
--
ALTER TABLE `likes`
  ADD PRIMARY KEY (`nutzerId`,`beitragId`),
  ADD KEY `beitragIDFK` (`beitragId`);

--
-- Indizes für die Tabelle `nutzer`
--
ALTER TABLE `nutzer`
  ADD PRIMARY KEY (`nutzerId`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `beitrag`
--
ALTER TABLE `beitrag`
  MODIFY `beitragid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `bild`
--
ALTER TABLE `bild`
  MODIFY `bildid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT für Tabelle `kommentar`
--
ALTER TABLE `kommentar`
  MODIFY `kommentarid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `nutzer`
--
ALTER TABLE `nutzer`
  MODIFY `nutzerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `abonnement`
--
ALTER TABLE `abonnement`
  ADD CONSTRAINT `abonnentFk` FOREIGN KEY (`abonnentId`) REFERENCES `nutzer` (`nutzerId`),
  ADD CONSTRAINT `abonnierteNutzerFK` FOREIGN KEY (`abonnierteNutzerId`) REFERENCES `nutzer` (`nutzerId`);

--
-- Constraints der Tabelle `beitrag`
--
ALTER TABLE `beitrag`
  ADD CONSTRAINT `autorFK` FOREIGN KEY (`autor`) REFERENCES `nutzer` (`nutzerId`);

--
-- Constraints der Tabelle `bild`
--
ALTER TABLE `bild`
  ADD CONSTRAINT `help` FOREIGN KEY (`beitragid`) REFERENCES `beitrag` (`beitragid`) ON UPDATE CASCADE;

--
-- Constraints der Tabelle `kommentar`
--
ALTER TABLE `kommentar`
  ADD CONSTRAINT `asd` FOREIGN KEY (`autor`) REFERENCES `nutzer` (`nutzerId`),
  ADD CONSTRAINT `beitragFK` FOREIGN KEY (`beitragId`) REFERENCES `beitrag` (`beitragid`),
  ADD CONSTRAINT `oberKommentarId` FOREIGN KEY (`oberKommentarId`) REFERENCES `kommentar` (`kommentarid`);

--
-- Constraints der Tabelle `likes`
--
ALTER TABLE `likes`
  ADD CONSTRAINT `beitragIDFK` FOREIGN KEY (`beitragId`) REFERENCES `beitrag` (`beitragid`),
  ADD CONSTRAINT `nutzerIdFK` FOREIGN KEY (`nutzerId`) REFERENCES `nutzer` (`nutzerId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
