--SQL Script History:
-----------------------------------------------------------
--Description:
-- The following SQL's statements are used to create tables that is created newly or have some update on already existing tables.
-- The following SQL's create a DB_GetSkills_VEL database, and create the following 13 tables with primary key, foreign key:
-- 1) topic`, 2) subject, 3) course, 4) course_price, 5) users_permission, 6) permissions, 7) user, 8)success_category, 9) orders
-- 10) success_story, 11) success_story_course, 12) contact_us, 13) board.
-- Author Name: Vasanth Boraiyan
-- Create Date: 29-08-2015
--
--
-- Update History:
-- S.No.		Update Date 	Reason for Update									 							Author
-- 	   1		31-08-2015    	The name of the table`permission` table is reserved word, changed to 			Vasanth Boraiyan
--								`permissions`.													                  
--																	
--	   2		31-08-2015		To remove the mistake in `course_price` table,Two primary keys defined, 		Vasanth Boraiyan
--								that is made to 1.
--
--     3		31-08-2015	    Additional keys defined(`subject_id`, `topic_id`) included in the 				Vasanth Boraiyan
--								table `course'.
--
--     4		31-08-2015	   Additional keys defined(`course_id`,grade_id) in `course_price` table.			Vasanth Boraiyan
--
--	   5		31-08-2015	   `users_permission_id` column added in `users_permission`. this is created to 	Vasanth Boraiyan
--								maintain the consistency followed in the table design. 	
--		
--	   6 	    31-08-2015      `users` table 'users_type` is used, so changed to `users_permission_id` as 		Vasanth Boraiyan
--							     that is the primary key of the table `users_permission`
--
--     7		31-08-2015		`category_id` column is defined as KEY in the table `success_category`.			Vasanth Boraiyan
--
--	   8		31-08-2015		In `orders' table `order_id` is defined as primary key.							Vasanth Boraiyan
--
--
-- Table structure for table `courses`
--
DROP DATABASE IF EXISTS `DB_GetSkills_VEL`;
CREATE DATABASE `DB_GetSkill_VEL`;
USE `DB_GetSkill_VEL`;
-- --------------------------------------------------------
--
-- Table structure for table `topics`
--
 DROP TABLE IF EXISTS `topic` ;
CREATE TABLE `topic` (
  `topic_id` int(11) NOT NULL auto_increment,
  `topic_name` varchar(150) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`topic_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;
 
 -- --------------------------------------------------------
--
-- Table structure for table `subject`
--
DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject` (
  `subject_id` int(11) NOT NULL auto_increment,
  `subject_name` varchar(50) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`subject_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=66 ;
 -- --------------------------------------------------------
--
-- Table structure for table `course`
--
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `course_id` int(11) NOT NULL auto_increment,
  `course_name` varchar(50) default NULL,
  `course_code` varchar(60) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `topic_id` int(11) NOT NULL,
  `description` varchar(500) NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`course_id`),
  KEY (`subject_id`, `topic_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=67 ;


-- --------------------------------------------------------
--
-- Table structure for table `course_price`
--
 DROP TABLE IF EXISTS `course_price` ;
CREATE TABLE `course_price` (
  `course_price_id` int(11) NOT NULL auto_increment,
  `course_id` int(11) NOT NULL,
  `grade_id` int(11) NOT NULL,
  `price_per_hour` int(3) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`course_price_id`),
  KEY(`course_id`,grade_id)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------
--
-- Table structure for table `users_permissions`
--
 DROP TABLE IF EXISTS `users_permission`  ;
CREATE TABLE `users_permission` (
  `users_permission_id` int(11) NOT NULL auto_increment,
  `user_type` char(1) NOT NULL COMMENT 'a - Admin, m - Manager, t - Teacher, s - Student',
  `permission_id` int(11) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY(`users_permission_id`),
  KEY (`permission_id`)
 )ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8;
-- --------------------------------------------------------
--
-- Table structure for table `permissions`
--
 DROP TABLE IF EXISTS `permissions`;
CREATE TABLE `permissions` (
  `permission_id` int(11) NOT NULL auto_increment,
  `module_name` varchar(50) NOT NULL,
  `file_names` varchar(80) NOT NULL,
  `permission_order` int(11) NOT NULL default '0',
   `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`permission_id`),
  KEY (`permission_order`)
  ) ENGINE=InnoDB   DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------
--
-- Table structure for table `users`
--
 DROP TABLE IF EXISTS `users`  ;
CREATE TABLE `users` (
  `user_id` int(11) NOT NULL auto_increment,
  `user_name` varchar(50) NOT NULL,
  `users_pswd` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email_address` varchar(100) NOT NULL,
  `users_type` char(1) NOT NULL COMMENT 'a - Admin, m - Manager, t - Teacher, s - Student',
  `student_status` int(11) NOT NULL default '1' COMMENT '1-free, 2-scheduled',
  `isAuthenticated` int(11) NOT NULL default '0' COMMENT '0-Not Athenticated, 1- Authenticated',
  `approved` int(11) NOT NULL default '1' COMMENT '1- Approved, 0-Not Approved',
  `created_on` date NOT NULL,
  `updated_on` date NOT NULL,
  `lastLoginAt` date NOT NULL,
  `fb_id` varchar(100) default NULL,
  `signup_source` int(11) NOT NULL default '1' COMMENT '1- Site, 2-Facebook',
  `status` int(1) NOT NULL default '1'  COMMENT '1- Active, 0- Inactive',
  PRIMARY KEY  (`user_id`),
  KEY `user_type` (`users_type`,`status`)
  ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=611 ;

-- --------------------------------------------------------
--
-- Table structure for table `success_category`
--
DROP TABLE IF EXISTS `success_category`  ;
CREATE TABLE `success_category` (
	`success_category_id` INT(11) NOT NULL auto_increment,
	`category_id` INT(11),
	`category_name` varchar(100),
	`status` int(1) NOT NULL default '1',
	PRIMARY KEY (`success_category_id`),
	KEY `category_id` (`category_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

-- --------------------------------------------------------
--
-- Table structure for table `orders`
--
DROP TABLE IF EXISTS `orders`  ;
CREATE TABLE `orders` (
	`order_id`	INT(11)  NOT NULL auto_increment,
	`order_name` varchar(100),
	`order_date` DATE,
	`status` int(1) NOT NULL default '1',
	PRIMARY KEY (`order_id`)
)ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;	
-- --------------------------------------------------------
--
-- Table structure for table `success_story`
--
DROP TABLE IF EXISTS `success_story`  ;
CREATE TABLE `success_story` (
	`success_story_id` int(11) NOT NULL auto_increment,
	`user_name` varchar(100),
	`photo` varchar(100) NOT NULL,
	`providing_category` varchar(100),
	`sort_number` int(11),
	`breif_story` varchar(200),
	`detail_story` varchar(1000),
	`order_order_id` int(11),
	`success_category_category_id` int(11),
	`status` int(1) NOT NULL default '1',
	PRIMARY KEY (`success_story_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;	

-- --------------------------------------------------------
--
-- Table structure for table `success_story_course`
--
DROP TABLE IF EXISTS `success_story_course`  ;
CREATE TABLE `success_story_course` (
	`success_story_course_id` INT(11) NOT NULL auto_increment,
	`course_id` int(11),
	`success_story_id` int(11),
	`status` int(1) NOT NULL default '1',
	PRIMARY KEY (`success_story_course_id`),
	KEY(`course_id`,`success_story_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;	
-- --------------------------------------------------------
-- --------------------------------------------------------
--
-- Table structure for table `contact_us`
--
 DROP TABLE IF EXISTS `contact_us`  ;
CREATE TABLE `contact_us` (
  `contact_us_id` int(11) NOT NULL auto_increment,
  `email_address` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `message` varchar(1500) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`contact_us_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;
--
-- Table structure for table `board`
--
 DROP TABLE IF EXISTS `board`  ;
CREATE TABLE `board` (
  `board_id` int(11) NOT NULL auto_increment,
  `board_name` varchar(50) NOT NULL,
  `status` int(1) NOT NULL default '1',
  PRIMARY KEY  (`board_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;
-- --------------------------------------------------------	