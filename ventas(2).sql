-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 26-02-2025 a las 01:36:30
-- Versión del servidor: 5.7.15-log
-- Versión de PHP: 5.6.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ventas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `apellido` text NOT NULL,
  `nombre` text NOT NULL,
  `direccion` text NOT NULL,
  `cuit` text NOT NULL,
  `telefono` text NOT NULL,
  `estado` text NOT NULL,
  `habilita_cta` text NOT NULL,
  `relacion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `apellido`, `nombre`, `direccion`, `cuit`, `telefono`, `estado`, `habilita_cta`, `relacion`) VALUES
(1, 'LUCYK', 'ALEXIS WALDEMAR', 'AV. SAN MARTIN 678', '20320743339', '3491438555', 'ACTIVO', 'SI', 'CLIENTE'),
(2, 'URBAN', 'YOHANA ADELIN', 'AV SAN MARTIN 678', '23317411804', '3491689203', 'ACTIVO', 'NO', 'PROVEEDOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras`
--

CREATE TABLE `compras` (
  `id` int(30) NOT NULL,
  `cod_proveedor` int(30) NOT NULL,
  `cond_pago` text NOT NULL,
  `documento` text NOT NULL,
  `n_documento` text NOT NULL,
  `total_compra` double NOT NULL,
  `fecha_compra` date NOT NULL,
  `fecha_operacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `compras`
--

INSERT INTO `compras` (`id`, `cod_proveedor`, `cond_pago`, `documento`, `n_documento`, `total_compra`, `fecha_compra`, `fecha_operacion`) VALUES
(2, 1, 'Contado', 'Factura', '213', 111.002, '2024-07-09', '2024-07-22 00:00:00'),
(3, 1, 'Contado', 'Factura', '214', 62302.3, '2024-07-10', '2024-07-22 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_detalle`
--

CREATE TABLE `compras_detalle` (
  `cod_prod` text NOT NULL,
  `descripcion` text NOT NULL,
  `cant` double NOT NULL,
  `p_unit` double NOT NULL,
  `total` double NOT NULL,
  `n_documento` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `compras_detalle`
--

INSERT INTO `compras_detalle` (`cod_prod`, `descripcion`, `cant`, `p_unit`, `total`, `n_documento`, `fecha`) VALUES
('4005900980366', 'CREMA NIVEA DERMA CARE REPAR. HIPOALERGENICA X 400ML', 10, 4800, 48002, 213, '2024-07-09'),
('7500435206617', 'SHAMPOO HEAD & SHOULDERS MEN OLD SPICE X 375 ML', 10, 6300, 63000, 213, '2024-07-09'),
('4005900980366', 'CREMA NIVEA DERMA CARE REPAR. HIPOALERGENICA X 400ML', 5, 4900, 24.502, 214, '2024-07-10'),
('7500435206617', 'SHAMPOO HEAD & SHOULDERS MEN OLD SPICE X 375 ML', 6, 6300, 37.8, 214, '2024-07-10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctacte`
--

CREATE TABLE `ctacte` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `movimiento` text NOT NULL,
  `n_documento` text NOT NULL,
  `debe` int(11) NOT NULL,
  `haber` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ctacte`
--

INSERT INTO `ctacte` (`id`, `id_cliente`, `movimiento`, `n_documento`, `debe`, `haber`, `fecha`) VALUES
(1, 1, 'FACTURA', '1', -3600, 0, '2025-01-26'),
(2, 1, 'FACTURA', '2', -11408, 0, '2025-01-26'),
(3, 1, 'FACTURA', '3', -11408, 0, '2025-01-26');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `cod_prod` text CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcion` text CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci NOT NULL,
  `p_compra` double NOT NULL,
  `p_venta` double NOT NULL,
  `stock` double NOT NULL,
  `fecha_ult_compra` date NOT NULL,
  `rubro` text CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci NOT NULL,
  `proveedor` text CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `cod_prod`, `descripcion`, `p_compra`, `p_venta`, `stock`, `fecha_ult_compra`, `rubro`, `proveedor`) VALUES
(1, '4005900980366', 'CREMA NIVEA DERMA CARE REPAR. HIPOALERGENICA X 400ML', 4900.46, 4800.23, 18, '2024-07-10', 'FARMACIA', 'NIVEA ARGENTINA S.A.'),
(2, '7500435206617', 'SHAMPOO HEAD & SHOULDERS MEN OLD SPICE X 375 ML', 6300, 6300, 18, '2024-07-10', 'FARMACIA', 'PG ARGENTINA S.A.'),
(3, '7798318370511', 'GOMA BLANCA GRANDE', 230, 460, 3, '2024-02-13', 'Utiles', 'Murad'),
(4, '7790400030457', 'Adhesivo Eccole x 9Grs', 320, 623, 6, '2024-02-01', 'ADHESIVOS', 'ECCOLE SRL'),
(5, '7798184683029', 'AROMATIZANTE AEROSOL BAMBOO X 280CC', 632.03, 950.65, 28, '2024-02-12', 'LIMPIEZA', 'AMBAR SRL'),
(6, '7793046007715', 'MERMELADA DULCOR CORMILLOT DURAZNO X 390GRS', 360.32, 1200.98, 50, '2024-07-08', 'ALIMENTOS', 'Alexis W. Lucyk Sistemas'),
(7, '7790628000133', 'GALLETITAS MAURI SALVADO X 400GRS', 306, 688, 88, '2024-07-08', 'ALIMENTOS', 'Alexis W. Lucyk Sistemas'),
(8, '7622201745561', 'GALLETITAS TERRABUSI DIVERSION X 400 GRS', 306.32, 542.99, 30, '2024-07-08', 'FARMACIA', 'Alexis W. Lucyk Sistemas'),
(9, '123456', 'PROD 1', 100, 300, -25, '2025-01-24', 'PERFUMERIAS', 'Alexis W. Lucyk Sistemas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `cod_prov` int(11) NOT NULL,
  `razon` text NOT NULL,
  `cuit` text NOT NULL,
  `telefono` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`cod_prov`, `razon`, `cuit`, `telefono`) VALUES
(1, 'LUCYK ALEXIS WALDEMAR', '20320743339', '3491438555'),
(2, 'URBAN YOHANA ADELIN', '23317411804', '3491689203');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rubros`
--

CREATE TABLE `rubros` (
  `id` int(11) NOT NULL,
  `nombre` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `rubros`
--

INSERT INTO `rubros` (`id`, `nombre`) VALUES
(1, 'FARMACIA'),
(2, 'PERFUMERIAS'),
(3, 'INFORMATICA'),
(4, 'LIBRERIA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `usr` text NOT NULL,
  `pwd` text NOT NULL,
  `descripcion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usr`, `pwd`, `descripcion`) VALUES
(1, 'alucyk', 'isidoro9', 'Developer');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(30) NOT NULL,
  `id_cliente` int(30) NOT NULL,
  `cond_pago` text NOT NULL,
  `n_documento` text NOT NULL,
  `total_venta` double NOT NULL,
  `fecha_venta` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id`, `id_cliente`, `cond_pago`, `n_documento`, `total_venta`, `fecha_venta`) VALUES
(1, 0, '0', '0', 0, '1980-01-01'),
(2, 1, 'CUENTA CORRIENTE', '1', 3600, '2025-01-26'),
(4, 1, 'CUENTA CORRIENTE', '2', 11407.8, '2025-01-26'),
(5, 1, 'CUENTA CORRIENTE', '3', 11407.8, '2025-01-26');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

CREATE TABLE `ventas_detalle` (
  `id` int(11) NOT NULL,
  `cod_prod` text NOT NULL,
  `descripcion` text NOT NULL,
  `cant` double NOT NULL,
  `p_unit` double NOT NULL,
  `total` double NOT NULL,
  `n_documento` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas_detalle`
--

INSERT INTO `ventas_detalle` (`id`, `cod_prod`, `descripcion`, `cant`, `p_unit`, `total`, `n_documento`, `fecha`) VALUES
(1, '123456', 'PROD 1', 12, 300, 3600, 1, '2025-01-26'),
(3, '7798184683029', 'AROMATIZANTE AEROSOL BAMBOO X 280CC', 12, 950, 11407.8, 2, '2025-01-26'),
(4, '7798184683029', 'AROMATIZANTE AEROSOL BAMBOO X 280CC', 12, 950, 11407.8, 3, '2025-01-26');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `compras`
--
ALTER TABLE `compras`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ctacte`
--
ALTER TABLE `ctacte`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ctacte`
--
ALTER TABLE `ctacte`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
