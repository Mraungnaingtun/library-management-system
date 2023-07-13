-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: library
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `project_old`
--

DROP TABLE IF EXISTS `project_old`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `project_old` (
  `PQ_ID` int(11) NOT NULL,
  `Type` varchar(50) DEFAULT NULL,
  `Semester` varchar(50) DEFAULT NULL,
  `Academic_Year` int(11) DEFAULT NULL,
  `Copies` int(11) DEFAULT NULL,
  `Description` longtext,
  `Subject_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`PQ_ID`),
  KEY `Subject_ID_idx1` (`Subject_ID`),
  CONSTRAINT `Subject_ID` FOREIGN KEY (`Subject_ID`) REFERENCES `allsubject` (`Subject_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `project_old`
--

LOCK TABLES `project_old` WRITE;
/*!40000 ALTER TABLE `project_old` DISABLE KEYS */;
INSERT INTO `project_old` VALUES (1,'Old Question','first',2019,10,NULL,1),(2,'Old Question','first',2019,9,NULL,2),(3,'Old Question','first',2019,10,NULL,3),(4,'Old Question','first',2019,10,NULL,4),(5,'Old Question','first',2019,10,NULL,5),(6,'Old Question','first',2019,10,NULL,6),(7,'Old Question','first',2019,10,'Unknown',7),(8,'Old Question','first',2019,10,NULL,8),(9,'Old Question','first',2019,10,NULL,9),(10,'Old Question','first',2018,10,NULL,10),(11,'Old Question','first',2018,10,NULL,11),(12,'Old Question','first',2018,10,NULL,12),(13,'Old Question','first',2018,6,NULL,13),(14,'Old Question','first',2018,10,NULL,14),(15,'Old Question','first',2018,10,NULL,15),(16,'Old Question','first',2018,10,NULL,16),(17,'Old Question','first',2018,10,NULL,17),(18,'Old Question','first',2018,10,NULL,18),(19,'Old Question','first',2018,10,NULL,19),(20,'Old Question','first',2018,9,NULL,20),(21,'Old Question','first',2018,10,NULL,21),(22,'Old Question','first',2018,10,NULL,22),(23,'Old Question','first',2018,10,NULL,23),(24,'Old Question','first',2018,10,NULL,24),(25,'Old Question','first',2019,10,NULL,25),(26,'Old Question','first',2019,10,NULL,26),(27,'Old Question','first',2019,10,NULL,27),(28,'Old Question','first',2019,10,NULL,28),(29,'Old Question','first',2019,10,NULL,29),(30,'Old Question','first',2019,10,NULL,30),(31,'Old Question','first',2019,10,NULL,31),(32,'Old Question','first',2019,10,NULL,32),(33,'Old Question','first',2019,10,NULL,33),(34,'Old Question','first',2019,10,NULL,34),(35,'Old Question','first',2019,10,NULL,35),(36,'Old Question','first',2019,10,NULL,36),(37,'Old Question','first',2019,10,NULL,37),(38,'Old Question','first',2019,10,NULL,38),(39,'Old Question','first',2019,10,NULL,39),(40,'Old Question','first',2019,10,NULL,40),(41,'Old Question','first',2019,10,NULL,41),(42,'Old Question','first',2019,10,NULL,42),(43,'Old Question','first',2019,10,NULL,43),(44,'Old Question','first',2019,10,NULL,44),(45,'Old Question','first',2019,10,NULL,45),(46,'Old Question','first',2019,10,NULL,46),(47,'Old Question','first',2019,10,NULL,47),(48,'Old Question','first',2019,10,NULL,48),(49,'Old Question','first',2019,10,NULL,49),(50,'Old Question','first',2019,10,NULL,50),(51,'Old Question','first',2019,10,NULL,51),(52,'Old Question','first',2019,10,NULL,52),(53,'Old Question','first',2019,10,NULL,53),(54,'Old Question','first',2019,10,NULL,54),(55,'Old Question','first',2019,10,NULL,55),(56,'Old Question','first',2019,10,NULL,56),(57,'Old Question','first',2019,10,NULL,57),(58,'Old Question','first',2019,10,NULL,58),(59,'Old Question','second',2018,10,NULL,59),(60,'Old Question','first',2018,10,NULL,60),(61,'Old Question','second',2018,10,NULL,61),(62,'Old Question','first',2018,10,NULL,62),(63,'Old Question','second',2018,10,NULL,63),(64,'Old Question','first',2018,10,NULL,64),(65,'Old Question','first',2018,10,NULL,65),(66,'Old Question','first',2018,10,NULL,66),(67,'Old Question','first',2018,10,NULL,67),(68,'Old Question','second',2018,10,NULL,68),(69,'Old Question','second',2018,10,NULL,69),(70,'Old Question','first',2018,10,NULL,70),(71,'Old Question','first',2018,10,NULL,71),(72,'Old Question','first',2018,10,NULL,72),(73,'Old Question','first',2018,10,NULL,73),(74,'Old Question','first',2018,10,NULL,74),(75,'Old Question','first',2018,10,NULL,75),(76,'Old Question','first',2018,10,NULL,76),(77,'Old Question','first',2018,10,NULL,77),(78,'Old Question','first',2018,10,NULL,78),(79,'Old Question','first',2018,10,NULL,79),(80,'Old Question','first',2018,10,NULL,80),(81,'Old Question','first',2018,10,NULL,81),(82,'Old Question','first',2018,10,NULL,82),(83,'Old Question','second',2019,10,NULL,83),(84,'Old Question','first',2019,10,NULL,84),(85,'Old Question','first',2019,10,NULL,85),(86,'Old Question','first',2019,10,NULL,86),(87,'Old Question','first',2019,10,NULL,87),(88,'Old Question','second',2018,10,NULL,88),(89,'Old Question','second',2018,10,NULL,89),(90,'Old Question','second',2018,10,NULL,90),(91,'Old Question','second',2018,10,NULL,91),(92,'Old Question','first',2018,10,NULL,92),(93,'Old Question','second',2018,10,NULL,93),(94,'Old Question','second',2018,10,NULL,94),(95,'Old Question','second',2018,10,NULL,95),(96,'Old Question','second',2018,10,NULL,96),(97,'Old Question','second',2018,10,NULL,97),(98,'Old Question','second',2018,10,NULL,98),(99,'Old Question','second',2018,10,NULL,99),(100,'Old Question','second',2018,10,NULL,100),(101,'Old Question','second',2018,10,NULL,101),(102,'Old Question','first',2018,10,NULL,102),(103,'Old Question','second',2018,10,NULL,103),(104,'Old Question','second',2018,10,NULL,104),(105,'Old Question','second',2018,10,NULL,105),(106,'Old Question','first',2018,10,NULL,106),(107,'Old Question','first',2018,10,NULL,107),(108,'Old Question','first',2018,10,NULL,108),(109,'Old Question','first',2018,10,NULL,109),(110,'Old Question','first',2018,10,NULL,110),(111,'Old Question','first',2018,10,NULL,111),(112,'Old Question','first',2018,10,NULL,112),(113,'Old Question','first',2018,10,NULL,113),(114,'Old Question','first',2018,10,NULL,114),(115,'Old Question','first',2018,10,NULL,115),(116,'Old Question','first',2018,10,NULL,116),(117,'Old Question','first',2018,10,NULL,117),(118,'Old Question','first',2018,10,NULL,118),(119,'Old Question','first',2018,10,NULL,119),(120,'Old Question','second',2018,10,NULL,120),(121,'Old Question','first',2018,10,NULL,121),(122,'Old Question','first',2018,10,NULL,122),(123,'Old Question','first',2018,10,NULL,123),(124,'Old Question','first',2018,10,NULL,124),(125,'Old Question','first',2018,10,NULL,125),(126,'Old Question','first',2018,10,NULL,126),(127,'Old Question','first',2018,10,NULL,127),(128,'Old Question','first',2018,10,NULL,128),(129,'Old Question','second',2018,10,NULL,129),(130,'Old Question','second',2018,10,NULL,130),(131,'Old Question','second',2018,10,NULL,131),(132,'Old Question','second',2018,10,NULL,132),(133,'Old Question','second',2018,10,NULL,133),(134,'Old Question','second',2018,10,NULL,134),(135,'Old Question','second',2018,10,NULL,135),(136,'Old Question','second',2018,10,NULL,136),(137,'Old Question','second',2018,10,NULL,137),(138,'Old Question','second',2018,10,NULL,138),(139,'Old Question','second',2018,10,NULL,139),(140,'Old Question','second',2018,10,NULL,140),(141,'Old Question','first',2018,10,NULL,141),(142,'Old Question','second',2018,10,NULL,142),(143,'Old Question','first',2018,10,NULL,143),(144,'Old Question','second',2018,10,NULL,144),(145,'Old Question','second',2018,10,NULL,145),(146,'Old Question','second',2018,10,NULL,146),(147,'Old Question','second',2018,10,NULL,147),(148,'Old Question','second',2018,10,NULL,148),(149,'Old Question','second',2018,10,NULL,149),(150,'Old Question','second',2018,10,NULL,150),(151,'Old Question','second',2018,10,NULL,151),(152,'Old Question','second',2018,10,NULL,152),(153,'Old Question','second',2018,10,NULL,153),(154,'Old Question','second',2018,10,NULL,154),(155,'Old Question','second',2018,10,NULL,155),(156,'Old Question','second',2018,10,NULL,156),(157,'Old Question','second',2018,10,NULL,157),(158,'Old Question','second',2018,10,NULL,158),(159,'Old Question','second',2018,10,NULL,159),(160,'Old Question','second',2018,10,NULL,160),(161,'Old Question','second',2018,10,NULL,161),(162,'Old Question','second',2018,10,NULL,162),(163,'Old Question','second',2018,10,NULL,163),(164,'Old Question','second',2018,10,NULL,164),(165,'Old Question','second',2018,10,NULL,165),(166,'Old Question','second',2018,10,NULL,166),(167,'Old Question','second',2018,10,NULL,167),(168,'Old Question','second',2018,10,NULL,168),(169,'Old Question','second',2018,10,NULL,169),(170,'Old Question','second',2018,10,NULL,170),(171,'Old Question','second',2018,10,NULL,171),(172,'Old Question','second',2018,10,NULL,172),(173,'Old Question','second',2018,10,NULL,173),(174,'Old Question','second',2018,10,NULL,174),(175,'Old Question','second',2018,10,NULL,175),(176,'Old Question','second',2018,10,NULL,176),(177,'Old Question','second',2018,10,NULL,177),(178,'Old Question','second',2018,10,NULL,178),(179,'Old Question','second',2018,10,NULL,179),(180,'Old Question','second',2018,10,NULL,180),(181,'Old Question','second',2018,10,NULL,181),(182,'Old Question','second',2018,10,NULL,182),(183,'Old Question','second ',2018,10,NULL,183),(184,'Old Question','first',2018,10,NULL,184),(185,'Old Question','first',2018,10,NULL,185),(186,'Old Question','second ',2018,10,NULL,186),(187,'Old Question','second ',2018,10,NULL,187),(188,'Old Question','second ',2018,10,NULL,188),(189,'Old Question','second ',2018,10,NULL,189),(190,'Old Question','second ',2018,10,NULL,190),(191,'Old Question','second ',2018,10,NULL,191),(192,'Old Question','second ',2018,10,NULL,192),(193,'Old Question','second ',2018,10,NULL,193),(194,'Old Question','second ',2018,10,NULL,194);
/*!40000 ALTER TABLE `project_old` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-05  4:01:46
