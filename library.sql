-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema u1546798_library
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema u1546798_library
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `u1546798_library` DEFAULT CHARACTER SET utf8 ;
USE `u1546798_library` ;

-- -----------------------------------------------------
-- Table `u1546798_library`.`editions`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`editions` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`editions` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(50) NOT NULL,
  `place` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `index2` (`title` ASC, `place` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`genres`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`genres` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`genres` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `title_UNIQUE` (`title` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`books`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`books` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`books` (
  `isbn` INT NOT NULL,
  `title` VARCHAR(45) NOT NULL,
  `genre_id` INT NOT NULL,
  `edition_id` INT NOT NULL,
  `author` VARCHAR(50) NOT NULL,
  `edition_year` INT NOT NULL,
  `pags` INT NOT NULL,
  `access` TINYINT NOT NULL,
  PRIMARY KEY (`isbn`),
  INDEX `editions_idx` (`edition_id` ASC) ,
  INDEX `genres_idx` (`genre_id` ASC) ,
  CONSTRAINT `editions`
    FOREIGN KEY (`edition_id`)
    REFERENCES `u1546798_library`.`editions` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT,
  CONSTRAINT `genres`
    FOREIGN KEY (`genre_id`)
    REFERENCES `u1546798_library`.`genres` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`posts`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`posts` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`posts` (
  `id` INT NOT NULL,
  `title` VARCHAR(50) NOT NULL,
  `salary` INT NOT NULL,
  `access_level` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `title_UNIQUE` (`title` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`employees`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`employees` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`employees` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fullname` VARCHAR(100) NOT NULL,
  `pass_num` VARCHAR(20) NOT NULL,
  `pass_exp` DATE NOT NULL,
  `homenum` INT NULL,
  `phonenum` INT NOT NULL,
  `town` VARCHAR(20) NOT NULL,
  `address` VARCHAR(100) NOT NULL,
  `post_id` INT NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `pass_num_UNIQUE` (`pass_num` ASC) ,
  UNIQUE INDEX `phonenum_UNIQUE` (`phonenum` ASC) ,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) ,
  INDEX `posts_idx` (`post_id` ASC) ,
  CONSTRAINT `posts`
    FOREIGN KEY (`post_id`)
    REFERENCES `u1546798_library`.`posts` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`clients`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`clients` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`clients` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fullname` VARCHAR(100) NOT NULL,
  `pass_num` VARCHAR(20) NOT NULL,
  `pass_exp` DATE NOT NULL,
  `homenum` INT NULL,
  `phonenum` INT NOT NULL,
  `town` VARCHAR(20) NOT NULL,
  `address` VARCHAR(100) NOT NULL,
  `vuz` VARCHAR(100) NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `pass_num_UNIQUE` (`pass_num` ASC) ,
  UNIQUE INDEX `phonenum_UNIQUE` (`phonenum` ASC) ,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`orders`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`orders` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`orders` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `client_id` INT NOT NULL,
  `employer_id` INT NOT NULL,
  `book_id` INT NOT NULL,
  `date_give` DATE NOT NULL,
  `date_return` VARCHAR(45) NOT NULL,
  `returned` TINYINT NOT NULL,
  INDEX `clients_idx` (`client_id` ASC) ,
  INDEX `employees_idx` (`employer_id` ASC) ,
  INDEX `books_idx` (`book_id` ASC) ,
  PRIMARY KEY (`id`),
  CONSTRAINT `clients`
    FOREIGN KEY (`client_id`)
    REFERENCES `u1546798_library`.`clients` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT,
  CONSTRAINT `employees`
    FOREIGN KEY (`employer_id`)
    REFERENCES `u1546798_library`.`employees` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT,
  CONSTRAINT `books`
    FOREIGN KEY (`book_id`)
    REFERENCES `u1546798_library`.`books` (`isbn`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `u1546798_library`.`logs`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `u1546798_library`.`logs` ;

CREATE TABLE IF NOT EXISTS `u1546798_library`.`logs` (
  `employer_id` INT NOT NULL,
  `command` VARCHAR(150) NOT NULL,
  `create_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  INDEX `employees_idx` (`employer_id` ASC) ,
  CONSTRAINT `employeeslog`
    FOREIGN KEY (`employer_id`)
    REFERENCES `u1546798_library`.`employees` (`id`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
