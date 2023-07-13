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
-- Table structure for table `member_student`
--

DROP TABLE IF EXISTS `member_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `member_student` (
  `MStu_ID` varchar(45) NOT NULL,
  `Student_Name` varchar(45) DEFAULT NULL,
  `EnterenceNo` varchar(45) DEFAULT NULL,
  `RollNo` varchar(45) DEFAULT NULL,
  `PhoneNo` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`MStu_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member_student`
--

LOCK TABLES `member_student` WRITE;
/*!40000 ALTER TABLE `member_student` DISABLE KEYS */;
INSERT INTO `member_student` VALUES ('MS-0001','Aung Naing Htun','11/TD-083945','5Cs-10','09763647235','Mrauk U'),('MS-0002','Kalat Tin Win','11/TD-075643','3CT-22','09763646435','Thandwe'),('MS-0003','Paing Soe Aung','11/TT-085644','5Cs5','09262185626','Sittwe'),('MS-0004','Myo Zaw Htun','11/TT-758473','5Cs-7','09260201790','Sittwe'),('MS-0005','May Hnin Thu','11/DD-985600','5Cs-1','09452122765','Yangon'),('MS-0006','Ei Zin Phyo','11/DD-657790','5Cs-3','09452122757','Thandwe'),('MS-0007','Ma Wai Mar Lwin','11/TT-668879','5Cs-2','09343874344','MaEi'),('MS-0008','မောင်မျိုးသန့်ကျော်','ကတစ-၁၂၈၄၄','2CT-12','09763647235','ဘူးသီးတောင်'),('MS-0009','Myat Htoo Paing','CUSS-1765','3CS-9','09262185626','KAUNG KYI LANN'),('MS-0010','Phyu Phyu Aung','3455erer','5cs-23','0932434324234','Mrauk U'),('MS-0011','Saw Lwan Nwe','CUSS-1730','5CS-4','09425301529','MINGAN'),('MS-0012','MAY HNIN THU','CUSS-1732','5CS-1','09451212276','THANDWE'),('MS-0013','hrtrtty','rrtyrty','6456','6463456345','rey');
/*!40000 ALTER TABLE `member_student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-05  4:01:49
