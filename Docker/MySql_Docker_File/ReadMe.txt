docker exec -it nameofcontainer mysql -uroot -p

update mysql.user set host = '%' where user='root';

https://stackoverflow.com/questions/33827342/how-to-connect-mysql-workbench-to-running-mysql-inside-docker