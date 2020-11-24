-- MySQL dump 10.13  Distrib 5.7.21, for Win64 (x86_64)
--
-- Host: localhost    Database: db_pos
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account_archive`
--

DROP TABLE IF EXISTS `account_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account_archive` (
  `acc_archive_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `user_name` varchar(45) DEFAULT NULL,
  `user_pass` varchar(45) DEFAULT NULL,
  `user_control` varchar(45) DEFAULT NULL,
  `user_fullName` varchar(45) DEFAULT NULL,
  `user_contactNo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`acc_archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_archive`
--

LOCK TABLES `account_archive` WRITE;
/*!40000 ALTER TABLE `account_archive` DISABLE KEYS */;
INSERT INTO `account_archive` VALUES (1,10002,'user1','user1','user','Katigbak, Segunda M.','09005005004'),(3,10012,'cliff','cliffpogi','user','Curtis, Anne S.','09653254563');
/*!40000 ALTER TABLE `account_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `user_pass` varchar(45) NOT NULL,
  `user_control` varchar(45) NOT NULL,
  `user_fullName` varchar(45) DEFAULT NULL,
  `user_contactNo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`),
  UNIQUE KEY `user_name_UNIQUE` (`user_name`),
  UNIQUE KEY `user_pass_UNIQUE` (`user_pass`),
  UNIQUE KEY `user_contactNo_UNIQUE` (`user_contactNo`)
) ENGINE=InnoDB AUTO_INCREMENT=10017 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (10001,'admin','admin','admin','Marbella, Cliff M.','09560566331'),(10004,'bhoxz','34562','user','Marbella, Henry Chapman M.','09195483652'),(10007,'shshunter','fuckboy21','user','Dela Cruz, John Lherry P.','09123456789'),(10008,'ninja','shadow1','user','Namikaze, Naruto U.','09656565656'),(10010,'zackandrew','davepogi','admin','Mejares, Dave S.','09970673689'),(10011,'clnmndz','12345','admin','Mendoza, Carl N.','09212219924'),(10013,'naruto','hinata','user','Uzumaki, Boruto H.','09654215632'),(10014,'anelovecliff','cliffpogi','user','Curtis, Anne S.','09642587412'),(10016,'tests','56789','admin','Test, Admin L.','09444444444');
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `category_code` int(11) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`category_code`),
  UNIQUE KEY `category_name_UNIQUE` (`category_name`)
) ENGINE=InnoDB AUTO_INCREMENT=32186 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (32172,'Alcohol Products'),(32174,'Canned goods'),(32170,'Dairy Products'),(32169,'Hygiene Products'),(32175,'Instant foods'),(32184,'new'),(32177,'Poison'),(32176,'Processed Foods'),(32173,'Snacks'),(32171,'Softdrinks');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category_archive`
--

DROP TABLE IF EXISTS `category_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category_archive` (
  `c_archive_id` int(11) NOT NULL AUTO_INCREMENT,
  `category_code` int(11) DEFAULT NULL,
  `category_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`c_archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category_archive`
--

LOCK TABLES `category_archive` WRITE;
/*!40000 ALTER TABLE `category_archive` DISABLE KEYS */;
INSERT INTO `category_archive` VALUES (1,32178,'tesc'),(4,32181,'yyyyyy'),(8,32180,'wew'),(10,32182,'yxyxyxyx'),(12,32179,'new'),(14,32183,'wex'),(16,32184,'wut'),(18,32185,'tytytyty');
/*!40000 ALTER TABLE `category_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `bar_code` varchar(45) DEFAULT NULL,
  `category_code` int(11) DEFAULT NULL,
  `exp_date` date DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10272 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (10161,'4801032741048',32172,'2025-03-03'),(10162,'4801032741048',32172,'2025-03-03'),(10163,'4801032741048',32172,'2025-03-03'),(10179,'4807770273674',32175,'2021-03-01'),(10180,'4807770273674',32175,'2021-03-01'),(10181,'4807770273674',32175,'2021-03-01'),(10182,'4807770273674',32175,'2021-03-01'),(10183,'4807770273674',32175,'2021-03-01'),(10184,'4902430935654',32175,'2020-05-12'),(10185,'4902430935654',32175,'2020-05-12'),(10186,'4902430935654',32175,'2020-05-12'),(10187,'4902430935654',32175,'2020-05-12'),(10188,'4902430935654',32175,'2020-05-12'),(10189,'4800249032611',32174,'2025-03-03'),(10190,'4800249032611',32174,'2025-03-03'),(10191,'4800249032611',32174,'2025-03-03'),(10192,'4800249032611',32174,'2025-03-03'),(10193,'4800249032611',32174,'2025-03-03'),(10194,'0748485200019',32174,'2021-01-31'),(10195,'0748485200019',32174,'2021-01-31'),(10196,'0748485200019',32174,'2021-01-31'),(10197,'0748485200019',32174,'2021-01-31'),(10198,'0748485200019',32174,'2021-01-31'),(10199,'9556182023258',32170,'2022-02-09'),(10200,'9556182023258',32170,'2022-02-09'),(10201,'9556182023258',32170,'2022-02-09'),(10202,'9556182023258',32170,'2022-02-09'),(10203,'9556182023258',32170,'2022-02-09'),(10204,'8850006342909',32170,'2021-12-31'),(10205,'8850006342909',32170,'2021-12-31'),(10206,'8850006342909',32170,'2021-12-31'),(10207,'8850006342909',32170,'2021-12-31'),(10208,'8850006342909',32170,'2021-12-31'),(10209,'4800888157508',32169,'2023-05-05'),(10210,'4800888157508',32169,'2023-05-05'),(10211,'4800888157508',32169,'2023-05-05'),(10212,'4800888157508',32169,'2023-05-05'),(10213,'4800888157508',32169,'2023-05-05'),(10214,'4801032211077',32172,'2025-12-12'),(10215,'4801032211077',32172,'2025-12-12'),(10216,'4801032211077',32172,'2025-12-12'),(10217,'4801032211077',32172,'2025-12-12'),(10218,'4801032211077',32172,'2025-12-12'),(10219,'4800888208743',32176,'2021-02-05'),(10220,'4800888208743',32176,'2021-02-05'),(10221,'4800888208743',32176,'2021-02-05'),(10222,'4800888208743',32176,'2021-02-05'),(10223,'4800888208743',32176,'2021-02-05'),(10224,'0014285000945',32176,'2022-04-15'),(10225,'0014285000945',32176,'2022-04-15'),(10226,'0014285000945',32176,'2022-04-15'),(10227,'0014285000945',32176,'2022-04-15'),(10228,'0014285000945',32176,'2022-04-15'),(10229,'4800016644504',32173,'2021-02-02'),(10230,'4800016644504',32173,'2021-02-02'),(10231,'4800016644504',32173,'2021-02-02'),(10232,'4800016644504',32173,'2021-02-02'),(10233,'4800016644504',32173,'2021-02-02'),(10234,'4800194115063',32173,'2021-06-06'),(10235,'4800194115063',32173,'2021-06-06'),(10236,'4800194115063',32173,'2021-06-06'),(10237,'4800194115063',32173,'2021-06-06'),(10238,'4800194115063',32173,'2021-06-06'),(10239,'4801981116072',32171,'2022-06-11'),(10240,'4801981116072',32171,'2022-06-11'),(10241,'4801981116072',32171,'2022-06-11'),(10242,'4801981116072',32171,'2022-06-11'),(10243,'4801981116072',32171,'2022-06-11'),(10244,'4800417056906',32171,'2023-08-25'),(10245,'4800417056906',32171,'2023-08-25'),(10246,'4800417056906',32171,'2023-08-25'),(10247,'4800417056906',32171,'2023-08-25'),(10248,'4800417056906',32171,'2023-08-25'),(10249,'4800014144082',32175,'2022-12-21'),(10250,'4800014144082',32175,'2022-12-21'),(10251,'4800014144082',32175,'2022-12-21'),(10252,'4800014144082',32175,'2022-12-21'),(10253,'4800014144082',32175,'2022-12-21'),(10255,'4800888146830',32169,'2021-04-06'),(10260,'2222222222222',32184,'2018-12-12'),(10263,'1111111111111',32184,'2018-11-30'),(10264,'1111111111111',32184,'2018-11-30'),(10265,'1111111111111',32184,'2018-11-30'),(10266,'1111111111111',32184,'2021-01-01'),(10267,'4444444444444',32177,'2018-12-12'),(10268,'4444444444444',32177,'2018-12-12'),(10269,'4444444444444',32177,'2018-12-12'),(10270,'4444444444444',32177,'2018-12-12'),(10271,'4444444444444',32177,'2018-12-12');
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `name_archive`
--

DROP TABLE IF EXISTS `name_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `name_archive` (
  `n_archive_id` int(11) NOT NULL AUTO_INCREMENT,
  `name_id` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `middle_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`n_archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `name_archive`
--

LOCK TABLES `name_archive` WRITE;
/*!40000 ALTER TABLE `name_archive` DISABLE KEYS */;
INSERT INTO `name_archive` VALUES (1,2,10002,'Segunda','Salsalani','Katigbak'),(3,10,10012,'Anne','Smith','Curtis');
/*!40000 ALTER TABLE `name_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `names`
--

DROP TABLE IF EXISTS `names`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `names` (
  `name_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `middle_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`name_id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `names`
--

LOCK TABLES `names` WRITE;
/*!40000 ALTER TABLE `names` DISABLE KEYS */;
INSERT INTO `names` VALUES (1,10001,'Cliff','Marquez','Marbella'),(4,10004,'Henry Chapman','Marquez','Marbella'),(5,10007,'John Lherry','Pascual','Dela Cruz'),(6,10008,'Naruto','Uzumaki','Namikaze'),(8,10010,'Dave','Salonga','Mejares'),(9,10011,'Carl','Nario','Mendoza'),(11,10013,'Boruto','Hyuga','Uzumaki'),(12,10014,'Anne','Smith','Curtis'),(13,10015,'New','Test','AdminT'),(14,10016,'Admin','Lang','Test');
/*!40000 ALTER TABLE `names` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product` (
  `name_code` int(11) NOT NULL AUTO_INCREMENT,
  `bar_code` varchar(45) DEFAULT NULL,
  `category_code` int(11) NOT NULL,
  `product_name` varchar(45) DEFAULT NULL,
  `price` decimal(13,2) DEFAULT NULL,
  `stock` varchar(45) DEFAULT NULL,
  `quantity` varchar(45) DEFAULT NULL,
  `factory_price` decimal(13,2) DEFAULT NULL,
  `vat_exempted` varchar(5) DEFAULT NULL,
  `zero_rated` varchar(5) DEFAULT NULL,
  `pcs_per_item` int(11) DEFAULT NULL,
  PRIMARY KEY (`name_code`),
  UNIQUE KEY `product_name_UNIQUE` (`product_name`),
  UNIQUE KEY `bar_code_UNIQUE` (`bar_code`)
) ENGINE=InnoDB AUTO_INCREMENT=25442 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (25413,'4807770273674',32175,'Lucky Me Pancit Canton Original 50g',7.50,'4.62 items','277 pcs',6.50,'False','False',60),(25414,'4902430935654',32175,'Nissin Cup Noodles Shrimp 100g',18.00,'4.98 items','249 pcs',15.00,'False','False',50),(25415,'4800249032611',32174,'Argentina Corned Beef Original 150g',55.00,'4.94 items','247 pcs',50.00,'False','False',50),(25416,'0748485200019',32174,'555 Sardines Tomato original 150g',35.00,'4.80 items','240 pcs',30.00,'False','False',50),(25417,'9556182023258',32170,'Nestle Milk Original 1L',75.00,'4.76 items','238 pcs',60.00,'False','False',50),(25418,'8850006342909',32170,'Cheese whiz original 100g',85.00,'4.60 items','230 pcs',65.00,'False','False',50),(25419,'4800888157508',32169,'Clear Men Shampoo 100g',85.00,'4.62 items','231 pcs',65.00,'False','False',50),(25421,'4801032741048',32172,'San Miguel Pale Pilsen 500ml',43.00,'2.64 items','132 pcs',35.00,'False','False',50),(25422,'4801032211077',32172,'Red Horse Beer 500ml',48.00,'4.74 items','237 pcs',35.00,'False','False',50),(25423,'4800888208743',32176,'Tender Juicy hotdog 500g',130.00,'4.74 items','237 pcs',120.00,'False','False',50),(25424,'0014285000945',32176,'Purefoods Bacon 250g',130.00,'4.66 items','233 pcs',120.00,'False','False',50),(25425,'4800016644504',32173,'Jack n Jill Piattos Cheese 50g',27.00,'4.52 items','226 pcs',18.00,'False','False',50),(25426,'4800194115063',32173,'Oishi Patata 50g',13.00,'4.66 items','233 pcs',9.00,'False','False',50),(25427,'4801981116072',32171,'Coca Cola original 1L ',60.00,'4.70 items','235 pcs',50.00,'False','False',50),(25428,'4800417056906',32171,'Sprite Lemon 1L',60.00,'4.74 items','237 pcs',50.00,'False','False',50),(25429,'4800014144082',32175,'Knorr Instant Corn Soup 10g',15.00,'3.88 items','194 pcs',12.00,'False','False',50),(25430,'4800888146830',32169,'Sunsilk',6.00,'1.00 items','20 pcs',5.00,'False','False',20),(25437,'2222222222222',32184,'werq',3.00,'1 items','4 pcs',2.00,'False','False',4),(25440,'1111111111111',32184,'dfdfd',5.00,'4 items','24 pcs',4.00,'False','True',6),(25441,'4444444444444',32177,'weurewry',6.00,'5 items','35 pcs',5.00,'True','True',7);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_archive`
--

DROP TABLE IF EXISTS `product_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_archive` (
  `p_archive_id` int(11) NOT NULL AUTO_INCREMENT,
  `name_code` int(11) DEFAULT NULL,
  `bar_code` varchar(45) DEFAULT NULL,
  `category_code` int(11) DEFAULT NULL,
  `product_name` varchar(45) DEFAULT NULL,
  `price` decimal(13,2) DEFAULT NULL,
  `stock` varchar(45) DEFAULT NULL,
  `quantity` varchar(45) DEFAULT NULL,
  `factory_price` decimal(13,2) DEFAULT NULL,
  `vat_exempted` varchar(45) DEFAULT NULL,
  `zero_rated` varchar(45) DEFAULT NULL,
  `pcs_per_item` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_archive`
--

LOCK TABLES `product_archive` WRITE;
/*!40000 ALTER TABLE `product_archive` DISABLE KEYS */;
INSERT INTO `product_archive` VALUES (20,25449,'3333333333333',32177,'qerqwreqe',6.00,'4 items','28 pcs',6.00,'True','True',7),(22,25452,'6644335511335',32184,'tretq',5.00,'2 items','6 pcs',4.00,'False','True',3),(23,25431,'3333333333333',32183,' fdsg',4.00,'0 items','0 pcs',3.00,'True','True',5),(26,25435,'9999999999999',32172,'werty',6.00,'0 items','0 pcs',5.00,'True','True',7),(27,25436,'4545454545454',32183,'ertuer',4.00,'0 items','0 pcs',3.00,'True','True',5),(29,25439,'4444444444444',32185,'oiuouo',4.00,'0 items','0 pcs',3.00,'True','True',5);
/*!40000 ALTER TABLE `product_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_sold`
--

DROP TABLE IF EXISTS `product_sold`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_sold` (
  `sold_id` int(11) NOT NULL AUTO_INCREMENT,
  `transaction_id` int(11) DEFAULT NULL,
  `product_name` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `price` decimal(13,2) DEFAULT NULL,
  `discount` decimal(13,2) DEFAULT NULL,
  PRIMARY KEY (`sold_id`)
) ENGINE=InnoDB AUTO_INCREMENT=462 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_sold`
--

LOCK TABLES `product_sold` WRITE;
/*!40000 ALTER TABLE `product_sold` DISABLE KEYS */;
INSERT INTO `product_sold` VALUES (131,10001,'Red Horse Beer 500ml',1,48.00,0.00),(132,10002,'Lucky Me Pancit Canton Original 50g',2,15.00,0.00),(133,10002,'Sprite Lemon 1L',1,60.00,0.00),(134,10002,'Jack n Jill Piattos Cheese 50g',1,27.00,0.00),(135,10003,'Lucky Me Pancit Canton Original 50g',2,15.00,0.00),(136,10003,'Cheese whiz original 100g',1,76.50,0.10),(137,10003,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(138,10003,'Coca Cola original 1L ',1,51.00,0.15),(139,10004,'Lucky Me Pancit Canton Original 50g',3,22.50,0.00),(140,10004,'Sprite Lemon 1L',1,54.00,0.10),(141,10004,'Red Horse Beer 500ml',1,48.00,0.00),(145,10007,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(152,10014,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(156,10018,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(157,10019,'Lucky Me Pancit Canton Original 50g',2,15.00,0.00),(161,10020,'Coca Cola original 1L ',1,60.00,0.00),(163,10021,'Coca Cola original 1L ',1,60.00,0.00),(164,10021,'Sunsilk',5,30.00,0.00),(165,10022,'Sunsilk',5,27.00,0.10),(167,10022,'Sprite Lemon 1L',1,60.00,0.00),(168,10023,'Red Horse Beer 500ml',1,48.00,0.00),(170,10023,'Sprite Lemon 1L',1,60.00,0.00),(171,10024,'Red Horse Beer 500ml',1,48.00,0.00),(172,10024,'Jack n Jill Piattos Cheese 50g',5,121.50,0.10),(173,10024,'Sprite Lemon 1L',1,60.00,0.00),(174,10025,'Sunsilk',5,27.00,0.10),(175,10025,'Lucky Me Pancit Canton Original 50g',1,7.50,0.00),(176,10026,'Red Horse Beer 500ml',2,144.00,0.10),(177,10026,'Jack n Jill Piattos Cheese 50g',5,121.50,0.10),(178,10026,'Sprite Lemon 1L',2,120.00,0.00),(179,10026,'Sunsilk',2,30.00,0.00),(180,10026,'Cheese whiz original 100g',3,255.00,0.00),(181,10026,'Coca Cola original 1L ',2,120.00,0.00),(186,10030,'Lucky Me Pancit Canton Original 50g',5,31.88,0.10),(187,10031,'Sunsilk',2,27.00,0.10),(189,10031,'Jack n Jill Piattos Cheese 50g',3,81.00,0.00),(190,10031,'Coca Cola original 1L ',2,120.00,0.00),(191,10031,'Red Horse Beer 500ml',2,81.60,0.15),(192,10031,'Cheese whiz original 100g',3,216.75,0.15),(193,10031,'Sprite Lemon 1L',3,162.00,0.10),(194,10032,'Sunsilk',12,61.20,0.00),(195,10033,'Sunsilk',12,61.20,0.15),(196,10034,'Sunsilk',3,18.00,0.00),(197,10034,'Jack n Jill Piattos Cheese 50g',2,48.60,0.10),(198,10034,'Coca Cola original 1L ',2,102.00,0.15),(199,10034,'Red Horse Beer 500ml',3,122.40,0.15),(200,10034,'Cheese whiz original 100g',1,85.00,0.00),(201,10035,'Sunsilk',5,30.00,0.00),(202,10035,'Jack n Jill Piattos Cheese 50g',4,97.20,0.10),(203,10035,'Coca Cola original 1L ',3,153.00,0.15),(204,10035,'Red Horse Beer 500ml',2,81.60,0.15),(205,10035,'Lucky Me Pancit Canton Original 50g',4,30.00,0.00),(206,10036,'Cheese whiz original 100g',2,153.00,0.10),(207,10036,'Red Horse Beer 500ml',2,81.60,0.15),(208,10036,'Sprite Lemon 1L',2,102.00,0.15),(209,10036,'Sunsilk',5,30.00,0.00),(210,10037,'Cheese whiz original 100g',2,153.00,0.10),(211,10038,'Cheese whiz original 100g',1,85.00,0.00),(212,10040,'Red Horse Beer 500ml',1,43.20,0.10),(213,10042,'Purefoods Bacon 250g',2,234.00,0.10),(214,10042,'Cheese whiz original 100g',3,255.00,0.00),(215,10043,'Lucky Me Pancit Canton Original 50g',1,7.50,0.00),(221,10044,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(222,10044,'Cheese whiz original 100g',1,85.00,0.00),(223,10045,'Clear Men Shampoo 100g',1,76.50,0.10),(224,10046,'Clear Men Shampoo 100g',1,72.25,0.15),(225,10047,'Red Horse Beer 500ml',1,40.80,0.15),(226,10048,'Clear Men Shampoo 100g',1,85.00,0.00),(227,10048,'Purefoods Bacon 250g',1,117.00,0.10),(228,10049,'Jack n Jill Piattos Cheese 50g',4,97.20,0.10),(229,10051,'Red Horse Beer 500ml',2,96.00,0.00),(230,10051,'Sprite Lemon 1L',1,60.00,0.00),(231,10051,'Lucky Me Pancit Canton Original 50g',3,20.25,0.10),(233,10052,'Cheese whiz original 100g',1,85.00,0.00),(234,10052,'Red Horse Beer 500ml',1,48.00,0.00),(235,10053,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(236,10053,'Coca Cola original 1L ',1,54.00,0.10),(237,10053,'Sunsilk',5,30.00,0.00),(238,10054,'Lucky Me Pancit Canton Original 50g',3,22.50,0.00),(239,10055,'Purefoods Bacon 250g',1,130.00,0.00),(240,10055,'Cheese whiz original 100g',1,85.00,0.00),(241,10055,'Sprite Lemon 1L',1,60.00,0.00),(243,10056,'Red Horse Beer 500ml',3,122.40,0.15),(244,10057,'Coca Cola original 1L ',1,60.00,0.00),(245,10057,'Sprite Lemon 1L',2,102.00,0.15),(246,10058,'Sunsilk',5,27.00,0.10),(247,10058,'Jack n Jill Piattos Cheese 50g',2,48.60,0.10),(248,10058,'Coca Cola original 1L ',1,60.00,0.00),(249,10059,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(250,10059,'555 Sardines Tomato original 150g',3,105.00,0.00),(251,10059,'Knorr Instant Corn Soup 10g',3,45.00,0.00),(252,10060,'Knorr Instant Corn Soup 10g',2,27.00,0.10),(253,10060,'Cheese whiz original 100g',6,510.00,0.00),(254,10060,'Sprite Lemon 1L',1,60.00,0.00),(255,10061,'Sunsilk',2,12.00,0.00),(256,10061,'Nestle Milk Original 1L',2,150.00,0.00),(257,10062,'Cheese whiz original 100g',5,425.00,0.00),(258,10063,'Red Horse Beer 500ml',2,96.00,0.00),(259,10065,'Clear Men Shampoo 100g',2,170.00,0.00),(260,10066,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(262,10067,'555 Sardines Tomato original 150g',2,63.00,0.10),(263,10067,'Cheese whiz original 100g',1,85.00,0.00),(264,10068,'Nestle Milk Original 1L',1,67.50,0.10),(265,10068,'Tender Juicy hotdog 500g',2,260.00,0.00),(266,10069,'Lucky Me Pancit Canton Original 50g',5,33.75,0.10),(267,10069,'Red Horse Beer 500ml',2,96.00,0.00),(268,10070,'Cheese whiz original 100g',5,425.00,0.00),(272,10071,'555 Sardines Tomato original 150g',2,63.00,0.10),(273,10071,'Sprite Lemon 1L',1,54.00,0.10),(274,10071,'Sunsilk',5,30.00,0.00),(275,10072,'Nissin Cup Noodles Shrimp 100g',2,32.40,0.10),(276,10072,'Purefoods Bacon 250g',1,130.00,0.00),(277,10073,'Tender Juicy hotdog 500g',3,390.00,0.00),(278,10073,'Sprite Lemon 1L',1,51.00,0.15),(279,10074,'Cheese whiz original 100g',5,382.50,0.10),(280,10074,'Sunsilk',10,60.00,0.00),(281,10075,'Red Horse Beer 500ml',2,96.00,0.00),(282,10076,'Purefoods Bacon 250g',1,117.00,0.10),(283,10076,'Tender Juicy hotdog 500g',2,260.00,0.00),(284,10077,'Oishi Patata 50g',5,65.00,0.00),(285,10077,'Sprite Lemon 1L',2,120.00,0.00),(290,10080,'Lucky Me Pancit Canton Original 50g',3,20.25,0.10),(294,10081,'Sprite Lemon 1L',2,120.00,0.00),(295,10082,'San Miguel Pale Pilsen 500ml',1,43.00,0.00),(296,10083,'Clear Men Shampoo 100g',1,85.00,0.00),(297,10084,'Lucky Me Pancit Canton Original 50g',3,22.50,0.00),(298,10085,'Clear Men Shampoo 100g',5,425.00,0.00),(300,10086,'Sunsilk',1,6.00,0.00),(302,10087,'Clear Men Shampoo 100g',2,170.00,0.00),(303,10088,'San Miguel Pale Pilsen 500ml',2,86.00,0.00),(304,10089,'Clear Men Shampoo 100g',3,255.00,0.00),(309,10090,'555 Sardines Tomato original 150g',5,157.50,0.10),(310,10090,'San Miguel Pale Pilsen 500ml',2,86.00,0.00),(311,10090,'Coca Cola original 1L ',1,60.00,0.00),(312,10091,'Nestle Milk Original 1L',1,75.00,0.00),(313,10091,'Clear Men Shampoo 100g',1,76.50,0.10),(314,10091,'Sprite Lemon 1L',2,108.00,0.10),(315,10092,'Coca Cola original 1L ',2,120.00,0.00),(316,10092,'Lucky Me Pancit Canton Original 50g',2,15.00,0.00),(319,10093,'Coca Cola original 1L ',3,180.00,0.00),(320,10093,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(322,10094,'Sunsilk',4,24.00,0.00),(323,10095,'Tender Juicy hotdog 500g',1,130.00,0.00),(324,10096,'Purefoods Bacon 250g',1,117.00,0.10),(325,10096,'Sprite Lemon 1L',1,54.00,0.10),(329,10097,'Tender Juicy hotdog 500g',1,117.00,0.10),(330,10097,'Nestle Milk Original 1L',1,67.50,0.10),(331,10097,'Oishi Patata 50g',5,58.50,0.10),(332,10098,'Cheese whiz original 100g',2,170.00,0.00),(333,10098,'Jack n Jill Piattos Cheese 50g',3,81.00,0.00),(334,10098,'San Miguel Pale Pilsen 500ml',2,77.40,0.10),(335,10099,'Coca Cola original 1L ',2,120.00,0.00),(336,10100,'Argentina Corned Beef Original 150g',2,110.00,0.00),(337,10100,'Cheese whiz original 100g',1,76.50,0.10),(338,10100,'Tender Juicy hotdog 500g',1,117.00,0.10),(339,10100,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(340,10101,'Red Horse Beer 500ml',2,81.60,0.15),(341,10101,'Jack n Jill Piattos Cheese 50g',4,108.00,0.00),(342,10102,'San Miguel Pale Pilsen 500ml',1,43.00,0.00),(343,10102,'Nestle Milk Original 1L',2,135.00,0.10),(344,10103,'Tender Juicy hotdog 500g',2,260.00,0.00),(345,10103,'Oishi Patata 50g',3,39.00,0.00),(346,10103,'Coca Cola original 1L ',1,54.00,0.10),(347,10104,'Sunsilk',5,30.00,0.00),(348,10104,'Oishi Patata 50g',2,26.00,0.00),(349,10105,'Lucky Me Pancit Canton Original 50g',2,13.50,0.10),(350,10105,'Red Horse Beer 500ml',1,48.00,0.00),(351,10106,'Coca Cola original 1L ',2,120.00,0.00),(352,10107,'Red Horse Beer 500ml',3,129.60,0.10),(353,10107,'Coca Cola original 1L ',2,120.00,0.00),(354,10107,'Jack n Jill Piattos Cheese 50g',5,121.50,0.10),(355,10108,'Red Horse Beer 500ml',1,40.80,0.15),(356,10108,'Cheese whiz original 100g',1,85.00,0.00),(357,10108,'Argentina Corned Beef Original 150g',1,55.00,0.00),(358,10108,'Jack n Jill Piattos Cheese 50g',1,27.00,0.00),(359,10108,'Sprite Lemon 1L',1,60.00,0.00),(360,10108,'Knorr Instant Corn Soup 10g',1,15.00,0.00),(361,10109,'Cheese whiz original 100g',1,76.50,0.10),(362,10109,'Purefoods Bacon 250g',1,117.00,0.10),(363,10109,'Sprite Lemon 1L',1,54.00,0.10),(364,10109,'Sunsilk',1,5.40,0.10),(365,10109,'San Miguel Pale Pilsen 500ml',1,38.70,0.10),(366,10109,'Oishi Patata 50g',1,11.70,0.10),(369,10110,'Nestle Milk Original 1L',2,150.00,0.00),(372,10111,'Cheese whiz original 100g',1,85.00,0.00),(373,10111,'Tender Juicy hotdog 500g',1,130.00,0.00),(374,10111,'San Miguel Pale Pilsen 500ml',1,43.00,0.00),(375,10112,'Purefoods Bacon 250g',2,260.00,0.00),(376,10112,'Knorr Instant Corn Soup 10g',1,15.00,0.00),(377,10112,'Oishi Patata 50g',1,13.00,0.00),(378,10113,'Red Horse Beer 500ml',1,48.00,0.00),(379,10113,'Coca Cola original 1L ',1,60.00,0.00),(380,10113,'Sunsilk',1,6.00,0.00),(381,10114,'Clear Men Shampoo 100g',1,85.00,0.00),(382,10114,'Purefoods Bacon 250g',1,130.00,0.00),(383,10114,'Knorr Instant Corn Soup 10g',1,15.00,0.00),(384,10115,'Lucky Me Pancit Canton Original 50g',1,7.50,0.00),(385,10115,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(386,10115,'Purefoods Bacon 250g',1,130.00,0.00),(387,10115,'555 Sardines Tomato original 150g',1,35.00,0.00),(388,10116,'555 Sardines Tomato original 150g',1,35.00,0.00),(389,10116,'Red Horse Beer 500ml',1,48.00,0.00),(390,10117,'Cheese whiz original 100g',2,170.00,0.00),(391,10117,'San Miguel Pale Pilsen 500ml',1,43.00,0.00),(392,10117,'Tender Juicy hotdog 500g',1,130.00,0.00),(393,10117,'Jack n Jill Piattos Cheese 50g',3,81.00,0.00),(394,10118,'Nestle Milk Original 1L',1,75.00,0.00),(395,10118,'Tender Juicy hotdog 500g',1,130.00,0.00),(396,10119,'Clear Men Shampoo 100g',1,85.00,0.00),(397,10119,'Tender Juicy hotdog 500g',1,130.00,0.00),(398,10119,'Cheese whiz original 100g',1,85.00,0.00),(399,10119,'Nissin Cup Noodles Shrimp 100g',1,18.00,0.00),(400,10120,'Cheese whiz original 100g',1,85.00,0.00),(401,10120,'Purefoods Bacon 250g',1,130.00,0.00),(402,10120,'Knorr Instant Corn Soup 10g',1,15.00,0.00),(403,10120,'Sunsilk',1,6.00,0.00),(404,10121,'San Miguel Pale Pilsen 500ml',1,43.00,0.00),(405,10121,'Purefoods Bacon 250g',1,130.00,0.00),(406,10122,'Cheese whiz original 100g',1,85.00,0.00),(407,10122,'Purefoods Bacon 250g',1,130.00,0.00),(408,10122,'Sunsilk',1,6.00,0.00),(409,10122,'Coca Cola original 1L ',1,60.00,0.00),(410,10123,'Clear Men Shampoo 100g',2,170.00,0.00),(411,10123,'Tender Juicy hotdog 500g',1,130.00,0.00),(412,10123,'Jack n Jill Piattos Cheese 50g',1,27.00,0.00),(413,10123,'Sprite Lemon 1L',1,60.00,0.00),(414,10123,'Oishi Patata 50g',1,13.00,0.00),(415,10123,'555 Sardines Tomato original 150g',1,35.00,0.00),(416,10124,'Cheese whiz original 100g',2,153.00,0.10),(417,10125,'Sprite Lemon 1L',3,180.00,0.00),(418,10125,'Purefoods Bacon 250g',5,650.00,0.00),(419,10126,'Knorr Instant Corn Soup 10g',47,564.00,0.20),(421,10127,'Sunsilk',6,36.00,0.00),(422,10128,'Sunsilk',20,120.00,0.00),(434,10129,'Sunsilk',20,120.00,0.00),(435,10130,'Purefoods Bacon 250g',1,117.00,0.10),(436,10130,'San Miguel Pale Pilsen 500ml',1,38.70,0.10),(437,10130,'Cheese whiz original 100g',2,170.00,0.00),(438,10130,'Knorr Instant Corn Soup 10g',2,30.00,0.00),(439,10130,'Jack n Jill Piattos Cheese 50g',1,27.00,0.00),(440,10130,'Red Horse Beer 500ml',1,48.00,0.00),(441,10131,'Lucky Me Pancit Canton Original 50g',2,15.00,0.00),(442,10132,'Lucky Me Pancit Canton Original 50g',4,30.00,0.00),(443,10132,'Knorr Instant Corn Soup 10g',1,15.00,0.00),(444,10132,'Cheese whiz original 100g',1,85.00,0.00),(445,10132,'Nestle Milk Original 1L',2,135.00,0.10),(446,10133,'Lucky Me Pancit Canton Original 50g',2,12.75,0.15),(447,10133,'Red Horse Beer 500ml',1,48.00,0.00),(448,10133,'Jack n Jill Piattos Cheese 50g',2,54.00,0.00),(449,10133,'Sprite Lemon 1L',1,60.00,0.00),(450,10134,'Nestle Milk Original 1L',2,150.00,0.00),(451,10134,'Clear Men Shampoo 100g',1,76.50,0.10),(452,10134,'Tender Juicy hotdog 500g',1,117.00,0.10),(453,10135,'Cheese whiz original 100g',2,153.00,0.10),(454,10135,'Clear Men Shampoo 100g',1,76.50,0.10),(455,10135,'Tender Juicy hotdog 500g',2,234.00,0.10),(457,10136,'Nestle Milk Original 1L',1,75.00,0.00),(458,10136,'Clear Men Shampoo 100g',1,85.00,0.00),(459,10136,'Knorr Instant Corn Soup 10g',2,30.00,0.00),(460,10136,'Oishi Patata 50g',4,52.00,0.00),(461,10136,'Purefoods Bacon 250g',1,130.00,0.00);
/*!40000 ALTER TABLE `product_sold` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction` (
  `transaction_id` int(11) NOT NULL AUTO_INCREMENT,
  `transaction_datetime` datetime DEFAULT NULL,
  `invoice_no` varchar(45) DEFAULT NULL,
  `transaction_profit` decimal(13,2) DEFAULT NULL,
  `cost_due` decimal(13,2) DEFAULT NULL,
  `quantity_sold` int(11) DEFAULT NULL,
  `discount` decimal(13,2) DEFAULT NULL,
  `discounted_sales` int(11) DEFAULT NULL,
  `cash` decimal(13,2) DEFAULT NULL,
  PRIMARY KEY (`transaction_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10137 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (10002,'2018-10-27 22:26:36','NV 10002',28.00,102.00,4,0.00,0,105.00),(10003,'2018-10-28 08:26:44','NV 10003',56.50,196.50,6,17.50,2,200.00),(10004,'2018-10-28 08:33:46','NV 10004',32.50,124.50,5,6.00,1,150.00),(10020,'2018-10-28 16:17:22','NV 10020',10.00,60.00,1,0.00,0,70.00),(10021,'2018-10-28 16:30:59','NV 10021',35.00,90.00,6,0.00,0,90.00),(10022,'2018-10-28 16:37:25','NV 10022',32.00,87.00,6,3.00,1,90.00),(10023,'2018-10-28 16:57:21','NV 10023',23.00,108.00,2,0.00,0,120.00),(10024,'2018-10-28 17:00:34','NV 10024',126.50,229.50,7,13.50,1,250.00),(10025,'2018-10-28 17:29:26','NV 10025',22.50,34.50,6,3.00,1,50.00),(10026,'2018-10-28 21:35:41','NV 10026',567.50,790.50,16,29.50,2,800.00),(10030,'2018-10-28 22:47:20','NV 10030',25.88,31.88,5,3.54,1,50.00),(10032,'2018-10-28 22:55:15','NV 10032',56.20,61.20,12,0.00,0,70.00),(10033,'2018-10-28 23:05:43','NV 10033',56.20,61.20,12,10.80,1,70.00),(10034,'2018-10-28 23:10:36','NV 10034',203.00,376.00,11,45.00,3,400.00),(10035,'2018-10-28 23:25:11','NV 10035',277.80,391.80,18,52.20,3,400.00),(10036,'2018-10-29 00:26:12','NV 10036',211.60,366.60,11,49.40,3,400.00),(10038,'2018-10-29 01:05:05','NV 10038',20.00,85.00,1,0.00,0,90.00),(10040,'2018-10-29 01:20:40','NV 10040',8.20,43.20,1,4.80,1,50.00),(10042,'2018-10-29 02:24:16','NV 10042',304.00,489.00,5,26.00,1,500.00),(10044,'2018-10-29 03:51:04','NV 10044',26.50,98.50,3,1.50,1,200.00),(10045,'2018-10-29 03:56:24','NV 10045',11.50,76.50,1,8.50,1,80.00),(10046,'2018-10-29 04:00:39','NV 10046',7.25,72.25,1,12.75,1,80.00),(10047,'2018-10-29 04:07:29','NV 10047',5.80,40.80,1,7.20,1,50.00),(10048,'2018-10-29 04:13:27','NV 10048',17.00,202.00,2,13.00,1,205.00),(10049,'2018-10-29 10:26:07','NV 10049',79.20,97.20,4,10.80,1,100.00),(10051,'2018-10-30 14:13:19','NV 10051',84.25,176.25,6,2.25,1,200.00),(10052,'2018-10-30 20:38:54','NV 10052',33.00,133.00,2,0.00,0,150.00),(10053,'2018-10-31 11:25:35','NV 10053',65.00,138.00,8,6.00,1,140.00),(10054,'2018-10-31 11:26:47','NV 10054',16.50,22.50,3,0.00,0,25.00),(10055,'2018-10-31 11:56:34','NV 10055',40.00,275.00,3,0.00,0,300.00),(10056,'2018-10-31 12:02:58','NV 10056',87.40,122.40,3,21.60,1,130.00),(10057,'2018-10-31 12:03:52','NV 10057',62.00,162.00,3,18.00,1,200.00),(10058,'2018-10-31 12:15:16','NV 10058',62.60,135.60,8,8.40,2,150.00),(10059,'2018-10-31 12:46:37','NV 10059',144.00,204.00,8,0.00,0,205.00),(10060,'2018-10-31 14:15:51','NV 10060',470.00,597.00,9,3.00,1,600.00),(10061,'2018-10-31 14:57:29','NV 10061',97.00,162.00,4,0.00,0,200.00),(10062,'2018-10-31 15:20:36','NV 10062',360.00,425.00,5,0.00,0,500.00),(10063,'2018-10-31 15:28:44','NV 10063',61.00,96.00,2,0.00,0,100.00),(10065,'2018-10-31 16:09:48','NV 10065',105.00,170.00,2,0.00,0,200.00),(10066,'2018-10-31 16:28:38','NV 10066',36.00,54.00,2,0.00,0,60.00),(10067,'2018-10-31 16:31:25','NV 10067',53.00,148.00,3,7.00,1,150.00),(10068,'2018-10-31 17:26:35','NV 10068',147.50,327.50,3,7.50,1,350.00),(10069,'2018-10-31 21:36:34','NV 10069',87.75,129.75,7,3.75,1,150.00),(10070,'2018-11-01 00:01:52','NV 10070',360.00,425.00,5,0.00,0,500.00),(10071,'2018-11-01 00:34:05','NV 10071',62.00,147.00,8,13.00,2,150.00),(10072,'2018-11-01 01:14:17','NV 10072',27.40,162.40,3,3.60,1,200.00),(10073,'2018-11-01 10:53:00','NV 10073',271.00,441.00,4,9.00,1,500.00),(10074,'2018-11-01 11:26:21','NV 10074',372.50,442.50,15,42.50,1,500.00),(10075,'2018-11-01 15:28:20','NV 10075',61.00,96.00,2,0.00,0,100.00),(10076,'2018-11-01 16:47:09','NV 10076',137.00,377.00,3,13.00,1,400.00),(10077,'2018-11-01 23:00:00','NV 10077',126.00,185.00,7,0.00,0,200.00),(10079,'2018-11-02 11:59:15','NV 10079',9.00,15.00,2,0.00,0,20.00),(10080,'2018-11-02 14:37:13','NV 10080',14.25,20.25,3,2.25,1,25.00),(10081,'2018-11-02 14:50:16','NV 10081',70.00,120.00,2,0.00,0,130.00),(10082,'2018-11-02 14:58:08','NV 10082',8.00,43.00,1,0.00,0,50.00),(10083,'2018-11-02 15:15:42','NV 10083',20.00,85.00,1,0.00,0,100.00),(10084,'2018-11-02 15:33:57','NV 10084',16.50,22.50,3,0.00,0,25.00),(10085,'2018-11-02 16:23:20','NV 10085',360.00,425.00,5,0.00,0,450.00),(10086,'2018-11-02 16:32:54','NV 10086',1.00,6.00,1,0.00,0,10.00),(10087,'2018-11-02 16:44:34','NV 10087',105.00,170.00,2,0.00,0,200.00),(10088,'2018-11-02 16:47:34','NV 10088',51.00,86.00,2,0.00,0,100.00),(10089,'2018-11-02 16:56:42','NV 10089',190.00,255.00,3,0.00,0,300.00),(10090,'2018-11-02 16:59:08','NV 10090',188.50,303.50,8,17.50,1,350.00),(10091,'2018-11-02 17:01:21','NV 10091',84.50,259.50,4,20.50,2,300.00),(10092,'2018-11-02 17:03:32','NV 10092',79.00,135.00,4,0.00,0,150.00),(10093,'2018-11-02 20:32:34','NV 10093',166.00,234.00,5,0.00,0,250.00),(10094,'2018-11-02 21:07:33','NV 10094',19.00,24.00,4,0.00,0,100.00),(10095,'2018-11-02 21:11:19','NV 10095',10.00,130.00,1,0.00,0,200.00),(10096,'2018-11-02 21:52:40','NV 10096',1.00,171.00,2,19.00,2,200.00),(10097,'2018-11-02 22:51:26','NV 10097',54.00,243.00,7,27.00,3,300.00),(10098,'2018-11-02 23:01:29','NV 10098',210.40,328.40,7,8.60,1,400.00),(10099,'2018-11-02 23:19:41','NV 10099',70.00,120.00,2,0.00,0,150.00),(10100,'2018-11-03 07:46:31','NV 10100',75.00,317.00,6,23.00,3,400.00),(10101,'2018-11-03 07:50:08','NV 10101',136.60,189.60,6,14.40,1,200.00),(10102,'2018-11-03 09:44:00','NV 10102',83.00,178.00,3,15.00,1,200.00),(10103,'2018-11-03 13:59:33','NV 10103',174.00,353.00,6,6.00,1,400.00),(10104,'2018-11-03 14:03:14','NV 10104',42.00,56.00,7,0.00,0,60.00),(10105,'2018-11-03 14:42:53','NV 10105',19.50,61.50,3,1.50,1,70.00),(10106,'2018-11-03 21:39:06','NV 10106',70.00,120.00,2,0.00,0,150.00),(10107,'2018-11-03 23:56:07','NV 10107',268.10,371.10,10,27.90,2,500.00),(10108,'2018-11-04 00:24:03','NV 10108',52.80,282.80,6,7.20,1,300.00),(10109,'2018-11-04 00:29:51','NV 10109',19.30,303.30,6,33.70,6,400.00),(10110,'2018-11-04 01:10:11','NV 10110',90.00,150.00,2,0.00,0,200.00),(10111,'2018-11-04 01:37:35','NV 10111',38.00,258.00,3,0.00,0,260.00),(10112,'2018-11-04 01:45:18','NV 10112',147.00,288.00,4,0.00,0,300.00),(10113,'2018-11-04 01:47:46','NV 10113',24.00,114.00,3,0.00,0,120.00),(10114,'2018-11-04 01:50:53','NV 10114',33.00,230.00,3,0.00,0,250.00),(10115,'2018-11-04 01:54:23','NV 10115',52.50,226.50,5,0.00,0,300.00),(10116,'2018-11-04 01:57:21','NV 10116',18.00,83.00,2,0.00,0,100.00),(10117,'2018-11-04 01:59:16','NV 10117',186.00,424.00,7,0.00,0,500.00),(10118,'2018-11-04 02:13:00','NV 10118',25.00,205.00,2,0.00,0,210.00),(10119,'2018-11-04 02:16:27','NV 10119',53.00,318.00,4,0.00,0,320.00),(10120,'2018-11-04 02:19:42','NV 10120',34.00,236.00,4,0.00,0,250.00),(10121,'2018-11-04 02:35:57','NV 10121',18.00,173.00,2,0.00,0,200.00),(10122,'2018-11-04 02:38:07','NV 10122',41.00,281.00,4,0.00,0,300.00),(10123,'2018-11-04 02:41:49','NV 10123',143.00,435.00,7,0.00,0,500.00),(10124,'2018-11-04 12:19:47','NV 10124',88.00,153.00,2,17.00,1,200.00),(10125,'2018-11-04 14:39:50','NV 10125',660.00,830.00,8,0.00,0,1000.00),(10126,'2018-11-04 14:43:54','NV 10126',552.00,564.00,47,141.00,1,600.00),(10127,'2018-11-04 15:48:46','NV 10127',31.00,36.00,6,0.00,0,50.00),(10128,'2018-11-04 16:00:22','NV 10128',115.00,120.00,20,0.00,0,150.00),(10129,'2018-11-04 16:50:45','NV 10129',115.00,120.00,20,0.00,0,150.00),(10130,'2018-11-04 23:36:05','NV 10130',145.70,430.70,8,17.30,2,500.00),(10131,'2018-11-04 23:45:08','NV 10131',9.00,15.00,2,0.00,0,20.00),(10132,'2018-11-05 05:06:55','NV 10132',121.00,265.00,8,15.00,1,300.00),(10133,'2018-11-05 05:43:48','NV 10133',64.75,174.75,6,2.25,1,200.00),(10134,'2018-11-05 06:00:59','NV 10134',98.50,343.50,4,21.50,2,350.00),(10135,'2018-11-05 09:19:28','NV 10135',213.50,463.50,5,51.50,3,500.00),(10136,'2018-11-05 09:35:21','NV 10136',106.00,372.00,9,0.00,0,400.00);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-05 10:56:05
