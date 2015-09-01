-- Description:
-- MySQL Script that creates tables for implementing Success Stories for GetSkills website, along with Primary key, Foreign Key and Index.
-- 09/01/15 11:24:43
--Author: Vasanth Boraiyan
-- 
-- 

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Schema_Success_Story
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Schema_Success_Story` ;

-- -----------------------------------------------------
-- Schema Schema_Success_Story
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Schema_Success_Story` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Schema_Success_Story` ;

-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Course`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Course` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Course` (
  `SS_Course_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Course_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Course_Desc` VARCHAR(100) NULL COMMENT '',
  `SS_Course_Fees` INT(11) NULL COMMENT '',
  `SS_Course_Start_Date` DATE NULL COMMENT '',
  `SS_Course_End_Date` DATE NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Course_ID`)  COMMENT '')
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Course_Name_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Course` (`SS_Course_Name` ASC)  COMMENT '';

CREATE UNIQUE INDEX `SS_Course_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Course` (`SS_Course_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Login_Level`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Login_Level` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Login_Level` (
  `SS_Login_Level_ID` INT(11) UNSIGNED NOT NULL COMMENT '',
  `SS_Login_Level_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Login_Level_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Login_Level_ID`)  COMMENT '')
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Login_Level_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Login_Level` (`SS_Login_Level_ID` ASC)  COMMENT '';

CREATE UNIQUE INDEX `SS_Login_Name_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Login_Level` (`SS_Login_Level_Name` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Category`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Category` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Category` (
  `SS_Category_ID` INT(11) NOT NULL COMMENT '',
  `SS_Category_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Category_Desc` VARCHAR(45) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Category_ID`)  COMMENT '')
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Category_Name_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Category` (`SS_Category_Name` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Classification`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Classification` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Classification` (
  `SS_Classification_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Classification_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Classification_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Classification_ID`)  COMMENT '')
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Classification_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Classification` (`SS_Classification_ID` ASC)  COMMENT '';

CREATE UNIQUE INDEX `SS_Classification_Name_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Classification` (`SS_Classification_Name` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Student`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Student` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Student` (
  `SS_Student_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Student_F_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Student_M_Name` VARCHAR(50) NULL COMMENT '',
  `SS_Student_L_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Studnet_Email` VARCHAR(100) NOT NULL COMMENT '',
  `SS_Student_Phone` VARCHAR(15) NULL COMMENT '',
  `SS_Student_Mobile` VARCHAR(15) NOT NULL COMMENT '',
  `SS_Student_Facebook` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Student_Course_ID` INT(11) NOT NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Student_ID`)  COMMENT '')
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Student_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Student` (`SS_Student_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Student_Course`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Student_Course` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Student_Course` (
  `SS_Student_Course_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Student_ID` INT(11) NOT NULL COMMENT '',
  `SS_Course_ID` INT(11) NOT NULL COMMENT '',
  `SS_Student_Course_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Student_Course_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_Student_Course_tbl_SS_Course`
    FOREIGN KEY (`SS_Course_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Course` (`SS_Course_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_SS_Student_Course_tbl_SS_Student1`
    FOREIGN KEY (`SS_Student_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Student` (`SS_Student_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Student_Course_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Student_Course` (`SS_Student_Course_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Student_Course_tbl_SS_Course_idx` ON `Schema_Success_Story`.`tbl_SS_Student_Course` (`SS_Course_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Student_Course_tbl_SS_Student1_idx` ON `Schema_Success_Story`.`tbl_SS_Student_Course` (`SS_Student_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_User_Login_Level`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_User_Login_Level` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_User_Login_Level` (
  `SS_User_Login_Level_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_User_ID` INT(11) NOT NULL COMMENT '',
  `SS_Login_Level_ID` INT(11) NOT NULL COMMENT '',
  `SS_User_Login_Level_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_User_Login_Level_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_User_Login_Level_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_User_Login_Level_tbl_SS_Login_Level1`
    FOREIGN KEY (`SS_Login_Level_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Login_Level` (`SS_Login_Level_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_User_Login_Level_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_User_Login_Level` (`SS_User_Login_Level_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_User_Login_Level_tbl_SS_Login_Level1_idx` ON `Schema_Success_Story`.`tbl_SS_User_Login_Level` (`SS_Login_Level_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_User`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_User` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_User` (
  `SS_User_ID` INT(11) UNSIGNED NOT NULL COMMENT '',
  `SS_User_Name` VARCHAR(100) NOT NULL COMMENT '',
  `SS_User_Desc` VARCHAR(200) NULL COMMENT '',
  `SS_User_Password` VARCHAR(45) NOT NULL COMMENT '',
  `SS_User_Login_Level_ID` INT(11) NOT NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL COMMENT '',
  PRIMARY KEY (`SS_User_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_User_tbl_SS_User_Login_Level1`
    FOREIGN KEY (`SS_User_Login_Level_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_User_Login_Level` (`SS_User_Login_Level_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_User_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_User` (`SS_User_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_User_tbl_SS_User_Login_Level1_idx` ON `Schema_Success_Story`.`tbl_SS_User` (`SS_User_Login_Level_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_Success_Story_User`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_Success_Story_User` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_Success_Story_User` (
  `SS_Success_Story_User_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Success_Story_ID` INT(11) NOT NULL COMMENT '',
  `SS_User_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_User_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Success_Story_User_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL COMMENT '',
  PRIMARY KEY (`SS_Success_Story_User_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_Success_Story_User_tbl_SS_User1`
    FOREIGN KEY (`SS_User_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_User` (`SS_User_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `Success_Story_User_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_Success_Story_User` (`SS_Success_Story_User_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_Success_Story_User_tbl_SS_User1_idx` ON `Schema_Success_Story`.`tbl_Success_Story_User` (`SS_User_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Student_Category`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Student_Category` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Student_Category` (
  `SS_Student_Category_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Category_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_Cagegory_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Success_Story_Category_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NULL COMMENT '',
  PRIMARY KEY (`SS_Student_Category_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_Student_Category_tbl_SS_Category1`
    FOREIGN KEY (`SS_Category_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Category` (`SS_Category_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_tbl_SS_Student_Category_tbl_SS_Category1_idx` ON `Schema_Success_Story`.`tbl_SS_Student_Category` (`SS_Category_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Success_Story_Classification`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Success_Story_Classification` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Success_Story_Classification` (
  `SS_Success_Story_Classification_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Success_Story_ID` INT(11) NOT NULL COMMENT '',
  `SS_Classification_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_Classification_Name` VARCHAR(50) NOT NULL COMMENT '',
  `SS_Success_Story_Classification_Desc` VARCHAR(100) NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Success_Story_Classification_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_Success_Story_Classification_tbl_SS_Classification1`
    FOREIGN KEY (`SS_Classification_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Classification` (`SS_Classification_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Success_Story_Classification_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Success_Story_Classification` (`SS_Success_Story_Classification_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Success_Story_Classification_tbl_SS_Classificatio_idx` ON `Schema_Success_Story`.`tbl_SS_Success_Story_Classification` (`SS_Classification_ID` ASC)  COMMENT '';


-- -----------------------------------------------------
-- Table `Schema_Success_Story`.`tbl_SS_Success_Story`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Schema_Success_Story`.`tbl_SS_Success_Story` ;

CREATE TABLE IF NOT EXISTS `Schema_Success_Story`.`tbl_SS_Success_Story` (
  `SS_Success_Story_ID` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `SS_Student_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_User_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_Category_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_Classification_ID` INT(11) NOT NULL COMMENT '',
  `SS_Success_Story_Short_Desc` VARCHAR(500) NOT NULL COMMENT '',
  `SS_Success_Story_Long_Desc` VARCHAR(1000) NULL COMMENT '',
  `SS_Success_Story_Photo` VARCHAR(100) NOT NULL COMMENT '',
  `Delete_Status` INT(1) NOT NULL DEFAULT 1 COMMENT '',
  PRIMARY KEY (`SS_Success_Story_ID`)  COMMENT '',
  CONSTRAINT `fk_tbl_SS_Success_Story_ID_tbl_SS_Student1`
    FOREIGN KEY (`SS_Student_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Student` (`SS_Student_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_SS_Success_Story_ID_tbl_Success_Story_User1`
    FOREIGN KEY (`SS_Success_Story_User_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_Success_Story_User` (`SS_Success_Story_User_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_SS_Success_Story_ID_tbl_SS_Student_Category1`
    FOREIGN KEY (`SS_Success_Story_Category_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Student_Category` (`SS_Student_Category_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_SS_Success_Story_tbl_SS_Success_Story_Classification1`
    FOREIGN KEY (`SS_Success_Story_Classification_ID`)
    REFERENCES `Schema_Success_Story`.`tbl_SS_Success_Story_Classification` (`SS_Success_Story_Classification_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `SS_Success_Story_ID_UNIQUE` ON `Schema_Success_Story`.`tbl_SS_Success_Story` (`SS_Success_Story_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Success_Story_ID_tbl_SS_Student1_idx` ON `Schema_Success_Story`.`tbl_SS_Success_Story` (`SS_Student_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Success_Story_ID_tbl_Success_Story_User1_idx` ON `Schema_Success_Story`.`tbl_SS_Success_Story` (`SS_Success_Story_User_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Success_Story_ID_tbl_SS_Student_Category1_idx` ON `Schema_Success_Story`.`tbl_SS_Success_Story` (`SS_Success_Story_Category_ID` ASC)  COMMENT '';

CREATE INDEX `fk_tbl_SS_Success_Story_tbl_SS_Success_Story_Classification_idx` ON `Schema_Success_Story`.`tbl_SS_Success_Story` (`SS_Success_Story_Classification_ID` ASC)  COMMENT '';


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
