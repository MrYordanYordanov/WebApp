-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema school
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema schooltest
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema schooltest
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `schooltest` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `schooltest` ;

-- -----------------------------------------------------
-- Table `schooltest`.`semesters`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schooltest`.`semesters` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `startDate` DATE NOT NULL,
  `endDate` DATE NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `schooltest`.`disciplines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schooltest`.`disciplines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `professorName` VARCHAR(255) NOT NULL,
  `score` DECIMAL(16,2) NOT NULL,
  `semester_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `semester_id` (`semester_id` ASC),
  CONSTRAINT `disciplines_ibfk_1`
    FOREIGN KEY (`semester_id`)
    REFERENCES `schooltest`.`semesters` (`id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 13
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `schooltest`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schooltest`.`students` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `surname` VARCHAR(255) NOT NULL,
  `dob` DATE NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 16
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `schooltest`.`students_semesters`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schooltest`.`students_semesters` (
  `student_id` INT NOT NULL,
  `semester_id` INT NOT NULL,
  PRIMARY KEY (`student_id`, `semester_id`),
  INDEX `semester_id` (`semester_id` ASC),
  CONSTRAINT `students_semesters_ibfk_1`
    FOREIGN KEY (`student_id`)
    REFERENCES `schooltest`.`students` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `students_semesters_ibfk_2`
    FOREIGN KEY (`semester_id`)
    REFERENCES `schooltest`.`semesters` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `schooltest` ;

-- -----------------------------------------------------
-- procedure sp_AddDiscipline
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_AddDiscipline`(IN name varchar(255), IN professorName varchar(255), in score decimal(16,2))
BEGIN
insert into disciplines(name, professorName,score) values (name, professorName,score);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_AddSemester
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_AddSemester`(IN name varchar(255), IN startDate date, in endDate date)
BEGIN
insert into semesters(name, startDate,endDate) values (name, startDate,endDate);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_AddStudent
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_AddStudent`(IN name varchar(255), IN surname varchar(255), in dob date)
BEGIN
insert into students(name, surname,dob) values (name, surname,dob);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_DeleteAllDisciplines
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DeleteAllDisciplines`()
BEGIN
DELETE FROM disciplines WHERE id>0;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_DeleteAllSemesters
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DeleteAllSemesters`()
BEGIN
DELETE FROM semesters WHERE id>0;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_DeleteAllStudents
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DeleteAllStudents`()
BEGIN
DELETE FROM students WHERE id>0;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_EditDiscipline
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_EditDiscipline`(In disciplineId int ,IN name varchar(255), IN professorName varchar(255), in score decimal(16,2))
BEGIN
UPDATE disciplines
SET Name = name, professorName=professorName,score=score
WHERE id = disciplineId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_EditSemester
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_EditSemester`(In semesterId int ,IN name varchar(255), IN startDate date, in endDate date)
BEGIN
UPDATE semesters
SET Name = name, startDate=startDate,endDate=endDate
WHERE id = semesterId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_EditStudent
-- -----------------------------------------------------

DELIMITER $$
USE `schooltest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_EditStudent`(In studentId int ,IN name varchar(255), IN surname varchar(255), in dob date)
BEGIN
UPDATE students
SET Name = name, Surname=surname,dob=dob
WHERE id = studentId;
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
