-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 15, 2017 at 05:56 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cpgm`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account_ledger`
--

CREATE TABLE `tbl_account_ledger` (
  `account_id` varchar(500) NOT NULL,
  `business_name` varchar(500) NOT NULL,
  `registered_owner` varchar(500) NOT NULL,
  `address` varchar(500) NOT NULL,
  `contact_number` varchar(500) NOT NULL,
  `local_code` varchar(500) NOT NULL,
  `term` varchar(500) NOT NULL,
  `total_sales` decimal(65,2) NOT NULL,
  `total_payments` decimal(65,2) NOT NULL,
  `balance` decimal(65,2) NOT NULL,
  `remarks` varchar(500) NOT NULL,
  `due_account_to_date` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `username` varchar(500) NOT NULL,
  `password` varchar(500) NOT NULL,
  `account_type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_bir_sales`
--

CREATE TABLE `tbl_bir_sales` (
  `m_code` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `or_number` varchar(500) NOT NULL,
  `customer_name` varchar(500) NOT NULL,
  `description` varchar(500) NOT NULL,
  `sales_vat_inclusive` decimal(65,2) NOT NULL,
  `less_vat` decimal(65,2) NOT NULL,
  `net_vat` decimal(65,2) NOT NULL,
  `discount` varchar(100) NOT NULL,
  `amount_due` decimal(65,2) NOT NULL,
  `addvat` decimal(65,2) NOT NULL,
  `total_amount_due` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dodge_sales`
--

CREATE TABLE `tbl_dodge_sales` (
  `year_code` varchar(500) NOT NULL,
  `date` varchar(500) NOT NULL,
  `or_number` varchar(500) NOT NULL,
  `customer_name` varchar(500) NOT NULL,
  `description` varchar(500) NOT NULL,
  `cash_sales` decimal(65,2) NOT NULL,
  `cash_vat` decimal(65,2) NOT NULL,
  `creditable_expense_amount` decimal(65,2) NOT NULL,
  `creditable_expense_vat` decimal(65,2) NOT NULL,
  `total` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_monthly_monitoring`
--

CREATE TABLE `tbl_monthly_monitoring` (
  `month` varchar(500) NOT NULL,
  `charge_account` decimal(65,2) NOT NULL,
  `payment` decimal(65,2) NOT NULL,
  `percent_ratio` varchar(500) NOT NULL,
  `balance` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchase_order`
--

CREATE TABLE `tbl_purchase_order` (
  `product_id` varchar(100) NOT NULL,
  `dr` varchar(100) NOT NULL,
  `supplier` varchar(100) NOT NULL,
  `receipt_delivery_date` varchar(100) NOT NULL,
  `arrival_date` varchar(100) NOT NULL,
  `remark_days_def` varchar(100) NOT NULL,
  `description` varchar(100) NOT NULL,
  `brand` varchar(100) NOT NULL,
  `model` varchar(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `unit` varchar(100) NOT NULL,
  `unit_cost` decimal(65,2) NOT NULL,
  `discount` varchar(100) NOT NULL,
  `net_cost` decimal(65,2) NOT NULL,
  `total_amount` decimal(65,2) NOT NULL,
  `margin` varchar(100) NOT NULL,
  `suggested_price` decimal(65,2) NOT NULL,
  `canvass_price` decimal(65,2) NOT NULL,
  `term` varchar(100) NOT NULL,
  `selling_area` int(100) NOT NULL,
  `bodega` int(100) NOT NULL,
  `sold_out` int(100) NOT NULL,
  `available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales_and_collection_entry`
--

CREATE TABLE `tbl_sales_and_collection_entry` (
  `sales_date_code` varchar(100) NOT NULL,
  `transaction_no` varchar(500) NOT NULL,
  `customer` varchar(500) NOT NULL,
  `period` varchar(500) NOT NULL,
  `sales_date` varchar(500) NOT NULL,
  `charge_account` decimal(65,2) NOT NULL,
  `settlemen/payment` decimal(65,2) NOT NULL,
  `aging_in_days` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales_and_expenses`
--

CREATE TABLE `tbl_sales_and_expenses` (
  `sales_and_expenses_id` varchar(500) NOT NULL,
  `date` varchar(500) NOT NULL,
  `particular` varchar(500) NOT NULL,
  `cash_payment` decimal(65,2) NOT NULL,
  `check_payment` decimal(65,2) NOT NULL,
  `total_sales` decimal(65,2) NOT NULL,
  `total_expenses` decimal(65,2) NOT NULL,
  `net_sales` decimal(65,2) NOT NULL,
  `coding_agent` varchar(500) NOT NULL,
  `gross_percent` varchar(100) NOT NULL,
  `possible_g-incomming` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sales_and_expenses`
--

INSERT INTO `tbl_sales_and_expenses` (`sales_and_expenses_id`, `date`, `particular`, `cash_payment`, `check_payment`, `total_sales`, `total_expenses`, `net_sales`, `coding_agent`, `gross_percent`, `possible_g-incomming`) VALUES
('SEID001', '27-Oct-10', 'via hinatuan', '69615.00', '61956.00', '131571.00', '3213.00', '128358.00', 'JT', '15', '19253.70'),
('SEID002', '30-Oct-10', 'via claver', '46029.25', '0.00', '46029.25', '1700.00', '44329.25', 'JT', '15', '6649.39'),
('SEID003', '31-Oct-17', 'via tungao', '2191.25', '13343.00', '1200.00', '1200.00', '14334.25', 'JT', '15', '2150.14'),
('SEID004', '31-Oct-17', 'via balingasag', '60568.00', '15423.00', '75991.00', '4840.00', '71151.00', 'JT', '15', '10672.65'),
('SEID005', '31-Oct-17', 'via claver', '30088.00', '0.00', '30088.00', '1745.00', '28343.00', 'JT', '15', '4251.45');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier_list`
--

CREATE TABLE `tbl_supplier_list` (
  `supplier_id` varchar(500) NOT NULL,
  `supplier_name` varchar(500) NOT NULL,
  `term` varchar(500) NOT NULL,
  `tin_number` varchar(500) NOT NULL,
  `address` varchar(500) NOT NULL,
  `contact_person` varchar(500) NOT NULL,
  `contact_number` varchar(500) NOT NULL,
  `email_address` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
