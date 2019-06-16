-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema nsecurity
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema nsecurity
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `nsecurity` DEFAULT CHARACTER SET utf8 ;
USE `nsecurity` ;

-- -----------------------------------------------------
-- Table `nsecurity`.`Addresses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Addresses` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `street` VARCHAR(45) NOT NULL,
  `house_num` INT NOT NULL,
  `city` VARCHAR(45) NOT NULL,
  `zip_code` VARCHAR(7) NOT NULL,
  `lat` DECIMAL(10,8) NULL DEFAULT 0.0,
  `lng` DECIMAL(11,8) NULL DEFAULT 0.0,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`Atms`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Atms` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `capacity` INT NOT NULL,
  `atm_size` INT NOT NULL COMMENT '1 = BIG_SIZE\n2 = SMALL_SIZE',
  `brand` VARCHAR(10) NOT NULL,
  `Addresses_id` INT NOT NULL,
  `live_money_avilable` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `fk_Atms_Addresses1_idx` (`Addresses_id` ASC) VISIBLE,
  CONSTRAINT `fk_Atms_Addresses1`
    FOREIGN KEY (`Addresses_id`)
    REFERENCES `nsecurity`.`Addresses` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`Employees`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Employees` (
  `id` VARCHAR(9) NOT NULL,
  `name` VARCHAR(20) NOT NULL,
  `birth_date` DATE NOT NULL,
  `role` VARCHAR(10) NOT NULL,
  `username` VARCHAR(10) CHARACTER SET 'big5' NOT NULL,
  `password` VARCHAR(18) NOT NULL,
  `phone_number` VARCHAR(10) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `gender` VARCHAR(1) NOT NULL COMMENT 'Female || Male (F || M)',
  `Addresses_id` INT NOT NULL COMMENT 'Address of the emploee residents',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `idEmployees_UNIQUE` (`id` ASC) VISIBLE,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  INDEX `fk_Employees_Addresses1_idx` (`Addresses_id` ASC) VISIBLE,
  CONSTRAINT `fk_Employees_Addresses1`
    FOREIGN KEY (`Addresses_id`)
    REFERENCES `nsecurity`.`Addresses` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`Cars`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Cars` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `code` VARCHAR(5) NOT NULL,
  `model` VARCHAR(45) NOT NULL,
  `creation_date` DATE NOT NULL,
  `driver_id` VARCHAR(9) NOT NULL COMMENT 'Emploee_id of the car\'s driver',
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  PRIMARY KEY (`id`),
  INDEX `fk_Cars_Employees1_idx` (`driver_id` ASC) VISIBLE,
  CONSTRAINT `fk_Cars_Employees1`
    FOREIGN KEY (`driver_id`)
    REFERENCES `nsecurity`.`Employees` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`Tracks`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Tracks` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `addresses` VARCHAR(45) NOT NULL,
  `is_done` TINYINT NOT NULL,
  `date` DATE NOT NULL,
  `Cars_id` INT NOT NULL,
  `Employees_id` VARCHAR(9) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `fk_Tracks_Cars1_idx` (`Cars_id` ASC) VISIBLE,
  INDEX `fk_Tracks_Employees1_idx` (`Employees_id` ASC) VISIBLE,
  CONSTRAINT `fk_Tracks_Cars1`
    FOREIGN KEY (`Cars_id`)
    REFERENCES `nsecurity`.`Cars` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tracks_Employees1`
    FOREIGN KEY (`Employees_id`)
    REFERENCES `nsecurity`.`Employees` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`Withdrawals`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`Withdrawals` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `amount` INT NOT NULL,
  `date` DATE NOT NULL,
  `Atms_id` INT NOT NULL,
  PRIMARY KEY (`id`, `Atms_id`),
  UNIQUE INDEX `idWithdrawals_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `fk_Withdrawals_Atms_idx` (`Atms_id` ASC) VISIBLE,
  CONSTRAINT `fk_Withdrawals_Atms`
    FOREIGN KEY (`Atms_id`)
    REFERENCES `nsecurity`.`Atms` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `nsecurity`.`AtmsTracks`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nsecurity`.`AtmsTracks` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `amount` VARCHAR(45) NOT NULL,
  `Atms_id` INT NOT NULL,
  `Track_id` INT NOT NULL,
  `Date` DATE NOT NULL,
  `Manager_id` VARCHAR(9) NOT NULL,
  INDEX `fk_AtmsTracks_Atms1_idx` (`Atms_id` ASC) VISIBLE,
  PRIMARY KEY (`id`, `Manager_id`),
  INDEX `fk_AtmsTracks_Employees1_idx` (`Manager_id` ASC) VISIBLE,
  CONSTRAINT `fk_AtmsTracks_Atms1`
    FOREIGN KEY (`Atms_id`)
    REFERENCES `nsecurity`.`Atms` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AtmsTracks_Tracks1`
    FOREIGN KEY (`Track_id`)
    REFERENCES `nsecurity`.`Tracks` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AtmsTracks_Employees1`
    FOREIGN KEY (`Manager_id`)
    REFERENCES `nsecurity`.`Employees` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
