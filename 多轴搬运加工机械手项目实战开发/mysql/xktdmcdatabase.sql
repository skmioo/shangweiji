/*
SQLyog Ultimate v12.08 (64 bit)
MySQL - 8.0.18 : Database - xktdmcdatabase
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`xktdmcdatabase` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `xktdmcdatabase`;

/*Table structure for table `product` */

DROP TABLE IF EXISTS `product`;

CREATE TABLE `product` (
  `ProductDateTime` varchar(50) DEFAULT NULL,
  `LotNum` varchar(50) DEFAULT NULL,
  `Result` int(11) DEFAULT NULL,
  `Operator` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `product` */

/*Table structure for table `report` */

DROP TABLE IF EXISTS `report`;

CREATE TABLE `report` (
  `ReportDateTime` varchar(50) DEFAULT NULL,
  `OKNumber` int(11) DEFAULT NULL,
  `NGNumber` int(11) DEFAULT NULL,
  `TotalNumber` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `report` */

insert  into `report`(`ReportDateTime`,`OKNumber`,`NGNumber`,`TotalNumber`) values ('2019/11/27 00:00:00',0,0,0);

/*Table structure for table `sysadmins` */

DROP TABLE IF EXISTS `sysadmins`;

CREATE TABLE `sysadmins` (
  `LoginName` varchar(50) DEFAULT NULL,
  `LoginPwd` varchar(50) DEFAULT NULL,
  `HandCtrl` int(11) DEFAULT NULL,
  `AutoCtrl` int(11) DEFAULT NULL,
  `SysSet` int(11) DEFAULT NULL,
  `SysLog` int(11) DEFAULT NULL,
  `Report` int(11) DEFAULT NULL,
  `Trend` int(11) DEFAULT NULL,
  `UserManage` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `sysadmins` */

insert  into `sysadmins`(`LoginName`,`LoginPwd`,`HandCtrl`,`AutoCtrl`,`SysSet`,`SysLog`,`Report`,`Trend`,`UserManage`) values ('管理员','EB7D99584FF02C14',1,1,1,1,1,1,1),('王曦','EB7D99584FF02C14',1,1,1,1,1,1,1);

/*Table structure for table `syslog` */

DROP TABLE IF EXISTS `syslog`;

CREATE TABLE `syslog` (
  `LogTime` varchar(50) DEFAULT NULL,
  `LogInfo` varchar(50) DEFAULT NULL,
  `User` varchar(50) DEFAULT NULL,
  `LogType` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `syslog` */

insert  into `syslog`(`LogTime`,`LogInfo`,`User`,`LogType`) values ('2019/11/27 14:45:33','登录系统','管理员',0),('2019/11/27 14:45:52','退出系统','管理员',0),('2019/11/27 14:47:52','登录系统','管理员',0),('2019/11/27 14:47:55','退出系统','管理员',0);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
