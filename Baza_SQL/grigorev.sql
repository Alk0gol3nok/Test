-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 22 2021 г., 09:37
-- Версия сервера: 8.0.19
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `grigorev`
--

-- --------------------------------------------------------

--
-- Структура таблицы `application`
--

CREATE TABLE `application` (
  `id` int UNSIGNED NOT NULL,
  `login` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'login',
  `Fullname` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'FUllname',
  `date_p` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'date_p',
  `number` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'number',
  `Dob` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Dob',
  `Pob` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Pob',
  `otziv` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'otziv'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `application`
--

INSERT INTO `application` (`id`, `login`, `Fullname`, `date_p`, `number`, `Dob`, `Pob`, `otziv`) VALUES
(6, 'Test', 'test test test', '03.11.2021', '654654645', '06.11.2001', 'SPB', ''),
(10, 'gfdgfd', 'gfdgdf', 'gfdgfd', 'gfdgdfg', 'gfdgfd', 'gfdgfd', ''),
(11, 'hgfhgf', 'hgfhgf', 'hgfhfg', 'hgfhgf', 'hgfhgfh', 'hgfhgfhgf', 'hgfhgfhgfhgfh');

-- --------------------------------------------------------

--
-- Структура таблицы `application_seal`
--

CREATE TABLE `application_seal` (
  `id` int UNSIGNED NOT NULL,
  `type_app` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `login` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Fullname` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `date_p` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `number` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Dob` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Pob` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `date_y` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `employees`
--

CREATE TABLE `employees` (
  `id` int UNSIGNED NOT NULL,
  `login` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'login',
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'password',
  `Fullname` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Fullname',
  `Dob` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Dob',
  `Pob` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Pob',
  `PhoneNumber` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `role` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `employees`
--

INSERT INTO `employees` (`id`, `login`, `password`, `Fullname`, `Dob`, `Pob`, `PhoneNumber`, `role`) VALUES
(6, 'Test', '123', 'Test Test', '06.11.2001', 'SPB', '6757655', 'бухгалтер'),
(7, 'test123', '2131', 'bgfdgfd', '06.12.2002', 'gfdgfdg', '5435435643', 'бухгалтер'),
(8, 'Test55', '123', 'test', '06.11.2001', 'SPB', '6546546456', 'менеджер');

-- --------------------------------------------------------

--
-- Структура таблицы `enduro_bank`
--

CREATE TABLE `enduro_bank` (
  `id` int UNSIGNED NOT NULL,
  `type_model` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'type_model',
  `model` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'model',
  `dvigatel` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'dvigatel',
  `moshnost` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'moshnost',
  `max_skr` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'max_skr',
  `kpp` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'kpp',
  `money` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'money'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `enduro_bank`
--

INSERT INTO `enduro_bank` (`id`, `type_model`, `model`, `dvigatel`, `moshnost`, `max_skr`, `kpp`, `money`) VALUES
(1, 'KAYO', 'KAYO-511', '599 см3', '99 л.с. при 11500 об/мин', '238 км/ч', 'Механическая(цепь)', '720тыс/руб'),
(2, 'KAYO', 'KAYO-400', '399 см3', '59 л.с. при 12000 об/мин', '200 км/ч', 'Механическая(цепь)', '630 тыс/руб'),
(3, 'KAYO', 'KAYO-GSX-R', '398 см3', '59 л.с. при 12500 об/мин', '200 км/ч', 'Механическая(цепь)', '510 тыс/руб');

-- --------------------------------------------------------

--
-- Структура таблицы `equip_bank`
--

CREATE TABLE `equip_bank` (
  `id` int UNSIGNED NOT NULL,
  `type_model` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'type_model',
  `model` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'model',
  `ohlajdenie` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'ohlajdenie',
  `vizor` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'vizor',
  `shtorka` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'shtorka',
  `bezopasnost` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'bezopasnost',
  `money` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'money'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `equip_bank`
--

INSERT INTO `equip_bank` (`id`, `type_model`, `model`, `ohlajdenie`, `vizor`, `shtorka`, `bezopasnost`, `money`) VALUES
(1, 'AirForm', 'AirForm-Batt2', 'Двухканальное', 'Солнцезащитный', 'Подбородочная', '7/10', '12 тыс/руб'),
(2, 'AirForm', 'AirForm-SK22', ' Одноканальное', 'Быстросъемный', 'Подбородочная', '5/10', '6 тыс/руб'),
(3, 'AirForm', 'AirForm-RR-TYPE-S', 'Пятиканальное', 'Поликарбонатный', 'Подбородочная', '10/10', '38 тыс/руб');

-- --------------------------------------------------------

--
-- Структура таблицы `pokypki`
--

CREATE TABLE `pokypki` (
  `model` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'model',
  `money` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'money',
  `login` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'login',
  `fio` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'fio',
  `number` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'number',
  `address` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'address'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `pokypki`
--

INSERT INTO `pokypki` (`model`, `money`, `login`, `fio`, `number`, `address`) VALUES
('', '', '', '', '', ''),
('Yamaha R3', '600тыс/руб', 'gfdg', 'gfdgfd', 'gdfgfd', 'gdfgdf'),
('Yamaha R3', '600тыс/руб', 'gfdg', 'gfdgfd', 'gdfgfd', 'gdfgdf');

-- --------------------------------------------------------

--
-- Структура таблицы `sport_bank`
--

CREATE TABLE `sport_bank` (
  `id` int UNSIGNED NOT NULL,
  `type_model` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'type_model',
  `model` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'model',
  `dvigatel` varchar(70) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'dvigatel',
  `moshnost` varchar(70) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'moshnost',
  `max_skr` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'max_skr',
  `kpp` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'kpp',
  `money` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'money'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sport_bank`
--

INSERT INTO `sport_bank` (`id`, `type_model`, `model`, `dvigatel`, `moshnost`, `max_skr`, `kpp`, `money`) VALUES
(1, 'Yamaha', 'Yamaha R3', '321 см3', '42 л.с. при 10750 об/мин', '180 км/ч', 'Механическая (цепная)', '600тыс/руб'),
(2, 'Yamaha', 'Yamaha TZR', '49,7 см3', '2,7 л.с. при 6250 об/мин', '90 км/ч', 'Механическая(цепная)', '150тыс/руб'),
(3, 'Yamaha', 'Yamaha YZF', '124,7 см3', '15 л.с. при 9000 об/мин', '120 км/ч', 'Механическая(цепная)', '300тыс/руб');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int UNSIGNED NOT NULL,
  `login` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'login',
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'password',
  `Fullname` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Fullname',
  `Dob` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Dob',
  `Pob` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Pob',
  `PhoneNumber` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'PhoneNumber',
  `role` text NOT NULL,
  `metka` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'us'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `Fullname`, `Dob`, `Pob`, `PhoneNumber`, `role`, `metka`) VALUES
(66, 'Cheb', '123', 'Cheb Cheb Cheb', '2001.22.08', 'SPB', '785643965', 'пользователь', 'us'),
(61, 'Alex', '123', 'fdgfdgfd', '06.12.2002', 'gfdgfdgfd', '5643654', 'админ', 'sub'),
(67, 'Loger', '123', 'Loger Loger Loger', '2002.22.06', 'SPB', '76578654564', 'пользователь', 'us'),
(62, 'Alex123', '12345', 'Alex Alex', '06.11.2001', 'SPB', '7931017683', 'пользователь', 'us'),
(63, 'Alex11', '12345', 'Alex Alex', '06.11.2001', 'SPB', '793110176833', 'пользователь', 'us'),
(64, 'Alex1232123', '123', 'Alex Alex', '06.11.2001', 'SPB', '79311017683', 'пользователь', 'us'),
(65, 'Bob45', 'bob123', 'Bob Bob', '06.06.2006', 'SPB', '789454', 'пользователь', 'us');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `application`
--
ALTER TABLE `application`
  ADD UNIQUE KEY `id_application` (`id`);

--
-- Индексы таблицы `application_seal`
--
ALTER TABLE `application_seal`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `enduro_bank`
--
ALTER TABLE `enduro_bank`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `equip_bank`
--
ALTER TABLE `equip_bank`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `sport_bank`
--
ALTER TABLE `sport_bank`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `application`
--
ALTER TABLE `application`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `application_seal`
--
ALTER TABLE `application_seal`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT для таблицы `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `enduro_bank`
--
ALTER TABLE `enduro_bank`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `equip_bank`
--
ALTER TABLE `equip_bank`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `sport_bank`
--
ALTER TABLE `sport_bank`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
