-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3307
-- Tiempo de generación: 12-03-2024 a las 18:33:29
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyectosube`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admins`
--

CREATE TABLE `admins` (
  `dni` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `email` varchar(75) NOT NULL,
  `password` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `admins`
--

INSERT INTO `admins` (`dni`, `name`, `lastname`, `email`, `password`) VALUES
(41709030, 'Ezequiel', 'Melo', 'ezequiel@hotmail.com', '1QoSZu5uduLxKxHm71AvLw=='),
(42645815, 'JuanPablo', 'Cortez', 'jpcortezzf@gmail.com', 'EuC4GX3h7noMT7wE66HbaA==');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoreclamo`
--

CREATE TABLE `estadoreclamo` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_swedish_ci;

--
-- Volcado de datos para la tabla `estadoreclamo`
--

INSERT INTO `estadoreclamo` (`id`, `name`) VALUES
(1, 'En Proceso'),
(2, 'En Revision'),
(3, 'Completado'),
(4, 'Rechazado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generos`
--

CREATE TABLE `generos` (
  `id` int(11) NOT NULL,
  `gender` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `generos`
--

INSERT INTO `generos` (`id`, `gender`) VALUES
(1, 'Masculino'),
(2, 'Femenino'),
(3, 'X');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lineas`
--

CREATE TABLE `lineas` (
  `id` int(11) NOT NULL,
  `line` varchar(15) NOT NULL,
  `idTransport` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `lineas`
--

INSERT INTO `lineas` (`id`, `line`, `idTransport`) VALUES
(1002, 'A', 2),
(1003, 'B', 2),
(1004, 'C', 2),
(1005, 'D', 2),
(1006, 'E', 2),
(1007, 'H', 2),
(1008, 'Belgrano Norte', 3),
(1009, 'Belgrano Sur', 3),
(1010, 'Mitre', 3),
(1011, 'Roca', 3),
(1012, 'Sarmiento', 3),
(1013, 'San Martin', 3),
(1014, 'Urquiza', 3),
(1015, 'Tren de la Cost', 3),
(1016, '1', 1),
(1017, '2', 1),
(1018, '4', 1),
(1019, '5', 1),
(1020, '105', 1),
(1021, '8', 1),
(1022, '86', 1),
(1023, '64', 1),
(1024, '152', 1),
(1025, '85', 1),
(1026, '166', 1),
(1027, '34', 1),
(1028, '106', 1),
(1029, '98', 1),
(1030, '95', 1),
(1031, '132', 1),
(1032, '12', 1),
(1033, '133', 1),
(1034, '53', 1),
(1035, '68', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pasajeros`
--

CREATE TABLE `pasajeros` (
  `dni` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `lastname` varchar(60) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` int(11) NOT NULL,
  `idGender` int(11) NOT NULL,
  `idSube` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `pasajeros`
--

INSERT INTO `pasajeros` (`dni`, `name`, `lastname`, `email`, `password`, `idGender`, `idSube`) VALUES
(12345678, 'Pepito', 'Peposo', 'pepitopeposo@gmail.com', 1234, 1, '6061564552464636'),
(22222222, 'Pepe', 'Peposo', 'pepe@hotmail.com', 1234, 1, '6061349545743453'),
(22222226, 'joser', 'alberto', 'elAlbert@gmail.com', 1234, 1, NULL),
(33202790, 'Alejandro', 'Heidenreich', 'AleHardcode@gmail.com', 2790, 1, '6061387460072827'),
(34562352, 'Eleze', 'melox', 'elezex@gmail.com', 1234, 1, '6061345323526346'),
(39534636, 'Melissa', 'Montes', 'lamelidelugano@hotmail.com', 1234, 2, '6061756756756675'),
(41709030, 'Ezequiel', 'Melo', 'eze@hotmail.com', 9272, 1, '6061246811847221'),
(42000000, 'Melanie', 'Cardaci', 'lamelanie@gmail.com', 9010, 2, '6061484522542901'),
(44467456, 'Nomenclatura', 'Dictadura', 'nomdic@hotmail.com', 1234, 3, '6061647434634574'),
(46453245, 'Melina', 'Lezcano', 'Lamelilez@hotmail.com', 4322, 2, '6061326326582345'),
(54234635, 'Juampalit', 'Lit', 'lit@juan.com', 1234, 1, '6061435223526363'),
(54322352, 'Tobias', 'Chambi', 'eltobi@gmail.com', 4321, 1, '6061463377655757'),
(55352344, 'Melina', 'Garcia', '123@meli.com', 1234, 2, '6061346621651556');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarifassociales`
--

CREATE TABLE `tarifassociales` (
  `id` int(11) NOT NULL,
  `rate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `tarifassociales`
--

INSERT INTO `tarifassociales` (`id`, `rate`) VALUES
(1, 'Ninguna'),
(2, 'Jubilado'),
(3, 'Estudiantil'),
(4, 'ExCombatienteDeMalvinas'),
(5, 'Discapacitado'),
(6, 'SinSubsidio'),
(10, 'Gold');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarjetas`
--

CREATE TABLE `tarjetas` (
  `id` varchar(16) NOT NULL,
  `balance` float NOT NULL,
  `socialRate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `tarjetas`
--

INSERT INTO `tarjetas` (`id`, `balance`, `socialRate`) VALUES
('6061100022881911', 0, 2),
('6061103047609000', 100, 2),
('6061246811847221', 410, 1),
('6061326326582345', 0, 2),
('6061345323526346', -122.54, 2),
('6061346621651542', 420, 2),
('6061346621651556', 200, 2),
('6061349545743453', 1020, 1),
('6061387460072827', 158.567, 1),
('6061435223526363', 0, 2),
('6061463377655757', -59, 2),
('6061484522542901', 0, 2),
('6061564552464636', 4771, 2),
('6061629241969133', 0, 2),
('6061647434634574', -122.54, 2),
('6061667144098575', 0, 2),
('6061756756756675', 0, 2),
('6061911912738398', 0, 2),
('6061938623643349', 0, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tramites`
--

CREATE TABLE `tramites` (
  `idClaim` int(11) NOT NULL,
  `dniClaimer` int(11) NOT NULL,
  `claimMessage` varchar(140) NOT NULL,
  `claimTime` datetime NOT NULL,
  `idClaimStatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_swedish_ci;

--
-- Volcado de datos para la tabla `tramites`
--

INSERT INTO `tramites` (`idClaim`, `dniClaimer`, `claimMessage`, `claimTime`, `idClaimStatus`) VALUES
(10001, 33202790, 'Reclamo:Jubilado  DAle loco', '2023-11-19 01:29:52', 3),
(10002, 33202790, 'Reclamo: Jubilado  Mira, yo ya toy grande mi nieto me dijo que por aca puedo pedir que me pasen a jubilado, Gracias', '2023-11-19 23:02:52', 3),
(10003, 33202790, 'Reclamo: Estudiantil  Me equivoque', '2023-11-19 23:05:04', 3),
(10004, 33202790, 'Reclamo: Estudiantil  Ahora la sube la usa mi hijo me lo cambias porfi', '2023-11-19 23:29:14', 4),
(10005, 33202790, 'Reclamo: Discapacitado  Soy Disca', '2023-11-20 17:39:44', 3),
(10010, 33202790, 'Reclamo: Jubilado  Soy jubi', '2023-11-20 17:44:49', 3),
(10011, 33202790, 'Reclamo: Perdida  man robao', '2023-11-20 17:45:27', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transportes`
--

CREATE TABLE `transportes` (
  `id` int(11) NOT NULL,
  `transport` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `transportes`
--

INSERT INTO `transportes` (`id`, `transport`) VALUES
(1, 'Colectivo'),
(2, 'Subte'),
(3, 'Tren');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `viajes`
--

CREATE TABLE `viajes` (
  `idTravel` int(11) NOT NULL,
  `idCard` varchar(16) NOT NULL,
  `idTransport` int(11) NOT NULL,
  `idLine` int(11) NOT NULL,
  `idSocialRate` int(11) NOT NULL,
  `ticketCost` float NOT NULL,
  `kilometres` float NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `viajes`
--

INSERT INTO `viajes` (`idTravel`, `idCard`, `idTransport`, `idLine`, `idSocialRate`, `ticketCost`, `kilometres`, `date`) VALUES
(1000, '6061103047609000', 1, 1025, 4, 59, 4, '0000-00-00 00:00:00'),
(1001, '6061345323526346', 1, 1025, 1, 59, 6, '2023-11-18 21:17:28'),
(1005, '6061564552464636', 1, 1020, 1, 59, 6, '2023-11-18 23:48:12'),
(1006, '6061564552464636', 2, 1002, 1, 80, 3, '2023-11-18 23:55:10'),
(1007, '6061564552464636', 3, 1009, 1, 90, 15, '2023-11-18 23:56:43'),
(1008, '6061387460072827', 1, 1020, 1, 59, 6, '2023-11-19 22:59:09'),
(1009, '6061387460072827', 3, 1013, 1, 90, 12, '2023-11-19 22:59:19'),
(1010, '6061387460072827', 2, 1007, 1, 80, 4, '2023-11-19 23:00:32'),
(1011, '6061387460072827', 1, 1022, 1, 59, 5, '2023-11-19 23:00:42'),
(1012, '6061387460072827', 1, 1034, 2, 32.45, 6, '2023-11-20 17:37:51'),
(1019, '6061387460072827', 3, 1010, 1, 90, 5252, '2023-11-20 18:55:09'),
(1021, '6061387460072827', 3, 1010, 2, 49.5, 6756, '2023-11-21 17:56:39'),
(1022, '6061387460072827', 2, 1004, 2, 44, 7, '2023-11-21 18:37:05'),
(1024, '6061387460072827', 2, 1004, 2, 44, 7, '2023-11-21 18:38:39'),
(1025, '6061387460072827', 2, 1004, 2, 44, 6, '2023-11-21 18:38:59'),
(1026, '6061387460072827', 2, 1006, 2, 44, 6, '2023-11-21 18:39:07'),
(1028, '6061349545743453', 3, 1011, 1, 90, 0, '2023-11-22 16:07:15'),
(1029, '6061387460072827', 1, 1021, 2, 34.947, 7, '2023-11-23 01:53:48'),
(1030, '6061387460072827', 1, 1019, 2, 32.45, 5, '2023-11-23 01:56:44'),
(1031, '6061387460072827', 1, 1017, 2, 29.128, 8, '2023-11-23 02:44:48'),
(1032, '6061387460072827', 2, 1004, 2, 44, 26, '2023-11-23 03:12:52'),
(1033, '6061387460072827', 2, 1004, 2, 44, 4, '2023-11-23 03:24:29'),
(1034, '6061387460072827', 2, 1004, 2, 44, 5, '2023-11-23 03:25:27'),
(1035, '6061387460072827', 3, 1009, 2, 49.5, 5, '2023-11-23 03:27:07'),
(1036, '6061387460072827', 2, 1002, 2, 44, 5, '2023-11-23 03:27:50'),
(1037, '6061387460072827', 1, 1027, 2, 29.128, 4, '2023-11-23 03:34:01'),
(1038, '6061387460072827', 3, 1010, 2, 0, 9, '2023-11-26 17:28:28'),
(1039, '6061387460072827', 2, 1003, 10, 80, 9, '2023-11-26 17:30:02'),
(1040, '6061387460072827', 1, 1018, 10, 0, 3, '2023-11-26 17:31:04'),
(1041, '6061387460072827', 1, 1018, 10, 52.96, 3, '2023-11-26 17:31:50'),
(1042, '6061387460072827', 1, 1018, 1, 0, 3, '2023-11-26 17:38:28'),
(1043, '6061387460072827', 3, 1010, 1, 0, 3, '2023-11-26 17:40:01');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `estadoreclamo`
--
ALTER TABLE `estadoreclamo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `generos`
--
ALTER TABLE `generos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `lineas`
--
ALTER TABLE `lineas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idTransport` (`idTransport`);

--
-- Indices de la tabla `pasajeros`
--
ALTER TABLE `pasajeros`
  ADD PRIMARY KEY (`dni`),
  ADD KEY `idGender` (`idGender`),
  ADD KEY `idSube` (`idSube`),
  ADD KEY `idGender_2` (`idGender`);

--
-- Indices de la tabla `tarifassociales`
--
ALTER TABLE `tarifassociales`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tarjetas`
--
ALTER TABLE `tarjetas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tarifaSocial` (`socialRate`),
  ADD KEY `id` (`id`);

--
-- Indices de la tabla `tramites`
--
ALTER TABLE `tramites`
  ADD PRIMARY KEY (`idClaim`),
  ADD KEY `idClaimStatus` (`idClaimStatus`),
  ADD KEY `dniClaimer` (`dniClaimer`);

--
-- Indices de la tabla `transportes`
--
ALTER TABLE `transportes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `viajes`
--
ALTER TABLE `viajes`
  ADD PRIMARY KEY (`idTravel`),
  ADD KEY `idTransport` (`idTransport`),
  ADD KEY `idLine` (`idLine`),
  ADD KEY `idTarifaSocial` (`idSocialRate`),
  ADD KEY `idSocialRate` (`idSocialRate`),
  ADD KEY `idCard` (`idCard`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `lineas`
--
ALTER TABLE `lineas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1036;

--
-- AUTO_INCREMENT de la tabla `tramites`
--
ALTER TABLE `tramites`
  MODIFY `idClaim` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10012;

--
-- AUTO_INCREMENT de la tabla `viajes`
--
ALTER TABLE `viajes`
  MODIFY `idTravel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1044;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `lineas`
--
ALTER TABLE `lineas`
  ADD CONSTRAINT `lineas_ibfk_1` FOREIGN KEY (`idTransport`) REFERENCES `transportes` (`id`);

--
-- Filtros para la tabla `pasajeros`
--
ALTER TABLE `pasajeros`
  ADD CONSTRAINT `pasajeros_ibfk_1` FOREIGN KEY (`idGender`) REFERENCES `generos` (`id`),
  ADD CONSTRAINT `pasajeros_ibfk_2` FOREIGN KEY (`idSube`) REFERENCES `tarjetas` (`id`);

--
-- Filtros para la tabla `tarjetas`
--
ALTER TABLE `tarjetas`
  ADD CONSTRAINT `tarjetas_ibfk_2` FOREIGN KEY (`socialRate`) REFERENCES `tarifassociales` (`id`);

--
-- Filtros para la tabla `tramites`
--
ALTER TABLE `tramites`
  ADD CONSTRAINT `tramites_ibfk_1` FOREIGN KEY (`idClaimStatus`) REFERENCES `estadoreclamo` (`id`),
  ADD CONSTRAINT `tramites_ibfk_2` FOREIGN KEY (`dniClaimer`) REFERENCES `pasajeros` (`dni`);

--
-- Filtros para la tabla `viajes`
--
ALTER TABLE `viajes`
  ADD CONSTRAINT `viajes_ibfk_1` FOREIGN KEY (`idLine`) REFERENCES `lineas` (`id`),
  ADD CONSTRAINT `viajes_ibfk_2` FOREIGN KEY (`idTransport`) REFERENCES `transportes` (`id`),
  ADD CONSTRAINT `viajes_ibfk_3` FOREIGN KEY (`idCard`) REFERENCES `tarjetas` (`id`),
  ADD CONSTRAINT `viajes_ibfk_4` FOREIGN KEY (`idSocialRate`) REFERENCES `tarifassociales` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
