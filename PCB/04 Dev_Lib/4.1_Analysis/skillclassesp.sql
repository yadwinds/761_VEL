-- phpMyAdmin SQL Dump
-- version 2.11.11.3
-- http://www.phpmyadmin.net
--
-- Host: 182.50.133.53
-- Generation Time: Aug 18, 2015 at 11:54 PM
-- Server version: 5.0.96
-- PHP Version: 5.1.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `skillclassesp`
--

-- --------------------------------------------------------

--
-- Table structure for table `board`
--

CREATE TABLE `board` (
  `board_id` int(11) NOT NULL auto_increment,
  `board_name` varchar(50) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`board_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `class_id` int(11) NOT NULL auto_increment,
  `class_session_code` varchar(20) NOT NULL,
  `class_title` varchar(100) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `description` text NOT NULL,
  `date` date NOT NULL,
  `time` varchar(14) NOT NULL,
  `total_users` int(11) NOT NULL,
  `duration` int(11) NOT NULL,
  `teacher_id` int(11) default NULL,
  `teacher_name` varchar(80) NOT NULL,
  `presenter_url` varchar(255) NOT NULL,
  `recording_url` varchar(255) NOT NULL,
  `session_status` int(11) NOT NULL default '1' COMMENT '1- Pending, 2- inProgress, 3- Done, 4- Expired',
  `common_attendee_url` varchar(255) default NULL,
  `review_session_url` varchar(255) default NULL,
  `startingtimestamp` varchar(300) NOT NULL,
  `endingtimestamp` varchar(300) NOT NULL,
  PRIMARY KEY  (`class_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=406 ;

-- --------------------------------------------------------

--
-- Table structure for table `class_students`
--

CREATE TABLE `class_students` (
  `class_session_code` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `student_name` varchar(80) NOT NULL,
  `attendee_id` varchar(100) NOT NULL,
  `attendee_url` varchar(255) NOT NULL,
  `email` varchar(200) NOT NULL,
  `fname` varchar(200) NOT NULL,
  `lname` varchar(200) NOT NULL,
  `stream` varchar(200) NOT NULL,
  `pno` varchar(200) NOT NULL,
  `date` varchar(200) NOT NULL,
  `time` varchar(14) NOT NULL,
  `duration` int(11) NOT NULL,
  `startingtimestamp` varchar(300) NOT NULL,
  `endingtimestamp` varchar(300) NOT NULL,
  `status` int(11) NOT NULL default '1'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `client_details`
--

CREATE TABLE `client_details` (
  `id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `company_name` varchar(200) NOT NULL,
  `description` varchar(1000) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `pno` varchar(100) NOT NULL,
  `address` varchar(500) NOT NULL,
  `password` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

-- --------------------------------------------------------

--
-- Table structure for table `contact_us`
--

CREATE TABLE `contact_us` (
  `id` int(11) NOT NULL auto_increment,
  `email_address` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `message` varchar(1500) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

-- --------------------------------------------------------

--
-- Table structure for table `content`
--

CREATE TABLE `content` (
  `contentid` int(11) NOT NULL auto_increment,
  `filename` varchar(500) NOT NULL,
  `subject` varchar(200) NOT NULL,
  `description` varchar(1000) NOT NULL,
  `upload_date` timestamp NOT NULL default CURRENT_TIMESTAMP,
  `uploadedby` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`contentid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` int(11) NOT NULL auto_increment,
  `course_name` varchar(50) default NULL,
  `course_code` varchar(60) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `topic_id` int(11) NOT NULL,
  `description` varchar(500) NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `status` int(11) default '1',
  PRIMARY KEY  (`course_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=67 ;

-- --------------------------------------------------------

--
-- Table structure for table `course_price`
--

CREATE TABLE `course_price` (
  `price_id` int(11) NOT NULL auto_increment,
  `grade_id` int(11) NOT NULL,
  `price_per_hour` int(3) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`price_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `demo_requests`
--

CREATE TABLE `demo_requests` (
  `id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `address` varchar(150) NOT NULL,
  `subject` varchar(20) NOT NULL,
  `date` varchar(20) NOT NULL,
  `time` varchar(20) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

-- --------------------------------------------------------

--
-- Table structure for table `emails`
--

CREATE TABLE `emails` (
  `emailid` int(11) NOT NULL auto_increment,
  `subject` varchar(250) NOT NULL,
  `message` varchar(1500) NOT NULL,
  `from_userid` int(11) NOT NULL,
  `read` int(11) NOT NULL default '0',
  `status` int(11) NOT NULL default '1',
  `datetime` datetime NOT NULL,
  PRIMARY KEY  (`emailid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=93 ;

-- --------------------------------------------------------

--
-- Table structure for table `email_group_contacts`
--

CREATE TABLE `email_group_contacts` (
  `id` int(100) NOT NULL auto_increment,
  `groupname` varchar(200) NOT NULL,
  `addemail` varchar(200) NOT NULL,
  `username` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1221 ;

-- --------------------------------------------------------

--
-- Table structure for table `grade`
--

CREATE TABLE `grade` (
  `grade_id` int(11) NOT NULL auto_increment,
  `grade_name` varchar(50) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`grade_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `interviews`
--

CREATE TABLE `interviews` (
  `interview_id` int(11) NOT NULL auto_increment,
  `class_session_code` varchar(20) NOT NULL,
  `class_title` varchar(100) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `message` text NOT NULL,
  `date` date NOT NULL,
  `time` varchar(14) NOT NULL,
  `total_users` int(11) NOT NULL,
  `duration` int(11) NOT NULL,
  `client_id` int(11) default NULL,
  `client_name` varchar(80) NOT NULL,
  `client_url` varchar(255) NOT NULL,
  `recording_url` varchar(255) NOT NULL,
  `session_status` int(11) NOT NULL default '1' COMMENT '1- Pending, 2- inProgress, 3- Done, 4- Expired',
  `startingtimestamp` varchar(300) NOT NULL,
  `endingtimestamp` varchar(300) NOT NULL,
  PRIMARY KEY  (`interview_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=138 ;

-- --------------------------------------------------------

--
-- Table structure for table `interview_schedules`
--

CREATE TABLE `interview_schedules` (
  `id` int(11) NOT NULL auto_increment,
  `client_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `time` varchar(20) NOT NULL,
  `message` varchar(1500) NOT NULL,
  `isAccepted` int(11) NOT NULL default '0',
  `mode` int(11) NOT NULL COMMENT '1-Telephonic, 2-Face to Face',
  `class_session_code` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=79 ;

-- --------------------------------------------------------

--
-- Table structure for table `interview_students`
--

CREATE TABLE `interview_students` (
  `class_session_code` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `student_name` varchar(80) NOT NULL,
  `attendee_id` varchar(100) NOT NULL,
  `attendee_url` varchar(255) NOT NULL,
  `date` varchar(200) NOT NULL,
  `time` varchar(14) NOT NULL,
  `duration` int(11) NOT NULL,
  `startingtimestamp` varchar(300) NOT NULL,
  `endingtimestamp` varchar(300) NOT NULL,
  `status` int(11) NOT NULL default '1'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `manager_details`
--

CREATE TABLE `manager_details` (
  `id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` char(1) NOT NULL default 'M' COMMENT 'M - Male, F - Female',
  `phone` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `city` varchar(30) NOT NULL,
  `state` varchar(30) NOT NULL,
  `county` varchar(30) NOT NULL,
  `zipcode` varchar(10) NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `gender` (`gender`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Table structure for table `mapping`
--

CREATE TABLE `mapping` (
  `mapping_id` int(11) NOT NULL auto_increment,
  `board_id` int(11) NOT NULL,
  `grade_id` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`mapping_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `mapping_subjects`
--

CREATE TABLE `mapping_subjects` (
  `id` int(11) NOT NULL auto_increment,
  `mapping_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `isChecked` int(11) NOT NULL default '1',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

-- --------------------------------------------------------

--
-- Table structure for table `newemailgroups`
--

CREATE TABLE `newemailgroups` (
  `sno` int(10) NOT NULL auto_increment,
  `groupname` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  PRIMARY KEY  (`sno`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=149 ;

-- --------------------------------------------------------

--
-- Table structure for table `order_days`
--

CREATE TABLE `order_days` (
  `order_daysid` int(11) NOT NULL auto_increment,
  `order_id` int(11) NOT NULL,
  `day_id` int(11) NOT NULL,
  `from_time` time NOT NULL,
  `to_time` time NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`order_daysid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=85 ;

-- --------------------------------------------------------

--
-- Table structure for table `order_subjects`
--

CREATE TABLE `order_subjects` (
  `order_subjectid` int(11) NOT NULL auto_increment,
  `order_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`order_subjectid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=116 ;

-- --------------------------------------------------------

--
-- Table structure for table `payment_log`
--

CREATE TABLE `payment_log` (
  `payment_id` int(11) NOT NULL auto_increment,
  `course_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `amount` float NOT NULL,
  `txn_id` varchar(50) NOT NULL,
  `payment_status` int(11) NOT NULL default '1' COMMENT '1-Pending, 2-successful, 3- cancel',
  `datetime` datetime NOT NULL,
  PRIMARY KEY  (`payment_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=226 ;

-- --------------------------------------------------------

--
-- Table structure for table `permissions`
--

CREATE TABLE `permissions` (
  `permission_id` int(11) NOT NULL auto_increment,
  `module_name` varchar(50) NOT NULL,
  `file_name` varchar(80) NOT NULL,
  `permission_order` int(11) NOT NULL default '0',
  PRIMARY KEY  (`permission_id`),
  KEY `permission_order` (`permission_order`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Table structure for table `question_answers`
--

CREATE TABLE `question_answers` (
  `answerid` int(11) NOT NULL auto_increment,
  `questionid` int(11) NOT NULL,
  `answer` varchar(500) NOT NULL,
  `correct` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`answerid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=689 ;

-- --------------------------------------------------------

--
-- Table structure for table `specializations`
--

CREATE TABLE `specializations` (
  `id` int(11) NOT NULL auto_increment,
  `specialization` varchar(50) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_courses`
--

CREATE TABLE `student_courses` (
  `student_courses_id` int(11) NOT NULL auto_increment,
  `student_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`student_courses_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1336 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_details`
--

CREATE TABLE `student_details` (
  `id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `email` varchar(1000) NOT NULL COMMENT 'M - Male, F- Female',
  `fname` varchar(1000) NOT NULL,
  `lname` varchar(1000) NOT NULL,
  `stream` varchar(1000) NOT NULL,
  `pno` varchar(20) NOT NULL,
  `address` varchar(150) NOT NULL,
  `city` varchar(30) NOT NULL,
  `subjects` varchar(100) NOT NULL,
  `college` varchar(100) NOT NULL,
  `convenient_time` varchar(25) NOT NULL,
  `password` varchar(20) NOT NULL,
  `cv` varchar(100) NOT NULL,
  `specialization` int(11) NOT NULL,
  `total_exp` varchar(20) NOT NULL,
  `brief` varchar(500) NOT NULL,
  `pic` varchar(100) NOT NULL,
  `up` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=484 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_orders`
--

CREATE TABLE `student_orders` (
  `order_id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `totalhours` int(11) NOT NULL,
  `datetime` datetime NOT NULL,
  `grade_id` int(11) NOT NULL,
  `board_id` int(11) NOT NULL,
  `txnid` int(11) NOT NULL,
  `payment_status` int(11) NOT NULL default '1' COMMENT '-1pre-process,1-prnding, 2-successful, 3-error',
  `payment_type` int(11) NOT NULL default '1' COMMENT '1-Online, 2-Offline',
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`order_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=117 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_subject_details`
--

CREATE TABLE `student_subject_details` (
  `sub_id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `subject` varchar(80) NOT NULL,
  `code` char(10) NOT NULL,
  `teacher_assigned` int(11) NOT NULL,
  `attendence` float NOT NULL,
  PRIMARY KEY  (`sub_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `subject_id` int(11) NOT NULL auto_increment,
  `subject_name` varchar(50) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`subject_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=66 ;

-- --------------------------------------------------------

--
-- Table structure for table `teacher_details`
--

CREATE TABLE `teacher_details` (
  `id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL COMMENT 'M - Male, F- Female',
  `lname` varchar(20) NOT NULL,
  `mobileno` varchar(30) NOT NULL,
  `address` varchar(100) NOT NULL,
  `age` int(3) NOT NULL,
  `education` varchar(100) NOT NULL,
  `grade` varchar(30) NOT NULL,
  `subject` varchar(30) NOT NULL,
  `details` varchar(10000) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `gender` (`fname`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=49 ;

-- --------------------------------------------------------

--
-- Table structure for table `teacher_subject_details`
--

CREATE TABLE `teacher_subject_details` (
  `quali_id` int(11) NOT NULL auto_increment,
  `user_id` int(11) NOT NULL,
  `subjects` varchar(80) NOT NULL,
  `attendence` float NOT NULL,
  PRIMARY KEY  (`quali_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `teammembers`
--

CREATE TABLE `teammembers` (
  `teammember_id` int(11) NOT NULL auto_increment,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `designation` varchar(100) NOT NULL,
  `company` varchar(100) NOT NULL,
  `brief` varchar(500) NOT NULL,
  `linkedinprofile` varchar(500) NOT NULL,
  `mobile` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`teammember_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

-- --------------------------------------------------------

--
-- Table structure for table `tests`
--

CREATE TABLE `tests` (
  `testid` int(11) NOT NULL auto_increment,
  `currentid` int(11) NOT NULL,
  `testcode` varchar(10) default NULL,
  `testname` varchar(50) NOT NULL,
  `description` varchar(500) default NULL,
  `subjectid` int(11) NOT NULL,
  `topicid` int(11) NOT NULL,
  `datecreated` datetime NOT NULL,
  `ispublished` int(11) NOT NULL default '0',
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`testid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=19 ;

-- --------------------------------------------------------

--
-- Table structure for table `test_attempts`
--

CREATE TABLE `test_attempts` (
  `attemptid` int(11) NOT NULL auto_increment,
  `userid` int(11) NOT NULL,
  `session_id` varchar(100) NOT NULL,
  `testid` int(11) NOT NULL,
  `datetime` datetime NOT NULL,
  `score` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`attemptid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=632 ;

-- --------------------------------------------------------

--
-- Table structure for table `test_attempt_details`
--

CREATE TABLE `test_attempt_details` (
  `attemptdetailsid` int(11) NOT NULL auto_increment,
  `attemptid` int(11) NOT NULL,
  `questionid` int(11) NOT NULL,
  `answerid` int(11) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`attemptdetailsid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5086 ;

-- --------------------------------------------------------

--
-- Table structure for table `test_questions`
--

CREATE TABLE `test_questions` (
  `questionid` int(11) NOT NULL auto_increment,
  `testid` int(11) NOT NULL,
  `question` varchar(500) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`questionid`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=156 ;

-- --------------------------------------------------------

--
-- Table structure for table `topics`
--

CREATE TABLE `topics` (
  `topic_id` int(11) NOT NULL auto_increment,
  `topic` varchar(150) NOT NULL,
  `status` int(11) NOT NULL default '1',
  PRIMARY KEY  (`topic_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

-- --------------------------------------------------------

--
-- Table structure for table `uploadtest`
--

CREATE TABLE `uploadtest` (
  `id` int(100) NOT NULL auto_increment,
  `testno` varchar(600) NOT NULL,
  `ques` varchar(1600) NOT NULL,
  `option1` varchar(1600) NOT NULL,
  `option2` varchar(1600) NOT NULL,
  `option3` varchar(1600) NOT NULL,
  `option4` varchar(1600) NOT NULL,
  `answer` varchar(1600) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL auto_increment,
  `user_name` varchar(50) NOT NULL,
  `user_pswd` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email_address` varchar(100) NOT NULL,
  `user_type` char(1) NOT NULL COMMENT 'a - Admin, m - Manager, t - Teacher, s - Student',
  `status` char(1) NOT NULL default '1' COMMENT '1- Active, 0- Inactive',
  `student_status` int(11) NOT NULL default '1' COMMENT '1-free, 2-scheduled',
  `isAuthenticated` int(11) NOT NULL default '0' COMMENT '0-Not Athenticated, 1- Authenticated',
  `approved` int(11) NOT NULL default '1' COMMENT '1- Approved, 0-Not Approved',
  `created_on` date NOT NULL,
  `updated_on` date NOT NULL,
  `lastLoginAt` date NOT NULL,
  `fb_id` varchar(100) default NULL,
  `signup_source` int(11) NOT NULL default '1' COMMENT '1- Site, 2-Facebook',
  PRIMARY KEY  (`user_id`),
  KEY `user_type` (`user_type`,`status`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=611 ;

-- --------------------------------------------------------

--
-- Table structure for table `users_permissions`
--

CREATE TABLE `users_permissions` (
  `user_type` char(1) NOT NULL COMMENT 'a - Admin, m - Manager, t - Teacher, s - Student',
  `permission_id` int(11) NOT NULL,
  KEY `user_id` (`user_type`,`permission_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_emails`
--

CREATE TABLE `user_emails` (
  `id` int(11) NOT NULL auto_increment,
  `emailid` int(11) NOT NULL,
  `subject` varchar(250) NOT NULL,
  `message` varchar(1500) NOT NULL,
  `to_userid` int(11) NOT NULL,
  `email_read` int(11) NOT NULL default '0',
  `status` int(11) NOT NULL default '1',
  `datetime` datetime NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=93 ;

-- --------------------------------------------------------

--
-- Table structure for table `videos`
--

CREATE TABLE `videos` (
  `id` int(11) NOT NULL auto_increment,
  `video` varchar(255) NOT NULL,
  `status` tinyint(1) NOT NULL,
  `time` bigint(20) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;
