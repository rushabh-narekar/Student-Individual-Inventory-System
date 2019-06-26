-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 08, 2019 at 10:35 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbstudentindividualinventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `messagein`
--

CREATE TABLE IF NOT EXISTS `messagein` (
`Id` int(11) NOT NULL,
  `SendTime` datetime DEFAULT NULL,
  `ReceiveTime` datetime DEFAULT NULL,
  `MessageFrom` varchar(80) DEFAULT NULL,
  `MessageTo` varchar(80) DEFAULT NULL,
  `SMSC` varchar(80) DEFAULT NULL,
  `MessageText` text,
  `MessageType` varchar(80) DEFAULT NULL,
  `MessageParts` int(11) DEFAULT NULL,
  `MessagePDU` text,
  `Gateway` varchar(80) DEFAULT NULL,
  `UserId` varchar(80) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `messagein`
--

INSERT INTO `messagein` (`Id`, `SendTime`, `ReceiveTime`, `MessageFrom`, `MessageTo`, `SMSC`, `MessageText`, `MessageType`, `MessageParts`, `MessagePDU`, `Gateway`, `UserId`) VALUES
(1, NULL, '2018-04-10 06:53:58', '+639305235027', '+639305235027', NULL, 'FROM Guidance Counselor : Yes', NULL, NULL, NULL, NULL, NULL),
(2, NULL, '2018-04-10 06:55:19', '+639305235027', '+639305235027', NULL, 'FROM Guidance Counselor : Yes', NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `messagelog`
--

CREATE TABLE IF NOT EXISTS `messagelog` (
`Id` int(11) NOT NULL,
  `SendTime` datetime DEFAULT NULL,
  `ReceiveTime` datetime DEFAULT NULL,
  `StatusCode` int(11) DEFAULT NULL,
  `StatusText` varchar(80) DEFAULT NULL,
  `MessageTo` varchar(80) DEFAULT NULL,
  `MessageFrom` varchar(80) DEFAULT NULL,
  `MessageText` text,
  `MessageType` varchar(80) DEFAULT NULL,
  `MessageId` varchar(80) DEFAULT NULL,
  `ErrorCode` varchar(80) DEFAULT NULL,
  `ErrorText` varchar(80) DEFAULT NULL,
  `Gateway` varchar(80) DEFAULT NULL,
  `MessageParts` int(11) DEFAULT NULL,
  `MessagePDU` text,
  `Connector` varchar(80) DEFAULT NULL,
  `UserId` varchar(80) DEFAULT NULL,
  `UserInfo` text
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `messagelog`
--

INSERT INTO `messagelog` (`Id`, `SendTime`, `ReceiveTime`, `StatusCode`, `StatusText`, `MessageTo`, `MessageFrom`, `MessageText`, `MessageType`, `MessageId`, `ErrorCode`, `ErrorText`, `Gateway`, `MessageParts`, `MessagePDU`, `Connector`, `UserId`, `UserInfo`) VALUES
(1, NULL, '2018-04-10 06:54:28', 200, NULL, '639305235027', NULL, 'FROM Guidance Counselor : Yes', NULL, '1:639305235027:147', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, NULL, '2018-04-10 06:55:49', 200, NULL, '639305235027', NULL, 'FROM Guidance Counselor : Yes', NULL, '1:639305235027:148', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `messageout`
--

CREATE TABLE IF NOT EXISTS `messageout` (
`Id` int(11) NOT NULL,
  `MessageTo` varchar(80) DEFAULT NULL,
  `MessageFrom` varchar(80) DEFAULT NULL,
  `MessageText` text,
  `MessageType` varchar(80) DEFAULT NULL,
  `Gateway` varchar(80) DEFAULT NULL,
  `UserId` varchar(80) DEFAULT NULL,
  `UserInfo` text,
  `Priority` int(11) DEFAULT NULL,
  `Scheduled` datetime DEFAULT NULL,
  `ValidityPeriod` int(11) DEFAULT NULL,
  `IsSent` tinyint(1) NOT NULL DEFAULT '0',
  `IsRead` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `messageout`
--

INSERT INTO `messageout` (`Id`, `MessageTo`, `MessageFrom`, `MessageText`, `MessageType`, `Gateway`, `UserId`, `UserInfo`, `Priority`, `Scheduled`, `ValidityPeriod`, `IsSent`, `IsRead`) VALUES
(1, '639305235027', 'Janno', 'FROM Guidance Counselor : Yes', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0),
(2, '639305235027', 'Janno', 'FROM Guidance Counselor : Yes', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE IF NOT EXISTS `tblautonumber` (
`AUTOID` int(11) NOT NULL,
  `STARTNUM` varchar(90) NOT NULL,
  `ENDNUM` int(11) NOT NULL,
  `INCREMENTNUM` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`AUTOID`, `STARTNUM`, `ENDNUM`, `INCREMENTNUM`) VALUES
(1, '20180', 34, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblcourse`
--

CREATE TABLE IF NOT EXISTS `tblcourse` (
`COURSEID` int(11) NOT NULL,
  `COURSE` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcourse`
--

INSERT INTO `tblcourse` (`COURSEID`, `COURSE`, `DESCRIPTION`) VALUES
(1, 'BEED', 'saas');

-- --------------------------------------------------------

--
-- Table structure for table `tbleducationalbackground`
--

CREATE TABLE IF NOT EXISTS `tbleducationalbackground` (
`EDUCID` int(11) NOT NULL,
  `StudentID` varchar(90) NOT NULL,
  `LEVEL` varchar(90) NOT NULL,
  `SCHOOLGRADUATED` varchar(90) NOT NULL,
  `SCHOOLADDRESS` varchar(90) NOT NULL,
  `PUBLICPRIVATE` varchar(90) NOT NULL,
  `DATESOFATTENDANCE` varchar(90) NOT NULL,
  `HONORSRECEIVED` varchar(90) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleducationalbackground`
--

INSERT INTO `tbleducationalbackground` (`EDUCID`, `StudentID`, `LEVEL`, `SCHOOLGRADUATED`, `SCHOOLADDRESS`, `PUBLICPRIVATE`, `DATESOFATTENDANCE`, `HONORSRECEIVED`) VALUES
(1, '2018', 'Pre-Elementary', 'dancalan', 's', 's', 's', 's'),
(2, '2018', 'Elementary', 'danca', 'sad', 'sad', 'sad', 'sad'),
(3, '2018', 'High School', 'ICA', '', '', '', ''),
(4, '2018', 'Vocational', '', '', '', '', ''),
(5, '2018', 'College', 'KCC', '', '', '', ''),
(6, '123', 'Pre-Elementary', '', '', '', '', ''),
(7, '123', 'Elementary', '', '', '', '', ''),
(8, '123', 'High School', '', '', '', '', ''),
(9, '123', 'Vocational', '', '', '', '', ''),
(10, '123', 'College', '', '', '', '', ''),
(11, '21', 'Pre-Elementary', '', '', '', '', ''),
(12, '21', 'Elementary', '', '', '', '', ''),
(13, '21', 'High School', '', '', '', '', ''),
(14, '21', 'Vocational', '', '', '', '', ''),
(15, '21', 'College', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblexcuseslip`
--

CREATE TABLE IF NOT EXISTS `tblexcuseslip` (
`EXCUSEDID` int(11) NOT NULL,
  `SlipNo` varchar(90) NOT NULL,
  `StudentID` varchar(90) NOT NULL,
  `CourseYear` varchar(90) NOT NULL,
  `Subject` varchar(90) NOT NULL,
  `ProfessorSignature` tinyint(1) NOT NULL,
  `ExcusedDate` date NOT NULL,
  `InclusiveDate` date NOT NULL,
  `Reasons` varchar(90) NOT NULL,
  `StudentPresented` varchar(90) NOT NULL,
  `Remarks` varchar(90) NOT NULL,
  `DepartmentAdviser` varchar(90) NOT NULL,
  `HeadAcademic` varchar(90) NOT NULL,
  `GuidanceCounselor` varchar(90) NOT NULL,
  `Approved` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblexcuseslip`
--

INSERT INTO `tblexcuseslip` (`EXCUSEDID`, `SlipNo`, `StudentID`, `CourseYear`, `Subject`, `ProfessorSignature`, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks`, `DepartmentAdviser`, `HeadAcademic`, `GuidanceCounselor`, `Approved`) VALUES
(1, '2018026', '2018', '', 'as', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(2, '2018026', '2018', '', 'sad', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(3, '2018027', '2018', '', 'sad', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(4, '2018027', '2018', '', 'sadsad', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(5, '2018027', '2018', '', 'asdasdas', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(6, '2018028', '2018', '', 'sa', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(7, '2018028', '2018', '', 'sad', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(8, '2018028', '2018', '', 'sad', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(9, '2018029', '2018', '', 's', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(10, '2018029', '2018', '', 's', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(11, '2018029', '2018', '', 's', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(12, '2018029', '2018', '', 's', 0, '2018-04-09', '2018-04-09', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(13, '2018030', '2018', '', 'math', 0, '2018-04-10', '2018-04-11', '', 'Parents/Guardians letter of excuse', 'Excused', '', '', '', 0),
(14, '2018030', '2018', '', 'science', 0, '2018-04-10', '2018-04-11', '', 'Parents/Guardians letter of excuse', 'Excused', '', '', '', 0),
(15, '2018031', '', '', 'sdsa', 0, '2018-08-02', '2018-08-02', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(16, '2018031', '', '', 'sad', 0, '2018-08-02', '2018-08-02', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(17, '2018032', '2018', 'BEED 1st-1', 'Math', 0, '2018-08-02', '2018-08-02', '', 'Students letter of excuse', 'Excused', '', '', '', 0),
(18, '2018033', '2018', 'BEED 1st-1', 'Math', 0, '2018-08-05', '2018-08-05', 'Sick', 'Students letter of excuse', 'Excused', '', '', '', 0),
(19, '2018033', '2018', 'BEED 1st-1', 'English', 0, '2018-08-05', '2018-08-05', 'Sick', 'Students letter of excuse', 'Excused', '', '', '', 0),
(20, '2018033', '2018', 'BEED 1st-1', 'Science', 0, '2018-08-05', '2018-08-05', 'Sick', 'Students letter of excuse', 'Excused', '', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblfamilybackground`
--

CREATE TABLE IF NOT EXISTS `tblfamilybackground` (
`HOMEID` int(11) NOT NULL,
  `StudentID` varchar(90) NOT NULL,
  `Father` varchar(90) NOT NULL,
  `F_Age` int(11) NOT NULL,
  `F_EducationaAttainment` varchar(90) NOT NULL,
  `F_Occupation` varchar(90) NOT NULL,
  `F_EmployerName` varchar(90) NOT NULL,
  `F_EmployerAddress` varchar(90) NOT NULL,
  `F_Living` varchar(90) NOT NULL,
  `Mother` varchar(90) NOT NULL,
  `M_Age` int(11) NOT NULL,
  `M_Living` varchar(90) NOT NULL,
  `M_EducationaAttainment` varchar(90) NOT NULL,
  `M_Occupation` varchar(90) NOT NULL,
  `M_EmployerName` varchar(90) NOT NULL,
  `M_EmployerAddress` varchar(90) NOT NULL,
  `Guardian` varchar(90) NOT NULL,
  `G_Age` int(11) NOT NULL,
  `G_Living` varchar(90) NOT NULL,
  `G_EducationaAttainment` varchar(90) NOT NULL,
  `G_Occupation` varchar(90) NOT NULL,
  `G_EmployerName` varchar(90) NOT NULL,
  `G_EmployerAddress` varchar(90) NOT NULL,
  `ParentsMartialReationship` varchar(90) NOT NULL,
  `NoofChildren` int(11) NOT NULL,
  `NoofBrothers` int(11) NOT NULL,
  `NoofSisters` int(11) NOT NULL,
  `NoofSisterBrotherGainfullyEmployed` int(11) NOT NULL,
  `OrdinalPositiom` varchar(90) NOT NULL,
  `ProvidingSupport` varchar(90) NOT NULL,
  `Allowance` varchar(90) NOT NULL,
  `QuitePlaceStudy` varchar(90) NOT NULL,
  `ShareRoom` varchar(90) NOT NULL,
  `NatureofResidence` varchar(90) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblfamilybackground`
--

INSERT INTO `tblfamilybackground` (`HOMEID`, `StudentID`, `Father`, `F_Age`, `F_EducationaAttainment`, `F_Occupation`, `F_EmployerName`, `F_EmployerAddress`, `F_Living`, `Mother`, `M_Age`, `M_Living`, `M_EducationaAttainment`, `M_Occupation`, `M_EmployerName`, `M_EmployerAddress`, `Guardian`, `G_Age`, `G_Living`, `G_EducationaAttainment`, `G_Occupation`, `G_EmployerName`, `G_EmployerAddress`, `ParentsMartialReationship`, `NoofChildren`, `NoofBrothers`, `NoofSisters`, `NoofSisterBrotherGainfullyEmployed`, `OrdinalPositiom`, `ProvidingSupport`, `Allowance`, `QuitePlaceStudy`, `ShareRoom`, `NatureofResidence`) VALUES
(1, '2018', '', 0, '', '', '', '', 'Alive', '', 0, 'Alive', '', '', '', '', '', 0, 'Alive', '', '', '', '', 'Married and staying together', 0, 0, 0, 0, '', 'your studies', 'Spouse', '', '', ''),
(2, '123', '', 0, '', '', '', '', 'Alive', '', 0, 'Alive', '', '', '', '', '', 0, 'Alive', '', '', '', '', 'Married and staying together', 0, 0, 0, 0, '', 'family', '0', '', '', ''),
(3, '21', '', 0, '', '', '', '', 'Alive', '', 0, 'Alive', '', '', '', '', '', 0, 'Alive', '', '', '', '', 'Married and staying together', 0, 0, 0, 0, '', 'family', 'Parents', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE IF NOT EXISTS `tblstudent` (
`IDNO` int(11) NOT NULL,
  `StudentID` varchar(90) NOT NULL,
  `FirstName` varchar(90) NOT NULL,
  `MiddleName` varchar(90) NOT NULL,
  `LastName` varchar(90) NOT NULL,
  `Sex` varchar(30) NOT NULL,
  `CivilStatus` varchar(90) NOT NULL,
  `DateofBirth` date NOT NULL,
  `Age` int(11) NOT NULL,
  `PlaceofBirth` varchar(200) NOT NULL,
  `CityAddress` varchar(200) NOT NULL,
  `ProvincialAddress` varchar(200) NOT NULL,
  `EmailAddress` varchar(90) NOT NULL,
  `TelephoneNo` varchar(90) NOT NULL,
  `MobileNo` varchar(90) NOT NULL,
  `CourseID` int(11) NOT NULL,
  `S_Level` varchar(90) NOT NULL,
  `S_Section` varchar(90) NOT NULL,
  `S_Height` text NOT NULL,
  `S_Weight` varchar(90) NOT NULL,
  `Comlexion` varchar(150) NOT NULL,
  `Religion` varchar(90) NOT NULL,
  `HighSchoolAve` double NOT NULL,
  `Employer` varchar(150) NOT NULL,
  `PersontobeContact` varchar(90) NOT NULL,
  `P_Address` varchar(90) NOT NULL,
  `P_Relationship` varchar(90) NOT NULL,
  `P_ContactNo` varchar(90) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudent`
--

INSERT INTO `tblstudent` (`IDNO`, `StudentID`, `FirstName`, `MiddleName`, `LastName`, `Sex`, `CivilStatus`, `DateofBirth`, `Age`, `PlaceofBirth`, `CityAddress`, `ProvincialAddress`, `EmailAddress`, `TelephoneNo`, `MobileNo`, `CourseID`, `S_Level`, `S_Section`, `S_Height`, `S_Weight`, `Comlexion`, `Religion`, `HighSchoolAve`, `Employer`, `PersontobeContact`, `P_Address`, `P_Relationship`, `P_ContactNo`) VALUES
(1, '2018', 'Janno', 'Echalar', 'Palacios', 'Male', 'Single', '1993-02-02', 25, 'dancalan ilog', 'Kab city', 'Negros Occ', 'janobe@gmial.com', '666', '639305235027', 1, '1st', '1', '5"3', '36', 'sa', 'chatolic', 86, 'none', 'none', 'none', 'none', 'none');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentguidanceoffice`
--

CREATE TABLE IF NOT EXISTS `tblstudentguidanceoffice` (
`TRANSID` int(11) NOT NULL,
  `StudentID` varchar(90) NOT NULL,
  `CourseYear` varchar(90) NOT NULL,
  `Reasons` text NOT NULL,
  `TransDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbluseraccounts`
--

CREATE TABLE IF NOT EXISTS `tbluseraccounts` (
`UserID` int(11) NOT NULL,
  `Fullname` varchar(30) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Pass` varchar(90) NOT NULL,
  `Role` varchar(30) NOT NULL,
  `Status` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluseraccounts`
--

INSERT INTO `tbluseraccounts` (`UserID`, `Fullname`, `Username`, `Pass`, `Role`, `Status`) VALUES
(1, 'Harry Den', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator', 'Active'),
(2, 'James Yap', 'staff', '6ccb4b7c39a6e77f76ecfa935a855c6c46ad5611', 'Staff', 'Active'),
(7, 'Paul Smith', 'bruno', '9d4e1e23bd5b727046a9e3b4b7db57bd8d6ee684', 'Staff', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `messagein`
--
ALTER TABLE `messagein`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `messagelog`
--
ALTER TABLE `messagelog`
 ADD PRIMARY KEY (`Id`), ADD KEY `IDX_MessageId` (`MessageId`,`SendTime`);

--
-- Indexes for table `messageout`
--
ALTER TABLE `messageout`
 ADD PRIMARY KEY (`Id`), ADD KEY `IDX_IsRead` (`IsRead`);

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
 ADD PRIMARY KEY (`AUTOID`);

--
-- Indexes for table `tblcourse`
--
ALTER TABLE `tblcourse`
 ADD PRIMARY KEY (`COURSEID`);

--
-- Indexes for table `tbleducationalbackground`
--
ALTER TABLE `tbleducationalbackground`
 ADD PRIMARY KEY (`EDUCID`);

--
-- Indexes for table `tblexcuseslip`
--
ALTER TABLE `tblexcuseslip`
 ADD PRIMARY KEY (`EXCUSEDID`);

--
-- Indexes for table `tblfamilybackground`
--
ALTER TABLE `tblfamilybackground`
 ADD PRIMARY KEY (`HOMEID`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
 ADD PRIMARY KEY (`IDNO`);

--
-- Indexes for table `tblstudentguidanceoffice`
--
ALTER TABLE `tblstudentguidanceoffice`
 ADD PRIMARY KEY (`TRANSID`);

--
-- Indexes for table `tbluseraccounts`
--
ALTER TABLE `tbluseraccounts`
 ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `messagein`
--
ALTER TABLE `messagein`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `messagelog`
--
ALTER TABLE `messagelog`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `messageout`
--
ALTER TABLE `messageout`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
MODIFY `AUTOID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblcourse`
--
ALTER TABLE `tblcourse`
MODIFY `COURSEID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbleducationalbackground`
--
ALTER TABLE `tbleducationalbackground`
MODIFY `EDUCID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tblexcuseslip`
--
ALTER TABLE `tblexcuseslip`
MODIFY `EXCUSEDID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `tblfamilybackground`
--
ALTER TABLE `tblfamilybackground`
MODIFY `HOMEID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tblstudent`
--
ALTER TABLE `tblstudent`
MODIFY `IDNO` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblstudentguidanceoffice`
--
ALTER TABLE `tblstudentguidanceoffice`
MODIFY `TRANSID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbluseraccounts`
--
ALTER TABLE `tbluseraccounts`
MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
