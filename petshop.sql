-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: petshop
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Корм'),(2,'Уход'),(3,'Игрушки'),(4,'Ошейники/Шлейки'),(5,'Лежаки'),(6,'Миски');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `category_AFTER_INSERT` AFTER INSERT ON `category` FOR EACH ROW BEGIN
INSERT INTO categorytr Set 
date = now(),
query = 'insert',
id_row = NEW.id,
Title = NEW.Title;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `category_AFTER_UPDATE` AFTER UPDATE ON `category` FOR EACH ROW BEGIN
INSERT INTO categorytr Set 
date = now(),
query = 'update',
id_row = OLD.id,
Title = OLD.Title;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `category_AFTER_DELETE` AFTER DELETE ON `category` FOR EACH ROW BEGIN
INSERT INTO categorytr Set 
date = now(),
query = 'delete',
id_row = OLD.id,
Title = OLD.Title;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `categorytr`
--

DROP TABLE IF EXISTS `categorytr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorytr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Title` varchar(150) NOT NULL,
  `Description` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorytr`
--

LOCK TABLES `categorytr` WRITE;
/*!40000 ALTER TABLE `categorytr` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorytr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Status` varchar(20) DEFAULT NULL,
  `Name` varchar(20) NOT NULL,
  `Surname` varchar(20) NOT NULL,
  `Login` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Work_id` int NOT NULL,
  `Position` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Work_id` (`Work_id`) /*!80000 INVISIBLE */,
  CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`Work_id`) REFERENCES `work_chedule` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'работник','Любовь','Михайлова','admin','1',1,'Администратор'),(2,'работник','Андрей','Петров','manager','2',3,'Кадровый менеджер'),(3,'работник','Анна','Иванова','seller','3',3,'Продавец');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `employee_AFTER_UPDATE` AFTER UPDATE ON `employee` FOR EACH ROW BEGIN
INSERT INTO employeetr Set 
date = now(),
query = 'update',
id_row = OLD.id,
Status = OLD.Status,
name = OLD.name,
surname = OLD.surname,
login = OLD.login,
password = OLD.password,
work_id = OLD.work_id,
position = OLD.position;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `employee_AFTER_DELETE` AFTER DELETE ON `employee` FOR EACH ROW BEGIN
INSERT INTO employeetr Set 
date = now(),
query = 'update',
id_row = OLD.id,
Status = OLD.Status,
name = OLD.name,
surname = OLD.surname,
login = OLD.login,
password = OLD.password,
work_id = OLD.work_id,
position = OLD.position;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `employeetr`
--

DROP TABLE IF EXISTS `employeetr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeetr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Position` varchar(45) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Surname` varchar(20) NOT NULL,
  `Login` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Work_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeetr`
--

LOCK TABLES `employeetr` WRITE;
/*!40000 ALTER TABLE `employeetr` DISABLE KEYS */;
INSERT INTO `employeetr` VALUES (1,'2022-03-15 12:38:45','update',3,'работник','Продавец','Анна','Иванова','seller','3',3),(2,'2022-03-15 12:38:48','update',3,'уволен','Продавец','Анна','Иванова','seller','3',3),(3,'2022-03-15 12:39:44','update',3,'работник','Продавец','Анна','Иванова','seller','3',3),(4,'2022-03-15 12:39:51','update',3,'уволен','Продавец','Анна','Иванова','seller','3',3);
/*!40000 ALTER TABLE `employeetr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Status` varchar(20) NOT NULL,
  `Price` int NOT NULL,
  `Number` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Category_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Product_Category1_idx` (`Category_id`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_Product_Category1` FOREIGN KEY (`Category_id`) REFERENCES `category` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'отстутсвует',1990,24,'Для кошек',1),(2,'в наличии',1900,23,'Для собак',1),(3,'в наличии',1710,25,'Для грызунов',1),(4,'в наличии',500,31,'Шампунь',2),(5,'в наличии',250,11,'Когтерезка',2),(6,'в наличии',450,27,'Мяч',3),(7,'в наличии',300,36,'Дразнилка',3),(8,'в наличии',250,16,'Мышка',3),(9,'в наличии',500,11,'Ошейник',4),(10,'в наличии',650,13,'Шлейка',4),(11,'в наличии',300,9,'Адресник',4),(12,'в наличии',1800,14,'Лежанка',5),(13,'в наличии',2100,13,'Домик',5),(14,'в наличии',3500,8,'Автокормушка',6),(15,'в наличии',1500,9,'Миска на подставке',6),(16,'в наличии',550,9,'Миска керамическая',6),(18,'в наличии',160,60,'Капли от блох',2);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `product_AFTER_INSERT` AFTER INSERT ON `product` FOR EACH ROW BEGIN
INSERT INTO producttr Set 
date = now(),
query = 'insert',
id_row = NEW.id,
Status = NEW.Status,
Category_id = NEW.Category_id,
Price = NEW.Price,
Number = NEW.Number,
Name = NEW.Name;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `product_AFTER_UPDATE` AFTER UPDATE ON `product` FOR EACH ROW BEGIN
INSERT INTO producttr Set 
date = now(),
query = 'update',
id_row = OLD.id,
Status = OLD.Status,
Category_id = OLD.Category_id,
Price = OLD.Price,
Number = OLD.Number,
Name = OLD.Name;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `product_AFTER_DELETE` AFTER DELETE ON `product` FOR EACH ROW BEGIN
INSERT INTO producttr Set 
date = now(),
query = 'delete',
id_row = OLD.id,
Status = OLD.Status,
Category_id = OLD.Category_id,
Price = OLD.Price,
Number = OLD.Number,
Name = OLD.Name;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `product_list`
--

DROP TABLE IF EXISTS `product_list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_list` (
  `Products_id` int NOT NULL,
  `Purchase_id` int DEFAULT NULL,
  `Sales_id` int DEFAULT NULL,
  `Number` int NOT NULL,
  KEY `Purchase_id` (`Purchase_id`),
  KEY `Sales_id` (`Sales_id`),
  KEY `Products_id` (`Products_id`),
  CONSTRAINT `product_list_ibfk_1` FOREIGN KEY (`Products_id`) REFERENCES `product` (`id`),
  CONSTRAINT `product_list_ibfk_2` FOREIGN KEY (`Products_id`) REFERENCES `product` (`id`),
  CONSTRAINT `product_list_ibfk_3` FOREIGN KEY (`Purchase_id`) REFERENCES `purchase` (`id`),
  CONSTRAINT `product_list_ibfk_4` FOREIGN KEY (`Sales_id`) REFERENCES `sales` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_list`
--

LOCK TABLES `product_list` WRITE;
/*!40000 ALTER TABLE `product_list` DISABLE KEYS */;
/*!40000 ALTER TABLE `product_list` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producttr`
--

DROP TABLE IF EXISTS `producttr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Price` int NOT NULL,
  `Number` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Category_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttr`
--

LOCK TABLES `producttr` WRITE;
/*!40000 ALTER TABLE `producttr` DISABLE KEYS */;
INSERT INTO `producttr` VALUES (51,'2021-12-21 01:20:17','update',6,'в наличии',450,23,'Мяч',3),(52,'2021-12-21 01:20:17','update',10,'в наличии',650,4,'Шлейка',4),(53,'2021-12-21 01:20:17','update',5,'в наличии',250,7,'Когтерезка',2),(54,'2021-12-21 01:39:09','update',8,'в наличии',250,14,'Мышка',3),(55,'2021-12-21 01:39:09','update',13,'в наличии',2100,9,'Домик',5),(56,'2021-12-21 01:47:19','update',2,'в наличии',1900,18,'Для собак',1),(57,'2021-12-21 01:47:19','update',7,'в наличии',300,23,'Дразнилка',3),(58,'2021-12-21 01:53:38','update',4,'в наличии',500,27,'Шампунь',2),(59,'2021-12-21 01:53:38','update',7,'в наличии',300,24,'Дразнилка',3),(60,'2021-12-21 01:54:08','update',5,'в наличии',250,9,'Когтерезка',2),(61,'2021-12-21 01:55:32','update',5,'в наличии',250,10,'Когтерезка',2),(62,'2021-12-21 01:56:42','update',2,'в наличии',1900,19,'Для собак',1),(63,'2021-12-21 01:57:17','update',7,'в наличии',300,26,'Дразнилка',3),(64,'2021-12-21 01:58:27','update',7,'в наличии',300,28,'Дразнилка',3),(65,'2021-12-21 02:18:47','update',2,'в наличии',1900,20,'Для собак',1),(66,'2021-12-21 02:18:47','update',4,'в наличии',500,29,'Шампунь',2),(67,'2021-12-21 02:22:17','update',1,'в наличии',1990,23,'Для кошек',1),(68,'2021-12-21 02:22:17','update',4,'в наличии',500,30,'Шампунь',2),(69,'2021-12-21 02:24:45','update',6,'в наличии',450,25,'Мяч',3),(70,'2021-12-21 02:24:45','update',13,'в наличии',2100,11,'Домик',5),(71,'2021-12-21 02:26:12','update',3,'в наличии',1710,24,'Для грызунов',1),(72,'2021-12-21 02:26:51','update',7,'в наличии',300,29,'Дразнилка',3),(73,'2021-12-21 02:26:51','update',9,'в наличии',500,7,'Ошейник',4),(74,'2021-12-22 13:29:43','update',1,'в наличии',1990,24,'Для кошек',1),(75,'2021-12-22 13:31:23','update',2,'в наличии',1900,21,'Для собак',1),(76,'2021-12-22 13:32:36','delete',17,'в наличии',310,12,'Миска металлическая',6),(77,'2021-12-22 13:33:26','update',1,'отстутсвует',1990,24,'Для кошек',1),(78,'2021-12-22 13:33:26','update',2,'отстутсвует',1900,21,'Для собак',1),(79,'2022-03-15 12:35:46','update',2,'в наличии',1900,21,'Для собак',1),(80,'2022-03-15 12:35:46','update',9,'в наличии',500,9,'Ошейник',4),(81,'2022-03-15 12:35:46','update',10,'в наличии',650,6,'Шлейка',4),(82,'2022-03-15 12:36:41','update',1,'в наличии',1990,24,'Для кошек',1),(83,'2022-03-15 12:44:08','update',10,'в наличии',650,8,'Шлейка',4),(84,'2022-03-15 12:44:08','update',7,'в наличии',300,31,'Дразнилка',3),(85,'2022-03-15 12:46:41','insert',18,'в наличии',160,10,'Капли от блох',2),(86,'2022-03-15 12:47:36','update',18,'в наличии',160,10,'Капли от блох',2);
/*!40000 ALTER TABLE `producttr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Transaction_id` int NOT NULL,
  `Date` date NOT NULL,
  `Price` int DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `purchase_ibfk_1` (`Transaction_id`),
  CONSTRAINT `purchase_ibfk_1` FOREIGN KEY (`Transaction_id`) REFERENCES `transaction` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase`
--

LOCK TABLES `purchase` WRITE;
/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
INSERT INTO `purchase` VALUES (1,1,'2022-03-15',5450,'отменено'),(2,2,'2022-03-15',6250,'выполнено'),(3,3,'2022-03-15',8000,'выполнено');
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `purchase_AFTER_INSERT` AFTER INSERT ON `purchase` FOR EACH ROW BEGIN
INSERT INTO purchasetr Set 
datee = now(),
query = 'insert',
id_row = NEW.id,
Status = NEW.Status,
Transaction_id = NEW.Transaction_id,
Date = NEW.Date,
Price = NEW.Price;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `purchase_AFTER_UPDATE` AFTER UPDATE ON `purchase` FOR EACH ROW BEGIN
INSERT INTO purchasetr Set 
datee = now(),
query = 'update',
id_row = OLD.id,
Status = OLD.Status,
Transaction_id = OLD.Transaction_id,
Date = OLD.Date,
Price = OLD.Price;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `purchasetr`
--

DROP TABLE IF EXISTS `purchasetr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchasetr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datee` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Date` date NOT NULL,
  `Transaction_id` int NOT NULL,
  `Price` int DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasetr`
--

LOCK TABLES `purchasetr` WRITE;
/*!40000 ALTER TABLE `purchasetr` DISABLE KEYS */;
INSERT INTO `purchasetr` VALUES (1,'2022-03-15 12:35:09','insert',1,'2022-03-15',1,5450,'отменено'),(6,'2022-03-15 12:35:51','update',1,'2022-03-15',1,5450,'выполнено'),(7,'2022-03-15 12:36:04','update',1,'2022-03-15',1,5450,'отменено'),(8,'2022-03-15 12:36:07','update',1,'2022-03-15',1,5450,'выполнено'),(9,'2022-03-15 12:42:50','insert',2,'2022-03-15',2,NULL,NULL),(13,'2022-03-15 12:47:23','insert',3,'2022-03-15',3,NULL,NULL);
/*!40000 ALTER TABLE `purchasetr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Transaction_id` int NOT NULL,
  `Date` date NOT NULL,
  `Price` int DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Transaction_id` (`Transaction_id`),
  CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`Transaction_id`) REFERENCES `transaction` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `sales_AFTER_INSERT` AFTER INSERT ON `sales` FOR EACH ROW BEGIN
INSERT INTO salestr Set 
datee = now(),
query = 'insert',
id_row = NEW.id,
Status = NEW.Status,
Transaction_id = NEW.Transaction_id,
Date = NEW.Date,
Price = NEW.Price;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `sales_AFTER_UPDATE` AFTER UPDATE ON `sales` FOR EACH ROW BEGIN
INSERT INTO salestr Set 
datee = now(),
query = 'insert',
id_row = OLD.id,
Status = OLD.Status,
Transaction_id = OLD.Transaction_id,
Date = OLD.Date,
Price = OLD.Price;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `salestr`
--

DROP TABLE IF EXISTS `salestr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salestr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datee` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Transaction_id` int NOT NULL,
  `Date` date NOT NULL,
  `Price` int DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salestr`
--

LOCK TABLES `salestr` WRITE;
/*!40000 ALTER TABLE `salestr` DISABLE KEYS */;
/*!40000 ALTER TABLE `salestr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transaction` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Employee_id` int NOT NULL,
  `Status` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Employee_id` (`Employee_id`),
  CONSTRAINT `transaction_ibfk_3` FOREIGN KEY (`Employee_id`) REFERENCES `employee` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (1,1,1),(2,1,1),(3,1,1);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `transaction_AFTER_INSERT` AFTER INSERT ON `transaction` FOR EACH ROW BEGIN
INSERT INTO transactiontr Set 
datee = now(),
query = 'insert',
id_row = NEW.id,
Employee_id = NEW.Employee_id,
Status = NEW.Status;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `transaction_AFTER_UPDATE` AFTER UPDATE ON `transaction` FOR EACH ROW BEGIN
INSERT INTO transactiontr Set 
datee = now(),
query = 'update',
id_row = OLD.id,
Employee_id = OLD.Employee_id,
Status = OLD.Status;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `transaction_AFTER_DELETE` AFTER DELETE ON `transaction` FOR EACH ROW BEGIN
INSERT INTO transactiontr Set 
datee = now(),
query = 'delete',
id_row = OLD.id,
Employee_id = OLD.Employee_id,
Status = OLD.Status;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `transactiontr`
--

DROP TABLE IF EXISTS `transactiontr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transactiontr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datee` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Employee_id` int NOT NULL,
  `Status` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactiontr`
--

LOCK TABLES `transactiontr` WRITE;
/*!40000 ALTER TABLE `transactiontr` DISABLE KEYS */;
INSERT INTO `transactiontr` VALUES (1,'2022-03-15 12:35:09','insert',1,1,NULL),(2,'2022-03-15 12:35:46','update',1,1,NULL),(3,'2022-03-15 12:35:51','update',1,1,1),(4,'2022-03-15 12:36:04','update',1,1,0),(5,'2022-03-15 12:36:07','update',1,1,1),(6,'2022-03-15 12:42:50','insert',2,1,NULL),(7,'2022-03-15 12:44:08','update',2,1,NULL),(8,'2022-03-15 12:47:23','insert',3,1,NULL),(9,'2022-03-15 12:47:36','update',3,1,NULL);
/*!40000 ALTER TABLE `transactiontr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vacation_schedule`
--

DROP TABLE IF EXISTS `vacation_schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vacation_schedule` (
  `id` int NOT NULL AUTO_INCREMENT,
  `start_vacation` date NOT NULL,
  `end_vacation` date NOT NULL,
  `Employee_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Employee_id` (`Employee_id`),
  CONSTRAINT `vacation_schedule_ibfk_1` FOREIGN KEY (`Employee_id`) REFERENCES `employee` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacation_schedule`
--

LOCK TABLES `vacation_schedule` WRITE;
/*!40000 ALTER TABLE `vacation_schedule` DISABLE KEYS */;
INSERT INTO `vacation_schedule` VALUES (1,'2022-05-01','2022-06-01',1),(2,'2022-06-01','2022-07-01',2),(3,'2022-07-01','2022-08-02',3);
/*!40000 ALTER TABLE `vacation_schedule` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `vacation_schedule_AFTER_INSERT` AFTER INSERT ON `vacation_schedule` FOR EACH ROW BEGIN
INSERT INTO vacation_scheduletr Set 
datee = now(),
query = 'insert',
id_row = NEW.id,
Employee_id = NEW.Employee_id,
start_vacation = NEW.start_vacation,
end_vacation = NEW.end_vacation;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `vacation_schedule_AFTER_UPDATE` AFTER UPDATE ON `vacation_schedule` FOR EACH ROW BEGIN
INSERT INTO vacation_scheduletr Set 
datee = now(),
query = 'update',
id_row = OLD.id,
Employee_id = OLD.Employee_id,
start_vacation = OLD.start_vacation,
end_vacation = OLD.end_vacation;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `vacation_schedule_AFTER_DELETE` AFTER DELETE ON `vacation_schedule` FOR EACH ROW BEGIN
INSERT INTO vacation_scheduletr Set 
datee = now(),
query = 'delete',
id_row = OLD.id,
Employee_id = OLD.Employee_id,
start_vacation = OLD.start_vacation,
end_vacation = OLD.end_vacation;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `vacation_scheduletr`
--

DROP TABLE IF EXISTS `vacation_scheduletr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vacation_scheduletr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datee` datetime DEFAULT NULL,
  `query` varchar(15) DEFAULT NULL,
  `id_row` int NOT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `start_vacation` date NOT NULL,
  `end_vacation` date NOT NULL,
  `Employee_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacation_scheduletr`
--

LOCK TABLES `vacation_scheduletr` WRITE;
/*!40000 ALTER TABLE `vacation_scheduletr` DISABLE KEYS */;
/*!40000 ALTER TABLE `vacation_scheduletr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `work_chedule`
--

DROP TABLE IF EXISTS `work_chedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `work_chedule` (
  `id` int NOT NULL AUTO_INCREMENT,
  `start_day` time NOT NULL,
  `end_day` time NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work_chedule`
--

LOCK TABLES `work_chedule` WRITE;
/*!40000 ALTER TABLE `work_chedule` DISABLE KEYS */;
INSERT INTO `work_chedule` VALUES (1,'10:00:00','18:00:00'),(2,'10:00:00','20:00:00'),(3,'10:00:00','15:00:00');
/*!40000 ALTER TABLE `work_chedule` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `work_chedule_AFTER_INSERT` AFTER INSERT ON `work_chedule` FOR EACH ROW BEGIN
INSERT INTO work_cheduletr Set 
date = now(),
query = 'insert',
start_day = NEW.start_day,
end_day = NEW.end_day;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `work_chedule_AFTER_UPDATE` AFTER UPDATE ON `work_chedule` FOR EACH ROW BEGIN
INSERT INTO work_cheduletr Set 
date = now(),
query = 'update',
start_day = OLD.start_day,
end_day = OLD.end_day;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `work_chedule_AFTER_DELETE` AFTER DELETE ON `work_chedule` FOR EACH ROW BEGIN
INSERT INTO work_cheduletr Set 
date = now(),
query = 'delete',
start_day = OLD.start_day,
end_day = OLD.end_day;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `work_cheduletr`
--

DROP TABLE IF EXISTS `work_cheduletr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `work_cheduletr` (
  `id` int NOT NULL AUTO_INCREMENT,
  `start_day` time NOT NULL,
  `end_day` time NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work_cheduletr`
--

LOCK TABLES `work_cheduletr` WRITE;
/*!40000 ALTER TABLE `work_cheduletr` DISABLE KEYS */;
/*!40000 ALTER TABLE `work_cheduletr` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-15 13:03:27
