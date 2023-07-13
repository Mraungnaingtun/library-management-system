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
-- Table structure for table `member_teacher_staff`
--

DROP TABLE IF EXISTS `member_teacher_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `member_teacher_staff` (
  `MTS_ID` varchar(45) NOT NULL,
  `TS_Name` varchar(45) DEFAULT NULL,
  `Depeartment_Name` varchar(45) DEFAULT NULL,
  `Rank_Name` varchar(45) DEFAULT NULL,
  `PhoneNo` varchar(15) DEFAULT NULL,
  `Address` longtext,
  PRIMARY KEY (`MTS_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member_teacher_staff`
--

LOCK TABLES `member_teacher_staff` WRITE;
/*!40000 ALTER TABLE `member_teacher_staff` DISABLE KEYS */;
INSERT INTO `member_teacher_staff` VALUES ('MTS-0001','Daw Thazin Nwe','IS','D.r','093244342344','Sittwe'),('MTS-0002','Daw San Nyein Khine','CT','D.r','094343423443','Sittwe'),('MTS-0003','DAW NU YIN KYAW','IS','D.R','09423887640','SITTWE'),('MTS-0004','DAW NI LAR HTUN','SOFTWARE','LECTURE','0947363849','ANN'),('MTS-0005','U THAUNG MYINT HTUN','IS','LECTURE','09473928390','SITTWE'),('MTS-0006','D.R ZAW HTUN','PRINCIPAL','PRO-RECTOR','09786424567','SITTWE'),('MTS-0007','DAW AYE NYEIN SAN','IS','ASSISANT LECTURE','098746256368','SITTWE'),('MTS-0008','DAW SWE SWE OO','IS','ASSIANT LECTURE','09435589524','SITTWE'),('MTS-0009','DAW SWE SWE MYINT ','ENGLISH','ASSISTANT LECTURE','09567982643','SITTWE'),('MTS-0010','U MYO MYAT NAING','ENGLISH','ASSISTANT LECTURE','09876534569','SITTWE'),('MTS-0011','U YE NAING','HARDWARE','ASSISTANT','09876543214','SITTWR');
/*!40000 ALTER TABLE `member_teacher_staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-05  4:01:43
