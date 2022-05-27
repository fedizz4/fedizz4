CREATE USER 'app_sam'@'%' IDENTIFIED BY 'pwdInactif';
GRANT USAGE ON *.* TO 'app_sam'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'app_sam'@'%';