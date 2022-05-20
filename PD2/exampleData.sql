USE PD2Movies
GO

/* Movie genres */
SET IDENTITY_INSERT Genres ON;
INSERT INTO Genres (id, Name) VALUES
	(1, 'Action'),
	(2, 'Comedy'),
	(3, 'Science fiction')
;
SET IDENTITY_INSERT Genres OFF;

/* Creators */
SET IDENTITY_INSERT Creators ON;
INSERT INTO Creators (id, Pseudonym) VALUES
	(1, 'Creator 1'),
	(2, 'Creator 2'),
	(3, 'Creator 3')
;
SET IDENTITY_INSERT Creators OFF;

/* Channels */
INSERT INTO Channels (Creator_id, Name) VALUES
	(1, 'Channel no.1'),
	(2, 'The Best Channel'),
	(2, 'My new channel')
;

/* Users */
SET IDENTITY_INSERT Users ON;
INSERT INTO Users (id, Pseudonym, Email) VALUES
	(1, 'blabla228', 'example@mail.com'),
	(2, 'BestUserEver', 'bestuserever@mail.org'),
	(3, 'MyNewNick', 'game@mail.uk')
;
SET IDENTITY_INSERT Users OFF;
GO

INSERT INTO Channel_User (Channel_id, User_id) VALUES
	(1, 1),
	(1, 2),
	(2, 2),
	(3, 2),
	(1, 3),
	(2, 3),
	(3, 3)
;
GO

CREATE PROCEDURE InsertExampleData AS
BEGIN
	SET NOCOUNT OFF;

	/* Films */
	DECLARE @ChannelID INT, @ChannelName VARCHAR(255);
	DECLARE Channel_Cursor CURSOR FOR SELECT id, Name FROM Channels ORDER BY id ASC;
	OPEN Channel_Cursor;

	FETCH NEXT FROM Channel_Cursor INTO @ChannelID, @ChannelName;
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		DECLARE @iCountFilm INT = 1;

		DECLARE @TitleVar VARCHAR(255);
		DECLARE @DurationVar INT;
		DECLARE @GenreIdVar INT;

		WHILE @iCountFilm < 4
		BEGIN
			SET @TitleVar = 'Film ' + CAST(@iCountFilm AS VARCHAR) + ' for channel "' + @ChannelName + '"';
			SET @DurationVar = RAND()*180+10;
			SET @GenreIdVar = RAND()*3+1;
			EXEC InsertFilm @Title = @TitleVar, @Duration = @DurationVar, @Channel_id = @ChannelID, @Genre_id = @GenreIdVar;

			SET @iCountFilm = @iCountFilm + 1;
		END;

		FETCH NEXT FROM Channel_Cursor INTO @ChannelID, @ChannelName;
	END;  
	
	CLOSE Channel_Cursor;  
	DEALLOCATE Channel_Cursor;  

	/* Film History */
	DECLARE @HistoryStartDate DateTime = DATEADD(YEAR, -1, GETDATE());

	DECLARE @FilmIDMin INT = (SELECT MIN(id) FROM Films);
	DECLARE @FilmIDMax INT = (SELECT MAX(id) FROM Films);

	DECLARE @iCountHistory INT = 0;
	WHILE @iCountHistory < 100
	BEGIN
		INSERT INTO History (User_id, Film_id, Date)
		VALUES (RAND()*3+1, RAND()*@FilmIDMax+@FilmIDMin, @HistoryStartDate);

		SET @HistoryStartDate = DATEADD(DAY, RAND()*4+1, @HistoryStartDate);
		SET @HistoryStartDate = DATEADD(MINUTE, RAND()*500+1, @HistoryStartDate);

		SET @iCountHistory = @iCountHistory + 1;
	END;
END
GO

EXECUTE InsertExampleData;
GO

DROP PROCEDURE InsertExampleData;
GO

/* Update selected table */
UPDATE Creators SET Pseudonym = 'Creator no.1' WHERE id = 1;
UPDATE Creators SET Pseudonym = 'Creator no.2' WHERE id = 2;
UPDATE Creators SET Pseudonym = 'Creator no.3' WHERE id = 3;
GO
