USE PD2Movies
GO

CREATE TABLE HistoryArchive(
	User_id INT NOT NULL,
	Film_id INT NOT NULL,
	Date DATETIME NOT NULL,
	PRIMARY KEY(User_id, Film_id, Date)
)

ALTER TABLE Films
	ADD ViewsCnt NUMERIC NOT NULL DEFAULT 0
;
GO

/* SP ArchiveHistory */
CREATE PROCEDURE ArchiveHistory (@DaysCount INT) AS
BEGIN
	SET NOCOUNT OFF;

	DECLARE @FilmID as INT;
	DECLARE Film_Cursor CURSOR FOR SELECT id FROM Films ORDER BY id ASC;
	OPEN Film_Cursor;

	FETCH NEXT FROM Film_Cursor INTO @FilmID;
	WHILE @@FETCH_STATUS = 0
	BEGIN  
		DELETE FROM History
		OUTPUT DELETED.User_id, DELETED.Film_id, DELETED.[Date] INTO HistoryArchive
		WHERE Film_id = @FilmID AND DATEDIFF(day, Date, GETDATE()) > @DaysCount;

		UPDATE Films SET ViewsCnt = ViewsCnt + @@ROWCOUNT WHERE id = @FilmID;

		FETCH NEXT FROM Film_Cursor INTO @FilmID;
	END;  
	
	CLOSE Film_Cursor;  
	DEALLOCATE Film_Cursor;  
END
GO
