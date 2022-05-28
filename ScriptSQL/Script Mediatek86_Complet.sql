-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 27 mai 2022 à 16:12
-- Version du serveur : 8.0.27
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE `absence` (
  `IDPERSONNEL` int NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int NOT NULL,
  `DATEFIN` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci COMMENT='Création de la table des absences, de la base de données Mediatek';

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, '2019-11-13 00:00:00', 2, '2019-11-15 00:00:00'),
(1, '2020-06-23 00:00:00', 2, '2020-06-29 00:00:00'),
(1, '2020-10-20 00:00:00', 2, '2020-10-30 00:00:00'),
(1, '2021-01-01 00:00:00', 2, '2021-01-10 00:00:00'),
(1, '2021-06-27 00:00:00', 4, '2021-06-30 00:00:00'),
(1, '2021-07-14 00:00:00', 1, '2021-07-30 00:00:00'),
(1, '2022-05-02 00:00:00', 2, '2022-05-10 00:00:00'),
(2, '2019-03-03 00:00:00', 2, '2019-03-25 00:00:00'),
(2, '2019-11-20 00:00:00', 2, '2019-11-22 00:00:00'),
(2, '2020-10-02 00:00:00', 2, '2020-10-06 00:00:00'),
(2, '2021-10-05 00:00:00', 3, '2021-10-10 00:00:00'),
(2, '2021-12-20 00:00:00', 1, '2021-12-28 00:00:00'),
(2, '2022-03-15 00:00:00', 3, '2021-03-25 00:00:00'),
(3, '2019-02-20 00:00:00', 3, '2019-02-28 00:00:00'),
(3, '2019-09-19 00:00:00', 2, '2019-09-24 00:00:00'),
(3, '2019-10-02 00:00:00', 3, '2019-10-14 00:00:00'),
(3, '2020-01-06 00:00:00', 2, '2020-02-17 00:00:00'),
(3, '2020-05-17 00:00:00', 3, '2020-05-27 00:00:00'),
(3, '2020-09-02 00:00:00', 3, '2020-09-07 00:00:00'),
(3, '2020-11-07 00:00:00', 2, '2020-11-25 00:00:00'),
(3, '2021-07-06 00:00:00', 3, '2021-07-30 00:00:00'),
(3, '2022-02-15 00:00:00', 3, '2022-03-25 00:00:00'),
(4, '2022-04-14 00:00:00', 4, '2022-04-24 00:00:00'),
(5, '2020-06-11 00:00:00', 1, '2020-06-21 00:00:00'),
(5, '2020-09-21 00:00:00', 4, '2020-09-30 00:00:00'),
(5, '2021-12-15 00:00:00', 1, '2021-12-30 00:00:00'),
(5, '2022-04-01 00:00:00', 3, '2022-04-15 00:00:00'),
(6, '2020-11-19 00:00:00', 2, '2020-11-25 00:00:00'),
(6, '2021-01-01 00:00:00', 1, '2021-01-30 00:00:00'),
(6, '2021-08-03 00:00:00', 2, '2021-08-15 00:00:00'),
(6, '2021-12-03 00:00:00', 2, '2021-12-06 00:00:00'),
(7, '2019-04-02 00:00:00', 3, '2019-04-14 00:00:00'),
(7, '2019-10-20 00:00:00', 3, '2019-10-25 00:00:00'),
(7, '2020-03-14 00:00:00', 3, '2020-03-18 00:00:00'),
(7, '2020-07-15 00:00:00', 1, '2020-07-30 00:00:00'),
(7, '2020-11-02 00:00:00', 3, '2020-11-17 00:00:00'),
(7, '2021-04-03 00:00:00', 2, '2021-04-20 00:00:00'),
(7, '2021-07-03 00:00:00', 2, '2021-07-15 00:00:00'),
(7, '2021-09-13 00:00:00', 4, '2021-09-15 00:00:00'),
(8, '2020-12-19 00:00:00', 1, '2020-12-26 00:00:00'),
(8, '2021-08-23 00:00:00', 2, '2021-09-12 00:00:00'),
(8, '2021-10-01 00:00:00', 2, '2021-10-17 00:00:00'),
(8, '2022-01-03 00:00:00', 1, '2022-01-21 00:00:00'),
(9, '2020-04-15 00:00:00', 3, '2020-04-20 00:00:00'),
(9, '2020-12-15 00:00:00', 3, '2020-12-27 00:00:00'),
(9, '2021-07-01 00:00:00', 1, '2021-07-20 00:00:00'),
(9, '2021-11-17 00:00:00', 4, '2021-11-20 00:00:00'),
(10, '2021-04-02 00:00:00', 1, '2021-04-10 00:00:00'),
(2, '2022-02-09 00:00:00', 4, '2022-02-11 00:00:00'),
(4, '2019-07-18 00:00:00', 2, '2019-07-20 00:00:00'),
(4, '2021-06-11 00:00:00', 2, '2022-06-27 00:00:00'),
(4, '2021-11-09 00:00:00', 3, '2021-11-12 00:00:00'),
(0, '2022-05-03 00:00:00', 3, '2022-05-06 00:00:00'),
(4, '2022-02-02 00:00:00', 1, '2022-02-11 00:00:00'),
(4, '2022-02-01 00:00:00', 1, '2022-02-02 00:00:00'),
(4, '2022-01-31 00:00:00', 1, '2022-02-01 00:00:00'),
(6, '2021-06-08 00:00:00', 2, '2021-06-11 00:00:00'),
(12, '2022-05-04 00:00:00', 1, '2022-05-19 00:00:00'),
(2, '2022-05-25 00:00:00', 3, '2022-05-26 00:00:00'),
(2, '2022-05-04 00:00:00', 2, '2022-05-05 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE `motif` (
  `IDMOTIF` int NOT NULL,
  `LIBELLE` varchar(128) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci COMMENT='Ajout des champs de la table motif';

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'Vacances'),
(2, 'Maladie'),
(3, 'Motif familial'),
(4, 'Congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `IDPERSONNEL` int NOT NULL,
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci COMMENT='Ajout des champs de la table PERSONNEL';

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Dwayne', 'Jackobson', '896572358', 'dw.jkb.msafea@outlook.com'),
(3, 1, 'Macaulay', 'Harris', '78945642', 'quisque.varius@icloud.org'),
(4, 2, 'Coby', 'Dixon', '524757885', 'tristique.pharetra@yahoo.com'),
(5, 3, 'Hall', 'Meyers', '654987238', 'tempor@outlook.com'),
(6, 1, 'Ashley', 'Baird', '104578992', 'commodo.auctor@yahoo.com'),
(7, 3, 'Jessamine', 'Keller', '267026598', 'ullamcorper.velit@aol.edu'),
(8, 3, 'Hanae', 'Francis', '253555367', 'laoreet.libero.et@outlook.com'),
(9, 2, 'Kieran', 'Sweet', '849685139', 'ornare.facilisis.eget@icloud.net'),
(10, 2, 'Hilda', 'Lowe', '419322810', 'viverra@hotmail.net'),
(11, 1, 'Carissa', 'Roach', '212932672', 'vulputate@icloud.org'),
(15, 1, 'Steve', 'McGrt', '123456789', 'steve.mcgrt1458m@icloud.org'),
(19, 2, 'Bob', 'Azart', '123457898', 'erggz@icloud.org'),
(28, 3, 'Charlotte', 'Ofraise', '456782369', 'charlotte.fraise.chtOfra123@yahoo.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE `responsable` (
  `login` varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci COMMENT='Création de la table responsable ';

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('Samzei', 'c73822d3586f095acd31e40e0128ea1ae5801f6a935fda9c7f594b209924346f');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE `service` (
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci COMMENT='Ajout des champs de la table SERVICE';

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`IDMOTIF`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`IDPERSONNEL`),
  ADD UNIQUE KEY `IDPERSONNEL` (`IDPERSONNEL`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`IDSERVICE`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `IDPERSONNEL` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
