-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Mer 26 Mai 2021 à 13:51
-- Version du serveur :  5.7.11
-- Version de PHP :  7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe2`
--

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

CREATE TABLE `compte` (
  `NUMCOMPTE` int(11) NOT NULL,
  `PSEUDO` char(20) DEFAULT NULL,
  `NOMCOMPTE` char(20) DEFAULT NULL,
  `PRENOMCOMPTE` char(20) DEFAULT NULL,
  `ADRCOMPTE` char(70) DEFAULT NULL,
  `NUMTELCOMPTE` int(11) DEFAULT NULL,
  `DATENAISSANCE` date DEFAULT NULL,
  `DATEINSCRIPTION` date DEFAULT NULL,
  `DATEFINCOMPTE` date DEFAULT NULL,
  `MDPCOMPTE` char(16) DEFAULT NULL,
  `TYPECOMPTE` char(6) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf32;

--
-- Contenu de la table `compte`
--

INSERT INTO `compte` (`NUMCOMPTE`, `PSEUDO`, `NOMCOMPTE`, `PRENOMCOMPTE`, `ADRCOMPTE`, `NUMTELCOMPTE`, `DATENAISSANCE`, `DATEINSCRIPTION`, `DATEFINCOMPTE`, `MDPCOMPTE`, `TYPECOMPTE`) VALUES
(1, 'SCH', 'Pedro', 'Prisca', 'hatik@megan.fr', 678695400, '2021-03-08', '2021-03-27', '2021-08-19', 'coucou', 'admin'),
(3, 'Pripri', 'Pedro', 'Prisca', 'pripri91@hotmail.fr', 667548321, '2001-03-16', '2021-05-25', '2022-05-25', 'coucou', 'User'),
(5, 'dadju', 'Cool', 'Léa', 'LC12@gmail.com', 789432274, '2008-10-30', '2021-05-25', '2022-05-25', 'hatik', 'User'),
(7, 'prisca', 'Pedro', 'Prisca', 'dadju@gmail.com', 735261134, '2004-05-26', '2021-05-26', '2022-05-26', 'neymar', 'User');

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE `inscription` (
  `CODEPRESTA` varchar(10) NOT NULL,
  `DATESEANCE` date NOT NULL,
  `NUMCOMPTE` int(5) NOT NULL,
  `DATEINSCRIPTION` date DEFAULT NULL,
  `NBREJOUEURS` int(3) DEFAULT NULL,
  `NUMINSCRIPTION` int(11) NOT NULL,
  `Pseudo` char(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf32;

-- --------------------------------------------------------

--
-- Structure de la table `prestation`
--

CREATE TABLE `prestation` (
  `CODEPRESTA` varchar(10) NOT NULL,
  `NOMPRESTATION` char(32) DEFAULT NULL,
  `NBRETOTALPLACES` int(11) DEFAULT NULL,
  `TARIFPRESTATION` int(11) DEFAULT NULL,
  `DATECREATION` date DEFAULT NULL,
  `DATEVALIDITE` date DEFAULT NULL,
  `AGELIMITE` int(3) DEFAULT NULL,
  `DESCRIPTIONPRESTATION` char(150) DEFAULT NULL,
  `COMMENTAIREPRESTATION` char(150) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf32;

--
-- Contenu de la table `prestation`
--

INSERT INTO `prestation` (`CODEPRESTA`, `NOMPRESTATION`, `NBRETOTALPLACES`, `TARIFPRESTATION`, `DATECREATION`, `DATEVALIDITE`, `AGELIMITE`, `DESCRIPTIONPRESTATION`, `COMMENTAIREPRESTATION`) VALUES
('91', '5 VS 5', 10, 15, '2021-05-12', '2021-05-29', 15, 'Match entre deux équipes de 5.', 'Tous les joueurs doivent savoir faire du basket.'),
('12098', 'Tramponile basket', 35, 20, '2021-05-02', '2021-05-26', 5, 'Match de basket sur des trampolines.', 'Idéal pour les enfants. Les équipes se font par tranche d\'âge.'),
('98403', 'A l\'aveugle', 10, 12, '2021-02-09', '2021-05-24', 16, 'Match de basket à l\'aveugle.', 'Le but est de gagner le match en étant tous dans une salle dans le noir.');

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

CREATE TABLE `seance` (
  `CODEPRESTA` varchar(10) NOT NULL,
  `DATESEANCE` date NOT NULL,
  `PRIXSEANCE` int(32) DEFAULT NULL,
  `HEUREDEBUTSEANCE` time DEFAULT NULL,
  `HEUREFINSEANCE` time DEFAULT NULL,
  `NBREPLACES` int(11) DEFAULT NULL,
  `NUMTERRAIN` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf32;

--
-- Contenu de la table `seance`
--

INSERT INTO `seance` (`CODEPRESTA`, `DATESEANCE`, `PRIXSEANCE`, `HEUREDEBUTSEANCE`, `HEUREFINSEANCE`, `NBREPLACES`, `NUMTERRAIN`) VALUES
('91', '2021-05-28', 15, '14:20:00', '15:00:00', 10, 1),
('12098', '2021-06-08', 20, '10:30:00', '11:40:00', 35, 4),
('260301', '2021-05-27', 67, '17:29:01', '19:29:01', 33, 6);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `compte`
--
ALTER TABLE `compte`
  ADD PRIMARY KEY (`NUMCOMPTE`);

--
-- Index pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD PRIMARY KEY (`NUMINSCRIPTION`),
  ADD UNIQUE KEY `NUMINSCRIPTION` (`NUMINSCRIPTION`),
  ADD KEY `I_FK_INSCRIPTION_SEANCE` (`CODEPRESTA`,`DATESEANCE`),
  ADD KEY `I_FK_INSCRIPTION_COMPTE` (`NUMCOMPTE`);

--
-- Index pour la table `prestation`
--
ALTER TABLE `prestation`
  ADD PRIMARY KEY (`CODEPRESTA`);

--
-- Index pour la table `seance`
--
ALTER TABLE `seance`
  ADD PRIMARY KEY (`CODEPRESTA`,`DATESEANCE`),
  ADD KEY `I_FK_SEANCE_PRESTATION` (`CODEPRESTA`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `compte`
--
ALTER TABLE `compte`
  MODIFY `NUMCOMPTE` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `inscription`
--
ALTER TABLE `inscription`
  MODIFY `NUMINSCRIPTION` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
