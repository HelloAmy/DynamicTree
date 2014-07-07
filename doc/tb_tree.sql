/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50614
Source Host           : localhost:3306
Source Database       : amydb

Target Server Type    : MYSQL
Target Server Version : 50614
File Encoding         : 65001

Date: 2014-07-04 14:04:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tb_tree`
-- ----------------------------
DROP TABLE IF EXISTS `tb_tree`;
CREATE TABLE `tb_tree` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '',
  `pid` int(11) DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_tree
-- ----------------------------
INSERT INTO `tb_tree` VALUES ('1', '书籍', null, '0');
INSERT INTO `tb_tree` VALUES ('2', '日常用品', null, '0');
INSERT INTO `tb_tree` VALUES ('3', '牙膏', '2', '1');
INSERT INTO `tb_tree` VALUES ('4', '牙刷', '2', '1');
INSERT INTO `tb_tree` VALUES ('5', '操作系统', '1', '1');
INSERT INTO `tb_tree` VALUES ('6', '学科类型', null, '0');
INSERT INTO `tb_tree` VALUES ('7', '自然学科', '6', '1');
INSERT INTO `tb_tree` VALUES ('8', '操作系统原理', '5', '2');
INSERT INTO `tb_tree` VALUES ('9', 'Linux操作系统', '5', '2');
INSERT INTO `tb_tree` VALUES ('10', 'windows操作系统', '5', '2');
