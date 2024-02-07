-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         5.5.40 - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para ahorcado
CREATE DATABASE IF NOT EXISTS `ahorcado` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_spanish_ci */;
USE `ahorcado`;

-- Volcando estructura para tabla ahorcado.categorias
CREATE TABLE IF NOT EXISTS `categorias` (
  `Categoria` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Dificultad` int(11) DEFAULT NULL,
  PRIMARY KEY (`Categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla ahorcado.categorias: ~6 rows (aproximadamente)
DELETE FROM `categorias`;
INSERT INTO `categorias` (`Categoria`, `Dificultad`) VALUES
	('Animales', 3),
	('Ciudades', 4),
	('Comida', 3),
	('Deportes', 3),
	('Paises', 2),
	('Prueba', 4);

-- Volcando estructura para tabla ahorcado.informacion
CREATE TABLE IF NOT EXISTS `informacion` (
  `IDPartida` int(10) unsigned NOT NULL,
  `Jugador` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Fecha` date DEFAULT NULL,
  `Ganado` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDPartida`) USING BTREE,
  KEY `FK_informacion_usuarios` (`Jugador`),
  CONSTRAINT `FK_informacion_usuarios` FOREIGN KEY (`Jugador`) REFERENCES `usuarios` (`Usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla ahorcado.informacion: ~1 rows (aproximadamente)
DELETE FROM `informacion`;
INSERT INTO `informacion` (`IDPartida`, `Jugador`, `Fecha`, `Ganado`) VALUES
	(0, 'Dani', '2024-02-07', 0);

-- Volcando estructura para tabla ahorcado.palabras
CREATE TABLE IF NOT EXISTS `palabras` (
  `Palabra` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Longitud` int(11) DEFAULT NULL,
  `Categoria` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Palabra`),
  KEY `FK_palabras_categorias` (`Categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla ahorcado.palabras: ~84 rows (aproximadamente)
DELETE FROM `palabras`;
INSERT INTO `palabras` (`Palabra`, `Longitud`, `Categoria`) VALUES
	('Alemania', 7, 'Paises'),
	('Araña', 5, 'Animales'),
	('Argentina', 9, 'Paises'),
	('Arroz', 4, 'Comida'),
	('Asado', 5, 'Comida'),
	('Atletismo', 8, 'Deportes'),
	('Australia', 9, 'Paises'),
	('Badmington', 10, 'Deportes'),
	('Ballena', 7, 'Animales'),
	('Baloncesto', 10, 'Deportes'),
	('Barcelona', 8, 'Ciudades'),
	('Baseball', 8, 'Deportes'),
	('Bilbao', 6, 'Ciudades'),
	('Boxeo', 5, 'Deportes'),
	('Brasil', 6, 'Paises'),
	('Caballo', 7, 'Animales'),
	('Canada', 6, 'Paises'),
	('Canguro', 7, 'Animales'),
	('Cebra', 5, 'Animales'),
	('Ceviche', 7, 'Comida'),
	('Chimpancé', 8, 'Animales'),
	('China', 5, 'Paises'),
	('Ciclismo', 8, 'Deportes'),
	('Conejo', 6, 'Animales'),
	('Curry', 5, 'Comida'),
	('Cádiz', 5, 'Ciudades'),
	('Delfín', 6, 'Animales'),
	('Elefante', 8, 'Animales'),
	('Ensalada', 7, 'Comida'),
	('Espagueti', 9, 'Comida'),
	('España', 6, 'Paises'),
	('Estados Unidos', 14, 'Paises'),
	('Francia', 7, 'Paises'),
	('Futbol', 6, 'Deportes'),
	('Gato', 4, 'Animales'),
	('Golf', 4, 'Deportes'),
	('Gorila', 6, 'Animales'),
	('Granada', 7, 'Ciudades'),
	('Hamburguesa', 10, 'Comida'),
	('Hipopótamo', 9, 'Animales'),
	('Hockey', 6, 'Deportes'),
	('Huelva', 6, 'Ciudades'),
	('India', 5, 'Paises'),
	('Italia', 5, 'Paises'),
	('Japón', 4, 'Paises'),
	('Jirafa', 6, 'Animales'),
	('Koala', 5, 'Animales'),
	('Lagarto', 7, 'Animales'),
	('Lasaña', 6, 'Comida'),
	('León', 4, 'Animales'),
	('Lugo', 4, 'Ciudades'),
	('Madrid', 6, 'Ciudades'),
	('Malaga', 5, 'Ciudades'),
	('Mexico', 5, 'Paises'),
	('Natación', 7, 'Deportes'),
	('Nutria', 6, 'Animales'),
	('Ornitorrinco', 12, 'Animales'),
	('Oso', 3, 'Animales'),
	('Padel', 5, 'Deportes'),
	('Paella', 6, 'Comida'),
	('Pajaro', 6, 'Animales'),
	('Patatas', 7, 'Comida'),
	('Pato', 4, 'Animales'),
	('Perro', 5, 'Animales'),
	('Pez payaso', 11, 'Animales'),
	('Pizza', 5, 'Comida'),
	('Prueba', 6, 'Prueba'),
	('Rinoceronte', 11, 'Animales'),
	('Rugby', 5, 'Deportes'),
	('Rusia', 5, 'Paises'),
	('Santander', 9, 'Ciudades'),
	('Serpiente', 8, 'Animales'),
	('Sevilla', 7, 'Ciudades'),
	('Sushi', 4, 'Comida'),
	('Tacos', 5, 'Comida'),
	('Tenis', 5, 'Deportes'),
	('Teruel', 6, 'Ciudades'),
	('Tigre', 5, 'Animales'),
	('Toledo', 6, 'Ciudades'),
	('Tortilla', 8, 'Comida'),
	('Valencia', 8, 'Ciudades'),
	('Voleibol', 8, 'Deportes'),
	('Zaragoza', 7, 'Ciudades'),
	('Zorro', 5, 'Animales');

-- Volcando estructura para tabla ahorcado.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Usuario` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Contrasena` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Admin` int(11) DEFAULT NULL,
  `Puntuacion` int(11) DEFAULT NULL,
  PRIMARY KEY (`Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla ahorcado.usuarios: ~2 rows (aproximadamente)
DELETE FROM `usuarios`;
INSERT INTO `usuarios` (`Usuario`, `Contrasena`, `Admin`, `Puntuacion`) VALUES
	('Aletornado', 'Aletornado', 0, 500),
	('Dani', 'Regames', 1, 500);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
