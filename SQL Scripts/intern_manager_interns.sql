-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: intern_manager
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `interns`
--

DROP TABLE IF EXISTS `interns`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `interns` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(200) NOT NULL,
  `last_name` varchar(200) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `internship_type` enum('PFA','PFE','Observation','Other') NOT NULL,
  `school` varchar(200) NOT NULL,
  `CNI` varchar(15) NOT NULL,
  `study_year` int NOT NULL,
  `study_branch` varchar(200) NOT NULL,
  `direction_accueil` varchar(200) NOT NULL,
  `entite_accueil` varchar(200) NOT NULL,
  `parrain` varchar(200) NOT NULL,
  `civilite` enum('madame','monsieur') NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `CIN_UNIQUE` (`CNI`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interns`
--

LOCK TABLES `interns` WRITE;
/*!40000 ALTER TABLE `interns` DISABLE KEYS */;
INSERT INTO `interns` VALUES (26,'Fatine','MOUJOUD','2023-07-01','2023-07-31','PFE','S/c de l\'Ecole Supérieure d\'Informatique et du Numérique Rabat','GA237207',3,'Génie Informatique','Direction de Site de Khouribga','Informatique (DSI/O/P/K)','M. TOUIJER Mohamed','madame'),(28,'Abdellah','EL FAKHRI','2023-07-01','2023-08-31','PFA','Ecole Marocaine de Sciences d\'Ingénieur','AA87320',2,'Information et Géstion','Direction site de Khouribga','Informatique (DSI/O/P/K)','Mme. EL OMARI Fadoua','monsieur'),(29,'Omar','BAGHDAOUI','2023-11-02','2023-12-03','Observation','Faculté de Sciences Université Ibn Tofail Kenitra','B331291',1,'Master Informatique','Direction du site de Casablanca','Informatique (DSI/O/P/C)','M. FKRAOUI Mahdi','monsieur'),(30,'Fatiha','MELOUNI','2023-10-16','2023-12-25','PFE','Ecole Hassania des Travaux Publics','X483321',3,'Génie Civil','Direction du Site de Khouribga','Raffinement (DSR/O/P/K)','Mme. EL FATHAOUI Malika','madame'),(31,'Abdelkader','BEN FENNOUL','2023-08-11','2023-09-21','Observation','Ecole Nationale des Sciences Appliquées Oujda','G38291',1,'Génie Mécanique','Direction du site de Khouribga','Maintenance (DSM/O/P/K)','Mme. ELFAROUQI Majda','monsieur'),(32,'Youness','MARDIT','2023-08-22','2023-10-09','PFA','Ecole Nationale Supérieure des Arts et Métiers Meknes','UA28374',2,'Génie Electrique','Direction du site de Khouribga','Maintenance (DSM/O/P/K)','M. ALLAOUI Abdelhaq','monsieur'),(33,'Mohamed','HANNOUNI','2023-08-18','2023-10-17','PFE','Ecole Nationale des Sciences Appliquées Kenitra','G283321',3,'Génie Mécatronique','Direction du site de Khouribga','Maintenance (DSM/O/P/K)','M. ABDELLAOUI Mohcine','monsieur'),(34,'Hasnaa','ELMAROUANI','2023-08-09','2023-10-08','Observation','Faculté de Sciences Université Sultan Moulay Slimane','Y293811',2,'Master Maths Physique','Direction du site de Benguerir','Acheminement (DSA/O/P/B)','M. ANIS Abdelhafid','madame'),(35,'Khadija','MAJDOUBI','2023-08-21','2023-10-09','PFA','Ecole Nationale Supérieure d\'Informatique et d\'Analyse des Systèmes Rabat','GB29388',2,'Big Data','Direction du site de Khouribga','Informatique (DSI/O/P/K)','M. HANNOUNI Mahfoud','madame'),(36,'Abdelilah','MAHFOUDI','2023-08-17','2023-10-17','Observation','Ecole Nationale des Sciences Appliquées Kenitra','BA283299',3,'Génie Informatique','Direction du site de Casablanca','Informatique (DSM/O/P/C)','Mme. FATINI Fatima','monsieur');
/*!40000 ALTER TABLE `interns` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-31 18:41:32
