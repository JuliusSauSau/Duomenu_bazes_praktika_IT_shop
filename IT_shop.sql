-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: it_shop_repair
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `apmokejimas`
--

DROP TABLE IF EXISTS `apmokejimas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apmokejimas` (
  `ApmokejimoID` int NOT NULL AUTO_INCREMENT,
  `UzsakymoID` int DEFAULT NULL,
  `Apmokejimo_budas` varchar(50) DEFAULT NULL,
  `Suma` decimal(10,2) DEFAULT NULL,
  `Pervedimo_data` date DEFAULT NULL,
  PRIMARY KEY (`ApmokejimoID`),
  KEY `UzsakymoID` (`UzsakymoID`),
  CONSTRAINT `apmokejimas_ibfk_1` FOREIGN KEY (`UzsakymoID`) REFERENCES `uzsakymas` (`UzsakymoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apmokejimas`
--

LOCK TABLES `apmokejimas` WRITE;
/*!40000 ALTER TABLE `apmokejimas` DISABLE KEYS */;
INSERT INTO `apmokejimas` VALUES (1,1,'Kredito kortelė',799.99,'2024-05-20'),(2,2,'Banko pavedimas',999.99,'2024-05-21');
/*!40000 ALTER TABLE `apmokejimas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aptarnavimo_atsiliepimas`
--

DROP TABLE IF EXISTS `aptarnavimo_atsiliepimas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aptarnavimo_atsiliepimas` (
  `AptarnavimoAtsiliepimoID` int NOT NULL AUTO_INCREMENT,
  `PrekesPriemimasID` int DEFAULT NULL,
  `KlientoID` int DEFAULT NULL,
  `Atsiliepimo_text` text,
  `Atsiliepimo_ivertinimas` int DEFAULT NULL,
  PRIMARY KEY (`AptarnavimoAtsiliepimoID`),
  KEY `KlientoID` (`KlientoID`),
  CONSTRAINT `aptarnavimo_atsiliepimas_ibfk_1` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aptarnavimo_atsiliepimas`
--

LOCK TABLES `aptarnavimo_atsiliepimas` WRITE;
/*!40000 ALTER TABLE `aptarnavimo_atsiliepimas` DISABLE KEYS */;
INSERT INTO `aptarnavimo_atsiliepimas` VALUES (1,1,1,'Fast and reliable service',5);
/*!40000 ALTER TABLE `aptarnavimo_atsiliepimas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `atsiliepimai`
--

DROP TABLE IF EXISTS `atsiliepimai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `atsiliepimai` (
  `AtsiliepimoID` int NOT NULL AUTO_INCREMENT,
  `ProduktoID` int DEFAULT NULL,
  `KlientoID` int DEFAULT NULL,
  `Ivertinimas` int DEFAULT NULL,
  `Vertinimo_tekstas` text,
  PRIMARY KEY (`AtsiliepimoID`),
  KEY `ProduktoID` (`ProduktoID`),
  KEY `KlientoID` (`KlientoID`),
  CONSTRAINT `atsiliepimai_ibfk_1` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`),
  CONSTRAINT `atsiliepimai_ibfk_2` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atsiliepimai`
--

LOCK TABLES `atsiliepimai` WRITE;
/*!40000 ALTER TABLE `atsiliepimai` DISABLE KEYS */;
INSERT INTO `atsiliepimai` VALUES (1,1,1,5,'Great laptop!'),(2,2,2,4,'Good phone but a bit pricey.');
/*!40000 ALTER TABLE `atsiliepimai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `darbuotojai`
--

DROP TABLE IF EXISTS `darbuotojai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `darbuotojai` (
  `DarbuotojoID` int NOT NULL AUTO_INCREMENT,
  `PareigosID` int DEFAULT NULL,
  `Vardas` varchar(50) DEFAULT NULL,
  `Pavarde` varchar(50) DEFAULT NULL,
  `Elektroninis_pastas` varchar(100) DEFAULT NULL,
  `Telefono_numeris` varchar(20) DEFAULT NULL,
  `Slaptazodis` varchar(255) NOT NULL,
  PRIMARY KEY (`DarbuotojoID`),
  KEY `PareigosID` (`PareigosID`),
  CONSTRAINT `darbuotojai_ibfk_1` FOREIGN KEY (`PareigosID`) REFERENCES `pareigos` (`PareigosID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `darbuotojai`
--

LOCK TABLES `darbuotojai` WRITE;
/*!40000 ALTER TABLE `darbuotojai` DISABLE KEYS */;
INSERT INTO `darbuotojai` VALUES (1,1,'Jonas','Kaliska','admin@example.com','37061234570','123'),(2,2,'Petras','Niska','sales.manager@example.com','37061234571','123'),(3,3,'Andrius','Andriusaitis','andrius@example.com','37061234561','123'),(4,4,'Simona','Simonaite','simona@example.com','37061234562','123');
/*!40000 ALTER TABLE `darbuotojai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gamintojas`
--

DROP TABLE IF EXISTS `gamintojas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gamintojas` (
  `GamintojoID` int NOT NULL AUTO_INCREMENT,
  `Gamintojo_pavadinimas` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`GamintojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gamintojas`
--

LOCK TABLES `gamintojas` WRITE;
/*!40000 ALTER TABLE `gamintojas` DISABLE KEYS */;
INSERT INTO `gamintojas` VALUES (1,'Dell'),(2,'Apple'),(3,'Samsung');
/*!40000 ALTER TABLE `gamintojas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grazinimo_prasymai`
--

DROP TABLE IF EXISTS `grazinimo_prasymai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grazinimo_prasymai` (
  `GrazinimoID` int NOT NULL AUTO_INCREMENT,
  `UzsakymoID` int DEFAULT NULL,
  `KlientoID` int DEFAULT NULL,
  `Prasymo_data` date DEFAULT NULL,
  `Busena` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`GrazinimoID`),
  KEY `UzsakymoID` (`UzsakymoID`),
  KEY `KlientoID` (`KlientoID`),
  CONSTRAINT `grazinimo_prasymai_ibfk_1` FOREIGN KEY (`UzsakymoID`) REFERENCES `uzsakymas` (`UzsakymoID`),
  CONSTRAINT `grazinimo_prasymai_ibfk_2` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grazinimo_prasymai`
--

LOCK TABLES `grazinimo_prasymai` WRITE;
/*!40000 ALTER TABLE `grazinimo_prasymai` DISABLE KEYS */;
INSERT INTO `grazinimo_prasymai` VALUES (1,1,1,'2024-05-22','Laukiama');
/*!40000 ALTER TABLE `grazinimo_prasymai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kategorija`
--

DROP TABLE IF EXISTS `kategorija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kategorija` (
  `KategorijosID` int NOT NULL AUTO_INCREMENT,
  `Kategorijos_pavadinimas` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`KategorijosID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kategorija`
--

LOCK TABLES `kategorija` WRITE;
/*!40000 ALTER TABLE `kategorija` DISABLE KEYS */;
INSERT INTO `kategorija` VALUES (1,'Kompiuteriai'),(2,'Išmanieji Telefonai'),(3,'Priedai');
/*!40000 ALTER TABLE `kategorija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klientas`
--

DROP TABLE IF EXISTS `klientas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klientas` (
  `KlientoID` int NOT NULL AUTO_INCREMENT,
  `Vardas` varchar(50) DEFAULT NULL,
  `Pavarde` varchar(50) DEFAULT NULL,
  `Elektroninis_pastas` varchar(100) DEFAULT NULL,
  `Adresas` varchar(255) DEFAULT NULL,
  `Slaptazodis` varchar(255) DEFAULT NULL,
  `Telefono_numeris` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`KlientoID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klientas`
--

LOCK TABLES `klientas` WRITE;
/*!40000 ALTER TABLE `klientas` DISABLE KEYS */;
INSERT INTO `klientas` VALUES (1,'Jonas','Jonaitis','jonas.jonaitis@example.com','Vilnius, Lietuva','123','37061234567'),(2,'Petras','Petraitis','petras.petraitis@example.com','Kaunas, Lietuva','123','37069876543'),(3,'Jonas','Ninam','Ninam@example.com','Vilnius, Lietuva','123','37061280855');
/*!40000 ALTER TABLE `klientas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `krepselis`
--

DROP TABLE IF EXISTS `krepselis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `krepselis` (
  `KrepselioID` int NOT NULL AUTO_INCREMENT,
  `KlientoID` int DEFAULT NULL,
  `ProduktoID` int DEFAULT NULL,
  `Kiekis` int DEFAULT NULL,
  PRIMARY KEY (`KrepselioID`),
  KEY `KlientoID` (`KlientoID`),
  KEY `ProduktoID` (`ProduktoID`),
  CONSTRAINT `krepselis_ibfk_1` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`),
  CONSTRAINT `krepselis_ibfk_2` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `krepselis`
--

LOCK TABLES `krepselis` WRITE;
/*!40000 ALTER TABLE `krepselis` DISABLE KEYS */;
INSERT INTO `krepselis` VALUES (1,1,3,2);
/*!40000 ALTER TABLE `krepselis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kuponas`
--

DROP TABLE IF EXISTS `kuponas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kuponas` (
  `KuponoID` int NOT NULL AUTO_INCREMENT,
  `Nuolaidos_kodas` varchar(50) DEFAULT NULL,
  `Nuolaidos_dydis` decimal(10,2) DEFAULT NULL,
  `Galiojimo_laikas` date DEFAULT NULL,
  PRIMARY KEY (`KuponoID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kuponas`
--

LOCK TABLES `kuponas` WRITE;
/*!40000 ALTER TABLE `kuponas` DISABLE KEYS */;
INSERT INTO `kuponas` VALUES (1,'DISCOUNT10',10.00,'2024-12-31');
/*!40000 ALTER TABLE `kuponas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nuotraukos`
--

DROP TABLE IF EXISTS `nuotraukos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nuotraukos` (
  `NuotraukosID` int NOT NULL AUTO_INCREMENT,
  `ProduktoID` int DEFAULT NULL,
  `Nuotraukos_url` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NuotraukosID`),
  KEY `ProduktoID` (`ProduktoID`),
  CONSTRAINT `nuotraukos_ibfk_1` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nuotraukos`
--

LOCK TABLES `nuotraukos` WRITE;
/*!40000 ALTER TABLE `nuotraukos` DISABLE KEYS */;
INSERT INTO `nuotraukos` VALUES (1,1,'https://example.com/images/dell_inspiron_15.jpg'),(2,2,'https://example.com/images/iphone_12.jpg');
/*!40000 ALTER TABLE `nuotraukos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagalbos_laikas`
--

DROP TABLE IF EXISTS `pagalbos_laikas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagalbos_laikas` (
  `PagalbosLaikasID` int NOT NULL AUTO_INCREMENT,
  `KlientoID` int DEFAULT NULL,
  `DarbuotojoID` int DEFAULT NULL,
  `Pagalbos_aprašymas` text,
  `Busena` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PagalbosLaikasID`),
  KEY `KlientoID` (`KlientoID`),
  KEY `DarbuotojoID` (`DarbuotojoID`),
  CONSTRAINT `pagalbos_laikas_ibfk_1` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`),
  CONSTRAINT `pagalbos_laikas_ibfk_2` FOREIGN KEY (`DarbuotojoID`) REFERENCES `darbuotojai` (`DarbuotojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagalbos_laikas`
--

LOCK TABLES `pagalbos_laikas` WRITE;
/*!40000 ALTER TABLE `pagalbos_laikas` DISABLE KEYS */;
INSERT INTO `pagalbos_laikas` VALUES (1,1,1,'Problema su prisijungimu prie paskyros','Atlikta'),(2,2,2,'Klausimas apie produkto garantiją','Vykdoma');
/*!40000 ALTER TABLE `pagalbos_laikas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pardavimai`
--

DROP TABLE IF EXISTS `pardavimai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pardavimai` (
  `PardavimuID` int NOT NULL AUTO_INCREMENT,
  `ProduktoID` int DEFAULT NULL,
  `Pardavimu_kiekis` int DEFAULT NULL,
  `Pardavimo_data` date DEFAULT NULL,
  PRIMARY KEY (`PardavimuID`),
  KEY `ProduktoID` (`ProduktoID`),
  CONSTRAINT `pardavimai_ibfk_1` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pardavimai`
--

LOCK TABLES `pardavimai` WRITE;
/*!40000 ALTER TABLE `pardavimai` DISABLE KEYS */;
INSERT INTO `pardavimai` VALUES (1,1,5,'2024-05-19'),(2,2,3,'2024-05-20');
/*!40000 ALTER TABLE `pardavimai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pareigos`
--

DROP TABLE IF EXISTS `pareigos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pareigos` (
  `PareigosID` int NOT NULL AUTO_INCREMENT,
  `Pareigos_pavadinimas` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PareigosID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pareigos`
--

LOCK TABLES `pareigos` WRITE;
/*!40000 ALTER TABLE `pareigos` DISABLE KEYS */;
INSERT INTO `pareigos` VALUES (1,'Administratorius'),(2,'Pardavimų vadybininkas'),(3,'Kasininkas'),(4,'Konsultantas');
/*!40000 ALTER TABLE `pareigos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prekes_priemimas`
--

DROP TABLE IF EXISTS `prekes_priemimas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prekes_priemimas` (
  `PrekesPriemimasID` int NOT NULL AUTO_INCREMENT,
  `ProduktoID` int DEFAULT NULL,
  `Busena` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PrekesPriemimasID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prekes_priemimas`
--

LOCK TABLES `prekes_priemimas` WRITE;
/*!40000 ALTER TABLE `prekes_priemimas` DISABLE KEYS */;
INSERT INTO `prekes_priemimas` VALUES (1,1,'Priimta'),(2,2,'Priimta');
/*!40000 ALTER TABLE `prekes_priemimas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produktas`
--

DROP TABLE IF EXISTS `produktas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produktas` (
  `ProduktoID` int NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(100) DEFAULT NULL,
  `Kaina` decimal(10,2) DEFAULT NULL,
  `Aprasymas` text,
  `TiekejasID` int DEFAULT NULL,
  `KategorijaID` int DEFAULT NULL,
  `GamintojoID` int DEFAULT NULL,
  `Kiekis` int DEFAULT NULL,
  PRIMARY KEY (`ProduktoID`),
  KEY `TiekejasID` (`TiekejasID`),
  KEY `KategorijaID` (`KategorijaID`),
  KEY `GamintojoID` (`GamintojoID`),
  CONSTRAINT `produktas_ibfk_1` FOREIGN KEY (`TiekejasID`) REFERENCES `tiekejas` (`TiekejoID`),
  CONSTRAINT `produktas_ibfk_2` FOREIGN KEY (`KategorijaID`) REFERENCES `kategorija` (`KategorijosID`),
  CONSTRAINT `produktas_ibfk_3` FOREIGN KEY (`GamintojoID`) REFERENCES `gamintojas` (`GamintojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produktas`
--

LOCK TABLES `produktas` WRITE;
/*!40000 ALTER TABLE `produktas` DISABLE KEYS */;
INSERT INTO `produktas` VALUES (1,'Dell Inspiron 15',799.99,'15-inch laptop with the latest Intel processors',1,1,1,50),(2,'Apple iPhone 12',999.99,'Latest model with A14 Bionic chip',2,2,2,30),(3,'Samsung Galaxy S21',899.99,'Flagship phone with Exynos 2100',2,2,3,40);
/*!40000 ALTER TABLE `produktas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siuntimas`
--

DROP TABLE IF EXISTS `siuntimas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siuntimas` (
  `SiuntimoID` int NOT NULL AUTO_INCREMENT,
  `UzsakymoID` int DEFAULT NULL,
  `DarbuotojoID` int DEFAULT NULL,
  `Adresas` varchar(255) DEFAULT NULL,
  `Siuntimo_data` date DEFAULT NULL,
  PRIMARY KEY (`SiuntimoID`),
  KEY `UzsakymoID` (`UzsakymoID`),
  KEY `DarbuotojoID` (`DarbuotojoID`),
  CONSTRAINT `siuntimas_ibfk_1` FOREIGN KEY (`UzsakymoID`) REFERENCES `uzsakymas` (`UzsakymoID`),
  CONSTRAINT `siuntimas_ibfk_2` FOREIGN KEY (`DarbuotojoID`) REFERENCES `darbuotojai` (`DarbuotojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siuntimas`
--

LOCK TABLES `siuntimas` WRITE;
/*!40000 ALTER TABLE `siuntimas` DISABLE KEYS */;
INSERT INTO `siuntimas` VALUES (1,1,1,'Vilnius, Lietuva','2024-05-20'),(2,2,2,'Kaunas, Lietuva','2024-05-21');
/*!40000 ALTER TABLE `siuntimas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specifikacijos`
--

DROP TABLE IF EXISTS `specifikacijos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specifikacijos` (
  `SpecifikacijosID` int NOT NULL AUTO_INCREMENT,
  `ProduktoID` int DEFAULT NULL,
  `Specifikaciju_tekstas` text,
  PRIMARY KEY (`SpecifikacijosID`),
  KEY `ProduktoID` (`ProduktoID`),
  CONSTRAINT `specifikacijos_ibfk_1` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specifikacijos`
--

LOCK TABLES `specifikacijos` WRITE;
/*!40000 ALTER TABLE `specifikacijos` DISABLE KEYS */;
INSERT INTO `specifikacijos` VALUES (1,1,'Intel i7, 16GB RAM, 512GB SSD'),(2,2,'A14 Bionic, 6.1-inch display, 5G');
/*!40000 ALTER TABLE `specifikacijos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiekejas`
--

DROP TABLE IF EXISTS `tiekejas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiekejas` (
  `TiekejoID` int NOT NULL AUTO_INCREMENT,
  `Vardas` varchar(100) DEFAULT NULL,
  `Telefonas` varchar(20) DEFAULT NULL,
  `Elektroninis_pastas` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TiekejoID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiekejas`
--

LOCK TABLES `tiekejas` WRITE;
/*!40000 ALTER TABLE `tiekejas` DISABLE KEYS */;
INSERT INTO `tiekejas` VALUES (1,'Tech Supplier','37061234568','tech.supplier@example.com'),(2,'Gadgets Ltd.','37061234569','gadgets.ltd@example.com');
/*!40000 ALTER TABLE `tiekejas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uzsakymas`
--

DROP TABLE IF EXISTS `uzsakymas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uzsakymas` (
  `UzsakymoID` int NOT NULL AUTO_INCREMENT,
  `KlientoID` int DEFAULT NULL,
  `DarbuotojoID` int DEFAULT NULL,
  `Uzsakymo_data` date DEFAULT NULL,
  `Busena` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`UzsakymoID`),
  KEY `KlientoID` (`KlientoID`),
  CONSTRAINT `uzsakymas_ibfk_1` FOREIGN KEY (`KlientoID`) REFERENCES `klientas` (`KlientoID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uzsakymas`
--

LOCK TABLES `uzsakymas` WRITE;
/*!40000 ALTER TABLE `uzsakymas` DISABLE KEYS */;
INSERT INTO `uzsakymas` VALUES (1,1,2,'2024-05-20','Patvirtinta'),(2,2,2,'2024-05-21','Vykdoma'),(3,1,3,'2024-05-21','Patvirtinta'),(4,2,3,'2024-05-22','Vykdomas');
/*!40000 ALTER TABLE `uzsakymas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uzsakymasinfo`
--

DROP TABLE IF EXISTS `uzsakymasinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uzsakymasinfo` (
  `UzsakymoInfoID` int NOT NULL AUTO_INCREMENT,
  `UzsakymoID` int DEFAULT NULL,
  `ProduktoID` int DEFAULT NULL,
  `Kiekis` int DEFAULT NULL,
  `Kaina` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`UzsakymoInfoID`),
  KEY `UzsakymoID` (`UzsakymoID`),
  KEY `ProduktoID` (`ProduktoID`),
  CONSTRAINT `uzsakymasinfo_ibfk_1` FOREIGN KEY (`UzsakymoID`) REFERENCES `uzsakymas` (`UzsakymoID`),
  CONSTRAINT `uzsakymasinfo_ibfk_2` FOREIGN KEY (`ProduktoID`) REFERENCES `produktas` (`ProduktoID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uzsakymasinfo`
--

LOCK TABLES `uzsakymasinfo` WRITE;
/*!40000 ALTER TABLE `uzsakymasinfo` DISABLE KEYS */;
INSERT INTO `uzsakymasinfo` VALUES (1,1,1,1,799.99),(2,2,2,1,999.99),(3,3,1,1,799.99),(4,4,3,1,899.99);
/*!40000 ALTER TABLE `uzsakymasinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-22 17:32:18
