CREATE DATABASE DB_WEBFORM
GO

USE DB_WEBFORM
GO

CREATE TABLE ROLES(
ID_R INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NAME VARCHAR(20) UNIQUE NOT NULL
);
GO

CREATE TABLE USERS(
ID_U INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
_USER VARCHAR(20) NOT NULL,
PASS VARCHAR(8) NOT NULL,
ID_R INT NOT NULL,
FOREIGN KEY (ID_R) REFERENCES ROLES(ID_R)
);
GO

CREATE PROCEDURE VALIDATION_USER
@USER VARCHAR(20), 
@PASS VARCHAR(8)
AS
BEGIN
	SELECT ID_R FROM USERS WHERE _USER = @USER AND PASS = @PASS
END
GO

EXECUTE VALIDATION_USER

CREATE PROCEDURE ADD_ROLES
@NAME VARCHAR(20)
AS
BEGIN
	INSERT INTO ROLES VALUES (@NAME);
END 
GO

EXECUTE ADD_ROLES 'GERENTE';

CREATE PROCEDURE UPDATE_ROLES
@ID_R INT,
@NAME VARCHAR(20)
AS
BEGIN
	UPDATE ROLES 
	SET NAME=@NAME
	WHERE ID_R=@ID_R
END 
GO

EXECUTE UPDATE_ROLES 2,'ADMINISTRADOR';

CREATE PROCEDURE DELETE_ROLES
@NAME VARCHAR(20)
AS
BEGIN
	DELETE FROM ROLES WHERE NAME= @NAME
END
GO

EXECUTE DELETE_ROLES 'ADMINISTRADOR';

select * from roles