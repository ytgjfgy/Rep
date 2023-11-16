-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Ноя 16 2023 г., 18:42
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `rep`
--

-- --------------------------------------------------------

--
-- Структура таблицы `components`
--

CREATE TABLE IF NOT EXISTS `components` (
  `Id` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `manufacturer`
--

CREATE TABLE IF NOT EXISTS `manufacturer` (
  `Amd` varchar(40) NOT NULL,
  `Asus(Rog)` varchar(50) NOT NULL,
  `Aorus` varchar(50) NOT NULL,
  `Msi` varchar(50) NOT NULL,
  `Palit` varchar(50) NOT NULL,
  `Asrock` varchar(50) NOT NULL,
  `Apacer` varchar(50) NOT NULL,
  `ADATA` varchar(50) NOT NULL,
  `Corsair` varchar(50) NOT NULL,
  `Crucial` varchar(50) NOT NULL,
  `Crucial(Ballistix)` varchar(50) NOT NULL,
  `GoodRAM` varchar(50) NOT NULL,
  `HYNIX` varchar(50) NOT NULL,
  `SAMSUNG` varchar(50) NOT NULL,
  `ADATA(XPG)` varchar(50) NOT NULL,
  `AFOX` varchar(50) NOT NULL,
  `Colorful` varchar(50) NOT NULL,
  `KFA2` varchar(50) NOT NULL,
  `nVidia` varchar(50) NOT NULL,
  `PowerColor` varchar(50) NOT NULL,
  `Sapphire` varchar(50) NOT NULL,
  `XFXforce` varchar(50) NOT NULL,
  `G.Skill` varchar(50) NOT NULL,
  `Lian Li` varchar(50) NOT NULL,
  `Chieftec` varchar(50) NOT NULL,
  `CoolerMaster` varchar(50) NOT NULL,
  `FSP` varchar(50) NOT NULL,
  `Seasonic` varchar(50) NOT NULL,
  `SilverStone` varchar(50) NOT NULL,
  `Super Flower` varchar(50) NOT NULL,
  `Thermal Grizzly` varchar(50) NOT NULL,
  `Kingston FURY` varchar(50) NOT NULL,
  `Kingston` varchar(50) NOT NULL,
  `Patriot Memory` varchar(50) NOT NULL,
  `Intel` varchar(40) NOT NULL,
  `Gigabyte` varchar(40) NOT NULL,
  `Asus` varchar(40) NOT NULL,
  `Zotac` varchar(50) NOT NULL,
  `Seagate` varchar(50) NOT NULL,
  `Toshiba` varchar(50) NOT NULL,
  `Western Digital` varchar(50) NOT NULL,
  `Netac` varchar(50) NOT NULL,
  `Silicon Power` varchar(50) NOT NULL,
  `AeroCool` varchar(50) NOT NULL,
  `Be quiet!` varchar(50) NOT NULL,
  `DEEPCOOL` varchar(50) NOT NULL,
  `ID-Cooling` varchar(50) NOT NULL,
  `Xilence` varchar(50) NOT NULL,
  `Zalman` varchar(50) NOT NULL,
  `Noctua` varchar(50) NOT NULL,
  `Therlmaltake` varchar(50) NOT NULL,
  `Arctic Cooling` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `type`
--

CREATE TABLE IF NOT EXISTS `type` (
  `Процессор` varchar(25) NOT NULL,
  `Видеокарта` varchar(25) NOT NULL,
  `Озу` varchar(25) NOT NULL,
  `Блок Питания` varchar(25) NOT NULL,
  `Ssd` varchar(25) NOT NULL,
  `Hdd` varchar(25) NOT NULL,
  `Материнская плата` varchar(25) NOT NULL,
  `Вентиляторы на корпус` varchar(25) NOT NULL,
  `Кулер(ЦП)` varchar(25) NOT NULL,
  `Водяное охлаждение` varchar(25) NOT NULL,
  `Корпуса` varchar(25) NOT NULL,
  `Термопаста` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `sde` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
